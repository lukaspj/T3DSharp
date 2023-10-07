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
    /// <summary>A datablock that specifies a Projectile effect.</summary>
    /// <description>
    /// afxProjectileData inherits from ProjectileData and adds some AFX specific fields.
    /// </description>
    public class afxProjectileData : ProjectileData {
        public afxProjectileData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public afxProjectileData(string pName, bool pRegister)
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

        public afxProjectileData(string pName)
            : this(pName, false) {
        }

        public afxProjectileData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxProjectileData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxProjectileData(SimObject pObj)
            : base(pObj) {
        }

        public afxProjectileData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxProjectileData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxProjectileData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the afxProjectileData class.
        /// </description>
        /// <returns>The type info object for afxProjectileData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public bool IgnoreSourceTimeout {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreSourceTimeout"));
            set => SetFieldValue("ignoreSourceTimeout", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int DynamicCollisionMask {
            get => GenericMarshal.StringTo<int>(GetFieldValue("dynamicCollisionMask"));
            set => SetFieldValue("dynamicCollisionMask", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int StaticCollisionMask {
            get => GenericMarshal.StringTo<int>(GetFieldValue("staticCollisionMask"));
            set => SetFieldValue("staticCollisionMask", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public bool OverrideCollisionMasks {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("overrideCollisionMasks"));
            set => SetFieldValue("overrideCollisionMasks", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public string LaunchPosSpec {
            get => GenericMarshal.StringTo<string>(GetFieldValue("launchPosSpec"));
            set => SetFieldValue("launchPosSpec", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public Point3F LaunchDirBias {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("launchDirBias"));
            set => SetFieldValue("launchDirBias", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Possible values: towardPos2Constraint, orientConstraint, or launchDirField.
        /// </description>
        /// </value>
        public afxProjectile_LaunchDirType LaunchDirMethod {
            get => GenericMarshal.StringTo<afxProjectile_LaunchDirType>(GetFieldValue("launchDirMethod"));
            set => SetFieldValue("launchDirMethod", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public sbyte Networking {
            get => GenericMarshal.StringTo<sbyte>(GetFieldValue("networking"));
            set => SetFieldValue("networking", GenericMarshal.ToString(value));
        }
    }
}
