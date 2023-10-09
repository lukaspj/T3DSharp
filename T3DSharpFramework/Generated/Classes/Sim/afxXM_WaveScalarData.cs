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
    /// <summary>An xmod datablock.</summary>
    /// <description>
    /// 
    /// </description>
    public class afxXM_WaveScalarData : afxXM_WaveBaseData {
        public afxXM_WaveScalarData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxXM_WaveScalarData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public afxXM_WaveScalarData(string pName)
            : this(pName, false) {
        }

        public afxXM_WaveScalarData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxXM_WaveScalarData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxXM_WaveScalarData(SimObject pObj)
            : base(pObj) {
        }

        public afxXM_WaveScalarData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxXM_WaveScalarData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxXM_WaveScalarData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the afxXM_WaveScalarData class.
        /// </description>
        /// <returns>The type info object for afxXM_WaveScalarData</returns>
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
        public float A {
            get => GenericMarshal.StringTo<float>(GetFieldValue("a"));
            set => SetFieldValue("a", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float B {
            get => GenericMarshal.StringTo<float>(GetFieldValue("b"));
            set => SetFieldValue("b", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float AVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("aVariance"));
            set => SetFieldValue("aVariance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float BVariance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("bVariance"));
            set => SetFieldValue("bVariance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public bool SyncVariances {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("syncVariances"));
            set => SetFieldValue("syncVariances", GenericMarshal.ToString(value));
        }
    }
}
