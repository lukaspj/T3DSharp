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
    /// <summary>A renderable, collidable convex shape defined by a collection of surface planes.</summary>
    /// <description>
    /// %ConvexShape is intended to be used as a temporary asset for quickly blocking out a scene or filling in approximate shapes to be later replaced with final assets. This is most easily done by using the WorldEditor's Sketch Tool.
    /// </description>
    public class ConvexShape : SceneObject {
        public ConvexShape(bool pRegister = false)
            : base(pRegister) {
        }

        public ConvexShape(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public ConvexShape(string pName)
            : this(pName, false) {
        }

        public ConvexShape(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ConvexShape(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ConvexShape(SimObject pObj)
            : base(pObj) {
        }

        public ConvexShape(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMaterial__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetMaterial(IntPtr _this, SetMaterial__Args args);
            private static _SetMaterial _SetMaterialFunc;
            internal static _SetMaterial SetMaterial() {
               _SetMaterialFunc ??= Torque3D.LookupEngineFunction<_SetMaterial>("fnConvexShape_setMaterial");

                return _SetMaterialFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMaterialAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMaterialAsset(IntPtr _this, GetMaterialAsset__Args args);
            private static _GetMaterialAsset _GetMaterialAssetFunc;
            internal static _GetMaterialAsset GetMaterialAsset() {
               _GetMaterialAssetFunc ??= Torque3D.LookupEngineFunction<_GetMaterialAsset>("fnConvexShape_getMaterialAsset");

                return _GetMaterialAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMaterial__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMaterial(IntPtr _this, GetMaterial__Args args);
            private static _GetMaterial _GetMaterialFunc;
            internal static _GetMaterial GetMaterial() {
               _GetMaterialFunc ??= Torque3D.LookupEngineFunction<_GetMaterial>("fnConvexShape_getMaterial");

                return _GetMaterialFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnConvexShape_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnConvexShape_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Materialassignment. first tries asset then flat file.
        /// </description>
        public bool SetMaterial(string assetName) {
             InternalUnsafeMethods.SetMaterial__Args _args = new InternalUnsafeMethods.SetMaterial__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetMaterial()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Materialasset reference
        /// </description>
        public string GetMaterialAsset() {
             InternalUnsafeMethods.GetMaterialAsset__Args _args = new InternalUnsafeMethods.GetMaterialAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMaterialAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetMaterial() {
             InternalUnsafeMethods.GetMaterial__Args _args = new InternalUnsafeMethods.GetMaterial__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMaterial()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the ConvexShape class.
        /// </description>
        /// <returns>The type info object for ConvexShape</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>Material "Default material used to render the ConvexShape surface."</summary>
        /// </value>
        public string Material {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Material"));
            set => SetFieldValue("Material", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Material asset "Default material used to render the ConvexShape surface.".</summary>
        /// </value>
        public string MaterialAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("MaterialAsset"));
            set => SetFieldValue("MaterialAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Do not modify, for internal use.
        /// </description>
        /// </value>
        public string Surface {
            get => GenericMarshal.StringTo<string>(GetFieldValue("surface"));
            set => SetFieldValue("surface", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Do not modify, for internal use.
        /// </description>
        /// </value>
        public string SurfaceTexture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("surfaceTexture"));
            set => SetFieldValue("surfaceTexture", GenericMarshal.ToString(value));
        }
    }
}
