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
    /// <summary>A collection of properties that determine control behavior and rendering.</summary>
    /// <description>
    /// 
    /// </description>
    public class GuiControlProfile : SimObject {
        public GuiControlProfile(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiControlProfile(string pName, bool pRegister)
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

        public GuiControlProfile(string pName)
            : this(pName, false) {
        }

        public GuiControlProfile(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiControlProfile(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiControlProfile(SimObject pObj)
            : base(pObj) {
        }

        public GuiControlProfile(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBitmap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetBitmap(IntPtr _this, SetBitmap__Args args);
            private static _SetBitmap _SetBitmapFunc;
            internal static _SetBitmap SetBitmap() {
               _SetBitmapFunc ??= Torque3D.LookupEngineFunction<_SetBitmap>("fnGuiControlProfile_setBitmap");

                return _SetBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBitmapAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetBitmapAsset(IntPtr _this, GetBitmapAsset__Args args);
            private static _GetBitmapAsset _GetBitmapAssetFunc;
            internal static _GetBitmapAsset GetBitmapAsset() {
               _GetBitmapAssetFunc ??= Torque3D.LookupEngineFunction<_GetBitmapAsset>("fnGuiControlProfile_getBitmapAsset");

                return _GetBitmapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBitmap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetBitmap(IntPtr _this, GetBitmap__Args args);
            private static _GetBitmap _GetBitmapFunc;
            internal static _GetBitmap GetBitmap() {
               _GetBitmapFunc ??= Torque3D.LookupEngineFunction<_GetBitmap>("fnGuiControlProfile_getBitmap");

                return _GetBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetStringWidth__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string _string;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetStringWidth(IntPtr _this, GetStringWidth__Args args);
            private static _GetStringWidth _GetStringWidthFunc;
            internal static _GetStringWidth GetStringWidth() {
               _GetStringWidthFunc ??= Torque3D.LookupEngineFunction<_GetStringWidth>("fnGuiControlProfile_getStringWidth");

                return _GetStringWidthFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiControlProfile_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiControlProfile_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public bool SetBitmap(string map) {
             InternalUnsafeMethods.SetBitmap__Args _args = new InternalUnsafeMethods.SetBitmap__Args() {
                map = map,
             };
             bool _engineResult = InternalUnsafeMethods.SetBitmap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// 
        public string GetBitmapAsset() {
             InternalUnsafeMethods.GetBitmapAsset__Args _args = new InternalUnsafeMethods.GetBitmapAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetBitmapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetBitmap() {
             InternalUnsafeMethods.GetBitmap__Args _args = new InternalUnsafeMethods.GetBitmap__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetBitmap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the width of the string in pixels.
        /// </description>
        /// <param name="string">String to get the width of.</param>
        /// <returns>width of the string in pixels.</returns>
        public int GetStringWidth(string _string) {
             InternalUnsafeMethods.GetStringWidth__Args _args = new InternalUnsafeMethods.GetStringWidth__Args() {
                _string = _string,
             };
             int _engineResult = InternalUnsafeMethods.GetStringWidth()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the GuiControlProfile class.
        /// </description>
        /// <returns>The type info object for GuiControlProfile</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public bool Tab {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("tab"));
            set => SetFieldValue("tab", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the control can have the keyboard focus.
        /// </description>
        /// </value>
        public bool CanKeyFocus {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("canKeyFocus"));
            set => SetFieldValue("canKeyFocus", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool MouseOverSelected {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("mouseOverSelected"));
            set => SetFieldValue("mouseOverSelected", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool Modal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("modal"));
            set => SetFieldValue("modal", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool Opaque {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("opaque"));
            set => SetFieldValue("opaque", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI FillColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColor"));
            set => SetFieldValue("fillColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI FillColorHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColorHL"));
            set => SetFieldValue("fillColorHL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI FillColorNA {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColorNA"));
            set => SetFieldValue("fillColorNA", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI FillColorERR {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColorERR"));
            set => SetFieldValue("fillColorERR", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI FillColorSEL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fillColorSEL"));
            set => SetFieldValue("fillColorSEL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Border type (0=no border).
        /// </description>
        /// </value>
        public int Border {
            get => GenericMarshal.StringTo<int>(GetFieldValue("border"));
            set => SetFieldValue("border", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Thickness of border in pixels.
        /// </description>
        /// </value>
        public int BorderThickness {
            get => GenericMarshal.StringTo<int>(GetFieldValue("borderThickness"));
            set => SetFieldValue("borderThickness", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Color to draw border with.
        /// </description>
        /// </value>
        public ColorI BorderColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColor"));
            set => SetFieldValue("borderColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Color to draw border with if highlighted.
        /// </description>
        /// </value>
        public ColorI BorderColorHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColorHL"));
            set => SetFieldValue("borderColorHL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Color to draw border if disabled.
        /// </description>
        /// </value>
        public ColorI BorderColorNA {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColorNA"));
            set => SetFieldValue("borderColorNA", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Color to draw border with if selected.
        /// </description>
        /// </value>
        public ColorI BorderColorSEL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColorSEL"));
            set => SetFieldValue("borderColorSEL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Color to draw border with if erroring.
        /// </description>
        /// </value>
        public ColorI BorderColorERR {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColorERR"));
            set => SetFieldValue("borderColorERR", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI BevelColorHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("bevelColorHL"));
            set => SetFieldValue("bevelColorHL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI BevelColorLL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("bevelColorLL"));
            set => SetFieldValue("bevelColorLL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Name of font family and typeface (e.g. "Arial Bold").
        /// </description>
        /// </value>
        public string FontType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fontType"));
            set => SetFieldValue("fontType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Font size in points.
        /// </description>
        /// </value>
        public int FontSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fontSize"));
            set => SetFieldValue("fontSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public GuiFontCharset FontCharset {
            get => GenericMarshal.StringTo<GuiFontCharset>(GetFieldValue("fontCharset"));
            set => SetFieldValue("fontCharset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Font colors to use for different text types/states.
        /// </description>
        /// </value>
        public DynamicFieldVector<ColorI> FontColors {
            get => new DynamicFieldVector<ColorI>(
                    this, 
                    "fontColors", 
                    11, 
                    val => GenericMarshal.StringTo<ColorI>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Font color for normal text (same as fontColors[0]).
        /// </description>
        /// </value>
        public ColorI FontColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColor"));
            set => SetFieldValue("fontColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Font color for highlighted text (same as fontColors[1]).
        /// </description>
        /// </value>
        public ColorI FontColorHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorHL"));
            set => SetFieldValue("fontColorHL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Font color when control is not active/disabled (same as fontColors[2]).
        /// </description>
        /// </value>
        public ColorI FontColorNA {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorNA"));
            set => SetFieldValue("fontColorNA", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Font color for selected text (same as fontColors[3]).
        /// </description>
        /// </value>
        public ColorI FontColorSEL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorSEL"));
            set => SetFieldValue("fontColorSEL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Font color for links in text (same as fontColors[4]).
        /// </description>
        /// </value>
        public ColorI FontColorLink {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorLink"));
            set => SetFieldValue("fontColorLink", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Font color for highlighted links in text (same as fontColors[5]).
        /// </description>
        /// </value>
        public ColorI FontColorLinkHL {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorLinkHL"));
            set => SetFieldValue("fontColorLinkHL", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Font color for links in text (same as fontColors[10]).
        /// </description>
        /// </value>
        public ColorI FontColorERR {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("fontColorERR"));
            set => SetFieldValue("fontColorERR", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Horizontal alignment for text.
        /// </description>
        /// </value>
        public GuiAlignmentType Justify {
            get => GenericMarshal.StringTo<GuiAlignmentType>(GetFieldValue("justify"));
            set => SetFieldValue("justify", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public Point2I TextOffset {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("textOffset"));
            set => SetFieldValue("textOffset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Automatically adjust width of control to fit contents.
        /// </description>
        /// </value>
        public bool AutoSizeWidth {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoSizeWidth"));
            set => SetFieldValue("autoSizeWidth", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Automatically adjust height of control to fit contents.
        /// </description>
        /// </value>
        public bool AutoSizeHeight {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoSizeHeight"));
            set => SetFieldValue("autoSizeHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to add automatic tab event when return is pressed so focus moves on to next control (GuiTextEditCtrl).
        /// </description>
        /// </value>
        public bool ReturnTab {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("returnTab"));
            set => SetFieldValue("returnTab", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether control should only accept numerical data (GuiTextEditCtrl).
        /// </description>
        /// </value>
        public bool NumbersOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("numbersOnly"));
            set => SetFieldValue("numbersOnly", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Color to use for the text cursor.
        /// </description>
        /// </value>
        public ColorI CursorColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("cursorColor"));
            set => SetFieldValue("cursorColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Texture to use for rendering control.
        /// </description>
        /// </value>
        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Bitmap"));
            set => SetFieldValue("Bitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Texture to use for rendering control.
        /// </description>
        /// </value>
        public string BitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("BitmapAsset"));
            set => SetFieldValue("BitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, 'bitmap' is an array of images.
        /// </description>
        /// </value>
        public bool HasBitmapArray {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hasBitmapArray"));
            set => SetFieldValue("hasBitmapArray", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// SoundButtonDown"The sound button down."
        /// </description>
        /// </value>
        public string SoundButtonDownFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SoundButtonDownFile"));
            set => SetFieldValue("SoundButtonDownFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// SoundButtonDownasset reference.
        /// </description>
        /// </value>
        public string SoundButtonDownAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SoundButtonDownAsset"));
            set => SetFieldValue("SoundButtonDownAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// SoundButtonOver"The sound button down."
        /// </description>
        /// </value>
        public string SoundButtonOverFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SoundButtonOverFile"));
            set => SetFieldValue("SoundButtonOverFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// SoundButtonOverasset reference.
        /// </description>
        /// </value>
        public string SoundButtonOverAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SoundButtonOverAsset"));
            set => SetFieldValue("SoundButtonOverAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string ProfileForChildren {
            get => GenericMarshal.StringTo<string>(GetFieldValue("profileForChildren"));
            set => SetFieldValue("profileForChildren", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Category under which the profile will appear in the editor.
        /// </description>
        /// </value>
        public string Category {
            get => GenericMarshal.StringTo<string>(GetFieldValue("category"));
            set => SetFieldValue("category", GenericMarshal.ToString(value));
        }
    }
}
