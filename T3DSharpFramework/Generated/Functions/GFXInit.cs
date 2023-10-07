using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Net;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Console;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Functions {

    public static class GFXInit {

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct CreateNullDevice__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CreateNullDevice(CreateNullDevice__Args args);
            private static _CreateNullDevice _CreateNullDeviceFunc;
            internal static _CreateNullDevice CreateNullDevice() {
               _CreateNullDeviceFunc ??= Torque3D.LookupEngineFunction<_CreateNullDevice>("fnGFXInit_createNullDevice");

                return _CreateNullDeviceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAdapterMode__Args
            {
                internal int index;
                internal int modeIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAdapterMode(GetAdapterMode__Args args);
            private static _GetAdapterMode _GetAdapterModeFunc;
            internal static _GetAdapterMode GetAdapterMode() {
               _GetAdapterModeFunc ??= Torque3D.LookupEngineFunction<_GetAdapterMode>("fnGFXInit_getAdapterMode");

                return _GetAdapterModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAdapterModeCount__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAdapterModeCount(GetAdapterModeCount__Args args);
            private static _GetAdapterModeCount _GetAdapterModeCountFunc;
            internal static _GetAdapterModeCount GetAdapterModeCount() {
               _GetAdapterModeCountFunc ??= Torque3D.LookupEngineFunction<_GetAdapterModeCount>("fnGFXInit_getAdapterModeCount");

                return _GetAdapterModeCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDefaultAdapterIndex__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDefaultAdapterIndex(GetDefaultAdapterIndex__Args args);
            private static _GetDefaultAdapterIndex _GetDefaultAdapterIndexFunc;
            internal static _GetDefaultAdapterIndex GetDefaultAdapterIndex() {
               _GetDefaultAdapterIndexFunc ??= Torque3D.LookupEngineFunction<_GetDefaultAdapterIndex>("fnGFXInit_getDefaultAdapterIndex");

                return _GetDefaultAdapterIndexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAdapterShaderModel__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetAdapterShaderModel(GetAdapterShaderModel__Args args);
            private static _GetAdapterShaderModel _GetAdapterShaderModelFunc;
            internal static _GetAdapterShaderModel GetAdapterShaderModel() {
               _GetAdapterShaderModelFunc ??= Torque3D.LookupEngineFunction<_GetAdapterShaderModel>("fnGFXInit_getAdapterShaderModel");

                return _GetAdapterShaderModelFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAdapterType__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAdapterType(GetAdapterType__Args args);
            private static _GetAdapterType _GetAdapterTypeFunc;
            internal static _GetAdapterType GetAdapterType() {
               _GetAdapterTypeFunc ??= Torque3D.LookupEngineFunction<_GetAdapterType>("fnGFXInit_getAdapterType");

                return _GetAdapterTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAdapterOutputName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAdapterOutputName(GetAdapterOutputName__Args args);
            private static _GetAdapterOutputName _GetAdapterOutputNameFunc;
            internal static _GetAdapterOutputName GetAdapterOutputName() {
               _GetAdapterOutputNameFunc ??= Torque3D.LookupEngineFunction<_GetAdapterOutputName>("fnGFXInit_getAdapterOutputName");

                return _GetAdapterOutputNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAdapterName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAdapterName(GetAdapterName__Args args);
            private static _GetAdapterName _GetAdapterNameFunc;
            internal static _GetAdapterName GetAdapterName() {
               _GetAdapterNameFunc ??= Torque3D.LookupEngineFunction<_GetAdapterName>("fnGFXInit_getAdapterName");

                return _GetAdapterNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAdapterCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAdapterCount(GetAdapterCount__Args args);
            private static _GetAdapterCount _GetAdapterCountFunc;
            internal static _GetAdapterCount GetAdapterCount() {
               _GetAdapterCountFunc ??= Torque3D.LookupEngineFunction<_GetAdapterCount>("fnGFXInit_getAdapterCount");

                return _GetAdapterCountFunc;
            }

        }
        #endregion

        /// <description>
        /// Create the NULL graphics device used for testing or headless operation.
        /// </description>
        public static void CreateNullDevice() {
             InternalUnsafeMethods.CreateNullDevice__Args _args = new InternalUnsafeMethods.CreateNullDevice__Args() {
             };
             InternalUnsafeMethods.CreateNullDevice()(_args);
        }

        /// <description>
        /// Gets the details of the specified adapter mode.
        /// </description>
        /// <param name="index">Index of the adapter to query.</param>
        /// <param name="modeIndex">Index of the mode to get data from.</param>
        /// <returns>A video mode string in the format 'width height fullscreen bitDepth refreshRate aaLevel'.</returns>
        /// <see cref="GuiCanvas::getVideoMode()" />
        public static string GetAdapterMode(int index, int modeIndex) {
             InternalUnsafeMethods.GetAdapterMode__Args _args = new InternalUnsafeMethods.GetAdapterMode__Args() {
                index = index,
                modeIndex = modeIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAdapterMode()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the number of modes available on the specified adapter.
        /// </description>
        /// <param name="index">Index of the adapter to get modes from.</param>
        /// <returns>The number of video modes supported by the adapter or -1 if the given adapter was not found.</returns>
        public static int GetAdapterModeCount(int index) {
             InternalUnsafeMethods.GetAdapterModeCount__Args _args = new InternalUnsafeMethods.GetAdapterModeCount__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetAdapterModeCount()(_args);
             return _engineResult;
        }

        /// <description>
        /// Returns the index of the default graphics adapter.  This is the graphics device which will be used to initialize the engine.
        /// </description>
        public static int GetDefaultAdapterIndex() {
             InternalUnsafeMethods.GetDefaultAdapterIndex__Args _args = new InternalUnsafeMethods.GetDefaultAdapterIndex__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetDefaultAdapterIndex()(_args);
             return _engineResult;
        }

        /// <description>
        /// Returns the supported shader model of the graphics adapter or -1 if the index is bad.
        /// </description>
        /// <param name="index">The index of the adapter.</param>
        public static float GetAdapterShaderModel(int index) {
             InternalUnsafeMethods.GetAdapterShaderModel__Args _args = new InternalUnsafeMethods.GetAdapterShaderModel__Args() {
                index = index,
             };
             float _engineResult = InternalUnsafeMethods.GetAdapterShaderModel()(_args);
             return _engineResult;
        }

        /// <description>
        /// Returns the type (D3D11, GL, Null) of a graphics adapter.
        /// </description>
        /// <param name="index">The index of the adapter.</param>
        public static GFXAdapterType GetAdapterType(int index) {
             InternalUnsafeMethods.GetAdapterType__Args _args = new InternalUnsafeMethods.GetAdapterType__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetAdapterType()(_args);
             return (GFXAdapterType)_engineResult;
        }

        /// <description>
        /// Returns the name of the graphics adapter's output display device.
        /// </description>
        /// <param name="index">The index of the adapter.</param>
        public static string GetAdapterOutputName(int index) {
             InternalUnsafeMethods.GetAdapterOutputName__Args _args = new InternalUnsafeMethods.GetAdapterOutputName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAdapterOutputName()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Returns the name of the graphics adapter.
        /// </description>
        /// <param name="index">The index of the adapter.</param>
        public static string GetAdapterName(int index) {
             InternalUnsafeMethods.GetAdapterName__Args _args = new InternalUnsafeMethods.GetAdapterName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAdapterName()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Return the number of graphics adapters available.
        /// </description>
        public static int GetAdapterCount() {
             InternalUnsafeMethods.GetAdapterCount__Args _args = new InternalUnsafeMethods.GetAdapterCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetAdapterCount()(_args);
             return _engineResult;
        }

    }
}
