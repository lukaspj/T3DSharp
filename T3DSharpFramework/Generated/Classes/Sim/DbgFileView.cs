using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim {
    /// <summary>Remnant from ancient script debugger (TGE days?)</summary>
    /// <description>
    /// Possibly useful for an editor tooltip.
    /// </description>
    public class DbgFileView : GuiArrayCtrl {
        public DbgFileView(bool pRegister = false)
            : base(pRegister) {
        }

        public DbgFileView(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public DbgFileView(string pName)
            : this(pName, false) {
        }

        public DbgFileView(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public DbgFileView(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public DbgFileView(SimObject pObj)
            : base(pObj) {
        }

        public DbgFileView(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct FindString__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string findThis;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _FindString(IntPtr _this, FindString__Args args);
            private static _FindString _FindStringFunc;
            internal static _FindString FindString() {
               _FindStringFunc ??= Torque3D.LookupEngineFunction<_FindString>("fnDbgFileView_findString");

                return _FindStringFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveBreak__Args
            {
                internal uint line;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveBreak(IntPtr _this, RemoveBreak__Args args);
            private static _RemoveBreak _RemoveBreakFunc;
            internal static _RemoveBreak RemoveBreak() {
               _RemoveBreakFunc ??= Torque3D.LookupEngineFunction<_RemoveBreak>("fnDbgFileView_removeBreak");

                return _RemoveBreakFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBreak__Args
            {
                internal uint line;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBreak(IntPtr _this, SetBreak__Args args);
            private static _SetBreak _SetBreakFunc;
            internal static _SetBreak SetBreak() {
               _SetBreakFunc ??= Torque3D.LookupEngineFunction<_SetBreak>("fnDbgFileView_setBreak");

                return _SetBreakFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBreakPosition__Args
            {
                internal uint line;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBreakPosition(IntPtr _this, SetBreakPosition__Args args);
            private static _SetBreakPosition _SetBreakPositionFunc;
            internal static _SetBreakPosition SetBreakPosition() {
               _SetBreakPositionFunc ??= Torque3D.LookupEngineFunction<_SetBreakPosition>("fnDbgFileView_setBreakPosition");

                return _SetBreakPositionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearBreakPositions__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearBreakPositions(IntPtr _this, ClearBreakPositions__Args args);
            private static _ClearBreakPositions _ClearBreakPositionsFunc;
            internal static _ClearBreakPositions ClearBreakPositions() {
               _ClearBreakPositionsFunc ??= Torque3D.LookupEngineFunction<_ClearBreakPositions>("fnDbgFileView_clearBreakPositions");

                return _ClearBreakPositionsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Open__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Open(IntPtr _this, Open__Args args);
            private static _Open _OpenFunc;
            internal static _Open Open() {
               _OpenFunc ??= Torque3D.LookupEngineFunction<_Open>("fnDbgFileView_open");

                return _OpenFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentLine__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetCurrentLine(IntPtr _this, GetCurrentLine__Args args);
            private static _GetCurrentLine _GetCurrentLineFunc;
            internal static _GetCurrentLine GetCurrentLine() {
               _GetCurrentLineFunc ??= Torque3D.LookupEngineFunction<_GetCurrentLine>("fnDbgFileView_getCurrentLine");

                return _GetCurrentLineFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCurrentLine__Args
            {
                internal int line;
                [MarshalAs(UnmanagedType.I1)]
                internal bool selected;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCurrentLine(IntPtr _this, SetCurrentLine__Args args);
            private static _SetCurrentLine _SetCurrentLineFunc;
            internal static _SetCurrentLine SetCurrentLine() {
               _SetCurrentLineFunc ??= Torque3D.LookupEngineFunction<_SetCurrentLine>("fnDbgFileView_setCurrentLine");

                return _SetCurrentLineFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnDbgFileView_staticGetType");

                return _StaticGetTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Create__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Create(Create__Args args);
            private static _Create _CreateFunc;
            internal static _Create Create() {
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnDbgFileView_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// (string findThis)Find the specified string in the currently viewed file and scroll it into view.
        /// </description>
        public bool FindString(string findThis) {
             InternalUnsafeMethods.FindString__Args _args = new InternalUnsafeMethods.FindString__Args() {
                findThis = findThis,
             };
             bool _engineResult = InternalUnsafeMethods.FindString()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (int line)Remove a breakpoint from the specified line.
        /// </description>
        public void RemoveBreak(uint line) {
             InternalUnsafeMethods.RemoveBreak__Args _args = new InternalUnsafeMethods.RemoveBreak__Args() {
                line = line,
             };
             InternalUnsafeMethods.RemoveBreak()(ObjectPtr, _args);
        }

        /// <description>
        /// (int line)Set a breakpoint at the specified line.
        /// </description>
        public void SetBreak(uint line) {
             InternalUnsafeMethods.SetBreak__Args _args = new InternalUnsafeMethods.SetBreak__Args() {
                line = line,
             };
             InternalUnsafeMethods.SetBreak()(ObjectPtr, _args);
        }

        /// <description>
        /// (int line)Set a breakpoint at the specified line.
        /// </description>
        public void SetBreakPosition(uint line) {
             InternalUnsafeMethods.SetBreakPosition__Args _args = new InternalUnsafeMethods.SetBreakPosition__Args() {
                line = line,
             };
             InternalUnsafeMethods.SetBreakPosition()(ObjectPtr, _args);
        }

        /// <description>
        /// ()Clear all break points in the current file.
        /// </description>
        public void ClearBreakPositions() {
             InternalUnsafeMethods.ClearBreakPositions__Args _args = new InternalUnsafeMethods.ClearBreakPositions__Args() {
             };
             InternalUnsafeMethods.ClearBreakPositions()(ObjectPtr, _args);
        }

        /// <description>
        /// (string filename)Open a file for viewing.
        /// </description>
        /// <remarks> This loads the file from the local system.</remarks>
        public bool Open(string filename) {
             InternalUnsafeMethods.Open__Args _args = new InternalUnsafeMethods.Open__Args() {
                filename = filename,
             };
             bool _engineResult = InternalUnsafeMethods.Open()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ()Get the currently executing file and line, if any.
        /// </description>
        /// <returns>A string containing the file, a tab, and then the line number. Use getField() with this.</returns>
        public string GetCurrentLine() {
             InternalUnsafeMethods.GetCurrentLine__Args _args = new InternalUnsafeMethods.GetCurrentLine__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetCurrentLine()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (int line, bool selected)Set the current highlighted line.
        /// </description>
        public void SetCurrentLine(int line, bool selected) {
             InternalUnsafeMethods.SetCurrentLine__Args _args = new InternalUnsafeMethods.SetCurrentLine__Args() {
                line = line,
                selected = selected,
             };
             InternalUnsafeMethods.SetCurrentLine()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the DbgFileView class.
        /// </description>
        /// <returns>The type info object for DbgFileView</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
