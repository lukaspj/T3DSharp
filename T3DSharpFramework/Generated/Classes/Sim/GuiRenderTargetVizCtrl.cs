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
    /// GuiRenderTargetVizCtrl renders seperately of, but utilizes all of the functionality of GuiBaseButtonCtrl.
    /// This grants GuiRenderTargetVizCtrl the versatility to be either of the 3 button types.
    /// </description>
    /// <code>
    /// // Create a PushButton GuiRenderTargetVizCtrl that calls randomFunction when clicked
    /// %button = new GuiRenderTargetVizCtrl()
    /// {
    ///    profile    = "GuiButtonProfile";
    ///    buttonType = "PushButton";
    ///    command    = "randomFunction();";
    /// };
    /// </code>
    public class GuiRenderTargetVizCtrl : GuiControl {
        public GuiRenderTargetVizCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiRenderTargetVizCtrl(string pName, bool pRegister)
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

        public GuiRenderTargetVizCtrl(string pName)
            : this(pName, false) {
        }

        public GuiRenderTargetVizCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiRenderTargetVizCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiRenderTargetVizCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiRenderTargetVizCtrl(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiRenderTargetVizCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiRenderTargetVizCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiRenderTargetVizCtrl class.
        /// </description>
        /// <returns>The type info object for GuiRenderTargetVizCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public string RenderTargetName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("RenderTargetName"));
            set => SetFieldValue("RenderTargetName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public SimObject CameraObject {
            get => GenericMarshal.StringTo<SimObject>(GetFieldValue("cameraObject"));
            set => SetFieldValue("cameraObject", GenericMarshal.ToString(value));
        }
    }
}
