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
    /// <summary>Defines the physics properties for an individual RigidShapeData physics object.</summary>
    /// <description>
    /// 
    /// </description>
    /// <code>
    /// datablock RigidShapeData( BouncingBoulder )
    /// 	{
    /// 	   category = "RigidShape";
    /// 
    /// 	   shapeFile = "~/data/shapes/boulder/boulder.dts";
    /// 
    /// 	   // Rigid Body
    /// 	   mass = 500;
    /// 	   massCenter = "0 0 0";    // Center of mass for rigid body
    /// 	   massBox = "0 0 0";         // Size of box used for moment of inertia,
    /// 								  // if zero it defaults to object bounding box
    /// 	   drag = 0.2;                // Drag coefficient
    /// 	   bodyFriction = 0.2;
    /// 	   bodyRestitution = 0.1;
    /// 	   minImpactSpeed = 5;        // Impacts over this invoke the script callback
    /// 	   softImpactSpeed = 5;       // Play SoftImpact Sound
    /// 	   hardImpactSpeed = 15;      // Play HardImpact Sound
    /// 	   integration = 4;           // Physics integration: TickSec/Rate
    /// 	   collisionTol = 0.1;        // Collision distance tolerance
    /// 	   contactTol = 0.1;          // Contact velocity tolerance
    /// 
    /// 	   minRollSpeed = 10;
    /// 
    /// 	   maxDrag = 0.5;
    /// 	   minDrag = 0.01;
    /// 
    /// 	   dustHeight = 10;
    /// 
    /// 	   dragForce = 0.05;
    /// 	   vertFactor = 0.05;
    /// 	};
    /// </code>
    /// <see cref="RigidShape" />
    /// <see cref="ShapeBase" />
    public class RigidShapeData : ShapeBaseData {
        public RigidShapeData(bool pRegister = false)
            : base(pRegister) {
        }

        public RigidShapeData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public RigidShapeData(string pName)
            : this(pName, false) {
        }

        public RigidShapeData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public RigidShapeData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public RigidShapeData(SimObject pObj)
            : base(pObj) {
        }

        public RigidShapeData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLeaveLiquid__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLeaveLiquid(IntPtr _this, OnLeaveLiquid__Args args);
            private static _OnLeaveLiquid _OnLeaveLiquidFunc;
            internal static _OnLeaveLiquid OnLeaveLiquid() {
               _OnLeaveLiquidFunc ??= Torque3D.LookupEngineFunction<_OnLeaveLiquid>("cbRigidShapeData_onLeaveLiquid");

                return _OnLeaveLiquidFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnEnterLiquid__Args
            {
                internal IntPtr obj;
                internal float coverage;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string type;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnEnterLiquid(IntPtr _this, OnEnterLiquid__Args args);
            private static _OnEnterLiquid _OnEnterLiquidFunc;
            internal static _OnEnterLiquid OnEnterLiquid() {
               _OnEnterLiquidFunc ??= Torque3D.LookupEngineFunction<_OnEnterLiquid>("cbRigidShapeData_onEnterLiquid");

                return _OnEnterLiquidFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnRigidShapeData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnRigidShapeData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Called when the vehicle leaves liquid.
        /// </description>
        /// <param name="obj">the Vehicle object</param>
        /// <param name="type">type of liquid the vehicle has left</param>
        public virtual void OnLeaveLiquid(RigidShape obj, string type) {
             InternalUnsafeMethods.OnLeaveLiquid__Args _args = new InternalUnsafeMethods.OnLeaveLiquid__Args() {
                obj = obj.ObjectPtr,
                type = type,
             };
             InternalUnsafeMethods.OnLeaveLiquid()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the vehicle enters liquid.
        /// </description>
        /// <param name="obj">the Vehicle object</param>
        /// <param name="coverage">percentage of the vehicle's bounding box covered by the liquid</param>
        /// <param name="type">type of liquid the vehicle has entered</param>
        public virtual void OnEnterLiquid(RigidShape obj, float coverage, string type) {
             InternalUnsafeMethods.OnEnterLiquid__Args _args = new InternalUnsafeMethods.OnEnterLiquid__Args() {
                obj = obj.ObjectPtr,
                coverage = coverage,
                type = type,
             };
             InternalUnsafeMethods.OnEnterLiquid()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the RigidShapeData class.
        /// </description>
        /// <returns>The type info object for RigidShapeData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Array of pointers to ParticleEmitterData datablocks which will be used to emit particles at object/terrain contact point.
        /// </description>
        /// </value>
        public ParticleEmitterData DustEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("dustEmitter"));
            set => SetFieldValue("dustEmitter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Maximum height from the ground at which the object will generate dust.
        /// </description>
        /// </value>
        public float TriggerDustHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerDustHeight"));
            set => SetFieldValue("triggerDustHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Height of dust effects.
        /// </description>
        /// </value>
        public float DustHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dustHeight"));
            set => SetFieldValue("dustHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Particle emitter used to create a dust trail for the moving object.
        /// </description>
        /// </value>
        public ParticleEmitterData DustTrailEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("dustTrailEmitter"));
            set => SetFieldValue("dustTrailEmitter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Array of pointers to ParticleEmitterData datablocks which will generate splash effects.
        /// </description>
        /// </value>
        public DynamicFieldVector<ParticleEmitterData> SplashEmitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this, 
                    "splashEmitter", 
                    2, 
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The simulated frequency modulation of a splash generated by this object. Multiplied along with speed and time elapsed when determining splash emition rate.
        /// </description>
        /// </value>
        public float SplashFreqMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashFreqMod"));
            set => SetFieldValue("splashFreqMod", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The threshold speed at which we consider the object's movement to have stopped when updating splash effects.
        /// </description>
        /// </value>
        public float SplashVelEpsilon {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashVelEpsilon"));
            set => SetFieldValue("splashVelEpsilon", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// BodySounds"Sounds for body."
        /// </description>
        /// </value>
        public string SoftImpactSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SoftImpactSoundFile"));
            set => SetFieldValue("SoftImpactSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// BodySoundsasset reference.
        /// </description>
        /// </value>
        public string SoftImpactSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SoftImpactSoundAsset"));
            set => SetFieldValue("SoftImpactSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// BodySounds"Sounds for body."
        /// </description>
        /// </value>
        public string HardImpactSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("HardImpactSoundFile"));
            set => SetFieldValue("HardImpactSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// BodySoundsasset reference.
        /// </description>
        /// </value>
        public string HardImpactSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("HardImpactSoundAsset"));
            set => SetFieldValue("HardImpactSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSounds"Sounds for interacting with water."
        /// </description>
        /// </value>
        public string ExitWaterFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ExitWaterFile"));
            set => SetFieldValue("ExitWaterFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSoundsasset reference.
        /// </description>
        /// </value>
        public string ExitWaterAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ExitWaterAsset"));
            set => SetFieldValue("ExitWaterAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSounds"Sounds for interacting with water."
        /// </description>
        /// </value>
        public string ImpactSoftFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactSoftFile"));
            set => SetFieldValue("ImpactSoftFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSoundsasset reference.
        /// </description>
        /// </value>
        public string ImpactSoftAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactSoftAsset"));
            set => SetFieldValue("ImpactSoftAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSounds"Sounds for interacting with water."
        /// </description>
        /// </value>
        public string ImpactMediumFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactMediumFile"));
            set => SetFieldValue("ImpactMediumFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSoundsasset reference.
        /// </description>
        /// </value>
        public string ImpactMediumAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactMediumAsset"));
            set => SetFieldValue("ImpactMediumAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSounds"Sounds for interacting with water."
        /// </description>
        /// </value>
        public string ImpactHardFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactHardFile"));
            set => SetFieldValue("ImpactHardFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSoundsasset reference.
        /// </description>
        /// </value>
        public string ImpactHardAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactHardAsset"));
            set => SetFieldValue("ImpactHardAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSounds"Sounds for interacting with water."
        /// </description>
        /// </value>
        public string WakeFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("WakeFile"));
            set => SetFieldValue("WakeFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// WaterSoundsasset reference.
        /// </description>
        /// </value>
        public string WakeAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("WakeAsset"));
            set => SetFieldValue("WakeAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Creates a representation of the object in the physics plugin.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public bool EnablePhysicsRep {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("enablePhysicsRep"));
            set => SetFieldValue("enablePhysicsRep", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Center of mass for rigid body.
        /// </description>
        /// </value>
        public Point3F MassCenter {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("massCenter"));
            set => SetFieldValue("massCenter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Size of inertial box.
        /// </description>
        /// </value>
        public Point3F MassBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("massBox"));
            set => SetFieldValue("massBox", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The percentage of kinetic energy kept by this object in a collision.
        /// </description>
        /// </value>
        public float BodyRestitution {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bodyRestitution"));
            set => SetFieldValue("bodyRestitution", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// How much friction this object has. Lower values will cause the object to appear to be more slippery.
        /// </description>
        /// </value>
        public float BodyFriction {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bodyFriction"));
            set => SetFieldValue("bodyFriction", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Maximum drag available to this object.
        /// </description>
        /// </value>
        public float MaxDrag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxDrag"));
            set => SetFieldValue("maxDrag", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum drag available to this object.
        /// </description>
        /// </value>
        public float MinDrag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minDrag"));
            set => SetFieldValue("minDrag", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Number of physics steps to process per tick.
        /// </description>
        /// </value>
        public int Integration {
            get => GenericMarshal.StringTo<int>(GetFieldValue("integration"));
            set => SetFieldValue("integration", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Collision distance tolerance.
        /// </description>
        /// </value>
        public float CollisionTol {
            get => GenericMarshal.StringTo<float>(GetFieldValue("collisionTol"));
            set => SetFieldValue("collisionTol", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Contact velocity tolerance.
        /// </description>
        /// </value>
        public float ContactTol {
            get => GenericMarshal.StringTo<float>(GetFieldValue("contactTol"));
            set => SetFieldValue("contactTol", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Used to simulate the constant drag acting on the object
        /// </description>
        /// </value>
        public float DragForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dragForce"));
            set => SetFieldValue("dragForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The scalar applied to the vertical portion of the velocity drag acting on a object.
        /// </description>
        /// </value>
        public float VertFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("vertFactor"));
            set => SetFieldValue("vertFactor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum collision speed to classify collision as impact (triggers onImpact on server object).
        /// </description>
        /// </value>
        public float MinImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minImpactSpeed"));
            set => SetFieldValue("minImpactSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum speed at which this object must be travelling for the soft impact sound to be played.
        /// </description>
        /// </value>
        public float SoftImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("softImpactSpeed"));
            set => SetFieldValue("softImpactSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum speed at which the object must be travelling for the hard impact sound to be played.
        /// </description>
        /// </value>
        public float HardImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("hardImpactSpeed"));
            set => SetFieldValue("hardImpactSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public float MinRollSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minRollSpeed"));
            set => SetFieldValue("minRollSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The minimum velocity at which the exit splash sound will be played when emerging from water.
        /// </description>
        /// </value>
        public float ExitSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("exitSplashSoundVelocity"));
            set => SetFieldValue("exitSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The minimum velocity at which the soft splash sound will be played when impacting water.
        /// </description>
        /// </value>
        public float SoftSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("softSplashSoundVelocity"));
            set => SetFieldValue("softSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The minimum velocity at which the medium splash sound will be played when impacting water.
        /// </description>
        /// </value>
        public float MediumSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mediumSplashSoundVelocity"));
            set => SetFieldValue("mediumSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The minimum velocity at which the hard splash sound will be played when impacting water.
        /// </description>
        /// </value>
        public float HardSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("hardSplashSoundVelocity"));
            set => SetFieldValue("hardSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Specifies whether the camera's rotation matrix, and the render eye transform are multiplied during camera updates.
        /// </description>
        /// </value>
        public bool CameraRoll {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("cameraRoll"));
            set => SetFieldValue("cameraRoll", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Scalar amount by which the third person camera lags the object, relative to the object's linear velocity.
        /// </description>
        /// </value>
        public float CameraLag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraLag"));
            set => SetFieldValue("cameraLag", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Scalar rate at which the third person camera offset decays, per tick.
        /// </description>
        /// </value>
        public float CameraDecay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraDecay"));
            set => SetFieldValue("cameraDecay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The vertical offset of the object's camera.
        /// </description>
        /// </value>
        public float CameraOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraOffset"));
            set => SetFieldValue("cameraOffset", GenericMarshal.ToString(value));
        }
    }
}
