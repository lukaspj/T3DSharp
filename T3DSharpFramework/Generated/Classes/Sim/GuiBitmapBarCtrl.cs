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
    /// 
    public class GuiBitmapBarCtrl : GuiBitmapCtrl {
        public GuiBitmapBarCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiBitmapBarCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiBitmapBarCtrl(string pName)
            : this(pName, false) {
        }

        public GuiBitmapBarCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiBitmapBarCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiBitmapBarCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiBitmapBarCtrl(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiBitmapBarCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiBitmapBarCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiBitmapBarCtrl class.
        /// </description>
        /// <returns>The type info object for GuiBitmapBarCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// % shown
        /// </description>
        /// </value>
        public float Percent {
            get => GenericMarshal.StringTo<float>(GetFieldValue("percent"));
            set => SetFieldValue("percent", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, the bitmap is clipped vertically.
        /// </description>
        /// </value>
        public bool Vertical {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("vertical"));
            set => SetFieldValue("vertical", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, the bitmap is clipped in the oposite direction.
        /// </description>
        /// </value>
        public bool FlipClip {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("flipClip"));
            set => SetFieldValue("flipClip", GenericMarshal.ToString(value));
        }
    }
}
