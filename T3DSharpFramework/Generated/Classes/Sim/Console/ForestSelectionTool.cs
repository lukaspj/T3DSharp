using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Console;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Console;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim.Console {
    /// <summary>Specialized selection tool for picking individual trees in a forest.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class ForestSelectionTool : ForestTool {
        public ForestSelectionTool(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public ForestSelectionTool(string pName, bool pRegister)
            : base(false) {
            Name = pName;
            // Handle the case where the class name refers to the name of
            // the object, and thus only meant to be used for that specific object,
            // not encompassing an actual type
            var managedClassName = ((object)this).GetType().Name;
            if (managedClassName != Name) {
               ClassName = managedClassName;
            }
            if (pRegister) {
                RegisterObject();
            }
        }

        public ForestSelectionTool(string pName)
            : this(pName, false) {
        }

        public ForestSelectionTool(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ForestSelectionTool(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ForestSelectionTool(SimObject pObj)
            : base(pObj) {
        }

        public ForestSelectionTool(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PasteSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PasteSelection(IntPtr _this, PasteSelection__Args args);
            private static _PasteSelection _PasteSelectionFunc;
            internal static _PasteSelection PasteSelection() {
               _PasteSelectionFunc ??= Torque3D.LookupEngineFunction<_PasteSelection>("fnForestSelectionTool_pasteSelection");

                return _PasteSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CopySelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CopySelection(IntPtr _this, CopySelection__Args args);
            private static _CopySelection _CopySelectionFunc;
            internal static _CopySelection CopySelection() {
               _CopySelectionFunc ??= Torque3D.LookupEngineFunction<_CopySelection>("fnForestSelectionTool_copySelection");

                return _CopySelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CutSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CutSelection(IntPtr _this, CutSelection__Args args);
            private static _CutSelection _CutSelectionFunc;
            internal static _CutSelection CutSelection() {
               _CutSelectionFunc ??= Torque3D.LookupEngineFunction<_CutSelection>("fnForestSelectionTool_cutSelection");

                return _CutSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearSelection(IntPtr _this, ClearSelection__Args args);
            private static _ClearSelection _ClearSelectionFunc;
            internal static _ClearSelection ClearSelection() {
               _ClearSelectionFunc ??= Torque3D.LookupEngineFunction<_ClearSelection>("fnForestSelectionTool_clearSelection");

                return _ClearSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteSelection(IntPtr _this, DeleteSelection__Args args);
            private static _DeleteSelection _DeleteSelectionFunc;
            internal static _DeleteSelection DeleteSelection() {
               _DeleteSelectionFunc ??= Torque3D.LookupEngineFunction<_DeleteSelection>("fnForestSelectionTool_deleteSelection");

                return _DeleteSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectionCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectionCount(IntPtr _this, GetSelectionCount__Args args);
            private static _GetSelectionCount _GetSelectionCountFunc;
            internal static _GetSelectionCount GetSelectionCount() {
               _GetSelectionCountFunc ??= Torque3D.LookupEngineFunction<_GetSelectionCount>("fnForestSelectionTool_getSelectionCount");

                return _GetSelectionCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnForestSelectionTool_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnForestSelectionTool_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public void PasteSelection() {
             InternalUnsafeMethods.PasteSelection__Args _args = new InternalUnsafeMethods.PasteSelection__Args() {
             };
             InternalUnsafeMethods.PasteSelection()(ObjectPtr, _args);
        }

        /// 
        public void CopySelection() {
             InternalUnsafeMethods.CopySelection__Args _args = new InternalUnsafeMethods.CopySelection__Args() {
             };
             InternalUnsafeMethods.CopySelection()(ObjectPtr, _args);
        }

        /// 
        public void CutSelection() {
             InternalUnsafeMethods.CutSelection__Args _args = new InternalUnsafeMethods.CutSelection__Args() {
             };
             InternalUnsafeMethods.CutSelection()(ObjectPtr, _args);
        }

        /// 
        public void ClearSelection() {
             InternalUnsafeMethods.ClearSelection__Args _args = new InternalUnsafeMethods.ClearSelection__Args() {
             };
             InternalUnsafeMethods.ClearSelection()(ObjectPtr, _args);
        }

        /// 
        public void DeleteSelection() {
             InternalUnsafeMethods.DeleteSelection__Args _args = new InternalUnsafeMethods.DeleteSelection__Args() {
             };
             InternalUnsafeMethods.DeleteSelection()(ObjectPtr, _args);
        }

        /// 
        public int GetSelectionCount() {
             InternalUnsafeMethods.GetSelectionCount__Args _args = new InternalUnsafeMethods.GetSelectionCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectionCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the ForestSelectionTool class.
        /// </description>
        /// <returns>The type info object for ForestSelectionTool</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
