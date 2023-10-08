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
    /// <summary>A strip of rectangular mesh segments defined by a 3D spline for prototyping road-shaped objects in your scene.</summary>
    /// <description>
    /// User may control width and depth per node, overall spline shape in three dimensions, and seperate Materials for rendering the top, bottom, and side surfaces.
    /// 
    /// MeshRoad is not capable of handling intersections, branches, curbs, or other desirable features in a final 'road' asset and is therefore intended for prototyping and experimentation.
    /// 
    /// Materials assigned to MeshRoad should tile vertically.
    /// </description>
    public class MeshRoad : SceneObject {
        public MeshRoad(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public MeshRoad(string pName, bool pRegister)
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

        public MeshRoad(string pName)
            : this(pName, false) {
        }

        public MeshRoad(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public MeshRoad(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public MeshRoad(SimObject pObj)
            : base(pObj) {
        }

        public MeshRoad(IntPtr pObj)
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
               _PostApplyFunc ??= Torque3D.LookupEngineFunction<_PostApply>("fnMeshRoad_postApply");

                return _PostApplyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Regenerate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Regenerate(IntPtr _this, Regenerate__Args args);
            private static _Regenerate _RegenerateFunc;
            internal static _Regenerate Regenerate() {
               _RegenerateFunc ??= Torque3D.LookupEngineFunction<_Regenerate>("fnMeshRoad_regenerate");

                return _RegenerateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNodeDepth__Args
            {
                internal int idx;
                internal float meters;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetNodeDepth(IntPtr _this, SetNodeDepth__Args args);
            private static _SetNodeDepth _SetNodeDepthFunc;
            internal static _SetNodeDepth SetNodeDepth() {
               _SetNodeDepthFunc ??= Torque3D.LookupEngineFunction<_SetNodeDepth>("fnMeshRoad_setNodeDepth");

                return _SetNodeDepthFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnMeshRoad_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnMeshRoad_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Intended as a helper to developers and editor scripts.
        /// Force trigger an inspectPostApply. This will transmit material and other fields ( not including nodes ) to client objects.
        /// </description>
        public void PostApply() {
             InternalUnsafeMethods.PostApply__Args _args = new InternalUnsafeMethods.PostApply__Args() {
             };
             InternalUnsafeMethods.PostApply()(ObjectPtr, _args);
        }

        /// <description>
        /// Intended as a helper to developers and editor scripts.
        /// Force MeshRoad to recreate its geometry.
        /// </description>
        public void Regenerate() {
             InternalUnsafeMethods.Regenerate__Args _args = new InternalUnsafeMethods.Regenerate__Args() {
             };
             InternalUnsafeMethods.Regenerate()(ObjectPtr, _args);
        }

        /// <description>
        /// Intended as a helper to developers and editor scripts.
        /// Sets the depth in meters of a particular node.
        /// </description>
        public void SetNodeDepth(int idx, float meters) {
             InternalUnsafeMethods.SetNodeDepth__Args _args = new InternalUnsafeMethods.SetNodeDepth__Args() {
                idx = idx,
                meters = meters,
             };
             InternalUnsafeMethods.SetNodeDepth()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the MeshRoad class.
        /// </description>
        /// <returns>The type info object for MeshRoad</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>TopMaterial "Material for the upper surface of the road."</summary>
        /// </value>
        public string TopMaterial {
            get => GenericMarshal.StringTo<string>(GetFieldValue("TopMaterial"));
            set => SetFieldValue("TopMaterial", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>TopMaterial asset "Material for the upper surface of the road.".</summary>
        /// </value>
        public string TopMaterialAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("TopMaterialAsset"));
            set => SetFieldValue("TopMaterialAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>BottomMaterial "Material for the bottom surface of the road."</summary>
        /// </value>
        public string BottomMaterial {
            get => GenericMarshal.StringTo<string>(GetFieldValue("BottomMaterial"));
            set => SetFieldValue("BottomMaterial", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>BottomMaterial asset "Material for the bottom surface of the road.".</summary>
        /// </value>
        public string BottomMaterialAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("BottomMaterialAsset"));
            set => SetFieldValue("BottomMaterialAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>SideMaterial "Material for the side surface of the road."</summary>
        /// </value>
        public string SideMaterial {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SideMaterial"));
            set => SetFieldValue("SideMaterial", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>SideMaterial asset "Material for the side surface of the road.".</summary>
        /// </value>
        public string SideMaterialAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SideMaterialAsset"));
            set => SetFieldValue("SideMaterialAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The length in meters of textures mapped to the MeshRoad.
        /// </description>
        /// </value>
        public float TextureLength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("textureLength"));
            set => SetFieldValue("textureLength", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Angle in degrees - MeshRoad will subdivide the spline if its curve is greater than this threshold.
        /// </description>
        /// </value>
        public float BreakAngle {
            get => GenericMarshal.StringTo<float>(GetFieldValue("breakAngle"));
            set => SetFieldValue("breakAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Subdivide segments widthwise this many times when generating vertices.
        /// </description>
        /// </value>
        public int WidthSubdivisions {
            get => GenericMarshal.StringTo<int>(GetFieldValue("widthSubdivisions"));
            set => SetFieldValue("widthSubdivisions", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Do not modify, for internal use.
        /// </description>
        /// </value>
        public string Node {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Node"));
            set => SetFieldValue("Node", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Do not modify, for internal use.
        /// </description>
        /// </value>
        public string ProfileNode {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ProfileNode"));
            set => SetFieldValue("ProfileNode", GenericMarshal.ToString(value));
        }
    }
}
