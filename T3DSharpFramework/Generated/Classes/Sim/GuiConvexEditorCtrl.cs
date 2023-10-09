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
    /// <summary>The base class for the sketch tool</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiConvexEditorCtrl : EditTSCtrl {
        public GuiConvexEditorCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiConvexEditorCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiConvexEditorCtrl(string pName)
            : this(pName, false) {
        }

        public GuiConvexEditorCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiConvexEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiConvexEditorCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiConvexEditorCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct UpdateShape__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UpdateShape(IntPtr _this, UpdateShape__Args args);
            private static _UpdateShape _UpdateShapeFunc;
            internal static _UpdateShape UpdateShape() {
               _UpdateShapeFunc ??= Torque3D.LookupEngineFunction<_UpdateShape>("fnGuiConvexEditorCtrl_updateShape");

                return _UpdateShapeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGridSnapSize__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetGridSnapSize(IntPtr _this, GetGridSnapSize__Args args);
            private static _GetGridSnapSize _GetGridSnapSizeFunc;
            internal static _GetGridSnapSize GetGridSnapSize() {
               _GetGridSnapSizeFunc ??= Torque3D.LookupEngineFunction<_GetGridSnapSize>("fnGuiConvexEditorCtrl_getGridSnapSize");

                return _GetGridSnapSizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGridSnapSize__Args
            {
                internal float gridSize;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetGridSnapSize(IntPtr _this, SetGridSnapSize__Args args);
            private static _SetGridSnapSize _SetGridSnapSizeFunc;
            internal static _SetGridSnapSize SetGridSnapSize() {
               _SetGridSnapSizeFunc ??= Torque3D.LookupEngineFunction<_SetGridSnapSize>("fnGuiConvexEditorCtrl_setGridSnapSize");

                return _SetGridSnapSizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ToggleGridSnapping__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ToggleGridSnapping(IntPtr _this, ToggleGridSnapping__Args args);
            private static _ToggleGridSnapping _ToggleGridSnappingFunc;
            internal static _ToggleGridSnapping ToggleGridSnapping() {
               _ToggleGridSnappingFunc ??= Torque3D.LookupEngineFunction<_ToggleGridSnapping>("fnGuiConvexEditorCtrl_toggleGridSnapping");

                return _ToggleGridSnappingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedFaceZRot__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetSelectedFaceZRot(IntPtr _this, GetSelectedFaceZRot__Args args);
            private static _GetSelectedFaceZRot _GetSelectedFaceZRotFunc;
            internal static _GetSelectedFaceZRot GetSelectedFaceZRot() {
               _GetSelectedFaceZRotFunc ??= Torque3D.LookupEngineFunction<_GetSelectedFaceZRot>("fnGuiConvexEditorCtrl_getSelectedFaceZRot");

                return _GetSelectedFaceZRotFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedFaceZRot__Args
            {
                internal float degrees;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedFaceZRot(IntPtr _this, SetSelectedFaceZRot__Args args);
            private static _SetSelectedFaceZRot _SetSelectedFaceZRotFunc;
            internal static _SetSelectedFaceZRot SetSelectedFaceZRot() {
               _SetSelectedFaceZRotFunc ??= Torque3D.LookupEngineFunction<_SetSelectedFaceZRot>("fnGuiConvexEditorCtrl_setSelectedFaceZRot");

                return _SetSelectedFaceZRotFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedFaceVertFlip__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetSelectedFaceVertFlip(IntPtr _this, GetSelectedFaceVertFlip__Args args);
            private static _GetSelectedFaceVertFlip _GetSelectedFaceVertFlipFunc;
            internal static _GetSelectedFaceVertFlip GetSelectedFaceVertFlip() {
               _GetSelectedFaceVertFlipFunc ??= Torque3D.LookupEngineFunction<_GetSelectedFaceVertFlip>("fnGuiConvexEditorCtrl_getSelectedFaceVertFlip");

                return _GetSelectedFaceVertFlipFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedFaceHorzFlip__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetSelectedFaceHorzFlip(IntPtr _this, GetSelectedFaceHorzFlip__Args args);
            private static _GetSelectedFaceHorzFlip _GetSelectedFaceHorzFlipFunc;
            internal static _GetSelectedFaceHorzFlip GetSelectedFaceHorzFlip() {
               _GetSelectedFaceHorzFlipFunc ??= Torque3D.LookupEngineFunction<_GetSelectedFaceHorzFlip>("fnGuiConvexEditorCtrl_getSelectedFaceHorzFlip");

                return _GetSelectedFaceHorzFlipFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedFaceVertFlip__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool flipped;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedFaceVertFlip(IntPtr _this, SetSelectedFaceVertFlip__Args args);
            private static _SetSelectedFaceVertFlip _SetSelectedFaceVertFlipFunc;
            internal static _SetSelectedFaceVertFlip SetSelectedFaceVertFlip() {
               _SetSelectedFaceVertFlipFunc ??= Torque3D.LookupEngineFunction<_SetSelectedFaceVertFlip>("fnGuiConvexEditorCtrl_setSelectedFaceVertFlip");

                return _SetSelectedFaceVertFlipFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedFaceHorzFlip__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool flipped;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedFaceHorzFlip(IntPtr _this, SetSelectedFaceHorzFlip__Args args);
            private static _SetSelectedFaceHorzFlip _SetSelectedFaceHorzFlipFunc;
            internal static _SetSelectedFaceHorzFlip SetSelectedFaceHorzFlip() {
               _SetSelectedFaceHorzFlipFunc ??= Torque3D.LookupEngineFunction<_SetSelectedFaceHorzFlip>("fnGuiConvexEditorCtrl_setSelectedFaceHorzFlip");

                return _SetSelectedFaceHorzFlipFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedFaceMaterial__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSelectedFaceMaterial(IntPtr _this, GetSelectedFaceMaterial__Args args);
            private static _GetSelectedFaceMaterial _GetSelectedFaceMaterialFunc;
            internal static _GetSelectedFaceMaterial GetSelectedFaceMaterial() {
               _GetSelectedFaceMaterialFunc ??= Torque3D.LookupEngineFunction<_GetSelectedFaceMaterial>("fnGuiConvexEditorCtrl_getSelectedFaceMaterial");

                return _GetSelectedFaceMaterialFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedFaceMaterial__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string materialName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedFaceMaterial(IntPtr _this, SetSelectedFaceMaterial__Args args);
            private static _SetSelectedFaceMaterial _SetSelectedFaceMaterialFunc;
            internal static _SetSelectedFaceMaterial SetSelectedFaceMaterial() {
               _SetSelectedFaceMaterialFunc ??= Torque3D.LookupEngineFunction<_SetSelectedFaceMaterial>("fnGuiConvexEditorCtrl_setSelectedFaceMaterial");

                return _SetSelectedFaceMaterialFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedFaceUVScale__Args
            {
                internal IntPtr scale;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedFaceUVScale(IntPtr _this, SetSelectedFaceUVScale__Args args);
            private static _SetSelectedFaceUVScale _SetSelectedFaceUVScaleFunc;
            internal static _SetSelectedFaceUVScale SetSelectedFaceUVScale() {
               _SetSelectedFaceUVScaleFunc ??= Torque3D.LookupEngineFunction<_SetSelectedFaceUVScale>("fnGuiConvexEditorCtrl_setSelectedFaceUVScale");

                return _SetSelectedFaceUVScaleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectedFaceUVOffset__Args
            {
                internal IntPtr offset;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectedFaceUVOffset(IntPtr _this, SetSelectedFaceUVOffset__Args args);
            private static _SetSelectedFaceUVOffset _SetSelectedFaceUVOffsetFunc;
            internal static _SetSelectedFaceUVOffset SetSelectedFaceUVOffset() {
               _SetSelectedFaceUVOffsetFunc ??= Torque3D.LookupEngineFunction<_SetSelectedFaceUVOffset>("fnGuiConvexEditorCtrl_setSelectedFaceUVOffset");

                return _SetSelectedFaceUVOffsetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedFaceUVScale__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2F.InternalStruct _GetSelectedFaceUVScale(IntPtr _this, GetSelectedFaceUVScale__Args args);
            private static _GetSelectedFaceUVScale _GetSelectedFaceUVScaleFunc;
            internal static _GetSelectedFaceUVScale GetSelectedFaceUVScale() {
               _GetSelectedFaceUVScaleFunc ??= Torque3D.LookupEngineFunction<_GetSelectedFaceUVScale>("fnGuiConvexEditorCtrl_getSelectedFaceUVScale");

                return _GetSelectedFaceUVScaleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedFaceUVOffset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2F.InternalStruct _GetSelectedFaceUVOffset(IntPtr _this, GetSelectedFaceUVOffset__Args args);
            private static _GetSelectedFaceUVOffset _GetSelectedFaceUVOffsetFunc;
            internal static _GetSelectedFaceUVOffset GetSelectedFaceUVOffset() {
               _GetSelectedFaceUVOffsetFunc ??= Torque3D.LookupEngineFunction<_GetSelectedFaceUVOffset>("fnGuiConvexEditorCtrl_getSelectedFaceUVOffset");

                return _GetSelectedFaceUVOffsetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SplitSelectedFace__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SplitSelectedFace(IntPtr _this, SplitSelectedFace__Args args);
            private static _SplitSelectedFace _SplitSelectedFaceFunc;
            internal static _SplitSelectedFace SplitSelectedFace() {
               _SplitSelectedFaceFunc ??= Torque3D.LookupEngineFunction<_SplitSelectedFace>("fnGuiConvexEditorCtrl_splitSelectedFace");

                return _SplitSelectedFaceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectConvex__Args
            {
                internal IntPtr convex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SelectConvex(IntPtr _this, SelectConvex__Args args);
            private static _SelectConvex _SelectConvexFunc;
            internal static _SelectConvex SelectConvex() {
               _SelectConvexFunc ??= Torque3D.LookupEngineFunction<_SelectConvex>("fnGuiConvexEditorCtrl_selectConvex");

                return _SelectConvexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DropSelectionAtScreenCenter__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DropSelectionAtScreenCenter(IntPtr _this, DropSelectionAtScreenCenter__Args args);
            private static _DropSelectionAtScreenCenter _DropSelectionAtScreenCenterFunc;
            internal static _DropSelectionAtScreenCenter DropSelectionAtScreenCenter() {
               _DropSelectionAtScreenCenterFunc ??= Torque3D.LookupEngineFunction<_DropSelectionAtScreenCenter>("fnGuiConvexEditorCtrl_dropSelectionAtScreenCenter");

                return _DropSelectionAtScreenCenterFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct HandleDeselect__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _HandleDeselect(IntPtr _this, HandleDeselect__Args args);
            private static _HandleDeselect _HandleDeselectFunc;
            internal static _HandleDeselect HandleDeselect() {
               _HandleDeselectFunc ??= Torque3D.LookupEngineFunction<_HandleDeselect>("fnGuiConvexEditorCtrl_handleDeselect");

                return _HandleDeselectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct HandleDelete__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _HandleDelete(IntPtr _this, HandleDelete__Args args);
            private static _HandleDelete _HandleDeleteFunc;
            internal static _HandleDelete HandleDelete() {
               _HandleDeleteFunc ??= Torque3D.LookupEngineFunction<_HandleDelete>("fnGuiConvexEditorCtrl_handleDelete");

                return _HandleDeleteFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct HasSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _HasSelection(IntPtr _this, HasSelection__Args args);
            private static _HasSelection _HasSelectionFunc;
            internal static _HasSelection HasSelection() {
               _HasSelectionFunc ??= Torque3D.LookupEngineFunction<_HasSelection>("fnGuiConvexEditorCtrl_hasSelection");

                return _HasSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RecenterSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RecenterSelection(IntPtr _this, RecenterSelection__Args args);
            private static _RecenterSelection _RecenterSelectionFunc;
            internal static _RecenterSelection RecenterSelection() {
               _RecenterSelectionFunc ??= Torque3D.LookupEngineFunction<_RecenterSelection>("fnGuiConvexEditorCtrl_recenterSelection");

                return _RecenterSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct HollowSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _HollowSelection(IntPtr _this, HollowSelection__Args args);
            private static _HollowSelection _HollowSelectionFunc;
            internal static _HollowSelection HollowSelection() {
               _HollowSelectionFunc ??= Torque3D.LookupEngineFunction<_HollowSelection>("fnGuiConvexEditorCtrl_hollowSelection");

                return _HollowSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiConvexEditorCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiConvexEditorCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public void UpdateShape() {
             InternalUnsafeMethods.UpdateShape__Args _args = new InternalUnsafeMethods.UpdateShape__Args() {
             };
             InternalUnsafeMethods.UpdateShape()(ObjectPtr, _args);
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public float GetGridSnapSize() {
             InternalUnsafeMethods.GetGridSnapSize__Args _args = new InternalUnsafeMethods.GetGridSnapSize__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetGridSnapSize()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public void SetGridSnapSize(float gridSize = 1f) {
             InternalUnsafeMethods.SetGridSnapSize__Args _args = new InternalUnsafeMethods.SetGridSnapSize__Args() {
                gridSize = gridSize,
             };
             InternalUnsafeMethods.SetGridSnapSize()(ObjectPtr, _args);
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public void ToggleGridSnapping() {
             InternalUnsafeMethods.ToggleGridSnapping__Args _args = new InternalUnsafeMethods.ToggleGridSnapping__Args() {
             };
             InternalUnsafeMethods.ToggleGridSnapping()(ObjectPtr, _args);
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public float GetSelectedFaceZRot() {
             InternalUnsafeMethods.GetSelectedFaceZRot__Args _args = new InternalUnsafeMethods.GetSelectedFaceZRot__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetSelectedFaceZRot()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public void SetSelectedFaceZRot(float degrees = 0f) {
             InternalUnsafeMethods.SetSelectedFaceZRot__Args _args = new InternalUnsafeMethods.SetSelectedFaceZRot__Args() {
                degrees = degrees,
             };
             InternalUnsafeMethods.SetSelectedFaceZRot()(ObjectPtr, _args);
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public bool GetSelectedFaceVertFlip() {
             InternalUnsafeMethods.GetSelectedFaceVertFlip__Args _args = new InternalUnsafeMethods.GetSelectedFaceVertFlip__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetSelectedFaceVertFlip()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public bool GetSelectedFaceHorzFlip() {
             InternalUnsafeMethods.GetSelectedFaceHorzFlip__Args _args = new InternalUnsafeMethods.GetSelectedFaceHorzFlip__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetSelectedFaceHorzFlip()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public void SetSelectedFaceVertFlip(bool flipped = false) {
             InternalUnsafeMethods.SetSelectedFaceVertFlip__Args _args = new InternalUnsafeMethods.SetSelectedFaceVertFlip__Args() {
                flipped = flipped,
             };
             InternalUnsafeMethods.SetSelectedFaceVertFlip()(ObjectPtr, _args);
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public void SetSelectedFaceHorzFlip(bool flipped = false) {
             InternalUnsafeMethods.SetSelectedFaceHorzFlip__Args _args = new InternalUnsafeMethods.SetSelectedFaceHorzFlip__Args() {
                flipped = flipped,
             };
             InternalUnsafeMethods.SetSelectedFaceHorzFlip()(ObjectPtr, _args);
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public string GetSelectedFaceMaterial() {
             InternalUnsafeMethods.GetSelectedFaceMaterial__Args _args = new InternalUnsafeMethods.GetSelectedFaceMaterial__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSelectedFaceMaterial()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public void SetSelectedFaceMaterial(string materialName = "") {
             InternalUnsafeMethods.SetSelectedFaceMaterial__Args _args = new InternalUnsafeMethods.SetSelectedFaceMaterial__Args() {
                materialName = materialName,
             };
             InternalUnsafeMethods.SetSelectedFaceMaterial()(ObjectPtr, _args);
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public void SetSelectedFaceUVScale(Point2F scale = null) {
scale = scale ?? new Point2F("0 0");
scale.Alloc();             InternalUnsafeMethods.SetSelectedFaceUVScale__Args _args = new InternalUnsafeMethods.SetSelectedFaceUVScale__Args() {
                scale = scale.internalStructPtr,
             };
             InternalUnsafeMethods.SetSelectedFaceUVScale()(ObjectPtr, _args);
scale.Free();        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public void SetSelectedFaceUVOffset(Point2F offset = null) {
offset = offset ?? new Point2F("0 0");
offset.Alloc();             InternalUnsafeMethods.SetSelectedFaceUVOffset__Args _args = new InternalUnsafeMethods.SetSelectedFaceUVOffset__Args() {
                offset = offset.internalStructPtr,
             };
             InternalUnsafeMethods.SetSelectedFaceUVOffset()(ObjectPtr, _args);
offset.Free();        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public Point2F GetSelectedFaceUVScale() {
             InternalUnsafeMethods.GetSelectedFaceUVScale__Args _args = new InternalUnsafeMethods.GetSelectedFaceUVScale__Args() {
             };
             Point2F.InternalStruct _engineResult = InternalUnsafeMethods.GetSelectedFaceUVScale()(ObjectPtr, _args);
             return new Point2F(_engineResult);
        }

        /// <summary>Mount objB to this object at the desired slot with optional transform.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objB">Object to mount onto us</param>
        /// <param name="slot">Mount slot ID</param>
        /// <param name="txfm">(optional) mount offset transform</param>
        /// <returns>true if successful, false if failed (objB is not valid)</returns>
        public Point2F GetSelectedFaceUVOffset() {
             InternalUnsafeMethods.GetSelectedFaceUVOffset__Args _args = new InternalUnsafeMethods.GetSelectedFaceUVOffset__Args() {
             };
             Point2F.InternalStruct _engineResult = InternalUnsafeMethods.GetSelectedFaceUVOffset()(ObjectPtr, _args);
             return new Point2F(_engineResult);
        }

        /// 
        public void SplitSelectedFace() {
             InternalUnsafeMethods.SplitSelectedFace__Args _args = new InternalUnsafeMethods.SplitSelectedFace__Args() {
             };
             InternalUnsafeMethods.SplitSelectedFace()(ObjectPtr, _args);
        }

        /// <description>
        /// ( ConvexShape )
        /// </description>
        public void SelectConvex(ConvexShape convex) {
             InternalUnsafeMethods.SelectConvex__Args _args = new InternalUnsafeMethods.SelectConvex__Args() {
                convex = convex.ObjectPtr,
             };
             InternalUnsafeMethods.SelectConvex()(ObjectPtr, _args);
        }

        /// 
        public void DropSelectionAtScreenCenter() {
             InternalUnsafeMethods.DropSelectionAtScreenCenter__Args _args = new InternalUnsafeMethods.DropSelectionAtScreenCenter__Args() {
             };
             InternalUnsafeMethods.DropSelectionAtScreenCenter()(ObjectPtr, _args);
        }

        /// 
        public void HandleDeselect() {
             InternalUnsafeMethods.HandleDeselect__Args _args = new InternalUnsafeMethods.HandleDeselect__Args() {
             };
             InternalUnsafeMethods.HandleDeselect()(ObjectPtr, _args);
        }

        /// 
        public void HandleDelete() {
             InternalUnsafeMethods.HandleDelete__Args _args = new InternalUnsafeMethods.HandleDelete__Args() {
             };
             InternalUnsafeMethods.HandleDelete()(ObjectPtr, _args);
        }

        /// 
        public int HasSelection() {
             InternalUnsafeMethods.HasSelection__Args _args = new InternalUnsafeMethods.HasSelection__Args() {
             };
             int _engineResult = InternalUnsafeMethods.HasSelection()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public void RecenterSelection() {
             InternalUnsafeMethods.RecenterSelection__Args _args = new InternalUnsafeMethods.RecenterSelection__Args() {
             };
             InternalUnsafeMethods.RecenterSelection()(ObjectPtr, _args);
        }

        /// 
        public void HollowSelection() {
             InternalUnsafeMethods.HollowSelection__Args _args = new InternalUnsafeMethods.HollowSelection__Args() {
             };
             InternalUnsafeMethods.HollowSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiConvexEditorCtrl class.
        /// </description>
        /// <returns>The type info object for GuiConvexEditorCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public bool IsDirty {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isDirty"));
            set => SetFieldValue("isDirty", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string MaterialName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("materialName"));
            set => SetFieldValue("materialName", GenericMarshal.ToString(value));
        }
    }
}
