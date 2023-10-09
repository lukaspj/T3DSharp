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
    /// <summary>Defines the properties of a WheeledVehicle.</summary>
    /// <description>
    /// 
    /// </description>
    public class WheeledVehicleData : VehicleData {
        public WheeledVehicleData(bool pRegister = false)
            : base(pRegister) {
        }

        public WheeledVehicleData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public WheeledVehicleData(string pName)
            : this(pName, false) {
        }

        public WheeledVehicleData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public WheeledVehicleData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public WheeledVehicleData(SimObject pObj)
            : base(pObj) {
        }

        public WheeledVehicleData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnWheeledVehicleData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnWheeledVehicleData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the WheeledVehicleData class.
        /// </description>
        /// <returns>The type info object for WheeledVehicleData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// ParticleEmitterData datablock used to generate particles from each wheel when the vehicle is moving and the wheel is in contact with the ground.
        /// </description>
        /// </value>
        public ParticleEmitterData TireEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("tireEmitter"));
            set => SetFieldValue("tireEmitter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WheeledVehicleSounds"Sounds related to wheeled vehicle."
        /// </description>
        /// </value>
        public string JetSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("JetSoundFile"));
            set => SetFieldValue("JetSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WheeledVehicleSoundsasset reference.
        /// </description>
        /// </value>
        public string JetSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("JetSoundAsset"));
            set => SetFieldValue("JetSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WheeledVehicleSounds"Sounds related to wheeled vehicle."
        /// </description>
        /// </value>
        public string EngineSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("EngineSoundFile"));
            set => SetFieldValue("EngineSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WheeledVehicleSoundsasset reference.
        /// </description>
        /// </value>
        public string EngineSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("EngineSoundAsset"));
            set => SetFieldValue("EngineSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WheeledVehicleSounds"Sounds related to wheeled vehicle."
        /// </description>
        /// </value>
        public string SquealSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SquealSoundFile"));
            set => SetFieldValue("SquealSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WheeledVehicleSoundsasset reference.
        /// </description>
        /// </value>
        public string SquealSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SquealSoundAsset"));
            set => SetFieldValue("SquealSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WheeledVehicleSounds"Sounds related to wheeled vehicle."
        /// </description>
        /// </value>
        public string WheelImpactSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("WheelImpactSoundFile"));
            set => SetFieldValue("WheelImpactSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WheeledVehicleSoundsasset reference.
        /// </description>
        /// </value>
        public string WheelImpactSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("WheelImpactSoundAsset"));
            set => SetFieldValue("WheelImpactSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum linear velocity of each wheel.</summary>
        /// <description>
        /// This caps the maximum speed of the vehicle.
        /// </description>
        /// </value>
        public float MaxWheelSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxWheelSpeed"));
            set => SetFieldValue("maxWheelSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Torque available from the engine at 100% throttle.</summary>
        /// <description>
        /// This controls vehicle acceleration. ie. how fast it will reach maximum speed.
        /// </description>
        /// </value>
        public float EngineTorque {
            get => GenericMarshal.StringTo<float>(GetFieldValue("engineTorque"));
            set => SetFieldValue("engineTorque", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Braking torque applied by the engine when the throttle and brake are both 0.</summary>
        /// <description>
        /// This controls how quickly the vehicle will coast to a stop.
        /// </description>
        /// </value>
        public float EngineBrake {
            get => GenericMarshal.StringTo<float>(GetFieldValue("engineBrake"));
            set => SetFieldValue("engineBrake", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Torque applied when braking.</summary>
        /// <description>
        /// This controls how fast the vehicle will stop when the brakes are applied.
        /// </description>
        /// </value>
        public float BrakeTorque {
            get => GenericMarshal.StringTo<float>(GetFieldValue("brakeTorque"));
            set => SetFieldValue("brakeTorque", GenericMarshal.ToString(value));
        }
    }
}
