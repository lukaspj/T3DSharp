using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;

namespace T3DSharpFramework.Interop {
   public static class Torque3D {
      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate string Exec(
         IntPtr nameSpace, IntPtr name, int argc, IntPtr argv, [MarshalAs(UnmanagedType.I1)] out bool result);

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate bool AddFunctionDelegate(IntPtr ns, IntPtr fnName, uint offset, IntPtr docstring);

      private static AddFunctionDelegate _AddFunction;

      public static AddFunctionDelegate AddFunction =>
         _AddFunction ??= (AddFunctionDelegate)Marshal.GetDelegateForFunctionPointer(
            NativeLibrary.GetExport(
               Torque3D.Torque3DLibHandle,
               "csharp_add_function"), typeof(AddFunctionDelegate));

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate void MainEntryPoint();

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate bool torque_engineinit(int argc, string[] argv);

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate int torque_enginetick();

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate bool torque_engineshutdown();

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate void SetCallbacks(IntPtr pExecPtr);

      public static string LibraryName;
      public static IntPtr Torque3DLibHandle;

      public static void Initialize(string[] args, Libraries libraryNames) {
         if (Platform.IsLinux()) {
            LibraryName = IntPtr.Size == 8 ? libraryNames.Linux64bit : libraryNames.Linux32bit;
         } else if (Platform.IsOSX()) {
            LibraryName = IntPtr.Size == 8 ? libraryNames.OSX64bit : libraryNames.OSX32bit;
         } else {
            LibraryName = IntPtr.Size == 8 ? libraryNames.Windows64bit : libraryNames.Windows32bit;
         }

         Torque3DLibHandle = NativeLibrary.Load(LibraryName);
         if (Torque3DLibHandle == IntPtr.Zero) {
            throw new Exception("Unable to load " + (IntPtr.Size == 8 ? "64" : "32") + " bit dll: " + LibraryName +
                                ", in directory: " + Directory.GetCurrentDirectory());
         }

         var setCallbacksHandle = NativeLibrary.GetExport(Torque3DLibHandle, "csharp_set_callbacks");
         var engineInitHandle = NativeLibrary.GetExport(Torque3DLibHandle, "torque_engineinit");
         var engineTickHandle = NativeLibrary.GetExport(Torque3DLibHandle, "torque_enginetick");
         var engineShutdownHandle = NativeLibrary.GetExport(Torque3DLibHandle, "torque_engineshutdown");


         var setCallbacks = (SetCallbacks)Marshal.GetDelegateForFunctionPointer(
            setCallbacksHandle, typeof(SetCallbacks));

         var engineInit = (torque_engineinit)Marshal.GetDelegateForFunctionPointer(
            engineInitHandle, typeof(torque_engineinit));

         var engineTick = (torque_enginetick)Marshal.GetDelegateForFunctionPointer(
            engineTickHandle, typeof(torque_enginetick));

         var engineShutdown = (torque_engineshutdown)Marshal.GetDelegateForFunctionPointer(
            engineShutdownHandle, typeof(torque_engineshutdown));

         Exec execDelegate = ExecDelegate;

         setCallbacks(Marshal.GetFunctionPointerForDelegate(execDelegate));

         if (!engineInit(args.Length, args)) return;

         foreach (var function in EngineCallbacks.GetFunctions()) {
            AddFunction(IntPtr.Zero, StringMarshal.Utf8StringToIntPtr(function.Key), 1, IntPtr.Zero);
         }

         foreach (var type in EngineCallbacks.GetTypes()) {
               type.Value
                  .GetMethods(BindingFlags.Default | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly |
                              BindingFlags.IgnoreCase)
                  .ToList()
                  .ForEach(cb =>
                     AddFunction(StringMarshal.Utf8StringToIntPtr(type.Key), StringMarshal.Utf8StringToIntPtr(cb.Name), 1, IntPtr.Zero));
         }

         Initializer.GetScriptEntry().Invoke(null, null);

         while (engineTick() > 0) { }

         SimDictionary.Shutdown();

         engineShutdown();

         SimDictionary.Shutdown();

         NativeLibrary.Free(Torque3DLibHandle);
      }

      public static string ExecDelegate(IntPtr nameSpace, IntPtr name, int argc, IntPtr argv, out bool result) {
         string _nameSpace = Marshal.PtrToStringAnsi(nameSpace);
         string _name = Marshal.PtrToStringAnsi(name);
         string[] strings = null;
         if (argv != IntPtr.Zero)
            strings = StringMarshal.IntPtrToAnsiStringArray(argv, argc);
         return EngineCallbacks.CallScriptFunction(_nameSpace, _name, strings, out result);
      }

      public struct Libraries {
         public string Linux32bit;
         public string Linux64bit;
         public string Windows32bit;
         public string Windows64bit;
         public string OSX32bit;
         public string OSX64bit;
      }
   }
}
