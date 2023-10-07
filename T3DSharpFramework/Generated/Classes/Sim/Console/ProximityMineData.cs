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
    /// <summary>Stores common properties for a ProximityMine.</summary>
    /// <description>
    /// 
    /// </description>
    /// <see cref="ProximityMine" />
    public class ProximityMineData : ItemData {
        public ProximityMineData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public ProximityMineData(string pName, bool pRegister)
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

        public ProximityMineData(string pName)
            : this(pName, false) {
        }

        public ProximityMineData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ProximityMineData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ProximityMineData(SimObject pObj)
            : base(pObj) {
        }

        public ProximityMineData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnExplode__Args
            {
                internal IntPtr obj;
                internal IntPtr pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnExplode(IntPtr _this, OnExplode__Args args);
            private static _OnExplode _OnExplodeFunc;
            internal static _OnExplode OnExplode() {
               _OnExplodeFunc ??= Torque3D.LookupEngineFunction<_OnExplode>("cbProximityMineData_onExplode");

                return _OnExplodeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnTriggered__Args
            {
                internal IntPtr obj;
                internal IntPtr target;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnTriggered(IntPtr _this, OnTriggered__Args args);
            private static _OnTriggered _OnTriggeredFunc;
            internal static _OnTriggered OnTriggered() {
               _OnTriggeredFunc ??= Torque3D.LookupEngineFunction<_OnTriggered>("cbProximityMineData_onTriggered");

                return _OnTriggeredFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnProximityMineData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnProximityMineData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Callback invoked when a ProximityMine is about to explode.
        /// </description>
        /// <param name="obj">The ProximityMine object</param>
        /// <param name="pos">The position of the mine explosion</param>
        /// <remarks> This callback is only invoked on the server.
        /// </remarks>
        /// <see cref="ProximityMine" />
        public virtual void OnExplode(ProximityMine obj, Point3F pos) {
pos.Alloc();             InternalUnsafeMethods.OnExplode__Args _args = new InternalUnsafeMethods.OnExplode__Args() {
                obj = obj.ObjectPtr,
                pos = pos.internalStructPtr,
             };
             InternalUnsafeMethods.OnExplode()(ObjectPtr, _args);
pos.Free();        }

        /// <description>
        /// Callback invoked when an object triggers the ProximityMine.
        /// </description>
        /// <param name="obj">The ProximityMine object</param>
        /// <param name="target">The object that triggered the mine</param>
        /// <remarks> This callback is only invoked on the server.
        /// </remarks>
        /// <see cref="ProximityMine" />
        public virtual void OnTriggered(ProximityMine obj, SceneObject target) {
             InternalUnsafeMethods.OnTriggered__Args _args = new InternalUnsafeMethods.OnTriggered__Args() {
                obj = obj.ObjectPtr,
                target = target.ObjectPtr,
             };
             InternalUnsafeMethods.OnTriggered()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the ProximityMineData class.
        /// </description>
        /// <returns>The type info object for ProximityMineData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// ArmSound"Arming sound for this proximity mine."
        /// </description>
        /// </value>
        public string ArmSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ArmSoundFile"));
            set => SetFieldValue("ArmSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ArmSoundasset reference.
        /// </description>
        /// </value>
        public string ArmSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ArmSoundAsset"));
            set => SetFieldValue("ArmSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// TriggerSound"Arming sound for this proximity mine."
        /// </description>
        /// </value>
        public string TriggerSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("TriggerSoundFile"));
            set => SetFieldValue("TriggerSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// TriggerSoundasset reference.
        /// </description>
        /// </value>
        public string TriggerSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("TriggerSoundAsset"));
            set => SetFieldValue("TriggerSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Delay (in seconds) from when the mine is placed to when it becomes active.
        /// </description>
        /// </value>
        public float ArmingDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("armingDelay"));
            set => SetFieldValue("armingDelay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Delay (in seconds) from arming until the mine automatically triggers and explodes, even if no object has entered the trigger area.</summary>
        /// <description>
        /// Set to 0 to disable.
        /// </description>
        /// </value>
        public float AutoTriggerDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("autoTriggerDelay"));
            set => SetFieldValue("autoTriggerDelay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Controls whether the mine can be triggered by the object that owns it.</summary>
        /// <description>
        /// For example, a player could deploy mines that are only dangerous to other players and not himself.
        /// </description>
        /// </value>
        public bool TriggerOnOwner {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("triggerOnOwner"));
            set => SetFieldValue("triggerOnOwner", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Distance at which an activated mine will detect other objects and explode.
        /// </description>
        /// </value>
        public float TriggerRadius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerRadius"));
            set => SetFieldValue("triggerRadius", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Speed above which moving objects within the trigger radius will trigger the mine
        /// </description>
        /// </value>
        public float TriggerSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerSpeed"));
            set => SetFieldValue("triggerSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Delay (in seconds) from when the mine is triggered until it explodes.
        /// </description>
        /// </value>
        public float TriggerDelay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("triggerDelay"));
            set => SetFieldValue("triggerDelay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Offset from the mine's origin where the explosion emanates from.Sometimes a thrown mine may be slightly sunk into the ground.  This can be just enough to cause the explosion to occur under the ground, especially on flat ground, which can end up blocking the explosion.  This offset along the mine's 'up' normal allows you to raise the explosion origin to a better height.</summary>
        /// </value>
        public float ExplosionOffset {
            get => GenericMarshal.StringTo<float>(GetFieldValue("explosionOffset"));
            set => SetFieldValue("explosionOffset", GenericMarshal.ToString(value));
        }
    }
}
