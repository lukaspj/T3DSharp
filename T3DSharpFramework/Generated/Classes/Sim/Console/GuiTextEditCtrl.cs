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
    /// <summary>A component that places a text entry box on the screen.</summary>
    /// <description>
    /// Fonts and sizes are changed using profiles. The text value can be set or entered by a user.
    /// </description>
    /// <code>
    /// new GuiTextEditCtrl(MessageHud_Edit)
    ///   {
    ///       text = "Hello World";
    ///       validate = "validateCommand();"
    ///       escapeCommand = "escapeCommand();";
    ///       historySize = "5";
    ///       tabComplete = "true";
    ///       deniedSound = "DeniedSoundProfile";
    ///       sinkAllKeyEvents = "true";
    ///       password = "true";
    ///       passwordMask = "*";
    ///        //Properties not specific to this control have been omitted from this example.
    ///    };
    /// </code>
    /// <see cref="GuiTextCtrl" />
    /// <see cref="GuiControl" />
    public class GuiTextEditCtrl : GuiTextCtrl {
        public GuiTextEditCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiTextEditCtrl(string pName, bool pRegister)
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

        public GuiTextEditCtrl(string pName)
            : this(pName, false) {
        }

        public GuiTextEditCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiTextEditCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiTextEditCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiTextEditCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct IsValidText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsValidText(IntPtr _this, IsValidText__Args args);
            private static _IsValidText _IsValidTextFunc;
            internal static _IsValidText IsValidText() {
               _IsValidTextFunc ??= Torque3D.LookupEngineFunction<_IsValidText>("fnGuiTextEditCtrl_isValidText");

                return _IsValidTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ValidText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ValidText(IntPtr _this, ValidText__Args args);
            private static _ValidText _ValidTextFunc;
            internal static _ValidText ValidText() {
               _ValidTextFunc ??= Torque3D.LookupEngineFunction<_ValidText>("fnGuiTextEditCtrl_validText");

                return _ValidTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct InvalidText__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool playSound;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _InvalidText(IntPtr _this, InvalidText__Args args);
            private static _InvalidText _InvalidTextFunc;
            internal static _InvalidText InvalidText() {
               _InvalidTextFunc ??= Torque3D.LookupEngineFunction<_InvalidText>("fnGuiTextEditCtrl_invalidText");

                return _InvalidTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ForceValidateText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ForceValidateText(IntPtr _this, ForceValidateText__Args args);
            private static _ForceValidateText _ForceValidateTextFunc;
            internal static _ForceValidateText ForceValidateText() {
               _ForceValidateTextFunc ??= Torque3D.LookupEngineFunction<_ForceValidateText>("fnGuiTextEditCtrl_forceValidateText");

                return _ForceValidateTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearSelectedText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearSelectedText(IntPtr _this, ClearSelectedText__Args args);
            private static _ClearSelectedText _ClearSelectedTextFunc;
            internal static _ClearSelectedText ClearSelectedText() {
               _ClearSelectedTextFunc ??= Torque3D.LookupEngineFunction<_ClearSelectedText>("fnGuiTextEditCtrl_clearSelectedText");

                return _ClearSelectedTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectAllText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SelectAllText(IntPtr _this, SelectAllText__Args args);
            private static _SelectAllText _SelectAllTextFunc;
            internal static _SelectAllText SelectAllText() {
               _SelectAllTextFunc ??= Torque3D.LookupEngineFunction<_SelectAllText>("fnGuiTextEditCtrl_selectAllText");

                return _SelectAllTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsAllTextSelected__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsAllTextSelected(IntPtr _this, IsAllTextSelected__Args args);
            private static _IsAllTextSelected _IsAllTextSelectedFunc;
            internal static _IsAllTextSelected IsAllTextSelected() {
               _IsAllTextSelectedFunc ??= Torque3D.LookupEngineFunction<_IsAllTextSelected>("fnGuiTextEditCtrl_isAllTextSelected");

                return _IsAllTextSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCursorPos__Args
            {
                internal int position;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCursorPos(IntPtr _this, SetCursorPos__Args args);
            private static _SetCursorPos _SetCursorPosFunc;
            internal static _SetCursorPos SetCursorPos() {
               _SetCursorPosFunc ??= Torque3D.LookupEngineFunction<_SetCursorPos>("fnGuiTextEditCtrl_setCursorPos");

                return _SetCursorPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCursorPos__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetCursorPos(IntPtr _this, GetCursorPos__Args args);
            private static _GetCursorPos _GetCursorPosFunc;
            internal static _GetCursorPos GetCursorPos() {
               _GetCursorPosFunc ??= Torque3D.LookupEngineFunction<_GetCursorPos>("fnGuiTextEditCtrl_getCursorPos");

                return _GetCursorPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetText__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetText(IntPtr _this, SetText__Args args);
            private static _SetText _SetTextFunc;
            internal static _SetText SetText() {
               _SetTextFunc ??= Torque3D.LookupEngineFunction<_SetText>("fnGuiTextEditCtrl_setText");

                return _SetTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetText(IntPtr _this, GetText__Args args);
            private static _GetText _GetTextFunc;
            internal static _GetText GetText() {
               _GetTextFunc ??= Torque3D.LookupEngineFunction<_GetText>("fnGuiTextEditCtrl_getText");

                return _GetTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnValidate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnValidate(IntPtr _this, OnValidate__Args args);
            private static _OnValidate _OnValidateFunc;
            internal static _OnValidate OnValidate() {
               _OnValidateFunc ??= Torque3D.LookupEngineFunction<_OnValidate>("cbGuiTextEditCtrl_onValidate");

                return _OnValidateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnReturn__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnReturn(IntPtr _this, OnReturn__Args args);
            private static _OnReturn _OnReturnFunc;
            internal static _OnReturn OnReturn() {
               _OnReturnFunc ??= Torque3D.LookupEngineFunction<_OnReturn>("cbGuiTextEditCtrl_onReturn");

                return _OnReturnFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnTabComplete__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string val;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnTabComplete(IntPtr _this, OnTabComplete__Args args);
            private static _OnTabComplete _OnTabCompleteFunc;
            internal static _OnTabComplete OnTabComplete() {
               _OnTabCompleteFunc ??= Torque3D.LookupEngineFunction<_OnTabComplete>("cbGuiTextEditCtrl_onTabComplete");

                return _OnTabCompleteFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiTextEditCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiTextEditCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Returns if the text is set to valid or not.n</summary>
        public bool IsValidText() {
             InternalUnsafeMethods.IsValidText__Args _args = new InternalUnsafeMethods.IsValidText__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsValidText()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Restores the box to normal color.nn</summary>
        public void ValidText() {
             InternalUnsafeMethods.ValidText__Args _args = new InternalUnsafeMethods.ValidText__Args() {
             };
             InternalUnsafeMethods.ValidText()(ObjectPtr, _args);
        }

        /// <summary>Trigger the invalid sound and make the box red.nn</summary>
        /// <param name="playSound">Play the invalid text sound or not.n</param>
        public void InvalidText(bool playSound = true) {
             InternalUnsafeMethods.InvalidText__Args _args = new InternalUnsafeMethods.InvalidText__Args() {
                playSound = playSound,
             };
             InternalUnsafeMethods.InvalidText()(ObjectPtr, _args);
        }

        /// <summary>Force a validation to occur.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // Inform the control to force a validation of its text.
        /// %thisGuiTextEditCtrl.forceValidateText();
        /// </code>
        /// <see cref="GuiControl" />
        public void ForceValidateText() {
             InternalUnsafeMethods.ForceValidateText__Args _args = new InternalUnsafeMethods.ForceValidateText__Args() {
             };
             InternalUnsafeMethods.ForceValidateText()(ObjectPtr, _args);
        }

        /// <summary>Unselects all selected text in the control.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // Inform the control to unselect all of its selected text
        /// %thisGuiTextEditCtrl.clearSelectedText();
        /// </code>
        /// <see cref="GuiControl" />
        public void ClearSelectedText() {
             InternalUnsafeMethods.ClearSelectedText__Args _args = new InternalUnsafeMethods.ClearSelectedText__Args() {
             };
             InternalUnsafeMethods.ClearSelectedText()(ObjectPtr, _args);
        }

        /// <summary>Selects all text within the control.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // Inform the control to select all of its text.
        /// %thisGuiTextEditCtrl.selectAllText();
        /// </code>
        /// <see cref="GuiControl" />
        public void SelectAllText() {
             InternalUnsafeMethods.SelectAllText__Args _args = new InternalUnsafeMethods.SelectAllText__Args() {
             };
             InternalUnsafeMethods.SelectAllText()(ObjectPtr, _args);
        }

        /// <summary>Checks to see if all text in the control has been selected.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // Check to see if all text has been selected or not.
        /// %allSelected = %thisGuiTextEditCtrl.isAllTextSelected();
        /// </code>
        /// <returns>True if all text in the control is selected, otherwise false.</returns>
        /// <see cref="GuiControl" />
        public bool IsAllTextSelected() {
             InternalUnsafeMethods.IsAllTextSelected__Args _args = new InternalUnsafeMethods.IsAllTextSelected__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsAllTextSelected()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Sets the text cursor at the defined position within the control.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="position">Text position to set the text cursor.</param>
        /// <code>
        /// // Define the cursor position
        /// %position = "12";
        /// 
        /// // Inform the GuiTextEditCtrl control to place the text cursor at the defined position
        /// %thisGuiTextEditCtrl.setCursorPos(%position);
        /// </code>
        /// <see cref="GuiControl" />
        public void SetCursorPos(int position) {
             InternalUnsafeMethods.SetCursorPos__Args _args = new InternalUnsafeMethods.SetCursorPos__Args() {
                position = position,
             };
             InternalUnsafeMethods.SetCursorPos()(ObjectPtr, _args);
        }

        /// <summary>Returns the current position of the text cursor in the control.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // Acquire the cursor position in the control
        /// %position = %thisGuiTextEditCtrl.getCursorPost();
        /// </code>
        /// <returns>Text cursor position within the control.</returns>
        /// <see cref="GuiControl" />
        public int GetCursorPos() {
             InternalUnsafeMethods.GetCursorPos__Args _args = new InternalUnsafeMethods.GetCursorPos__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetCursorPos()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Sets the text in the control.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="text">Text to place in the control.</param>
        /// <code>
        /// // Define the text to display
        /// %text = "Text!"
        /// 
        /// // Inform the GuiTextEditCtrl to display the defined text
        /// %thisGuiTextEditCtrl.setText(%text);
        /// </code>
        /// <see cref="GuiControl" />
        public void SetText(string text) {
             InternalUnsafeMethods.SetText__Args _args = new InternalUnsafeMethods.SetText__Args() {
                text = text,
             };
             InternalUnsafeMethods.SetText()(ObjectPtr, _args);
        }

        /// <summary>Acquires the current text displayed in this control.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // Acquire the value of the text control.
        /// %text = %thisGuiTextEditCtrl.getText();
        /// </code>
        /// <returns>The current text within the control.</returns>
        /// <see cref="GuiControl" />
        public string GetText() {
             InternalUnsafeMethods.GetText__Args _args = new InternalUnsafeMethods.GetText__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetText()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Called whenever the control is validated.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // The control gets validated, causing the callback to occur
        /// GuiTextEditCtrl::onValidated(%this)
        ///   {
        ///      // Code to run when the control is validated
        ///   }
        /// </code>
        /// <see cref="GuiTextCtrl" />
        /// <see cref="GuiControl" />
        public virtual void OnValidate() {
             InternalUnsafeMethods.OnValidate__Args _args = new InternalUnsafeMethods.OnValidate__Args() {
             };
             InternalUnsafeMethods.OnValidate()(ObjectPtr, _args);
        }

        /// <summary>Called when the 'Return' or 'Enter' key is pressed.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // Return or Enter key was pressed, causing the callback to occur.
        /// GuiTextEditCtrl::onReturn(%this)
        ///   {
        ///      // Code to run when the onReturn callback occurs
        ///   }
        /// </code>
        /// <see cref="GuiTextCtrl" />
        /// <see cref="GuiControl" />
        public virtual void OnReturn() {
             InternalUnsafeMethods.OnReturn__Args _args = new InternalUnsafeMethods.OnReturn__Args() {
             };
             InternalUnsafeMethods.OnReturn()(ObjectPtr, _args);
        }

        /// <summary>Called if tabComplete is true, and the 'tab' key is pressed.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="val">Input to mimick the '1' sent by the actual tab key button press.</param>
        /// <code>
        /// // Tab key has been pressed, causing the callback to occur.
        /// GuiTextEditCtrl::onTabComplete(%this,%val)
        ///   {
        ///      //Code to run when the onTabComplete callback occurs
        ///   }
        /// </code>
        /// <see cref="GuiTextCtrl" />
        /// <see cref="GuiControl" />
        public virtual void OnTabComplete(string val) {
             InternalUnsafeMethods.OnTabComplete__Args _args = new InternalUnsafeMethods.OnTabComplete__Args() {
                val = val,
             };
             InternalUnsafeMethods.OnTabComplete()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiTextEditCtrl class.
        /// </description>
        /// <returns>The type info object for GuiTextEditCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// The text to show on the control.
        /// </description>
        /// </value>
        public string PlaceholderText {
            get => GenericMarshal.StringTo<string>(GetFieldValue("placeholderText"));
            set => SetFieldValue("placeholderText", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script command to be called when the first validater is lost.
        /// </description>
        /// </value>
        public string Validate {
            get => GenericMarshal.StringTo<string>(GetFieldValue("validate"));
            set => SetFieldValue("validate", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Script command to be called when the Escape key is pressed.
        /// </description>
        /// </value>
        public string EscapeCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("escapeCommand"));
            set => SetFieldValue("escapeCommand", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// How large of a history buffer to maintain.
        /// </description>
        /// </value>
        public int HistorySize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("historySize"));
            set => SetFieldValue("historySize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, when the 'tab' key is pressed, it will act as if the Enter key was pressed on the control.
        /// </description>
        /// </value>
        public bool TabComplete {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("tabComplete"));
            set => SetFieldValue("tabComplete", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If the attempted text cannot be entered, this sound effect will be played.
        /// </description>
        /// </value>
        public SFXTrack DeniedSound {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("deniedSound"));
            set => SetFieldValue("deniedSound", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, every key event will act as if the Enter key was pressed.
        /// </description>
        /// </value>
        public bool SinkAllKeyEvents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sinkAllKeyEvents"));
            set => SetFieldValue("sinkAllKeyEvents", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, all characters entered will be stored in the control, however will display as the character stored in passwordMask.
        /// </description>
        /// </value>
        public bool Password {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("password"));
            set => SetFieldValue("password", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If 'password' is true, this is the character that will be used to mask the characters in the control.
        /// </description>
        /// </value>
        public string PasswordMask {
            get => GenericMarshal.StringTo<string>(GetFieldValue("passwordMask"));
            set => SetFieldValue("passwordMask", GenericMarshal.ToString(value));
        }
    }
}
