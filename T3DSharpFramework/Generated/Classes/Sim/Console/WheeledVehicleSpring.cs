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
    /// <summary>Defines the properties of a WheeledVehicle spring.</summary>
    /// <description>
    /// 
    /// </description>
    public class WheeledVehicleSpring : SimDataBlock {
        public WheeledVehicleSpring(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public WheeledVehicleSpring(string pName, bool pRegister)
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

        public WheeledVehicleSpring(string pName)
            : this(pName, false) {
        }

        public WheeledVehicleSpring(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public WheeledVehicleSpring(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public WheeledVehicleSpring(SimObject pObj)
            : base(pObj) {
        }

        public WheeledVehicleSpring(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnWheeledVehicleSpring_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnWheeledVehicleSpring_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the WheeledVehicleSpring class.
        /// </description>
        /// <returns>The type info object for WheeledVehicleSpring</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Maximum spring length. ie. how far the wheel can extend from the root hub position.</summary>
        /// <description>
        /// This should be set to the vertical (Z) distance the hub travels in the associated spring animation.
        /// </description>
        /// </value>
        public float Length {
            get => GenericMarshal.StringTo<float>(GetFieldValue("length"));
            set => SetFieldValue("length", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Maximum spring force (when compressed to minimum length, 0).</summary>
        /// <description>
        /// Increasing this will make the vehicle suspension ride higher (for a given vehicle mass), and also make the vehicle more bouncy when landing jumps.
        /// </description>
        /// </value>
        public float Force {
            get => GenericMarshal.StringTo<float>(GetFieldValue("force"));
            set => SetFieldValue("force", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Force applied to slow changes to the extension of this spring.</summary>
        /// <description>
        /// Increasing this makes the suspension stiffer which can help stabilise bouncy vehicles.
        /// </description>
        /// </value>
        public float Damping {
            get => GenericMarshal.StringTo<float>(GetFieldValue("damping"));
            set => SetFieldValue("damping", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Force applied to equalize extension of the spring on the opposite wheel.</summary>
        /// <description>
        /// This force helps to keep the suspension balanced when opposite wheels are at different heights.
        /// </description>
        /// </value>
        public float AntiSwayForce {
            get => GenericMarshal.StringTo<float>(GetFieldValue("antiSwayForce"));
            set => SetFieldValue("antiSwayForce", GenericMarshal.ToString(value));
        }
    }
}
