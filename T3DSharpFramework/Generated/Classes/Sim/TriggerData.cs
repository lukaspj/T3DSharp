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
    /// <summary>Defines shared properties for Trigger objects.</summary>
    /// <description>
    /// The primary focus of the TriggerData datablock is the callbacks it provides when an object is within or leaves the Trigger bounds.
    /// </description>
    /// <see cref="Trigger." />
    public class TriggerData : GameBaseData {
        public TriggerData(bool pRegister = false)
            : base(pRegister) {
        }

        public TriggerData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public TriggerData(string pName)
            : this(pName, false) {
        }

        public TriggerData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public TriggerData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public TriggerData(SimObject pObj)
            : base(pObj) {
        }

        public TriggerData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLeaveTrigger__Args
            {
                internal IntPtr trigger;
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLeaveTrigger(IntPtr _this, OnLeaveTrigger__Args args);
            private static _OnLeaveTrigger _OnLeaveTriggerFunc;
            internal static _OnLeaveTrigger OnLeaveTrigger() {
               _OnLeaveTriggerFunc ??= Torque3D.LookupEngineFunction<_OnLeaveTrigger>("cbTriggerData_onLeaveTrigger");

                return _OnLeaveTriggerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnTickTrigger__Args
            {
                internal IntPtr trigger;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnTickTrigger(IntPtr _this, OnTickTrigger__Args args);
            private static _OnTickTrigger _OnTickTriggerFunc;
            internal static _OnTickTrigger OnTickTrigger() {
               _OnTickTriggerFunc ??= Torque3D.LookupEngineFunction<_OnTickTrigger>("cbTriggerData_onTickTrigger");

                return _OnTickTriggerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnEnterTrigger__Args
            {
                internal IntPtr trigger;
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnEnterTrigger(IntPtr _this, OnEnterTrigger__Args args);
            private static _OnEnterTrigger _OnEnterTriggerFunc;
            internal static _OnEnterTrigger OnEnterTrigger() {
               _OnEnterTriggerFunc ??= Torque3D.LookupEngineFunction<_OnEnterTrigger>("cbTriggerData_onEnterTrigger");

                return _OnEnterTriggerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnTriggerData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnTriggerData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Called when an object leaves the volume of the Trigger instance using this TriggerData.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="trigger">the Trigger instance whose volume the object left</param>
        /// <param name="obj">the object that left the volume of the Trigger instance</param>
        public virtual void OnLeaveTrigger(Trigger trigger, GameBase obj) {
             InternalUnsafeMethods.OnLeaveTrigger__Args _args = new InternalUnsafeMethods.OnLeaveTrigger__Args() {
                trigger = trigger.ObjectPtr,
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnLeaveTrigger()(ObjectPtr, _args);
        }

        /// <summary>Called every tickPeriodMS number of milliseconds (as specified in the TriggerData) whenever one or more objects are inside the volume of the trigger.</summary>
        /// <description>
        /// The Trigger has methods to retrieve the objects that are within the Trigger's bounds if you want to do something with them in this callback.
        /// </description>
        /// <param name="trigger">the Trigger instance whose volume the object is inside</param>
        /// <see cref="tickPeriodMS" />
        /// <see cref="Trigger::getNumObjects()" />
        /// <see cref="Trigger::getObject()" />
        public virtual void OnTickTrigger(Trigger trigger) {
             InternalUnsafeMethods.OnTickTrigger__Args _args = new InternalUnsafeMethods.OnTickTrigger__Args() {
                trigger = trigger.ObjectPtr,
             };
             InternalUnsafeMethods.OnTickTrigger()(ObjectPtr, _args);
        }

        /// <summary>Called when an object enters the volume of the Trigger instance using this TriggerData.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="trigger">the Trigger instance whose volume the object entered</param>
        /// <param name="obj">the object that entered the volume of the Trigger instance</param>
        public virtual void OnEnterTrigger(Trigger trigger, GameBase obj) {
             InternalUnsafeMethods.OnEnterTrigger__Args _args = new InternalUnsafeMethods.OnEnterTrigger__Args() {
                trigger = trigger.ObjectPtr,
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.OnEnterTrigger()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the TriggerData class.
        /// </description>
        /// <returns>The type info object for TriggerData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Time in milliseconds between calls to onTickTrigger() while at least one object is within a Trigger's bounds.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="onTickTrigger()" />
        /// </value>
        public int TickPeriodMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("tickPeriodMS"));
            set => SetFieldValue("tickPeriodMS", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Forces Trigger callbacks to only be called on clients.
        /// </description>
        /// </value>
        public bool ClientSide {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("clientSide"));
            set => SetFieldValue("clientSide", GenericMarshal.ToString(value));
        }
    }
}
