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
    /// <summary>This control provides the 3D view for the Shape Editor tool, and is not intended for general purpose use.</summary>
    /// <description>
    /// 
    /// </description>
    public class GuiShapeEdPreview : EditTSCtrl {
        public GuiShapeEdPreview(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiShapeEdPreview(string pName, bool pRegister)
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

        public GuiShapeEdPreview(string pName)
            : this(pName, false) {
        }

        public GuiShapeEdPreview(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiShapeEdPreview(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiShapeEdPreview(SimObject pObj)
            : base(pObj) {
        }

        public GuiShapeEdPreview(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct UnmountAll__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UnmountAll(IntPtr _this, UnmountAll__Args args);
            private static _UnmountAll _UnmountAllFunc;
            internal static _UnmountAll UnmountAll() {
               _UnmountAllFunc ??= Torque3D.LookupEngineFunction<_UnmountAll>("fnGuiShapeEdPreview_unmountAll");

                return _UnmountAllFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UnmountShape__Args
            {
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UnmountShape(IntPtr _this, UnmountShape__Args args);
            private static _UnmountShape _UnmountShapeFunc;
            internal static _UnmountShape UnmountShape() {
               _UnmountShapeFunc ??= Torque3D.LookupEngineFunction<_UnmountShape>("fnGuiShapeEdPreview_unmountShape");

                return _UnmountShapeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMountThreadDir__Args
            {
                internal int slot;
                internal float dir;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMountThreadDir(IntPtr _this, SetMountThreadDir__Args args);
            private static _SetMountThreadDir _SetMountThreadDirFunc;
            internal static _SetMountThreadDir SetMountThreadDir() {
               _SetMountThreadDirFunc ??= Torque3D.LookupEngineFunction<_SetMountThreadDir>("fnGuiShapeEdPreview_setMountThreadDir");

                return _SetMountThreadDirFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMountThreadDir__Args
            {
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetMountThreadDir(IntPtr _this, GetMountThreadDir__Args args);
            private static _GetMountThreadDir _GetMountThreadDirFunc;
            internal static _GetMountThreadDir GetMountThreadDir() {
               _GetMountThreadDirFunc ??= Torque3D.LookupEngineFunction<_GetMountThreadDir>("fnGuiShapeEdPreview_getMountThreadDir");

                return _GetMountThreadDirFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMountThreadPos__Args
            {
                internal int slot;
                internal float pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMountThreadPos(IntPtr _this, SetMountThreadPos__Args args);
            private static _SetMountThreadPos _SetMountThreadPosFunc;
            internal static _SetMountThreadPos SetMountThreadPos() {
               _SetMountThreadPosFunc ??= Torque3D.LookupEngineFunction<_SetMountThreadPos>("fnGuiShapeEdPreview_setMountThreadPos");

                return _SetMountThreadPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMountThreadPos__Args
            {
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetMountThreadPos(IntPtr _this, GetMountThreadPos__Args args);
            private static _GetMountThreadPos _GetMountThreadPosFunc;
            internal static _GetMountThreadPos GetMountThreadPos() {
               _GetMountThreadPosFunc ??= Torque3D.LookupEngineFunction<_GetMountThreadPos>("fnGuiShapeEdPreview_getMountThreadPos");

                return _GetMountThreadPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMountThreadSequence__Args
            {
                internal int slot;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMountThreadSequence(IntPtr _this, SetMountThreadSequence__Args args);
            private static _SetMountThreadSequence _SetMountThreadSequenceFunc;
            internal static _SetMountThreadSequence SetMountThreadSequence() {
               _SetMountThreadSequenceFunc ??= Torque3D.LookupEngineFunction<_SetMountThreadSequence>("fnGuiShapeEdPreview_setMountThreadSequence");

                return _SetMountThreadSequenceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMountThreadSequence__Args
            {
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMountThreadSequence(IntPtr _this, GetMountThreadSequence__Args args);
            private static _GetMountThreadSequence _GetMountThreadSequenceFunc;
            internal static _GetMountThreadSequence GetMountThreadSequence() {
               _GetMountThreadSequenceFunc ??= Torque3D.LookupEngineFunction<_GetMountThreadSequence>("fnGuiShapeEdPreview_getMountThreadSequence");

                return _GetMountThreadSequenceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMountNode__Args
            {
                internal int slot;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string nodeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMountNode(IntPtr _this, SetMountNode__Args args);
            private static _SetMountNode _SetMountNodeFunc;
            internal static _SetMountNode SetMountNode() {
               _SetMountNodeFunc ??= Torque3D.LookupEngineFunction<_SetMountNode>("fnGuiShapeEdPreview_setMountNode");

                return _SetMountNodeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MountShape__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string shapeAssetId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string nodeName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _MountShape(IntPtr _this, MountShape__Args args);
            private static _MountShape _MountShapeFunc;
            internal static _MountShape MountShape() {
               _MountShapeFunc ??= Torque3D.LookupEngineFunction<_MountShape>("fnGuiShapeEdPreview_mountShape");

                return _MountShapeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RefreshThreadSequences__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RefreshThreadSequences(IntPtr _this, RefreshThreadSequences__Args args);
            private static _RefreshThreadSequences _RefreshThreadSequencesFunc;
            internal static _RefreshThreadSequences RefreshThreadSequences() {
               _RefreshThreadSequencesFunc ??= Torque3D.LookupEngineFunction<_RefreshThreadSequences>("fnGuiShapeEdPreview_refreshThreadSequences");

                return _RefreshThreadSequencesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetThreadSequence__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetThreadSequence(IntPtr _this, GetThreadSequence__Args args);
            private static _GetThreadSequence _GetThreadSequenceFunc;
            internal static _GetThreadSequence GetThreadSequence() {
               _GetThreadSequenceFunc ??= Torque3D.LookupEngineFunction<_GetThreadSequence>("fnGuiShapeEdPreview_getThreadSequence");

                return _GetThreadSequenceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetThreadSequence__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal float duration;
                internal float pos;
                [MarshalAs(UnmanagedType.I1)]
                internal bool play;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetThreadSequence(IntPtr _this, SetThreadSequence__Args args);
            private static _SetThreadSequence _SetThreadSequenceFunc;
            internal static _SetThreadSequence SetThreadSequence() {
               _SetThreadSequenceFunc ??= Torque3D.LookupEngineFunction<_SetThreadSequence>("fnGuiShapeEdPreview_setThreadSequence");

                return _SetThreadSequenceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTimeScale__Args
            {
                internal float scale;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTimeScale(IntPtr _this, SetTimeScale__Args args);
            private static _SetTimeScale _SetTimeScaleFunc;
            internal static _SetTimeScale SetTimeScale() {
               _SetTimeScaleFunc ??= Torque3D.LookupEngineFunction<_SetTimeScale>("fnGuiShapeEdPreview_setTimeScale");

                return _SetTimeScaleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetThreadCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetThreadCount(IntPtr _this, GetThreadCount__Args args);
            private static _GetThreadCount _GetThreadCountFunc;
            internal static _GetThreadCount GetThreadCount() {
               _GetThreadCountFunc ??= Torque3D.LookupEngineFunction<_GetThreadCount>("fnGuiShapeEdPreview_getThreadCount");

                return _GetThreadCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveThread__Args
            {
                internal int slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveThread(IntPtr _this, RemoveThread__Args args);
            private static _RemoveThread _RemoveThreadFunc;
            internal static _RemoveThread RemoveThread() {
               _RemoveThreadFunc ??= Torque3D.LookupEngineFunction<_RemoveThread>("fnGuiShapeEdPreview_removeThread");

                return _RemoveThreadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddThread__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddThread(IntPtr _this, AddThread__Args args);
            private static _AddThread _AddThreadFunc;
            internal static _AddThread AddThread() {
               _AddThreadFunc ??= Torque3D.LookupEngineFunction<_AddThread>("fnGuiShapeEdPreview_addThread");

                return _AddThreadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ExportToCollada__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ExportToCollada(IntPtr _this, ExportToCollada__Args args);
            private static _ExportToCollada _ExportToColladaFunc;
            internal static _ExportToCollada ExportToCollada() {
               _ExportToColladaFunc ??= Torque3D.LookupEngineFunction<_ExportToCollada>("fnGuiShapeEdPreview_exportToCollada");

                return _ExportToColladaFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAllMeshesHidden__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool hidden;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAllMeshesHidden(IntPtr _this, SetAllMeshesHidden__Args args);
            private static _SetAllMeshesHidden _SetAllMeshesHiddenFunc;
            internal static _SetAllMeshesHidden SetAllMeshesHidden() {
               _SetAllMeshesHiddenFunc ??= Torque3D.LookupEngineFunction<_SetAllMeshesHidden>("fnGuiShapeEdPreview_setAllMeshesHidden");

                return _SetAllMeshesHiddenFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMeshHidden__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                [MarshalAs(UnmanagedType.I1)]
                internal bool hidden;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMeshHidden(IntPtr _this, SetMeshHidden__Args args);
            private static _SetMeshHidden _SetMeshHiddenFunc;
            internal static _SetMeshHidden SetMeshHidden() {
               _SetMeshHiddenFunc ??= Torque3D.LookupEngineFunction<_SetMeshHidden>("fnGuiShapeEdPreview_setMeshHidden");

                return _SetMeshHiddenFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMeshHidden__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetMeshHidden(IntPtr _this, GetMeshHidden__Args args);
            private static _GetMeshHidden _GetMeshHiddenFunc;
            internal static _GetMeshHidden GetMeshHidden() {
               _GetMeshHiddenFunc ??= Torque3D.LookupEngineFunction<_GetMeshHidden>("fnGuiShapeEdPreview_getMeshHidden");

                return _GetMeshHiddenFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ComputeShapeBounds__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Box3F.InternalStruct _ComputeShapeBounds(IntPtr _this, ComputeShapeBounds__Args args);
            private static _ComputeShapeBounds _ComputeShapeBoundsFunc;
            internal static _ComputeShapeBounds ComputeShapeBounds() {
               _ComputeShapeBoundsFunc ??= Torque3D.LookupEngineFunction<_ComputeShapeBounds>("fnGuiShapeEdPreview_computeShapeBounds");

                return _ComputeShapeBoundsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UpdateNodeTransforms__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UpdateNodeTransforms(IntPtr _this, UpdateNodeTransforms__Args args);
            private static _UpdateNodeTransforms _UpdateNodeTransformsFunc;
            internal static _UpdateNodeTransforms UpdateNodeTransforms() {
               _UpdateNodeTransformsFunc ??= Torque3D.LookupEngineFunction<_UpdateNodeTransforms>("fnGuiShapeEdPreview_updateNodeTransforms");

                return _UpdateNodeTransformsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RefreshShape__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RefreshShape(IntPtr _this, RefreshShape__Args args);
            private static _RefreshShape _RefreshShapeFunc;
            internal static _RefreshShape RefreshShape() {
               _RefreshShapeFunc ??= Torque3D.LookupEngineFunction<_RefreshShape>("fnGuiShapeEdPreview_refreshShape");

                return _RefreshShapeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FitToShape__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FitToShape(IntPtr _this, FitToShape__Args args);
            private static _FitToShape _FitToShapeFunc;
            internal static _FitToShape FitToShape() {
               _FitToShapeFunc ??= Torque3D.LookupEngineFunction<_FitToShape>("fnGuiShapeEdPreview_fitToShape");

                return _FitToShapeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetShapeAsset__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string shapeAsset;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetShapeAsset(IntPtr _this, SetShapeAsset__Args args);
            private static _SetShapeAsset _SetShapeAssetFunc;
            internal static _SetShapeAsset SetShapeAsset() {
               _SetShapeAssetFunc ??= Torque3D.LookupEngineFunction<_SetShapeAsset>("fnGuiShapeEdPreview_setShapeAsset");

                return _SetShapeAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetModel__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string shapePath;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetModel(IntPtr _this, SetModel__Args args);
            private static _SetModel _SetModelFunc;
            internal static _SetModel SetModel() {
               _SetModelFunc ??= Torque3D.LookupEngineFunction<_SetModel>("fnGuiShapeEdPreview_setModel");

                return _SetModelFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetOrbitPos__Args
            {
                internal IntPtr pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetOrbitPos(IntPtr _this, SetOrbitPos__Args args);
            private static _SetOrbitPos _SetOrbitPosFunc;
            internal static _SetOrbitPos SetOrbitPos() {
               _SetOrbitPosFunc ??= Torque3D.LookupEngineFunction<_SetOrbitPos>("fnGuiShapeEdPreview_setOrbitPos");

                return _SetOrbitPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnThreadPosChanged__Args
            {
                internal float pos;
                [MarshalAs(UnmanagedType.I1)]
                internal bool inTransition;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnThreadPosChanged(IntPtr _this, OnThreadPosChanged__Args args);
            private static _OnThreadPosChanged _OnThreadPosChangedFunc;
            internal static _OnThreadPosChanged OnThreadPosChanged() {
               _OnThreadPosChangedFunc ??= Torque3D.LookupEngineFunction<_OnThreadPosChanged>("cbGuiShapeEdPreview_onThreadPosChanged");

                return _OnThreadPosChangedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiShapeEdPreview_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiShapeEdPreview_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Unmount all shapes
        /// </description>
        public void UnmountAll() {
             InternalUnsafeMethods.UnmountAll__Args _args = new InternalUnsafeMethods.UnmountAll__Args() {
             };
             InternalUnsafeMethods.UnmountAll()(ObjectPtr, _args);
        }

        /// <description>
        /// Unmount the shape in the specified slot
        /// </description>
        /// <param name="slot">mounted shape slot</param>
        public void UnmountShape(int slot) {
             InternalUnsafeMethods.UnmountShape__Args _args = new InternalUnsafeMethods.UnmountShape__Args() {
                slot = slot,
             };
             InternalUnsafeMethods.UnmountShape()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the playback direction of the shape mounted in the specified slot
        /// </description>
        /// <param name="slot">mounted shape slot</param>
        /// <param name="dir">playback direction (-1=backwards, 0=paused, 1=forwards)</param>
        public void SetMountThreadDir(int slot, float dir) {
             InternalUnsafeMethods.SetMountThreadDir__Args _args = new InternalUnsafeMethods.SetMountThreadDir__Args() {
                slot = slot,
                dir = dir,
             };
             InternalUnsafeMethods.SetMountThreadDir()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the playback direction of the sequence playing on this mounted shape
        /// </description>
        /// <param name="slot">mounted shape slot</param>
        /// <returns>direction of the sequence (-1=reverse, 0=paused, 1=forward)</returns>
        public float GetMountThreadDir(int slot) {
             InternalUnsafeMethods.GetMountThreadDir__Args _args = new InternalUnsafeMethods.GetMountThreadDir__Args() {
                slot = slot,
             };
             float _engineResult = InternalUnsafeMethods.GetMountThreadDir()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set the sequence position of the shape mounted in the specified slot
        /// </description>
        /// <param name="slot">mounted shape slot</param>
        /// <param name="pos">sequence position (0-1)</param>
        public void SetMountThreadPos(int slot, float pos) {
             InternalUnsafeMethods.SetMountThreadPos__Args _args = new InternalUnsafeMethods.SetMountThreadPos__Args() {
                slot = slot,
                pos = pos,
             };
             InternalUnsafeMethods.SetMountThreadPos()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the playback position of the sequence playing on this mounted shape
        /// </description>
        /// <param name="slot">mounted shape slot</param>
        /// <returns>playback position of the sequence (0-1)</returns>
        public float GetMountThreadPos(int slot) {
             InternalUnsafeMethods.GetMountThreadPos__Args _args = new InternalUnsafeMethods.GetMountThreadPos__Args() {
                slot = slot,
             };
             float _engineResult = InternalUnsafeMethods.GetMountThreadPos()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set the sequence to play for the shape mounted in the specified slot
        /// </description>
        /// <param name="slot">mounted shape slot</param>
        /// <param name="name">name of the sequence to play</param>
        public void SetMountThreadSequence(int slot, string name) {
             InternalUnsafeMethods.SetMountThreadSequence__Args _args = new InternalUnsafeMethods.SetMountThreadSequence__Args() {
                slot = slot,
                name = name,
             };
             InternalUnsafeMethods.SetMountThreadSequence()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the name of the sequence playing on this mounted shape
        /// </description>
        /// <param name="slot">mounted shape slot</param>
        /// <returns>name of the sequence (if any)</returns>
        public string GetMountThreadSequence(int slot) {
             InternalUnsafeMethods.GetMountThreadSequence__Args _args = new InternalUnsafeMethods.GetMountThreadSequence__Args() {
                slot = slot,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMountThreadSequence()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Set the node a shape is mounted to.
        /// </description>
        /// <param name="slot">mounted shape slot</param>
        /// <param name="nodename">name of the node to mount to</param>
        public void SetMountNode(int slot, string nodeName) {
             InternalUnsafeMethods.SetMountNode__Args _args = new InternalUnsafeMethods.SetMountNode__Args() {
                slot = slot,
                nodeName = nodeName,
             };
             InternalUnsafeMethods.SetMountNode()(ObjectPtr, _args);
        }

        /// <description>
        /// Mount a shape onto the main shape at the specified node
        /// </description>
        /// <param name="shapeAssetId">AssetId of the shape to mount</param>
        /// <param name="nodeName">name of the node on the main shape to mount to</param>
        /// <param name="type">type of mounting to use (Object, Image or Wheel)</param>
        /// <param name="slot">mount slot</param>
        public bool MountShape(string shapeAssetId, string nodeName, string type, int slot) {
             InternalUnsafeMethods.MountShape__Args _args = new InternalUnsafeMethods.MountShape__Args() {
                shapeAssetId = shapeAssetId,
                nodeName = nodeName,
                type = type,
                slot = slot,
             };
             bool _engineResult = InternalUnsafeMethods.MountShape()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Refreshes thread sequences (in case of removed/renamed sequences
        /// </description>
        public void RefreshThreadSequences() {
             InternalUnsafeMethods.RefreshThreadSequences__Args _args = new InternalUnsafeMethods.RefreshThreadSequences__Args() {
             };
             InternalUnsafeMethods.RefreshThreadSequences()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the name of the sequence assigned to the active thread
        /// </description>
        public string GetThreadSequence() {
             InternalUnsafeMethods.GetThreadSequence__Args _args = new InternalUnsafeMethods.GetThreadSequence__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetThreadSequence()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Sets the sequence to play for the active thread.
        /// </description>
        /// <param name="name">name of the sequence to play</param>
        /// <param name="duration">transition duration (0 for no transition)</param>
        /// <param name="pos">position in the new sequence to transition to</param>
        /// <param name="play">if true, the new sequence will play during the transition</param>
        public void SetThreadSequence(string name, float duration = 0f, float pos = 0f, bool play = false) {
             InternalUnsafeMethods.SetThreadSequence__Args _args = new InternalUnsafeMethods.SetThreadSequence__Args() {
                name = name,
                duration = duration,
                pos = pos,
                play = play,
             };
             InternalUnsafeMethods.SetThreadSequence()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the time scale of all threads
        /// </description>
        /// <param name="scale">new time scale value</param>
        public void SetTimeScale(float scale) {
             InternalUnsafeMethods.SetTimeScale__Args _args = new InternalUnsafeMethods.SetTimeScale__Args() {
                scale = scale,
             };
             InternalUnsafeMethods.SetTimeScale()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the number of threads
        /// </description>
        /// <returns>the number of threads</returns>
        public int GetThreadCount() {
             InternalUnsafeMethods.GetThreadCount__Args _args = new InternalUnsafeMethods.GetThreadCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetThreadCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Removes the specifed thread
        /// </description>
        /// <param name="slot">index of the thread to remove</param>
        public void RemoveThread(int slot) {
             InternalUnsafeMethods.RemoveThread__Args _args = new InternalUnsafeMethods.RemoveThread__Args() {
                slot = slot,
             };
             InternalUnsafeMethods.RemoveThread()(ObjectPtr, _args);
        }

        /// <description>
        /// Add a new thread (initially without any sequence set)
        /// </description>
        public void AddThread() {
             InternalUnsafeMethods.AddThread__Args _args = new InternalUnsafeMethods.AddThread__Args() {
             };
             InternalUnsafeMethods.AddThread()(ObjectPtr, _args);
        }

        /// <description>
        /// Export the current shape and all mounted objects to COLLADA (.dae).
        /// Note that animation is not exported, and all geometry is combined into a single mesh.
        /// </description>
        /// <param name="path">Destination filename</param>
        public void ExportToCollada(string path) {
             InternalUnsafeMethods.ExportToCollada__Args _args = new InternalUnsafeMethods.ExportToCollada__Args() {
                path = path,
             };
             InternalUnsafeMethods.ExportToCollada()(ObjectPtr, _args);
        }

        /// <description>
        /// Show or hide all objects in the shape
        /// </description>
        public void SetAllMeshesHidden(bool hidden) {
             InternalUnsafeMethods.SetAllMeshesHidden__Args _args = new InternalUnsafeMethods.SetAllMeshesHidden__Args() {
                hidden = hidden,
             };
             InternalUnsafeMethods.SetAllMeshesHidden()(ObjectPtr, _args);
        }

        /// <description>
        /// Show or hide the named object in the shape
        /// </description>
        public void SetMeshHidden(string name, bool hidden) {
             InternalUnsafeMethods.SetMeshHidden__Args _args = new InternalUnsafeMethods.SetMeshHidden__Args() {
                name = name,
                hidden = hidden,
             };
             InternalUnsafeMethods.SetMeshHidden()(ObjectPtr, _args);
        }

        /// <description>
        /// Return whether the named object is currently hidden
        /// </description>
        public bool GetMeshHidden(string name) {
             InternalUnsafeMethods.GetMeshHidden__Args _args = new InternalUnsafeMethods.GetMeshHidden__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.GetMeshHidden()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Compute the bounding box of the shape using the current detail and node transforms
        /// </description>
        /// <returns>the bounding box "min.x min.y min.z max.x max.y max.z"</returns>
        public Box3F ComputeShapeBounds() {
             InternalUnsafeMethods.ComputeShapeBounds__Args _args = new InternalUnsafeMethods.ComputeShapeBounds__Args() {
             };
             Box3F.InternalStruct _engineResult = InternalUnsafeMethods.ComputeShapeBounds()(ObjectPtr, _args);
             return new Box3F(_engineResult);
        }

        /// <description>
        /// Refresh the shape node transforms (used when a node transform has been modified externally)
        /// </description>
        public void UpdateNodeTransforms() {
             InternalUnsafeMethods.UpdateNodeTransforms__Args _args = new InternalUnsafeMethods.UpdateNodeTransforms__Args() {
             };
             InternalUnsafeMethods.UpdateNodeTransforms()(ObjectPtr, _args);
        }

        /// <description>
        /// Refresh the shape (used when the shape meshes or nodes have been added or removed)
        /// </description>
        public void RefreshShape() {
             InternalUnsafeMethods.RefreshShape__Args _args = new InternalUnsafeMethods.RefreshShape__Args() {
             };
             InternalUnsafeMethods.RefreshShape()(ObjectPtr, _args);
        }

        /// <description>
        /// Adjust the camera position and zoom to fit the shape within the view.
        /// </description>
        public void FitToShape() {
             InternalUnsafeMethods.FitToShape__Args _args = new InternalUnsafeMethods.FitToShape__Args() {
             };
             InternalUnsafeMethods.FitToShape()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the model to be displayed in this control
        /// </description>
        /// <param name="shapeName">Name of the model to display.</param>
        /// <returns>True if the model was loaded successfully, false otherwise.</returns>
        public bool SetShapeAsset(string shapeAsset) {
             InternalUnsafeMethods.SetShapeAsset__Args _args = new InternalUnsafeMethods.SetShapeAsset__Args() {
                shapeAsset = shapeAsset,
             };
             bool _engineResult = InternalUnsafeMethods.SetShapeAsset()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Sets the model to be displayed in this control
        /// </description>
        /// <param name="shapeName">Name of the model to display.</param>
        /// <returns>True if the model was loaded successfully, false otherwise.</returns>
        public bool SetModel(string shapePath) {
             InternalUnsafeMethods.SetModel__Args _args = new InternalUnsafeMethods.SetModel__Args() {
                shapePath = shapePath,
             };
             bool _engineResult = InternalUnsafeMethods.SetModel()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set the camera orbit position
        /// </description>
        /// <param name="pos">Position in the form "x y z"</param>
        public void SetOrbitPos(Point3F pos) {
pos.Alloc();             InternalUnsafeMethods.SetOrbitPos__Args _args = new InternalUnsafeMethods.SetOrbitPos__Args() {
                pos = pos.internalStructPtr,
             };
             InternalUnsafeMethods.SetOrbitPos()(ObjectPtr, _args);
pos.Free();        }

        /// <description>
        /// Called when the position of the active thread has changed, such as during playback.
        /// </description>
        public virtual void OnThreadPosChanged(float pos, bool inTransition) {
             InternalUnsafeMethods.OnThreadPosChanged__Args _args = new InternalUnsafeMethods.OnThreadPosChanged__Args() {
                pos = pos,
                inTransition = inTransition,
             };
             InternalUnsafeMethods.OnThreadPosChanged()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiShapeEdPreview class.
        /// </description>
        /// <returns>The type info object for GuiShapeEdPreview</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// If true, dragging the gizmo will rotate the sun direction
        /// </description>
        /// </value>
        public bool EditSun {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("editSun"));
            set => SetFieldValue("editSun", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Index of the selected node, or -1 if none
        /// </description>
        /// </value>
        public int SelectedNode {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectedNode"));
            set => SetFieldValue("selectedNode", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Index of the selected object, or -1 if none
        /// </description>
        /// </value>
        public int SelectedObject {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectedObject"));
            set => SetFieldValue("selectedObject", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Index of the selected object detail mesh, or 0 if none
        /// </description>
        /// </value>
        public int SelectedObjDetail {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectedObjDetail"));
            set => SetFieldValue("selectedObjDetail", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Grid dimensions (number of rows and columns) in the form "rows cols"
        /// </description>
        /// </value>
        public Point2I GridDimension {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("gridDimension"));
            set => SetFieldValue("gridDimension", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Flag indicating whether to draw the grid
        /// </description>
        /// </value>
        public bool RenderGrid {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderGrid"));
            set => SetFieldValue("renderGrid", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Flag indicating whether to render the shape nodes
        /// </description>
        /// </value>
        public bool RenderNodes {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderNodes"));
            set => SetFieldValue("renderNodes", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Flag indicating whether to render the shape in 'ghost' mode (transparent)
        /// </description>
        /// </value>
        public bool RenderGhost {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderGhost"));
            set => SetFieldValue("renderGhost", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Flag indicating whether to render the shape bounding box
        /// </description>
        /// </value>
        public bool RenderBounds {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderBounds"));
            set => SetFieldValue("renderBounds", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Flag indicating whether to render the selected object's bounding box
        /// </description>
        /// </value>
        public bool RenderObjBox {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderObjBox"));
            set => SetFieldValue("renderObjBox", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Flag indicating whether to render the shape's collision geometry
        /// </description>
        /// </value>
        public bool RenderColMeshes {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderColMeshes"));
            set => SetFieldValue("renderColMeshes", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Flag indicating whether to render mounted objects
        /// </description>
        /// </value>
        public bool RenderMounts {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderMounts"));
            set => SetFieldValue("renderMounts", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Ambient color for the sun
        /// </description>
        /// </value>
        public ColorI SunDiffuse {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("sunDiffuse"));
            set => SetFieldValue("sunDiffuse", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Diffuse color for the sun
        /// </description>
        /// </value>
        public ColorI SunAmbient {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("sunAmbient"));
            set => SetFieldValue("sunAmbient", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// X-axis rotation angle for the sun
        /// </description>
        /// </value>
        public float SunAngleX {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sunAngleX"));
            set => SetFieldValue("sunAngleX", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Z-axis rotation angle for the sun
        /// </description>
        /// </value>
        public float SunAngleZ {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sunAngleZ"));
            set => SetFieldValue("sunAngleZ", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Index of the active thread, or -1 if none
        /// </description>
        /// </value>
        public int ActiveThread {
            get => GenericMarshal.StringTo<int>(GetFieldValue("activeThread"));
            set => SetFieldValue("activeThread", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Current position of the active thread (0-1)
        /// </description>
        /// </value>
        public float ThreadPos {
            get => GenericMarshal.StringTo<float>(GetFieldValue("threadPos"));
            set => SetFieldValue("threadPos", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Playback direction of the active thread
        /// </description>
        /// </value>
        public int ThreadDirection {
            get => GenericMarshal.StringTo<int>(GetFieldValue("threadDirection"));
            set => SetFieldValue("threadDirection", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// 'PingPong' mode of the active thread
        /// </description>
        /// </value>
        public bool ThreadPingPong {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("threadPingPong"));
            set => SetFieldValue("threadPingPong", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If false, the current detail is selected based on camera distance
        /// </description>
        /// </value>
        public bool FixedDetail {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fixedDetail"));
            set => SetFieldValue("fixedDetail", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The current distance from the camera to the model
        /// </description>
        /// </value>
        public float OrbitDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("orbitDist"));
            set => SetFieldValue("orbitDist", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The current detail level
        /// </description>
        /// </value>
        public int CurrentDL {
            get => GenericMarshal.StringTo<int>(GetFieldValue("currentDL"));
            set => SetFieldValue("currentDL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The size of the current detail
        /// </description>
        /// </value>
        public int DetailSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("detailSize"));
            set => SetFieldValue("detailSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Number of polygons in the current detail
        /// </description>
        /// </value>
        public int DetailPolys {
            get => GenericMarshal.StringTo<int>(GetFieldValue("detailPolys"));
            set => SetFieldValue("detailPolys", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The current pixel size of the model
        /// </description>
        /// </value>
        public float PixelSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pixelSize"));
            set => SetFieldValue("pixelSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The number of materials in the current detail level
        /// </description>
        /// </value>
        public int NumMaterials {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numMaterials"));
            set => SetFieldValue("numMaterials", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The number of draw calls in the current detail level
        /// </description>
        /// </value>
        public int NumDrawCalls {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numDrawCalls"));
            set => SetFieldValue("numDrawCalls", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The number of bones in the current detail level (skins only)
        /// </description>
        /// </value>
        public int NumBones {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numBones"));
            set => SetFieldValue("numBones", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The number of vertex weights in the current detail level (skins only)
        /// </description>
        /// </value>
        public int NumWeights {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numWeights"));
            set => SetFieldValue("numWeights", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The number of collision meshes in the shape
        /// </description>
        /// </value>
        public int ColMeshes {
            get => GenericMarshal.StringTo<int>(GetFieldValue("colMeshes"));
            set => SetFieldValue("colMeshes", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The total number of collision polygons (all meshes) in the shape
        /// </description>
        /// </value>
        public int ColPolys {
            get => GenericMarshal.StringTo<int>(GetFieldValue("colPolys"));
            set => SetFieldValue("colPolys", GenericMarshal.ToString(value));
        }
    }
}
