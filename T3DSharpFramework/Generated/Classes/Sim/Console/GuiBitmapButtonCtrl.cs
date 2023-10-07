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
    /// <summary>A button that renders its various states (mouse over, pushed, etc.) from separate bitmaps.</summary>
    /// <description>
    /// A bitmapped button is a push button that uses one or more texture images for rendering its individual states.
    /// 
    /// To find the individual textures associated with the button, a naming scheme is used.  For each state a suffix is appended to the texture file name given in the GuiBitmapButtonCtrl::bitmap field:
    /// - "_n": Normal state.  This one will be active when no other state applies.
    /// - "_h": Highlighted state.  This applies when the mouse is hovering over the button.
    /// - "_d": Depressed state.  This applies when the left mouse button has been clicked on the button but not yet released.
    /// - "_i": Inactive state.  This applies when the button control has been deactivated (GuiControl::setActive())
    /// 
    /// If a bitmap for a particular state cannot be found, the default bitmap will be used.  To disable all state-based bitmap functionality, set useStates to false which will make the control solely render from the bitmap specified in the bitmap field.
    /// </description>
    /// <code>
    /// // Create an OK button that will trigger an onOk() call on its parent when clicked:
    /// %okButton = new GuiBitmapButtonCtrl()
    /// {
    ///    bitmap = "art/gui/okButton";
    ///    autoFitExtents = true;
    ///    command = "$ThisControl.getParent().onOk();";
    /// };
    /// </code>
    public class GuiBitmapButtonCtrl : GuiButtonCtrl {
        public GuiBitmapButtonCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiBitmapButtonCtrl(string pName, bool pRegister)
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

        public GuiBitmapButtonCtrl(string pName)
            : this(pName, false) {
        }

        public GuiBitmapButtonCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiBitmapButtonCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiBitmapButtonCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiBitmapButtonCtrl(IntPtr pObj)
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
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetBitmap(IntPtr _this, SetBitmap__Args args);
            private static _SetBitmap _SetBitmapFunc;
            internal static _SetBitmap SetBitmap() {
               _SetBitmapFunc ??= Torque3D.LookupEngineFunction<_SetBitmap>("fnGuiBitmapButtonCtrl_setBitmap");

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
               _GetBitmapAssetFunc ??= Torque3D.LookupEngineFunction<_GetBitmapAsset>("fnGuiBitmapButtonCtrl_getBitmapAsset");

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
               _GetBitmapFunc ??= Torque3D.LookupEngineFunction<_GetBitmap>("fnGuiBitmapButtonCtrl_getBitmap");

                return _GetBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnShiftClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnShiftClick(IntPtr _this, OnShiftClick__Args args);
            private static _OnShiftClick _OnShiftClickFunc;
            internal static _OnShiftClick OnShiftClick() {
               _OnShiftClickFunc ??= Torque3D.LookupEngineFunction<_OnShiftClick>("cbGuiBitmapButtonCtrl_onShiftClick");

                return _OnShiftClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAltClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAltClick(IntPtr _this, OnAltClick__Args args);
            private static _OnAltClick _OnAltClickFunc;
            internal static _OnAltClick OnAltClick() {
               _OnAltClickFunc ??= Torque3D.LookupEngineFunction<_OnAltClick>("cbGuiBitmapButtonCtrl_onAltClick");

                return _OnAltClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnCtrlClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnCtrlClick(IntPtr _this, OnCtrlClick__Args args);
            private static _OnCtrlClick _OnCtrlClickFunc;
            internal static _OnCtrlClick OnCtrlClick() {
               _OnCtrlClickFunc ??= Torque3D.LookupEngineFunction<_OnCtrlClick>("cbGuiBitmapButtonCtrl_onCtrlClick");

                return _OnCtrlClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDefaultClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDefaultClick(IntPtr _this, OnDefaultClick__Args args);
            private static _OnDefaultClick _OnDefaultClickFunc;
            internal static _OnDefaultClick OnDefaultClick() {
               _OnDefaultClickFunc ??= Torque3D.LookupEngineFunction<_OnDefaultClick>("cbGuiBitmapButtonCtrl_onDefaultClick");

                return _OnDefaultClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiBitmapButtonCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiBitmapButtonCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Bitmapassignment. first tries asset then flat file.
        /// </description>
        public bool SetBitmap(string assetName) {
             InternalUnsafeMethods.SetBitmap__Args _args = new InternalUnsafeMethods.SetBitmap__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetBitmap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Bitmapasset reference
        /// </description>
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
        /// Called when per-modifier functionality is enabled and the user clicks on the button with the SHIFT key pressed.
        /// </description>
        public virtual void OnShiftClick() {
             InternalUnsafeMethods.OnShiftClick__Args _args = new InternalUnsafeMethods.OnShiftClick__Args() {
             };
             InternalUnsafeMethods.OnShiftClick()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when per-modifier functionality is enabled and the user clicks on the button with the ALT key pressed.
        /// </description>
        public virtual void OnAltClick() {
             InternalUnsafeMethods.OnAltClick__Args _args = new InternalUnsafeMethods.OnAltClick__Args() {
             };
             InternalUnsafeMethods.OnAltClick()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when per-modifier functionality is enabled and the user clicks on the button with the CTRL key pressed.
        /// </description>
        public virtual void OnCtrlClick() {
             InternalUnsafeMethods.OnCtrlClick__Args _args = new InternalUnsafeMethods.OnCtrlClick__Args() {
             };
             InternalUnsafeMethods.OnCtrlClick()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when per-modifier functionality is enabled and the user clicks on the button without any modifier pressed.
        /// </description>
        public virtual void OnDefaultClick() {
             InternalUnsafeMethods.OnDefaultClick__Args _args = new InternalUnsafeMethods.OnDefaultClick__Args() {
             };
             InternalUnsafeMethods.OnDefaultClick()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiBitmapButtonCtrl class.
        /// </description>
        /// <returns>The type info object for GuiBitmapButtonCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Texture file to display on this button.
        /// If useStates is false, this will be the file that renders on the control.  Otherwise, this will specify the default texture name to which the various state and modifier suffixes are appended to find the per-state and per-modifier (if enabled) textures.
        /// </description>
        /// </value>
        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Bitmap"));
            set => SetFieldValue("Bitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Texture file to display on this button.
        /// If useStates is false, this will be the file that renders on the control.  Otherwise, this will specify the default texture name to which the various state and modifier suffixes are appended to find the per-state and per-modifier (if enabled) textures.
        /// </description>
        /// </value>
        public string BitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("BitmapAsset"));
            set => SetFieldValue("BitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// color mul
        /// </description>
        /// </value>
        public ColorI Color {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("color"));
            set => SetFieldValue("color", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Behavior for fitting the bitmap to the control extents.
        /// If set to 'Stretched', the bitmap will be stretched both verticall and horizontally to fit inside the control's extents.
        /// 
        /// If set to 'Centered', the bitmap will stay at its original resolution centered in the control's rectangle (getting clipped if the control is smaller than the texture).
        /// </description>
        /// </value>
        public GuiBitmapMode BitmapMode {
            get => GenericMarshal.StringTo<GuiBitmapMode>(GetFieldValue("bitmapMode"));
            set => SetFieldValue("bitmapMode", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, the control's extents will be set to match the bitmap's extents when setting the bitmap.
        /// The bitmap extents will always be taken from the default/normal bitmap (in case the extents of the various bitmaps do not match up.)
        /// </description>
        /// </value>
        public bool AutoFitExtents {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoFitExtents"));
            set => SetFieldValue("autoFitExtents", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, per-modifier button functionality is enabled.
        /// </description>
        /// </value>
        public bool UseModifiers {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useModifiers"));
            set => SetFieldValue("useModifiers", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, per-mouse state button functionality is enabled.
        /// Defaults to true.
        /// 
        /// If you do not use per-state images on this button set this to false to speed up the loading process by inhibiting searches for the individual images.
        /// </description>
        /// </value>
        public bool UseStates {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useStates"));
            set => SetFieldValue("useStates", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Use alpha masking for interaction.
        /// </description>
        /// </value>
        public bool Masked {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("masked"));
            set => SetFieldValue("masked", GenericMarshal.ToString(value));
        }
    }
}
