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
    /// <summary>GUI control object this displays a single line of text, without TorqueML.</summary>
    /// <description>
    /// 
    /// </description>
    /// <code>
    /// new GuiTextCtrl()
    ///   {
    ///      text = "Hello World";
    ///      textID = ""STR_HELLO"";
    ///      maxlength = "1024";
    ///       //Properties not specific to this control have been omitted from this example.
    ///   };
    /// </code>
    /// <see cref="GuiControl" />
    /// <see cref="Localization" />
    public class GuiTextCtrl : GuiContainer {
        public GuiTextCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiTextCtrl(string pName, bool pRegister)
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

        public GuiTextCtrl(string pName)
            : this(pName, false) {
        }

        public GuiTextCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiTextCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiTextCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiTextCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTextID__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string textID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTextID(IntPtr _this, SetTextID__Args args);
            private static _SetTextID _SetTextIDFunc;
            internal static _SetTextID SetTextID() {
               _SetTextIDFunc ??= Torque3D.LookupEngineFunction<_SetTextID>("fnGuiTextCtrl_setTextID");

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
               _SetTextFunc ??= Torque3D.LookupEngineFunction<_SetText>("fnGuiTextCtrl_setText");

                return _SetTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiTextCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiTextCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Maps the text ctrl to a variable used in localization, rather than raw text.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="textID">Name of variable text should be mapped to</param>
        /// <code>
        /// // Inform the GuiTextCtrl control of the textID to use
        /// %thisGuiTextCtrl.setTextID("STR_QUIT");
        /// </code>
        /// <see cref="GuiControl" />
        /// <see cref="Localization" />
        public void SetTextID(string textID) {
             InternalUnsafeMethods.SetTextID__Args _args = new InternalUnsafeMethods.SetTextID__Args() {
                textID = textID,
             };
             InternalUnsafeMethods.SetTextID()(ObjectPtr, _args);
        }

        /// <summary>Sets the text in the control.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="text">Text to display in the control.</param>
        /// <code>
        /// // Set the text to show in the control
        /// %text = "Gideon - Destroyer of World";
        /// 
        /// // Inform the GuiTextCtrl control to change its text to the defined value
        /// %thisGuiTextCtrl.setText(%text);
        /// </code>
        /// <see cref="GuiControl" />
        public void SetText(string text) {
             InternalUnsafeMethods.SetText__Args _args = new InternalUnsafeMethods.SetText__Args() {
                text = text,
             };
             InternalUnsafeMethods.SetText()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiTextCtrl class.
        /// </description>
        /// <returns>The type info object for GuiTextCtrl</returns>
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
        public string Text {
            get => GenericMarshal.StringTo<string>(GetFieldValue("text"));
            set => SetFieldValue("text", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Maps the text of this control to a variable used in localization, rather than raw text.
        /// </description>
        /// </value>
        public string TextID {
            get => GenericMarshal.StringTo<string>(GetFieldValue("textID"));
            set => SetFieldValue("textID", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Defines the maximum length of the text.  The default is 1024.
        /// </description>
        /// </value>
        public int MaxLength {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxLength"));
            set => SetFieldValue("maxLength", GenericMarshal.ToString(value));
        }
    }
}
