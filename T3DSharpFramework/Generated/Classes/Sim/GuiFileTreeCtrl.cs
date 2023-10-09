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
    /// <summary>A control that displays a hierarchical tree view of a path in the game file system.</summary>
    /// <description>
    /// 
    /// </description>
    /// <remarks> Currently not used, most likely existed for editors. Possibly deprecated.
    /// 
    /// </remarks>
    public class GuiFileTreeCtrl : GuiTreeViewCtrl {
        public GuiFileTreeCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiFileTreeCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiFileTreeCtrl(string pName)
            : this(pName, false) {
        }

        public GuiFileTreeCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiFileTreeCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiFileTreeCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiFileTreeCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Reload__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reload(IntPtr _this, Reload__Args args);
            private static _Reload _ReloadFunc;
            internal static _Reload Reload() {
               _ReloadFunc ??= Torque3D.LookupEngineFunction<_Reload>("fnGuiFileTreeCtrl_reload");

                return _ReloadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedPath__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetSelectedPath(IntPtr _this, SetSelectedPath__Args args);
            private static _SetSelectedPath _SetSelectedPathFunc;
            internal static _SetSelectedPath SetSelectedPath() {
               _SetSelectedPathFunc ??= Torque3D.LookupEngineFunction<_SetSelectedPath>("fnGuiFileTreeCtrl_setSelectedPath");

                return _SetSelectedPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSelectedPath(IntPtr _this, GetSelectedPath__Args args);
            private static _GetSelectedPath _GetSelectedPathFunc;
            internal static _GetSelectedPath GetSelectedPath() {
               _GetSelectedPathFunc ??= Torque3D.LookupEngineFunction<_GetSelectedPath>("fnGuiFileTreeCtrl_getSelectedPath");

                return _GetSelectedPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiFileTreeCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiFileTreeCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// () - Reread the directory tree hierarchy.
        /// </description>
        public void Reload() {
             InternalUnsafeMethods.Reload__Args _args = new InternalUnsafeMethods.Reload__Args() {
             };
             InternalUnsafeMethods.Reload()(ObjectPtr, _args);
        }

        /// <description>
        /// setSelectedPath(path) - expands the tree to the specified path
        /// </description>
        public bool SetSelectedPath(string path) {
             InternalUnsafeMethods.SetSelectedPath__Args _args = new InternalUnsafeMethods.SetSelectedPath__Args() {
                path = path,
             };
             bool _engineResult = InternalUnsafeMethods.SetSelectedPath()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// getSelectedPath() - returns the currently selected path in the tree
        /// </description>
        public string GetSelectedPath() {
             InternalUnsafeMethods.GetSelectedPath__Args _args = new InternalUnsafeMethods.GetSelectedPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSelectedPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the GuiFileTreeCtrl class.
        /// </description>
        /// <returns>The type info object for GuiFileTreeCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Path in game directory that should be displayed in the control.
        /// </description>
        /// </value>
        public string RootPath {
            get => GenericMarshal.StringTo<string>(GetFieldValue("rootPath"));
            set => SetFieldValue("rootPath", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Vector of file patterns.  If not empty, only files matching the pattern will be shown in the control.
        /// </description>
        /// </value>
        public string FileFilter {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fileFilter"));
            set => SetFieldValue("fileFilter", GenericMarshal.ToString(value));
        }
    }
}
