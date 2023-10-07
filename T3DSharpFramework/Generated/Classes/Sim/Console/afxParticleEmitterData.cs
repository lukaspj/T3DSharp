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
    /// <summary>A base datablock inherited by AFX Particle Emitter effects.</summary>
    /// <description>
    /// A base datablock inherited by AFX Particle Emitter effects.
    /// </description>
    public class afxParticleEmitterData : ParticleEmitterData {
        public afxParticleEmitterData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public afxParticleEmitterData(string pName, bool pRegister)
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

        public afxParticleEmitterData(string pName)
            : this(pName, false) {
        }

        public afxParticleEmitterData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxParticleEmitterData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxParticleEmitterData(SimObject pObj)
            : base(pObj) {
        }

        public afxParticleEmitterData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxParticleEmitterData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxParticleEmitterData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the afxParticleEmitterData class.
        /// </description>
        /// <returns>The type info object for afxParticleEmitterData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// If true, the initial velocity of emitted particles is multiplied by the fade amount of the containing effect wrapper. As the effect fades-in and out, so does the initial velocity of new particles.
        /// </description>
        /// </value>
        public bool FadeVelocity {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fadeVelocity"));
            set => SetFieldValue("fadeVelocity", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, the ejection offset of emitted particles is multiplied by the fade amount of the containing effect wrapper. As the effect fades-in and out, so does the ejection offset of new particles.
        /// </description>
        /// </value>
        public bool FadeOffset {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("fadeOffset"));
            set => SetFieldValue("fadeOffset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// General direction vector used for emitting particles. Its exact interpretation is determined by the particle emitter subclass.
        /// </description>
        /// </value>
        public Point3F Vector {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("vector"));
            set => SetFieldValue("vector", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Sets whether the vector field should be interpreted as a vector in the world coordinate system.
        /// </description>
        /// </value>
        public bool VectorIsWorld {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("vectorIsWorld"));
            set => SetFieldValue("vectorIsWorld", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// A string of paths to be used as transform paths. Each path name must reference an afxPathData datablock. Transform paths are used to translate particles along a given path or series of paths.
        /// </description>
        /// </value>
        public string PathsTransform {
            get => GenericMarshal.StringTo<string>(GetFieldValue("pathsTransform"));
            set => SetFieldValue("pathsTransform", GenericMarshal.ToString(value));
        }
    }
}
