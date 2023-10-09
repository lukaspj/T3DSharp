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
    /// <summary>A datablock that specifies a Machine Gun effect.</summary>
    /// <description>
    /// Machine Gun is a simple but useful effect for rapidly shooting standard Torque Projectile objects. For performance reasons, keep in mind that each bullet is a separate Projectile object, which is not a very lightweight object.
    /// </description>
    public class afxMachineGunData : GameBaseData {
        public afxMachineGunData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxMachineGunData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public afxMachineGunData(string pName)
            : this(pName, false) {
        }

        public afxMachineGunData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxMachineGunData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxMachineGunData(SimObject pObj)
            : base(pObj) {
        }

        public afxMachineGunData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxMachineGunData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxMachineGunData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the afxMachineGunData class.
        /// </description>
        /// <returns>The type info object for afxMachineGunData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// A ProjectileData datablock describing the projectile to be launched.
        /// </description>
        /// </value>
        public ProjectileData Projectile {
            get => GenericMarshal.StringTo<ProjectileData>(GetFieldValue("Projectile"));
            set => SetFieldValue("Projectile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Specifies the number of projectiles fired over a minute of time. A value of 1200 will create 20 projectiles per second.
        /// Sample values for real machine guns:
        ///     AK-47 = 600, M16 = 750-900, UZI = 600
        /// </description>
        /// </value>
        public int RoundsPerMinute {
            get => GenericMarshal.StringTo<int>(GetFieldValue("roundsPerMinute"));
            set => SetFieldValue("roundsPerMinute", GenericMarshal.ToString(value));
        }
    }
}
