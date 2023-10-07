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
    /// <summary>The main World Editor tool class</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class WorldEditor : EditTSCtrl {
        public WorldEditor(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public WorldEditor(string pName, bool pRegister)
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

        public WorldEditor(string pName)
            : this(pName, false) {
        }

        public WorldEditor(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public WorldEditor(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public WorldEditor(SimObject pObj)
            : base(pObj) {
        }

        public WorldEditor(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetActiveEditorTool__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetActiveEditorTool(IntPtr _this, GetActiveEditorTool__Args args);
            private static _GetActiveEditorTool _GetActiveEditorToolFunc;
            internal static _GetActiveEditorTool GetActiveEditorTool() {
               _GetActiveEditorToolFunc ??= Torque3D.LookupEngineFunction<_GetActiveEditorTool>("fnWorldEditor_getActiveEditorTool");

                return _GetActiveEditorToolFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetEditorTool__Args
            {
                internal IntPtr newEditorTool;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetEditorTool(IntPtr _this, SetEditorTool__Args args);
            private static _SetEditorTool _SetEditorToolFunc;
            internal static _SetEditorTool SetEditorTool() {
               _SetEditorToolFunc ??= Torque3D.LookupEngineFunction<_SetEditorTool>("fnWorldEditor_setEditorTool");

                return _SetEditorToolFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CreateConvexShapeFrom__Args
            {
                internal IntPtr polyObject;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _CreateConvexShapeFrom(IntPtr _this, CreateConvexShapeFrom__Args args);
            private static _CreateConvexShapeFrom _CreateConvexShapeFromFunc;
            internal static _CreateConvexShapeFrom CreateConvexShapeFrom() {
               _CreateConvexShapeFromFunc ??= Torque3D.LookupEngineFunction<_CreateConvexShapeFrom>("fnWorldEditor_createConvexShapeFrom");

                return _CreateConvexShapeFromFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CreatePolyhedralObject__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string className;
                internal IntPtr geometryProvider;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _CreatePolyhedralObject(IntPtr _this, CreatePolyhedralObject__Args args);
            private static _CreatePolyhedralObject _CreatePolyhedralObjectFunc;
            internal static _CreatePolyhedralObject CreatePolyhedralObject() {
               _CreatePolyhedralObjectFunc ??= Torque3D.LookupEngineFunction<_CreatePolyhedralObject>("fnWorldEditor_createPolyhedralObject");

                return _CreatePolyhedralObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MountRelative__Args
            {
                internal IntPtr objA;
                internal IntPtr objB;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _MountRelative(IntPtr _this, MountRelative__Args args);
            private static _MountRelative _MountRelativeFunc;
            internal static _MountRelative MountRelative() {
               _MountRelativeFunc ??= Torque3D.LookupEngineFunction<_MountRelative>("fnWorldEditor_mountRelative");

                return _MountRelativeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MakeSelectionAMesh__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _MakeSelectionAMesh(IntPtr _this, MakeSelectionAMesh__Args args);
            private static _MakeSelectionAMesh _MakeSelectionAMeshFunc;
            internal static _MakeSelectionAMesh MakeSelectionAMesh() {
               _MakeSelectionAMeshFunc ??= Torque3D.LookupEngineFunction<_MakeSelectionAMesh>("fnWorldEditor_makeSelectionAMesh");

                return _MakeSelectionAMeshFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ExplodeSelectedPrefab__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ExplodeSelectedPrefab(IntPtr _this, ExplodeSelectedPrefab__Args args);
            private static _ExplodeSelectedPrefab _ExplodeSelectedPrefabFunc;
            internal static _ExplodeSelectedPrefab ExplodeSelectedPrefab() {
               _ExplodeSelectedPrefabFunc ??= Torque3D.LookupEngineFunction<_ExplodeSelectedPrefab>("fnWorldEditor_explodeSelectedPrefab");

                return _ExplodeSelectedPrefabFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MakeSelectionPrefab__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
                [MarshalAs(UnmanagedType.I1)]
                internal bool dontDeleteOriginals;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _MakeSelectionPrefab(IntPtr _this, MakeSelectionPrefab__Args args);
            private static _MakeSelectionPrefab _MakeSelectionPrefabFunc;
            internal static _MakeSelectionPrefab MakeSelectionPrefab() {
               _MakeSelectionPrefabFunc ??= Torque3D.LookupEngineFunction<_MakeSelectionPrefab>("fnWorldEditor_makeSelectionPrefab");

                return _MakeSelectionPrefabFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ColladaExportSelection__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ColladaExportSelection(IntPtr _this, ColladaExportSelection__Args args);
            private static _ColladaExportSelection _ColladaExportSelectionFunc;
            internal static _ColladaExportSelection ColladaExportSelection() {
               _ColladaExportSelectionFunc ??= Torque3D.LookupEngineFunction<_ColladaExportSelection>("fnWorldEditor_colladaExportSelection");

                return _ColladaExportSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct TransformSelection__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool position;
                internal IntPtr point;
                [MarshalAs(UnmanagedType.I1)]
                internal bool relativePos;
                [MarshalAs(UnmanagedType.I1)]
                internal bool rotate;
                internal IntPtr rotation;
                [MarshalAs(UnmanagedType.I1)]
                internal bool relativeRot;
                [MarshalAs(UnmanagedType.I1)]
                internal bool rotLocal;
                internal int scaleType;
                internal IntPtr scale;
                [MarshalAs(UnmanagedType.I1)]
                internal bool sRelative;
                [MarshalAs(UnmanagedType.I1)]
                internal bool sLocal;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _TransformSelection(IntPtr _this, TransformSelection__Args args);
            private static _TransformSelection _TransformSelectionFunc;
            internal static _TransformSelection TransformSelection() {
               _TransformSelectionFunc ??= Torque3D.LookupEngineFunction<_TransformSelection>("fnWorldEditor_transformSelection");

                return _TransformSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTerrainSnapAlignment__Args
            {
                internal int alignment;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTerrainSnapAlignment(IntPtr _this, SetTerrainSnapAlignment__Args args);
            private static _SetTerrainSnapAlignment _SetTerrainSnapAlignmentFunc;
            internal static _SetTerrainSnapAlignment SetTerrainSnapAlignment() {
               _SetTerrainSnapAlignmentFunc ??= Torque3D.LookupEngineFunction<_SetTerrainSnapAlignment>("fnWorldEditor_setTerrainSnapAlignment");

                return _SetTerrainSnapAlignmentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTerrainSnapAlignment__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetTerrainSnapAlignment(IntPtr _this, GetTerrainSnapAlignment__Args args);
            private static _GetTerrainSnapAlignment _GetTerrainSnapAlignmentFunc;
            internal static _GetTerrainSnapAlignment GetTerrainSnapAlignment() {
               _GetTerrainSnapAlignmentFunc ??= Torque3D.LookupEngineFunction<_GetTerrainSnapAlignment>("fnWorldEditor_getTerrainSnapAlignment");

                return _GetTerrainSnapAlignmentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SoftSnapDebugRender__Args
            {
                internal float debugRender;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SoftSnapDebugRender(IntPtr _this, SoftSnapDebugRender__Args args);
            private static _SoftSnapDebugRender _SoftSnapDebugRenderFunc;
            internal static _SoftSnapDebugRender SoftSnapDebugRender() {
               _SoftSnapDebugRenderFunc ??= Torque3D.LookupEngineFunction<_SoftSnapDebugRender>("fnWorldEditor_softSnapDebugRender");

                return _SoftSnapDebugRenderFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SoftSnapRenderTriangle__Args
            {
                internal float renderTriangle;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SoftSnapRenderTriangle(IntPtr _this, SoftSnapRenderTriangle__Args args);
            private static _SoftSnapRenderTriangle _SoftSnapRenderTriangleFunc;
            internal static _SoftSnapRenderTriangle SoftSnapRenderTriangle() {
               _SoftSnapRenderTriangleFunc ??= Torque3D.LookupEngineFunction<_SoftSnapRenderTriangle>("fnWorldEditor_softSnapRenderTriangle");

                return _SoftSnapRenderTriangleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SoftSnapRender__Args
            {
                internal float render;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SoftSnapRender(IntPtr _this, SoftSnapRender__Args args);
            private static _SoftSnapRender _SoftSnapRenderFunc;
            internal static _SoftSnapRender SoftSnapRender() {
               _SoftSnapRenderFunc ??= Torque3D.LookupEngineFunction<_SoftSnapRender>("fnWorldEditor_softSnapRender");

                return _SoftSnapRenderFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSoftSnapBackfaceTolerance__Args
            {
                internal float tolerance;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSoftSnapBackfaceTolerance(IntPtr _this, SetSoftSnapBackfaceTolerance__Args args);
            private static _SetSoftSnapBackfaceTolerance _SetSoftSnapBackfaceToleranceFunc;
            internal static _SetSoftSnapBackfaceTolerance SetSoftSnapBackfaceTolerance() {
               _SetSoftSnapBackfaceToleranceFunc ??= Torque3D.LookupEngineFunction<_SetSoftSnapBackfaceTolerance>("fnWorldEditor_setSoftSnapBackfaceTolerance");

                return _SetSoftSnapBackfaceToleranceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSoftSnapBackfaceTolerance__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetSoftSnapBackfaceTolerance(IntPtr _this, GetSoftSnapBackfaceTolerance__Args args);
            private static _GetSoftSnapBackfaceTolerance _GetSoftSnapBackfaceToleranceFunc;
            internal static _GetSoftSnapBackfaceTolerance GetSoftSnapBackfaceTolerance() {
               _GetSoftSnapBackfaceToleranceFunc ??= Torque3D.LookupEngineFunction<_GetSoftSnapBackfaceTolerance>("fnWorldEditor_getSoftSnapBackfaceTolerance");

                return _GetSoftSnapBackfaceToleranceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SoftSnapSizeByBounds__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool useBounds;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SoftSnapSizeByBounds(IntPtr _this, SoftSnapSizeByBounds__Args args);
            private static _SoftSnapSizeByBounds _SoftSnapSizeByBoundsFunc;
            internal static _SoftSnapSizeByBounds SoftSnapSizeByBounds() {
               _SoftSnapSizeByBoundsFunc ??= Torque3D.LookupEngineFunction<_SoftSnapSizeByBounds>("fnWorldEditor_softSnapSizeByBounds");

                return _SoftSnapSizeByBoundsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSoftSnapAlignment__Args
            {
                internal int type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSoftSnapAlignment(IntPtr _this, SetSoftSnapAlignment__Args args);
            private static _SetSoftSnapAlignment _SetSoftSnapAlignmentFunc;
            internal static _SetSoftSnapAlignment SetSoftSnapAlignment() {
               _SetSoftSnapAlignmentFunc ??= Torque3D.LookupEngineFunction<_SetSoftSnapAlignment>("fnWorldEditor_setSoftSnapAlignment");

                return _SetSoftSnapAlignmentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSoftSnapAlignment__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSoftSnapAlignment(IntPtr _this, GetSoftSnapAlignment__Args args);
            private static _GetSoftSnapAlignment _GetSoftSnapAlignmentFunc;
            internal static _GetSoftSnapAlignment GetSoftSnapAlignment() {
               _GetSoftSnapAlignmentFunc ??= Torque3D.LookupEngineFunction<_GetSoftSnapAlignment>("fnWorldEditor_getSoftSnapAlignment");

                return _GetSoftSnapAlignmentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSoftSnapSize__Args
            {
                internal float size;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSoftSnapSize(IntPtr _this, SetSoftSnapSize__Args args);
            private static _SetSoftSnapSize _SetSoftSnapSizeFunc;
            internal static _SetSoftSnapSize SetSoftSnapSize() {
               _SetSoftSnapSizeFunc ??= Torque3D.LookupEngineFunction<_SetSoftSnapSize>("fnWorldEditor_setSoftSnapSize");

                return _SetSoftSnapSizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSoftSnapSize__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetSoftSnapSize(IntPtr _this, GetSoftSnapSize__Args args);
            private static _GetSoftSnapSize _GetSoftSnapSizeFunc;
            internal static _GetSoftSnapSize GetSoftSnapSize() {
               _GetSoftSnapSizeFunc ??= Torque3D.LookupEngineFunction<_GetSoftSnapSize>("fnWorldEditor_getSoftSnapSize");

                return _GetSoftSnapSizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSoftSnap__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool softSnap;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSoftSnap(IntPtr _this, SetSoftSnap__Args args);
            private static _SetSoftSnap _SetSoftSnapFunc;
            internal static _SetSoftSnap SetSoftSnap() {
               _SetSoftSnapFunc ??= Torque3D.LookupEngineFunction<_SetSoftSnap>("fnWorldEditor_setSoftSnap");

                return _SetSoftSnapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSoftSnap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetSoftSnap(IntPtr _this, GetSoftSnap__Args args);
            private static _GetSoftSnap _GetSoftSnapFunc;
            internal static _GetSoftSnap GetSoftSnap() {
               _GetSoftSnapFunc ??= Torque3D.LookupEngineFunction<_GetSoftSnap>("fnWorldEditor_getSoftSnap");

                return _GetSoftSnapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddUndoState__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddUndoState(IntPtr _this, AddUndoState__Args args);
            private static _AddUndoState _AddUndoStateFunc;
            internal static _AddUndoState AddUndoState() {
               _AddUndoStateFunc ??= Torque3D.LookupEngineFunction<_AddUndoState>("fnWorldEditor_addUndoState");

                return _AddUndoStateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RedirectConsole__Args
            {
                internal int objID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RedirectConsole(IntPtr _this, RedirectConsole__Args args);
            private static _RedirectConsole _RedirectConsoleFunc;
            internal static _RedirectConsole RedirectConsole() {
               _RedirectConsoleFunc ??= Torque3D.LookupEngineFunction<_RedirectConsole>("fnWorldEditor_redirectConsole");

                return _RedirectConsoleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetSelectedScale__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetSelectedScale(IntPtr _this, ResetSelectedScale__Args args);
            private static _ResetSelectedScale _ResetSelectedScaleFunc;
            internal static _ResetSelectedScale ResetSelectedScale() {
               _ResetSelectedScaleFunc ??= Torque3D.LookupEngineFunction<_ResetSelectedScale>("fnWorldEditor_resetSelectedScale");

                return _ResetSelectedScaleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetSelectedRotation__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetSelectedRotation(IntPtr _this, ResetSelectedRotation__Args args);
            private static _ResetSelectedRotation _ResetSelectedRotationFunc;
            internal static _ResetSelectedRotation ResetSelectedRotation() {
               _ResetSelectedRotationFunc ??= Torque3D.LookupEngineFunction<_ResetSelectedRotation>("fnWorldEditor_resetSelectedRotation");

                return _ResetSelectedRotationFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AlignByAxis__Args
            {
                internal int axis;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AlignByAxis(IntPtr _this, AlignByAxis__Args args);
            private static _AlignByAxis _AlignByAxisFunc;
            internal static _AlignByAxis AlignByAxis() {
               _AlignByAxisFunc ??= Torque3D.LookupEngineFunction<_AlignByAxis>("fnWorldEditor_alignByAxis");

                return _AlignByAxisFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AlignByBounds__Args
            {
                internal int boundsAxis;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AlignByBounds(IntPtr _this, AlignByBounds__Args args);
            private static _AlignByBounds _AlignByBoundsFunc;
            internal static _AlignByBounds AlignByBounds() {
               _AlignByBoundsFunc ??= Torque3D.LookupEngineFunction<_AlignByBounds>("fnWorldEditor_alignByBounds");

                return _AlignByBoundsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct LockSelection__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool _lock;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _LockSelection(IntPtr _this, LockSelection__Args args);
            private static _LockSelection _LockSelectionFunc;
            internal static _LockSelection LockSelection() {
               _LockSelectionFunc ??= Torque3D.LookupEngineFunction<_LockSelection>("fnWorldEditor_lockSelection");

                return _LockSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct HideSelection__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool hide;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _HideSelection(IntPtr _this, HideSelection__Args args);
            private static _HideSelection _HideSelectionFunc;
            internal static _HideSelection HideSelection() {
               _HideSelectionFunc ??= Torque3D.LookupEngineFunction<_HideSelection>("fnWorldEditor_hideSelection");

                return _HideSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct HideObject__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.I1)]
                internal bool hide;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _HideObject(IntPtr _this, HideObject__Args args);
            private static _HideObject _HideObjectFunc;
            internal static _HideObject HideObject() {
               _HideObjectFunc ??= Torque3D.LookupEngineFunction<_HideObject>("fnWorldEditor_hideObject");

                return _HideObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CanPasteSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _CanPasteSelection(IntPtr _this, CanPasteSelection__Args args);
            private static _CanPasteSelection _CanPasteSelectionFunc;
            internal static _CanPasteSelection CanPasteSelection() {
               _CanPasteSelectionFunc ??= Torque3D.LookupEngineFunction<_CanPasteSelection>("fnWorldEditor_canPasteSelection");

                return _CanPasteSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PasteSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PasteSelection(IntPtr _this, PasteSelection__Args args);
            private static _PasteSelection _PasteSelectionFunc;
            internal static _PasteSelection PasteSelection() {
               _PasteSelectionFunc ??= Torque3D.LookupEngineFunction<_PasteSelection>("fnWorldEditor_pasteSelection");

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
               _CopySelectionFunc ??= Torque3D.LookupEngineFunction<_CopySelection>("fnWorldEditor_copySelection");

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
               _CutSelectionFunc ??= Torque3D.LookupEngineFunction<_CutSelection>("fnWorldEditor_cutSelection");

                return _CutSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DropSelection__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool skipUndo;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DropSelection(IntPtr _this, DropSelection__Args args);
            private static _DropSelection _DropSelectionFunc;
            internal static _DropSelection DropSelection() {
               _DropSelectionFunc ??= Torque3D.LookupEngineFunction<_DropSelection>("fnWorldEditor_dropSelection");

                return _DropSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectionExtent__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetSelectionExtent(IntPtr _this, GetSelectionExtent__Args args);
            private static _GetSelectionExtent _GetSelectionExtentFunc;
            internal static _GetSelectionExtent GetSelectionExtent() {
               _GetSelectionExtentFunc ??= Torque3D.LookupEngineFunction<_GetSelectionExtent>("fnWorldEditor_getSelectionExtent");

                return _GetSelectionExtentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectionCentroid__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetSelectionCentroid(IntPtr _this, GetSelectionCentroid__Args args);
            private static _GetSelectionCentroid _GetSelectionCentroidFunc;
            internal static _GetSelectionCentroid GetSelectionCentroid() {
               _GetSelectionCentroidFunc ??= Torque3D.LookupEngineFunction<_GetSelectionCentroid>("fnWorldEditor_getSelectionCentroid");

                return _GetSelectionCentroidFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectionRadius__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetSelectionRadius(IntPtr _this, GetSelectionRadius__Args args);
            private static _GetSelectionRadius _GetSelectionRadiusFunc;
            internal static _GetSelectionRadius GetSelectionRadius() {
               _GetSelectionRadiusFunc ??= Torque3D.LookupEngineFunction<_GetSelectionRadius>("fnWorldEditor_getSelectionRadius");

                return _GetSelectionRadiusFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedObject__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectedObject(IntPtr _this, GetSelectedObject__Args args);
            private static _GetSelectedObject _GetSelectedObjectFunc;
            internal static _GetSelectedObject GetSelectedObject() {
               _GetSelectedObjectFunc ??= Torque3D.LookupEngineFunction<_GetSelectedObject>("fnWorldEditor_getSelectedObject");

                return _GetSelectedObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectionSize__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectionSize(IntPtr _this, GetSelectionSize__Args args);
            private static _GetSelectionSize _GetSelectionSizeFunc;
            internal static _GetSelectionSize GetSelectionSize() {
               _GetSelectionSizeFunc ??= Torque3D.LookupEngineFunction<_GetSelectionSize>("fnWorldEditor_getSelectionSize");

                return _GetSelectionSizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct InvalidateSelectionCentroid__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _InvalidateSelectionCentroid(IntPtr _this, InvalidateSelectionCentroid__Args args);
            private static _InvalidateSelectionCentroid _InvalidateSelectionCentroidFunc;
            internal static _InvalidateSelectionCentroid InvalidateSelectionCentroid() {
               _InvalidateSelectionCentroidFunc ??= Torque3D.LookupEngineFunction<_InvalidateSelectionCentroid>("fnWorldEditor_invalidateSelectionCentroid");

                return _InvalidateSelectionCentroidFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UnselectObject__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UnselectObject(IntPtr _this, UnselectObject__Args args);
            private static _UnselectObject _UnselectObjectFunc;
            internal static _UnselectObject UnselectObject() {
               _UnselectObjectFunc ??= Torque3D.LookupEngineFunction<_UnselectObject>("fnWorldEditor_unselectObject");

                return _UnselectObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectObject__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SelectObject(IntPtr _this, SelectObject__Args args);
            private static _SelectObject _SelectObjectFunc;
            internal static _SelectObject SelectObject() {
               _SelectObjectFunc ??= Torque3D.LookupEngineFunction<_SelectObject>("fnWorldEditor_selectObject");

                return _SelectObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetActiveSelection__Args
            {
                internal IntPtr selection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetActiveSelection(IntPtr _this, SetActiveSelection__Args args);
            private static _SetActiveSelection _SetActiveSelectionFunc;
            internal static _SetActiveSelection SetActiveSelection() {
               _SetActiveSelectionFunc ??= Torque3D.LookupEngineFunction<_SetActiveSelection>("fnWorldEditor_setActiveSelection");

                return _SetActiveSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetActiveSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetActiveSelection(IntPtr _this, GetActiveSelection__Args args);
            private static _GetActiveSelection _GetActiveSelectionFunc;
            internal static _GetActiveSelection GetActiveSelection() {
               _GetActiveSelectionFunc ??= Torque3D.LookupEngineFunction<_GetActiveSelection>("fnWorldEditor_getActiveSelection");

                return _GetActiveSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearSelection(IntPtr _this, ClearSelection__Args args);
            private static _ClearSelection _ClearSelectionFunc;
            internal static _ClearSelection ClearSelection() {
               _ClearSelectionFunc ??= Torque3D.LookupEngineFunction<_ClearSelection>("fnWorldEditor_clearSelection");

                return _ClearSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearIgnoreList__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearIgnoreList(IntPtr _this, ClearIgnoreList__Args args);
            private static _ClearIgnoreList _ClearIgnoreListFunc;
            internal static _ClearIgnoreList ClearIgnoreList() {
               _ClearIgnoreListFunc ??= Torque3D.LookupEngineFunction<_ClearIgnoreList>("fnWorldEditor_clearIgnoreList");

                return _ClearIgnoreListFunc;
            }



            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _IgnoreObjClass(IntPtr _this, ref StringVector.InternalStruct args);
            private static _IgnoreObjClass _IgnoreObjClassFunc;
            internal static _IgnoreObjClass IgnoreObjClass() {
               _IgnoreObjClassFunc ??= Torque3D.LookupEngineFunction<_IgnoreObjClass>("fnWorldEditor_ignoreObjClass");

                return _IgnoreObjClassFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnWorldEditor_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnWorldEditor_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Gets the active Editor Tool for the world editor.
        /// </description>
        public EditorTool GetActiveEditorTool() {
             InternalUnsafeMethods.GetActiveEditorTool__Args _args = new InternalUnsafeMethods.GetActiveEditorTool__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetActiveEditorTool()(ObjectPtr, _args);
             return new EditorTool(_engineResult);
        }

        /// <description>
        /// Sets the active Editor Tool for the world editor.
        /// </description>
        public void SetEditorTool(EditorTool newEditorTool = null) {
             InternalUnsafeMethods.SetEditorTool__Args _args = new InternalUnsafeMethods.SetEditorTool__Args() {
                newEditorTool = newEditorTool.ObjectPtr,
             };
             InternalUnsafeMethods.SetEditorTool()(ObjectPtr, _args);
        }

        /// <description>
        /// Create a ConvexShape from the given polyhedral object.
        /// </description>
        public ConvexShape CreateConvexShapeFrom(SceneObject polyObject) {
             InternalUnsafeMethods.CreateConvexShapeFrom__Args _args = new InternalUnsafeMethods.CreateConvexShapeFrom__Args() {
                polyObject = polyObject.ObjectPtr,
             };
             IntPtr _engineResult = InternalUnsafeMethods.CreateConvexShapeFrom()(ObjectPtr, _args);
             return new ConvexShape(_engineResult);
        }

        /// <description>
        /// Grab the geometry from<paramref name="" /> geometryProvider, create a 
        /// </description>
        public SceneObject CreatePolyhedralObject(string className, SceneObject geometryProvider) {
             InternalUnsafeMethods.CreatePolyhedralObject__Args _args = new InternalUnsafeMethods.CreatePolyhedralObject__Args() {
                className = className,
                geometryProvider = geometryProvider.ObjectPtr,
             };
             IntPtr _engineResult = InternalUnsafeMethods.CreatePolyhedralObject()(ObjectPtr, _args);
             return new SceneObject(_engineResult);
        }

        /// <description>
        /// Mount object B relatively to object A.
        /// </description>
        /// <param name="objA">Object to mount to.</param>
        /// <param name="objB">Object to mount.</param>
        public void MountRelative(SceneObject objA, SceneObject objB) {
             InternalUnsafeMethods.MountRelative__Args _args = new InternalUnsafeMethods.MountRelative__Args() {
                objA = objA.ObjectPtr,
                objB = objB.ObjectPtr,
             };
             InternalUnsafeMethods.MountRelative()(ObjectPtr, _args);
        }

        /// <description>
        /// Save selected objects to a .dae collada file and replace them in the level with a TSStatic object.
        /// </description>
        /// <param name="filename">collada file to save the selected objects to.</param>
        public bool MakeSelectionAMesh(string filename) {
             InternalUnsafeMethods.MakeSelectionAMesh__Args _args = new InternalUnsafeMethods.MakeSelectionAMesh__Args() {
                filename = filename,
             };
             bool _engineResult = InternalUnsafeMethods.MakeSelectionAMesh()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Replace selected Prefab objects with a SimGroup containing all children objects defined in the .prefab.
        /// </description>
        public void ExplodeSelectedPrefab() {
             InternalUnsafeMethods.ExplodeSelectedPrefab__Args _args = new InternalUnsafeMethods.ExplodeSelectedPrefab__Args() {
             };
             InternalUnsafeMethods.ExplodeSelectedPrefab()(ObjectPtr, _args);
        }

        /// <description>
        /// Save selected objects to a .prefab file and replace them in the level with a Prefab object.
        /// </description>
        /// <param name="filename">Prefab file to save the selected objects to.</param>
        public void MakeSelectionPrefab(string filename, bool dontDeleteOriginals = false) {
             InternalUnsafeMethods.MakeSelectionPrefab__Args _args = new InternalUnsafeMethods.MakeSelectionPrefab__Args() {
                filename = filename,
                dontDeleteOriginals = dontDeleteOriginals,
             };
             InternalUnsafeMethods.MakeSelectionPrefab()(ObjectPtr, _args);
        }

        /// <description>
        /// Export the combined geometry of all selected objects to the specified path in collada format.
        /// </description>
        /// <param name="path">Path to export collada format to.</param>
        public void ColladaExportSelection(string path) {
             InternalUnsafeMethods.ColladaExportSelection__Args _args = new InternalUnsafeMethods.ColladaExportSelection__Args() {
                path = path,
             };
             InternalUnsafeMethods.ColladaExportSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Transform selection by given parameters.
        /// </description>
        /// <param name="position">True to transform the selection's position.</param>
        /// <param name="point">Position to transform by.</param>
        /// <param name="relativePos">True to use relative position.</param>
        /// <param name="rotate">True to transform the selection's rotation.</param>
        /// <param name="rotation">Rotation to transform by.</param>
        /// <param name="relativeRot">True to use the relative rotation.</param>
        /// <param name="rotLocal">True to use the local rotation.</param>
        /// <param name="scaleType">Scale type to use.</param>
        /// <param name="scale">Scale to transform by.</param>
        /// <param name="sRelative">True to use a relative scale.</param>
        /// <param name="sLocal">True to use a local scale.</param>
        public void TransformSelection(bool position, Point3F point, bool relativePos, bool rotate, Point3F rotation, bool relativeRot, bool rotLocal, int scaleType, Point3F scale, bool sRelative, bool sLocal) {
point.Alloc();rotation.Alloc();scale.Alloc();             InternalUnsafeMethods.TransformSelection__Args _args = new InternalUnsafeMethods.TransformSelection__Args() {
                position = position,
                point = point.internalStructPtr,
                relativePos = relativePos,
                rotate = rotate,
                rotation = rotation.internalStructPtr,
                relativeRot = relativeRot,
                rotLocal = rotLocal,
                scaleType = scaleType,
                scale = scale.internalStructPtr,
                sRelative = sRelative,
                sLocal = sLocal,
             };
             InternalUnsafeMethods.TransformSelection()(ObjectPtr, _args);
point.Free();rotation.Free();scale.Free();        }

        /// <description>
        /// Set the terrain snap alignment.
        /// </description>
        /// <param name="alignment">New terrain snap alignment type.</param>
        public void SetTerrainSnapAlignment(WorldEditorAlignmentType alignment) {
             InternalUnsafeMethods.SetTerrainSnapAlignment__Args _args = new InternalUnsafeMethods.SetTerrainSnapAlignment__Args() {
                alignment = (int)alignment,
             };
             InternalUnsafeMethods.SetTerrainSnapAlignment()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the terrain snap alignment.
        /// </description>
        /// <returns>terrain snap alignment type.</returns>
        public WorldEditorAlignmentType GetTerrainSnapAlignment() {
             InternalUnsafeMethods.GetTerrainSnapAlignment__Args _args = new InternalUnsafeMethods.GetTerrainSnapAlignment__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetTerrainSnapAlignment()(ObjectPtr, _args);
             return (WorldEditorAlignmentType)_engineResult;
        }

        /// <description>
        /// Toggle soft snapping debug rendering.
        /// </description>
        /// <param name="debugRender">True to turn on soft snapping debug rendering, false to turn it off.</param>
        public void SoftSnapDebugRender(float debugRender) {
             InternalUnsafeMethods.SoftSnapDebugRender__Args _args = new InternalUnsafeMethods.SoftSnapDebugRender__Args() {
                debugRender = debugRender,
             };
             InternalUnsafeMethods.SoftSnapDebugRender()(ObjectPtr, _args);
        }

        /// <description>
        /// Render the soft snapped triangle.
        /// </description>
        /// <param name="renderTriangle">True to render the soft snapped triangle, false to not.</param>
        public void SoftSnapRenderTriangle(float renderTriangle) {
             InternalUnsafeMethods.SoftSnapRenderTriangle__Args _args = new InternalUnsafeMethods.SoftSnapRenderTriangle__Args() {
                renderTriangle = renderTriangle,
             };
             InternalUnsafeMethods.SoftSnapRenderTriangle()(ObjectPtr, _args);
        }

        /// <description>
        /// Render the soft snapping bounds.
        /// </description>
        /// <param name="render">True to render the soft snapping bounds, false to not.</param>
        public void SoftSnapRender(float render) {
             InternalUnsafeMethods.SoftSnapRender__Args _args = new InternalUnsafeMethods.SoftSnapRender__Args() {
                render = render,
             };
             InternalUnsafeMethods.SoftSnapRender()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the fraction of the soft snap radius that backfaces may be included.
        /// </description>
        /// <param name="tolerance">Fraction of the soft snap radius that backfaces may be included (range of 0..1).</param>
        public void SetSoftSnapBackfaceTolerance(float tolerance) {
             InternalUnsafeMethods.SetSoftSnapBackfaceTolerance__Args _args = new InternalUnsafeMethods.SetSoftSnapBackfaceTolerance__Args() {
                tolerance = tolerance,
             };
             InternalUnsafeMethods.SetSoftSnapBackfaceTolerance()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the fraction of the soft snap radius that backfaces may be included.
        /// </description>
        /// <returns>fraction of the soft snap radius that backfaces may be included.</returns>
        public float GetSoftSnapBackfaceTolerance() {
             InternalUnsafeMethods.GetSoftSnapBackfaceTolerance__Args _args = new InternalUnsafeMethods.GetSoftSnapBackfaceTolerance__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetSoftSnapBackfaceTolerance()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Use selection bounds size as soft snap bounds.
        /// </description>
        /// <param name="useBounds">True to use selection bounds size as soft snap bounds, false to not.</param>
        public void SoftSnapSizeByBounds(bool useBounds) {
             InternalUnsafeMethods.SoftSnapSizeByBounds__Args _args = new InternalUnsafeMethods.SoftSnapSizeByBounds__Args() {
                useBounds = useBounds,
             };
             InternalUnsafeMethods.SoftSnapSizeByBounds()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the soft snap alignment.
        /// </description>
        /// <param name="type">Soft snap alignment type.</param>
        public void SetSoftSnapAlignment(WorldEditorAlignmentType type) {
             InternalUnsafeMethods.SetSoftSnapAlignment__Args _args = new InternalUnsafeMethods.SetSoftSnapAlignment__Args() {
                type = (int)type,
             };
             InternalUnsafeMethods.SetSoftSnapAlignment()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the soft snap alignment.
        /// </description>
        /// <returns>soft snap alignment.</returns>
        public WorldEditorAlignmentType GetSoftSnapAlignment() {
             InternalUnsafeMethods.GetSoftSnapAlignment__Args _args = new InternalUnsafeMethods.GetSoftSnapAlignment__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSoftSnapAlignment()(ObjectPtr, _args);
             return (WorldEditorAlignmentType)_engineResult;
        }

        /// <description>
        /// Set the absolute size to trigger a soft snap.
        /// </description>
        /// <param name="size">Absolute size to trigger a soft snap.</param>
        public void SetSoftSnapSize(float size) {
             InternalUnsafeMethods.SetSoftSnapSize__Args _args = new InternalUnsafeMethods.SetSoftSnapSize__Args() {
                size = size,
             };
             InternalUnsafeMethods.SetSoftSnapSize()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the absolute size to trigger a soft snap.
        /// </description>
        /// <returns>absolute size to trigger a soft snap.</returns>
        public float GetSoftSnapSize() {
             InternalUnsafeMethods.GetSoftSnapSize__Args _args = new InternalUnsafeMethods.GetSoftSnapSize__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetSoftSnapSize()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Allow soft snapping all of the time.
        /// </description>
        /// <param name="softSnap">True to turn soft snap on, false to turn it off.</param>
        public void SetSoftSnap(bool softSnap) {
             InternalUnsafeMethods.SetSoftSnap__Args _args = new InternalUnsafeMethods.SetSoftSnap__Args() {
                softSnap = softSnap,
             };
             InternalUnsafeMethods.SetSoftSnap()(ObjectPtr, _args);
        }

        /// <description>
        /// Is soft snapping always on?
        /// </description>
        /// <returns>True if soft snap is on, false if not.</returns>
        public bool GetSoftSnap() {
             InternalUnsafeMethods.GetSoftSnap__Args _args = new InternalUnsafeMethods.GetSoftSnap__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetSoftSnap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Adds/Submits an undo state to the undo manager.
        /// </description>
        public void AddUndoState() {
             InternalUnsafeMethods.AddUndoState__Args _args = new InternalUnsafeMethods.AddUndoState__Args() {
             };
             InternalUnsafeMethods.AddUndoState()(ObjectPtr, _args);
        }

        /// <description>
        /// Redirect console.
        /// </description>
        /// <param name="objID">Object id.</param>
        public void RedirectConsole(int objID) {
             InternalUnsafeMethods.RedirectConsole__Args _args = new InternalUnsafeMethods.RedirectConsole__Args() {
                objID = objID,
             };
             InternalUnsafeMethods.RedirectConsole()(ObjectPtr, _args);
        }

        /// <description>
        /// Reset the scale of the selection.
        /// </description>
        public void ResetSelectedScale() {
             InternalUnsafeMethods.ResetSelectedScale__Args _args = new InternalUnsafeMethods.ResetSelectedScale__Args() {
             };
             InternalUnsafeMethods.ResetSelectedScale()(ObjectPtr, _args);
        }

        /// <description>
        /// Reset the rotation of the selection.
        /// </description>
        public void ResetSelectedRotation() {
             InternalUnsafeMethods.ResetSelectedRotation__Args _args = new InternalUnsafeMethods.ResetSelectedRotation__Args() {
             };
             InternalUnsafeMethods.ResetSelectedRotation()(ObjectPtr, _args);
        }

        /// <description>
        /// Align all selected objects along the given axis.
        /// </description>
        /// <param name="axis">Axis to align all selected objects along.</param>
        public void AlignByAxis(int axis) {
             InternalUnsafeMethods.AlignByAxis__Args _args = new InternalUnsafeMethods.AlignByAxis__Args() {
                axis = axis,
             };
             InternalUnsafeMethods.AlignByAxis()(ObjectPtr, _args);
        }

        /// <description>
        /// Align all selected objects against the given bounds axis.
        /// </description>
        /// <param name="boundsAxis">Bounds axis to align all selected objects against.</param>
        public void AlignByBounds(int boundsAxis) {
             InternalUnsafeMethods.AlignByBounds__Args _args = new InternalUnsafeMethods.AlignByBounds__Args() {
                boundsAxis = boundsAxis,
             };
             InternalUnsafeMethods.AlignByBounds()(ObjectPtr, _args);
        }

        /// <description>
        /// Lock/unlock the selection.
        /// </description>
        /// <param name="lock">True to lock the selection, false to unlock it.</param>
        public void LockSelection(bool _lock) {
             InternalUnsafeMethods.LockSelection__Args _args = new InternalUnsafeMethods.LockSelection__Args() {
                _lock = _lock,
             };
             InternalUnsafeMethods.LockSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Hide/show the selection.
        /// </description>
        /// <param name="hide">True to hide the selection, false to show it.</param>
        public void HideSelection(bool hide) {
             InternalUnsafeMethods.HideSelection__Args _args = new InternalUnsafeMethods.HideSelection__Args() {
                hide = hide,
             };
             InternalUnsafeMethods.HideSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Hide/show the given object.
        /// </description>
        /// <param name="obj	Object">to hide/show.</param>
        /// <param name="hide">True to hide the object, false to show it.</param>
        public void HideObject(SceneObject obj, bool hide) {
             InternalUnsafeMethods.HideObject__Args _args = new InternalUnsafeMethods.HideObject__Args() {
                obj = obj.ObjectPtr,
                hide = hide,
             };
             InternalUnsafeMethods.HideObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Check if we can paste the current selection.
        /// </description>
        /// <returns>True if we can paste the current selection, false if not.</returns>
        public bool CanPasteSelection() {
             InternalUnsafeMethods.CanPasteSelection__Args _args = new InternalUnsafeMethods.CanPasteSelection__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.CanPasteSelection()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Paste the current selection.
        /// </description>
        public void PasteSelection() {
             InternalUnsafeMethods.PasteSelection__Args _args = new InternalUnsafeMethods.PasteSelection__Args() {
             };
             InternalUnsafeMethods.PasteSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Copy the current selection to be pasted later.
        /// </description>
        public void CopySelection() {
             InternalUnsafeMethods.CopySelection__Args _args = new InternalUnsafeMethods.CopySelection__Args() {
             };
             InternalUnsafeMethods.CopySelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Cut the current selection to be pasted later.
        /// </description>
        public void CutSelection() {
             InternalUnsafeMethods.CutSelection__Args _args = new InternalUnsafeMethods.CutSelection__Args() {
             };
             InternalUnsafeMethods.CutSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Drop the current selection.
        /// </description>
        /// <param name="skipUndo">True to skip creating undo's for this action, false to create an undo.</param>
        public void DropSelection(bool skipUndo = false) {
             InternalUnsafeMethods.DropSelection__Args _args = new InternalUnsafeMethods.DropSelection__Args() {
                skipUndo = skipUndo,
             };
             InternalUnsafeMethods.DropSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Get extent of the selection.
        /// </description>
        /// <returns>extent of the selection.</returns>
        public Point3F GetSelectionExtent() {
             InternalUnsafeMethods.GetSelectionExtent__Args _args = new InternalUnsafeMethods.GetSelectionExtent__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetSelectionExtent()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <description>
        /// Get centroid of the selection.
        /// </description>
        /// <returns>centroid of the selection.</returns>
        public Point3F GetSelectionCentroid() {
             InternalUnsafeMethods.GetSelectionCentroid__Args _args = new InternalUnsafeMethods.GetSelectionCentroid__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetSelectionCentroid()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <description>
        /// Get the radius of the current selection.
        /// </description>
        /// <returns>radius of the current selection.</returns>
        public float GetSelectionRadius() {
             InternalUnsafeMethods.GetSelectionRadius__Args _args = new InternalUnsafeMethods.GetSelectionRadius__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetSelectionRadius()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Return the selected object and the given index.
        /// </description>
        /// <param name="index">Index of selected object to get.</param>
        /// <returns>selected object at given index or -1 if index is incorrect.</returns>
        public int GetSelectedObject(int index) {
             InternalUnsafeMethods.GetSelectedObject__Args _args = new InternalUnsafeMethods.GetSelectedObject__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedObject()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Return the number of objects currently selected in the editor.
        /// </description>
        /// <returns>number of objects currently selected in the editor.</returns>
        public int GetSelectionSize() {
             InternalUnsafeMethods.GetSelectionSize__Args _args = new InternalUnsafeMethods.GetSelectionSize__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectionSize()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Invalidate the selection sets centroid.
        /// </description>
        public void InvalidateSelectionCentroid() {
             InternalUnsafeMethods.InvalidateSelectionCentroid__Args _args = new InternalUnsafeMethods.InvalidateSelectionCentroid__Args() {
             };
             InternalUnsafeMethods.InvalidateSelectionCentroid()(ObjectPtr, _args);
        }

        /// <description>
        /// Unselects a single object.
        /// </description>
        /// <param name="obj	Object">to unselect.</param>
        public void UnselectObject(SimObject obj) {
             InternalUnsafeMethods.UnselectObject__Args _args = new InternalUnsafeMethods.UnselectObject__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.UnselectObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Selects a single object.
        /// </description>
        /// <param name="obj	Object">to select.</param>
        public void SelectObject(SimObject obj) {
             InternalUnsafeMethods.SelectObject__Args _args = new InternalUnsafeMethods.SelectObject__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.SelectObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the currently active WorldEditorSelection object.
        /// </description>
        public void SetActiveSelection(WorldEditorSelection selection) {
             InternalUnsafeMethods.SetActiveSelection__Args _args = new InternalUnsafeMethods.SetActiveSelection__Args() {
                selection = selection.ObjectPtr,
             };
             InternalUnsafeMethods.SetActiveSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Return the currently active WorldEditorSelection object.
        /// </description>
        /// <returns>currently active WorldEditorSelection object or 0 if no selection set is available.</returns>
        public int GetActiveSelection() {
             InternalUnsafeMethods.GetActiveSelection__Args _args = new InternalUnsafeMethods.GetActiveSelection__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetActiveSelection()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Clear the selection.
        /// </description>
        public void ClearSelection() {
             InternalUnsafeMethods.ClearSelection__Args _args = new InternalUnsafeMethods.ClearSelection__Args() {
             };
             InternalUnsafeMethods.ClearSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Clear the ignore class list.
        /// </description>
        public void ClearIgnoreList() {
             InternalUnsafeMethods.ClearIgnoreList__Args _args = new InternalUnsafeMethods.ClearIgnoreList__Args() {
             };
             InternalUnsafeMethods.ClearIgnoreList()(ObjectPtr, _args);
        }

        /// <description>
        /// (string class_name, ...)
        /// </description>
        public void IgnoreObjClass(params string[] args) { 
            List<string> _argList = new List<string>() {"", ""};
            _argList.AddRange(args);

            StringVector nativeVecArgs = new StringVector {
                ElementCount = (uint)_argList.Count,
                Array = _argList.ToArray(),
                ArraySize = (uint)_argList.Count
            };
            nativeVecArgs.Alloc();
            InternalUnsafeMethods.IgnoreObjClass()(ObjectPtr, ref nativeVecArgs.internalStruct);
            nativeVecArgs.Free();

        }

        /// <description>
        /// Get the type info object for the WorldEditor class.
        /// </description>
        /// <returns>The type info object for WorldEditor</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// If true, transform operations will snap to the grid.
        /// </description>
        /// </value>
        public bool GridSnap {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("gridSnap"));
            set => SetFieldValue("gridSnap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool UseGroupCenter {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useGroupCenter"));
            set => SetFieldValue("useGroupCenter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool DropAtBounds {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("dropAtBounds"));
            set => SetFieldValue("dropAtBounds", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float DropBelowCameraOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dropBelowCameraOffset"));
            set => SetFieldValue("dropBelowCameraOffset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float DropAtScreenCenterScalar {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dropAtScreenCenterScalar"));
            set => SetFieldValue("dropAtScreenCenterScalar", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float DropAtScreenCenterMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dropAtScreenCenterMax"));
            set => SetFieldValue("dropAtScreenCenterMax", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public WorldEditorDropType DropType {
            get => GenericMarshal.StringTo<WorldEditorDropType>(GetFieldValue("dropType"));
            set => SetFieldValue("dropType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI PopupBackgroundColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("popupBackgroundColor"));
            set => SetFieldValue("popupBackgroundColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI PopupTextColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("popupTextColor"));
            set => SetFieldValue("popupTextColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI ObjectTextColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("objectTextColor"));
            set => SetFieldValue("objectTextColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI SelectionBoxColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("selectionBoxColor"));
            set => SetFieldValue("selectionBoxColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI ObjSelectColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("objSelectColor"));
            set => SetFieldValue("objSelectColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI ObjMouseOverSelectColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("objMouseOverSelectColor"));
            set => SetFieldValue("objMouseOverSelectColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI ObjMouseOverColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("objMouseOverColor"));
            set => SetFieldValue("objMouseOverColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI DragRectColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("dragRectColor"));
            set => SetFieldValue("dragRectColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI FaceSelectColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("faceSelectColor"));
            set => SetFieldValue("faceSelectColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool BoundingBoxCollision {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("boundingBoxCollision"));
            set => SetFieldValue("boundingBoxCollision", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool ObjectMeshCollision {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("objectMeshCollision"));
            set => SetFieldValue("objectMeshCollision", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool SelectionLocked {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("selectionLocked"));
            set => SetFieldValue("selectionLocked", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool ObjectsUseBoxCenter {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("objectsUseBoxCenter"));
            set => SetFieldValue("objectsUseBoxCenter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string ObjTextFormat {
            get => GenericMarshal.StringTo<string>(GetFieldValue("objTextFormat"));
            set => SetFieldValue("objTextFormat", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool RenderPopupBackground {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderPopupBackground"));
            set => SetFieldValue("renderPopupBackground", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool ShowMousePopupInfo {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showMousePopupInfo"));
            set => SetFieldValue("showMousePopupInfo", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool RenderObjText {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderObjText"));
            set => SetFieldValue("renderObjText", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool RenderObjHandle {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderObjHandle"));
            set => SetFieldValue("renderObjHandle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool RenderSelectionBox {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderSelectionBox"));
            set => SetFieldValue("renderSelectionBox", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>SelectHandle ""</summary>
        /// </value>
        public string SelectHandle {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SelectHandle"));
            set => SetFieldValue("SelectHandle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>SelectHandle asset "".</summary>
        /// </value>
        public string SelectHandleAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SelectHandleAsset"));
            set => SetFieldValue("SelectHandleAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>DefaultHandle ""</summary>
        /// </value>
        public string DefaultHandle {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DefaultHandle"));
            set => SetFieldValue("DefaultHandle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>DefaultHandle asset "".</summary>
        /// </value>
        public string DefaultHandleAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DefaultHandleAsset"));
            set => SetFieldValue("DefaultHandleAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>LockedHandle ""</summary>
        /// </value>
        public string LockedHandle {
            get => GenericMarshal.StringTo<string>(GetFieldValue("LockedHandle"));
            set => SetFieldValue("LockedHandle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>LockedHandle asset "".</summary>
        /// </value>
        public string LockedHandleAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("LockedHandleAsset"));
            set => SetFieldValue("LockedHandleAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether object icons should fade out with distance to camera pos.
        /// </description>
        /// </value>
        public bool FadeIcons {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fadeIcons"));
            set => SetFieldValue("fadeIcons", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Distance from camera pos at which to start fading out icons.
        /// </description>
        /// </value>
        public float FadeIconsDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeIconsDist"));
            set => SetFieldValue("fadeIconsDist", GenericMarshal.ToString(value));
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
        public bool StickToGround {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("stickToGround"));
            set => SetFieldValue("stickToGround", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool TerrainSnapOffsetZ {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("TerrainSnapOffsetZ"));
            set => SetFieldValue("TerrainSnapOffsetZ", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float OffsetZValue {
            get => GenericMarshal.StringTo<float>(GetFieldValue("OffsetZValue"));
            set => SetFieldValue("OffsetZValue", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool ToggleIgnoreList {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("toggleIgnoreList"));
            set => SetFieldValue("toggleIgnoreList", GenericMarshal.ToString(value));
        }
    }
}
