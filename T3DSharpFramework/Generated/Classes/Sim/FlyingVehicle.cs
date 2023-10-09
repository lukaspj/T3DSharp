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
    /// <summary>A flying vehicle.</summary>
    /// <description>
    /// 
    /// </description>
    public class FlyingVehicle : Vehicle {
        public FlyingVehicle(bool pRegister = false)
            : base(pRegister) {
        }

        public FlyingVehicle(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public FlyingVehicle(string pName)
            : this(pName, false) {
        }

        public FlyingVehicle(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public FlyingVehicle(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public FlyingVehicle(SimObject pObj)
            : base(pObj) {
        }

        public FlyingVehicle(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct UseCreateHeight__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool enabled;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UseCreateHeight(IntPtr _this, UseCreateHeight__Args args);
            private static _UseCreateHeight _UseCreateHeightFunc;
            internal static _UseCreateHeight UseCreateHeight() {
               _UseCreateHeightFunc ??= Torque3D.LookupEngineFunction<_UseCreateHeight>("fnFlyingVehicle_useCreateHeight");

                return _UseCreateHeightFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnFlyingVehicle_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnFlyingVehicle_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Set whether the vehicle should temporarily use the createHoverHeight specified in the datablock.</summary>
        /// <description>
        /// This can help avoid problems with spawning.
        /// </description>
        /// <param name="enabled">true to use the datablock createHoverHeight, false otherwise</param>
        public void UseCreateHeight(bool enabled) {
             InternalUnsafeMethods.UseCreateHeight__Args _args = new InternalUnsafeMethods.UseCreateHeight__Args() {
                enabled = enabled,
             };
             InternalUnsafeMethods.UseCreateHeight()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the FlyingVehicle class.
        /// </description>
        /// <returns>The type info object for FlyingVehicle</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
