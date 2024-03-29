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
    /// <summary>Defines the properties of a HoverVehicle.</summary>
    /// <description>
    /// 
    /// </description>
    public class HoverVehicleData : VehicleData {
        public HoverVehicleData(bool pRegister = false)
            : base(pRegister) {
        }

        public HoverVehicleData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public HoverVehicleData(string pName)
            : this(pName, false) {
        }

        public HoverVehicleData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public HoverVehicleData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public HoverVehicleData(SimObject pObj)
            : base(pObj) {
        }

        public HoverVehicleData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnHoverVehicleData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnHoverVehicleData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the HoverVehicleData class.
        /// </description>
        /// <returns>The type info object for HoverVehicleData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Force generated in the ground normal direction when the vehicle is not floating (within stabalizer length from the ground).
        /// </description>
        /// <see cref="stabLenMin" />
        /// </value>
        public float NormalForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("normalForce"));
            set => SetFieldValue("normalForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Length of the base stabalizer when travelling at minimum speed (0).
        /// Each tick, the vehicle performs 2 raycasts (from the center back and center front of the vehicle) to check for contact with the ground. The base stabalizer length determines the length of that raycast; if neither raycast hit the ground, the vehicle is floating, stabalizer spring and ground normal forces are not applied.
        /// 
        /// <img src="images/hoverVehicle_forces.png">
        /// </description>
        /// <see cref="stabSpringConstant" />
        /// </value>
        public float StabLenMin {
            get => GenericMarshal.StringTo<float>(GetFieldValue("stabLenMin"));
            set => SetFieldValue("stabLenMin", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Length of the base stabalizer when travelling at maximum speed (maxThrustSpeed).
        /// </description>
        /// <see cref="stabLenMin" />
        /// <see cref="mainThrustForce" />
        /// </value>
        public float StabLenMax {
            get => GenericMarshal.StringTo<float>(GetFieldValue("stabLenMax"));
            set => SetFieldValue("stabLenMax", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Value used to generate stabalizer spring force. The force generated depends on stabilizer compression, that is how close the vehicle is to the ground proportional to current stabalizer length.
        /// </description>
        /// <see cref="stabLenMin" />
        /// </value>
        public float StabSpringConstant {
            get => GenericMarshal.StringTo<float>(GetFieldValue("stabSpringConstant"));
            set => SetFieldValue("stabSpringConstant", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Damping spring force acting against changes in the stabalizer length.
        /// </description>
        /// <see cref="stabLenMin" />
        /// </value>
        public float StabDampingConstant {
            get => GenericMarshal.StringTo<float>(GetFieldValue("stabDampingConstant"));
            set => SetFieldValue("stabDampingConstant", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Yaw (rotation about the Z-axis) force applied when steering in the x-axis direction.about the vehicle's Z-axis)
        /// </description>
        /// </value>
        public float SteeringForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("steeringForce"));
            set => SetFieldValue("steeringForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Roll (rotation about the Y-axis) force applied when steering in the x-axis direction.
        /// </description>
        /// </value>
        public float RollForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rollForce"));
            set => SetFieldValue("rollForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Pitch (rotation about the X-axis) force applied when steering in the y-axis direction.
        /// </description>
        /// </value>
        public float PitchForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pitchForce"));
            set => SetFieldValue("pitchForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Force generated by thrusting the vehicle forward.
        /// Also used to determine the maxThrustSpeed:
        /// </description>
        /// <code>
        /// maxThrustSpeed = (mainThrustForce + strafeThrustForce) / dragForce;
        /// </code>
        /// </value>
        public float MainThrustForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mainThrustForce"));
            set => SetFieldValue("mainThrustForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Force generated by thrusting the vehicle backward.
        /// </description>
        /// </value>
        public float ReverseThrustForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("reverseThrustForce"));
            set => SetFieldValue("reverseThrustForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Force generated by thrusting the vehicle to one side.
        /// Also used to determine the vehicle's maxThrustSpeed.
        /// </description>
        /// <see cref="mainThrustForce" />
        /// </value>
        public float StrafeThrustForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("strafeThrustForce"));
            set => SetFieldValue("strafeThrustForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Scale factor applied to the vehicle's thrust force when jetting.
        /// </description>
        /// </value>
        public float TurboFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("turboFactor"));
            set => SetFieldValue("turboFactor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Scalar applied to the vehicle's thrust force when the vehicle is floating.
        /// </description>
        /// <remarks> The floatingThrustFactor must be between 0.0 and 1.0 (inclusive).</remarks>
        /// </value>
        public float FloatingThrustFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("floatingThrustFactor"));
            set => SetFieldValue("floatingThrustFactor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Damping torque that acts against the vehicle's current angular momentum.
        /// </description>
        /// </value>
        public float GyroDrag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gyroDrag"));
            set => SetFieldValue("gyroDrag", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Force generated to stabalize the vehicle (return it to neutral pitch/roll) when the vehicle is floating (more than stabalizer length from the ground.
        /// </description>
        /// <see cref="stabLenMin" />
        /// </value>
        public float RestorativeForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("restorativeForce"));
            set => SetFieldValue("restorativeForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Emitter to generate particles for forward jet thrust.
        /// Forward jet thrust particles are emitted from model nodes JetNozzle0 and JetNozzle1.
        /// </description>
        /// </value>
        public ParticleEmitterData ForwardJetEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("forwardJetEmitter"));
            set => SetFieldValue("forwardJetEmitter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// "X Y Z" offset from the vehicle's origin from which to generate dust trail particles.
        /// By default particles are emitted directly beneath the origin of the vehicle model.
        /// </description>
        /// </value>
        public Point3F DustTrailOffset {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("dustTrailOffset"));
            set => SetFieldValue("dustTrailOffset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Maximum height above surface to emit dust trail particles.
        /// If the vehicle is less than triggerTrailHeight above a static surface with a material that has 'showDust' set to true, the vehicle will emit particles from the dustTrailEmitter.
        /// </description>
        /// </value>
        public float TriggerTrailHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerTrailHeight"));
            set => SetFieldValue("triggerTrailHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Number of dust trail particles to generate based on vehicle speed.
        /// The vehicle's speed is divided by this value to determine how many particles to generate each frame. Lower values give a more dense trail, higher values a more sparse trail.
        /// </description>
        /// </value>
        public float DustTrailFreqMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("dustTrailFreqMod"));
            set => SetFieldValue("dustTrailFreqMod", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// HoverSounds"Sounds for hover vehicle."
        /// </description>
        /// </value>
        public string JetSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("JetSoundFile"));
            set => SetFieldValue("JetSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// HoverSoundsasset reference.
        /// </description>
        /// </value>
        public string JetSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("JetSoundAsset"));
            set => SetFieldValue("JetSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// HoverSounds"Sounds for hover vehicle."
        /// </description>
        /// </value>
        public string EngineSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("EngineSoundFile"));
            set => SetFieldValue("EngineSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// HoverSoundsasset reference.
        /// </description>
        /// </value>
        public string EngineSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("EngineSoundAsset"));
            set => SetFieldValue("EngineSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// HoverSounds"Sounds for hover vehicle."
        /// </description>
        /// </value>
        public string FloatSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FloatSoundFile"));
            set => SetFieldValue("FloatSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// HoverSoundsasset reference.
        /// </description>
        /// </value>
        public string FloatSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FloatSoundAsset"));
            set => SetFieldValue("FloatSoundAsset", GenericMarshal.ToString(value));
        }
    }
}
