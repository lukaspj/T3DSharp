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
    /// <summary>The base Terrain Editor tool</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class TerrainEditor : EditTSCtrl {
        public TerrainEditor(bool pRegister = false)
            : base(pRegister) {
        }

        public TerrainEditor(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public TerrainEditor(string pName)
            : this(pName, false) {
        }

        public TerrainEditor(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public TerrainEditor(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public TerrainEditor(SimObject pObj)
            : base(pObj) {
        }

        public TerrainEditor(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct AutoMaterialLayer__Args
            {
                internal float minHeight;
                internal float maxHeight;
                internal float minSlope;
                internal float maxSlope;
                internal float coverage;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AutoMaterialLayer(IntPtr _this, AutoMaterialLayer__Args args);
            private static _AutoMaterialLayer _AutoMaterialLayerFunc;
            internal static _AutoMaterialLayer AutoMaterialLayer() {
               _AutoMaterialLayerFunc ??= Torque3D.LookupEngineFunction<_AutoMaterialLayer>("fnTerrainEditor_autoMaterialLayer");

                return _AutoMaterialLayerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSlopeLimitMaxAngle__Args
            {
                internal float angle;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _SetSlopeLimitMaxAngle(IntPtr _this, SetSlopeLimitMaxAngle__Args args);
            private static _SetSlopeLimitMaxAngle _SetSlopeLimitMaxAngleFunc;
            internal static _SetSlopeLimitMaxAngle SetSlopeLimitMaxAngle() {
               _SetSlopeLimitMaxAngleFunc ??= Torque3D.LookupEngineFunction<_SetSlopeLimitMaxAngle>("fnTerrainEditor_setSlopeLimitMaxAngle");

                return _SetSlopeLimitMaxAngleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSlopeLimitMaxAngle__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetSlopeLimitMaxAngle(IntPtr _this, GetSlopeLimitMaxAngle__Args args);
            private static _GetSlopeLimitMaxAngle _GetSlopeLimitMaxAngleFunc;
            internal static _GetSlopeLimitMaxAngle GetSlopeLimitMaxAngle() {
               _GetSlopeLimitMaxAngleFunc ??= Torque3D.LookupEngineFunction<_GetSlopeLimitMaxAngle>("fnTerrainEditor_getSlopeLimitMaxAngle");

                return _GetSlopeLimitMaxAngleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSlopeLimitMinAngle__Args
            {
                internal float angle;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _SetSlopeLimitMinAngle(IntPtr _this, SetSlopeLimitMinAngle__Args args);
            private static _SetSlopeLimitMinAngle _SetSlopeLimitMinAngleFunc;
            internal static _SetSlopeLimitMinAngle SetSlopeLimitMinAngle() {
               _SetSlopeLimitMinAngleFunc ??= Torque3D.LookupEngineFunction<_SetSlopeLimitMinAngle>("fnTerrainEditor_setSlopeLimitMinAngle");

                return _SetSlopeLimitMinAngleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSlopeLimitMinAngle__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetSlopeLimitMinAngle(IntPtr _this, GetSlopeLimitMinAngle__Args args);
            private static _GetSlopeLimitMinAngle _GetSlopeLimitMinAngleFunc;
            internal static _GetSlopeLimitMinAngle GetSlopeLimitMinAngle() {
               _GetSlopeLimitMinAngleFunc ??= Torque3D.LookupEngineFunction<_GetSlopeLimitMinAngle>("fnTerrainEditor_getSlopeLimitMinAngle");

                return _GetSlopeLimitMinAngleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTerrainUnderWorldPoint__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string ptOrX;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string Y;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string Z;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetTerrainUnderWorldPoint(IntPtr _this, GetTerrainUnderWorldPoint__Args args);
            private static _GetTerrainUnderWorldPoint _GetTerrainUnderWorldPointFunc;
            internal static _GetTerrainUnderWorldPoint GetTerrainUnderWorldPoint() {
               _GetTerrainUnderWorldPointFunc ??= Torque3D.LookupEngineFunction<_GetTerrainUnderWorldPoint>("fnTerrainEditor_getTerrainUnderWorldPoint");

                return _GetTerrainUnderWorldPointFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ReorderMaterial__Args
            {
                internal int index;
                internal int orderPos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ReorderMaterial(IntPtr _this, ReorderMaterial__Args args);
            private static _ReorderMaterial _ReorderMaterialFunc;
            internal static _ReorderMaterial ReorderMaterial() {
               _ReorderMaterialFunc ??= Torque3D.LookupEngineFunction<_ReorderMaterial>("fnTerrainEditor_reorderMaterial");

                return _ReorderMaterialFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMaterialIndex__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMaterialIndex(IntPtr _this, GetMaterialIndex__Args args);
            private static _GetMaterialIndex _GetMaterialIndexFunc;
            internal static _GetMaterialIndex GetMaterialIndex() {
               _GetMaterialIndexFunc ??= Torque3D.LookupEngineFunction<_GetMaterialIndex>("fnTerrainEditor_getMaterialIndex");

                return _GetMaterialIndexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMaterialName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMaterialName(IntPtr _this, GetMaterialName__Args args);
            private static _GetMaterialName _GetMaterialNameFunc;
            internal static _GetMaterialName GetMaterialName() {
               _GetMaterialNameFunc ??= Torque3D.LookupEngineFunction<_GetMaterialName>("fnTerrainEditor_getMaterialName");

                return _GetMaterialNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMaterials__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMaterials(IntPtr _this, GetMaterials__Args args);
            private static _GetMaterials _GetMaterialsFunc;
            internal static _GetMaterials GetMaterials() {
               _GetMaterialsFunc ??= Torque3D.LookupEngineFunction<_GetMaterials>("fnTerrainEditor_getMaterials");

                return _GetMaterialsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMaterialCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMaterialCount(IntPtr _this, GetMaterialCount__Args args);
            private static _GetMaterialCount _GetMaterialCountFunc;
            internal static _GetMaterialCount GetMaterialCount() {
               _GetMaterialCountFunc ??= Torque3D.LookupEngineFunction<_GetMaterialCount>("fnTerrainEditor_getMaterialCount");

                return _GetMaterialCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveMaterial__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveMaterial(IntPtr _this, RemoveMaterial__Args args);
            private static _RemoveMaterial _RemoveMaterialFunc;
            internal static _RemoveMaterial RemoveMaterial() {
               _RemoveMaterialFunc ??= Torque3D.LookupEngineFunction<_RemoveMaterial>("fnTerrainEditor_removeMaterial");

                return _RemoveMaterialFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddMaterial__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string matName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _AddMaterial(IntPtr _this, AddMaterial__Args args);
            private static _AddMaterial _AddMaterialFunc;
            internal static _AddMaterial AddMaterial() {
               _AddMaterialFunc ??= Torque3D.LookupEngineFunction<_AddMaterial>("fnTerrainEditor_addMaterial");

                return _AddMaterialFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UpdateMaterial__Args
            {
                internal uint index;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string matName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _UpdateMaterial(IntPtr _this, UpdateMaterial__Args args);
            private static _UpdateMaterial _UpdateMaterialFunc;
            internal static _UpdateMaterial UpdateMaterial() {
               _UpdateMaterialFunc ??= Torque3D.LookupEngineFunction<_UpdateMaterial>("fnTerrainEditor_updateMaterial");

                return _UpdateMaterialFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTerraformOverlay__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool overlayEnable;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTerraformOverlay(IntPtr _this, SetTerraformOverlay__Args args);
            private static _SetTerraformOverlay _SetTerraformOverlayFunc;
            internal static _SetTerraformOverlay SetTerraformOverlay() {
               _SetTerraformOverlayFunc ??= Torque3D.LookupEngineFunction<_SetTerraformOverlay>("fnTerrainEditor_setTerraformOverlay");

                return _SetTerraformOverlayFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MirrorTerrain__Args
            {
                internal int mirrorIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _MirrorTerrain(IntPtr _this, MirrorTerrain__Args args);
            private static _MirrorTerrain _MirrorTerrainFunc;
            internal static _MirrorTerrain MirrorTerrain() {
               _MirrorTerrainFunc ??= Torque3D.LookupEngineFunction<_MirrorTerrain>("fnTerrainEditor_mirrorTerrain");

                return _MirrorTerrainFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MarkEmptySquares__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _MarkEmptySquares(IntPtr _this, MarkEmptySquares__Args args);
            private static _MarkEmptySquares _MarkEmptySquaresFunc;
            internal static _MarkEmptySquares MarkEmptySquares() {
               _MarkEmptySquaresFunc ??= Torque3D.LookupEngineFunction<_MarkEmptySquares>("fnTerrainEditor_markEmptySquares");

                return _MarkEmptySquaresFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNumTextures__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNumTextures(IntPtr _this, GetNumTextures__Args args);
            private static _GetNumTextures _GetNumTexturesFunc;
            internal static _GetNumTextures GetNumTextures() {
               _GetNumTexturesFunc ??= Torque3D.LookupEngineFunction<_GetNumTextures>("fnTerrainEditor_getNumTextures");

                return _GetNumTexturesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetActiveTerrain__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetActiveTerrain(IntPtr _this, GetActiveTerrain__Args args);
            private static _GetActiveTerrain _GetActiveTerrainFunc;
            internal static _GetActiveTerrain GetActiveTerrain() {
               _GetActiveTerrainFunc ??= Torque3D.LookupEngineFunction<_GetActiveTerrain>("fnTerrainEditor_getActiveTerrain");

                return _GetActiveTerrainFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ProcessAction__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string action;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ProcessAction(IntPtr _this, ProcessAction__Args args);
            private static _ProcessAction _ProcessActionFunc;
            internal static _ProcessAction ProcessAction() {
               _ProcessActionFunc ??= Torque3D.LookupEngineFunction<_ProcessAction>("fnTerrainEditor_processAction");

                return _ProcessActionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearSelection(IntPtr _this, ClearSelection__Args args);
            private static _ClearSelection _ClearSelectionFunc;
            internal static _ClearSelection ClearSelection() {
               _ClearSelectionFunc ??= Torque3D.LookupEngineFunction<_ClearSelection>("fnTerrainEditor_clearSelection");

                return _ClearSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetSelWeights__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool clear;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetSelWeights(IntPtr _this, ResetSelWeights__Args args);
            private static _ResetSelWeights _ResetSelWeightsFunc;
            internal static _ResetSelWeights ResetSelWeights() {
               _ResetSelWeightsFunc ??= Torque3D.LookupEngineFunction<_ResetSelWeights>("fnTerrainEditor_resetSelWeights");

                return _ResetSelWeightsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentAction__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetCurrentAction(IntPtr _this, GetCurrentAction__Args args);
            private static _GetCurrentAction _GetCurrentActionFunc;
            internal static _GetCurrentAction GetCurrentAction() {
               _GetCurrentActionFunc ??= Torque3D.LookupEngineFunction<_GetCurrentAction>("fnTerrainEditor_getCurrentAction");

                return _GetCurrentActionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNumActions__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNumActions(IntPtr _this, GetNumActions__Args args);
            private static _GetNumActions _GetNumActionsFunc;
            internal static _GetNumActions GetNumActions() {
               _GetNumActionsFunc ??= Torque3D.LookupEngineFunction<_GetNumActions>("fnTerrainEditor_getNumActions");

                return _GetNumActionsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetActionName__Args
            {
                internal uint index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetActionName(IntPtr _this, GetActionName__Args args);
            private static _GetActionName _GetActionNameFunc;
            internal static _GetActionName GetActionName() {
               _GetActionNameFunc ??= Torque3D.LookupEngineFunction<_GetActionName>("fnTerrainEditor_getActionName");

                return _GetActionNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAction__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string action_name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAction(IntPtr _this, SetAction__Args args);
            private static _SetAction _SetActionFunc;
            internal static _SetAction SetAction() {
               _SetActionFunc ??= Torque3D.LookupEngineFunction<_SetAction>("fnTerrainEditor_setAction");

                return _SetActionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBrushPos__Args
            {
                internal IntPtr pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBrushPos(IntPtr _this, SetBrushPos__Args args);
            private static _SetBrushPos _SetBrushPosFunc;
            internal static _SetBrushPos SetBrushPos() {
               _SetBrushPosFunc ??= Torque3D.LookupEngineFunction<_SetBrushPos>("fnTerrainEditor_setBrushPos");

                return _SetBrushPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBrushPos__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetBrushPos(IntPtr _this, GetBrushPos__Args args);
            private static _GetBrushPos _GetBrushPosFunc;
            internal static _GetBrushPos GetBrushPos() {
               _GetBrushPosFunc ??= Torque3D.LookupEngineFunction<_GetBrushPos>("fnTerrainEditor_getBrushPos");

                return _GetBrushPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBrushSoftness__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetBrushSoftness(IntPtr _this, GetBrushSoftness__Args args);
            private static _GetBrushSoftness _GetBrushSoftnessFunc;
            internal static _GetBrushSoftness GetBrushSoftness() {
               _GetBrushSoftnessFunc ??= Torque3D.LookupEngineFunction<_GetBrushSoftness>("fnTerrainEditor_getBrushSoftness");

                return _GetBrushSoftnessFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBrushSoftness__Args
            {
                internal float softness;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBrushSoftness(IntPtr _this, SetBrushSoftness__Args args);
            private static _SetBrushSoftness _SetBrushSoftnessFunc;
            internal static _SetBrushSoftness SetBrushSoftness() {
               _SetBrushSoftnessFunc ??= Torque3D.LookupEngineFunction<_SetBrushSoftness>("fnTerrainEditor_setBrushSoftness");

                return _SetBrushSoftnessFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBrushPressure__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetBrushPressure(IntPtr _this, GetBrushPressure__Args args);
            private static _GetBrushPressure _GetBrushPressureFunc;
            internal static _GetBrushPressure GetBrushPressure() {
               _GetBrushPressureFunc ??= Torque3D.LookupEngineFunction<_GetBrushPressure>("fnTerrainEditor_getBrushPressure");

                return _GetBrushPressureFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBrushPressure__Args
            {
                internal float pressure;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBrushPressure(IntPtr _this, SetBrushPressure__Args args);
            private static _SetBrushPressure _SetBrushPressureFunc;
            internal static _SetBrushPressure SetBrushPressure() {
               _SetBrushPressureFunc ??= Torque3D.LookupEngineFunction<_SetBrushPressure>("fnTerrainEditor_setBrushPressure");

                return _SetBrushPressureFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBrushSize__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetBrushSize(IntPtr _this, GetBrushSize__Args args);
            private static _GetBrushSize _GetBrushSizeFunc;
            internal static _GetBrushSize GetBrushSize() {
               _GetBrushSizeFunc ??= Torque3D.LookupEngineFunction<_GetBrushSize>("fnTerrainEditor_getBrushSize");

                return _GetBrushSizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBrushSize__Args
            {
                internal int w;
                internal int h;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBrushSize(IntPtr _this, SetBrushSize__Args args);
            private static _SetBrushSize _SetBrushSizeFunc;
            internal static _SetBrushSize SetBrushSize() {
               _SetBrushSizeFunc ??= Torque3D.LookupEngineFunction<_SetBrushSize>("fnTerrainEditor_setBrushSize");

                return _SetBrushSizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBrushType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetBrushType(IntPtr _this, GetBrushType__Args args);
            private static _GetBrushType _GetBrushTypeFunc;
            internal static _GetBrushType GetBrushType() {
               _GetBrushTypeFunc ??= Torque3D.LookupEngineFunction<_GetBrushType>("fnTerrainEditor_getBrushType");

                return _GetBrushTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBrushType__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBrushType(IntPtr _this, SetBrushType__Args args);
            private static _SetBrushType _SetBrushTypeFunc;
            internal static _SetBrushType SetBrushType() {
               _SetBrushTypeFunc ??= Torque3D.LookupEngineFunction<_SetBrushType>("fnTerrainEditor_setBrushType");

                return _SetBrushTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTerrainBlocksMaterialList__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTerrainBlocksMaterialList(IntPtr _this, GetTerrainBlocksMaterialList__Args args);
            private static _GetTerrainBlocksMaterialList _GetTerrainBlocksMaterialListFunc;
            internal static _GetTerrainBlocksMaterialList GetTerrainBlocksMaterialList() {
               _GetTerrainBlocksMaterialListFunc ??= Torque3D.LookupEngineFunction<_GetTerrainBlocksMaterialList>("fnTerrainEditor_getTerrainBlocksMaterialList");

                return _GetTerrainBlocksMaterialListFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTerrainBlock__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetTerrainBlock(IntPtr _this, GetTerrainBlock__Args args);
            private static _GetTerrainBlock _GetTerrainBlockFunc;
            internal static _GetTerrainBlock GetTerrainBlock() {
               _GetTerrainBlockFunc ??= Torque3D.LookupEngineFunction<_GetTerrainBlock>("fnTerrainEditor_getTerrainBlock");

                return _GetTerrainBlockFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTerrainBlockCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetTerrainBlockCount(IntPtr _this, GetTerrainBlockCount__Args args);
            private static _GetTerrainBlockCount _GetTerrainBlockCountFunc;
            internal static _GetTerrainBlockCount GetTerrainBlockCount() {
               _GetTerrainBlockCountFunc ??= Torque3D.LookupEngineFunction<_GetTerrainBlockCount>("fnTerrainEditor_getTerrainBlockCount");

                return _GetTerrainBlockCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AttachTerrain__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string terrain;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AttachTerrain(IntPtr _this, AttachTerrain__Args args);
            private static _AttachTerrain _AttachTerrainFunc;
            internal static _AttachTerrain AttachTerrain() {
               _AttachTerrainFunc ??= Torque3D.LookupEngineFunction<_AttachTerrain>("fnTerrainEditor_attachTerrain");

                return _AttachTerrainFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnTerrainEditor_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnTerrainEditor_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Rule based terrain painting.
        /// </description>
        /// <param name="minHeight">Minimum terrain height.</param>
        /// <param name="maxHeight">Maximum terrain height.</param>
        /// <param name="minSlope">Minimum terrain slope.</param>
        /// <param name="maxSlope">Maximum terrain slope.</param>
        /// <param name="coverage">Terrain coverage amount.</param>
        public void AutoMaterialLayer(float minHeight, float maxHeight, float minSlope, float maxSlope, float coverage) {
             InternalUnsafeMethods.AutoMaterialLayer__Args _args = new InternalUnsafeMethods.AutoMaterialLayer__Args() {
                minHeight = minHeight,
                maxHeight = maxHeight,
                minSlope = minSlope,
                maxSlope = maxSlope,
                coverage = coverage,
             };
             InternalUnsafeMethods.AutoMaterialLayer()(ObjectPtr, _args);
        }

        /// 
        public float SetSlopeLimitMaxAngle(float angle) {
             InternalUnsafeMethods.SetSlopeLimitMaxAngle__Args _args = new InternalUnsafeMethods.SetSlopeLimitMaxAngle__Args() {
                angle = angle,
             };
             float _engineResult = InternalUnsafeMethods.SetSlopeLimitMaxAngle()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public float GetSlopeLimitMaxAngle() {
             InternalUnsafeMethods.GetSlopeLimitMaxAngle__Args _args = new InternalUnsafeMethods.GetSlopeLimitMaxAngle__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetSlopeLimitMaxAngle()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public float SetSlopeLimitMinAngle(float angle) {
             InternalUnsafeMethods.SetSlopeLimitMinAngle__Args _args = new InternalUnsafeMethods.SetSlopeLimitMinAngle__Args() {
                angle = angle,
             };
             float _engineResult = InternalUnsafeMethods.SetSlopeLimitMinAngle()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public float GetSlopeLimitMinAngle() {
             InternalUnsafeMethods.GetSlopeLimitMinAngle__Args _args = new InternalUnsafeMethods.GetSlopeLimitMinAngle__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetSlopeLimitMinAngle()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (x/y/z) Gets the terrain block that is located under the given world point.
        /// </description>
        /// <param name="x/y/z">The world coordinates (floating point values) you wish to query at. These can be formatted as either a string ("x y z") or separately as (x, y, z)</param>
        /// <returns>Returns the ID of the requested terrain block (0 if not found).</returns>
        public int GetTerrainUnderWorldPoint(string ptOrX = "", string Y = "", string Z = "") {
             InternalUnsafeMethods.GetTerrainUnderWorldPoint__Args _args = new InternalUnsafeMethods.GetTerrainUnderWorldPoint__Args() {
                ptOrX = ptOrX,
                Y = Y,
                Z = Z,
             };
             int _engineResult = InternalUnsafeMethods.GetTerrainUnderWorldPoint()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ( int index, int order ) - Reorder material at the given index to the new position, changing the order in which it is rendered / blended.
        /// </description>
        public void ReorderMaterial(int index, int orderPos) {
             InternalUnsafeMethods.ReorderMaterial__Args _args = new InternalUnsafeMethods.ReorderMaterial__Args() {
                index = index,
                orderPos = orderPos,
             };
             InternalUnsafeMethods.ReorderMaterial()(ObjectPtr, _args);
        }

        /// <description>
        /// ( string name ) - Returns the index of the material with the given name or -1.
        /// </description>
        public int GetMaterialIndex(string name) {
             InternalUnsafeMethods.GetMaterialIndex__Args _args = new InternalUnsafeMethods.GetMaterialIndex__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.GetMaterialIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ( int index ) - Returns the name of the material at the given index.
        /// </description>
        public string GetMaterialName(int index) {
             InternalUnsafeMethods.GetMaterialName__Args _args = new InternalUnsafeMethods.GetMaterialName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMaterialName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// () gets the list of current terrain materials.
        /// </description>
        public string GetMaterials() {
             InternalUnsafeMethods.GetMaterials__Args _args = new InternalUnsafeMethods.GetMaterials__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMaterials()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Returns the current material count.
        /// </description>
        public int GetMaterialCount() {
             InternalUnsafeMethods.GetMaterialCount__Args _args = new InternalUnsafeMethods.GetMaterialCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetMaterialCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ( int index ) - Remove the material at the given index.
        /// </description>
        public void RemoveMaterial(int index) {
             InternalUnsafeMethods.RemoveMaterial__Args _args = new InternalUnsafeMethods.RemoveMaterial__Args() {
                index = index,
             };
             InternalUnsafeMethods.RemoveMaterial()(ObjectPtr, _args);
        }

        /// <description>
        /// ( string matName )
        /// Adds a new material.
        /// </description>
        public int AddMaterial(string matName) {
             InternalUnsafeMethods.AddMaterial__Args _args = new InternalUnsafeMethods.AddMaterial__Args() {
                matName = matName,
             };
             int _engineResult = InternalUnsafeMethods.AddMaterial()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ( int index, string matName )
        /// Changes the material name at the index.
        /// </description>
        public bool UpdateMaterial(uint index, string matName) {
             InternalUnsafeMethods.UpdateMaterial__Args _args = new InternalUnsafeMethods.UpdateMaterial__Args() {
                index = index,
                matName = matName,
             };
             bool _engineResult = InternalUnsafeMethods.UpdateMaterial()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (bool overlayEnable) - sets the terraformer current heightmap to draw as an overlay over the current terrain.
        /// </description>
        public void SetTerraformOverlay(bool overlayEnable) {
             InternalUnsafeMethods.SetTerraformOverlay__Args _args = new InternalUnsafeMethods.SetTerraformOverlay__Args() {
                overlayEnable = overlayEnable,
             };
             InternalUnsafeMethods.SetTerraformOverlay()(ObjectPtr, _args);
        }

        /// 
        public void MirrorTerrain(int mirrorIndex) {
             InternalUnsafeMethods.MirrorTerrain__Args _args = new InternalUnsafeMethods.MirrorTerrain__Args() {
                mirrorIndex = mirrorIndex,
             };
             InternalUnsafeMethods.MirrorTerrain()(ObjectPtr, _args);
        }

        /// 
        public void MarkEmptySquares() {
             InternalUnsafeMethods.MarkEmptySquares__Args _args = new InternalUnsafeMethods.MarkEmptySquares__Args() {
             };
             InternalUnsafeMethods.MarkEmptySquares()(ObjectPtr, _args);
        }

        /// 
        public int GetNumTextures() {
             InternalUnsafeMethods.GetNumTextures__Args _args = new InternalUnsafeMethods.GetNumTextures__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetNumTextures()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public int GetActiveTerrain() {
             InternalUnsafeMethods.GetActiveTerrain__Args _args = new InternalUnsafeMethods.GetActiveTerrain__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetActiveTerrain()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (string action=NULL)
        /// </description>
        public void ProcessAction(string action = "") {
             InternalUnsafeMethods.ProcessAction__Args _args = new InternalUnsafeMethods.ProcessAction__Args() {
                action = action,
             };
             InternalUnsafeMethods.ProcessAction()(ObjectPtr, _args);
        }

        /// 
        public void ClearSelection() {
             InternalUnsafeMethods.ClearSelection__Args _args = new InternalUnsafeMethods.ClearSelection__Args() {
             };
             InternalUnsafeMethods.ClearSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// (bool clear)
        /// </description>
        public void ResetSelWeights(bool clear) {
             InternalUnsafeMethods.ResetSelWeights__Args _args = new InternalUnsafeMethods.ResetSelWeights__Args() {
                clear = clear,
             };
             InternalUnsafeMethods.ResetSelWeights()(ObjectPtr, _args);
        }

        /// 
        public string GetCurrentAction() {
             InternalUnsafeMethods.GetCurrentAction__Args _args = new InternalUnsafeMethods.GetCurrentAction__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetCurrentAction()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// 
        public int GetNumActions() {
             InternalUnsafeMethods.GetNumActions__Args _args = new InternalUnsafeMethods.GetNumActions__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetNumActions()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (int num)
        /// </description>
        public string GetActionName(uint index) {
             InternalUnsafeMethods.GetActionName__Args _args = new InternalUnsafeMethods.GetActionName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetActionName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (string action_name)
        /// </description>
        public void SetAction(string action_name) {
             InternalUnsafeMethods.SetAction__Args _args = new InternalUnsafeMethods.SetAction__Args() {
                action_name = action_name,
             };
             InternalUnsafeMethods.SetAction()(ObjectPtr, _args);
        }

        /// <description>
        /// Location
        /// </description>
        public void SetBrushPos(Point2I pos) {
pos.Alloc();             InternalUnsafeMethods.SetBrushPos__Args _args = new InternalUnsafeMethods.SetBrushPos__Args() {
                pos = pos.internalStructPtr,
             };
             InternalUnsafeMethods.SetBrushPos()(ObjectPtr, _args);
pos.Free();        }

        /// <description>
        /// Returns a Point2I.
        /// </description>
        public string GetBrushPos() {
             InternalUnsafeMethods.GetBrushPos__Args _args = new InternalUnsafeMethods.GetBrushPos__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetBrushPos()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// ()
        /// </description>
        public float GetBrushSoftness() {
             InternalUnsafeMethods.GetBrushSoftness__Args _args = new InternalUnsafeMethods.GetBrushSoftness__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetBrushSoftness()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (float softness)
        /// </description>
        public void SetBrushSoftness(float softness) {
             InternalUnsafeMethods.SetBrushSoftness__Args _args = new InternalUnsafeMethods.SetBrushSoftness__Args() {
                softness = softness,
             };
             InternalUnsafeMethods.SetBrushSoftness()(ObjectPtr, _args);
        }

        /// <description>
        /// ()
        /// </description>
        public float GetBrushPressure() {
             InternalUnsafeMethods.GetBrushPressure__Args _args = new InternalUnsafeMethods.GetBrushPressure__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetBrushPressure()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (float pressure)
        /// </description>
        public void SetBrushPressure(float pressure) {
             InternalUnsafeMethods.SetBrushPressure__Args _args = new InternalUnsafeMethods.SetBrushPressure__Args() {
                pressure = pressure,
             };
             InternalUnsafeMethods.SetBrushPressure()(ObjectPtr, _args);
        }

        /// <description>
        /// ()
        /// </description>
        public string GetBrushSize() {
             InternalUnsafeMethods.GetBrushSize__Args _args = new InternalUnsafeMethods.GetBrushSize__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetBrushSize()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (int w [, int h])
        /// </description>
        public void SetBrushSize(int w, int h = 0) {
             InternalUnsafeMethods.SetBrushSize__Args _args = new InternalUnsafeMethods.SetBrushSize__Args() {
                w = w,
                h = h,
             };
             InternalUnsafeMethods.SetBrushSize()(ObjectPtr, _args);
        }

        /// <description>
        /// ()
        /// </description>
        public string GetBrushType() {
             InternalUnsafeMethods.GetBrushType__Args _args = new InternalUnsafeMethods.GetBrushType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetBrushType()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (string type)One of box, ellipse, selection.
        /// </description>
        public void SetBrushType(string type) {
             InternalUnsafeMethods.SetBrushType__Args _args = new InternalUnsafeMethods.SetBrushType__Args() {
                type = type,
             };
             InternalUnsafeMethods.SetBrushType()(ObjectPtr, _args);
        }

        /// <description>
        /// () gets the list of current terrain materials for all terrain blocks.
        /// </description>
        public string GetTerrainBlocksMaterialList() {
             InternalUnsafeMethods.GetTerrainBlocksMaterialList__Args _args = new InternalUnsafeMethods.GetTerrainBlocksMaterialList__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTerrainBlocksMaterialList()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (S32 index)
        /// </description>
        public int GetTerrainBlock(int index) {
             InternalUnsafeMethods.GetTerrainBlock__Args _args = new InternalUnsafeMethods.GetTerrainBlock__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetTerrainBlock()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ()
        /// </description>
        public int GetTerrainBlockCount() {
             InternalUnsafeMethods.GetTerrainBlockCount__Args _args = new InternalUnsafeMethods.GetTerrainBlockCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetTerrainBlockCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (TerrainBlock terrain)
        /// </description>
        public void AttachTerrain(string terrain = "") {
             InternalUnsafeMethods.AttachTerrain__Args _args = new InternalUnsafeMethods.AttachTerrain__Args() {
                terrain = terrain,
             };
             InternalUnsafeMethods.AttachTerrain()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the TerrainEditor class.
        /// </description>
        /// <returns>The type info object for TerrainEditor</returns>
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
        public bool IsMissionDirty {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isMissionDirty"));
            set => SetFieldValue("isMissionDirty", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool RenderBorder {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderBorder"));
            set => SetFieldValue("renderBorder", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float BorderHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("borderHeight"));
            set => SetFieldValue("borderHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI BorderFillColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderFillColor"));
            set => SetFieldValue("borderFillColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI BorderFrameColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderFrameColor"));
            set => SetFieldValue("borderFrameColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool BorderLineMode {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("borderLineMode"));
            set => SetFieldValue("borderLineMode", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool SelectionHidden {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("selectionHidden"));
            set => SetFieldValue("selectionHidden", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool RenderVertexSelection {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderVertexSelection"));
            set => SetFieldValue("renderVertexSelection", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool RenderSolidBrush {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderSolidBrush"));
            set => SetFieldValue("renderSolidBrush", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool ProcessUsesBrush {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("processUsesBrush"));
            set => SetFieldValue("processUsesBrush", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public Point2I MaxBrushSize {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("maxBrushSize"));
            set => SetFieldValue("maxBrushSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float AdjustHeightVal {
            get => GenericMarshal.StringTo<float>(GetFieldValue("adjustHeightVal"));
            set => SetFieldValue("adjustHeightVal", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float SetHeightVal {
            get => GenericMarshal.StringTo<float>(GetFieldValue("setHeightVal"));
            set => SetFieldValue("setHeightVal", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float ScaleVal {
            get => GenericMarshal.StringTo<float>(GetFieldValue("scaleVal"));
            set => SetFieldValue("scaleVal", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float SmoothFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("smoothFactor"));
            set => SetFieldValue("smoothFactor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float NoiseFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("noiseFactor"));
            set => SetFieldValue("noiseFactor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public int MaterialGroup {
            get => GenericMarshal.StringTo<int>(GetFieldValue("materialGroup"));
            set => SetFieldValue("materialGroup", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float SoftSelectRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("softSelectRadius"));
            set => SetFieldValue("softSelectRadius", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string SoftSelectFilter {
            get => GenericMarshal.StringTo<string>(GetFieldValue("softSelectFilter"));
            set => SetFieldValue("softSelectFilter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string SoftSelectDefaultFilter {
            get => GenericMarshal.StringTo<string>(GetFieldValue("softSelectDefaultFilter"));
            set => SetFieldValue("softSelectDefaultFilter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float AdjustHeightMouseScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("adjustHeightMouseScale"));
            set => SetFieldValue("adjustHeightMouseScale", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public int PaintIndex {
            get => GenericMarshal.StringTo<int>(GetFieldValue("paintIndex"));
            set => SetFieldValue("paintIndex", GenericMarshal.ToString(value));
        }
    }
}
