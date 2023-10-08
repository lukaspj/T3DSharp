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
    /// <summary>This is a control that will render a specified bitmap or a bitmap specified in a referenced variable.</summary>
    /// <description>
    /// This control allows you to either set a bitmap with the "bitmap" field or with the setBitmap method.  You can also choose to reference a variable in the "variable" field such as "$image" and then set "useVariable" to true.  This will cause it to synchronize the variable with the bitmap displayed (if the variable holds a valid image).  You can then change the variable and effectively changed the displayed image.
    /// </description>
    /// <code>
    /// $image = "anotherbackground.png";
    /// new GuiChunkedBitmapCtrl(ChunkedBitmap)
    /// {
    ///    bitmap = "background.png";
    ///    variable = "$image";
    ///    useVariable = false;
    /// }
    /// 
    /// // This will result in the control rendering "background.png"
    /// // If we now set the useVariable to true it will now render "anotherbackground.png"
    /// ChunkedBitmap.useVariable = true;
    /// </code>
    /// <see cref="GuiControl::variable" />
    public class GuiChunkedBitmapCtrl : GuiControl {
        public GuiChunkedBitmapCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiChunkedBitmapCtrl(string pName, bool pRegister)
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

        public GuiChunkedBitmapCtrl(string pName)
            : this(pName, false) {
        }

        public GuiChunkedBitmapCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiChunkedBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiChunkedBitmapCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiChunkedBitmapCtrl(IntPtr pObj)
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
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBitmap(IntPtr _this, SetBitmap__Args args);
            private static _SetBitmap _SetBitmapFunc;
            internal static _SetBitmap SetBitmap() {
               _SetBitmapFunc ??= Torque3D.LookupEngineFunction<_SetBitmap>("fnGuiChunkedBitmapCtrl_setBitmap");

                return _SetBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiChunkedBitmapCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiChunkedBitmapCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Set the image rendered in this control.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="filename">The image name you want to set</param>
        public void SetBitmap(string filename) {
             InternalUnsafeMethods.SetBitmap__Args _args = new InternalUnsafeMethods.SetBitmap__Args() {
                filename = filename,
             };
             InternalUnsafeMethods.SetBitmap()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiChunkedBitmapCtrl class.
        /// </description>
        /// <returns>The type info object for GuiChunkedBitmapCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Bitmap "This is the bitmap to render to the control."</summary>
        /// </value>
        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Bitmap"));
            set => SetFieldValue("Bitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Bitmap asset "This is the bitmap to render to the control.".</summary>
        /// </value>
        public string BitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("BitmapAsset"));
            set => SetFieldValue("BitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// This decides whether to use the "bitmap" file or a bitmap stored in "variable"
        /// </description>
        /// </value>
        public bool UseVariable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useVariable"));
            set => SetFieldValue("useVariable", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// This is no longer in use
        /// </description>
        /// </value>
        public bool Tile {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("tile"));
            set => SetFieldValue("tile", GenericMarshal.ToString(value));
        }
    }
}
