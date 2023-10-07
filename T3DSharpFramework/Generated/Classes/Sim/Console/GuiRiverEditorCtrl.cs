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
    /// <summary>GUI tool that makes up the River Editor</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiRiverEditorCtrl : EditTSCtrl {
        public GuiRiverEditorCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiRiverEditorCtrl(string pName, bool pRegister)
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

        public GuiRiverEditorCtrl(string pName)
            : this(pName, false) {
        }

        public GuiRiverEditorCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiRiverEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiRiverEditorCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiRiverEditorCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Regenerate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Regenerate(IntPtr _this, Regenerate__Args args);
            private static _Regenerate _RegenerateFunc;
            internal static _Regenerate Regenerate() {
               _RegenerateFunc ??= Torque3D.LookupEngineFunction<_Regenerate>("fnGuiRiverEditorCtrl_regenerate");

                return _RegenerateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedRiver__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectedRiver(IntPtr _this, GetSelectedRiver__Args args);
            private static _GetSelectedRiver _GetSelectedRiverFunc;
            internal static _GetSelectedRiver GetSelectedRiver() {
               _GetSelectedRiverFunc ??= Torque3D.LookupEngineFunction<_GetSelectedRiver>("fnGuiRiverEditorCtrl_getSelectedRiver");

                return _GetSelectedRiverFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedRiver__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedRiver(IntPtr _this, SetSelectedRiver__Args args);
            private static _SetSelectedRiver _SetSelectedRiverFunc;
            internal static _SetSelectedRiver SetSelectedRiver() {
               _SetSelectedRiverFunc ??= Torque3D.LookupEngineFunction<_SetSelectedRiver>("fnGuiRiverEditorCtrl_setSelectedRiver");

                return _SetSelectedRiverFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNodeNormal__Args
            {
                internal IntPtr normal;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetNodeNormal(IntPtr _this, SetNodeNormal__Args args);
            private static _SetNodeNormal _SetNodeNormalFunc;
            internal static _SetNodeNormal SetNodeNormal() {
               _SetNodeNormalFunc ??= Torque3D.LookupEngineFunction<_SetNodeNormal>("fnGuiRiverEditorCtrl_setNodeNormal");

                return _SetNodeNormalFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeNormal__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetNodeNormal(IntPtr _this, GetNodeNormal__Args args);
            private static _GetNodeNormal _GetNodeNormalFunc;
            internal static _GetNodeNormal GetNodeNormal() {
               _GetNodeNormalFunc ??= Torque3D.LookupEngineFunction<_GetNodeNormal>("fnGuiRiverEditorCtrl_getNodeNormal");

                return _GetNodeNormalFunc;
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
               _SetNodePositionFunc ??= Torque3D.LookupEngineFunction<_SetNodePosition>("fnGuiRiverEditorCtrl_setNodePosition");

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
               _GetNodePositionFunc ??= Torque3D.LookupEngineFunction<_GetNodePosition>("fnGuiRiverEditorCtrl_getNodePosition");

                return _GetNodePositionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNodeDepth__Args
            {
                internal float depth;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetNodeDepth(IntPtr _this, SetNodeDepth__Args args);
            private static _SetNodeDepth _SetNodeDepthFunc;
            internal static _SetNodeDepth SetNodeDepth() {
               _SetNodeDepthFunc ??= Torque3D.LookupEngineFunction<_SetNodeDepth>("fnGuiRiverEditorCtrl_setNodeDepth");

                return _SetNodeDepthFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNodeDepth__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetNodeDepth(IntPtr _this, GetNodeDepth__Args args);
            private static _GetNodeDepth _GetNodeDepthFunc;
            internal static _GetNodeDepth GetNodeDepth() {
               _GetNodeDepthFunc ??= Torque3D.LookupEngineFunction<_GetNodeDepth>("fnGuiRiverEditorCtrl_getNodeDepth");

                return _GetNodeDepthFunc;
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
               _SetNodeWidthFunc ??= Torque3D.LookupEngineFunction<_SetNodeWidth>("fnGuiRiverEditorCtrl_setNodeWidth");

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
               _GetNodeWidthFunc ??= Torque3D.LookupEngineFunction<_GetNodeWidth>("fnGuiRiverEditorCtrl_getNodeWidth");

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
               _SetModeFunc ??= Torque3D.LookupEngineFunction<_SetMode>("fnGuiRiverEditorCtrl_setMode");

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
               _GetModeFunc ??= Torque3D.LookupEngineFunction<_GetMode>("fnGuiRiverEditorCtrl_getMode");

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
               _DeleteNodeFunc ??= Torque3D.LookupEngineFunction<_DeleteNode>("fnGuiRiverEditorCtrl_deleteNode");

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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiRiverEditorCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiRiverEditorCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public void Regenerate() {
             InternalUnsafeMethods.Regenerate__Args _args = new InternalUnsafeMethods.Regenerate__Args() {
             };
             InternalUnsafeMethods.Regenerate()(ObjectPtr, _args);
        }

        /// 
        public int GetSelectedRiver() {
             InternalUnsafeMethods.GetSelectedRiver__Args _args = new InternalUnsafeMethods.GetSelectedRiver__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedRiver()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public void SetSelectedRiver(string objName = "") {
             InternalUnsafeMethods.SetSelectedRiver__Args _args = new InternalUnsafeMethods.SetSelectedRiver__Args() {
                objName = objName,
             };
             InternalUnsafeMethods.SetSelectedRiver()(ObjectPtr, _args);
        }

        /// 
        public void SetNodeNormal(Point3F normal) {
normal.Alloc();             InternalUnsafeMethods.SetNodeNormal__Args _args = new InternalUnsafeMethods.SetNodeNormal__Args() {
                normal = normal.internalStructPtr,
             };
             InternalUnsafeMethods.SetNodeNormal()(ObjectPtr, _args);
normal.Free();        }

        /// 
        public Point3F GetNodeNormal() {
             InternalUnsafeMethods.GetNodeNormal__Args _args = new InternalUnsafeMethods.GetNodeNormal__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetNodeNormal()(ObjectPtr, _args);
             return new Point3F(_engineResult);
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
        public void SetNodeDepth(float depth) {
             InternalUnsafeMethods.SetNodeDepth__Args _args = new InternalUnsafeMethods.SetNodeDepth__Args() {
                depth = depth,
             };
             InternalUnsafeMethods.SetNodeDepth()(ObjectPtr, _args);
        }

        /// 
        public float GetNodeDepth() {
             InternalUnsafeMethods.GetNodeDepth__Args _args = new InternalUnsafeMethods.GetNodeDepth__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetNodeDepth()(ObjectPtr, _args);
             return _engineResult;
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
        /// Get the type info object for the GuiRiverEditorCtrl class.
        /// </description>
        /// <returns>The type info object for GuiRiverEditorCtrl</returns>
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
        public float DefaultDepth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("DefaultDepth"));
            set => SetFieldValue("DefaultDepth", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public Point3F DefaultNormal {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("DefaultNormal"));
            set => SetFieldValue("DefaultNormal", GenericMarshal.ToString(value));
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
    }
}
