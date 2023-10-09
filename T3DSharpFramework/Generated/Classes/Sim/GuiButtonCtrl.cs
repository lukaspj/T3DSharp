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
    /// <summary>The most widely used button class.</summary>
    /// <description>
    /// GuiButtonCtrl renders seperately of, but utilizes all of the functionality of GuiBaseButtonCtrl.
    /// This grants GuiButtonCtrl the versatility to be either of the 3 button types.
    /// </description>
    /// <code>
    /// // Create a PushButton GuiButtonCtrl that calls randomFunction when clicked
    /// %button = new GuiButtonCtrl()
    /// {
    ///    profile    = "GuiButtonProfile";
    ///    buttonType = "PushButton";
    ///    command    = "randomFunction();";
    /// };
    /// </code>
    public class GuiButtonCtrl : GuiButtonBaseCtrl {
        public GuiButtonCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiButtonCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiButtonCtrl(string pName)
            : this(pName, false) {
        }

        public GuiButtonCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiButtonCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiButtonCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiButtonCtrl(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiButtonCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiButtonCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiButtonCtrl class.
        /// </description>
        /// <returns>The type info object for GuiButtonCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
