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
    /// <summary>A base class for cross platform menu controls that are gamepad friendly.</summary>
    /// <description>
    /// This class is used to build row-based menu GUIs that can be easily navigated using the keyboard, mouse or gamepad. The desired row can be selected using the mouse, or by navigating using the Up and Down buttons.
    /// </description>
    /// <code>
    /// new GuiGameListMenuCtrl()
    /// {
    ///    debugRender = "0";
    ///    callbackOnA = "applyOptions();";
    ///    callbackOnB = "Canvas.setContent(MainMenuGui);";
    ///    callbackOnX = "";
    ///    callbackOnY = "revertOptions();";
    ///    //Properties not specific to this control have been omitted from this example.
    /// };
    /// </code>
    /// <see cref="GuiGameListMenuProfile" />
    public class GuiGameListMenuCtrl : GuiControl {
        public GuiGameListMenuCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiGameListMenuCtrl(string pName, bool pRegister)
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

        public GuiGameListMenuCtrl(string pName)
            : this(pName, false) {
        }

        public GuiGameListMenuCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiGameListMenuCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiGameListMenuCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiGameListMenuCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTooltip__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTooltip(IntPtr _this, GetTooltip__Args args);
            private static _GetTooltip _GetTooltipFunc;
            internal static _GetTooltip GetTooltip() {
               _GetTooltipFunc ??= Torque3D.LookupEngineFunction<_GetTooltip>("fnGuiGameListMenuCtrl_getTooltip");

                return _GetTooltipFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetValue__Args
            {
                internal int row;
                internal float value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetValue(IntPtr _this, SetValue__Args args);
            private static _SetValue _SetValueFunc;
            internal static _SetValue SetValue() {
               _SetValueFunc ??= Torque3D.LookupEngineFunction<_SetValue>("fnGuiGameListMenuCtrl_setValue");

                return _SetValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetValue__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetValue(IntPtr _this, GetValue__Args args);
            private static _GetValue _GetValueFunc;
            internal static _GetValue GetValue() {
               _GetValueFunc ??= Torque3D.LookupEngineFunction<_GetValue>("fnGuiGameListMenuCtrl_getValue");

                return _GetValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddOption__Args
            {
                internal int row;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string displayText;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string keyText;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddOption(IntPtr _this, AddOption__Args args);
            private static _AddOption _AddOptionFunc;
            internal static _AddOption AddOption() {
               _AddOptionFunc ??= Torque3D.LookupEngineFunction<_AddOption>("fnGuiGameListMenuCtrl_addOption");

                return _AddOptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetOptions__Args
            {
                internal int row;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string optionsList;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetOptions(IntPtr _this, SetOptions__Args args);
            private static _SetOptions _SetOptionsFunc;
            internal static _SetOptions SetOptions() {
               _SetOptionsFunc ??= Torque3D.LookupEngineFunction<_SetOptions>("fnGuiGameListMenuCtrl_setOptions");

                return _SetOptionsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectOptionByIndex__Args
            {
                internal int row;
                internal int optionIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SelectOptionByIndex(IntPtr _this, SelectOptionByIndex__Args args);
            private static _SelectOptionByIndex _SelectOptionByIndexFunc;
            internal static _SelectOptionByIndex SelectOptionByIndex() {
               _SelectOptionByIndexFunc ??= Torque3D.LookupEngineFunction<_SelectOptionByIndex>("fnGuiGameListMenuCtrl_selectOptionByIndex");

                return _SelectOptionByIndexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectOptionByKey__Args
            {
                internal int row;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string optionKey;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SelectOptionByKey(IntPtr _this, SelectOptionByKey__Args args);
            private static _SelectOptionByKey _SelectOptionByKeyFunc;
            internal static _SelectOptionByKey SelectOptionByKey() {
               _SelectOptionByKeyFunc ??= Torque3D.LookupEngineFunction<_SelectOptionByKey>("fnGuiGameListMenuCtrl_selectOptionByKey");

                return _SelectOptionByKeyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectOption__Args
            {
                internal int row;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string option;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SelectOption(IntPtr _this, SelectOption__Args args);
            private static _SelectOption _SelectOptionFunc;
            internal static _SelectOption SelectOption() {
               _SelectOptionFunc ??= Torque3D.LookupEngineFunction<_SelectOption>("fnGuiGameListMenuCtrl_selectOption");

                return _SelectOptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentOptionIndex__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetCurrentOptionIndex(IntPtr _this, GetCurrentOptionIndex__Args args);
            private static _GetCurrentOptionIndex _GetCurrentOptionIndexFunc;
            internal static _GetCurrentOptionIndex GetCurrentOptionIndex() {
               _GetCurrentOptionIndexFunc ??= Torque3D.LookupEngineFunction<_GetCurrentOptionIndex>("fnGuiGameListMenuCtrl_getCurrentOptionIndex");

                return _GetCurrentOptionIndexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentOptionKey__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetCurrentOptionKey(IntPtr _this, GetCurrentOptionKey__Args args);
            private static _GetCurrentOptionKey _GetCurrentOptionKeyFunc;
            internal static _GetCurrentOptionKey GetCurrentOptionKey() {
               _GetCurrentOptionKeyFunc ??= Torque3D.LookupEngineFunction<_GetCurrentOptionKey>("fnGuiGameListMenuCtrl_getCurrentOptionKey");

                return _GetCurrentOptionKeyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentOption__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetCurrentOption(IntPtr _this, GetCurrentOption__Args args);
            private static _GetCurrentOption _GetCurrentOptionFunc;
            internal static _GetCurrentOption GetCurrentOption() {
               _GetCurrentOptionFunc ??= Torque3D.LookupEngineFunction<_GetCurrentOption>("fnGuiGameListMenuCtrl_getCurrentOption");

                return _GetCurrentOptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveRow__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveRow(IntPtr _this, RemoveRow__Args args);
            private static _RemoveRow _RemoveRowFunc;
            internal static _RemoveRow RemoveRow() {
               _RemoveRowFunc ??= Torque3D.LookupEngineFunction<_RemoveRow>("fnGuiGameListMenuCtrl_removeRow");

                return _RemoveRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddKeybindRow__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string bitmapName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
                internal int icon;
                internal int yPad;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string tooltip;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddKeybindRow(IntPtr _this, AddKeybindRow__Args args);
            private static _AddKeybindRow _AddKeybindRowFunc;
            internal static _AddKeybindRow AddKeybindRow() {
               _AddKeybindRowFunc ??= Torque3D.LookupEngineFunction<_AddKeybindRow>("fnGuiGameListMenuCtrl_addKeybindRow");

                return _AddKeybindRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddSliderRow__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
                internal float defaultValue;
                internal float increment;
                internal IntPtr range;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
                internal int icon;
                internal int yPad;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string tooltip;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddSliderRow(IntPtr _this, AddSliderRow__Args args);
            private static _AddSliderRow _AddSliderRowFunc;
            internal static _AddSliderRow AddSliderRow() {
               _AddSliderRowFunc ??= Torque3D.LookupEngineFunction<_AddSliderRow>("fnGuiGameListMenuCtrl_addSliderRow");

                return _AddSliderRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddOptionRow__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string options;
                [MarshalAs(UnmanagedType.I1)]
                internal bool wrapOptions;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
                internal int icon;
                internal int yPad;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string tooltip;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string defaultValue;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddOptionRow(IntPtr _this, AddOptionRow__Args args);
            private static _AddOptionRow _AddOptionRowFunc;
            internal static _AddOptionRow AddOptionRow() {
               _AddOptionRowFunc ??= Torque3D.LookupEngineFunction<_AddOptionRow>("fnGuiGameListMenuCtrl_addOptionRow");

                return _AddOptionRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Refresh__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Refresh(IntPtr _this, Refresh__Args args);
            private static _Refresh _RefreshFunc;
            internal static _Refresh Refresh() {
               _RefreshFunc ??= Torque3D.LookupEngineFunction<_Refresh>("fnGuiGameListMenuCtrl_refresh");

                return _RefreshFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearRows__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearRows(IntPtr _this, ClearRows__Args args);
            private static _ClearRows _ClearRowsFunc;
            internal static _ClearRows ClearRows() {
               _ClearRowsFunc ??= Torque3D.LookupEngineFunction<_ClearRows>("fnGuiGameListMenuCtrl_clearRows");

                return _ClearRowsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectedRow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectedRow(IntPtr _this, GetSelectedRow__Args args);
            private static _GetSelectedRow _GetSelectedRowFunc;
            internal static _GetSelectedRow GetSelectedRow() {
               _GetSelectedRowFunc ??= Torque3D.LookupEngineFunction<_GetSelectedRow>("fnGuiGameListMenuCtrl_getSelectedRow");

                return _GetSelectedRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelected__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelected(IntPtr _this, SetSelected__Args args);
            private static _SetSelected _SetSelectedFunc;
            internal static _SetSelected SetSelected() {
               _SetSelectedFunc ??= Torque3D.LookupEngineFunction<_SetSelected>("fnGuiGameListMenuCtrl_setSelected");

                return _SetSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRowLabel__Args
            {
                internal int row;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRowLabel(IntPtr _this, SetRowLabel__Args args);
            private static _SetRowLabel _SetRowLabelFunc;
            internal static _SetRowLabel SetRowLabel() {
               _SetRowLabelFunc ??= Torque3D.LookupEngineFunction<_SetRowLabel>("fnGuiGameListMenuCtrl_setRowLabel");

                return _SetRowLabelFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowLabel__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetRowLabel(IntPtr _this, GetRowLabel__Args args);
            private static _GetRowLabel _GetRowLabelFunc;
            internal static _GetRowLabel GetRowLabel() {
               _GetRowLabelFunc ??= Torque3D.LookupEngineFunction<_GetRowLabel>("fnGuiGameListMenuCtrl_getRowLabel");

                return _GetRowLabelFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRowCount(IntPtr _this, GetRowCount__Args args);
            private static _GetRowCount _GetRowCountFunc;
            internal static _GetRowCount GetRowCount() {
               _GetRowCountFunc ??= Torque3D.LookupEngineFunction<_GetRowCount>("fnGuiGameListMenuCtrl_getRowCount");

                return _GetRowCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ActivateRow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ActivateRow(IntPtr _this, ActivateRow__Args args);
            private static _ActivateRow _ActivateRowFunc;
            internal static _ActivateRow ActivateRow() {
               _ActivateRowFunc ??= Torque3D.LookupEngineFunction<_ActivateRow>("fnGuiGameListMenuCtrl_activateRow");

                return _ActivateRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRowEnabled__Args
            {
                internal int row;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRowEnabled(IntPtr _this, SetRowEnabled__Args args);
            private static _SetRowEnabled _SetRowEnabledFunc;
            internal static _SetRowEnabled SetRowEnabled() {
               _SetRowEnabledFunc ??= Torque3D.LookupEngineFunction<_SetRowEnabled>("fnGuiGameListMenuCtrl_setRowEnabled");

                return _SetRowEnabledFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsRowEnabled__Args
            {
                internal int row;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsRowEnabled(IntPtr _this, IsRowEnabled__Args args);
            private static _IsRowEnabled _IsRowEnabledFunc;
            internal static _IsRowEnabled IsRowEnabled() {
               _IsRowEnabledFunc ??= Torque3D.LookupEngineFunction<_IsRowEnabled>("fnGuiGameListMenuCtrl_isRowEnabled");

                return _IsRowEnabledFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddRow__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
                internal int icon;
                internal int yPad;
                [MarshalAs(UnmanagedType.I1)]
                internal bool useHighlightIcon;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
                internal int mode;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddRow(IntPtr _this, AddRow__Args args);
            private static _AddRow _AddRowFunc;
            internal static _AddRow AddRow() {
               _AddRowFunc ??= Torque3D.LookupEngineFunction<_AddRow>("fnGuiGameListMenuCtrl_addRow");

                return _AddRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAxisEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string device;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string action;
                internal float axisValue;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAxisEvent(IntPtr _this, OnAxisEvent__Args args);
            private static _OnAxisEvent _OnAxisEventFunc;
            internal static _OnAxisEvent OnAxisEvent() {
               _OnAxisEventFunc ??= Torque3D.LookupEngineFunction<_OnAxisEvent>("cbGuiGameListMenuCtrl_onAxisEvent");

                return _OnAxisEventFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnInputEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string device;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string action;
                [MarshalAs(UnmanagedType.I1)]
                internal bool state;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnInputEvent(IntPtr _this, OnInputEvent__Args args);
            private static _OnInputEvent _OnInputEventFunc;
            internal static _OnInputEvent OnInputEvent() {
               _OnInputEventFunc ??= Torque3D.LookupEngineFunction<_OnInputEvent>("cbGuiGameListMenuCtrl_onInputEvent");

                return _OnInputEventFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnChange__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnChange(IntPtr _this, OnChange__Args args);
            private static _OnChange _OnChangeFunc;
            internal static _OnChange OnChange() {
               _OnChangeFunc ??= Torque3D.LookupEngineFunction<_OnChange>("cbGuiGameListMenuCtrl_onChange");

                return _OnChangeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiGameListMenuCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiGameListMenuCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Sets the list of options on the given row.
        /// </description>
        /// <param name="row">Index of the row to set options on.</param>
        /// <param name="optionsList">A tab separated list of options for the control.</param>
        public string GetTooltip(int row) {
             InternalUnsafeMethods.GetTooltip__Args _args = new InternalUnsafeMethods.GetTooltip__Args() {
                row = row,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTooltip()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Sets the list of options on the given row.
        /// </description>
        /// <param name="row">Index of the row to set options on.</param>
        /// <param name="optionsList">A tab separated list of options for the control.</param>
        public void SetValue(int row, float value) {
             InternalUnsafeMethods.SetValue__Args _args = new InternalUnsafeMethods.SetValue__Args() {
                row = row,
                value = value,
             };
             InternalUnsafeMethods.SetValue()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the list of options on the given row.
        /// </description>
        /// <param name="row">Index of the row to set options on.</param>
        /// <param name="optionsList">A tab separated list of options for the control.</param>
        public float GetValue(int row) {
             InternalUnsafeMethods.GetValue__Args _args = new InternalUnsafeMethods.GetValue__Args() {
                row = row,
             };
             float _engineResult = InternalUnsafeMethods.GetValue()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Adds an option to the list of options on the given row.
        /// </description>
        /// <param name="row">Index of the row to add the option on.</param>
        /// <param name="displayText">The text to display for this option.</param>
        /// <param name="keyText">[Optional] The id string to associate with this value. If unset, the id will be the same as the display text.</param>
        public void AddOption(int row, string displayText, string keyText = "") {
             InternalUnsafeMethods.AddOption__Args _args = new InternalUnsafeMethods.AddOption__Args() {
                row = row,
                displayText = displayText,
                keyText = keyText,
             };
             InternalUnsafeMethods.AddOption()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the list of options on the given row.
        /// </description>
        /// <param name="row">Index of the row to set options on.</param>
        /// <param name="optionsList">A tab separated list of options for the control.</param>
        public void SetOptions(int row, string optionsList) {
             InternalUnsafeMethods.SetOptions__Args _args = new InternalUnsafeMethods.SetOptions__Args() {
                row = row,
                optionsList = optionsList,
             };
             InternalUnsafeMethods.SetOptions()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the row's current option to the one at the specified index.
        /// </description>
        /// <param name="row">Index of the row to set an option on.</param>
        /// <param name="optionIndex">The index of the option to be made active.</param>
        /// <returns>True if the index was valid and the option and was set, false otherwise.</returns>
        public bool SelectOptionByIndex(int row, int optionIndex) {
             InternalUnsafeMethods.SelectOptionByIndex__Args _args = new InternalUnsafeMethods.SelectOptionByIndex__Args() {
                row = row,
                optionIndex = optionIndex,
             };
             bool _engineResult = InternalUnsafeMethods.SelectOptionByIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set the row's current option to the one with the specified key.
        /// </description>
        /// <param name="row">Index of the row to set an option on.</param>
        /// <param name="optionKey">The key string that was assigned to the option to be made active.</param>
        /// <returns>True if the row contained the key and the option and was set, false otherwise.</returns>
        public bool SelectOptionByKey(int row, string optionKey) {
             InternalUnsafeMethods.SelectOptionByKey__Args _args = new InternalUnsafeMethods.SelectOptionByKey__Args() {
                row = row,
                optionKey = optionKey,
             };
             bool _engineResult = InternalUnsafeMethods.SelectOptionByKey()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set the row's current option to the one specified
        /// </description>
        /// <param name="row">Index of the row to set an option on.</param>
        /// <param name="option">The option to be made active.</param>
        /// <returns>True if the row contained the option and was set, false otherwise.</returns>
        public bool SelectOption(int row, string option) {
             InternalUnsafeMethods.SelectOption__Args _args = new InternalUnsafeMethods.SelectOption__Args() {
                row = row,
                option = option,
             };
             bool _engineResult = InternalUnsafeMethods.SelectOption()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the index into the option list for the currently selected option of the given row.
        /// </description>
        /// <param name="row">Index of the row to get the option from.</param>
        /// <returns>The index of the selected option on the given row. If there is no selected option then -1 is returned.</returns>
        public int GetCurrentOptionIndex(int row) {
             InternalUnsafeMethods.GetCurrentOptionIndex__Args _args = new InternalUnsafeMethods.GetCurrentOptionIndex__Args() {
                row = row,
             };
             int _engineResult = InternalUnsafeMethods.GetCurrentOptionIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the key string for the currently selected option of the given row.
        /// </description>
        /// <param name="row">Index of the row to get the option from.</param>
        /// <returns>The key (or id) that was assigned to the selected option on the given row. If there is no selected option then the empty string is returned.</returns>
        public string GetCurrentOptionKey(int row) {
             InternalUnsafeMethods.GetCurrentOptionKey__Args _args = new InternalUnsafeMethods.GetCurrentOptionKey__Args() {
                row = row,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetCurrentOptionKey()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the text for the currently selected option of the given row.
        /// </description>
        /// <param name="row">Index of the row to get the option from.</param>
        /// <returns>A string representing the text currently displayed as the selected option on the given row. If there is no such displayed text then the empty string is returned.</returns>
        public string GetCurrentOption(int row) {
             InternalUnsafeMethods.GetCurrentOption__Args _args = new InternalUnsafeMethods.GetCurrentOption__Args() {
                row = row,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetCurrentOption()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Removes the row at the provided index
        /// </description>
        public void RemoveRow(int row) {
             InternalUnsafeMethods.RemoveRow__Args _args = new InternalUnsafeMethods.RemoveRow__Args() {
                row = row,
             };
             InternalUnsafeMethods.RemoveRow()(ObjectPtr, _args);
        }

        /// <description>
        /// Add a row to the list control.
        /// </description>
        /// <param name="label">The text to display on the row as a label.</param>
        /// <param name="options">A tab separated list of options.</param>
        /// <param name="wrapOptions">Specify true to allow options to wrap at each end or false to prevent wrapping.</param>
        /// <param name="callback">Name of a script function to use as a callback when this row is activated.</param>
        /// <param name="icon">[optional] Index of the icon to use as a marker.</param>
        /// <param name="yPad">[optional] An extra amount of height padding before the row. Does nothing on the first row.</param>
        /// <param name="enabled">[optional] If this row is initially enabled.</param>
        public void AddKeybindRow(string label, string bitmapName, string callback, int icon = -1, int yPad = 0, bool enabled = true, string tooltip = "") {
             InternalUnsafeMethods.AddKeybindRow__Args _args = new InternalUnsafeMethods.AddKeybindRow__Args() {
                label = label,
                bitmapName = bitmapName,
                callback = callback,
                icon = icon,
                yPad = yPad,
                enabled = enabled,
                tooltip = tooltip,
             };
             InternalUnsafeMethods.AddKeybindRow()(ObjectPtr, _args);
        }

        /// <description>
        /// Add a row to the list control.
        /// </description>
        /// <param name="label">The text to display on the row as a label.</param>
        /// <param name="options">A tab separated list of options.</param>
        /// <param name="wrapOptions">Specify true to allow options to wrap at each end or false to prevent wrapping.</param>
        /// <param name="callback">Name of a script function to use as a callback when this row is activated.</param>
        /// <param name="icon">[optional] Index of the icon to use as a marker.</param>
        /// <param name="yPad">[optional] An extra amount of height padding before the row. Does nothing on the first row.</param>
        /// <param name="enabled">[optional] If this row is initially enabled.</param>
        public void AddSliderRow(string label, float defaultValue, float increment, Point2F range, string callback, int icon = -1, int yPad = 0, bool enabled = true, string tooltip = "") {
range.Alloc();             InternalUnsafeMethods.AddSliderRow__Args _args = new InternalUnsafeMethods.AddSliderRow__Args() {
                label = label,
                defaultValue = defaultValue,
                increment = increment,
                range = range.internalStructPtr,
                callback = callback,
                icon = icon,
                yPad = yPad,
                enabled = enabled,
                tooltip = tooltip,
             };
             InternalUnsafeMethods.AddSliderRow()(ObjectPtr, _args);
range.Free();        }

        /// <description>
        /// Add a row to the list control.
        /// </description>
        /// <param name="label">The text to display on the row as a label.</param>
        /// <param name="options">A tab separated list of options.</param>
        /// <param name="wrapOptions">Specify true to allow options to wrap at each end or false to prevent wrapping.</param>
        /// <param name="callback">Name of a script function to use as a callback when this row is activated.</param>
        /// <param name="icon">[optional] Index of the icon to use as a marker.</param>
        /// <param name="yPad">[optional] An extra amount of height padding before the row. Does nothing on the first row.</param>
        /// <param name="enabled">[optional] If this row is initially enabled.</param>
        public void AddOptionRow(string label, string options, bool wrapOptions, string callback, int icon = -1, int yPad = 0, bool enabled = true, string tooltip = "", string defaultValue = "") {
             InternalUnsafeMethods.AddOptionRow__Args _args = new InternalUnsafeMethods.AddOptionRow__Args() {
                label = label,
                options = options,
                wrapOptions = wrapOptions,
                callback = callback,
                icon = icon,
                yPad = yPad,
                enabled = enabled,
                tooltip = tooltip,
                defaultValue = defaultValue,
             };
             InternalUnsafeMethods.AddOptionRow()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the index of the currently selected row.
        /// </description>
        /// <returns>Index of the selected row.</returns>
        public void Refresh() {
             InternalUnsafeMethods.Refresh__Args _args = new InternalUnsafeMethods.Refresh__Args() {
             };
             InternalUnsafeMethods.Refresh()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the index of the currently selected row.
        /// </description>
        /// <returns>Index of the selected row.</returns>
        public void ClearRows() {
             InternalUnsafeMethods.ClearRows__Args _args = new InternalUnsafeMethods.ClearRows__Args() {
             };
             InternalUnsafeMethods.ClearRows()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the index of the currently selected row.
        /// </description>
        /// <returns>Index of the selected row.</returns>
        public int GetSelectedRow() {
             InternalUnsafeMethods.GetSelectedRow__Args _args = new InternalUnsafeMethods.GetSelectedRow__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectedRow()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Sets the selected row. Only rows that are enabled can be selected.
        /// </description>
        /// <param name="row">Index of the row to set as selected.</param>
        public void SetSelected(int row) {
             InternalUnsafeMethods.SetSelected__Args _args = new InternalUnsafeMethods.SetSelected__Args() {
                row = row,
             };
             InternalUnsafeMethods.SetSelected()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the label on the given row.
        /// </description>
        /// <param name="row">Index of the row to set the label on.</param>
        /// <param name="label">Text to set as the label of the row.</param>
        public void SetRowLabel(int row, string label) {
             InternalUnsafeMethods.SetRowLabel__Args _args = new InternalUnsafeMethods.SetRowLabel__Args() {
                row = row,
                label = label,
             };
             InternalUnsafeMethods.SetRowLabel()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the label displayed on the specified row.
        /// </description>
        /// <param name="row">Index of the row to get the label of.</param>
        /// <returns>The label for the row.</returns>
        public string GetRowLabel(int row) {
             InternalUnsafeMethods.GetRowLabel__Args _args = new InternalUnsafeMethods.GetRowLabel__Args() {
                row = row,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetRowLabel()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the number of rows on the control.
        /// </description>
        /// <returns>(int) The number of rows on the control.</returns>
        public int GetRowCount() {
             InternalUnsafeMethods.GetRowCount__Args _args = new InternalUnsafeMethods.GetRowCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetRowCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Activates the current row. The script callback of  the current row will be called (if it has one).
        /// </description>
        public void ActivateRow() {
             InternalUnsafeMethods.ActivateRow__Args _args = new InternalUnsafeMethods.ActivateRow__Args() {
             };
             InternalUnsafeMethods.ActivateRow()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets a row's enabled status according to the given parameters.
        /// </description>
        /// <param name="row">The index to check for validity.</param>
        /// <param name="enabled">Indicate true to enable the row or false to disable it.</param>
        public void SetRowEnabled(int row, bool enabled) {
             InternalUnsafeMethods.SetRowEnabled__Args _args = new InternalUnsafeMethods.SetRowEnabled__Args() {
                row = row,
                enabled = enabled,
             };
             InternalUnsafeMethods.SetRowEnabled()(ObjectPtr, _args);
        }

        /// <description>
        /// Determines if the specified row is enabled or disabled.
        /// </description>
        /// <param name="row">The row to set the enabled status of.</param>
        /// <returns>True if the specified row is enabled. False if the row is not enabled or the given index was not valid.</returns>
        public bool IsRowEnabled(int row) {
             InternalUnsafeMethods.IsRowEnabled__Args _args = new InternalUnsafeMethods.IsRowEnabled__Args() {
                row = row,
             };
             bool _engineResult = InternalUnsafeMethods.IsRowEnabled()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Add a row to the list control.
        /// </description>
        /// <param name="label">The text to display on the row as a label.</param>
        /// <param name="callback">Name of a script function to use as a callback when this row is activated.</param>
        /// <param name="icon">[optional] Index of the icon to use as a marker.</param>
        /// <param name="yPad">[optional] An extra amount of height padding before the row. Does nothing on the first row.</param>
        /// <param name="useHighlightIcon">[optional] Does this row use the highlight icon?.</param>
        /// <param name="enabled">[optional] If this row is initially enabled.</param>
        /// <param name="mode">[optional] What option mode the row is in. 0 = Default, 1 = OptionList, 2 == Keybind</param>
        public void AddRow(string label, string callback, int icon = -1, int yPad = 0, bool useHighlightIcon = true, bool enabled = true, int mode = 0) {
             InternalUnsafeMethods.AddRow__Args _args = new InternalUnsafeMethods.AddRow__Args() {
                label = label,
                callback = callback,
                icon = icon,
                yPad = yPad,
                useHighlightIcon = useHighlightIcon,
                enabled = enabled,
                mode = mode,
             };
             InternalUnsafeMethods.AddRow()(ObjectPtr, _args);
        }

        /// <summary>Callback that occurs when an axis event is triggered on this control</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="device">The device type triggering the input, such as mouse, joystick, gamepad, etc</param>
        /// <param name="action">The ActionMap code for the axis</param>
        /// <param name="axisValue">The current value of the axis</param>
        public virtual void OnAxisEvent(string device, string action, float axisValue) {
             InternalUnsafeMethods.OnAxisEvent__Args _args = new InternalUnsafeMethods.OnAxisEvent__Args() {
                device = device,
                action = action,
                axisValue = axisValue,
             };
             InternalUnsafeMethods.OnAxisEvent()(ObjectPtr, _args);
        }

        /// <summary>Callback that occurs when an input is triggered on this control</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="device">The device type triggering the input, such as keyboard, mouse, etc</param>
        /// <param name="action">The actual event occuring, such as a key or button</param>
        /// <param name="state">True if the action is being pressed, false if it is being release</param>
        public virtual void OnInputEvent(string device, string action, bool state) {
             InternalUnsafeMethods.OnInputEvent__Args _args = new InternalUnsafeMethods.OnInputEvent__Args() {
                device = device,
                action = action,
                state = state,
             };
             InternalUnsafeMethods.OnInputEvent()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the selected row changes.
        /// </description>
        public virtual void OnChange() {
             InternalUnsafeMethods.OnChange__Args _args = new InternalUnsafeMethods.OnChange__Args() {
             };
             InternalUnsafeMethods.OnChange()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiGameListMenuCtrl class.
        /// </description>
        /// <returns>The type info object for GuiGameListMenuCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Enable debug rendering
        /// </description>
        /// </value>
        public bool DebugRender {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("debugRender"));
            set => SetFieldValue("debugRender", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script callback when the 'A' button is pressed. 'A' inputs are Keyboard: A, Return, Space; Gamepad: A, Start
        /// </description>
        /// </value>
        public string CallbackOnA {
            get => GenericMarshal.StringTo<string>(GetFieldValue("callbackOnA"));
            set => SetFieldValue("callbackOnA", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script callback when the 'B' button is pressed. 'B' inputs are Keyboard: B, Esc, Backspace, Delete; Gamepad: B, Back
        /// </description>
        /// </value>
        public string CallbackOnB {
            get => GenericMarshal.StringTo<string>(GetFieldValue("callbackOnB"));
            set => SetFieldValue("callbackOnB", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script callback when the 'X' button is pressed. 'X' inputs are Keyboard: X; Gamepad: X
        /// </description>
        /// </value>
        public string CallbackOnX {
            get => GenericMarshal.StringTo<string>(GetFieldValue("callbackOnX"));
            set => SetFieldValue("callbackOnX", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script callback when the 'Y' button is pressed. 'Y' inputs are Keyboard: Y; Gamepad: Y
        /// </description>
        /// </value>
        public string CallbackOnY {
            get => GenericMarshal.StringTo<string>(GetFieldValue("callbackOnY"));
            set => SetFieldValue("callbackOnY", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script callback when any inputs are detected, even if they aren't the regular 4 face buttons. Useful for secondary/speciality handling of menu navigation.
        /// </description>
        /// </value>
        public bool CallbackOnInputs {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("callbackOnInputs"));
            set => SetFieldValue("callbackOnInputs", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// When callbackOnInputs is active, this indicates if the input event should be consumed, or allowed 'through' to let other things respond to the event as well.
        /// </description>
        /// </value>
        public bool ConsumeKeyInputEvents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("consumeKeyInputEvents"));
            set => SetFieldValue("consumeKeyInputEvents", GenericMarshal.ToString(value));
        }
    }
}
