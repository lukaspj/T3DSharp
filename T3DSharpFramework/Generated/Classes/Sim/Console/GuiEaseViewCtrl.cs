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
    /// <summary>Control to visualize an EaseF.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    /// <see cref="EaseF" />
    public class GuiEaseViewCtrl : GuiControl {
        public GuiEaseViewCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiEaseViewCtrl(string pName, bool pRegister)
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

        public GuiEaseViewCtrl(string pName)
            : this(pName, false) {
        }

        public GuiEaseViewCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiEaseViewCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiEaseViewCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiEaseViewCtrl(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiEaseViewCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiEaseViewCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiEaseViewCtrl class.
        /// </description>
        /// <returns>The type info object for GuiEaseViewCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public EaseF Ease {
            get => GenericMarshal.StringTo<EaseF>(GetFieldValue("ease"));
            set => SetFieldValue("ease", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public LinearColorF EaseColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("easeColor"));
            set => SetFieldValue("easeColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float EaseWidth {
            get => GenericMarshal.StringTo<float>(GetFieldValue("easeWidth"));
            set => SetFieldValue("easeWidth", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public LinearColorF AxisColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("axisColor"));
            set => SetFieldValue("axisColor", GenericMarshal.ToString(value));
        }
    }
}
