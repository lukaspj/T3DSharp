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
    /// <summary>Native side of the GUI editor.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiEditCtrl : GuiControl {
        public GuiEditCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiEditCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiEditCtrl(string pName)
            : this(pName, false) {
        }

        public GuiEditCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiEditCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiEditCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiEditCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMouseMode__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMouseMode(IntPtr _this, GetMouseMode__Args args);
            private static _GetMouseMode _GetMouseModeFunc;
            internal static _GetMouseMode GetMouseMode() {
               _GetMouseModeFunc ??= Torque3D.LookupEngineFunction<_GetMouseMode>("fnGuiEditCtrl_getMouseMode");

                return _GetMouseModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FitIntoParents__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool width;
                [MarshalAs(UnmanagedType.I1)]
                internal bool height;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FitIntoParents(IntPtr _this, FitIntoParents__Args args);
            private static _FitIntoParents _FitIntoParentsFunc;
            internal static _FitIntoParents FitIntoParents() {
               _FitIntoParentsFunc ??= Torque3D.LookupEngineFunction<_FitIntoParents>("fnGuiEditCtrl_fitIntoParents");

                return _FitIntoParentsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearGuides__Args
            {
                internal int axis;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearGuides(IntPtr _this, ClearGuides__Args args);
            private static _ClearGuides _ClearGuidesFunc;
            internal static _ClearGuides ClearGuides() {
               _ClearGuidesFunc ??= Torque3D.LookupEngineFunction<_ClearGuides>("fnGuiEditCtrl_clearGuides");

                return _ClearGuidesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct WriteGuides__Args
            {
                internal IntPtr ctrl;
                internal int axis;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _WriteGuides(IntPtr _this, WriteGuides__Args args);
            private static _WriteGuides _WriteGuidesFunc;
            internal static _WriteGuides WriteGuides() {
               _WriteGuidesFunc ??= Torque3D.LookupEngineFunction<_WriteGuides>("fnGuiEditCtrl_writeGuides");

                return _WriteGuidesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ReadGuides__Args
            {
                internal IntPtr ctrl;
                internal int axis;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ReadGuides(IntPtr _this, ReadGuides__Args args);
            private static _ReadGuides _ReadGuidesFunc;
            internal static _ReadGuides ReadGuides() {
               _ReadGuidesFunc ??= Torque3D.LookupEngineFunction<_ReadGuides>("fnGuiEditCtrl_readGuides");

                return _ReadGuidesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSnapToGrid__Args
            {
                internal uint gridsize;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSnapToGrid(IntPtr _this, SetSnapToGrid__Args args);
            private static _SetSnapToGrid _SetSnapToGridFunc;
            internal static _SetSnapToGrid SetSnapToGrid() {
               _SetSnapToGridFunc ??= Torque3D.LookupEngineFunction<_SetSnapToGrid>("fnGuiEditCtrl_setSnapToGrid");

                return _SetSnapToGridFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTrash__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetTrash(IntPtr _this, GetTrash__Args args);
            private static _GetTrash _GetTrashFunc;
            internal static _GetTrash GetTrash() {
               _GetTrashFunc ??= Torque3D.LookupEngineFunction<_GetTrash>("fnGuiEditCtrl_getTrash");

                return _GetTrashFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectChildren__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool addToSelection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SelectChildren(IntPtr _this, SelectChildren__Args args);
            private static _SelectChildren _SelectChildrenFunc;
            internal static _SelectChildren SelectChildren() {
               _SelectChildrenFunc ??= Torque3D.LookupEngineFunction<_SelectChildren>("fnGuiEditCtrl_selectChildren");

                return _SelectChildrenFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectParents__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool addToSelection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SelectParents(IntPtr _this, SelectParents__Args args);
            private static _SelectParents _SelectParentsFunc;
            internal static _SelectParents SelectParents() {
               _SelectParentsFunc ??= Torque3D.LookupEngineFunction<_SelectParents>("fnGuiEditCtrl_selectParents");

                return _SelectParentsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectionGlobalBounds__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSelectionGlobalBounds(IntPtr _this, GetSelectionGlobalBounds__Args args);
            private static _GetSelectionGlobalBounds _GetSelectionGlobalBoundsFunc;
            internal static _GetSelectionGlobalBounds GetSelectionGlobalBounds() {
               _GetSelectionGlobalBoundsFunc ??= Torque3D.LookupEngineFunction<_GetSelectionGlobalBounds>("fnGuiEditCtrl_getSelectionGlobalBounds");

                return _GetSelectionGlobalBoundsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNumSelected__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNumSelected(IntPtr _this, GetNumSelected__Args args);
            private static _GetNumSelected _GetNumSelectedFunc;
            internal static _GetNumSelected GetNumSelected() {
               _GetNumSelectedFunc ??= Torque3D.LookupEngineFunction<_GetNumSelected>("fnGuiEditCtrl_getNumSelected");

                return _GetNumSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetSelection(IntPtr _this, GetSelection__Args args);
            private static _GetSelection _GetSelectionFunc;
            internal static _GetSelection GetSelection() {
               _GetSelectionFunc ??= Torque3D.LookupEngineFunction<_GetSelection>("fnGuiEditCtrl_getSelection");

                return _GetSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectAll__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SelectAll(IntPtr _this, SelectAll__Args args);
            private static _SelectAll _SelectAllFunc;
            internal static _SelectAll SelectAll() {
               _SelectAllFunc ??= Torque3D.LookupEngineFunction<_SelectAll>("fnGuiEditCtrl_selectAll");

                return _SelectAllFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct LoadSelection__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _LoadSelection(IntPtr _this, LoadSelection__Args args);
            private static _LoadSelection _LoadSelectionFunc;
            internal static _LoadSelection LoadSelection() {
               _LoadSelectionFunc ??= Torque3D.LookupEngineFunction<_LoadSelection>("fnGuiEditCtrl_loadSelection");

                return _LoadSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SaveSelection__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SaveSelection(IntPtr _this, SaveSelection__Args args);
            private static _SaveSelection _SaveSelectionFunc;
            internal static _SaveSelection SaveSelection() {
               _SaveSelectionFunc ??= Torque3D.LookupEngineFunction<_SaveSelection>("fnGuiEditCtrl_saveSelection");

                return _SaveSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MoveSelection__Args
            {
                internal int dx;
                internal int dy;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _MoveSelection(IntPtr _this, MoveSelection__Args args);
            private static _MoveSelection _MoveSelectionFunc;
            internal static _MoveSelection MoveSelection() {
               _MoveSelectionFunc ??= Torque3D.LookupEngineFunction<_MoveSelection>("fnGuiEditCtrl_moveSelection");

                return _MoveSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteSelection(IntPtr _this, DeleteSelection__Args args);
            private static _DeleteSelection _DeleteSelectionFunc;
            internal static _DeleteSelection DeleteSelection() {
               _DeleteSelectionFunc ??= Torque3D.LookupEngineFunction<_DeleteSelection>("fnGuiEditCtrl_deleteSelection");

                return _DeleteSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushToBack__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushToBack(IntPtr _this, PushToBack__Args args);
            private static _PushToBack _PushToBackFunc;
            internal static _PushToBack PushToBack() {
               _PushToBackFunc ??= Torque3D.LookupEngineFunction<_PushToBack>("fnGuiEditCtrl_pushToBack");

                return _PushToBackFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct BringToFront__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _BringToFront(IntPtr _this, BringToFront__Args args);
            private static _BringToFront _BringToFrontFunc;
            internal static _BringToFront BringToFront() {
               _BringToFrontFunc ??= Torque3D.LookupEngineFunction<_BringToFront>("fnGuiEditCtrl_bringToFront");

                return _BringToFrontFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Justify__Args
            {
                internal uint mode;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Justify(IntPtr _this, Justify__Args args);
            private static _Justify _JustifyFunc;
            internal static _Justify Justify() {
               _JustifyFunc ??= Torque3D.LookupEngineFunction<_Justify>("fnGuiEditCtrl_justify");

                return _JustifyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Toggle__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Toggle(IntPtr _this, Toggle__Args args);
            private static _Toggle _ToggleFunc;
            internal static _Toggle Toggle() {
               _ToggleFunc ??= Torque3D.LookupEngineFunction<_Toggle>("fnGuiEditCtrl_toggle");

                return _ToggleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentAddSet__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetCurrentAddSet(IntPtr _this, GetCurrentAddSet__Args args);
            private static _GetCurrentAddSet _GetCurrentAddSetFunc;
            internal static _GetCurrentAddSet GetCurrentAddSet() {
               _GetCurrentAddSetFunc ??= Torque3D.LookupEngineFunction<_GetCurrentAddSet>("fnGuiEditCtrl_getCurrentAddSet");

                return _GetCurrentAddSetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCurrentAddSet__Args
            {
                internal IntPtr addSet;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCurrentAddSet(IntPtr _this, SetCurrentAddSet__Args args);
            private static _SetCurrentAddSet _SetCurrentAddSetFunc;
            internal static _SetCurrentAddSet SetCurrentAddSet() {
               _SetCurrentAddSetFunc ??= Torque3D.LookupEngineFunction<_SetCurrentAddSet>("fnGuiEditCtrl_setCurrentAddSet");

                return _SetCurrentAddSetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Select__Args
            {
                internal IntPtr ctrl;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Select(IntPtr _this, Select__Args args);
            private static _Select _SelectFunc;
            internal static _Select Select() {
               _SelectFunc ??= Torque3D.LookupEngineFunction<_Select>("fnGuiEditCtrl_select");

                return _SelectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearSelection__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearSelection(IntPtr _this, ClearSelection__Args args);
            private static _ClearSelection _ClearSelectionFunc;
            internal static _ClearSelection ClearSelection() {
               _ClearSelectionFunc ??= Torque3D.LookupEngineFunction<_ClearSelection>("fnGuiEditCtrl_clearSelection");

                return _ClearSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveSelection__Args
            {
                internal int id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveSelection(IntPtr _this, RemoveSelection__Args args);
            private static _RemoveSelection _RemoveSelectionFunc;
            internal static _RemoveSelection RemoveSelection() {
               _RemoveSelectionFunc ??= Torque3D.LookupEngineFunction<_RemoveSelection>("fnGuiEditCtrl_removeSelection");

                return _RemoveSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddSelection__Args
            {
                internal int id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddSelection(IntPtr _this, AddSelection__Args args);
            private static _AddSelection _AddSelectionFunc;
            internal static _AddSelection AddSelection() {
               _AddSelectionFunc ??= Torque3D.LookupEngineFunction<_AddSelection>("fnGuiEditCtrl_addSelection");

                return _AddSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddNewCtrl__Args
            {
                internal IntPtr ctrl;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddNewCtrl(IntPtr _this, AddNewCtrl__Args args);
            private static _AddNewCtrl _AddNewCtrlFunc;
            internal static _AddNewCtrl AddNewCtrl() {
               _AddNewCtrlFunc ??= Torque3D.LookupEngineFunction<_AddNewCtrl>("fnGuiEditCtrl_addNewCtrl");

                return _AddNewCtrlFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetContentControl__Args
            {
                internal IntPtr ctrl;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetContentControl(IntPtr _this, SetContentControl__Args args);
            private static _SetContentControl _SetContentControlFunc;
            internal static _SetContentControl SetContentControl() {
               _SetContentControlFunc ??= Torque3D.LookupEngineFunction<_SetContentControl>("fnGuiEditCtrl_setContentControl");

                return _SetContentControlFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetContentControl__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetContentControl(IntPtr _this, GetContentControl__Args args);
            private static _GetContentControl _GetContentControlFunc;
            internal static _GetContentControl GetContentControl() {
               _GetContentControlFunc ??= Torque3D.LookupEngineFunction<_GetContentControl>("fnGuiEditCtrl_getContentControl");

                return _GetContentControlFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnControlInspectPostApply__Args
            {
                internal IntPtr control;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnControlInspectPostApply(IntPtr _this, OnControlInspectPostApply__Args args);
            private static _OnControlInspectPostApply _OnControlInspectPostApplyFunc;
            internal static _OnControlInspectPostApply OnControlInspectPostApply() {
               _OnControlInspectPostApplyFunc ??= Torque3D.LookupEngineFunction<_OnControlInspectPostApply>("cbGuiEditCtrl_onControlInspectPostApply");

                return _OnControlInspectPostApplyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnControlInspectPreApply__Args
            {
                internal IntPtr control;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnControlInspectPreApply(IntPtr _this, OnControlInspectPreApply__Args args);
            private static _OnControlInspectPreApply _OnControlInspectPreApplyFunc;
            internal static _OnControlInspectPreApply OnControlInspectPreApply() {
               _OnControlInspectPreApplyFunc ??= Torque3D.LookupEngineFunction<_OnControlInspectPreApply>("cbGuiEditCtrl_onControlInspectPreApply");

                return _OnControlInspectPreApplyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMouseModeChange__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMouseModeChange(IntPtr _this, OnMouseModeChange__Args args);
            private static _OnMouseModeChange _OnMouseModeChangeFunc;
            internal static _OnMouseModeChange OnMouseModeChange() {
               _OnMouseModeChangeFunc ??= Torque3D.LookupEngineFunction<_OnMouseModeChange>("cbGuiEditCtrl_onMouseModeChange");

                return _OnMouseModeChangeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnFitIntoParent__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool width;
                [MarshalAs(UnmanagedType.I1)]
                internal bool height;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnFitIntoParent(IntPtr _this, OnFitIntoParent__Args args);
            private static _OnFitIntoParent _OnFitIntoParentFunc;
            internal static _OnFitIntoParent OnFitIntoParent() {
               _OnFitIntoParentFunc ??= Torque3D.LookupEngineFunction<_OnFitIntoParent>("cbGuiEditCtrl_onFitIntoParent");

                return _OnFitIntoParentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnSelectionResized__Args
            {
                internal IntPtr control;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnSelectionResized(IntPtr _this, OnSelectionResized__Args args);
            private static _OnSelectionResized _OnSelectionResizedFunc;
            internal static _OnSelectionResized OnSelectionResized() {
               _OnSelectionResizedFunc ??= Torque3D.LookupEngineFunction<_OnSelectionResized>("cbGuiEditCtrl_onSelectionResized");

                return _OnSelectionResizedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAddNewCtrlSet__Args
            {
                internal IntPtr set;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAddNewCtrlSet(IntPtr _this, OnAddNewCtrlSet__Args args);
            private static _OnAddNewCtrlSet _OnAddNewCtrlSetFunc;
            internal static _OnAddNewCtrlSet OnAddNewCtrlSet() {
               _OnAddNewCtrlSetFunc ??= Torque3D.LookupEngineFunction<_OnAddNewCtrlSet>("cbGuiEditCtrl_onAddNewCtrlSet");

                return _OnAddNewCtrlSetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAddNewCtrl__Args
            {
                internal IntPtr control;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAddNewCtrl(IntPtr _this, OnAddNewCtrl__Args args);
            private static _OnAddNewCtrl _OnAddNewCtrlFunc;
            internal static _OnAddNewCtrl OnAddNewCtrl() {
               _OnAddNewCtrlFunc ??= Torque3D.LookupEngineFunction<_OnAddNewCtrl>("cbGuiEditCtrl_onAddNewCtrl");

                return _OnAddNewCtrlFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnTrashSelection__Args
            {
                internal IntPtr selection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnTrashSelection(IntPtr _this, OnTrashSelection__Args args);
            private static _OnTrashSelection _OnTrashSelectionFunc;
            internal static _OnTrashSelection OnTrashSelection() {
               _OnTrashSelectionFunc ??= Torque3D.LookupEngineFunction<_OnTrashSelection>("cbGuiEditCtrl_onTrashSelection");

                return _OnTrashSelectionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnSelectionCloned__Args
            {
                internal IntPtr selection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnSelectionCloned(IntPtr _this, OnSelectionCloned__Args args);
            private static _OnSelectionCloned _OnSelectionClonedFunc;
            internal static _OnSelectionCloned OnSelectionCloned() {
               _OnSelectionClonedFunc ??= Torque3D.LookupEngineFunction<_OnSelectionCloned>("cbGuiEditCtrl_onSelectionCloned");

                return _OnSelectionClonedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnSelectionMoved__Args
            {
                internal IntPtr control;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnSelectionMoved(IntPtr _this, OnSelectionMoved__Args args);
            private static _OnSelectionMoved _OnSelectionMovedFunc;
            internal static _OnSelectionMoved OnSelectionMoved() {
               _OnSelectionMovedFunc ??= Torque3D.LookupEngineFunction<_OnSelectionMoved>("cbGuiEditCtrl_onSelectionMoved");

                return _OnSelectionMovedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnPostSelectionNudged__Args
            {
                internal IntPtr selection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnPostSelectionNudged(IntPtr _this, OnPostSelectionNudged__Args args);
            private static _OnPostSelectionNudged _OnPostSelectionNudgedFunc;
            internal static _OnPostSelectionNudged OnPostSelectionNudged() {
               _OnPostSelectionNudgedFunc ??= Torque3D.LookupEngineFunction<_OnPostSelectionNudged>("cbGuiEditCtrl_onPostSelectionNudged");

                return _OnPostSelectionNudgedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnPreSelectionNudged__Args
            {
                internal IntPtr selection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnPreSelectionNudged(IntPtr _this, OnPreSelectionNudged__Args args);
            private static _OnPreSelectionNudged _OnPreSelectionNudgedFunc;
            internal static _OnPreSelectionNudged OnPreSelectionNudged() {
               _OnPreSelectionNudgedFunc ??= Torque3D.LookupEngineFunction<_OnPreSelectionNudged>("cbGuiEditCtrl_onPreSelectionNudged");

                return _OnPreSelectionNudgedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnRemoveSelected__Args
            {
                internal IntPtr control;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnRemoveSelected(IntPtr _this, OnRemoveSelected__Args args);
            private static _OnRemoveSelected _OnRemoveSelectedFunc;
            internal static _OnRemoveSelected OnRemoveSelected() {
               _OnRemoveSelectedFunc ??= Torque3D.LookupEngineFunction<_OnRemoveSelected>("cbGuiEditCtrl_onRemoveSelected");

                return _OnRemoveSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAddSelected__Args
            {
                internal IntPtr control;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAddSelected(IntPtr _this, OnAddSelected__Args args);
            private static _OnAddSelected _OnAddSelectedFunc;
            internal static _OnAddSelected OnAddSelected() {
               _OnAddSelectedFunc ??= Torque3D.LookupEngineFunction<_OnAddSelected>("cbGuiEditCtrl_onAddSelected");

                return _OnAddSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnSelect__Args
            {
                internal IntPtr control;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnSelect(IntPtr _this, OnSelect__Args args);
            private static _OnSelect _OnSelectFunc;
            internal static _OnSelect OnSelect() {
               _OnSelectFunc ??= Torque3D.LookupEngineFunction<_OnSelect>("cbGuiEditCtrl_onSelect");

                return _OnSelectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnClearSelected__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnClearSelected(IntPtr _this, OnClearSelected__Args args);
            private static _OnClearSelected _OnClearSelectedFunc;
            internal static _OnClearSelected OnClearSelected() {
               _OnClearSelectedFunc ??= Torque3D.LookupEngineFunction<_OnClearSelected>("cbGuiEditCtrl_onClearSelected");

                return _OnClearSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnPostEdit__Args
            {
                internal IntPtr selection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnPostEdit(IntPtr _this, OnPostEdit__Args args);
            private static _OnPostEdit _OnPostEditFunc;
            internal static _OnPostEdit OnPostEdit() {
               _OnPostEditFunc ??= Torque3D.LookupEngineFunction<_OnPostEdit>("cbGuiEditCtrl_onPostEdit");

                return _OnPostEditFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnPreEdit__Args
            {
                internal IntPtr selection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnPreEdit(IntPtr _this, OnPreEdit__Args args);
            private static _OnPreEdit _OnPreEditFunc;
            internal static _OnPreEdit OnPreEdit() {
               _OnPreEditFunc ??= Torque3D.LookupEngineFunction<_OnPreEdit>("cbGuiEditCtrl_onPreEdit");

                return _OnPreEditFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDelete__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDelete(IntPtr _this, OnDelete__Args args);
            private static _OnDelete _OnDeleteFunc;
            internal static _OnDelete OnDelete() {
               _OnDeleteFunc ??= Torque3D.LookupEngineFunction<_OnDelete>("cbGuiEditCtrl_onDelete");

                return _OnDeleteFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnHierarchyChanged__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnHierarchyChanged(IntPtr _this, OnHierarchyChanged__Args args);
            private static _OnHierarchyChanged _OnHierarchyChangedFunc;
            internal static _OnHierarchyChanged OnHierarchyChanged() {
               _OnHierarchyChangedFunc ??= Torque3D.LookupEngineFunction<_OnHierarchyChanged>("cbGuiEditCtrl_onHierarchyChanged");

                return _OnHierarchyChangedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiEditCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiEditCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// () - Return the current mouse mode.
        /// </description>
        public string GetMouseMode() {
             InternalUnsafeMethods.GetMouseMode__Args _args = new InternalUnsafeMethods.GetMouseMode__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMouseMode()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// ( bool width=true, bool height=true ) - Fit selected controls into their parents.
        /// </description>
        public void FitIntoParents(bool width = true, bool height = true) {
             InternalUnsafeMethods.FitIntoParents__Args _args = new InternalUnsafeMethods.FitIntoParents__Args() {
                width = width,
                height = height,
             };
             InternalUnsafeMethods.FitIntoParents()(ObjectPtr, _args);
        }

        /// <description>
        /// ( [ int axis ] ) - Clear all currently set guide lines.
        /// </description>
        public void ClearGuides(int axis = -1) {
             InternalUnsafeMethods.ClearGuides__Args _args = new InternalUnsafeMethods.ClearGuides__Args() {
                axis = axis,
             };
             InternalUnsafeMethods.ClearGuides()(ObjectPtr, _args);
        }

        /// <description>
        /// ( GuiControl ctrl [, int axis ] ) - Write the guides to the given control.
        /// </description>
        public void WriteGuides(GuiControl ctrl, int axis = -1) {
             InternalUnsafeMethods.WriteGuides__Args _args = new InternalUnsafeMethods.WriteGuides__Args() {
                ctrl = ctrl.ObjectPtr,
                axis = axis,
             };
             InternalUnsafeMethods.WriteGuides()(ObjectPtr, _args);
        }

        /// <description>
        /// ( GuiControl ctrl [, int axis ] ) - Read the guides from the given control.
        /// </description>
        public void ReadGuides(GuiControl ctrl, int axis = -1) {
             InternalUnsafeMethods.ReadGuides__Args _args = new InternalUnsafeMethods.ReadGuides__Args() {
                ctrl = ctrl.ObjectPtr,
                axis = axis,
             };
             InternalUnsafeMethods.ReadGuides()(ObjectPtr, _args);
        }

        /// <description>
        /// GuiEditCtrl.setSnapToGrid(gridsize)
        /// </description>
        public void SetSnapToGrid(uint gridsize) {
             InternalUnsafeMethods.SetSnapToGrid__Args _args = new InternalUnsafeMethods.SetSnapToGrid__Args() {
                gridsize = gridsize,
             };
             InternalUnsafeMethods.SetSnapToGrid()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the GUI controls(s) that are currently in the trash.
        /// </description>
        public SimGroup GetTrash() {
             InternalUnsafeMethods.GetTrash__Args _args = new InternalUnsafeMethods.GetTrash__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTrash()(ObjectPtr, _args);
             return new SimGroup(_engineResult);
        }

        /// <description>
        /// ( bool addToSelection=false ) - Select children of currently selected controls.
        /// </description>
        public void SelectChildren(bool addToSelection = false) {
             InternalUnsafeMethods.SelectChildren__Args _args = new InternalUnsafeMethods.SelectChildren__Args() {
                addToSelection = addToSelection,
             };
             InternalUnsafeMethods.SelectChildren()(ObjectPtr, _args);
        }

        /// <description>
        /// ( bool addToSelection=false ) - Select parents of currently selected controls.
        /// </description>
        public void SelectParents(bool addToSelection = false) {
             InternalUnsafeMethods.SelectParents__Args _args = new InternalUnsafeMethods.SelectParents__Args() {
                addToSelection = addToSelection,
             };
             InternalUnsafeMethods.SelectParents()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Returns global bounds of current selection as vector 'x y width height'.
        /// </description>
        public string GetSelectionGlobalBounds() {
             InternalUnsafeMethods.GetSelectionGlobalBounds__Args _args = new InternalUnsafeMethods.GetSelectionGlobalBounds__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSelectionGlobalBounds()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// () - Return the number of controls currently selected.
        /// </description>
        public int GetNumSelected() {
             InternalUnsafeMethods.GetNumSelected__Args _args = new InternalUnsafeMethods.GetNumSelected__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetNumSelected()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the set of GUI controls currently selected in the editor.
        /// </description>
        public SimSet GetSelection() {
             InternalUnsafeMethods.GetSelection__Args _args = new InternalUnsafeMethods.GetSelection__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSelection()(ObjectPtr, _args);
             return new SimSet(_engineResult);
        }

        /// <description>
        /// ()
        /// </description>
        public void SelectAll() {
             InternalUnsafeMethods.SelectAll__Args _args = new InternalUnsafeMethods.SelectAll__Args() {
             };
             InternalUnsafeMethods.SelectAll()(ObjectPtr, _args);
        }

        /// <description>
        /// ( string fileName=null ) - Load selection from file or clipboard.
        /// </description>
        public void LoadSelection(string filename = "") {
             InternalUnsafeMethods.LoadSelection__Args _args = new InternalUnsafeMethods.LoadSelection__Args() {
                filename = filename,
             };
             InternalUnsafeMethods.LoadSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// ( string fileName=null ) - Save selection to file or clipboard.
        /// </description>
        public void SaveSelection(string filename = "") {
             InternalUnsafeMethods.SaveSelection__Args _args = new InternalUnsafeMethods.SaveSelection__Args() {
                filename = filename,
             };
             InternalUnsafeMethods.SaveSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// Move all controls in the selection by (dx,dy) pixels.
        /// </description>
        public void MoveSelection(int dx, int dy) {
             InternalUnsafeMethods.MoveSelection__Args _args = new InternalUnsafeMethods.MoveSelection__Args() {
                dx = dx,
                dy = dy,
             };
             InternalUnsafeMethods.MoveSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Delete the selected controls.
        /// </description>
        public void DeleteSelection() {
             InternalUnsafeMethods.DeleteSelection__Args _args = new InternalUnsafeMethods.DeleteSelection__Args() {
             };
             InternalUnsafeMethods.DeleteSelection()(ObjectPtr, _args);
        }

        /// 
        public void PushToBack() {
             InternalUnsafeMethods.PushToBack__Args _args = new InternalUnsafeMethods.PushToBack__Args() {
             };
             InternalUnsafeMethods.PushToBack()(ObjectPtr, _args);
        }

        /// 
        public void BringToFront() {
             InternalUnsafeMethods.BringToFront__Args _args = new InternalUnsafeMethods.BringToFront__Args() {
             };
             InternalUnsafeMethods.BringToFront()(ObjectPtr, _args);
        }

        /// <description>
        /// (int mode)
        /// </description>
        public void Justify(uint mode) {
             InternalUnsafeMethods.Justify__Args _args = new InternalUnsafeMethods.Justify__Args() {
                mode = mode,
             };
             InternalUnsafeMethods.Justify()(ObjectPtr, _args);
        }

        /// <description>
        /// Toggle activation.
        /// </description>
        public void Toggle() {
             InternalUnsafeMethods.Toggle__Args _args = new InternalUnsafeMethods.Toggle__Args() {
             };
             InternalUnsafeMethods.Toggle()(ObjectPtr, _args);
        }

        /// <description>
        /// Returns the set to which new controls will be added
        /// </description>
        public int GetCurrentAddSet() {
             InternalUnsafeMethods.GetCurrentAddSet__Args _args = new InternalUnsafeMethods.GetCurrentAddSet__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetCurrentAddSet()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (GuiControl ctrl)
        /// </description>
        public void SetCurrentAddSet(GuiControl addSet) {
             InternalUnsafeMethods.SetCurrentAddSet__Args _args = new InternalUnsafeMethods.SetCurrentAddSet__Args() {
                addSet = addSet.ObjectPtr,
             };
             InternalUnsafeMethods.SetCurrentAddSet()(ObjectPtr, _args);
        }

        /// <description>
        /// (GuiControl ctrl)
        /// </description>
        public void Select(GuiControl ctrl) {
             InternalUnsafeMethods.Select__Args _args = new InternalUnsafeMethods.Select__Args() {
                ctrl = ctrl.ObjectPtr,
             };
             InternalUnsafeMethods.Select()(ObjectPtr, _args);
        }

        /// <description>
        /// Clear selected controls list.
        /// </description>
        public void ClearSelection() {
             InternalUnsafeMethods.ClearSelection__Args _args = new InternalUnsafeMethods.ClearSelection__Args() {
             };
             InternalUnsafeMethods.ClearSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// deselects a control.
        /// </description>
        public void RemoveSelection(int id) {
             InternalUnsafeMethods.RemoveSelection__Args _args = new InternalUnsafeMethods.RemoveSelection__Args() {
                id = id,
             };
             InternalUnsafeMethods.RemoveSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// selects a control.
        /// </description>
        public void AddSelection(int id) {
             InternalUnsafeMethods.AddSelection__Args _args = new InternalUnsafeMethods.AddSelection__Args() {
                id = id,
             };
             InternalUnsafeMethods.AddSelection()(ObjectPtr, _args);
        }

        /// <description>
        /// (GuiControl ctrl)
        /// </description>
        public void AddNewCtrl(GuiControl ctrl) {
             InternalUnsafeMethods.AddNewCtrl__Args _args = new InternalUnsafeMethods.AddNewCtrl__Args() {
                ctrl = ctrl.ObjectPtr,
             };
             InternalUnsafeMethods.AddNewCtrl()(ObjectPtr, _args);
        }

        /// <description>
        /// ( GuiControl ctrl ) - Set the toplevel control to edit in the GUI editor.
        /// </description>
        public void SetContentControl(GuiControl ctrl) {
             InternalUnsafeMethods.SetContentControl__Args _args = new InternalUnsafeMethods.SetContentControl__Args() {
                ctrl = ctrl.ObjectPtr,
             };
             InternalUnsafeMethods.SetContentControl()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Return the toplevel control edited inside the GUI editor.
        /// </description>
        public int GetContentControl() {
             InternalUnsafeMethods.GetContentControl__Args _args = new InternalUnsafeMethods.GetContentControl__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetContentControl()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public virtual void OnControlInspectPostApply(GuiControl control) {
             InternalUnsafeMethods.OnControlInspectPostApply__Args _args = new InternalUnsafeMethods.OnControlInspectPostApply__Args() {
                control = control.ObjectPtr,
             };
             InternalUnsafeMethods.OnControlInspectPostApply()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnControlInspectPreApply(GuiControl control) {
             InternalUnsafeMethods.OnControlInspectPreApply__Args _args = new InternalUnsafeMethods.OnControlInspectPreApply__Args() {
                control = control.ObjectPtr,
             };
             InternalUnsafeMethods.OnControlInspectPreApply()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnMouseModeChange() {
             InternalUnsafeMethods.OnMouseModeChange__Args _args = new InternalUnsafeMethods.OnMouseModeChange__Args() {
             };
             InternalUnsafeMethods.OnMouseModeChange()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnFitIntoParent(bool width, bool height) {
             InternalUnsafeMethods.OnFitIntoParent__Args _args = new InternalUnsafeMethods.OnFitIntoParent__Args() {
                width = width,
                height = height,
             };
             InternalUnsafeMethods.OnFitIntoParent()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnSelectionResized(GuiControl control) {
             InternalUnsafeMethods.OnSelectionResized__Args _args = new InternalUnsafeMethods.OnSelectionResized__Args() {
                control = control.ObjectPtr,
             };
             InternalUnsafeMethods.OnSelectionResized()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnAddNewCtrlSet(SimSet set) {
             InternalUnsafeMethods.OnAddNewCtrlSet__Args _args = new InternalUnsafeMethods.OnAddNewCtrlSet__Args() {
                set = set.ObjectPtr,
             };
             InternalUnsafeMethods.OnAddNewCtrlSet()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnAddNewCtrl(GuiControl control) {
             InternalUnsafeMethods.OnAddNewCtrl__Args _args = new InternalUnsafeMethods.OnAddNewCtrl__Args() {
                control = control.ObjectPtr,
             };
             InternalUnsafeMethods.OnAddNewCtrl()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnTrashSelection(SimSet selection) {
             InternalUnsafeMethods.OnTrashSelection__Args _args = new InternalUnsafeMethods.OnTrashSelection__Args() {
                selection = selection.ObjectPtr,
             };
             InternalUnsafeMethods.OnTrashSelection()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnSelectionCloned(SimSet selection) {
             InternalUnsafeMethods.OnSelectionCloned__Args _args = new InternalUnsafeMethods.OnSelectionCloned__Args() {
                selection = selection.ObjectPtr,
             };
             InternalUnsafeMethods.OnSelectionCloned()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnSelectionMoved(GuiControl control) {
             InternalUnsafeMethods.OnSelectionMoved__Args _args = new InternalUnsafeMethods.OnSelectionMoved__Args() {
                control = control.ObjectPtr,
             };
             InternalUnsafeMethods.OnSelectionMoved()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnPostSelectionNudged(SimSet selection) {
             InternalUnsafeMethods.OnPostSelectionNudged__Args _args = new InternalUnsafeMethods.OnPostSelectionNudged__Args() {
                selection = selection.ObjectPtr,
             };
             InternalUnsafeMethods.OnPostSelectionNudged()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnPreSelectionNudged(SimSet selection) {
             InternalUnsafeMethods.OnPreSelectionNudged__Args _args = new InternalUnsafeMethods.OnPreSelectionNudged__Args() {
                selection = selection.ObjectPtr,
             };
             InternalUnsafeMethods.OnPreSelectionNudged()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnRemoveSelected(GuiControl control) {
             InternalUnsafeMethods.OnRemoveSelected__Args _args = new InternalUnsafeMethods.OnRemoveSelected__Args() {
                control = control.ObjectPtr,
             };
             InternalUnsafeMethods.OnRemoveSelected()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnAddSelected(GuiControl control) {
             InternalUnsafeMethods.OnAddSelected__Args _args = new InternalUnsafeMethods.OnAddSelected__Args() {
                control = control.ObjectPtr,
             };
             InternalUnsafeMethods.OnAddSelected()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnSelect(GuiControl control) {
             InternalUnsafeMethods.OnSelect__Args _args = new InternalUnsafeMethods.OnSelect__Args() {
                control = control.ObjectPtr,
             };
             InternalUnsafeMethods.OnSelect()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnClearSelected() {
             InternalUnsafeMethods.OnClearSelected__Args _args = new InternalUnsafeMethods.OnClearSelected__Args() {
             };
             InternalUnsafeMethods.OnClearSelected()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnPostEdit(SimSet selection) {
             InternalUnsafeMethods.OnPostEdit__Args _args = new InternalUnsafeMethods.OnPostEdit__Args() {
                selection = selection.ObjectPtr,
             };
             InternalUnsafeMethods.OnPostEdit()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnPreEdit(SimSet selection) {
             InternalUnsafeMethods.OnPreEdit__Args _args = new InternalUnsafeMethods.OnPreEdit__Args() {
                selection = selection.ObjectPtr,
             };
             InternalUnsafeMethods.OnPreEdit()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnDelete() {
             InternalUnsafeMethods.OnDelete__Args _args = new InternalUnsafeMethods.OnDelete__Args() {
             };
             InternalUnsafeMethods.OnDelete()(ObjectPtr, _args);
        }

        /// 
        public virtual void OnHierarchyChanged() {
             InternalUnsafeMethods.OnHierarchyChanged__Args _args = new InternalUnsafeMethods.OnHierarchyChanged__Args() {
             };
             InternalUnsafeMethods.OnHierarchyChanged()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiEditCtrl class.
        /// </description>
        /// <returns>The type info object for GuiEditCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// If true, edge and center snapping will work against controls.
        /// </description>
        /// </value>
        public bool SnapToControls {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("snapToControls"));
            set => SetFieldValue("snapToControls", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, edge and center snapping will work against guides.
        /// </description>
        /// </value>
        public bool SnapToGuides {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("snapToGuides"));
            set => SetFieldValue("snapToGuides", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, edge and center snapping will work against canvas (toplevel control).
        /// </description>
        /// </value>
        public bool SnapToCanvas {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("snapToCanvas"));
            set => SetFieldValue("snapToCanvas", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, selection edges will snap into alignment when moved or resized.
        /// </description>
        /// </value>
        public bool SnapToEdges {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("snapToEdges"));
            set => SetFieldValue("snapToEdges", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, selection centers will snap into alignment when moved or resized.
        /// </description>
        /// </value>
        public bool SnapToCenters {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("snapToCenters"));
            set => SetFieldValue("snapToCenters", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Distance in pixels that edge and center snapping will work across.
        /// </description>
        /// </value>
        public int SnapSensitivity {
            get => GenericMarshal.StringTo<int>(GetFieldValue("snapSensitivity"));
            set => SetFieldValue("snapSensitivity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, rectangle selection will only select controls fully inside the drag rectangle.
        /// </description>
        /// </value>
        public bool FullBoxSelection {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fullBoxSelection"));
            set => SetFieldValue("fullBoxSelection", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, lines will be drawn extending along the edges of selected objects.
        /// </description>
        /// </value>
        public bool DrawBorderLines {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("drawBorderLines"));
            set => SetFieldValue("drawBorderLines", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, guides will be included in rendering.
        /// </description>
        /// </value>
        public bool DrawGuides {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("drawGuides"));
            set => SetFieldValue("drawGuides", GenericMarshal.ToString(value));
        }
    }
}
