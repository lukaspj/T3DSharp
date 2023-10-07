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
    /// <summary>GUI tool that makes up the Decal Road Editor</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiRoadEditorCtrl : EditTSCtrl {
        public GuiRoadEditorCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiRoadEditorCtrl(string pName, bool pRegister)
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

        public GuiRoadEditorCtrl(string pName)
            : this(pName, false) {
        }

        public GuiRoadEditorCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiRoadEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiRoadEditorCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiRoadEditorCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteRoad__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteRoad(IntPtr _this, DeleteRoad__Args args);
            private static _DeleteRoad _DeleteRoadFunc;
            internal static _DeleteRoad DeleteRoad() {
               _DeleteRoadFunc ??= Torque3D.LookupEngineFunction<_DeleteRoad>("fnGuiRoadEditorCtrl_deleteRoad");

                return _DeleteRoadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedNode__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectedNode(IntPtr _this, GetSelectedNode__Args args);
            private static _GetSelectedNode _GetSelectedNodeFunc;
            internal static _GetSelectedNode GetSelectedNode() {
               _GetSelectedNodeFunc ??= Torque3D.LookupEngineFunction<_GetSelectedNode>("fnGuiRoadEditorCtrl_getSelectedNode");

                return _GetSelectedNodeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedRoad__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectedRoad(IntPtr _this, GetSelectedRoad__Args args);
            private static _GetSelectedRoad _GetSelectedRoadFunc;
            internal static _GetSelectedRoad GetSelectedRoad() {
               _GetSelectedRoadFunc ??= Torque3D.LookupEngineFunction<_GetSelectedRoad>("fnGuiRoadEditorCtrl_getSelectedRoad");

                return _GetSelectedRoadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedRoad__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pathRoad;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedRoad(IntPtr _this, SetSelectedRoad__Args args);
            private static _SetSelectedRoad _SetSelectedRoadFunc;
            internal static _SetSelectedRoad SetSelectedRoad() {
               _SetSelectedRoadFunc ??= Torque3D.LookupEngineFunction<_SetSelectedRoad>("fnGuiRoadEditorCtrl_setSelectedRoad");

                return _SetSelectedRoadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNodePosition__Args
            {
                internal IntPtr pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetNodePosition(IntPtr _this, SetNodePosition__Args args);
            private static _SetNodePosition _SetNodePositionFunc;
            internal static _SetNodePosition SetNodePosition() {
               _SetNodePositionFunc ??= Torque3D.LookupEngineFunction<_SetNodePosition>("fnGuiRoadEditorCtrl_setNodePosition");

                return _SetNodePositionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodePosition__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetNodePosition(IntPtr _this, GetNodePosition__Args args);
            private static _GetNodePosition _GetNodePositionFunc;
            internal static _GetNodePosition GetNodePosition() {
               _GetNodePositionFunc ??= Torque3D.LookupEngineFunction<_GetNodePosition>("fnGuiRoadEditorCtrl_getNodePosition");

                return _GetNodePositionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNodeWidth__Args
            {
                internal float width;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetNodeWidth(IntPtr _this, SetNodeWidth__Args args);
            private static _SetNodeWidth _SetNodeWidthFunc;
            internal static _SetNodeWidth SetNodeWidth() {
               _SetNodeWidthFunc ??= Torque3D.LookupEngineFunction<_SetNodeWidth>("fnGuiRoadEditorCtrl_setNodeWidth");

                return _SetNodeWidthFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeWidth__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetNodeWidth(IntPtr _this, GetNodeWidth__Args args);
            private static _GetNodeWidth _GetNodeWidthFunc;
            internal static _GetNodeWidth GetNodeWidth() {
               _GetNodeWidthFunc ??= Torque3D.LookupEngineFunction<_GetNodeWidth>("fnGuiRoadEditorCtrl_getNodeWidth");

                return _GetNodeWidthFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMode__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string mode;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMode(IntPtr _this, SetMode__Args args);
            private static _SetMode _SetModeFunc;
            internal static _SetMode SetMode() {
               _SetModeFunc ??= Torque3D.LookupEngineFunction<_SetMode>("fnGuiRoadEditorCtrl_setMode");

                return _SetModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMode__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMode(IntPtr _this, GetMode__Args args);
            private static _GetMode _GetModeFunc;
            internal static _GetMode GetMode() {
               _GetModeFunc ??= Torque3D.LookupEngineFunction<_GetMode>("fnGuiRoadEditorCtrl_getMode");

                return _GetModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteNode__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteNode(IntPtr _this, DeleteNode__Args args);
            private static _DeleteNode _DeleteNodeFunc;
            internal static _DeleteNode DeleteNode() {
               _DeleteNodeFunc ??= Torque3D.LookupEngineFunction<_DeleteNode>("fnGuiRoadEditorCtrl_deleteNode");

                return _DeleteNodeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiRoadEditorCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiRoadEditorCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public void DeleteRoad() {
             InternalUnsafeMethods.DeleteRoad__Args _args = new InternalUnsafeMethods.DeleteRoad__Args() {
             };
             InternalUnsafeMethods.DeleteRoad()(ObjectPtr, _args);
        }

        /// 
        public int GetSelectedNode() {
             InternalUnsafeMethods.GetSelectedNode__Args _args = new InternalUnsafeMethods.GetSelectedNode__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedNode()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public int GetSelectedRoad() {
             InternalUnsafeMethods.GetSelectedRoad__Args _args = new InternalUnsafeMethods.GetSelectedRoad__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedRoad()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public void SetSelectedRoad(string pathRoad = "") {
             InternalUnsafeMethods.SetSelectedRoad__Args _args = new InternalUnsafeMethods.SetSelectedRoad__Args() {
                pathRoad = pathRoad,
             };
             InternalUnsafeMethods.SetSelectedRoad()(ObjectPtr, _args);
        }

        /// 
        public void SetNodePosition(Point3F pos) {
pos.Alloc();             InternalUnsafeMethods.SetNodePosition__Args _args = new InternalUnsafeMethods.SetNodePosition__Args() {
                pos = pos.internalStructPtr,
             };
             InternalUnsafeMethods.SetNodePosition()(ObjectPtr, _args);
pos.Free();        }

        /// 
        public Point3F GetNodePosition() {
             InternalUnsafeMethods.GetNodePosition__Args _args = new InternalUnsafeMethods.GetNodePosition__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetNodePosition()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// 
        public void SetNodeWidth(float width) {
             InternalUnsafeMethods.SetNodeWidth__Args _args = new InternalUnsafeMethods.SetNodeWidth__Args() {
                width = width,
             };
             InternalUnsafeMethods.SetNodeWidth()(ObjectPtr, _args);
        }

        /// 
        public float GetNodeWidth() {
             InternalUnsafeMethods.GetNodeWidth__Args _args = new InternalUnsafeMethods.GetNodeWidth__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetNodeWidth()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// setMode( String mode )
        /// </description>
        public void SetMode(string mode) {
             InternalUnsafeMethods.SetMode__Args _args = new InternalUnsafeMethods.SetMode__Args() {
                mode = mode,
             };
             InternalUnsafeMethods.SetMode()(ObjectPtr, _args);
        }

        /// 
        public string GetMode() {
             InternalUnsafeMethods.GetMode__Args _args = new InternalUnsafeMethods.GetMode__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMode()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// deleteNode()
        /// </description>
        public void DeleteNode() {
             InternalUnsafeMethods.DeleteNode__Args _args = new InternalUnsafeMethods.DeleteNode__Args() {
             };
             InternalUnsafeMethods.DeleteNode()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiRoadEditorCtrl class.
        /// </description>
        /// <returns>The type info object for GuiRoadEditorCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public float DefaultWidth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("DefaultWidth"));
            set => SetFieldValue("DefaultWidth", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI HoverSplineColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("HoverSplineColor"));
            set => SetFieldValue("HoverSplineColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI SelectedSplineColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("SelectedSplineColor"));
            set => SetFieldValue("SelectedSplineColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI HoverNodeColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("HoverNodeColor"));
            set => SetFieldValue("HoverNodeColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool IsDirty {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isDirty"));
            set => SetFieldValue("isDirty", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Material "Default Material used by the Road Editor on road creation."</summary>
        /// </value>
        public string Material {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Material"));
            set => SetFieldValue("Material", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Material asset "Default Material used by the Road Editor on road creation.".</summary>
        /// </value>
        public string MaterialAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("MaterialAsset"));
            set => SetFieldValue("MaterialAsset", GenericMarshal.ToString(value));
        }
    }
}
