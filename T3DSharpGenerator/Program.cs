using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using T3DSharpFramework.Interop;
using T3DSharpGenerator.DocGenerators;
using T3DSharpGenerator.DocParsers;
using T3DSharpGenerator.Generators;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator
{
    internal static class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr _eval([MarshalAs(UnmanagedType.LPStr)]string consoleString);
        private static _eval _evalFunc;
        internal static string eval(string consoleString)
        {
            if (_evalFunc == null)
            {
                _evalFunc =
                    (_eval)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                        "fneval"), typeof(_eval));
            }
         
            return  Marshal.PtrToStringUni(_evalFunc(consoleString));
        }
        
        public static void Main(string[] args) {
            
            CultureInfo customCulture =
                (CultureInfo) Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            Thread.CurrentThread.CurrentCulture = customCulture;

            if (File.Exists("engineApi.xml")) {
                ParseEngineApi();
                return;
            }
            
            Initializer.InitializeTypeDictionaries(Assembly.GetExecutingAssembly().GetTypes());
            Torque3D.Libraries libraries = new Torque3D.Libraries
            {
                Windows32bit = "BaseGame_DEBUG.dll",
                Windows64bit = "BaseGame_DEBUG.dll"
            };

            Torque3D.Initialize(args, libraries);
        }

        [ScriptEntryPoint]
        public static void Entry() {
            // --- Boilerplate C#-specific setup. Normally Torque uses the main.cs file to set these variables, here we have to do it ourselves.
            string CSDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).Replace('\\', '/');
            eval($"setMainDotCsDir(\"{CSDir}\");");
            eval($"setCurrentDirectory(\"{CSDir}\");");
            // ---

            eval("setLogMode(6);");
            
            Console.WriteLine(eval("exportEngineAPIToXML().saveFile(\"engineApi.xml\");"));
            
            eval("quit();");
            
            ParseEngineApi();
        }

        private static void ParseEngineApi() {
            StreamReader sr =
                new StreamReader("engineApi.xml");
            string content = sr.ReadToEnd();
            sr.Close();

            EngineApi engineApi = EngineApiParser.Parse(content);

            Console.WriteLine(engineApi.Enums.Count);
            Console.WriteLine(engineApi.Structs.Count);
            Console.WriteLine(engineApi.Functions.Count);
            Console.WriteLine(engineApi.Classes.Count);

            foreach (EngineStruct engineStruct in engineApi.Structs) {
                if (engineStruct.Fields.Count < 1) {
                    Console.WriteLine("No fields defined in struct: " + engineStruct.Name);
                }
            }

            if (Directory.Exists("Generated/")) {
                Directory.Delete("Generated/", true);
            }

            engineApi.Functions
                .ForEach(f => f.Docs = DotNetXmlDocGenerator.Generate(EngineApiDocStringParser.Parse(f.Docs)).Trim());
            
            EnumGenerator.GenerateFor(engineApi, engineApi.Enums);
            StructGenerator.GenerateFor(engineApi, engineApi.Structs);
            FunctionGenerator.GenerateFor(engineApi, engineApi.Functions);
            ClassGenerator.GenerateFor(engineApi, engineApi.Classes);
            PrimitiveSizesGenerator.GenerateFor(engineApi, engineApi.Primitives);
            Console.WriteLine("Finished code generation.");
        }
    }
}