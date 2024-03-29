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
    /// <summary>The base class for the various button controls.</summary>
    /// <description>
    /// This is the base class for the various types of button controls.  If no more specific functionality is required than offered by this class, then it can be instantiated and used directly.  Otherwise, its subclasses should be used:
    /// - GuiRadioCtrl (radio buttons)
    /// - GuiCheckBoxCtrl (checkboxes)
    /// - GuiButtonCtrl (push buttons with text labels)
    /// - GuiBitmapButtonCtrl (bitmapped buttons)
    /// - GuiBitmapButtonTextCtrl (bitmapped buttons with a text label)
    /// - GuiToggleButtonCtrl (toggle buttons, i.e. push buttons with "sticky" behavior)
    /// - GuiSwatchButtonCtrl (color swatch buttons)
    /// - GuiBorderButtonCtrl (push buttons for surrounding child controls)
    /// </description>
    public class GuiButtonBaseCtrl : GuiControl {
        public GuiButtonBaseCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiButtonBaseCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiButtonBaseCtrl(string pName)
            : this(pName, false) {
        }

        public GuiButtonBaseCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiButtonBaseCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiButtonBaseCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiButtonBaseCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct IsHighlighted__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsHighlighted(IntPtr _this, IsHighlighted__Args args);
            private static _IsHighlighted _IsHighlightedFunc;
            internal static _IsHighlighted IsHighlighted() {
               _IsHighlightedFunc ??= Torque3D.LookupEngineFunction<_IsHighlighted>("fnGuiButtonBaseCtrl_isHighlighted");

                return _IsHighlightedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetHighlighted__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool highlighted;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetHighlighted(IntPtr _this, SetHighlighted__Args args);
            private static _SetHighlighted _SetHighlightedFunc;
            internal static _SetHighlighted SetHighlighted() {
               _SetHighlightedFunc ??= Torque3D.LookupEngineFunction<_SetHighlighted>("fnGuiButtonBaseCtrl_setHighlighted");

                return _SetHighlightedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetState__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetState(IntPtr _this, ResetState__Args args);
            private static _ResetState _ResetStateFunc;
            internal static _ResetState ResetState() {
               _ResetStateFunc ??= Torque3D.LookupEngineFunction<_ResetState>("fnGuiButtonBaseCtrl_resetState");

                return _ResetStateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetStateOn__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool isOn;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetStateOn(IntPtr _this, SetStateOn__Args args);
            private static _SetStateOn _SetStateOnFunc;
            internal static _SetStateOn SetStateOn() {
               _SetStateOnFunc ??= Torque3D.LookupEngineFunction<_SetStateOn>("fnGuiButtonBaseCtrl_setStateOn");

                return _SetStateOnFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetText(IntPtr _this, GetText__Args args);
            private static _GetText _GetTextFunc;
            internal static _GetText GetText() {
               _GetTextFunc ??= Torque3D.LookupEngineFunction<_GetText>("fnGuiButtonBaseCtrl_getText");

                return _GetTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTextID__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTextID(IntPtr _this, SetTextID__Args args);
            private static _SetTextID _SetTextIDFunc;
            internal static _SetTextID SetTextID() {
               _SetTextIDFunc ??= Torque3D.LookupEngineFunction<_SetTextID>("fnGuiButtonBaseCtrl_setTextID");

                return _SetTextIDFunc;
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
               _SetTextFunc ??= Torque3D.LookupEngineFunction<_SetText>("fnGuiButtonBaseCtrl_setText");

                return _SetTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PerformClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PerformClick(IntPtr _this, PerformClick__Args args);
            private static _PerformClick _PerformClickFunc;
            internal static _PerformClick PerformClick() {
               _PerformClickFunc ??= Torque3D.LookupEngineFunction<_PerformClick>("fnGuiButtonBaseCtrl_performClick");

                return _PerformClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMouseDragged__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMouseDragged(IntPtr _this, OnMouseDragged__Args args);
            private static _OnMouseDragged _OnMouseDraggedFunc;
            internal static _OnMouseDragged OnMouseDragged() {
               _OnMouseDraggedFunc ??= Torque3D.LookupEngineFunction<_OnMouseDragged>("cbGuiButtonBaseCtrl_onMouseDragged");

                return _OnMouseDraggedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMouseLeave__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMouseLeave(IntPtr _this, OnMouseLeave__Args args);
            private static _OnMouseLeave _OnMouseLeaveFunc;
            internal static _OnMouseLeave OnMouseLeave() {
               _OnMouseLeaveFunc ??= Torque3D.LookupEngineFunction<_OnMouseLeave>("cbGuiButtonBaseCtrl_onMouseLeave");

                return _OnMouseLeaveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMouseEnter__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMouseEnter(IntPtr _this, OnMouseEnter__Args args);
            private static _OnMouseEnter _OnMouseEnterFunc;
            internal static _OnMouseEnter OnMouseEnter() {
               _OnMouseEnterFunc ??= Torque3D.LookupEngineFunction<_OnMouseEnter>("cbGuiButtonBaseCtrl_onMouseEnter");

                return _OnMouseEnterFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnRightClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnRightClick(IntPtr _this, OnRightClick__Args args);
            private static _OnRightClick _OnRightClickFunc;
            internal static _OnRightClick OnRightClick() {
               _OnRightClickFunc ??= Torque3D.LookupEngineFunction<_OnRightClick>("cbGuiButtonBaseCtrl_onRightClick");

                return _OnRightClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDoubleClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDoubleClick(IntPtr _this, OnDoubleClick__Args args);
            private static _OnDoubleClick _OnDoubleClickFunc;
            internal static _OnDoubleClick OnDoubleClick() {
               _OnDoubleClickFunc ??= Torque3D.LookupEngineFunction<_OnDoubleClick>("cbGuiButtonBaseCtrl_onDoubleClick");

                return _OnDoubleClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnClick(IntPtr _this, OnClick__Args args);
            private static _OnClick _OnClickFunc;
            internal static _OnClick OnClick() {
               _OnClickFunc ??= Torque3D.LookupEngineFunction<_OnClick>("cbGuiButtonBaseCtrl_onClick");

                return _OnClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMouseUp__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMouseUp(IntPtr _this, OnMouseUp__Args args);
            private static _OnMouseUp _OnMouseUpFunc;
            internal static _OnMouseUp OnMouseUp() {
               _OnMouseUpFunc ??= Torque3D.LookupEngineFunction<_OnMouseUp>("cbGuiButtonBaseCtrl_onMouseUp");

                return _OnMouseUpFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMouseDown__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnMouseDown(IntPtr _this, OnMouseDown__Args args);
            private static _OnMouseDown _OnMouseDownFunc;
            internal static _OnMouseDown OnMouseDown() {
               _OnMouseDownFunc ??= Torque3D.LookupEngineFunction<_OnMouseDown>("cbGuiButtonBaseCtrl_onMouseDown");

                return _OnMouseDownFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiButtonBaseCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiButtonBaseCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Reset the mousing state of the button.
        /// 
        /// This method should not generally be called.
        /// </description>
        public bool IsHighlighted() {
             InternalUnsafeMethods.IsHighlighted__Args _args = new InternalUnsafeMethods.IsHighlighted__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsHighlighted()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Reset the mousing state of the button.
        /// 
        /// This method should not generally be called.
        /// </description>
        public void SetHighlighted(bool highlighted = false) {
             InternalUnsafeMethods.SetHighlighted__Args _args = new InternalUnsafeMethods.SetHighlighted__Args() {
                highlighted = highlighted,
             };
             InternalUnsafeMethods.SetHighlighted()(ObjectPtr, _args);
        }

        /// <description>
        /// Reset the mousing state of the button.
        /// 
        /// This method should not generally be called.
        /// </description>
        public void ResetState() {
             InternalUnsafeMethods.ResetState__Args _args = new InternalUnsafeMethods.ResetState__Args() {
             };
             InternalUnsafeMethods.ResetState()(ObjectPtr, _args);
        }

        /// <description>
        /// For toggle or radio buttons, set whether the button is currently activated or not.  For radio buttons, toggling a button on will toggle all other radio buttons in its group to off.
        /// </description>
        /// <param name="isOn">If true, the button will be toggled on (if not already); if false, it will be toggled off.</param>
        /// <remarks> Toggling the state of a button with this method will <em>not</em> not trigger the action associated with the button.  To do that, use performClick().</remarks>
        public void SetStateOn(bool isOn = true) {
             InternalUnsafeMethods.SetStateOn__Args _args = new InternalUnsafeMethods.SetStateOn__Args() {
                isOn = isOn,
             };
             InternalUnsafeMethods.SetStateOn()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the text display on the button's label (if any).
        /// </description>
        /// <returns>The button's label.</returns>
        public string GetText() {
             InternalUnsafeMethods.GetText__Args _args = new InternalUnsafeMethods.GetText__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetText()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Set the text displayed on the button's label using a string from the string table assigned to the control.
        /// </description>
        /// <param name="id">Name of the variable that contains the integer string ID.  Used to look up string in table.</param>
        /// <remarks> Not all buttons render text labels.
        /// 
        /// </remarks>
        /// <see cref="setText" />
        /// <see cref="getText" />
        /// <see cref="GuiControl::langTableMod" />
        /// <see cref="LangTable" />
        public void SetTextID(string id) {
             InternalUnsafeMethods.SetTextID__Args _args = new InternalUnsafeMethods.SetTextID__Args() {
                id = id,
             };
             InternalUnsafeMethods.SetTextID()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the text displayed on the button's label.
        /// </description>
        /// <param name="text">The text to display as the button's text label.</param>
        /// <remarks> Not all buttons render text labels.
        /// 
        /// </remarks>
        /// <see cref="getText" />
        /// <see cref="setTextID" />
        public void SetText(string text) {
             InternalUnsafeMethods.SetText__Args _args = new InternalUnsafeMethods.SetText__Args() {
                text = text,
             };
             InternalUnsafeMethods.SetText()(ObjectPtr, _args);
        }

        /// <description>
        /// Simulate a click on the button.
        /// This method will trigger the button's action just as if the button had been pressed by the user.
        /// </description>
        public void PerformClick() {
             InternalUnsafeMethods.PerformClick__Args _args = new InternalUnsafeMethods.PerformClick__Args() {
             };
             InternalUnsafeMethods.PerformClick()(ObjectPtr, _args);
        }

        /// <description>
        /// If #useMouseEvents is true, this is called when a left mouse button drag is detected, i.e. when the user pressed the left mouse button on the control and then moves the mouse over a certain distance threshold with the mouse button still pressed.
        /// </description>
        public virtual void OnMouseDragged() {
             InternalUnsafeMethods.OnMouseDragged__Args _args = new InternalUnsafeMethods.OnMouseDragged__Args() {
             };
             InternalUnsafeMethods.OnMouseDragged()(ObjectPtr, _args);
        }

        /// <description>
        /// If #useMouseEvents is true, this is called when the mouse cursor moves off the button (only if the button had previously received an onMouseEvent() event).
        /// </description>
        public virtual void OnMouseLeave() {
             InternalUnsafeMethods.OnMouseLeave__Args _args = new InternalUnsafeMethods.OnMouseLeave__Args() {
             };
             InternalUnsafeMethods.OnMouseLeave()(ObjectPtr, _args);
        }

        /// <description>
        /// If #useMouseEvents is true, this is called when the mouse cursor moves over the button (only if the button is the front-most visible control, though).
        /// </description>
        public virtual void OnMouseEnter() {
             InternalUnsafeMethods.OnMouseEnter__Args _args = new InternalUnsafeMethods.OnMouseEnter__Args() {
             };
             InternalUnsafeMethods.OnMouseEnter()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the right mouse button is clicked on the button.
        /// </description>
        public virtual void OnRightClick() {
             InternalUnsafeMethods.OnRightClick__Args _args = new InternalUnsafeMethods.OnRightClick__Args() {
             };
             InternalUnsafeMethods.OnRightClick()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the left mouse button is double-clicked on the button.
        /// </description>
        public virtual void OnDoubleClick() {
             InternalUnsafeMethods.OnDoubleClick__Args _args = new InternalUnsafeMethods.OnDoubleClick__Args() {
             };
             InternalUnsafeMethods.OnDoubleClick()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the primary action of the button is triggered (e.g. by a left mouse click).
        /// </description>
        public virtual void OnClick() {
             InternalUnsafeMethods.OnClick__Args _args = new InternalUnsafeMethods.OnClick__Args() {
             };
             InternalUnsafeMethods.OnClick()(ObjectPtr, _args);
        }

        /// <description>
        /// If #useMouseEvents is true, this is called when the left mouse button is release over an (active) button.
        /// </description>
        /// <remarks> To trigger actions, better use onClick() since onMouseUp() will also be called when the mouse was not originally pressed on the button.</remarks>
        public virtual void OnMouseUp() {
             InternalUnsafeMethods.OnMouseUp__Args _args = new InternalUnsafeMethods.OnMouseUp__Args() {
             };
             InternalUnsafeMethods.OnMouseUp()(ObjectPtr, _args);
        }

        /// <description>
        /// If #useMouseEvents is true, this is called when the left mouse button is pressed on an (active) button.
        /// </description>
        public virtual void OnMouseDown() {
             InternalUnsafeMethods.OnMouseDown__Args _args = new InternalUnsafeMethods.OnMouseDown__Args() {
             };
             InternalUnsafeMethods.OnMouseDown()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiButtonBaseCtrl class.
        /// </description>
        /// <returns>The type info object for GuiButtonBaseCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Text label to display on button (if button class supports text labels).
        /// </description>
        /// </value>
        public string Text {
            get => GenericMarshal.StringTo<string>(GetFieldValue("text"));
            set => SetFieldValue("text", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ID of string in string table to use for text label on button.
        /// </description>
        /// <see cref="setTextID" />
        /// <see cref="GuiControl::langTableMod" />
        /// <see cref="LangTable" />
        /// </value>
        public string TextID {
            get => GenericMarshal.StringTo<string>(GetFieldValue("textID"));
            set => SetFieldValue("textID", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Radio button toggle group number.  All radio buttons that are assigned the same #groupNum and that are parented to the same control will synchronize their toggle state, i.e. if one radio button is toggled on all other radio buttons in its group will be toggled off.
        /// 
        /// The default group is -1.
        /// </description>
        /// </value>
        public int GroupNum {
            get => GenericMarshal.StringTo<int>(GetFieldValue("groupNum"));
            set => SetFieldValue("groupNum", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Button behavior type.
        /// </description>
        /// </value>
        public GuiButtonType ButtonType {
            get => GenericMarshal.StringTo<GuiButtonType>(GetFieldValue("buttonType"));
            set => SetFieldValue("buttonType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, mouse events will be passed on to script.  Default is false.
        /// </description>
        /// </value>
        public bool UseMouseEvents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useMouseEvents"));
            set => SetFieldValue("useMouseEvents", GenericMarshal.ToString(value));
        }
    }
}
