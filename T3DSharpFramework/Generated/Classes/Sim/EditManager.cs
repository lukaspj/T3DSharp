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
    /// <summary>For Editor use only, deprecated</summary>
    /// <description>
    /// 
    /// </description>
    public class EditManager : GuiControl {
        public EditManager(bool pRegister = false)
            : base(pRegister) {
        }

        public EditManager(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public EditManager(string pName)
            : this(pName, false) {
        }

        public EditManager(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public EditManager(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public EditManager(SimObject pObj)
            : base(pObj) {
        }

        public EditManager(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct IsEditorEnabled__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsEditorEnabled(IntPtr _this, IsEditorEnabled__Args args);
            private static _IsEditorEnabled _IsEditorEnabledFunc;
            internal static _IsEditorEnabled IsEditorEnabled() {
               _IsEditorEnabledFunc ??= Torque3D.LookupEngineFunction<_IsEditorEnabled>("fnEditManager_isEditorEnabled");

                return _IsEditorEnabledFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct EditorDisabled__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _EditorDisabled(IntPtr _this, EditorDisabled__Args args);
            private static _EditorDisabled _EditorDisabledFunc;
            internal static _EditorDisabled EditorDisabled() {
               _EditorDisabledFunc ??= Torque3D.LookupEngineFunction<_EditorDisabled>("fnEditManager_editorDisabled");

                return _EditorDisabledFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct EditorEnabled__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _EditorEnabled(IntPtr _this, EditorEnabled__Args args);
            private static _EditorEnabled _EditorEnabledFunc;
            internal static _EditorEnabled EditorEnabled() {
               _EditorEnabledFunc ??= Torque3D.LookupEngineFunction<_EditorEnabled>("fnEditManager_editorEnabled");

                return _EditorEnabledFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GotoBookmark__Args
            {
                internal int val;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _GotoBookmark(IntPtr _this, GotoBookmark__Args args);
            private static _GotoBookmark _GotoBookmarkFunc;
            internal static _GotoBookmark GotoBookmark() {
               _GotoBookmarkFunc ??= Torque3D.LookupEngineFunction<_GotoBookmark>("fnEditManager_gotoBookmark");

                return _GotoBookmarkFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBookmark__Args
            {
                internal int val;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBookmark(IntPtr _this, SetBookmark__Args args);
            private static _SetBookmark _SetBookmarkFunc;
            internal static _SetBookmark SetBookmark() {
               _SetBookmarkFunc ??= Torque3D.LookupEngineFunction<_SetBookmark>("fnEditManager_setBookmark");

                return _SetBookmarkFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnEditManager_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnEditManager_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Return the value of gEditingMission.
        /// </description>
        public bool IsEditorEnabled() {
             InternalUnsafeMethods.IsEditorEnabled__Args _args = new InternalUnsafeMethods.IsEditorEnabled__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsEditorEnabled()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Perform the onEditorDisabled callback on all SimObjects and set gEditingMission false
        /// </description>
        public void EditorDisabled() {
             InternalUnsafeMethods.EditorDisabled__Args _args = new InternalUnsafeMethods.EditorDisabled__Args() {
             };
             InternalUnsafeMethods.EditorDisabled()(ObjectPtr, _args);
        }

        /// <description>
        /// Perform the onEditorEnabled callback on all SimObjects and set gEditingMission true
        /// </description>
        public void EditorEnabled() {
             InternalUnsafeMethods.EditorEnabled__Args _args = new InternalUnsafeMethods.EditorEnabled__Args() {
             };
             InternalUnsafeMethods.EditorEnabled()(ObjectPtr, _args);
        }

        /// <description>
        /// (int slot)
        /// </description>
        public void GotoBookmark(int val) {
             InternalUnsafeMethods.GotoBookmark__Args _args = new InternalUnsafeMethods.GotoBookmark__Args() {
                val = val,
             };
             InternalUnsafeMethods.GotoBookmark()(ObjectPtr, _args);
        }

        /// <description>
        /// (int slot)
        /// </description>
        public void SetBookmark(int val) {
             InternalUnsafeMethods.SetBookmark__Args _args = new InternalUnsafeMethods.SetBookmark__Args() {
                val = val,
             };
             InternalUnsafeMethods.SetBookmark()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the EditManager class.
        /// </description>
        /// <returns>The type info object for EditManager</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
