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
    /// <summary>Contains additional data to be associated with a ParticleEmitterNode.</summary>
    public class ParticleEmitterNodeData : GameBaseData {
        public ParticleEmitterNodeData(bool pRegister = false)
            : base(pRegister) {
        }

        public ParticleEmitterNodeData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public ParticleEmitterNodeData(string pName)
            : this(pName, false) {
        }

        public ParticleEmitterNodeData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ParticleEmitterNodeData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ParticleEmitterNodeData(SimObject pObj)
            : base(pObj) {
        }

        public ParticleEmitterNodeData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnParticleEmitterNodeData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnParticleEmitterNodeData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the ParticleEmitterNodeData class.
        /// </description>
        /// <returns>The type info object for ParticleEmitterNodeData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Time multiplier for particle emitter nodes.</summary>
        /// <description>
        /// Increasing timeMultiple is like running the emitter at a faster rate - single-shot emitters will complete in a shorter time, and continuous emitters will generate particles more quickly.
        /// 
        /// Valid range is 0.01 - 100.
        /// </description>
        /// </value>
        public float TimeMultiple {
            get => GenericMarshal.StringTo<float>(GetFieldValue("timeMultiple"));
            set => SetFieldValue("timeMultiple", GenericMarshal.ToString(value));
        }
    }
}
