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
    /// 
    public class afxXM_WeightedBaseData : afxXM_BaseData {
        public afxXM_WeightedBaseData(bool pRegister = false)
            : base(pRegister) {
        }

        public afxXM_WeightedBaseData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public afxXM_WeightedBaseData(string pName)
            : this(pName, false) {
        }

        public afxXM_WeightedBaseData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxXM_WeightedBaseData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxXM_WeightedBaseData(SimObject pObj)
            : base(pObj) {
        }

        public afxXM_WeightedBaseData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxXM_WeightedBaseData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxXM_WeightedBaseData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the afxXM_WeightedBaseData class.
        /// </description>
        /// <returns>The type info object for afxXM_WeightedBaseData</returns>
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
        public float Delay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("delay"));
            set => SetFieldValue("delay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float Lifetime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lifetime"));
            set => SetFieldValue("lifetime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float FadeInTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeInTime"));
            set => SetFieldValue("fadeInTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float FadeOutTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeOutTime"));
            set => SetFieldValue("fadeOutTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public Point2F FadeInEase {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("fadeInEase"));
            set => SetFieldValue("fadeInEase", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public Point2F FadeOutEase {
            get => GenericMarshal.StringTo<Point2F>(GetFieldValue("fadeOutEase"));
            set => SetFieldValue("fadeOutEase", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float LifetimeBias {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lifetimeBias"));
            set => SetFieldValue("lifetimeBias", GenericMarshal.ToString(value));
        }
    }
}
