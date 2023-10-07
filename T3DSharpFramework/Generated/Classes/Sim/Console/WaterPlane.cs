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
    /// <summary>Represents a large body of water stretching to the horizon in all directions.</summary>
    /// <description>
    /// WaterPlane's position is defined only height, the z element of position, it is infinite in xy and depth. %WaterPlane is designed to represent the ocean on an island scene and viewed from ground level; other uses may not be appropriate and a WaterBlock may be used.
    /// </description>
    /// <see cref="WaterObject for inherited functionality.
    /// 
    /// Limitations:
    /// 
    /// Because %WaterPlane cannot be projected exactly to the far-clip distance, other objects nearing this distance can have noticible artifacts as they clip through first the %WaterPlane and then the far plane.
    /// 
    /// To avoid this large objects should be positioned such that they will not line up with the far-clip from vantage points the player is expected to be. In particular, your TerrainBlock should be completely contained by the far-clip distance.
    /// 
    /// Viewing %WaterPlane from a high altitude with a tight far-clip distance will accentuate this limitation. %WaterPlane is primarily designed to be viewed from ground level." />
    public class WaterPlane : WaterObject {
        public WaterPlane(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public WaterPlane(string pName, bool pRegister)
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

        public WaterPlane(string pName)
            : this(pName, false) {
        }

        public WaterPlane(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public WaterPlane(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public WaterPlane(SimObject pObj)
            : base(pObj) {
        }

        public WaterPlane(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnWaterPlane_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnWaterPlane_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the WaterPlane class.
        /// </description>
        /// <returns>The type info object for WaterPlane</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Spacing between vertices in the WaterBlock mesh
        /// </description>
        /// </value>
        public int GridSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("gridSize"));
            set => SetFieldValue("gridSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Duplicate of gridElementSize for backwards compatility
        /// </description>
        /// </value>
        public float GridElementSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("gridElementSize"));
            set => SetFieldValue("gridElementSize", GenericMarshal.ToString(value));
        }
    }
}
