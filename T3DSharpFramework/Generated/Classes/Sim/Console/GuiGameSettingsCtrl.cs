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
    /// <summary>A base class for cross platform menu controls that are gamepad friendly.</summary>
    /// <description>
    /// This class is used to build row-based menu GUIs that can be easily navigated using the keyboard, mouse or gamepad. The desired row can be selected using the mouse, or by navigating using the Up and Down buttons.
    /// </description>
    /// <code>
    /// new GuiGameSettingsCtrl()
    /// {
    ///    debugRender = "0";
    ///    callbackOnA = "applyOptions();";
    ///    callbackOnB = "Canvas.setContent(MainMenuGui);";
    ///    callbackOnX = "";
    ///    callbackOnY = "revertOptions();";
    ///    //Properties not specific to this control have been omitted from this example.
    /// };
    /// </code>
    /// <see cref="GuiGameSettingsProfile" />
    public class GuiGameSettingsCtrl : GuiButtonCtrl {
        public GuiGameSettingsCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiGameSettingsCtrl(string pName, bool pRegister)
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

        public GuiGameSettingsCtrl(string pName)
            : this(pName, false) {
        }

        public GuiGameSettingsCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiGameSettingsCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiGameSettingsCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiGameSettingsCtrl(IntPtr pObj)
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
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTooltip(IntPtr _this, GetTooltip__Args args);
            private static _GetTooltip _GetTooltipFunc;
            internal static _GetTooltip GetTooltip() {
               _GetTooltipFunc ??= Torque3D.LookupEngineFunction<_GetTooltip>("fnGuiGameSettingsCtrl_getTooltip");

                return _GetTooltipFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRange__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2F.InternalStruct _GetRange(IntPtr _this, GetRange__Args args);
            private static _GetRange _GetRangeFunc;
            internal static _GetRange GetRange() {
               _GetRangeFunc ??= Torque3D.LookupEngineFunction<_GetRange>("fnGuiGameSettingsCtrl_getRange");

                return _GetRangeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetIncrement__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetIncrement(IntPtr _this, GetIncrement__Args args);
            private static _GetIncrement _GetIncrementFunc;
            internal static _GetIncrement GetIncrement() {
               _GetIncrementFunc ??= Torque3D.LookupEngineFunction<_GetIncrement>("fnGuiGameSettingsCtrl_getIncrement");

                return _GetIncrementFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetValue__Args
            {
                internal float value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetValue(IntPtr _this, SetValue__Args args);
            private static _SetValue _SetValueFunc;
            internal static _SetValue SetValue() {
               _SetValueFunc ??= Torque3D.LookupEngineFunction<_SetValue>("fnGuiGameSettingsCtrl_setValue");

                return _SetValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetValue__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetValue(IntPtr _this, GetValue__Args args);
            private static _GetValue _GetValueFunc;
            internal static _GetValue GetValue() {
               _GetValueFunc ??= Torque3D.LookupEngineFunction<_GetValue>("fnGuiGameSettingsCtrl_getValue");

                return _GetValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddOption__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string displayText;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string keyText;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddOption(IntPtr _this, AddOption__Args args);
            private static _AddOption _AddOptionFunc;
            internal static _AddOption AddOption() {
               _AddOptionFunc ??= Torque3D.LookupEngineFunction<_AddOption>("fnGuiGameSettingsCtrl_addOption");

                return _AddOptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetOptions__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string optionsList;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetOptions(IntPtr _this, SetOptions__Args args);
            private static _SetOptions _SetOptionsFunc;
            internal static _SetOptions SetOptions() {
               _SetOptionsFunc ??= Torque3D.LookupEngineFunction<_SetOptions>("fnGuiGameSettingsCtrl_setOptions");

                return _SetOptionsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectOptionByIndex__Args
            {
                internal int optionIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SelectOptionByIndex(IntPtr _this, SelectOptionByIndex__Args args);
            private static _SelectOptionByIndex _SelectOptionByIndexFunc;
            internal static _SelectOptionByIndex SelectOptionByIndex() {
               _SelectOptionByIndexFunc ??= Torque3D.LookupEngineFunction<_SelectOptionByIndex>("fnGuiGameSettingsCtrl_selectOptionByIndex");

                return _SelectOptionByIndexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectOptionByKey__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string optionKey;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SelectOptionByKey(IntPtr _this, SelectOptionByKey__Args args);
            private static _SelectOptionByKey _SelectOptionByKeyFunc;
            internal static _SelectOptionByKey SelectOptionByKey() {
               _SelectOptionByKeyFunc ??= Torque3D.LookupEngineFunction<_SelectOptionByKey>("fnGuiGameSettingsCtrl_selectOptionByKey");

                return _SelectOptionByKeyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectOption__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string option;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SelectOption(IntPtr _this, SelectOption__Args args);
            private static _SelectOption _SelectOptionFunc;
            internal static _SelectOption SelectOption() {
               _SelectOptionFunc ??= Torque3D.LookupEngineFunction<_SelectOption>("fnGuiGameSettingsCtrl_selectOption");

                return _SelectOptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentOptionIndex__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetCurrentOptionIndex(IntPtr _this, GetCurrentOptionIndex__Args args);
            private static _GetCurrentOptionIndex _GetCurrentOptionIndexFunc;
            internal static _GetCurrentOptionIndex GetCurrentOptionIndex() {
               _GetCurrentOptionIndexFunc ??= Torque3D.LookupEngineFunction<_GetCurrentOptionIndex>("fnGuiGameSettingsCtrl_getCurrentOptionIndex");

                return _GetCurrentOptionIndexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentOptionKey__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetCurrentOptionKey(IntPtr _this, GetCurrentOptionKey__Args args);
            private static _GetCurrentOptionKey _GetCurrentOptionKeyFunc;
            internal static _GetCurrentOptionKey GetCurrentOptionKey() {
               _GetCurrentOptionKeyFunc ??= Torque3D.LookupEngineFunction<_GetCurrentOptionKey>("fnGuiGameSettingsCtrl_getCurrentOptionKey");

                return _GetCurrentOptionKeyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentOption__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetCurrentOption(IntPtr _this, GetCurrentOption__Args args);
            private static _GetCurrentOption _GetCurrentOptionFunc;
            internal static _GetCurrentOption GetCurrentOption() {
               _GetCurrentOptionFunc ??= Torque3D.LookupEngineFunction<_GetCurrentOption>("fnGuiGameSettingsCtrl_getCurrentOption");

                return _GetCurrentOptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetKeybindSetting__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string bitmapName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string tooltip;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetKeybindSetting(IntPtr _this, SetKeybindSetting__Args args);
            private static _SetKeybindSetting _SetKeybindSettingFunc;
            internal static _SetKeybindSetting SetKeybindSetting() {
               _SetKeybindSettingFunc ??= Torque3D.LookupEngineFunction<_SetKeybindSetting>("fnGuiGameSettingsCtrl_setKeybindSetting");

                return _SetKeybindSettingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSliderSetting__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
                internal float defaultValue;
                internal float increment;
                internal IntPtr range;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string tooltip;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSliderSetting(IntPtr _this, SetSliderSetting__Args args);
            private static _SetSliderSetting _SetSliderSettingFunc;
            internal static _SetSliderSetting SetSliderSetting() {
               _SetSliderSettingFunc ??= Torque3D.LookupEngineFunction<_SetSliderSetting>("fnGuiGameSettingsCtrl_setSliderSetting");

                return _SetSliderSettingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetListSetting__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string options;
                [MarshalAs(UnmanagedType.I1)]
                internal bool wrapOptions;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string tooltip;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string defaultValue;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetListSetting(IntPtr _this, SetListSetting__Args args);
            private static _SetListSetting _SetListSettingFunc;
            internal static _SetListSetting SetListSetting() {
               _SetListSettingFunc ??= Torque3D.LookupEngineFunction<_SetListSetting>("fnGuiGameSettingsCtrl_setListSetting");

                return _SetListSettingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMode__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMode(IntPtr _this, GetMode__Args args);
            private static _GetMode _GetModeFunc;
            internal static _GetMode GetMode() {
               _GetModeFunc ??= Torque3D.LookupEngineFunction<_GetMode>("fnGuiGameSettingsCtrl_getMode");

                return _GetModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Clear__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Clear(IntPtr _this, Clear__Args args);
            private static _Clear _ClearFunc;
            internal static _Clear Clear() {
               _ClearFunc ??= Torque3D.LookupEngineFunction<_Clear>("fnGuiGameSettingsCtrl_clear");

                return _ClearFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelected__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetSelected(IntPtr _this, GetSelected__Args args);
            private static _GetSelected _GetSelectedFunc;
            internal static _GetSelected GetSelected() {
               _GetSelectedFunc ??= Torque3D.LookupEngineFunction<_GetSelected>("fnGuiGameSettingsCtrl_getSelected");

                return _GetSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelected__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelected(IntPtr _this, SetSelected__Args args);
            private static _SetSelected _SetSelectedFunc;
            internal static _SetSelected SetSelected() {
               _SetSelectedFunc ??= Torque3D.LookupEngineFunction<_SetSelected>("fnGuiGameSettingsCtrl_setSelected");

                return _SetSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetLabel__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetLabel(IntPtr _this, SetLabel__Args args);
            private static _SetLabel _SetLabelFunc;
            internal static _SetLabel SetLabel() {
               _SetLabelFunc ??= Torque3D.LookupEngineFunction<_SetLabel>("fnGuiGameSettingsCtrl_setLabel");

                return _SetLabelFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLabel__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLabel(IntPtr _this, GetLabel__Args args);
            private static _GetLabel _GetLabelFunc;
            internal static _GetLabel GetLabel() {
               _GetLabelFunc ??= Torque3D.LookupEngineFunction<_GetLabel>("fnGuiGameSettingsCtrl_getLabel");

                return _GetLabelFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Activate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Activate(IntPtr _this, Activate__Args args);
            private static _Activate _ActivateFunc;
            internal static _Activate Activate() {
               _ActivateFunc ??= Torque3D.LookupEngineFunction<_Activate>("fnGuiGameSettingsCtrl_activate");

                return _ActivateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetEnabled__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetEnabled(IntPtr _this, SetEnabled__Args args);
            private static _SetEnabled _SetEnabledFunc;
            internal static _SetEnabled SetEnabled() {
               _SetEnabledFunc ??= Torque3D.LookupEngineFunction<_SetEnabled>("fnGuiGameSettingsCtrl_setEnabled");

                return _SetEnabledFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsEnabled__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsEnabled(IntPtr _this, IsEnabled__Args args);
            private static _IsEnabled _IsEnabledFunc;
            internal static _IsEnabled IsEnabled() {
               _IsEnabledFunc ??= Torque3D.LookupEngineFunction<_IsEnabled>("fnGuiGameSettingsCtrl_isEnabled");

                return _IsEnabledFunc;
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
               _OnAxisEventFunc ??= Torque3D.LookupEngineFunction<_OnAxisEvent>("cbGuiGameSettingsCtrl_onAxisEvent");

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
               _OnInputEventFunc ??= Torque3D.LookupEngineFunction<_OnInputEvent>("cbGuiGameSettingsCtrl_onInputEvent");

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
               _OnChangeFunc ??= Torque3D.LookupEngineFunction<_OnChange>("cbGuiGameSettingsCtrl_onChange");

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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiGameSettingsCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiGameSettingsCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Gets the tooltip on the given control.
        /// </description>
        public string GetTooltip() {
             InternalUnsafeMethods.GetTooltip__Args _args = new InternalUnsafeMethods.GetTooltip__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTooltip()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the min and max values for the range of the slider on a given control.
        /// </description>
        public Point2F GetRange() {
             InternalUnsafeMethods.GetRange__Args _args = new InternalUnsafeMethods.GetRange__Args() {
             };
             Point2F.InternalStruct _engineResult = InternalUnsafeMethods.GetRange()(ObjectPtr, _args);
             return new Point2F(_engineResult);
        }

        /// <description>
        /// Gets the increment amount of the slider on a given control.
        /// </description>
        public float GetIncrement() {
             InternalUnsafeMethods.GetIncrement__Args _args = new InternalUnsafeMethods.GetIncrement__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetIncrement()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Sets the value of the slider on the given control.
        /// </description>
        public void SetValue(float value) {
             InternalUnsafeMethods.SetValue__Args _args = new InternalUnsafeMethods.SetValue__Args() {
                value = value,
             };
             InternalUnsafeMethods.SetValue()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the value of the slider on the given control.
        /// </description>
        public float GetValue() {
             InternalUnsafeMethods.GetValue__Args _args = new InternalUnsafeMethods.GetValue__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetValue()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Adds an option to the list of options on the given control.
        /// </description>
        /// <param name="displayText">The text to display for this option.</param>
        /// <param name="keyText">[Optional] The id string to associate with this value. If unset, the id will be the same as the display text.</param>
        public void AddOption(string displayText, string keyText = "") {
             InternalUnsafeMethods.AddOption__Args _args = new InternalUnsafeMethods.AddOption__Args() {
                displayText = displayText,
                keyText = keyText,
             };
             InternalUnsafeMethods.AddOption()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the list of options on the given control.
        /// </description>
        /// <param name="optionsList">A tab separated list of options for the control.</param>
        public void SetOptions(string optionsList) {
             InternalUnsafeMethods.SetOptions__Args _args = new InternalUnsafeMethods.SetOptions__Args() {
                optionsList = optionsList,
             };
             InternalUnsafeMethods.SetOptions()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the control's current option to the one at the specified index.
        /// </description>
        /// <param name="optionIndex">The index of the option to be made active.</param>
        /// <returns>True if the index was valid and the option and was set, false otherwise.</returns>
        public bool SelectOptionByIndex(int optionIndex) {
             InternalUnsafeMethods.SelectOptionByIndex__Args _args = new InternalUnsafeMethods.SelectOptionByIndex__Args() {
                optionIndex = optionIndex,
             };
             bool _engineResult = InternalUnsafeMethods.SelectOptionByIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set the control's current option to the one with the specified key.
        /// </description>
        /// <param name="optionKey">The key string that was assigned to the option to be made active.</param>
        /// <returns>True if the control contained the key and the option and was set, false otherwise.</returns>
        public bool SelectOptionByKey(string optionKey) {
             InternalUnsafeMethods.SelectOptionByKey__Args _args = new InternalUnsafeMethods.SelectOptionByKey__Args() {
                optionKey = optionKey,
             };
             bool _engineResult = InternalUnsafeMethods.SelectOptionByKey()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set the control's current option to the one specified
        /// </description>
        /// <param name="option">The option to be made active.</param>
        /// <returns>True if the control contained the option and was set, false otherwise.</returns>
        public bool SelectOption(string option) {
             InternalUnsafeMethods.SelectOption__Args _args = new InternalUnsafeMethods.SelectOption__Args() {
                option = option,
             };
             bool _engineResult = InternalUnsafeMethods.SelectOption()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the index into the option list for the currently selected option.
        /// </description>
        /// <returns>The index of the selected option. If there is no selected option then -1 is returned.</returns>
        public int GetCurrentOptionIndex() {
             InternalUnsafeMethods.GetCurrentOptionIndex__Args _args = new InternalUnsafeMethods.GetCurrentOptionIndex__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetCurrentOptionIndex()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the key string for the currently selected option.
        /// </description>
        /// <returns>The key (or id) that was assigned to the selected option. If there is no selected option then the empty string is returned.</returns>
        public string GetCurrentOptionKey() {
             InternalUnsafeMethods.GetCurrentOptionKey__Args _args = new InternalUnsafeMethods.GetCurrentOptionKey__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetCurrentOptionKey()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the text for the currently selected option .
        /// </description>
        /// <returns>A string representing the text currently displayed as the selected option. If there is no such displayed text then the empty string is returned.</returns>
        public string GetCurrentOption() {
             InternalUnsafeMethods.GetCurrentOption__Args _args = new InternalUnsafeMethods.GetCurrentOption__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetCurrentOption()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Sets this setting to a keybind.
        /// </description>
        /// <param name="label">The text to display as a label.</param>
        /// <param name="options">A tab separated list of options.</param>
        /// <param name="wrapOptions">Specify true to allow options to wrap at each end or false to prevent wrapping.</param>
        /// <param name="callback">Name of a script function to use as a callback when this control is activated.</param>
        /// <param name="enabled">[optional] If this control is initially enabled.</param>
        public void SetKeybindSetting(string label, string bitmapName, string callback, bool enabled = true, string tooltip = "") {
             InternalUnsafeMethods.SetKeybindSetting__Args _args = new InternalUnsafeMethods.SetKeybindSetting__Args() {
                label = label,
                bitmapName = bitmapName,
                callback = callback,
                enabled = enabled,
                tooltip = tooltip,
             };
             InternalUnsafeMethods.SetKeybindSetting()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets this setting to a slider.
        /// </description>
        /// <param name="label">The text to display as a label.</param>
        /// <param name="options">A tab separated list of options.</param>
        /// <param name="wrapOptions">Specify true to allow options to wrap at each end or false to prevent wrapping.</param>
        /// <param name="callback">Name of a script function to use as a callback when this control is activated.</param>
        /// <param name="enabled">[optional] If this control is initially enabled.</param>
        public void SetSliderSetting(string label, float defaultValue, float increment, Point2F range, string callback, bool enabled = true, string tooltip = "") {
range.Alloc();             InternalUnsafeMethods.SetSliderSetting__Args _args = new InternalUnsafeMethods.SetSliderSetting__Args() {
                label = label,
                defaultValue = defaultValue,
                increment = increment,
                range = range.internalStructPtr,
                callback = callback,
                enabled = enabled,
                tooltip = tooltip,
             };
             InternalUnsafeMethods.SetSliderSetting()(ObjectPtr, _args);
range.Free();        }

        /// <description>
        /// Sets this setting to a list.
        /// </description>
        /// <param name="label">The text to display  as a label.</param>
        /// <param name="options">A tab separated list of options.</param>
        /// <param name="wrapOptions">Specify true to allow options to wrap at each end or false to prevent wrapping.</param>
        /// <param name="callback">Name of a script function to use as a callback when this control is activated.</param>
        /// <param name="enabled">[optional] If this control is initially enabled.</param>
        public void SetListSetting(string label, string options, bool wrapOptions, string callback, bool enabled = true, string tooltip = "", string defaultValue = "") {
             InternalUnsafeMethods.SetListSetting__Args _args = new InternalUnsafeMethods.SetListSetting__Args() {
                label = label,
                options = options,
                wrapOptions = wrapOptions,
                callback = callback,
                enabled = enabled,
                tooltip = tooltip,
                defaultValue = defaultValue,
             };
             InternalUnsafeMethods.SetListSetting()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets this control's options mode.
        /// </description>
        public int GetMode() {
             InternalUnsafeMethods.GetMode__Args _args = new InternalUnsafeMethods.GetMode__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetMode()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Clears the current options.
        /// </description>
        public void Clear() {
             InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
             };
             InternalUnsafeMethods.Clear()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets if the control is currently selected.
        /// </description>
        /// <returns>if the control is selected.</returns>
        public bool GetSelected() {
             InternalUnsafeMethods.GetSelected__Args _args = new InternalUnsafeMethods.GetSelected__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetSelected()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Sets the control as selected. Can only select enabled controls.
        /// </description>
        public void SetSelected() {
             InternalUnsafeMethods.SetSelected__Args _args = new InternalUnsafeMethods.SetSelected__Args() {
             };
             InternalUnsafeMethods.SetSelected()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the label.
        /// </description>
        /// <param name="label">Text to set as the label.</param>
        public void SetLabel(string label) {
             InternalUnsafeMethods.SetLabel__Args _args = new InternalUnsafeMethods.SetLabel__Args() {
                label = label,
             };
             InternalUnsafeMethods.SetLabel()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the label displayed.
        /// </description>
        /// <returns>The label.</returns>
        public string GetLabel() {
             InternalUnsafeMethods.GetLabel__Args _args = new InternalUnsafeMethods.GetLabel__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLabel()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Activates the control. The script callback of the control will be called (if it has one).
        /// </description>
        public void Activate() {
             InternalUnsafeMethods.Activate__Args _args = new InternalUnsafeMethods.Activate__Args() {
             };
             InternalUnsafeMethods.Activate()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the control's enabled status according to the given parameters.
        /// </description>
        /// <param name="enabled">Indicate true to enable the control or false to disable it.</param>
        public void SetEnabled(bool enabled) {
             InternalUnsafeMethods.SetEnabled__Args _args = new InternalUnsafeMethods.SetEnabled__Args() {
                enabled = enabled,
             };
             InternalUnsafeMethods.SetEnabled()(ObjectPtr, _args);
        }

        /// <description>
        /// Determines if the control is enabled or disabled.
        /// </description>
        /// <returns>True if the control is enabled. False if the control is not enabled.</returns>
        public bool IsEnabled() {
             InternalUnsafeMethods.IsEnabled__Args _args = new InternalUnsafeMethods.IsEnabled__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsEnabled()(ObjectPtr, _args);
             return _engineResult;
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
        /// Called when the setting's value changes.
        /// </description>
        public virtual void OnChange() {
             InternalUnsafeMethods.OnChange__Args _args = new InternalUnsafeMethods.OnChange__Args() {
             };
             InternalUnsafeMethods.OnChange()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiGameSettingsCtrl class.
        /// </description>
        /// <returns>The type info object for GuiGameSettingsCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>KeybindBitmap "Bitmap used to display the bound key for this keybind option."</summary>
        /// </value>
        public string KeybindBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("KeybindBitmap"));
            set => SetFieldValue("KeybindBitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>KeybindBitmap asset "Bitmap used to display the bound key for this keybind option.".</summary>
        /// </value>
        public string KeybindBitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("KeybindBitmapAsset"));
            set => SetFieldValue("KeybindBitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>PreviousBitmap "Bitmap used for the previous button when in list mode."</summary>
        /// </value>
        public string PreviousBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("PreviousBitmap"));
            set => SetFieldValue("PreviousBitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>PreviousBitmap asset "Bitmap used for the previous button when in list mode.".</summary>
        /// </value>
        public string PreviousBitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("PreviousBitmapAsset"));
            set => SetFieldValue("PreviousBitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>NextBitmap "Bitmap used for the next button when in list mode."</summary>
        /// </value>
        public string NextBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("NextBitmap"));
            set => SetFieldValue("NextBitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>NextBitmap asset "Bitmap used for the next button when in list mode.".</summary>
        /// </value>
        public string NextBitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("NextBitmapAsset"));
            set => SetFieldValue("NextBitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Size of the arrow buttons' extents
        /// </description>
        /// </value>
        public int ArrowSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("arrowSize"));
            set => SetFieldValue("arrowSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Position of the split between the leftside label and the rightside setting parts
        /// </description>
        /// </value>
        public int ColumnSplit {
            get => GenericMarshal.StringTo<int>(GetFieldValue("columnSplit"));
            set => SetFieldValue("columnSplit", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Padding between the rightmost edge of the control and right arrow.
        /// </description>
        /// </value>
        public int RightPad {
            get => GenericMarshal.StringTo<int>(GetFieldValue("rightPad"));
            set => SetFieldValue("rightPad", GenericMarshal.ToString(value));
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
