using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Modules.T3DSharpGenerator;
using T3DSharpFramework.Reloading;
using T3DSharpFramework.Generated.Functions;

namespace T3DSharpFramework.Interop {
   public static class Torque3D {
      private static MsBuildReloader _reloader;

      public delegate void AddFunctionDelegate(IntPtr pNamespace, IntPtr pFnName, uint pOffset, IntPtr pDocString);

      public static AddFunctionDelegate AddFunctionNative = null;

      public static void AddFunction(string pNamespace, string pFnName, uint pOffset = 1, string pDocString = null) {
         IntPtr namespacePtr = pNamespace == null ? IntPtr.Zero : StringMarshal.Utf8StringToIntPtr(pNamespace);
         IntPtr fnNamePtr = pFnName == null ? IntPtr.Zero : StringMarshal.Utf8StringToIntPtr(pFnName);
         IntPtr docstringPtr = pDocString == null ? IntPtr.Zero : StringMarshal.Utf8StringToIntPtr(pDocString);
         AddFunctionNative(namespacePtr, fnNamePtr, pOffset, docstringPtr);
         Marshal.FreeHGlobal(namespacePtr);
         Marshal.FreeHGlobal(fnNamePtr);
         Marshal.FreeHGlobal(docstringPtr);
      }

      public delegate IntPtr LookupEngineFunctionDelegate(IntPtr pFnName);

      public static LookupEngineFunctionDelegate LookupEngineFunctionNative = null;

      public static T LookupEngineFunction<T>(string pFnName) where T : Delegate {
         IntPtr fnNamePtr = pFnName == null ? IntPtr.Zero : StringMarshal.Utf8StringToIntPtr(pFnName);
         IntPtr result = LookupEngineFunctionNative(fnNamePtr);
         Marshal.FreeHGlobal(fnNamePtr);
         return (T)Marshal.GetDelegateForFunctionPointer(result, typeof(T));
      }

      [UnmanagedCallersOnly]
      public static void InitT3DSharp(IntPtr addFunction, IntPtr lookupEngineFunction) {
         CultureInfo customCulture =
            (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
         customCulture.NumberFormat.NumberDecimalSeparator = ".";

         Thread.CurrentThread.CurrentCulture = customCulture;

         AddFunctionNative = Marshal.GetDelegateForFunctionPointer<AddFunctionDelegate>(addFunction);
         LookupEngineFunctionNative =
            Marshal.GetDelegateForFunctionPointer<LookupEngineFunctionDelegate>(lookupEngineFunction);

         var cwd = Directory.GetCurrentDirectory();

         _reloader = new(CMakeSettings.SOLUTION_PATH, "T3DSharpGame");
         _reloader.AssemblyReloaded += (_, args) => {
            EngineCallbacks.Clear();
            Initializer.InitializeTypeDictionaries(args.NewAssembly.GetTypes());
         };
         _reloader.Start().GetAwaiter().GetResult();
         AddFunction(null, "ReloadT3DSharpGame");
         AddFunction(null, Initializer.GetScriptEntry().Name);

         foreach (var function in EngineCallbacks.GetFunctions()) {
            AddFunction(null, function.Key);
         }

         foreach (var type in EngineCallbacks.GetTypes()) {
            type.Value
               .GetMethods(BindingFlags.Default | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                           BindingFlags.DeclaredOnly |
                           BindingFlags.IgnoreCase)
               .ToList()
               .ForEach(cb =>
                  AddFunction(type.Key, cb.Name));
         }

         // --- Normally Torque uses the main.tscript file to set these variables, here we have to do it ourselves.
         string CSDir = Path.GetDirectoryName(AppContext.BaseDirectory)?.Replace('\\', '/');
         if (CSDir != null) {
            Global.SetMainDotCsDir(CSDir);
            Global.SetCurrentDirectory(CSDir);
         }
      }

      public static IEnumerable<Type[]> InitT3DScript(IntPtr lookupEngineFunction) {
         CultureInfo customCulture =
            (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
         customCulture.NumberFormat.NumberDecimalSeparator = ".";

         Thread.CurrentThread.CurrentCulture = customCulture;

         LookupEngineFunctionNative =
            Marshal.GetDelegateForFunctionPointer<LookupEngineFunctionDelegate>(lookupEngineFunction);

         Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
         return assemblies.Where(a =>
               a.FullName != null && !a.FullName.StartsWith("System") && !a.FullName.StartsWith("Microsoft") &&
               !a.FullName.Contains("T3DSharpFramework"))
            .Select(a => a.GetTypes());
      }

      [UnmanagedCallersOnly]
      public static unsafe IntPtr ExecConsoleFunction(IntPtr nameSpace, IntPtr name, int argc, IntPtr argv,
         bool* result) {
         string _nameSpace = Marshal.PtrToStringAnsi(nameSpace);
         string _name = Marshal.PtrToStringAnsi(name);
         string[] strings = null;
         if (argv != IntPtr.Zero)
            strings = StringMarshal.IntPtrToAnsiStringArray(argv, argc);

         if (_name == "ReloadT3DSharpGame") {
            _reloader.Reload().GetAwaiter().GetResult();
            return StringMarshal.Utf8StringToIntPtr("");
         }

         if (_name == Initializer.GetScriptEntry().Name) {
            Initializer.GetScriptEntry().Invoke(null, null);
            *result = true;
            return StringMarshal.Utf8StringToIntPtr("");
         }

         return StringMarshal.Utf8StringToIntPtr(
            EngineCallbacks.CallScriptFunction(_nameSpace, _name, strings, out *result));
      }
   }
}
