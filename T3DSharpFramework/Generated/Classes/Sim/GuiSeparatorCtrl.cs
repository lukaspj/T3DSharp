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
    /// <summary>A control that renders a horizontal or vertical separator with an optional text label (horizontal only)</summary>
    /// <description>
    /// 
    /// </description>
    /// <code>
    /// new GuiSeparatorCtrl()
    /// {
    ///    profile = "GuiDefaultProfile";
    ///    position = "505 0";
    ///    extent = "10 17";
    ///    minExtent = "10 17";
    ///    canSave = "1";
    ///    visible = "1";
    ///    horizSizing = "left";
    /// };
    /// </code>
    public class GuiSeparatorCtrl : GuiControl {
        public GuiSeparatorCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiSeparatorCtrl(string pName, bool pRegister)
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

        public GuiSeparatorCtrl(string pName)
            : this(pName, false) {
        }

        public GuiSeparatorCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiSeparatorCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiSeparatorCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiSeparatorCtrl(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiSeparatorCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiSeparatorCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiSeparatorCtrl class.
        /// </description>
        /// <returns>The type info object for GuiSeparatorCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Optional text label to display.
        /// </description>
        /// </value>
        public string Caption {
            get => GenericMarshal.StringTo<string>(GetFieldValue("caption"));
            set => SetFieldValue("caption", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Orientation of separator.
        /// </description>
        /// </value>
        public GuiSeparatorType Type {
            get => GenericMarshal.StringTo<GuiSeparatorType>(GetFieldValue("type"));
            set => SetFieldValue("type", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public int BorderMargin {
            get => GenericMarshal.StringTo<int>(GetFieldValue("borderMargin"));
            set => SetFieldValue("borderMargin", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool Invisible {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("invisible"));
            set => SetFieldValue("invisible", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Left margin of text label.
        /// </description>
        /// </value>
        public int LeftMargin {
            get => GenericMarshal.StringTo<int>(GetFieldValue("leftMargin"));
            set => SetFieldValue("leftMargin", GenericMarshal.ToString(value));
        }
    }
}
