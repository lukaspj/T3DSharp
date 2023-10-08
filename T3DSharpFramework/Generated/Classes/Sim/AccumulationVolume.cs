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
    /// <summary>An invisible shape that allow objects within it to have an accumulation map.</summary>
    /// <description>
    /// AccumulationVolume is used to add additional realism to a scene. It's main use is in outdoor scenes  where objects could benefit from overlaying environment accumulation textures such as sand, snow, etc.
    /// 
    /// Objects within the volume must have accumulation enabled in their material.
    /// </description>
    public class AccumulationVolume : SceneObject {
        public AccumulationVolume(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public AccumulationVolume(string pName, bool pRegister)
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

        public AccumulationVolume(string pName)
            : this(pName, false) {
        }

        public AccumulationVolume(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public AccumulationVolume(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public AccumulationVolume(SimObject pObj)
            : base(pObj) {
        }

        public AccumulationVolume(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnAccumulationVolume_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnAccumulationVolume_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the AccumulationVolume class.
        /// </description>
        /// <returns>The type info object for AccumulationVolume</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Accumulation texture.
        /// </description>
        /// </value>
        public string TextureAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("TextureAsset"));
            set => SetFieldValue("TextureAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Accumulation texture.
        /// </description>
        /// </value>
        public string Texture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Texture"));
            set => SetFieldValue("Texture", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// For internal use only.
        /// </description>
        /// </value>
        public string Plane {
            get => GenericMarshal.StringTo<string>(GetFieldValue("plane"));
            set => SetFieldValue("plane", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// For internal use only.
        /// </description>
        /// </value>
        public string Point {
            get => GenericMarshal.StringTo<string>(GetFieldValue("point"));
            set => SetFieldValue("point", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// For internal use only.
        /// </description>
        /// </value>
        public string Edge {
            get => GenericMarshal.StringTo<string>(GetFieldValue("edge"));
            set => SetFieldValue("edge", GenericMarshal.ToString(value));
        }
    }
}
