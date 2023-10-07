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
    /// <summary>A collapsable pane control.</summary>
    /// <description>
    /// This class wraps a single child control and displays a header with caption above it. If you click the header it will collapse or expand (if <i>collapsable</i> is enabled). The control resizes itself based on its collapsed/expanded size.<br>In the GUI editor, if you just want the header you can make <i>collapsable</i> false. The caption field lets you set the caption; it expects a bitmap (from the GuiControlProfile) that contains two images - the first is displayed when the control is expanded and the second is displayed when it is collapsed. The header is sized based on the first image.
    /// </description>
    /// <code>
    /// new GuiPaneControl()
    /// {
    ///    caption = "Example Pane";
    ///    collapsable = "1";
    ///    barBehindText = "1";
    ///    //Properties not specific to this control have been omitted from this example.
    /// };
    /// </code>
    public class GuiPaneControl : GuiControl {
        public GuiPaneControl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiPaneControl(string pName, bool pRegister)
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

        public GuiPaneControl(string pName)
            : this(pName, false) {
        }

        public GuiPaneControl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiPaneControl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiPaneControl(SimObject pObj)
            : base(pObj) {
        }

        public GuiPaneControl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCollapsed__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool collapse;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCollapsed(IntPtr _this, SetCollapsed__Args args);
            private static _SetCollapsed _SetCollapsedFunc;
            internal static _SetCollapsed SetCollapsed() {
               _SetCollapsedFunc ??= Torque3D.LookupEngineFunction<_SetCollapsed>("fnGuiPaneControl_setCollapsed");

                return _SetCollapsedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiPaneControl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiPaneControl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Collapse or un-collapse the control.
        /// </description>
        /// <param name="collapse">True to collapse the control, false to un-collapse it</param>
        public void SetCollapsed(bool collapse) {
             InternalUnsafeMethods.SetCollapsed__Args _args = new InternalUnsafeMethods.SetCollapsed__Args() {
                collapse = collapse,
             };
             InternalUnsafeMethods.SetCollapsed()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiPaneControl class.
        /// </description>
        /// <returns>The type info object for GuiPaneControl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Text label to display as the pane header.
        /// </description>
        /// </value>
        public string Caption {
            get => GenericMarshal.StringTo<string>(GetFieldValue("caption"));
            set => SetFieldValue("caption", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// String table text ID to use as caption string (overrides 'caption').
        /// </description>
        /// </value>
        public string CaptionID {
            get => GenericMarshal.StringTo<string>(GetFieldValue("captionID"));
            set => SetFieldValue("captionID", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the pane can be collapsed by clicking its header.
        /// </description>
        /// </value>
        public bool Collapsable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("collapsable"));
            set => SetFieldValue("collapsable", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to draw the bitmapped pane bar behind the header text, too.
        /// </description>
        /// </value>
        public bool BarBehindText {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("barBehindText"));
            set => SetFieldValue("barBehindText", GenericMarshal.ToString(value));
        }
    }
}
