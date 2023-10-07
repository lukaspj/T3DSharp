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
    /// <summary>A choreographer for selection effects.</summary>
    /// <description>
    /// 
    /// </description>
    public class afxSelectron : afxChoreographer {
        public afxSelectron(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public afxSelectron(string pName, bool pRegister)
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

        public afxSelectron(string pName)
            : this(pName, false) {
        }

        public afxSelectron(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxSelectron(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxSelectron(SimObject pObj)
            : base(pObj) {
        }

        public afxSelectron(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct StopSelectron__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _StopSelectron(IntPtr _this, StopSelectron__Args args);
            private static _StopSelectron _StopSelectronFunc;
            internal static _StopSelectron StopSelectron() {
               _StopSelectronFunc ??= Torque3D.LookupEngineFunction<_StopSelectron>("fnafxSelectron_stopSelectron");

                return _StopSelectronFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Interrupt__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Interrupt(IntPtr _this, Interrupt__Args args);
            private static _Interrupt _InterruptFunc;
            internal static _Interrupt Interrupt() {
               _InterruptFunc ??= Torque3D.LookupEngineFunction<_Interrupt>("fnafxSelectron_interrupt");

                return _InterruptFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTimeFactor__Args
            {
                internal float factor;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTimeFactor(IntPtr _this, SetTimeFactor__Args args);
            private static _SetTimeFactor _SetTimeFactorFunc;
            internal static _SetTimeFactor SetTimeFactor() {
               _SetTimeFactorFunc ??= Torque3D.LookupEngineFunction<_SetTimeFactor>("fnafxSelectron_setTimeFactor");

                return _SetTimeFactorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxSelectron_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxSelectron_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Stops and deletes a running selectron.
        /// </description>
        public void StopSelectron() {
             InternalUnsafeMethods.StopSelectron__Args _args = new InternalUnsafeMethods.StopSelectron__Args() {
             };
             InternalUnsafeMethods.StopSelectron()(ObjectPtr, _args);
        }

        /// <description>
        /// Interrupts and deletes a running selectron.
        /// </description>
        public void Interrupt() {
             InternalUnsafeMethods.Interrupt__Args _args = new InternalUnsafeMethods.Interrupt__Args() {
             };
             InternalUnsafeMethods.Interrupt()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the time factor of the selectron.
        /// </description>
        public void SetTimeFactor(float factor = 1f) {
             InternalUnsafeMethods.SetTimeFactor__Args _args = new InternalUnsafeMethods.SetTimeFactor__Args() {
                factor = factor,
             };
             InternalUnsafeMethods.SetTimeFactor()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the afxSelectron class.
        /// </description>
        /// <returns>The type info object for afxSelectron</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
