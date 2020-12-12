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
    /// <summary>Draws a box with handles for the user to manipulate.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public unsafe class GuiRectHandles : GuiControl {
        public GuiRectHandles(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiRectHandles(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiRectHandles(string pName) 
            : this(pName, false) {
        }
        
        public GuiRectHandles(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiRectHandles(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiRectHandles(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiRectHandles(IntPtr pObj) 
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
                if (_StaticGetTypeFunc == null) {
                    _StaticGetTypeFunc =
                        (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiRectHandles_staticGetType"), typeof(_StaticGetType));
                }
                
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
                if (_CreateFunc == null) {
                    _CreateFunc =
                        (_Create)Marshal.GetDelegateForFunctionPointer(
                            Torque3D.DllLoadUtils.GetProcAddress(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiRectHandles_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiRectHandles class.
        /// </description>
        /// <returns>The type info object for GuiRectHandles</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// RectF of handle's box.
        /// </description>
        /// </value>
        public RectF HandleRect {
            get => GenericMarshal.StringTo<RectF>(GetFieldValue("handleRect"));
            set => SetFieldValue("handleRect", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Size of handles in pixels.
        /// </description>
        /// </value>
        public int HandleSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("handleSize"));
            set => SetFieldValue("handleSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Use given custom color for handles.
        /// </description>
        /// </value>
        public bool UseCustomColor {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useCustomColor"));
            set => SetFieldValue("useCustomColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Use given custom color for handles.
        /// </description>
        /// </value>
        public ColorI HandleColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("handleColor"));
            set => SetFieldValue("handleColor", GenericMarshal.ToString(value));
        }
    }
}