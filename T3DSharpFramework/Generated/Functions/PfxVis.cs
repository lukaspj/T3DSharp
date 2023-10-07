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

    public static class PfxVis {

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnWindowClosed__Args
            {
                internal IntPtr ctrl;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnWindowClosed(OnWindowClosed__Args args);
            private static _OnWindowClosed _OnWindowClosedFunc;
            internal static _OnWindowClosed OnWindowClosed() {
               _OnWindowClosedFunc ??= Torque3D.LookupEngineFunction<_OnWindowClosed>("fnPfxVis_onWindowClosed");

                return _OnWindowClosedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Show__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Show(Show__Args args);
            private static _Show _ShowFunc;
            internal static _Show Show() {
               _ShowFunc ??= Torque3D.LookupEngineFunction<_Show>("fnPfxVis_show");

                return _ShowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Hide__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Hide(Hide__Args args);
            private static _Hide _HideFunc;
            internal static _Hide Hide() {
               _HideFunc ??= Torque3D.LookupEngineFunction<_Hide>("fnPfxVis_hide");

                return _HideFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Open__Args
            {
                internal IntPtr pfx;
                [MarshalAs(UnmanagedType.I1)]
                internal bool clear;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Open(Open__Args args);
            private static _Open _OpenFunc;
            internal static _Open Open() {
               _OpenFunc ??= Torque3D.LookupEngineFunction<_Open>("fnPfxVis_open");

                return _OpenFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Clear__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Clear(Clear__Args args);
            private static _Clear _ClearFunc;
            internal static _Clear Clear() {
               _ClearFunc ??= Torque3D.LookupEngineFunction<_Clear>("fnPfxVis_clear");

                return _ClearFunc;
            }

        }
        #endregion

        /// 
        public static void OnWindowClosed(GuiWindowCtrl ctrl) {
             InternalUnsafeMethods.OnWindowClosed__Args _args = new InternalUnsafeMethods.OnWindowClosed__Args() {
                ctrl = ctrl.ObjectPtr,
             };
             InternalUnsafeMethods.OnWindowClosed()(_args);
        }

        /// 
        public static void Show() {
             InternalUnsafeMethods.Show__Args _args = new InternalUnsafeMethods.Show__Args() {
             };
             InternalUnsafeMethods.Show()(_args);
        }

        /// 
        public static void Hide() {
             InternalUnsafeMethods.Hide__Args _args = new InternalUnsafeMethods.Hide__Args() {
             };
             InternalUnsafeMethods.Hide()(_args);
        }

        /// <description>
        /// ( PostEffect, [bool clear = false] )
        /// </description>
        public static void Open(PostEffect pfx, bool clear = false) {
             InternalUnsafeMethods.Open__Args _args = new InternalUnsafeMethods.Open__Args() {
                pfx = pfx.ObjectPtr,
                clear = clear,
             };
             InternalUnsafeMethods.Open()(_args);
        }

        /// 
        public static void Clear() {
             InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
             };
             InternalUnsafeMethods.Clear()(_args);
        }

    }
}
