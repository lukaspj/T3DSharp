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
    /// <summary>GUI Control which displays a numerical value which can be increased or decreased using a pair of bitmap up/down buttons.</summary>
    /// <description>
    /// This control uses the bitmap specified in it's profile (GuiControlProfile::bitmapName). It takes this image and breaks up aspects of it to render the up and down arrows. It is also important to set GuiControlProfile::hasBitmapArray to true on the profile as well.
    /// 
    /// The bitmap referenced should be broken up into a 1 x 4 grid (using the top left color pixel as a border color between each of the images) in which it will map to the following places:
    /// <ol>
    /// <li>Up arrow active</li>
    /// <li>Up arrow inactive</li>
    /// <li>Down arrow active</li>
    /// <li>Down arrow inactive</li>
    /// </ol>
    /// 
    /// <pre>
    /// 1
    /// 2
    /// 3
    /// 4</pre>
    /// </description>
    /// <code>
    /// singleton GuiControlProfile (SliderBitmapGUIProfile)
    /// {
    ///    bitmap = "core/art/gui/images/sliderArray";
    ///    hasBitmapArray = true;
    ///    opaque = false;
    /// };
    /// 
    /// new GuiTextEditSliderBitmapCtrl()
    /// {
    ///    profile = "SliderBitmapGUIProfile";
    ///    format = "%3.2f";
    ///    range = "-1e+03 1e+03";
    ///    increment = "0.1";
    ///    focusOnMouseWheel = "0";
    ///    bitmap = "";
    ///    //Properties not specific to this control have been omitted from this example.
    /// };
    /// </code>
    /// <see cref="GuiTextEditSliderCtrl" />
    /// <see cref="GuiTextEditCtrl" />
    public class GuiTextEditSliderBitmapCtrl : GuiTextEditCtrl {
        public GuiTextEditSliderBitmapCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiTextEditSliderBitmapCtrl(string pName, bool pRegister)
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

        public GuiTextEditSliderBitmapCtrl(string pName)
            : this(pName, false) {
        }

        public GuiTextEditSliderBitmapCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiTextEditSliderBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiTextEditSliderBitmapCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiTextEditSliderBitmapCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiTextEditSliderBitmapCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiTextEditSliderBitmapCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiTextEditSliderBitmapCtrl class.
        /// </description>
        /// <returns>The type info object for GuiTextEditSliderBitmapCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Character format type to place in the control.
        /// </description>
        /// </value>
        public string Format {
            get => GenericMarshal.StringTo<string>(GetFieldValue("format"));
            set => SetFieldValue("format", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Maximum vertical and horizontal range to allow in the control.
        /// </description>
        /// </value>
        public Point2F Range {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("range"));
            set => SetFieldValue("range", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// How far to increment the slider on each step.
        /// </description>
        /// </value>
        public float Increment {
            get => GenericMarshal.StringTo<float>(GetFieldValue("increment"));
            set => SetFieldValue("increment", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, the control will accept giving focus to the user when the mouse wheel is used.
        /// </description>
        /// </value>
        public bool FocusOnMouseWheel {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("focusOnMouseWheel"));
            set => SetFieldValue("focusOnMouseWheel", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Unused
        /// </description>
        /// </value>
        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Bitmap"));
            set => SetFieldValue("Bitmap", GenericMarshal.ToString(value));
        }
    }
}
