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
    /// <summary>A Player object not controlled by conventional input, but by an AI engine.</summary>
    /// <description>
    /// The AIPlayer provides a Player object that may be controlled from script.  You control where the player moves and how fast.  You may also set where the AIPlayer is aiming at -- either a location or another game object.
    /// 
    /// The AIPlayer class does not have a datablock of its own.  It makes use of the PlayerData datablock to define how it looks, etc.  As the AIPlayer is an extension of the Player class it can mount objects and fire weapons, or mount vehicles and drive them.
    /// 
    /// While the PlayerData datablock is used, there are a number of additional callbacks that are implemented by AIPlayer on the datablock.  These are listed here:
    /// 
    /// void onReachDestination(AIPlayer obj) 
    /// Called when the player has reached its set destination using the setMoveDestination() method.  The actual point at which this callback is called is when the AIPlayer is within the mMoveTolerance of the defined destination.
    /// 
    /// void onMoveStuck(AIPlayer obj) 
    /// While in motion, if an AIPlayer has moved less than moveStuckTolerance within a single tick, this callback is called.  From here you could choose an alternate destination to get the AIPlayer moving again.
    /// 
    /// void onTargetEnterLOS(AIPlayer obj) 
    /// When an object is being aimed at (following a call to setAimObject()) and the targeted object enters the AIPlayer's line of sight, this callback is called.  The LOS test is a ray from the AIPlayer's eye position to the center of the target's bounding box.  The LOS ray test only checks against interiors, statis shapes, and terrain.
    /// 
    /// void onTargetExitLOS(AIPlayer obj) 
    /// When an object is being aimed at (following a call to setAimObject()) and the targeted object leaves the AIPlayer's line of sight, this callback is called.  The LOS test is a ray from the AIPlayer's eye position to the center of the target's bounding box.  The LOS ray test only checks against interiors, statis shapes, and terrain.
    /// </description>
    /// <code>
    /// // Create the demo player object
    /// %player = new AiPlayer()
    /// {
    ///   dataBlock = DemoPlayer;
    ///   path = "";
    /// };
    /// </code>
    /// <see cref="Player for a list of all inherited functions, variables, and base description" />
    public class AIPlayer : Player {
        public AIPlayer(bool pRegister = false)
            : base(pRegister) {
        }

        public AIPlayer(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public AIPlayer(string pName)
            : this(pName, false) {
        }

        public AIPlayer(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public AIPlayer(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public AIPlayer(SimObject pObj)
            : base(pObj) {
        }

        public AIPlayer(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAiPose__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAiPose(IntPtr _this, GetAiPose__Args args);
            private static _GetAiPose _GetAiPoseFunc;
            internal static _GetAiPose GetAiPose() {
               _GetAiPoseFunc ??= Torque3D.LookupEngineFunction<_GetAiPose>("fnAIPlayer_getAiPose");

                return _GetAiPoseFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAiPose__Args
            {
                internal int pose;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAiPose(IntPtr _this, SetAiPose__Args args);
            private static _SetAiPose _SetAiPoseFunc;
            internal static _SetAiPose SetAiPose() {
               _SetAiPoseFunc ??= Torque3D.LookupEngineFunction<_SetAiPose>("fnAIPlayer_setAiPose");

                return _SetAiPoseFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTargetDistance__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.I1)]
                internal bool checkEnabled;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetTargetDistance(IntPtr _this, GetTargetDistance__Args args);
            private static _GetTargetDistance _GetTargetDistanceFunc;
            internal static _GetTargetDistance GetTargetDistance() {
               _GetTargetDistanceFunc ??= Torque3D.LookupEngineFunction<_GetTargetDistance>("fnAIPlayer_getTargetDistance");

                return _GetTargetDistanceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearMoveTriggers__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearMoveTriggers(IntPtr _this, ClearMoveTriggers__Args args);
            private static _ClearMoveTriggers _ClearMoveTriggersFunc;
            internal static _ClearMoveTriggers ClearMoveTriggers() {
               _ClearMoveTriggersFunc ??= Torque3D.LookupEngineFunction<_ClearMoveTriggers>("fnAIPlayer_clearMoveTriggers");

                return _ClearMoveTriggersFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMoveTrigger__Args
            {
                internal uint slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetMoveTrigger(IntPtr _this, GetMoveTrigger__Args args);
            private static _GetMoveTrigger _GetMoveTriggerFunc;
            internal static _GetMoveTrigger GetMoveTrigger() {
               _GetMoveTriggerFunc ??= Torque3D.LookupEngineFunction<_GetMoveTrigger>("fnAIPlayer_getMoveTrigger");

                return _GetMoveTriggerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearMoveTrigger__Args
            {
                internal uint slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearMoveTrigger(IntPtr _this, ClearMoveTrigger__Args args);
            private static _ClearMoveTrigger _ClearMoveTriggerFunc;
            internal static _ClearMoveTrigger ClearMoveTrigger() {
               _ClearMoveTriggerFunc ??= Torque3D.LookupEngineFunction<_ClearMoveTrigger>("fnAIPlayer_clearMoveTrigger");

                return _ClearMoveTriggerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMoveTrigger__Args
            {
                internal uint slot;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMoveTrigger(IntPtr _this, SetMoveTrigger__Args args);
            private static _SetMoveTrigger _SetMoveTriggerFunc;
            internal static _SetMoveTrigger SetMoveTrigger() {
               _SetMoveTriggerFunc ??= Torque3D.LookupEngineFunction<_SetMoveTrigger>("fnAIPlayer_setMoveTrigger");

                return _SetMoveTriggerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CheckInFoV__Args
            {
                internal IntPtr obj;
                internal float fov;
                [MarshalAs(UnmanagedType.I1)]
                internal bool checkEnabled;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _CheckInFoV(IntPtr _this, CheckInFoV__Args args);
            private static _CheckInFoV _CheckInFoVFunc;
            internal static _CheckInFoV CheckInFoV() {
               _CheckInFoVFunc ??= Torque3D.LookupEngineFunction<_CheckInFoV>("fnAIPlayer_checkInFoV");

                return _CheckInFoVFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CheckInLos__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.I1)]
                internal bool useMuzzle;
                [MarshalAs(UnmanagedType.I1)]
                internal bool checkEnabled;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _CheckInLos(IntPtr _this, CheckInLos__Args args);
            private static _CheckInLos _CheckInLosFunc;
            internal static _CheckInLos CheckInLos() {
               _CheckInLosFunc ??= Torque3D.LookupEngineFunction<_CheckInLos>("fnAIPlayer_checkInLos");

                return _CheckInLosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAimObject__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAimObject(IntPtr _this, GetAimObject__Args args);
            private static _GetAimObject _GetAimObjectFunc;
            internal static _GetAimObject GetAimObject() {
               _GetAimObjectFunc ??= Torque3D.LookupEngineFunction<_GetAimObject>("fnAIPlayer_getAimObject");

                return _GetAimObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAimObject__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
                internal IntPtr offset;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAimObject(IntPtr _this, SetAimObject__Args args);
            private static _SetAimObject _SetAimObjectFunc;
            internal static _SetAimObject SetAimObject() {
               _SetAimObjectFunc ??= Torque3D.LookupEngineFunction<_SetAimObject>("fnAIPlayer_setAimObject");

                return _SetAimObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAimLocation__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetAimLocation(IntPtr _this, GetAimLocation__Args args);
            private static _GetAimLocation _GetAimLocationFunc;
            internal static _GetAimLocation GetAimLocation() {
               _GetAimLocationFunc ??= Torque3D.LookupEngineFunction<_GetAimLocation>("fnAIPlayer_getAimLocation");

                return _GetAimLocationFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAimLocation__Args
            {
                internal IntPtr target;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAimLocation(IntPtr _this, SetAimLocation__Args args);
            private static _SetAimLocation _SetAimLocationFunc;
            internal static _SetAimLocation SetAimLocation() {
               _SetAimLocationFunc ??= Torque3D.LookupEngineFunction<_SetAimLocation>("fnAIPlayer_setAimLocation");

                return _SetAimLocationFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMoveDestination__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetMoveDestination(IntPtr _this, GetMoveDestination__Args args);
            private static _GetMoveDestination _GetMoveDestinationFunc;
            internal static _GetMoveDestination GetMoveDestination() {
               _GetMoveDestinationFunc ??= Torque3D.LookupEngineFunction<_GetMoveDestination>("fnAIPlayer_getMoveDestination");

                return _GetMoveDestinationFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMoveDestination__Args
            {
                internal IntPtr goal;
                [MarshalAs(UnmanagedType.I1)]
                internal bool slowDown;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMoveDestination(IntPtr _this, SetMoveDestination__Args args);
            private static _SetMoveDestination _SetMoveDestinationFunc;
            internal static _SetMoveDestination SetMoveDestination() {
               _SetMoveDestinationFunc ??= Torque3D.LookupEngineFunction<_SetMoveDestination>("fnAIPlayer_setMoveDestination");

                return _SetMoveDestinationFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMoveSpeed__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetMoveSpeed(IntPtr _this, GetMoveSpeed__Args args);
            private static _GetMoveSpeed _GetMoveSpeedFunc;
            internal static _GetMoveSpeed GetMoveSpeed() {
               _GetMoveSpeedFunc ??= Torque3D.LookupEngineFunction<_GetMoveSpeed>("fnAIPlayer_getMoveSpeed");

                return _GetMoveSpeedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMoveSpeed__Args
            {
                internal float speed;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMoveSpeed(IntPtr _this, SetMoveSpeed__Args args);
            private static _SetMoveSpeed _SetMoveSpeedFunc;
            internal static _SetMoveSpeed SetMoveSpeed() {
               _SetMoveSpeedFunc ??= Torque3D.LookupEngineFunction<_SetMoveSpeed>("fnAIPlayer_setMoveSpeed");

                return _SetMoveSpeedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearAim__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearAim(IntPtr _this, ClearAim__Args args);
            private static _ClearAim _ClearAimFunc;
            internal static _ClearAim ClearAim() {
               _ClearAimFunc ??= Torque3D.LookupEngineFunction<_ClearAim>("fnAIPlayer_clearAim");

                return _ClearAimFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Stop__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Stop(IntPtr _this, Stop__Args args);
            private static _Stop _StopFunc;
            internal static _Stop Stop() {
               _StopFunc ??= Torque3D.LookupEngineFunction<_Stop>("fnAIPlayer_stop");

                return _StopFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNavSize__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNavSize(IntPtr _this, GetNavSize__Args args);
            private static _GetNavSize _GetNavSizeFunc;
            internal static _GetNavSize GetNavSize() {
               _GetNavSizeFunc ??= Torque3D.LookupEngineFunction<_GetNavSize>("fnAIPlayer_getNavSize");

                return _GetNavSizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNavSize__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string size;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetNavSize(IntPtr _this, SetNavSize__Args args);
            private static _SetNavSize _SetNavSizeFunc;
            internal static _SetNavSize SetNavSize() {
               _SetNavSizeFunc ??= Torque3D.LookupEngineFunction<_SetNavSize>("fnAIPlayer_setNavSize");

                return _SetNavSizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNavMesh__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNavMesh(IntPtr _this, GetNavMesh__Args args);
            private static _GetNavMesh _GetNavMeshFunc;
            internal static _GetNavMesh GetNavMesh() {
               _GetNavMeshFunc ??= Torque3D.LookupEngineFunction<_GetNavMesh>("fnAIPlayer_getNavMesh");

                return _GetNavMeshFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FindNavMesh__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _FindNavMesh(IntPtr _this, FindNavMesh__Args args);
            private static _FindNavMesh _FindNavMeshFunc;
            internal static _FindNavMesh FindNavMesh() {
               _FindNavMeshFunc ??= Torque3D.LookupEngineFunction<_FindNavMesh>("fnAIPlayer_findNavMesh");

                return _FindNavMeshFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FindCover__Args
            {
                internal IntPtr from;
                internal float radius;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _FindCover(IntPtr _this, FindCover__Args args);
            private static _FindCover _FindCoverFunc;
            internal static _FindCover FindCover() {
               _FindCoverFunc ??= Torque3D.LookupEngineFunction<_FindCover>("fnAIPlayer_findCover");

                return _FindCoverFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Repath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Repath(IntPtr _this, Repath__Args args);
            private static _Repath _RepathFunc;
            internal static _Repath Repath() {
               _RepathFunc ??= Torque3D.LookupEngineFunction<_Repath>("fnAIPlayer_repath");

                return _RepathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FollowObject__Args
            {
                internal uint obj;
                internal float radius;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FollowObject(IntPtr _this, FollowObject__Args args);
            private static _FollowObject _FollowObjectFunc;
            internal static _FollowObject FollowObject() {
               _FollowObjectFunc ??= Torque3D.LookupEngineFunction<_FollowObject>("fnAIPlayer_followObject");

                return _FollowObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FollowNavPath__Args
            {
                internal uint obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FollowNavPath(IntPtr _this, FollowNavPath__Args args);
            private static _FollowNavPath _FollowNavPathFunc;
            internal static _FollowNavPath FollowNavPath() {
               _FollowNavPathFunc ??= Torque3D.LookupEngineFunction<_FollowNavPath>("fnAIPlayer_followNavPath");

                return _FollowNavPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetPathDestination__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetPathDestination(IntPtr _this, GetPathDestination__Args args);
            private static _GetPathDestination _GetPathDestinationFunc;
            internal static _GetPathDestination GetPathDestination() {
               _GetPathDestinationFunc ??= Torque3D.LookupEngineFunction<_GetPathDestination>("fnAIPlayer_getPathDestination");

                return _GetPathDestinationFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetPathDestination__Args
            {
                internal IntPtr goal;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetPathDestination(IntPtr _this, SetPathDestination__Args args);
            private static _SetPathDestination _SetPathDestinationFunc;
            internal static _SetPathDestination SetPathDestination() {
               _SetPathDestinationFunc ??= Torque3D.LookupEngineFunction<_SetPathDestination>("fnAIPlayer_setPathDestination");

                return _SetPathDestinationFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnAIPlayer_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnAIPlayer_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Get the object's current AiPose.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>StandPose=0, CrouchPose=1, PronePose=2, SprintPose=3.</returns>
        public int GetAiPose() {
             InternalUnsafeMethods.GetAiPose__Args _args = new InternalUnsafeMethods.GetAiPose__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetAiPose()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Sets the AiPose for an AI object.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="pose">StandPose=0, CrouchPose=1, PronePose=2, SprintPose=3.
        /// Uses the new AiPose variable from shapebase (as defined in its PlayerData datablock).</param>
        public void SetAiPose(int pose) {
             InternalUnsafeMethods.SetAiPose__Args _args = new InternalUnsafeMethods.SetAiPose__Args() {
                pose = pose,
             };
             InternalUnsafeMethods.SetAiPose()(ObjectPtr, _args);
        }

        /// <summary>The distance to a given object.</summary>
        /// <description>
        /// 
        /// </description>
        public float GetTargetDistance(ShapeBase obj = null, bool checkEnabled = false) {
             InternalUnsafeMethods.GetTargetDistance__Args _args = new InternalUnsafeMethods.GetTargetDistance__Args() {
                obj = obj.ObjectPtr,
                checkEnabled = checkEnabled,
             };
             float _engineResult = InternalUnsafeMethods.GetTargetDistance()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Clear ALL movement triggers on an AI object.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="setMoveTrigger()" />
        /// <see cref="getMoveTrigger()" />
        /// <see cref="clearMoveTrigger()" />
        public void ClearMoveTriggers() {
             InternalUnsafeMethods.ClearMoveTriggers__Args _args = new InternalUnsafeMethods.ClearMoveTriggers__Args() {
             };
             InternalUnsafeMethods.ClearMoveTriggers()(ObjectPtr, _args);
        }

        /// <summary>Tests if a movement trigger on an AI object is set.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="slot">The trigger slot to check.</param>
        /// <returns>a boolean indicating if the trigger is set/unset.</returns>
        /// <see cref="setMoveTrigger()" />
        /// <see cref="clearMoveTrigger()" />
        /// <see cref="clearMoveTriggers()" />
        public bool GetMoveTrigger(uint slot) {
             InternalUnsafeMethods.GetMoveTrigger__Args _args = new InternalUnsafeMethods.GetMoveTrigger__Args() {
                slot = slot,
             };
             bool _engineResult = InternalUnsafeMethods.GetMoveTrigger()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Clears a movement trigger on an AI object.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="slot">The trigger slot to set.</param>
        /// <see cref="setMoveTrigger()" />
        /// <see cref="getMoveTrigger()" />
        /// <see cref="clearMoveTriggers()" />
        public void ClearMoveTrigger(uint slot) {
             InternalUnsafeMethods.ClearMoveTrigger__Args _args = new InternalUnsafeMethods.ClearMoveTrigger__Args() {
                slot = slot,
             };
             InternalUnsafeMethods.ClearMoveTrigger()(ObjectPtr, _args);
        }

        /// <summary>Sets a movement trigger on an AI object.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="slot">The trigger slot to set.</param>
        /// <see cref="getMoveTrigger()" />
        /// <see cref="clearMoveTrigger()" />
        /// <see cref="clearMoveTriggers()" />
        public void SetMoveTrigger(uint slot) {
             InternalUnsafeMethods.SetMoveTrigger__Args _args = new InternalUnsafeMethods.SetMoveTrigger__Args() {
                slot = slot,
             };
             InternalUnsafeMethods.SetMoveTrigger()(ObjectPtr, _args);
        }

        /// <summary>Check whether an object is within a specified veiw cone.</summary>
        /// <description>
        /// 
        /// </description>
        public bool CheckInFoV(ShapeBase obj = null, float fov = 45f, bool checkEnabled = false) {
             InternalUnsafeMethods.CheckInFoV__Args _args = new InternalUnsafeMethods.CheckInFoV__Args() {
                obj = obj.ObjectPtr,
                fov = fov,
                checkEnabled = checkEnabled,
             };
             bool _engineResult = InternalUnsafeMethods.CheckInFoV()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Check whether an object is in line of sight.</summary>
        /// <description>
        /// 
        /// </description>
        public bool CheckInLos(ShapeBase obj = null, bool useMuzzle = false, bool checkEnabled = false) {
             InternalUnsafeMethods.CheckInLos__Args _args = new InternalUnsafeMethods.CheckInLos__Args() {
                obj = obj.ObjectPtr,
                useMuzzle = useMuzzle,
                checkEnabled = checkEnabled,
             };
             bool _engineResult = InternalUnsafeMethods.CheckInLos()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Gets the object the AIPlayer is targeting.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>Returns -1 if no object is being aimed at, or the SimObjectID of the object the AIPlayer is aiming at.</returns>
        /// <see cref="setAimObject()" />
        public int GetAimObject() {
             InternalUnsafeMethods.GetAimObject__Args _args = new InternalUnsafeMethods.GetAimObject__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetAimObject()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ( GameBase obj, [Point3F offset] )Sets the bot's target object. Optionally set an offset from target location.
        /// </description>
        public void SetAimObject(string objName, Point3F offset = null) {
offset = offset ?? new Point3F("0 0 0");
offset.Alloc();             InternalUnsafeMethods.SetAimObject__Args _args = new InternalUnsafeMethods.SetAimObject__Args() {
                objName = objName,
                offset = offset.internalStructPtr,
             };
             InternalUnsafeMethods.SetAimObject()(ObjectPtr, _args);
offset.Free();        }

        /// <summary>Returns the point the AIPlayer is aiming at.</summary>
        /// <description>
        /// This will reflect the position set by setAimLocation(), or the position of the object that the bot is now aiming at.  If the bot is not aiming at anything, this value will change to whatever point the bot's current line-of-sight intercepts.
        /// </description>
        /// <returns>World space coordinates of the object AI is aiming at. Formatted as "X Y Z".</returns>
        /// <see cref="setAimLocation()" />
        /// <see cref="setAimObject()" />
        public Point3F GetAimLocation() {
             InternalUnsafeMethods.GetAimLocation__Args _args = new InternalUnsafeMethods.GetAimLocation__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetAimLocation()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <summary>Tells the AIPlayer to aim at the location provided.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="target">An "x y z" position in the game world to target.</param>
        /// <see cref="getAimLocation()" />
        public void SetAimLocation(Point3F target) {
target.Alloc();             InternalUnsafeMethods.SetAimLocation__Args _args = new InternalUnsafeMethods.SetAimLocation__Args() {
                target = target.internalStructPtr,
             };
             InternalUnsafeMethods.SetAimLocation()(ObjectPtr, _args);
target.Free();        }

        /// <summary>Get the AIPlayer's current destination.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>Returns a point containing the "x y z" position of the AIPlayer's current move destination. If no move destination has yet been set, this returns "0 0 0".</returns>
        /// <see cref="setMoveDestination()" />
        public Point3F GetMoveDestination() {
             InternalUnsafeMethods.GetMoveDestination__Args _args = new InternalUnsafeMethods.GetMoveDestination__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetMoveDestination()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <summary>Tells the AI to move to the location provided</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="goal">Coordinates in world space representing location to move to.</param>
        /// <param name="slowDown">A boolean value. If set to true, the bot will slow down when it gets within 5-meters of its move destination. If false, the bot will stop abruptly when it reaches the move destination. By default, this is true.</param>
        /// <remarks> Upon reaching a move destination, the bot will clear its move destination and calls to getMoveDestination will return "0 0 0".</remarks>
        /// <see cref="getMoveDestination()" />
        public void SetMoveDestination(Point3F goal, bool slowDown = true) {
goal.Alloc();             InternalUnsafeMethods.SetMoveDestination__Args _args = new InternalUnsafeMethods.SetMoveDestination__Args() {
                goal = goal.internalStructPtr,
                slowDown = slowDown,
             };
             InternalUnsafeMethods.SetMoveDestination()(ObjectPtr, _args);
goal.Free();        }

        /// <summary>Gets the move speed of an AI object.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>A speed multiplier between 0.0 and 1.0.</returns>
        /// <see cref="setMoveSpeed()" />
        public float GetMoveSpeed() {
             InternalUnsafeMethods.GetMoveSpeed__Args _args = new InternalUnsafeMethods.GetMoveSpeed__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetMoveSpeed()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Sets the move speed for an AI object.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="speed">A speed multiplier between 0.0 and 1.0.  This is multiplied by the AIPlayer's base movement rates (as defined in its PlayerData datablock)</param>
        /// <see cref="getMoveDestination()" />
        public void SetMoveSpeed(float speed) {
             InternalUnsafeMethods.SetMoveSpeed__Args _args = new InternalUnsafeMethods.SetMoveSpeed__Args() {
                speed = speed,
             };
             InternalUnsafeMethods.SetMoveSpeed()(ObjectPtr, _args);
        }

        /// <summary>Use this to stop aiming at an object or a point.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="setAimLocation()" />
        /// <see cref="setAimObject()" />
        public void ClearAim() {
             InternalUnsafeMethods.ClearAim__Args _args = new InternalUnsafeMethods.ClearAim__Args() {
             };
             InternalUnsafeMethods.ClearAim()(ObjectPtr, _args);
        }

        /// <summary>Tells the AIPlayer to stop moving.</summary>
        /// <description>
        /// 
        /// </description>
        public void Stop() {
             InternalUnsafeMethods.Stop__Args _args = new InternalUnsafeMethods.Stop__Args() {
             };
             InternalUnsafeMethods.Stop()(ObjectPtr, _args);
        }

        /// <summary>Return the size of NavMesh this character uses for pathfinding.</summary>
        public string GetNavSize() {
             InternalUnsafeMethods.GetNavSize__Args _args = new InternalUnsafeMethods.GetNavSize__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNavSize()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Set the size of NavMesh this character uses. One of "Small", "Regular" or "Large".</summary>
        public void SetNavSize(string size) {
             InternalUnsafeMethods.SetNavSize__Args _args = new InternalUnsafeMethods.SetNavSize__Args() {
                size = size,
             };
             InternalUnsafeMethods.SetNavSize()(ObjectPtr, _args);
        }

        /// <summary>Return the NavMesh this AIPlayer is using to navigate.</summary>
        /// <description>
        /// 
        /// </description>
        public int GetNavMesh() {
             InternalUnsafeMethods.GetNavMesh__Args _args = new InternalUnsafeMethods.GetNavMesh__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetNavMesh()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Get the NavMesh object this AIPlayer is currently using.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>The ID of the NavPath object this character is using for pathfinding. This is determined by the character's location, navigation type and other factors. Returns -1 if no NavMesh is found.</returns>
        public int FindNavMesh() {
             InternalUnsafeMethods.FindNavMesh__Args _args = new InternalUnsafeMethods.FindNavMesh__Args() {
             };
             int _engineResult = InternalUnsafeMethods.FindNavMesh()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Tells the AI to find cover nearby.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="from">Location to find cover from (i.e., enemy position).</param>
        /// <param name="radius">Distance to search for cover.</param>
        /// <returns>Cover point ID if cover was found, -1 otherwise.</returns>
        public int FindCover(Point3F from, float radius) {
from.Alloc();             InternalUnsafeMethods.FindCover__Args _args = new InternalUnsafeMethods.FindCover__Args() {
                from = from.internalStructPtr,
                radius = radius,
             };
             int _engineResult = InternalUnsafeMethods.FindCover()(ObjectPtr, _args);
from.Free();             return _engineResult;
        }

        /// <summary>Tells the AI to re-plan its path. Does nothing if the character has no path, or if it is following a mission path.</summary>
        /// <description>
        /// 
        /// </description>
        public void Repath() {
             InternalUnsafeMethods.Repath__Args _args = new InternalUnsafeMethods.Repath__Args() {
             };
             InternalUnsafeMethods.Repath()(ObjectPtr, _args);
        }

        /// <summary>Tell the AIPlayer to follow another object.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">ID of the object to follow.</param>
        /// <param name="radius">Maximum distance we let the target escape to.</param>
        public void FollowObject(uint obj, float radius) {
             InternalUnsafeMethods.FollowObject__Args _args = new InternalUnsafeMethods.FollowObject__Args() {
                obj = obj,
                radius = radius,
             };
             InternalUnsafeMethods.FollowObject()(ObjectPtr, _args);
        }

        /// <summary>Tell the AIPlayer to follow a path.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="obj">ID of a NavPath object for the character to follow.</param>
        public void FollowNavPath(uint obj) {
             InternalUnsafeMethods.FollowNavPath__Args _args = new InternalUnsafeMethods.FollowNavPath__Args() {
                obj = obj,
             };
             InternalUnsafeMethods.FollowNavPath()(ObjectPtr, _args);
        }

        /// <summary>Get the AIPlayer's current pathfinding destination.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>Returns a point containing the "x y z" position of the AIPlayer's current path destination. If no path destination has yet been set, this returns "0 0 0".</returns>
        /// <see cref="setPathDestination()" />
        public Point3F GetPathDestination() {
             InternalUnsafeMethods.GetPathDestination__Args _args = new InternalUnsafeMethods.GetPathDestination__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetPathDestination()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <summary>Tells the AI to find a path to the location provided</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="goal">Coordinates in world space representing location to move to.</param>
        /// <returns>True if a path was found.</returns>
        /// <see cref="getPathDestination()" />
        /// <see cref="setMoveDestination()" />
        public bool SetPathDestination(Point3F goal) {
goal.Alloc();             InternalUnsafeMethods.SetPathDestination__Args _args = new InternalUnsafeMethods.SetPathDestination__Args() {
                goal = goal.internalStructPtr,
             };
             bool _engineResult = InternalUnsafeMethods.SetPathDestination()(ObjectPtr, _args);
goal.Free();             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the AIPlayer class.
        /// </description>
        /// <returns>The type info object for AIPlayer</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Distance from destination before stopping.</summary>
        /// <description>
        /// When the AIPlayer is moving to a given destination it will move to within this distance of the destination and then stop.  By providing this tolerance it helps the AIPlayer from never reaching its destination due to minor obstacles, rounding errors on its position calculation, etc.  By default it is set to 0.25.
        /// </description>
        /// </value>
        public float MMoveTolerance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mMoveTolerance"));
            set => SetFieldValue("mMoveTolerance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Distance tolerance on stuck check.</summary>
        /// <description>
        /// When the AIPlayer is moving to a given destination, if it ever moves less than this tolerance during a single tick, the AIPlayer is considered stuck.  At this point the onMoveStuck() callback is called on the datablock.
        /// </description>
        /// </value>
        public float MoveStuckTolerance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("moveStuckTolerance"));
            set => SetFieldValue("moveStuckTolerance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>The number of ticks to wait before testing if the AIPlayer is stuck.</summary>
        /// <description>
        /// When the AIPlayer is asked to move, this property is the number of ticks to wait before the AIPlayer starts to check if it is stuck.  This delay allows the AIPlayer to accelerate to full speed without its initial slow start being considered as stuck.
        /// </description>
        /// <remarks> Set to zero to have the stuck test start immediately.
        /// </remarks>
        /// </value>
        public int MoveStuckTestDelay {
            get => GenericMarshal.StringTo<int>(GetFieldValue("moveStuckTestDelay"));
            set => SetFieldValue("moveStuckTestDelay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Distance considered in firing range for callback purposes.</summary>
        /// </value>
        public float AttackRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("AttackRadius"));
            set => SetFieldValue("AttackRadius", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Allow the character to walk on dry land.
        /// </description>
        /// </value>
        public bool AllowWalk {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowWalk"));
            set => SetFieldValue("allowWalk", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Allow the character to use jump links.
        /// </description>
        /// </value>
        public bool AllowJump {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowJump"));
            set => SetFieldValue("allowJump", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Allow the character to use drop links.
        /// </description>
        /// </value>
        public bool AllowDrop {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowDrop"));
            set => SetFieldValue("allowDrop", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Allow the character to move in water.
        /// </description>
        /// </value>
        public bool AllowSwim {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowSwim"));
            set => SetFieldValue("allowSwim", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Allow the character to jump ledges.
        /// </description>
        /// </value>
        public bool AllowLedge {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowLedge"));
            set => SetFieldValue("allowLedge", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Allow the character to use climb links.
        /// </description>
        /// </value>
        public bool AllowClimb {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowClimb"));
            set => SetFieldValue("allowClimb", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Allow the character to use teleporters.
        /// </description>
        /// </value>
        public bool AllowTeleport {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowTeleport"));
            set => SetFieldValue("allowTeleport", GenericMarshal.ToString(value));
        }
    }
}
