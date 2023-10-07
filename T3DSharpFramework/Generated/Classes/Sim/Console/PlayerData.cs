using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Console;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Console;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim.Console {
    /// <summary>Defines properties for a Player object.</summary>
    /// <description>
    /// 
    /// </description>
    /// <see cref="Player" />
    public class PlayerData : ShapeBaseData {
        public PlayerData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public PlayerData(string pName, bool pRegister)
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

        public PlayerData(string pName)
            : this(pName, false) {
        }

        public PlayerData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public PlayerData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public PlayerData(SimObject pObj)
            : base(pObj) {
        }

        public PlayerData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLeaveMissionArea__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLeaveMissionArea(IntPtr _this, OnLeaveMissionArea__Args args);
            private static _OnLeaveMissionArea _OnLeaveMissionAreaFunc;
            internal static _OnLeaveMissionArea OnLeaveMissionArea() {
               _OnLeaveMissionAreaFunc ??= Torque3D.LookupEngineFunction<_OnLeaveMissionArea>("cbPlayerData_onLeaveMissionArea");

                return _OnLeaveMissionAreaFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnEnterMissionArea__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnEnterMissionArea(IntPtr _this, OnEnterMissionArea__Args args);
            private static _OnEnterMissionArea _OnEnterMissionAreaFunc;
            internal static _OnEnterMissionArea OnEnterMissionArea() {
               _OnEnterMissionAreaFunc ??= Torque3D.LookupEngineFunction<_OnEnterMissionArea>("cbPlayerData_onEnterMissionArea");

                return _OnEnterMissionAreaFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AnimationDone__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AnimationDone(IntPtr _this, AnimationDone__Args args);
            private static _AnimationDone _AnimationDoneFunc;
            internal static _AnimationDone AnimationDone() {
               _AnimationDoneFunc ??= Torque3D.LookupEngineFunction<_AnimationDone>("cbPlayerData_animationDone");

                return _AnimationDoneFunc;
            }


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
               _OnLeaveLiquidFunc ??= Torque3D.LookupEngineFunction<_OnLeaveLiquid>("cbPlayerData_onLeaveLiquid");

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
               _OnEnterLiquidFunc ??= Torque3D.LookupEngineFunction<_OnEnterLiquid>("cbPlayerData_onEnterLiquid");

                return _OnEnterLiquidFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DoDismount__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DoDismount(IntPtr _this, DoDismount__Args args);
            private static _DoDismount _DoDismountFunc;
            internal static _DoDismount DoDismount() {
               _DoDismountFunc ??= Torque3D.LookupEngineFunction<_DoDismount>("cbPlayerData_doDismount");

                return _DoDismountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStopSprintMotion__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStopSprintMotion(IntPtr _this, OnStopSprintMotion__Args args);
            private static _OnStopSprintMotion _OnStopSprintMotionFunc;
            internal static _OnStopSprintMotion OnStopSprintMotion() {
               _OnStopSprintMotionFunc ??= Torque3D.LookupEngineFunction<_OnStopSprintMotion>("cbPlayerData_onStopSprintMotion");

                return _OnStopSprintMotionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStartSprintMotion__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStartSprintMotion(IntPtr _this, OnStartSprintMotion__Args args);
            private static _OnStartSprintMotion _OnStartSprintMotionFunc;
            internal static _OnStartSprintMotion OnStartSprintMotion() {
               _OnStartSprintMotionFunc ??= Torque3D.LookupEngineFunction<_OnStartSprintMotion>("cbPlayerData_onStartSprintMotion");

                return _OnStartSprintMotionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStopSwim__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStopSwim(IntPtr _this, OnStopSwim__Args args);
            private static _OnStopSwim _OnStopSwimFunc;
            internal static _OnStopSwim OnStopSwim() {
               _OnStopSwimFunc ??= Torque3D.LookupEngineFunction<_OnStopSwim>("cbPlayerData_onStopSwim");

                return _OnStopSwimFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStartSwim__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStartSwim(IntPtr _this, OnStartSwim__Args args);
            private static _OnStartSwim _OnStartSwimFunc;
            internal static _OnStartSwim OnStartSwim() {
               _OnStartSwimFunc ??= Torque3D.LookupEngineFunction<_OnStartSwim>("cbPlayerData_onStartSwim");

                return _OnStartSwimFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnPoseChange__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string oldPose;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newPose;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnPoseChange(IntPtr _this, OnPoseChange__Args args);
            private static _OnPoseChange _OnPoseChangeFunc;
            internal static _OnPoseChange OnPoseChange() {
               _OnPoseChangeFunc ??= Torque3D.LookupEngineFunction<_OnPoseChange>("cbPlayerData_onPoseChange");

                return _OnPoseChangeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnPlayerData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnPlayerData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Called when the player leaves the mission area.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        /// <see cref="MissionArea" />
        public virtual void OnLeaveMissionArea(Player obj) {
             InternalUnsafeMethods.OnLeaveMissionArea__Args _args = new InternalUnsafeMethods.OnLeaveMissionArea__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnLeaveMissionArea()(ObjectPtr, _args);
        }

        /// <summary>Called when the player enters the mission area.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        /// <see cref="MissionArea" />
        public virtual void OnEnterMissionArea(Player obj) {
             InternalUnsafeMethods.OnEnterMissionArea__Args _args = new InternalUnsafeMethods.OnEnterMissionArea__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnEnterMissionArea()(ObjectPtr, _args);
        }

        /// <summary>Called on the server when a scripted animation completes.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        /// <see cref="Player::setActionThread() for setting a scripted animation and its 'hold' parameter to determine if this callback is used." />
        public virtual void AnimationDone(Player obj) {
             InternalUnsafeMethods.AnimationDone__Args _args = new InternalUnsafeMethods.AnimationDone__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.AnimationDone()(ObjectPtr, _args);
        }

        /// <summary>Called when the player leaves a liquid.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        /// <param name="type">The type of liquid the player has left</param>
        public virtual void OnLeaveLiquid(Player obj, string type) {
             InternalUnsafeMethods.OnLeaveLiquid__Args _args = new InternalUnsafeMethods.OnLeaveLiquid__Args() {
                obj = obj.ObjectPtr,
                type = type,
             };
             InternalUnsafeMethods.OnLeaveLiquid()(ObjectPtr, _args);
        }

        /// <summary>Called when the player enters a liquid.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        /// <param name="coverage">Percentage of the player's bounding box covered by the liquid</param>
        /// <param name="type">The type of liquid the player has entered</param>
        public virtual void OnEnterLiquid(Player obj, float coverage, string type) {
             InternalUnsafeMethods.OnEnterLiquid__Args _args = new InternalUnsafeMethods.OnEnterLiquid__Args() {
                obj = obj.ObjectPtr,
                coverage = coverage,
                type = type,
             };
             InternalUnsafeMethods.OnEnterLiquid()(ObjectPtr, _args);
        }

        /// <summary>Called when attempting to dismount the player from a vehicle.</summary>
        /// <description>
        /// It is up to the doDismount() method to actually perform the dismount.  Often there are some conditions that prevent this, such as the vehicle moving too fast.
        /// </description>
        /// <param name="obj">The Player object</param>
        public virtual void DoDismount(Player obj) {
             InternalUnsafeMethods.DoDismount__Args _args = new InternalUnsafeMethods.DoDismount__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.DoDismount()(ObjectPtr, _args);
        }

        /// <summary>Called when the player stops moving while in a Sprint pose.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        public virtual void OnStopSprintMotion(Player obj) {
             InternalUnsafeMethods.OnStopSprintMotion__Args _args = new InternalUnsafeMethods.OnStopSprintMotion__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnStopSprintMotion()(ObjectPtr, _args);
        }

        /// <summary>Called when the player starts moving while in a Sprint pose.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        public virtual void OnStartSprintMotion(Player obj) {
             InternalUnsafeMethods.OnStartSprintMotion__Args _args = new InternalUnsafeMethods.OnStartSprintMotion__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnStartSprintMotion()(ObjectPtr, _args);
        }

        /// <summary>Called when the player stops swimming.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        public virtual void OnStopSwim(Player obj) {
             InternalUnsafeMethods.OnStopSwim__Args _args = new InternalUnsafeMethods.OnStopSwim__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnStopSwim()(ObjectPtr, _args);
        }

        /// <summary>Called when the player starts swimming.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        public virtual void OnStartSwim(Player obj) {
             InternalUnsafeMethods.OnStartSwim__Args _args = new InternalUnsafeMethods.OnStartSwim__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnStartSwim()(ObjectPtr, _args);
        }

        /// <summary>Called when the player changes poses.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">The Player object</param>
        /// <param name="oldPose">The pose the player is switching from.</param>
        /// <param name="newPose">The pose the player is switching to.</param>
        public virtual void OnPoseChange(Player obj, string oldPose, string newPose) {
             InternalUnsafeMethods.OnPoseChange__Args _args = new InternalUnsafeMethods.OnPoseChange__Args() {
                obj = obj.ObjectPtr,
                oldPose = oldPose,
                newPose = newPose,
             };
             InternalUnsafeMethods.OnPoseChange()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the PlayerData class.
        /// </description>
        /// <returns>The type info object for PlayerData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Radius around the player to collide with Items in the scene (on server).</summary>
        /// <description>
        /// Internally the pickupRadius is added to the larger side of the initial bounding box to determine the actual distance, to a maximum of 2 times the bounding box size.  The initial bounding box is that used for the root pose, and therefore doesn't take into account the change in pose.
        /// </description>
        /// </value>
        public float PickupRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pickupRadius"));
            set => SetFieldValue("pickupRadius", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum time scale for action animations.</summary>
        /// <description>
        /// If an action animation has a defined ground frame, it is automatically scaled to match the player's ground velocity.  This field limits the maximum time scale used even if the player's velocity exceeds it.
        /// </description>
        /// </value>
        public float MaxTimeScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxTimeScale"));
            set => SetFieldValue("maxTimeScale", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Flag controlling whether to render the player shape in first person view.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public bool RenderFirstPerson {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderFirstPerson"));
            set => SetFieldValue("renderFirstPerson", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Forces shadows to be rendered in first person when renderFirstPerson is disabled.  Defaults to false.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public bool FirstPersonShadows {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("firstPersonShadows"));
            set => SetFieldValue("firstPersonShadows", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Lowest angle (in radians) the player can look.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> An angle of zero is straight ahead, with positive up and negative down.</remarks>
        /// </value>
        public float MinLookAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minLookAngle"));
            set => SetFieldValue("minLookAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Highest angle (in radians) the player can look.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> An angle of zero is straight ahead, with positive up and negative down.</remarks>
        /// </value>
        public float MaxLookAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxLookAngle"));
            set => SetFieldValue("maxLookAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Defines the maximum left and right angles (in radians) the player can look in freelook mode.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxFreelookAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxFreelookAngle"));
            set => SetFieldValue("maxFreelookAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum height the player can step up.</summary>
        /// <description>
        /// The player will automatically step onto changes in ground height less than maxStepHeight.  The player will collide with ground height changes greater than this.
        /// </description>
        /// </value>
        public float MaxStepHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxStepHeight"));
            set => SetFieldValue("maxStepHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Force used to accelerate the player when running.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float RunForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("runForce"));
            set => SetFieldValue("runForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Energy value drained each tick that the player is moving.</summary>
        /// <description>
        /// The player will not be able to move when his energy falls below minRunEnergy.
        /// </description>
        /// <remarks> Setting this to zero will disable any energy drain.
        /// </remarks>
        /// <see cref="minRunEnergy" />
        /// </value>
        public float RunEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("runEnergyDrain"));
            set => SetFieldValue("runEnergyDrain", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum energy level required to run or swim.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="runEnergyDrain" />
        /// </value>
        public float MinRunEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minRunEnergy"));
            set => SetFieldValue("minRunEnergy", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum forward speed when running.</summary>
        /// </value>
        public float MaxForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxForwardSpeed"));
            set => SetFieldValue("maxForwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum backward speed when running.</summary>
        /// </value>
        public float MaxBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxBackwardSpeed"));
            set => SetFieldValue("maxBackwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum sideways speed when running.</summary>
        /// </value>
        public float MaxSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSideSpeed"));
            set => SetFieldValue("maxSideSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum angle from vertical (in degrees) the player can run up.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float RunSurfaceAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("runSurfaceAngle"));
            set => SetFieldValue("runSurfaceAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum impact speed to apply falling damage.</summary>
        /// <description>
        /// This field also sets the minimum speed for the onImpact callback to be invoked.
        /// </description>
        /// <see cref="ShapeBaseData::onImpact()" />
        /// </value>
        public float MinImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minImpactSpeed"));
            set => SetFieldValue("minImpactSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum impact speed to apply non-falling damage.</summary>
        /// <description>
        /// This field also sets the minimum speed for the onLateralImpact callback to be invoked.
        /// </description>
        /// <see cref="ShapeBaseData::onLateralImpact()" />
        /// </value>
        public float MinLateralImpactSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minLateralImpactSpeed"));
            set => SetFieldValue("minLateralImpactSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum horizontal speed.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> This limit is only enforced if the player's horizontal speed exceeds horizResistSpeed.
        /// </remarks>
        /// <see cref="horizResistSpeed" />
        /// <see cref="horizResistFactor" />
        /// </value>
        public float HorizMaxSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("horizMaxSpeed"));
            set => SetFieldValue("horizMaxSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Horizontal speed at which resistence will take place.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="horizMaxSpeed" />
        /// <see cref="horizResistFactor" />
        /// </value>
        public float HorizResistSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("horizResistSpeed"));
            set => SetFieldValue("horizResistSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Factor of resistence once horizResistSpeed has been reached.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="horizMaxSpeed" />
        /// <see cref="horizResistSpeed" />
        /// </value>
        public float HorizResistFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("horizResistFactor"));
            set => SetFieldValue("horizResistFactor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum upwards speed.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> This limit is only enforced if the player's upward speed exceeds upResistSpeed.
        /// </remarks>
        /// <see cref="upResistSpeed" />
        /// <see cref="upResistFactor" />
        /// </value>
        public float UpMaxSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("upMaxSpeed"));
            set => SetFieldValue("upMaxSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Upwards speed at which resistence will take place.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="upMaxSpeed" />
        /// <see cref="upResistFactor" />
        /// </value>
        public float UpResistSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("upResistSpeed"));
            set => SetFieldValue("upResistSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Factor of resistence once upResistSpeed has been reached.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="upMaxSpeed" />
        /// <see cref="upResistSpeed" />
        /// </value>
        public float UpResistFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("upResistFactor"));
            set => SetFieldValue("upResistFactor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Force used to accelerate the player when a jump is initiated.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float JumpForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jumpForce"));
            set => SetFieldValue("jumpForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Energy level drained each time the player jumps.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> Setting this to zero will disable any energy drain
        /// </remarks>
        /// <see cref="minJumpEnergy" />
        /// </value>
        public float JumpEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jumpEnergyDrain"));
            set => SetFieldValue("jumpEnergyDrain", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum energy level required to jump.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="jumpEnergyDrain" />
        /// </value>
        public float MinJumpEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minJumpEnergy"));
            set => SetFieldValue("minJumpEnergy", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum speed needed to jump.</summary>
        /// <description>
        /// If the player's own z velocity is greater than this, then it is used to scale the jump speed, up to maxJumpSpeed.
        /// </description>
        /// <see cref="maxJumpSpeed" />
        /// </value>
        public float MinJumpSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minJumpSpeed"));
            set => SetFieldValue("minJumpSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum vertical speed before the player can no longer jump.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxJumpSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxJumpSpeed"));
            set => SetFieldValue("maxJumpSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Angle from vertical (in degrees) where the player can jump.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float JumpSurfaceAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jumpSurfaceAngle"));
            set => SetFieldValue("jumpSurfaceAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Delay time in number of ticks ticks between jumps.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public int JumpDelay {
            get => GenericMarshal.StringTo<int>(GetFieldValue("jumpDelay"));
            set => SetFieldValue("jumpDelay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Amount of movement control the player has when in the air.</summary>
        /// <description>
        /// This is applied as a multiplier to the player's x and y motion.
        /// </description>
        /// </value>
        public float AirControl {
            get => GenericMarshal.StringTo<float>(GetFieldValue("airControl"));
            set => SetFieldValue("airControl", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Controls the direction of the jump impulse.</summary>
        /// <description>
        /// When false, jumps are always in the vertical (+Z) direction. When true jumps are in the direction of the ground normal so long as the player is not directly facing the surface.  If the player is directly facing the surface, then they will jump straight up.
        /// </description>
        /// </value>
        public bool JumpTowardsNormal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("jumpTowardsNormal"));
            set => SetFieldValue("jumpTowardsNormal", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Force used to accelerate the player when sprinting.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float SprintForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintForce"));
            set => SetFieldValue("sprintForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Energy value drained each tick that the player is sprinting.</summary>
        /// <description>
        /// The player will not be able to move when his energy falls below sprintEnergyDrain.
        /// </description>
        /// <remarks> Setting this to zero will disable any energy drain.
        /// </remarks>
        /// <see cref="minSprintEnergy" />
        /// </value>
        public float SprintEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintEnergyDrain"));
            set => SetFieldValue("sprintEnergyDrain", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum energy level required to sprint.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="sprintEnergyDrain" />
        /// </value>
        public float MinSprintEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minSprintEnergy"));
            set => SetFieldValue("minSprintEnergy", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum forward speed when sprinting.</summary>
        /// </value>
        public float MaxSprintForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSprintForwardSpeed"));
            set => SetFieldValue("maxSprintForwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum backward speed when sprinting.</summary>
        /// </value>
        public float MaxSprintBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSprintBackwardSpeed"));
            set => SetFieldValue("maxSprintBackwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum sideways speed when sprinting.</summary>
        /// </value>
        public float MaxSprintSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxSprintSideSpeed"));
            set => SetFieldValue("maxSprintSideSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Amount to scale strafing motion vector while sprinting.</summary>
        /// </value>
        public float SprintStrafeScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintStrafeScale"));
            set => SetFieldValue("sprintStrafeScale", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Amount to scale yaw motion while sprinting.</summary>
        /// </value>
        public float SprintYawScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintYawScale"));
            set => SetFieldValue("sprintYawScale", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Amount to scale pitch motion while sprinting.</summary>
        /// </value>
        public float SprintPitchScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sprintPitchScale"));
            set => SetFieldValue("sprintPitchScale", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Can the player jump while sprinting.</summary>
        /// </value>
        public bool SprintCanJump {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("sprintCanJump"));
            set => SetFieldValue("sprintCanJump", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Force used to accelerate the player when swimming.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float SwimForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("swimForce"));
            set => SetFieldValue("swimForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum forward speed when underwater.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxUnderwaterForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxUnderwaterForwardSpeed"));
            set => SetFieldValue("maxUnderwaterForwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum backward speed when underwater.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxUnderwaterBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxUnderwaterBackwardSpeed"));
            set => SetFieldValue("maxUnderwaterBackwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum sideways speed when underwater.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxUnderwaterSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxUnderwaterSideSpeed"));
            set => SetFieldValue("maxUnderwaterSideSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Force used to accelerate the player when crouching.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float CrouchForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("crouchForce"));
            set => SetFieldValue("crouchForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum forward speed when crouching.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxCrouchForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxCrouchForwardSpeed"));
            set => SetFieldValue("maxCrouchForwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum backward speed when crouching.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxCrouchBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxCrouchBackwardSpeed"));
            set => SetFieldValue("maxCrouchBackwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum sideways speed when crouching.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxCrouchSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxCrouchSideSpeed"));
            set => SetFieldValue("maxCrouchSideSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Force used to accelerate the player when prone (laying down).</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float ProneForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("proneForce"));
            set => SetFieldValue("proneForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum forward speed when prone (laying down).</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxProneForwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxProneForwardSpeed"));
            set => SetFieldValue("maxProneForwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum backward speed when prone (laying down).</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxProneBackwardSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxProneBackwardSpeed"));
            set => SetFieldValue("maxProneBackwardSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum sideways speed when prone (laying down).</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float MaxProneSideSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxProneSideSpeed"));
            set => SetFieldValue("maxProneSideSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Force used to accelerate the player when a jet jump is initiated.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float JetJumpForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetJumpForce"));
            set => SetFieldValue("jetJumpForce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Energy level drained each time the player jet jumps.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> Setting this to zero will disable any energy drain
        /// </remarks>
        /// <see cref="jetMinJumpEnergy" />
        /// </value>
        public float JetJumpEnergyDrain {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetJumpEnergyDrain"));
            set => SetFieldValue("jetJumpEnergyDrain", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum energy level required to jet jump.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="jetJumpEnergyDrain" />
        /// </value>
        public float JetMinJumpEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetMinJumpEnergy"));
            set => SetFieldValue("jetMinJumpEnergy", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum speed needed to jet jump.</summary>
        /// <description>
        /// If the player's own z velocity is greater than this, then it is used to scale the jet jump speed, up to jetMaxJumpSpeed.
        /// </description>
        /// <see cref="jetMaxJumpSpeed" />
        /// </value>
        public float JetMinJumpSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetMinJumpSpeed"));
            set => SetFieldValue("jetMinJumpSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum vertical speed before the player can no longer jet jump.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float JetMaxJumpSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetMaxJumpSpeed"));
            set => SetFieldValue("jetMaxJumpSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Angle from vertical (in degrees) where the player can jet jump.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float JetJumpSurfaceAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("jetJumpSurfaceAngle"));
            set => SetFieldValue("jetJumpSurfaceAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Downward speed at which we consider the player falling.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float FallingSpeedThreshold {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fallingSpeedThreshold"));
            set => SetFieldValue("fallingSpeedThreshold", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Number of ticks for the player to recover from falling.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public int RecoverDelay {
            get => GenericMarshal.StringTo<int>(GetFieldValue("recoverDelay"));
            set => SetFieldValue("recoverDelay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Scale factor applied to runForce while in the recover state.</summary>
        /// <description>
        /// This can be used to temporarily slow the player's movement after a fall, or prevent the player from moving at all if set to zero.
        /// </description>
        /// </value>
        public float RecoverRunForceScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("recoverRunForceScale"));
            set => SetFieldValue("recoverRunForceScale", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Time of land sequence play back when using new recover system.</summary>
        /// <description>
        /// If greater than 0 then the legacy fall recovery system will be bypassed in favour of just playing the player's land sequence.  The time to recover from a fall then becomes this parameter's time and the land sequence's playback will be scaled to match.
        /// </description>
        /// <see cref="transitionToLand" />
        /// </value>
        public float LandSequenceTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("landSequenceTime"));
            set => SetFieldValue("landSequenceTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>When going from a fall to a land, should we transition between the two.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> Only takes affect when landSequenceTime is greater than 0.
        /// </remarks>
        /// <see cref="landSequenceTime" />
        /// </value>
        public bool TransitionToLand {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("transitionToLand"));
            set => SetFieldValue("transitionToLand", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Size of the bounding box used by the player for collision.</summary>
        /// <description>
        /// Dimensions are given as "width depth height".
        /// </description>
        /// </value>
        public Point3F BoundingBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("boundingBox"));
            set => SetFieldValue("boundingBox", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Collision bounding box used when the player is crouching.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="boundingBox" />
        /// </value>
        public Point3F CrouchBoundingBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("crouchBoundingBox"));
            set => SetFieldValue("crouchBoundingBox", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Collision bounding box used when the player is prone (laying down).</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="boundingBox" />
        /// </value>
        public Point3F ProneBoundingBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("proneBoundingBox"));
            set => SetFieldValue("proneBoundingBox", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Collision bounding box used when the player is swimming.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="boundingBox" />
        /// </value>
        public Point3F SwimBoundingBox {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("swimBoundingBox"));
            set => SetFieldValue("swimBoundingBox", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Percentage of the player's bounding box height that represents the head.</summary>
        /// <description>
        /// Used when computing the damage location.
        /// </description>
        /// <see cref="Player::getDamageLocation" />
        /// </value>
        public float BoxHeadPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadPercentage"));
            set => SetFieldValue("boxHeadPercentage", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Percentage of the player's bounding box height that represents the torso.</summary>
        /// <description>
        /// Used when computing the damage location.
        /// </description>
        /// <see cref="Player::getDamageLocation" />
        /// </value>
        public float BoxTorsoPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxTorsoPercentage"));
            set => SetFieldValue("boxTorsoPercentage", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Percentage of the player's bounding box width that represents the left side of the head.</summary>
        /// <description>
        /// Used when computing the damage location.
        /// </description>
        /// <see cref="Player::getDamageLocation" />
        /// </value>
        public float BoxHeadLeftPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadLeftPercentage"));
            set => SetFieldValue("boxHeadLeftPercentage", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Percentage of the player's bounding box width that represents the right side of the head.</summary>
        /// <description>
        /// Used when computing the damage location.
        /// </description>
        /// <see cref="Player::getDamageLocation" />
        /// </value>
        public float BoxHeadRightPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadRightPercentage"));
            set => SetFieldValue("boxHeadRightPercentage", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Percentage of the player's bounding box depth that represents the back side of the head.</summary>
        /// <description>
        /// Used when computing the damage location.
        /// </description>
        /// <see cref="Player::getDamageLocation" />
        /// </value>
        public float BoxHeadBackPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadBackPercentage"));
            set => SetFieldValue("boxHeadBackPercentage", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Percentage of the player's bounding box depth that represents the front side of the head.</summary>
        /// <description>
        /// Used when computing the damage location.
        /// </description>
        /// <see cref="Player::getDamageLocation" />
        /// </value>
        public float BoxHeadFrontPercentage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("boxHeadFrontPercentage"));
            set => SetFieldValue("boxHeadFrontPercentage", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Particle emitter used to generate footpuffs (particles created as the player walks along the ground).</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> The generation of foot puffs requires the appropriate triggeres to be defined in the player's animation sequences.  Without these, no foot puffs will be generated.
        /// </remarks>
        /// </value>
        public ParticleEmitterData FootPuffEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("footPuffEmitter"));
            set => SetFieldValue("footPuffEmitter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Number of footpuff particles to generate each step.</summary>
        /// <description>
        /// Each foot puff is randomly placed within the defined foot puff radius.  This includes having footPuffNumParts set to one.
        /// </description>
        /// <see cref="footPuffRadius" />
        /// </value>
        public int FootPuffNumParts {
            get => GenericMarshal.StringTo<int>(GetFieldValue("footPuffNumParts"));
            set => SetFieldValue("footPuffNumParts", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Particle creation radius for footpuff particles.</summary>
        /// <description>
        /// This is applied to each foot puff particle, even if footPuffNumParts is set to one.  So set this value to zero if you want a single foot puff placed at exactly the same location under the player each time.
        /// </description>
        /// </value>
        public float FootPuffRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("footPuffRadius"));
            set => SetFieldValue("footPuffRadius", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Emitter used to generate dust particles.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> Currently unused.</remarks>
        /// </value>
        public ParticleEmitterData DustEmitter {
            get => GenericMarshal.StringTo<ParticleEmitterData>(GetFieldValue("dustEmitter"));
            set => SetFieldValue("dustEmitter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Decal to place on the ground for player footsteps.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public DecalData DecalData {
            get => GenericMarshal.StringTo<DecalData>(GetFieldValue("DecalData"));
            set => SetFieldValue("DecalData", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Distance from the center of the model to the right foot.</summary>
        /// <description>
        /// While this defines the distance to the right foot, it is also used to place the left foot decal as well.  Just on the opposite side of the player.
        /// </description>
        /// </value>
        public float DecalOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("decalOffset"));
            set => SetFieldValue("decalOffset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string FootSoftFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootSoftFile"));
            set => SetFieldValue("FootSoftFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string FootSoftAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootSoftAsset"));
            set => SetFieldValue("FootSoftAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string FootHardFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootHardFile"));
            set => SetFieldValue("FootHardFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string FootHardAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootHardAsset"));
            set => SetFieldValue("FootHardAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string FootMetalFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootMetalFile"));
            set => SetFieldValue("FootMetalFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string FootMetalAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootMetalAsset"));
            set => SetFieldValue("FootMetalAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string FootSnowFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootSnowFile"));
            set => SetFieldValue("FootSnowFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string FootSnowAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootSnowAsset"));
            set => SetFieldValue("FootSnowAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string FootShallowSplashFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootShallowSplashFile"));
            set => SetFieldValue("FootShallowSplashFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string FootShallowSplashAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootShallowSplashAsset"));
            set => SetFieldValue("FootShallowSplashAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string FootWadingFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootWadingFile"));
            set => SetFieldValue("FootWadingFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string FootWadingAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootWadingAsset"));
            set => SetFieldValue("FootWadingAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string FootUnderWaterFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootUnderWaterFile"));
            set => SetFieldValue("FootUnderWaterFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string FootUnderWaterAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootUnderWaterAsset"));
            set => SetFieldValue("FootUnderWaterAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string FootBubblesFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootBubblesFile"));
            set => SetFieldValue("FootBubblesFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string FootBubblesAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("FootBubblesAsset"));
            set => SetFieldValue("FootBubblesAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string MoveBubblesFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("MoveBubblesFile"));
            set => SetFieldValue("MoveBubblesFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string MoveBubblesAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("MoveBubblesAsset"));
            set => SetFieldValue("MoveBubblesAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string WaterBreathFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("WaterBreathFile"));
            set => SetFieldValue("WaterBreathFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string WaterBreathAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("WaterBreathAsset"));
            set => SetFieldValue("WaterBreathAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string ImpactSoftFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactSoftFile"));
            set => SetFieldValue("ImpactSoftFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string ImpactSoftAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactSoftAsset"));
            set => SetFieldValue("ImpactSoftAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string ImpactHardFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactHardFile"));
            set => SetFieldValue("ImpactHardFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string ImpactHardAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactHardAsset"));
            set => SetFieldValue("ImpactHardAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string ImpactMetalFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactMetalFile"));
            set => SetFieldValue("ImpactMetalFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string ImpactMetalAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactMetalAsset"));
            set => SetFieldValue("ImpactMetalAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string ImpactSnowFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactSnowFile"));
            set => SetFieldValue("ImpactSnowFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string ImpactSnowAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactSnowAsset"));
            set => SetFieldValue("ImpactSnowAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string ImpactWaterEasyFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactWaterEasyFile"));
            set => SetFieldValue("ImpactWaterEasyFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string ImpactWaterEasyAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactWaterEasyAsset"));
            set => SetFieldValue("ImpactWaterEasyAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string ImpactWaterMediumFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactWaterMediumFile"));
            set => SetFieldValue("ImpactWaterMediumFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string ImpactWaterMediumAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactWaterMediumAsset"));
            set => SetFieldValue("ImpactWaterMediumAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string ImpactWaterHardFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactWaterHardFile"));
            set => SetFieldValue("ImpactWaterHardFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string ImpactWaterHardAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ImpactWaterHardAsset"));
            set => SetFieldValue("ImpactWaterHardAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSound"Sounds related to player interaction."
        /// </description>
        /// </value>
        public string ExitWaterFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ExitWaterFile"));
            set => SetFieldValue("ExitWaterFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// PlayerSoundasset reference.
        /// </description>
        /// </value>
        public string ExitWaterAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ExitWaterAsset"));
            set => SetFieldValue("ExitWaterAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>SplashData datablock used to create splashes when the player moves through water.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public SplashData Splash {
            get => GenericMarshal.StringTo<SplashData>(GetFieldValue("Splash"));
            set => SetFieldValue("Splash", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum velocity when moving through water to generate splashes.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float SplashVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashVelocity"));
            set => SetFieldValue("splashVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum angle (in degrees) from pure vertical movement in water to generate splashes.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float SplashAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashAngle"));
            set => SetFieldValue("splashAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Multipled by speed to determine the number of splash particles to generate.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float SplashFreqMod {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashFreqMod"));
            set => SetFieldValue("splashFreqMod", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum speed to generate splash particles.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float SplashVelEpsilon {
            get => GenericMarshal.StringTo<float>(GetFieldValue("splashVelEpsilon"));
            set => SetFieldValue("splashVelEpsilon", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Time in seconds to generate bubble particles after entering the water.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float BubbleEmitTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bubbleEmitTime"));
            set => SetFieldValue("bubbleEmitTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Particle emitters used to generate splash particles.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public DynamicFieldVector<ParticleEmitterData> SplashEmitter {
            get => new DynamicFieldVector<ParticleEmitterData>(
                    this, 
                    "splashEmitter", 
                    3, 
                    val => GenericMarshal.StringTo<ParticleEmitterData>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>Water coverage level to choose between FootShallowSound and FootWadingSound.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="FootShallowSound" />
        /// <see cref="FootWadingSound" />
        /// </value>
        public float FootstepSplashHeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("footstepSplashHeight"));
            set => SetFieldValue("footstepSplashHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum velocity when entering the water for choosing between the impactWaterEasy and impactWaterMedium sounds to play.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="impactWaterEasy" />
        /// <see cref="impactWaterMedium" />
        /// </value>
        public float MediumSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mediumSplashSoundVelocity"));
            set => SetFieldValue("mediumSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum velocity when entering the water for choosing between the impactWaterMedium and impactWaterHard sound to play.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="impactWaterMedium" />
        /// <see cref="impactWaterHard" />
        /// </value>
        public float HardSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("hardSplashSoundVelocity"));
            set => SetFieldValue("hardSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum velocity when leaving the water for the exitingWater sound to play.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="exitingWater" />
        /// </value>
        public float ExitSplashSoundVelocity {
            get => GenericMarshal.StringTo<float>(GetFieldValue("exitSplashSoundVelocity"));
            set => SetFieldValue("exitSplashSoundVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Minimum falling impact speed to apply damage and initiate the camera shaking effect.</summary>
        /// <description>
        /// 
        /// </description>
        /// </value>
        public float GroundImpactMinSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("groundImpactMinSpeed"));
            set => SetFieldValue("groundImpactMinSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Frequency of the camera shake effect after falling.</summary>
        /// <description>
        /// This is how fast to shake the camera.
        /// </description>
        /// </value>
        public Point3F GroundImpactShakeFreq {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("groundImpactShakeFreq"));
            set => SetFieldValue("groundImpactShakeFreq", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Amplitude of the camera shake effect after falling.</summary>
        /// <description>
        /// This is how much to shake the camera.
        /// </description>
        /// </value>
        public Point3F GroundImpactShakeAmp {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("groundImpactShakeAmp"));
            set => SetFieldValue("groundImpactShakeAmp", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Duration (in seconds) of the camera shake effect after falling.</summary>
        /// <description>
        /// This is how long to shake the camera.
        /// </description>
        /// </value>
        public float GroundImpactShakeDuration {
            get => GenericMarshal.StringTo<float>(GetFieldValue("groundImpactShakeDuration"));
            set => SetFieldValue("groundImpactShakeDuration", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Falloff factor of the camera shake effect after falling.</summary>
        /// <description>
        /// This is how to fade the camera shake over the duration.
        /// </description>
        /// </value>
        public float GroundImpactShakeFalloff {
            get => GenericMarshal.StringTo<float>(GetFieldValue("groundImpactShakeFalloff"));
            set => SetFieldValue("groundImpactShakeFalloff", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Specifies the type of physics used by the player.</summary>
        /// <description>
        /// This depends on the physics module used.  An example is 'Capsule'.
        /// </description>
        /// <remarks> Not current used.
        /// </remarks>
        /// </value>
        public string PhysicsPlayerType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("physicsPlayerType"));
            set => SetFieldValue("physicsPlayerType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Optional prefix to all mounted image animation sequences in first person.</summary>
        /// <description>
        /// This defines a prefix that will be added when looking up mounted image animation sequences while in first person.  It allows for the customization of a first person image based on the type of player.
        /// </description>
        /// </value>
        public string ImageAnimPrefixFP {
            get => GenericMarshal.StringTo<string>(GetFieldValue("imageAnimPrefixFP"));
            set => SetFieldValue("imageAnimPrefixFP", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>File name of this player's shape that will be used in conjunction with the corresponding mounted image.</summary>
        /// <description>
        /// These optional parameters correspond to each mounted image slot to indicate a shape that is rendered in addition to the mounted image shape.  Typically these are a player's arms (or arm) that is animated along with the mounted image's state animation sequences.
        /// </description>
        /// </value>
        public DynamicFieldVector<string> ShapeNameFP {
            get => new DynamicFieldVector<string>(
                    this, 
                    "shapeNameFP", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// ShapeFP"
        /// </description>
        /// <summary>File name of this player's shape that will be used in conjunction with the corresponding mounted image.\n\n" "These optional parameters correspond to each mounted image slot to indicate a shape that is rendered " "in addition to the mounted image shape.  Typically these are a player's arms (or arm) that is " "animated along with the mounted image's state animation sequences.\n"</summary>
        /// </value>
        public DynamicFieldVector<string> ShapeFPFile {
            get => new DynamicFieldVector<string>(
                    this, 
                    "ShapeFPFile", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// ShapeFPasset reference.
        /// </description>
        /// </value>
        public DynamicFieldVector<string> ShapeFPAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "ShapeFPAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>Optional prefix to all mounted image animation sequences in third person.</summary>
        /// <description>
        /// This defines a prefix that will be added when looking up mounted image animation sequences while in third person.  It allows for the customization of a third person image based on the type of player.
        /// </description>
        /// </value>
        public string ImageAnimPrefix {
            get => GenericMarshal.StringTo<string>(GetFieldValue("imageAnimPrefix"));
            set => SetFieldValue("imageAnimPrefix", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Allow mounted images to request a sequence be played on the Player.</summary>
        /// <description>
        /// When true a new thread is added to the player to allow for mounted images to request a sequence be played on the player through the image's state machine.  It is only optional so that we don't create a TSThread on the player if we don't need to.
        /// </description>
        /// </value>
        public bool AllowImageStateAnimation {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowImageStateAnimation"));
            set => SetFieldValue("allowImageStateAnimation", GenericMarshal.ToString(value));
        }
    }
}
