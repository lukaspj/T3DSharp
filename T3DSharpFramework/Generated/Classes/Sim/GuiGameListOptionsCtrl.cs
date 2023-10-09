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
    /// <summary>A control for showing pages of options that are gamepad friendly.</summary>
    /// <description>
    /// Each row in this control allows the selection of one value from a set of options using the keyboard, gamepad or mouse. The row is rendered as 2 columns: the first column contains the row label, the second column contains left and right arrows (for mouse picking) and the currently selected value.
    /// </description>
    /// <see cref="GuiGameListOptionsProfile" />
    public class GuiGameListOptionsCtrl : GuiGameListMenuCtrl {
        public GuiGameListOptionsCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiGameListOptionsCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiGameListOptionsCtrl(string pName)
            : this(pName, false) {
        }

        public GuiGameListOptionsCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiGameListOptionsCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiGameListOptionsCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiGameListOptionsCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearOptions__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearOptions(IntPtr _this, ClearOptions__Args args);
            private static _ClearOptions _ClearOptionsFunc;
            internal static _ClearOptions ClearOptions() {
               _ClearOptionsFunc ??= Torque3D.LookupEngineFunction<_ClearOptions>("fnGuiGameListOptionsCtrl_clearOptions");

                return _ClearOptionsFunc;
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
               _SetOptionsFunc ??= Torque3D.LookupEngineFunction<_SetOptions>("fnGuiGameListOptionsCtrl_setOptions");

                return _SetOptionsFunc;
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
               _SelectOptionFunc ??= Torque3D.LookupEngineFunction<_SelectOption>("fnGuiGameListOptionsCtrl_selectOption");

                return _SelectOptionFunc;
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
               _GetCurrentOptionFunc ??= Torque3D.LookupEngineFunction<_GetCurrentOption>("fnGuiGameListOptionsCtrl_getCurrentOption");

                return _GetCurrentOptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddRow__Args
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
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddRow(IntPtr _this, AddRow__Args args);
            private static _AddRow _AddRowFunc;
            internal static _AddRow AddRow() {
               _AddRowFunc ??= Torque3D.LookupEngineFunction<_AddRow>("fnGuiGameListOptionsCtrl_addRow");

                return _AddRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiGameListOptionsCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiGameListOptionsCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Sets the list of options on the given row.
        /// </description>
        /// <param name="row">Index of the row to set options on.</param>
        /// <param name="optionsList">A tab separated list of options for the control.</param>
        public void ClearOptions() {
             InternalUnsafeMethods.ClearOptions__Args _args = new InternalUnsafeMethods.ClearOptions__Args() {
             };
             InternalUnsafeMethods.ClearOptions()(ObjectPtr, _args);
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
        /// Add a row to the list control.
        /// </description>
        /// <param name="label">The text to display on the row as a label.</param>
        /// <param name="options">A tab separated list of options.</param>
        /// <param name="wrapOptions">Specify true to allow options to wrap at each end or false to prevent wrapping.</param>
        /// <param name="callback">Name of a script function to use as a callback when this row is activated.</param>
        /// <param name="icon">[optional] Index of the icon to use as a marker.</param>
        /// <param name="yPad">[optional] An extra amount of height padding before the row. Does nothing on the first row.</param>
        /// <param name="enabled">[optional] If this row is initially enabled.</param>
        public void AddRow(string label, string options, bool wrapOptions, string callback, int icon = -1, int yPad = 0, bool enabled = true) {
             InternalUnsafeMethods.AddRow__Args _args = new InternalUnsafeMethods.AddRow__Args() {
                label = label,
                options = options,
                wrapOptions = wrapOptions,
                callback = callback,
                icon = icon,
                yPad = yPad,
                enabled = enabled,
             };
             InternalUnsafeMethods.AddRow()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiGameListOptionsCtrl class.
        /// </description>
        /// <returns>The type info object for GuiGameListOptionsCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
