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
    /// <summary>Editor GUI used for picking a LinearColorF from a palette.</summary>
    /// <description>
    /// 
    /// </description>
    /// <remarks> Editor use only.
    /// 
    /// </remarks>
    public class GuiColorPickerCtrl : GuiControl {
        public GuiColorPickerCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiColorPickerCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiColorPickerCtrl(string pName)
            : this(pName, false) {
        }

        public GuiColorPickerCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiColorPickerCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiColorPickerCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiColorPickerCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectorColor__Args
            {
                internal IntPtr color;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectorColor(IntPtr _this, SetSelectorColor__Args args);
            private static _SetSelectorColor _SetSelectorColorFunc;
            internal static _SetSelectorColor SetSelectorColor() {
               _SetSelectorColorFunc ??= Torque3D.LookupEngineFunction<_SetSelectorColor>("fnGuiColorPickerCtrl_setSelectorColor");

                return _SetSelectorColorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UpdateColor__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UpdateColor(IntPtr _this, UpdateColor__Args args);
            private static _UpdateColor _UpdateColorFunc;
            internal static _UpdateColor UpdateColor() {
               _UpdateColorFunc ??= Torque3D.LookupEngineFunction<_UpdateColor>("fnGuiColorPickerCtrl_updateColor");

                return _UpdateColorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSelectorPos__Args
            {
                internal IntPtr newPos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSelectorPos(IntPtr _this, SetSelectorPos__Args args);
            private static _SetSelectorPos _SetSelectorPosFunc;
            internal static _SetSelectorPos SetSelectorPos() {
               _SetSelectorPosFunc ??= Torque3D.LookupEngineFunction<_SetSelectorPos>("fnGuiColorPickerCtrl_setSelectorPos");

                return _SetSelectorPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectorPos__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2I.InternalStruct _GetSelectorPos(IntPtr _this, GetSelectorPos__Args args);
            private static _GetSelectorPos _GetSelectorPosFunc;
            internal static _GetSelectorPos GetSelectorPos() {
               _GetSelectorPosFunc ??= Torque3D.LookupEngineFunction<_GetSelectorPos>("fnGuiColorPickerCtrl_getSelectorPos");

                return _GetSelectorPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiColorPickerCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiColorPickerCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Sets the current position of the selector based on a color.n
        /// </description>
        /// <param name="color">Color to look for.n</param>
        public void SetSelectorColor(LinearColorF color) {
color.Alloc();             InternalUnsafeMethods.SetSelectorColor__Args _args = new InternalUnsafeMethods.SetSelectorColor__Args() {
                color = color.internalStructPtr,
             };
             InternalUnsafeMethods.SetSelectorColor()(ObjectPtr, _args);
color.Free();        }

        /// <description>
        /// Forces update of pick color
        /// </description>
        public void UpdateColor() {
             InternalUnsafeMethods.UpdateColor__Args _args = new InternalUnsafeMethods.UpdateColor__Args() {
             };
             InternalUnsafeMethods.UpdateColor()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the current position of the selector
        /// </description>
        public void SetSelectorPos(Point2I newPos) {
newPos.Alloc();             InternalUnsafeMethods.SetSelectorPos__Args _args = new InternalUnsafeMethods.SetSelectorPos__Args() {
                newPos = newPos.internalStructPtr,
             };
             InternalUnsafeMethods.SetSelectorPos()(ObjectPtr, _args);
newPos.Free();        }

        /// <description>
        /// Gets the current position of the selector
        /// </description>
        public Point2I GetSelectorPos() {
             InternalUnsafeMethods.GetSelectorPos__Args _args = new InternalUnsafeMethods.GetSelectorPos__Args() {
             };
             Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetSelectorPos()(ObjectPtr, _args);
             return new Point2I(_engineResult);
        }

        /// <description>
        /// Get the type info object for the GuiColorPickerCtrl class.
        /// </description>
        /// <returns>The type info object for GuiColorPickerCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public LinearColorF BaseColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("baseColor"));
            set => SetFieldValue("baseColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public LinearColorF PickColor {
            get => GenericMarshal.StringTo<LinearColorF>(GetFieldValue("pickColor"));
            set => SetFieldValue("pickColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public int SelectorGap {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectorGap"));
            set => SetFieldValue("selectorGap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public GuiColorPickMode DisplayMode {
            get => GenericMarshal.StringTo<GuiColorPickMode>(GetFieldValue("displayMode"));
            set => SetFieldValue("displayMode", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool ActionOnMove {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("actionOnMove"));
            set => SetFieldValue("actionOnMove", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool ShowReticle {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showReticle"));
            set => SetFieldValue("showReticle", GenericMarshal.ToString(value));
        }
    }
}
