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
    /// <summary>PopupMenu represents a system menu.</summary>
    /// <description>
    /// You can add menu items to the menu, but there is no torque object associated with these menu items, they exist only in a  platform specific manner.
    /// </description>
    /// <remarks> Internal use only
    /// 
    /// </remarks>
    public class PopupMenu : SimObject {
        public PopupMenu(bool pRegister = false)
            : base(pRegister) {
        }

        public PopupMenu(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public PopupMenu(string pName)
            : this(pName, false) {
        }

        public PopupMenu(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public PopupMenu(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public PopupMenu(SimObject pObj)
            : base(pObj) {
        }

        public PopupMenu(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ShowPopup__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string canvasName;
                internal int x;
                internal int y;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ShowPopup(IntPtr _this, ShowPopup__Args args);
            private static _ShowPopup _ShowPopupFunc;
            internal static _ShowPopup ShowPopup() {
               _ShowPopupFunc ??= Torque3D.LookupEngineFunction<_ShowPopup>("fnPopupMenu_showPopup");

                return _ShowPopupFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearItems__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearItems(IntPtr _this, ClearItems__Args args);
            private static _ClearItems _ClearItemsFunc;
            internal static _ClearItems ClearItems() {
               _ClearItemsFunc ??= Torque3D.LookupEngineFunction<_ClearItems>("fnPopupMenu_clearItems");

                return _ClearItemsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetItemCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetItemCount(IntPtr _this, GetItemCount__Args args);
            private static _GetItemCount _GetItemCountFunc;
            internal static _GetItemCount GetItemCount() {
               _GetItemCountFunc ??= Torque3D.LookupEngineFunction<_GetItemCount>("fnPopupMenu_getItemCount");

                return _GetItemCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsItemChecked__Args
            {
                internal int pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsItemChecked(IntPtr _this, IsItemChecked__Args args);
            private static _IsItemChecked _IsItemCheckedFunc;
            internal static _IsItemChecked IsItemChecked() {
               _IsItemCheckedFunc ??= Torque3D.LookupEngineFunction<_IsItemChecked>("fnPopupMenu_isItemChecked");

                return _IsItemCheckedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CheckRadioItem__Args
            {
                internal int firstPos;
                internal int lastPos;
                internal int checkPos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CheckRadioItem(IntPtr _this, CheckRadioItem__Args args);
            private static _CheckRadioItem _CheckRadioItemFunc;
            internal static _CheckRadioItem CheckRadioItem() {
               _CheckRadioItemFunc ??= Torque3D.LookupEngineFunction<_CheckRadioItem>("fnPopupMenu_checkRadioItem");

                return _CheckRadioItemFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetItemText__Args
            {
                internal int pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetItemText(IntPtr _this, GetItemText__Args args);
            private static _GetItemText _GetItemTextFunc;
            internal static _GetItemText GetItemText() {
               _GetItemTextFunc ??= Torque3D.LookupEngineFunction<_GetItemText>("fnPopupMenu_getItemText");

                return _GetItemTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CheckItem__Args
            {
                internal int pos;
                [MarshalAs(UnmanagedType.I1)]
                internal bool _checked;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CheckItem(IntPtr _this, CheckItem__Args args);
            private static _CheckItem _CheckItemFunc;
            internal static _CheckItem CheckItem() {
               _CheckItemFunc ??= Torque3D.LookupEngineFunction<_CheckItem>("fnPopupMenu_checkItem");

                return _CheckItemFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct EnableItem__Args
            {
                internal int pos;
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _EnableItem(IntPtr _this, EnableItem__Args args);
            private static _EnableItem _EnableItemFunc;
            internal static _EnableItem EnableItem() {
               _EnableItemFunc ??= Torque3D.LookupEngineFunction<_EnableItem>("fnPopupMenu_enableItem");

                return _EnableItemFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetItem__Args
            {
                internal int pos;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string title;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string accelerator;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string cmd;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetItem(IntPtr _this, SetItem__Args args);
            private static _SetItem _SetItemFunc;
            internal static _SetItem SetItem() {
               _SetItemFunc ??= Torque3D.LookupEngineFunction<_SetItem>("fnPopupMenu_setItem");

                return _SetItemFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct InsertSubMenu__Args
            {
                internal int pos;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string title;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string subMenu;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _InsertSubMenu(IntPtr _this, InsertSubMenu__Args args);
            private static _InsertSubMenu _InsertSubMenuFunc;
            internal static _InsertSubMenu InsertSubMenu() {
               _InsertSubMenuFunc ??= Torque3D.LookupEngineFunction<_InsertSubMenu>("fnPopupMenu_insertSubMenu");

                return _InsertSubMenuFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveItem__Args
            {
                internal int pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveItem(IntPtr _this, RemoveItem__Args args);
            private static _RemoveItem _RemoveItemFunc;
            internal static _RemoveItem RemoveItem() {
               _RemoveItemFunc ??= Torque3D.LookupEngineFunction<_RemoveItem>("fnPopupMenu_removeItem");

                return _RemoveItemFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct InsertItem__Args
            {
                internal int pos;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string title;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string accelerator;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string cmd;
                internal int bitmapIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _InsertItem(IntPtr _this, InsertItem__Args args);
            private static _InsertItem _InsertItemFunc;
            internal static _InsertItem InsertItem() {
               _InsertItemFunc ??= Torque3D.LookupEngineFunction<_InsertItem>("fnPopupMenu_insertItem");

                return _InsertItemFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnPopupMenu_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnPopupMenu_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// (Canvas,[x, y])
        /// </description>
        public void ShowPopup(string canvasName, int x = -1, int y = -1) {
             InternalUnsafeMethods.ShowPopup__Args _args = new InternalUnsafeMethods.ShowPopup__Args() {
                canvasName = canvasName,
                x = x,
                y = y,
             };
             InternalUnsafeMethods.ShowPopup()(ObjectPtr, _args);
        }

        /// <description>
        /// ()
        /// </description>
        public void ClearItems() {
             InternalUnsafeMethods.ClearItems__Args _args = new InternalUnsafeMethods.ClearItems__Args() {
             };
             InternalUnsafeMethods.ClearItems()(ObjectPtr, _args);
        }

        /// <description>
        /// ()
        /// </description>
        public int GetItemCount() {
             InternalUnsafeMethods.GetItemCount__Args _args = new InternalUnsafeMethods.GetItemCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetItemCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (pos)
        /// </description>
        public bool IsItemChecked(int pos) {
             InternalUnsafeMethods.IsItemChecked__Args _args = new InternalUnsafeMethods.IsItemChecked__Args() {
                pos = pos,
             };
             bool _engineResult = InternalUnsafeMethods.IsItemChecked()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (firstPos, lastPos, checkPos)
        /// </description>
        public void CheckRadioItem(int firstPos, int lastPos, int checkPos) {
             InternalUnsafeMethods.CheckRadioItem__Args _args = new InternalUnsafeMethods.CheckRadioItem__Args() {
                firstPos = firstPos,
                lastPos = lastPos,
                checkPos = checkPos,
             };
             InternalUnsafeMethods.CheckRadioItem()(ObjectPtr, _args);
        }

        /// <description>
        /// (pos)
        /// </description>
        public string GetItemText(int pos) {
             InternalUnsafeMethods.GetItemText__Args _args = new InternalUnsafeMethods.GetItemText__Args() {
                pos = pos,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetItemText()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (pos, checked)
        /// </description>
        public void CheckItem(int pos, bool _checked) {
             InternalUnsafeMethods.CheckItem__Args _args = new InternalUnsafeMethods.CheckItem__Args() {
                pos = pos,
                _checked = _checked,
             };
             InternalUnsafeMethods.CheckItem()(ObjectPtr, _args);
        }

        /// <description>
        /// (pos, enabled)
        /// </description>
        public void EnableItem(int pos, bool enabled) {
             InternalUnsafeMethods.EnableItem__Args _args = new InternalUnsafeMethods.EnableItem__Args() {
                pos = pos,
                enabled = enabled,
             };
             InternalUnsafeMethods.EnableItem()(ObjectPtr, _args);
        }

        /// <description>
        /// (pos, title[, accelerator][, cmd])
        /// </description>
        public bool SetItem(int pos, string title, string accelerator, string cmd = "") {
             InternalUnsafeMethods.SetItem__Args _args = new InternalUnsafeMethods.SetItem__Args() {
                pos = pos,
                title = title,
                accelerator = accelerator,
                cmd = cmd,
             };
             bool _engineResult = InternalUnsafeMethods.SetItem()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (pos, title, subMenu)
        /// </description>
        public int InsertSubMenu(int pos, string title, string subMenu) {
             InternalUnsafeMethods.InsertSubMenu__Args _args = new InternalUnsafeMethods.InsertSubMenu__Args() {
                pos = pos,
                title = title,
                subMenu = subMenu,
             };
             int _engineResult = InternalUnsafeMethods.InsertSubMenu()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (pos)
        /// </description>
        public void RemoveItem(int pos) {
             InternalUnsafeMethods.RemoveItem__Args _args = new InternalUnsafeMethods.RemoveItem__Args() {
                pos = pos,
             };
             InternalUnsafeMethods.RemoveItem()(ObjectPtr, _args);
        }

        /// <description>
        /// (pos[, title][, accelerator][, cmd][, bitmapIndex])
        /// </description>
        public int InsertItem(int pos, string title = "", string accelerator = "", string cmd = "", int bitmapIndex = -1) {
             InternalUnsafeMethods.InsertItem__Args _args = new InternalUnsafeMethods.InsertItem__Args() {
                pos = pos,
                title = title,
                accelerator = accelerator,
                cmd = cmd,
                bitmapIndex = bitmapIndex,
             };
             int _engineResult = InternalUnsafeMethods.InsertItem()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the PopupMenu class.
        /// </description>
        /// <returns>The type info object for PopupMenu</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public string BarTitle {
            get => GenericMarshal.StringTo<string>(GetFieldValue("barTitle"));
            set => SetFieldValue("barTitle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool RadioSelection {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("radioSelection"));
            set => SetFieldValue("radioSelection", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool Visible {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("visible"));
            set => SetFieldValue("visible", GenericMarshal.ToString(value));
        }
    }
}
