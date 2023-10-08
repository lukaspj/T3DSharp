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
    /// <summary>Terrain action used for leveling varying terrain heights smoothly.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class TerrainSmoothAction : UndoAction {
        public TerrainSmoothAction(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public TerrainSmoothAction(string pName, bool pRegister)
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

        public TerrainSmoothAction(string pName)
            : this(pName, false) {
        }

        public TerrainSmoothAction(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public TerrainSmoothAction(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public TerrainSmoothAction(SimObject pObj)
            : base(pObj) {
        }

        public TerrainSmoothAction(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Smooth__Args
            {
                internal IntPtr terrain;
                internal float factor;
                internal uint steps;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Smooth(IntPtr _this, Smooth__Args args);
            private static _Smooth _SmoothFunc;
            internal static _Smooth Smooth() {
               _SmoothFunc ??= Torque3D.LookupEngineFunction<_Smooth>("fnTerrainSmoothAction_smooth");

                return _SmoothFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnTerrainSmoothAction_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnTerrainSmoothAction_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// ( TerrainBlock obj, F32 factor, U32 steps )
        /// </description>
        public void Smooth(TerrainBlock terrain, float factor, uint steps) {
             InternalUnsafeMethods.Smooth__Args _args = new InternalUnsafeMethods.Smooth__Args() {
                terrain = terrain.ObjectPtr,
                factor = factor,
                steps = steps,
             };
             InternalUnsafeMethods.Smooth()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the TerrainSmoothAction class.
        /// </description>
        /// <returns>The type info object for TerrainSmoothAction</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
