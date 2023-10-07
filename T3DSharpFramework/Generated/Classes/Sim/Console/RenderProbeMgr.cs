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
    /// <summary>This render bin handles the rendering of reflection probes to provide IBL</summary>
    /// <description>
    /// lighting for PBR
    /// 
    /// Probes when added to the scene, are registered to the Manager, and then during the steps
    /// leading up to the frame being rendered, the probes submit to the Manager that they are ready to be rendered
    /// resulting in them being added to the active list.
    /// When the manager is invoked to render, it processes the active probe list and finds the best probes based on
    /// settings like max probes per frame, probe score, etc to get the final list of probes to be submitted to the shader.
    /// </description>
    public class RenderProbeMgr : RenderBinManager {
        public RenderProbeMgr(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public RenderProbeMgr(string pName, bool pRegister)
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

        public RenderProbeMgr(string pName)
            : this(pName, false) {
        }

        public RenderProbeMgr(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public RenderProbeMgr(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public RenderProbeMgr(SimObject pObj)
            : base(pObj) {
        }

        public RenderProbeMgr(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct BakeProbes__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _BakeProbes(IntPtr _this, BakeProbes__Args args);
            private static _BakeProbes _BakeProbesFunc;
            internal static _BakeProbes BakeProbes() {
               _BakeProbesFunc ??= Torque3D.LookupEngineFunction<_BakeProbes>("fnRenderProbeMgr_bakeProbes");

                return _BakeProbesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct BakeProbe__Args
            {
                internal IntPtr probe;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _BakeProbe(IntPtr _this, BakeProbe__Args args);
            private static _BakeProbe _BakeProbeFunc;
            internal static _BakeProbe BakeProbe() {
               _BakeProbeFunc ??= Torque3D.LookupEngineFunction<_BakeProbe>("fnRenderProbeMgr_bakeProbe");

                return _BakeProbeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnRenderProbeMgr_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnRenderProbeMgr_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Iterates over all reflection probes in the scene and bakes their cubemaps</summary>
        /// <description>
        /// .
        /// </description>
        public void BakeProbes() {
             InternalUnsafeMethods.BakeProbes__Args _args = new InternalUnsafeMethods.BakeProbes__Args() {
             };
             InternalUnsafeMethods.BakeProbes()(ObjectPtr, _args);
        }

        /// <summary>Bakes the cubemaps for a reflection probe</summary>
        /// <description>
        /// .
        /// </description>
        public void BakeProbe(ReflectionProbe probe = null) {
             InternalUnsafeMethods.BakeProbe__Args _args = new InternalUnsafeMethods.BakeProbe__Args() {
                probe = probe.ObjectPtr,
             };
             InternalUnsafeMethods.BakeProbe()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the RenderProbeMgr class.
        /// </description>
        /// <returns>The type info object for RenderProbeMgr</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
