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
    /// <summary>An infinite plane extending in all direction.</summary>
    /// <description>
    /// %GroundPlane is useful for setting up simple testing scenes, or it can be placed under an existing scene to keep objects from falling into 'nothing'.
    /// 
    /// %GroundPlane may not be moved or rotated, it is always at the world origin.
    /// </description>
    public class GroundPlane : SceneObject {
        public GroundPlane(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GroundPlane(string pName, bool pRegister)
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

        public GroundPlane(string pName)
            : this(pName, false) {
        }

        public GroundPlane(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GroundPlane(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GroundPlane(SimObject pObj)
            : base(pObj) {
        }

        public GroundPlane(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PostApply__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PostApply(IntPtr _this, PostApply__Args args);
            private static _PostApply _PostApplyFunc;
            internal static _PostApply PostApply() {
               _PostApplyFunc ??= Torque3D.LookupEngineFunction<_PostApply>("fnGroundPlane_postApply");

                return _PostApplyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGroundPlane_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGroundPlane_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Intended as a helper to developers and editor scripts.
        /// Force trigger an inspectPostApply. This will transmit material and other fields to client objects.
        /// </description>
        public void PostApply() {
             InternalUnsafeMethods.PostApply__Args _args = new InternalUnsafeMethods.PostApply__Args() {
             };
             InternalUnsafeMethods.PostApply()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GroundPlane class.
        /// </description>
        /// <returns>The type info object for GroundPlane</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Square size in meters to which %GroundPlane subdivides its geometry.
        /// </description>
        /// </value>
        public float SquareSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("squareSize"));
            set => SetFieldValue("squareSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Scale of texture repeat in the U direction.
        /// </description>
        /// </value>
        public float ScaleU {
            get => GenericMarshal.StringTo<float>(GetFieldValue("scaleU"));
            set => SetFieldValue("scaleU", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Scale of texture repeat in the V direction.
        /// </description>
        /// </value>
        public float ScaleV {
            get => GenericMarshal.StringTo<float>(GetFieldValue("scaleV"));
            set => SetFieldValue("scaleV", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Material "The material used to render the ground plane."</summary>
        /// </value>
        public string Material {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Material"));
            set => SetFieldValue("Material", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Material asset "The material used to render the ground plane.".</summary>
        /// </value>
        public string MaterialAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("MaterialAsset"));
            set => SetFieldValue("MaterialAsset", GenericMarshal.ToString(value));
        }
    }
}
