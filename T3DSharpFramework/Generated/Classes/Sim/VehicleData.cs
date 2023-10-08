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
    /// <summary>Base properties shared by all Vehicles (FlyingVehicle, HoverVehicle, WheeledVehicle).</summary>
    /// <description>
    /// This datablock defines properties shared by all Vehicle types, but should not be instantiated directly. Instead, set the desired properties in the FlyingVehicleData, HoverVehicleData or WheeledVehicleData datablock.
    /// </description>
    /// <code>
    /// // damage from collisions
    /// collDamageMultiplier = 0.05;
    /// collDamageThresholdVel = 15;
    /// 
    /// // damage levels
    /// damageLevelTolerance[0] = 0.5;
    /// damageEmitter[0] = GraySmokeEmitter;     // emitter used when damage is >= 50%
    /// damageLevelTolerance[1] = 0.85;
    /// damageEmitter[1] = BlackSmokeEmitter;    // emitter used when damage is >= 85%
    /// damageEmitter[2] = DamageBubbleEmitter;  // emitter used instead of damageEmitter[0:1]
    ///                                          // when offset point is underwater
    /// // emit offsets (used for all active damage level emitters)
    /// damageEmitterOffset[0] = "0.5 3 1";
    /// damageEmitterOffset[1] = "-0.5 3 1";
    /// numDmgEmitterAreas = 2;
    /// </code>
    public class VehicleData : RigidShapeData {
        public VehicleData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public VehicleData(string pName, bool pRegister)
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

        public VehicleData(string pName)
            : this(pName, false) {
        }

        public VehicleData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public VehicleData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public VehicleData(SimObject pObj)
            : base(pObj) {
        }

        public VehicleData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnVehicleData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnVehicleData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the VehicleData class.
        /// </description>
        /// <returns>The type info object for VehicleData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Array of particle emitters used to generate damage (dust, smoke etc) effects.</summary>
        /// <description>
        /// Currently, the first two emitters (indices 0 and 1) are used when the damage level exceeds the associated damageLevelTolerance. The 3rd emitter is used when the emitter point is underwater.
        /// </description>
        /// <see cref="damageEmitterOffset" />
        /// </value>
        public DynamicFieldVector<ParticleEmitterData> DamageEmitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this, 
                    "damageEmitter", 
                    3, 
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>Object space "x y z" offsets used to emit particles for the active damageEmitter.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // damage levels
        /// damageLevelTolerance[0] = 0.5;
        /// damageEmitter[0] = SmokeEmitter;
        /// // emit offsets (used for all active damage level emitters)
        /// damageEmitterOffset[0] = "0.5 3 1";
        /// damageEmitterOffset[1] = "-0.5 3 1";
        /// numDmgEmitterAreas = 2;
        /// </code>
        /// </value>
        public DynamicFieldVector<Point3F> DamageEmitterOffset {
            get => new DynamicFieldVector<Point3F>(
                    this, 
                    "damageEmitterOffset", 
                    2, 
                    val => GenericMarshal.StringTo<Point3F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>Damage levels (as a percentage of maxDamage) above which to begin emitting particles from the associated damageEmitter.</summary>
        /// <description>
        /// Levels should be in order of increasing damage.
        /// </description>
        /// <see cref="damageEmitterOffset" />
        /// </value>
        public DynamicFieldVector<float> DamageLevelTolerance {
            get => new DynamicFieldVector<float>(
                    this, 
                    "damageLevelTolerance", 
                    2, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Number of damageEmitterOffset values to use for each damageEmitter.
        /// </description>
        /// <see cref="damageEmitterOffset" />
        /// </value>
        public float NumDmgEmitterAreas {
            get => GenericMarshal.StringTo<float>(GetFieldValue("numDmgEmitterAreas"));
            set => SetFieldValue("numDmgEmitterAreas", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum collision velocity to cause damage to this vehicle.
        /// Currently unused.
        /// </description>
        /// </value>
        public float CollDamageThresholdVel {
            get => GenericMarshal.StringTo<float>(GetFieldValue("collDamageThresholdVel"));
            set => SetFieldValue("collDamageThresholdVel", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Damage to this vehicle after a collision (multiplied by collision velocity).</summary>
        /// <description>
        /// Currently unused.
        /// </description>
        /// </value>
        public float CollDamageMultiplier {
            get => GenericMarshal.StringTo<float>(GetFieldValue("collDamageMultiplier"));
            set => SetFieldValue("collDamageMultiplier", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Additional force applied to the vehicle when it is jetting.</summary>
        /// <description>
        /// For WheeledVehicles, the force is applied in the forward direction. For FlyingVehicles, the force is applied in the thrust direction.
        /// </description>
        /// </value>
        public float JetForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetForce"));
            set => SetFieldValue("jetForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Energy amount to drain for each tick the vehicle is jetting.</summary>
        /// <description>
        /// Once the vehicle's energy level reaches 0, it will no longer be able to jet.
        /// </description>
        /// </value>
        public float JetEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetEnergyDrain"));
            set => SetFieldValue("jetEnergyDrain", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum vehicle energy level to begin jetting.
        /// </description>
        /// </value>
        public float MinJetEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minJetEnergy"));
            set => SetFieldValue("minJetEnergy", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Maximum yaw (horizontal) and pitch (vertical) steering angle in radians.
        /// </description>
        /// </value>
        public float MaxSteeringAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSteeringAngle"));
            set => SetFieldValue("maxSteeringAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, steering does not auto-centre while the vehicle is being steered by its driver.
        /// </description>
        /// </value>
        public bool PowerSteering {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("powerSteering"));
            set => SetFieldValue("powerSteering", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Rate at which the vehicle's steering returns to forwards when it is moving.
        /// </description>
        /// </value>
        public float SteeringReturn {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringReturn"));
            set => SetFieldValue("steeringReturn", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Amount of effect the vehicle's speed has on its rate of steering return.
        /// </description>
        /// </value>
        public float SteeringReturnSpeedScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringReturnSpeedScale"));
            set => SetFieldValue("steeringReturnSpeedScale", GenericMarshal.ToString(value));
        }
    }
}
