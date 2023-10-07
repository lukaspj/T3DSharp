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
    /// <summary>A control that allows to select a value from a drop-down list.</summary>
    /// <description>
    /// This is essentially a GuiPopUpMenuCtrl, but with quite a few more features.
    /// </description>
    /// <code>
    /// new GuiPopUpMenuCtrlEx()
    /// {
    ///   maxPopupHeight = "200";
    ///   sbUsesNAColor = "0";
    ///   reverseTextList = "0";
    ///   bitmapBounds = "16 16";
    ///   hotTrackCallback = "0";
    ///   extent = "64 64";
    ///   profile = "GuiDefaultProfile";
    ///   tooltipProfile = "GuiToolTipProfile";
    /// };
    /// </code>
    /// <see cref="GuiPopUpMenuCtrl" />
    public class GuiPopUpMenuCtrlEx : GuiTextCtrl {
        public GuiPopUpMenuCtrlEx(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiPopUpMenuCtrlEx(string pName, bool pRegister)
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

        public GuiPopUpMenuCtrlEx(string pName)
            : this(pName, false) {
        }

        public GuiPopUpMenuCtrlEx(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiPopUpMenuCtrlEx(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiPopUpMenuCtrlEx(SimObject pObj)
            : base(pObj) {
        }

        public GuiPopUpMenuCtrlEx(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearEntry__Args
            {
                internal int entry;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearEntry(IntPtr _this, ClearEntry__Args args);
            private static _ClearEntry _ClearEntryFunc;
            internal static _ClearEntry ClearEntry() {
               _ClearEntryFunc ??= Torque3D.LookupEngineFunction<_ClearEntry>("fnGuiPopUpMenuCtrlEx_clearEntry");

                return _ClearEntryFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ReplaceText__Args
            {
                internal int boolVal;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ReplaceText(IntPtr _this, ReplaceText__Args args);
            private static _ReplaceText _ReplaceTextFunc;
            internal static _ReplaceText ReplaceText() {
               _ReplaceTextFunc ??= Torque3D.LookupEngineFunction<_ReplaceText>("fnGuiPopUpMenuCtrlEx_replaceText");

                return _ReplaceTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Size__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _Size(IntPtr _this, Size__Args args);
            private static _Size _SizeFunc;
            internal static _Size Size() {
               _SizeFunc ??= Torque3D.LookupEngineFunction<_Size>("fnGuiPopUpMenuCtrlEx_size");

                return _SizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FindText__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _FindText(IntPtr _this, FindText__Args args);
            private static _FindText _FindTextFunc;
            internal static _FindText FindText() {
               _FindTextFunc ??= Torque3D.LookupEngineFunction<_FindText>("fnGuiPopUpMenuCtrlEx_findText");

                return _FindTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetEnumContent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string className;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string enumName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetEnumContent(IntPtr _this, SetEnumContent__Args args);
            private static _SetEnumContent _SetEnumContentFunc;
            internal static _SetEnumContent SetEnumContent() {
               _SetEnumContentFunc ??= Torque3D.LookupEngineFunction<_SetEnumContent>("fnGuiPopUpMenuCtrlEx_setEnumContent");

                return _SetEnumContentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetColorById__Args
            {
                internal int id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate ColorI.InternalStruct _GetColorById(IntPtr _this, GetColorById__Args args);
            private static _GetColorById _GetColorByIdFunc;
            internal static _GetColorById GetColorById() {
               _GetColorByIdFunc ??= Torque3D.LookupEngineFunction<_GetColorById>("fnGuiPopUpMenuCtrlEx_getColorById");

                return _GetColorByIdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTextById__Args
            {
                internal int id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTextById(IntPtr _this, GetTextById__Args args);
            private static _GetTextById _GetTextByIdFunc;
            internal static _GetTextById GetTextById() {
               _GetTextByIdFunc ??= Torque3D.LookupEngineFunction<_GetTextById>("fnGuiPopUpMenuCtrlEx_getTextById");

                return _GetTextByIdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNoneSelected__Args
            {
                internal int param;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetNoneSelected(IntPtr _this, SetNoneSelected__Args args);
            private static _SetNoneSelected _SetNoneSelectedFunc;
            internal static _SetNoneSelected SetNoneSelected() {
               _SetNoneSelectedFunc ??= Torque3D.LookupEngineFunction<_SetNoneSelected>("fnGuiPopUpMenuCtrlEx_setNoneSelected");

                return _SetNoneSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetFirstSelected__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool scriptCallback;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetFirstSelected(IntPtr _this, SetFirstSelected__Args args);
            private static _SetFirstSelected _SetFirstSelectedFunc;
            internal static _SetFirstSelected SetFirstSelected() {
               _SetFirstSelectedFunc ??= Torque3D.LookupEngineFunction<_SetFirstSelected>("fnGuiPopUpMenuCtrlEx_setFirstSelected");

                return _SetFirstSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelected__Args
            {
                internal int id;
                [MarshalAs(UnmanagedType.I1)]
                internal bool scriptCallback;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelected(IntPtr _this, SetSelected__Args args);
            private static _SetSelected _SetSelectedFunc;
            internal static _SetSelected SetSelected() {
               _SetSelectedFunc ??= Torque3D.LookupEngineFunction<_SetSelected>("fnGuiPopUpMenuCtrlEx_setSelected");

                return _SetSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelected__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelected(IntPtr _this, GetSelected__Args args);
            private static _GetSelected _GetSelectedFunc;
            internal static _GetSelected GetSelected() {
               _GetSelectedFunc ??= Torque3D.LookupEngineFunction<_GetSelected>("fnGuiPopUpMenuCtrlEx_getSelected");

                return _GetSelectedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ForceClose__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ForceClose(IntPtr _this, ForceClose__Args args);
            private static _ForceClose _ForceCloseFunc;
            internal static _ForceClose ForceClose() {
               _ForceCloseFunc ??= Torque3D.LookupEngineFunction<_ForceClose>("fnGuiPopUpMenuCtrlEx_forceClose");

                return _ForceCloseFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ForceOnAction__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ForceOnAction(IntPtr _this, ForceOnAction__Args args);
            private static _ForceOnAction _ForceOnActionFunc;
            internal static _ForceOnAction ForceOnAction() {
               _ForceOnActionFunc ??= Torque3D.LookupEngineFunction<_ForceOnAction>("fnGuiPopUpMenuCtrlEx_forceOnAction");

                return _ForceOnActionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SortID__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SortID(IntPtr _this, SortID__Args args);
            private static _SortID _SortIDFunc;
            internal static _SortID SortID() {
               _SortIDFunc ??= Torque3D.LookupEngineFunction<_SortID>("fnGuiPopUpMenuCtrlEx_sortID");

                return _SortIDFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sort__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sort(IntPtr _this, Sort__Args args);
            private static _Sort _SortFunc;
            internal static _Sort Sort() {
               _SortFunc ??= Torque3D.LookupEngineFunction<_Sort>("fnGuiPopUpMenuCtrlEx_sort");

                return _SortFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Clear__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Clear(IntPtr _this, Clear__Args args);
            private static _Clear _ClearFunc;
            internal static _Clear Clear() {
               _ClearFunc ??= Torque3D.LookupEngineFunction<_Clear>("fnGuiPopUpMenuCtrlEx_clear");

                return _ClearFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetText(IntPtr _this, GetText__Args args);
            private static _GetText _GetTextFunc;
            internal static _GetText GetText() {
               _GetTextFunc ??= Torque3D.LookupEngineFunction<_GetText>("fnGuiPopUpMenuCtrlEx_getText");

                return _GetTextFunc;
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
               _SetTextFunc ??= Torque3D.LookupEngineFunction<_SetText>("fnGuiPopUpMenuCtrlEx_setText");

                return _SetTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddScheme__Args
            {
                internal int id;
                internal IntPtr fontColor;
                internal IntPtr fontColorHL;
                internal IntPtr fontColorSEL;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddScheme(IntPtr _this, AddScheme__Args args);
            private static _AddScheme _AddSchemeFunc;
            internal static _AddScheme AddScheme() {
               _AddSchemeFunc ??= Torque3D.LookupEngineFunction<_AddScheme>("fnGuiPopUpMenuCtrlEx_addScheme");

                return _AddSchemeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddCategory__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddCategory(IntPtr _this, AddCategory__Args args);
            private static _AddCategory _AddCategoryFunc;
            internal static _AddCategory AddCategory() {
               _AddCategoryFunc ??= Torque3D.LookupEngineFunction<_AddCategory>("fnGuiPopUpMenuCtrlEx_addCategory");

                return _AddCategoryFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Add__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
                internal int idNum;
                internal uint scheme;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Add(IntPtr _this, Add__Args args);
            private static _Add _AddFunc;
            internal static _Add Add() {
               _AddFunc ??= Torque3D.LookupEngineFunction<_Add>("fnGuiPopUpMenuCtrlEx_add");

                return _AddFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiPopUpMenuCtrlEx_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiPopUpMenuCtrlEx_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// (S32 entry)
        /// </description>
        public void ClearEntry(int entry) {
             InternalUnsafeMethods.ClearEntry__Args _args = new InternalUnsafeMethods.ClearEntry__Args() {
                entry = entry,
             };
             InternalUnsafeMethods.ClearEntry()(ObjectPtr, _args);
        }

        /// <summary>Flag that causes each new text addition to replace the current entry</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="True">to turn on replacing, false to disable it</param>
        public void ReplaceText(int boolVal) {
             InternalUnsafeMethods.ReplaceText__Args _args = new InternalUnsafeMethods.ReplaceText__Args() {
                boolVal = boolVal,
             };
             InternalUnsafeMethods.ReplaceText()(ObjectPtr, _args);
        }

        /// <summary>Get the size of the menu</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>Number of entries in the menu</returns>
        public int Size() {
             InternalUnsafeMethods.Size__Args _args = new InternalUnsafeMethods.Size__Args() {
             };
             int _engineResult = InternalUnsafeMethods.Size()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (string text)Returns the id of the first entry containing the specified text or -1 if not found.
        /// </description>
        /// <param name="text">String value used for the query</param>
        /// <returns>Numerical ID of entry containing the text.</returns>
        public int FindText(string text) {
             InternalUnsafeMethods.FindText__Args _args = new InternalUnsafeMethods.FindText__Args() {
                text = text,
             };
             int _engineResult = InternalUnsafeMethods.FindText()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>This fills the popup with a classrep's field enumeration type info.</summary>
        /// <description>
        /// More of a helper function than anything.   If console access to the field list is added, at least for the enumerated types, then this should go away.
        /// </description>
        /// <param name="class">Name of the class containing the enum</param>
        /// <param name="enum">Name of the enum value to acces</param>
        public void SetEnumContent(string className, string enumName) {
             InternalUnsafeMethods.SetEnumContent__Args _args = new InternalUnsafeMethods.SetEnumContent__Args() {
                className = className,
                enumName = enumName,
             };
             InternalUnsafeMethods.SetEnumContent()(ObjectPtr, _args);
        }

        /// <summary>Get color of an entry's box</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="id">ID number of entry to query</param>
        /// <returns>ColorI in the format of "Red Green Blue Alpha", each of with is a value between 0 - 255</returns>
        public ColorI GetColorById(int id) {
             InternalUnsafeMethods.GetColorById__Args _args = new InternalUnsafeMethods.GetColorById__Args() {
                id = id,
             };
             ColorI.InternalStruct _engineResult = InternalUnsafeMethods.GetColorById()(ObjectPtr, _args);
             return new ColorI(_engineResult);
        }

        /// <summary>Get the text of an entry based on an ID.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="id">The ID assigned to the entry being queried</param>
        /// <returns>String contained by the specified entry, NULL if empty or bad ID</returns>
        public string GetTextById(int id) {
             InternalUnsafeMethods.GetTextById__Args _args = new InternalUnsafeMethods.GetTextById__Args() {
                id = id,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTextById()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Clears selection in the menu.</summary>
        /// <description>
        /// 
        /// </description>
        public void SetNoneSelected(int param) {
             InternalUnsafeMethods.SetNoneSelected__Args _args = new InternalUnsafeMethods.SetNoneSelected__Args() {
                param = param,
             };
             InternalUnsafeMethods.SetNoneSelected()(ObjectPtr, _args);
        }

        /// <description>
        /// ([scriptCallback=true])
        /// </description>
        public void SetFirstSelected(bool scriptCallback = true) {
             InternalUnsafeMethods.SetFirstSelected__Args _args = new InternalUnsafeMethods.SetFirstSelected__Args() {
                scriptCallback = scriptCallback,
             };
             InternalUnsafeMethods.SetFirstSelected()(ObjectPtr, _args);
        }

        /// <description>
        /// (int id, [scriptCallback=true])
        /// </description>
        public void SetSelected(int id, bool scriptCallback = true) {
             InternalUnsafeMethods.SetSelected__Args _args = new InternalUnsafeMethods.SetSelected__Args() {
                id = id,
                scriptCallback = scriptCallback,
             };
             InternalUnsafeMethods.SetSelected()(ObjectPtr, _args);
        }

        /// <summary>Get the current selection of the menu.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>Returns the ID of the currently selected entry</returns>
        public int GetSelected() {
             InternalUnsafeMethods.GetSelected__Args _args = new InternalUnsafeMethods.GetSelected__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelected()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Manually force this control to collapse and close.</summary>
        /// <description>
        /// 
        /// </description>
        public void ForceClose() {
             InternalUnsafeMethods.ForceClose__Args _args = new InternalUnsafeMethods.ForceClose__Args() {
             };
             InternalUnsafeMethods.ForceClose()(ObjectPtr, _args);
        }

        /// <summary>Manually for the onAction function, which updates everything in this control.</summary>
        /// <description>
        /// 
        /// </description>
        public void ForceOnAction() {
             InternalUnsafeMethods.ForceOnAction__Args _args = new InternalUnsafeMethods.ForceOnAction__Args() {
             };
             InternalUnsafeMethods.ForceOnAction()(ObjectPtr, _args);
        }

        /// <summary>Sort the list by ID.</summary>
        /// <description>
        /// 
        /// </description>
        public void SortID() {
             InternalUnsafeMethods.SortID__Args _args = new InternalUnsafeMethods.SortID__Args() {
             };
             InternalUnsafeMethods.SortID()(ObjectPtr, _args);
        }

        /// <summary>Sort the list alphabetically.</summary>
        /// <description>
        /// 
        /// </description>
        public void Sort() {
             InternalUnsafeMethods.Sort__Args _args = new InternalUnsafeMethods.Sort__Args() {
             };
             InternalUnsafeMethods.Sort()(ObjectPtr, _args);
        }

        /// <summary>Clear the popup list.</summary>
        /// <description>
        /// 
        /// </description>
        public void Clear() {
             InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
             };
             InternalUnsafeMethods.Clear()(ObjectPtr, _args);
        }

        /// <summary>Get the.</summary>
        /// <description>
        /// Detailed description
        /// </description>
        /// <param name="param">Description</param>
        /// <code>
        /// // Comment
        /// code();
        /// </code>
        /// <returns>Returns current text in string format</returns>
        public string GetText() {
             InternalUnsafeMethods.GetText__Args _args = new InternalUnsafeMethods.GetText__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetText()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Set the current text to a specified value.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="text">String containing new text to set</param>
        public void SetText(string text) {
             InternalUnsafeMethods.SetText__Args _args = new InternalUnsafeMethods.SetText__Args() {
                text = text,
             };
             InternalUnsafeMethods.SetText()(ObjectPtr, _args);
        }

        /// <summary>Create a new scheme and add it to the list of choices for when a new text entry is added.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="id">Numerical id associated with this scheme</param>
        /// <param name="fontColor">The base text font color. Formatted as "Red Green Blue", each a numerical between 0 and 255.</param>
        /// <param name="fontColorHL">Color of text when being highlighted. Formatted as "Red Green Blue", each a numerical between 0 and 255.</param>
        /// <param name="fontColorSel">Color of text when being selected. Formatted as "Red Green Blue", each a numerical between 0 and 255.</param>
        public void AddScheme(int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL) {
fontColor.Alloc();fontColorHL.Alloc();fontColorSEL.Alloc();             InternalUnsafeMethods.AddScheme__Args _args = new InternalUnsafeMethods.AddScheme__Args() {
                id = id,
                fontColor = fontColor.internalStructPtr,
                fontColorHL = fontColorHL.internalStructPtr,
                fontColorSEL = fontColorSEL.internalStructPtr,
             };
             InternalUnsafeMethods.AddScheme()(ObjectPtr, _args);
fontColor.Free();fontColorHL.Free();fontColorSEL.Free();        }

        /// <summary>Add a category to the list.</summary>
        /// <description>
        /// Acts as a separator between entries, allowing for sub-lists
        /// </description>
        /// <param name="text">Name of the new category</param>
        public void AddCategory(string text) {
             InternalUnsafeMethods.AddCategory__Args _args = new InternalUnsafeMethods.AddCategory__Args() {
                text = text,
             };
             InternalUnsafeMethods.AddCategory()(ObjectPtr, _args);
        }

        /// <description>
        /// (string name, int idNum, int scheme=0)
        /// </description>
        public void Add(string name = "", int idNum = -1, uint scheme = 0) {
             InternalUnsafeMethods.Add__Args _args = new InternalUnsafeMethods.Add__Args() {
                name = name,
                idNum = idNum,
                scheme = scheme,
             };
             InternalUnsafeMethods.Add()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiPopUpMenuCtrlEx class.
        /// </description>
        /// <returns>The type info object for GuiPopUpMenuCtrlEx</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Length of menu when it extends
        /// </description>
        /// </value>
        public int MaxPopupHeight {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxPopupHeight"));
            set => SetFieldValue("maxPopupHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Deprecated
        /// </description>
        /// </value>
        public bool SbUsesNAColor {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sbUsesNAColor"));
            set => SetFieldValue("sbUsesNAColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Reverses text list if popup extends up, instead of down
        /// </description>
        /// </value>
        public bool ReverseTextList {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("reverseTextList"));
            set => SetFieldValue("reverseTextList", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// File name of bitmap to use
        /// </description>
        /// </value>
        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Bitmap"));
            set => SetFieldValue("Bitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Name of bitmap asset to use
        /// </description>
        /// </value>
        public string BitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("BitmapAsset"));
            set => SetFieldValue("BitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Boundaries of bitmap displayed
        /// </description>
        /// </value>
        public Point2I BitmapBounds {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("bitmapBounds"));
            set => SetFieldValue("bitmapBounds", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to provide a 'onHotTrackItem' callback when a list item is hovered over
        /// </description>
        /// </value>
        public bool HotTrackCallback {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hotTrackCallback"));
            set => SetFieldValue("hotTrackCallback", GenericMarshal.ToString(value));
        }
    }
}
