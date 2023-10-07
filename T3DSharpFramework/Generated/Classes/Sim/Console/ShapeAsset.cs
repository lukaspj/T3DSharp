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
    /// 
    public class ShapeAsset : AssetBase {
        public ShapeAsset(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public ShapeAsset(string pName, bool pRegister)
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

        public ShapeAsset(string pName)
            : this(pName, false) {
        }

        public ShapeAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ShapeAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ShapeAsset(SimObject pObj)
            : base(pObj) {
        }

        public ShapeAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetIdByFilename__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filePath;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAssetIdByFilename(GetAssetIdByFilename__Args args);
            private static _GetAssetIdByFilename _GetAssetIdByFilenameFunc;
            internal static _GetAssetIdByFilename GetAssetIdByFilename() {
               _GetAssetIdByFilenameFunc ??= Torque3D.LookupEngineFunction<_GetAssetIdByFilename>("fnShapeAsset_getAssetIdByFilename");

                return _GetAssetIdByFilenameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GenerateCachedPreviewImage__Args
            {
                internal int resolution;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string overrideMaterialName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GenerateCachedPreviewImage(IntPtr _this, GenerateCachedPreviewImage__Args args);
            private static _GenerateCachedPreviewImage _GenerateCachedPreviewImageFunc;
            internal static _GenerateCachedPreviewImage GenerateCachedPreviewImage() {
               _GenerateCachedPreviewImageFunc ??= Torque3D.LookupEngineFunction<_GenerateCachedPreviewImage>("fnShapeAsset_generateCachedPreviewImage");

                return _GenerateCachedPreviewImageFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetStatusString__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetStatusString(IntPtr _this, GetStatusString__Args args);
            private static _GetStatusString _GetStatusStringFunc;
            internal static _GetStatusString GetStatusString() {
               _GetStatusStringFunc ??= Torque3D.LookupEngineFunction<_GetStatusString>("fnShapeAsset_getStatusString");

                return _GetStatusStringFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetShapeConstructorFilePath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetShapeConstructorFilePath(IntPtr _this, GetShapeConstructorFilePath__Args args);
            private static _GetShapeConstructorFilePath _GetShapeConstructorFilePathFunc;
            internal static _GetShapeConstructorFilePath GetShapeConstructorFilePath() {
               _GetShapeConstructorFilePathFunc ??= Torque3D.LookupEngineFunction<_GetShapeConstructorFilePath>("fnShapeAsset_getShapeConstructorFilePath");

                return _GetShapeConstructorFilePathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetShapePath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetShapePath(IntPtr _this, GetShapePath__Args args);
            private static _GetShapePath _GetShapePathFunc;
            internal static _GetShapePath GetShapePath() {
               _GetShapePathFunc ??= Torque3D.LookupEngineFunction<_GetShapePath>("fnShapeAsset_getShapePath");

                return _GetShapePathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAnimation__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetAnimation(IntPtr _this, GetAnimation__Args args);
            private static _GetAnimation _GetAnimationFunc;
            internal static _GetAnimation GetAnimation() {
               _GetAnimationFunc ??= Torque3D.LookupEngineFunction<_GetAnimation>("fnShapeAsset_getAnimation");

                return _GetAnimationFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAnimationCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAnimationCount(IntPtr _this, GetAnimationCount__Args args);
            private static _GetAnimationCount _GetAnimationCountFunc;
            internal static _GetAnimationCount GetAnimationCount() {
               _GetAnimationCountFunc ??= Torque3D.LookupEngineFunction<_GetAnimationCount>("fnShapeAsset_getAnimationCount");

                return _GetAnimationCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMaterialCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMaterialCount(IntPtr _this, GetMaterialCount__Args args);
            private static _GetMaterialCount _GetMaterialCountFunc;
            internal static _GetMaterialCount GetMaterialCount() {
               _GetMaterialCountFunc ??= Torque3D.LookupEngineFunction<_GetMaterialCount>("fnShapeAsset_getMaterialCount");

                return _GetMaterialCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnShapeAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnShapeAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Queries the Asset Database to see if any asset exists that is associated with the provided file path.
        /// </description>
        /// <returns>The AssetId of the associated asset, if any.</returns>
        public static string GetAssetIdByFilename(string filePath = "") {
             InternalUnsafeMethods.GetAssetIdByFilename__Args _args = new InternalUnsafeMethods.GetAssetIdByFilename__Args() {
                filePath = filePath,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetIdByFilename()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Generates a baked preview image of the given shapeAsset. Only really used for generating Asset Browser icons.
        /// </description>
        /// <param name="resolution">Optional field for what resolution to bake the preview image at. Must be pow2</param>
        /// <param name="overrideMaterialName">Optional field for overriding the material used when rendering the shape for the bake.</param>
        public string GenerateCachedPreviewImage(int resolution = 256, string overrideMaterialName = "") {
             InternalUnsafeMethods.GenerateCachedPreviewImage__Args _args = new InternalUnsafeMethods.GenerateCachedPreviewImage__Args() {
                resolution = resolution,
                overrideMaterialName = overrideMaterialName,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GenerateCachedPreviewImage()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get status string
        /// </description>
        public string GetStatusString() {
             InternalUnsafeMethods.GetStatusString__Args _args = new InternalUnsafeMethods.GetStatusString__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetStatusString()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the shape's constructor file.
        /// </description>
        /// <returns>The filename of the shape constructor file</returns>
        public string GetShapeConstructorFilePath() {
             InternalUnsafeMethods.GetShapeConstructorFilePath__Args _args = new InternalUnsafeMethods.GetShapeConstructorFilePath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetShapeConstructorFilePath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the shape's file path
        /// </description>
        /// <returns>The filename of the shape file</returns>
        public string GetShapePath() {
             InternalUnsafeMethods.GetShapePath__Args _args = new InternalUnsafeMethods.GetShapePath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetShapePath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets a particular shape animation asset for this shape.
        /// </description>
        /// <param name="animation">asset index.</param>
        /// <returns>Shape Animation Asset.</returns>
        public ShapeAnimationAsset GetAnimation(int index = 0) {
             InternalUnsafeMethods.GetAnimation__Args _args = new InternalUnsafeMethods.GetAnimation__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAnimation()(ObjectPtr, _args);
             return new ShapeAnimationAsset(_engineResult);
        }

        /// <description>
        /// Gets the number of animations for this shape asset.
        /// </description>
        /// <returns>Animation count.</returns>
        public int GetAnimationCount() {
             InternalUnsafeMethods.GetAnimationCount__Args _args = new InternalUnsafeMethods.GetAnimationCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetAnimationCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the number of materials for this shape asset.
        /// </description>
        /// <returns>Material count.</returns>
        public int GetMaterialCount() {
             InternalUnsafeMethods.GetMaterialCount__Args _args = new InternalUnsafeMethods.GetMaterialCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetMaterialCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the ShapeAsset class.
        /// </description>
        /// <returns>The type info object for ShapeAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Path to the shape file we want to render
        /// </description>
        /// </value>
        public string FileName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fileName"));
            set => SetFieldValue("fileName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the shape file we want to render
        /// </description>
        /// </value>
        public string ConstuctorFileName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("constuctorFileName"));
            set => SetFieldValue("constuctorFileName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the diffuse imposter file we want to render
        /// </description>
        /// </value>
        public string DiffuseImposterFileName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("diffuseImposterFileName"));
            set => SetFieldValue("diffuseImposterFileName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the normal imposter file we want to render
        /// </description>
        /// </value>
        public string NormalImposterFileName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("normalImposterFileName"));
            set => SetFieldValue("normalImposterFileName", GenericMarshal.ToString(value));
        }
    }
}
