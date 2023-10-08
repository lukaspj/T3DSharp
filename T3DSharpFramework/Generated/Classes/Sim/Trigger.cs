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
    /// <summary>A Trigger is a volume of space that initiates script callbacks when objects pass through the Trigger.</summary>
    /// <description>
    /// TriggerData provides the callbacks for the Trigger when an object enters, stays inside or leaves the Trigger's volume.
    /// </description>
    /// <see cref="TriggerData" />
    public class Trigger : GameBase {
        public Trigger(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public Trigger(string pName, bool pRegister)
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

        public Trigger(string pName)
            : this(pName, false) {
        }

        public Trigger(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Trigger(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Trigger(SimObject pObj)
            : base(pObj) {
        }

        public Trigger(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetObject__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetObject(IntPtr _this, GetObject__Args args);
            private static _GetObject _GetObjectFunc;
            internal static _GetObject GetObject() {
               _GetObjectFunc ??= Torque3D.LookupEngineFunction<_GetObject>("fnTrigger_getObject");

                return _GetObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNumObjects__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNumObjects(IntPtr _this, GetNumObjects__Args args);
            private static _GetNumObjects _GetNumObjectsFunc;
            internal static _GetNumObjects GetNumObjects() {
               _GetNumObjectsFunc ??= Torque3D.LookupEngineFunction<_GetNumObjects>("fnTrigger_getNumObjects");

                return _GetNumObjectsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnRemove__Args
            {
                internal uint objectId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnRemove(IntPtr _this, OnRemove__Args args);
            private static _OnRemove _OnRemoveFunc;
            internal static _OnRemove OnRemove() {
               _OnRemoveFunc ??= Torque3D.LookupEngineFunction<_OnRemove>("cbTrigger_onRemove");

                return _OnRemoveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAdd__Args
            {
                internal uint objectId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAdd(IntPtr _this, OnAdd__Args args);
            private static _OnAdd _OnAddFunc;
            internal static _OnAdd OnAdd() {
               _OnAddFunc ??= Torque3D.LookupEngineFunction<_OnAdd>("cbTrigger_onAdd");

                return _OnAddFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnTrigger_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnTrigger_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Retrieve the requested object that is within the Trigger's bounds.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">Index of the object to get (range is 0 to getNumObjects()-1)</param>
        /// <returns>The SimObjectID of the object, or -1 if the requested index is invalid.</returns>
        /// <see cref="getNumObjects()" />
        public int GetObject(int index) {
             InternalUnsafeMethods.GetObject__Args _args = new InternalUnsafeMethods.GetObject__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetObject()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Get the number of objects that are within the Trigger's bounds.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="getObject()" />
        public int GetNumObjects() {
             InternalUnsafeMethods.GetNumObjects__Args _args = new InternalUnsafeMethods.GetNumObjects__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetNumObjects()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Called just before the Trigger is deleted.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objectId">the object id of the Trigger being deleted</param>
        public virtual void OnRemove(uint objectId) {
             InternalUnsafeMethods.OnRemove__Args _args = new InternalUnsafeMethods.OnRemove__Args() {
                objectId = objectId,
             };
             InternalUnsafeMethods.OnRemove()(ObjectPtr, _args);
        }

        /// <summary>Called when the Trigger is being created.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objectId">the object id of the Trigger being created</param>
        public virtual void OnAdd(uint objectId) {
             InternalUnsafeMethods.OnAdd__Args _args = new InternalUnsafeMethods.OnAdd__Args() {
                objectId = objectId,
             };
             InternalUnsafeMethods.OnAdd()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the Trigger class.
        /// </description>
        /// <returns>The type info object for Trigger</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Defines a non-rectangular area for the trigger.</summary>
        /// <description>
        /// Rather than the standard rectangular bounds, this optional parameter defines a quadrilateral trigger area.  The quadrilateral is defined as a corner point followed by three vectors representing the edges extending from the corner.
        /// </description>
        /// </value>
        public Polyhedron Polyhedron {
            get => GenericMarshal.StringTo<Polyhedron>(GetFieldValue("polyhedron"));
            set => SetFieldValue("polyhedron", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Do we trigger callacks just the once?
        /// </description>
        /// </value>
        public bool TripOnce {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("TripOnce"));
            set => SetFieldValue("TripOnce", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// evaluation condition to trip callbacks (true/false)
        /// </description>
        /// </value>
        public string TripCondition {
            get => GenericMarshal.StringTo<string>(GetFieldValue("TripCondition"));
            set => SetFieldValue("TripCondition", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// typemask filter
        /// </description>
        /// </value>
        public int TrippedBy {
            get => GenericMarshal.StringTo<int>(GetFieldValue("TrippedBy"));
            set => SetFieldValue("TrippedBy", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The command to execute when an object enters this trigger. Object id stored in %%obj. Maximum 1023 characters.
        /// </description>
        /// </value>
        public string EnterCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("enterCommand"));
            set => SetFieldValue("enterCommand", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The command to execute when an object leaves this trigger. Object id stored in %%obj. Maximum 1023 characters.
        /// </description>
        /// </value>
        public string LeaveCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("leaveCommand"));
            set => SetFieldValue("leaveCommand", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The command to execute while an object is inside this trigger. Maximum 1023 characters.
        /// </description>
        /// </value>
        public string TickCommand {
            get => GenericMarshal.StringTo<string>(GetFieldValue("tickCommand"));
            set => SetFieldValue("tickCommand", GenericMarshal.ToString(value));
        }
    }
}
