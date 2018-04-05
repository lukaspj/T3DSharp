﻿using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using T3DSharpFramework.Interop;

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
            
            Initializer.InitializeTypeDictionaries(Assembly.GetExecutingAssembly().GetTypes());
            Torque3D.Libraries libraries = new Torque3D.Libraries
            {
                Windows32bit = "Full_DEBUG.dll",
                Windows64bit = "Full_DEBUG.dll"
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
            
            StreamReader sr =
                new StreamReader("engineApi.xml");
            string content = sr.ReadToEnd();
            sr.Close();

            EngineApiParser.Parse(content);
        }
    }
}