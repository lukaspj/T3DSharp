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
    /// <summary>A named checkbox that can be toggled on and off.</summary>
    /// <description>
    /// A GuiCheckBoxCtrl displays a text label next to a checkbox that can be toggled on and off by the user. Checkboxes are usually used to present boolean choices like, for example, a switch to toggle fullscreen video on and off.
    /// </description>
    /// <code>
    /// // Create a checkbox that allows to toggle fullscreen on and off.
    /// new GuiCheckBoxCtrl( FullscreenToggle )
    /// {
    ///    text = "Fullscreen";
    /// };
    /// 
    /// // Set the initial state to match the current fullscreen setting.
    /// FullscreenToggle.setStateOn( Canvas.isFullscreen() );
    /// 
    /// // Define function to be called when checkbox state is toggled.
    /// function FullscreenToggle::onClick( %this )
    /// {
    ///    Canvas.toggleFullscreen();
    /// }
    /// </code>
    public class GuiCheckBoxCtrl : GuiButtonBaseCtrl {
        public GuiCheckBoxCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiCheckBoxCtrl(string pName, bool pRegister)
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

        public GuiCheckBoxCtrl(string pName)
            : this(pName, false) {
        }

        public GuiCheckBoxCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiCheckBoxCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiCheckBoxCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiCheckBoxCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct IsStateOn__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsStateOn(IntPtr _this, IsStateOn__Args args);
            private static _IsStateOn _IsStateOnFunc;
            internal static _IsStateOn IsStateOn() {
               _IsStateOnFunc ??= Torque3D.LookupEngineFunction<_IsStateOn>("fnGuiCheckBoxCtrl_isStateOn");

                return _IsStateOnFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetStateOn__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool newState;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetStateOn(IntPtr _this, SetStateOn__Args args);
            private static _SetStateOn _SetStateOnFunc;
            internal static _SetStateOn SetStateOn() {
               _SetStateOnFunc ??= Torque3D.LookupEngineFunction<_SetStateOn>("fnGuiCheckBoxCtrl_setStateOn");

                return _SetStateOnFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiCheckBoxCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiCheckBoxCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Test whether the checkbox is currently checked.
        /// </description>
        /// <returns>True if the checkbox is currently ticked, false otherwise.</returns>
        public bool IsStateOn() {
             InternalUnsafeMethods.IsStateOn__Args _args = new InternalUnsafeMethods.IsStateOn__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsStateOn()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set whether the checkbox is ticked or not.
        /// </description>
        /// <param name="newState">If true the box will be checked, if false, it will be unchecked.</param>
        /// <remarks> This method will </remarks>
        public void SetStateOn(bool newState) {
             InternalUnsafeMethods.SetStateOn__Args _args = new InternalUnsafeMethods.SetStateOn__Args() {
                newState = newState,
             };
             InternalUnsafeMethods.SetStateOn()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiCheckBoxCtrl class.
        /// </description>
        /// <returns>The type info object for GuiCheckBoxCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
