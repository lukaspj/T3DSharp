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
    /// <summary>The TerrainMaterial class orginizes the material settings for a single terrain material layer.</summary>
    /// <description>
    /// 
    /// </description>
    /// <remarks> You should not be creating TerrainMaterials by hand in code. All TerrainMaterials should be created in the editors, as intended by the system.
    /// 
    /// </remarks>
    /// <code>
    /// // Created by the Terrain Painter tool in the World Editor
    /// new TerrainMaterial()
    /// {
    /// 	internalName = "grass1";
    /// 	diffuseMap = "art/terrains/Test/grass1";
    /// 	detailMap = "art/terrains/Test/grass1_d";
    /// 	detailSize = "10";
    /// 	isManaged = "1";
    /// 	detailBrightness = "1";
    /// 	Enabled = "1";
    /// 	diffuseSize = "200";
    /// };
    /// </code>
    /// <see cref="Materials" />
    public class TerrainMaterial : SimObject {
        public TerrainMaterial(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public TerrainMaterial(string pName, bool pRegister)
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

        public TerrainMaterial(string pName)
            : this(pName, false) {
        }

        public TerrainMaterial(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public TerrainMaterial(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public TerrainMaterial(SimObject pObj)
            : base(pObj) {
        }

        public TerrainMaterial(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMacroMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetMacroMap(IntPtr _this, SetMacroMap__Args args);
            private static _SetMacroMap _SetMacroMapFunc;
            internal static _SetMacroMap SetMacroMap() {
               _SetMacroMapFunc ??= Torque3D.LookupEngineFunction<_SetMacroMap>("fnTerrainMaterial_setMacroMap");

                return _SetMacroMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMacroMapAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMacroMapAsset(IntPtr _this, GetMacroMapAsset__Args args);
            private static _GetMacroMapAsset _GetMacroMapAssetFunc;
            internal static _GetMacroMapAsset GetMacroMapAsset() {
               _GetMacroMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetMacroMapAsset>("fnTerrainMaterial_getMacroMapAsset");

                return _GetMacroMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMacroMap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMacroMap(IntPtr _this, GetMacroMap__Args args);
            private static _GetMacroMap _GetMacroMapFunc;
            internal static _GetMacroMap GetMacroMap() {
               _GetMacroMapFunc ??= Torque3D.LookupEngineFunction<_GetMacroMap>("fnTerrainMaterial_getMacroMap");

                return _GetMacroMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetORMConfigMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetORMConfigMap(IntPtr _this, SetORMConfigMap__Args args);
            private static _SetORMConfigMap _SetORMConfigMapFunc;
            internal static _SetORMConfigMap SetORMConfigMap() {
               _SetORMConfigMapFunc ??= Torque3D.LookupEngineFunction<_SetORMConfigMap>("fnTerrainMaterial_setORMConfigMap");

                return _SetORMConfigMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetORMConfigMapAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetORMConfigMapAsset(IntPtr _this, GetORMConfigMapAsset__Args args);
            private static _GetORMConfigMapAsset _GetORMConfigMapAssetFunc;
            internal static _GetORMConfigMapAsset GetORMConfigMapAsset() {
               _GetORMConfigMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetORMConfigMapAsset>("fnTerrainMaterial_getORMConfigMapAsset");

                return _GetORMConfigMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetORMConfigMap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetORMConfigMap(IntPtr _this, GetORMConfigMap__Args args);
            private static _GetORMConfigMap _GetORMConfigMapFunc;
            internal static _GetORMConfigMap GetORMConfigMap() {
               _GetORMConfigMapFunc ??= Torque3D.LookupEngineFunction<_GetORMConfigMap>("fnTerrainMaterial_getORMConfigMap");

                return _GetORMConfigMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetDetailMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetDetailMap(IntPtr _this, SetDetailMap__Args args);
            private static _SetDetailMap _SetDetailMapFunc;
            internal static _SetDetailMap SetDetailMap() {
               _SetDetailMapFunc ??= Torque3D.LookupEngineFunction<_SetDetailMap>("fnTerrainMaterial_setDetailMap");

                return _SetDetailMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailMapAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDetailMapAsset(IntPtr _this, GetDetailMapAsset__Args args);
            private static _GetDetailMapAsset _GetDetailMapAssetFunc;
            internal static _GetDetailMapAsset GetDetailMapAsset() {
               _GetDetailMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetDetailMapAsset>("fnTerrainMaterial_getDetailMapAsset");

                return _GetDetailMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailMap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDetailMap(IntPtr _this, GetDetailMap__Args args);
            private static _GetDetailMap _GetDetailMapFunc;
            internal static _GetDetailMap GetDetailMap() {
               _GetDetailMapFunc ??= Torque3D.LookupEngineFunction<_GetDetailMap>("fnTerrainMaterial_getDetailMap");

                return _GetDetailMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNormalMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetNormalMap(IntPtr _this, SetNormalMap__Args args);
            private static _SetNormalMap _SetNormalMapFunc;
            internal static _SetNormalMap SetNormalMap() {
               _SetNormalMapFunc ??= Torque3D.LookupEngineFunction<_SetNormalMap>("fnTerrainMaterial_setNormalMap");

                return _SetNormalMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNormalMapAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNormalMapAsset(IntPtr _this, GetNormalMapAsset__Args args);
            private static _GetNormalMapAsset _GetNormalMapAssetFunc;
            internal static _GetNormalMapAsset GetNormalMapAsset() {
               _GetNormalMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetNormalMapAsset>("fnTerrainMaterial_getNormalMapAsset");

                return _GetNormalMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNormalMap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNormalMap(IntPtr _this, GetNormalMap__Args args);
            private static _GetNormalMap _GetNormalMapFunc;
            internal static _GetNormalMap GetNormalMap() {
               _GetNormalMapFunc ??= Torque3D.LookupEngineFunction<_GetNormalMap>("fnTerrainMaterial_getNormalMap");

                return _GetNormalMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetDiffuseMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetDiffuseMap(IntPtr _this, SetDiffuseMap__Args args);
            private static _SetDiffuseMap _SetDiffuseMapFunc;
            internal static _SetDiffuseMap SetDiffuseMap() {
               _SetDiffuseMapFunc ??= Torque3D.LookupEngineFunction<_SetDiffuseMap>("fnTerrainMaterial_setDiffuseMap");

                return _SetDiffuseMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDiffuseMapAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDiffuseMapAsset(IntPtr _this, GetDiffuseMapAsset__Args args);
            private static _GetDiffuseMapAsset _GetDiffuseMapAssetFunc;
            internal static _GetDiffuseMapAsset GetDiffuseMapAsset() {
               _GetDiffuseMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetDiffuseMapAsset>("fnTerrainMaterial_getDiffuseMapAsset");

                return _GetDiffuseMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDiffuseMap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDiffuseMap(IntPtr _this, GetDiffuseMap__Args args);
            private static _GetDiffuseMap _GetDiffuseMapFunc;
            internal static _GetDiffuseMap GetDiffuseMap() {
               _GetDiffuseMapFunc ??= Torque3D.LookupEngineFunction<_GetDiffuseMap>("fnTerrainMaterial_getDiffuseMap");

                return _GetDiffuseMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnTerrainMaterial_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnTerrainMaterial_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// MacroMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetMacroMap(string assetName) {
             InternalUnsafeMethods.SetMacroMap__Args _args = new InternalUnsafeMethods.SetMacroMap__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetMacroMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// MacroMapasset reference
        /// </description>
        public string GetMacroMapAsset() {
             InternalUnsafeMethods.GetMacroMapAsset__Args _args = new InternalUnsafeMethods.GetMacroMapAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMacroMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetMacroMap() {
             InternalUnsafeMethods.GetMacroMap__Args _args = new InternalUnsafeMethods.GetMacroMap__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMacroMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// ORMConfigMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetORMConfigMap(string assetName) {
             InternalUnsafeMethods.SetORMConfigMap__Args _args = new InternalUnsafeMethods.SetORMConfigMap__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetORMConfigMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ORMConfigMapasset reference
        /// </description>
        public string GetORMConfigMapAsset() {
             InternalUnsafeMethods.GetORMConfigMapAsset__Args _args = new InternalUnsafeMethods.GetORMConfigMapAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetORMConfigMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetORMConfigMap() {
             InternalUnsafeMethods.GetORMConfigMap__Args _args = new InternalUnsafeMethods.GetORMConfigMap__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetORMConfigMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// DetailMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetDetailMap(string assetName) {
             InternalUnsafeMethods.SetDetailMap__Args _args = new InternalUnsafeMethods.SetDetailMap__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetDetailMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// DetailMapasset reference
        /// </description>
        public string GetDetailMapAsset() {
             InternalUnsafeMethods.GetDetailMapAsset__Args _args = new InternalUnsafeMethods.GetDetailMapAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDetailMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetDetailMap() {
             InternalUnsafeMethods.GetDetailMap__Args _args = new InternalUnsafeMethods.GetDetailMap__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDetailMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// NormalMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetNormalMap(string assetName) {
             InternalUnsafeMethods.SetNormalMap__Args _args = new InternalUnsafeMethods.SetNormalMap__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetNormalMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// NormalMapasset reference
        /// </description>
        public string GetNormalMapAsset() {
             InternalUnsafeMethods.GetNormalMapAsset__Args _args = new InternalUnsafeMethods.GetNormalMapAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNormalMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetNormalMap() {
             InternalUnsafeMethods.GetNormalMap__Args _args = new InternalUnsafeMethods.GetNormalMap__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNormalMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// DiffuseMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetDiffuseMap(string assetName) {
             InternalUnsafeMethods.SetDiffuseMap__Args _args = new InternalUnsafeMethods.SetDiffuseMap__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetDiffuseMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// DiffuseMapasset reference
        /// </description>
        public string GetDiffuseMapAsset() {
             InternalUnsafeMethods.GetDiffuseMapAsset__Args _args = new InternalUnsafeMethods.GetDiffuseMapAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDiffuseMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetDiffuseMap() {
             InternalUnsafeMethods.GetDiffuseMap__Args _args = new InternalUnsafeMethods.GetDiffuseMap__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDiffuseMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the TerrainMaterial class.
        /// </description>
        /// <returns>The type info object for TerrainMaterial</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>DiffuseMap "Base Albedo stretched over the whole map"</summary>
        /// </value>
        public string DiffuseMap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DiffuseMap"));
            set => SetFieldValue("DiffuseMap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>DiffuseMap asset "Base Albedo stretched over the whole map".</summary>
        /// </value>
        public string DiffuseMapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DiffuseMapAsset"));
            set => SetFieldValue("DiffuseMapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Used to scale the diffuse map to the material square
        /// </description>
        /// </value>
        public float DiffuseSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("diffuseSize"));
            set => SetFieldValue("diffuseSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>NormalMap "NormalMap"</summary>
        /// </value>
        public string NormalMap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("NormalMap"));
            set => SetFieldValue("NormalMap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>NormalMap asset "NormalMap".</summary>
        /// </value>
        public string NormalMapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("NormalMapAsset"));
            set => SetFieldValue("NormalMapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Used to scale the height from the normal map to give some self occlusion effect (aka parallax) to the terrain material
        /// </description>
        /// </value>
        public float ParallaxScale {
            get => GenericMarshal.StringTo<float>(GetFieldValue("parallaxScale"));
            set => SetFieldValue("parallaxScale", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// A fixed value to add while blending using heightmap-based blending.Higher numbers = larger blend radius.
        /// </description>
        /// </value>
        public float BlendHeightBase {
            get => GenericMarshal.StringTo<float>(GetFieldValue("blendHeightBase"));
            set => SetFieldValue("blendHeightBase", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// A fixed value to add while blending using heightmap-based blending.Higher numbers = larger blend radius.
        /// </description>
        /// </value>
        public float BlendHeightContrast {
            get => GenericMarshal.StringTo<float>(GetFieldValue("blendHeightContrast"));
            set => SetFieldValue("blendHeightContrast", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// How sharply this layer blends with other textures.0->1, soft->hard.
        /// </description>
        /// </value>
        public float BlendHeightHardness {
            get => GenericMarshal.StringTo<float>(GetFieldValue("blendHeightHardness"));
            set => SetFieldValue("blendHeightHardness", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>DetailMap "Raises and lowers the RGB result of the Base Albedo up close."</summary>
        /// </value>
        public string DetailMap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DetailMap"));
            set => SetFieldValue("DetailMap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>DetailMap asset "Raises and lowers the RGB result of the Base Albedo up close.".</summary>
        /// </value>
        public string DetailMapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DetailMapAsset"));
            set => SetFieldValue("DetailMapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Used to scale the detail map to the material square
        /// </description>
        /// </value>
        public float DetailSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("detailSize"));
            set => SetFieldValue("detailSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Exponentially sharpens or lightens the detail map rendering on the material
        /// </description>
        /// </value>
        public float DetailStrength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("detailStrength"));
            set => SetFieldValue("detailStrength", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Changes how far camera can see the detail map rendering on the material
        /// </description>
        /// </value>
        public float DetailDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("detailDistance"));
            set => SetFieldValue("detailDistance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Makes that terrain material project along the sides of steep slopes instead of projected downwards
        /// </description>
        /// </value>
        public bool UseSideProjection {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useSideProjection"));
            set => SetFieldValue("useSideProjection", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>ORMConfigMap "AO|Roughness|metalness map (uses DetailMap UV Coords)"</summary>
        /// </value>
        public string ORMConfigMap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ORMConfigMap"));
            set => SetFieldValue("ORMConfigMap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>ORMConfigMap asset "AO|Roughness|metalness map (uses DetailMap UV Coords)".</summary>
        /// </value>
        public string ORMConfigMapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ORMConfigMapAsset"));
            set => SetFieldValue("ORMConfigMapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Is the PBR Config map's image in sRGB format?
        /// </description>
        /// </value>
        public bool IsSRGb {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isSRGb"));
            set => SetFieldValue("isSRGb", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Should the roughness channel of the PBR Config map be inverted?
        /// </description>
        /// </value>
        public bool InvertRoughness {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("invertRoughness"));
            set => SetFieldValue("invertRoughness", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>MacroMap "Raises and lowers the RGB result of the Base Albedo at a distance."</summary>
        /// </value>
        public string MacroMap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("MacroMap"));
            set => SetFieldValue("MacroMap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>MacroMap asset "Raises and lowers the RGB result of the Base Albedo at a distance.".</summary>
        /// </value>
        public string MacroMapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("MacroMapAsset"));
            set => SetFieldValue("MacroMapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Used to scale the Macro map to the material square
        /// </description>
        /// </value>
        public float MacroSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("macroSize"));
            set => SetFieldValue("macroSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Exponentially sharpens or lightens the Macro map rendering on the material
        /// </description>
        /// </value>
        public float MacroStrength {
            get => GenericMarshal.StringTo<float>(GetFieldValue("macroStrength"));
            set => SetFieldValue("macroStrength", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Changes how far camera can see the Macro map rendering on the material
        /// </description>
        /// </value>
        public float MacroDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("macroDistance"));
            set => SetFieldValue("macroDistance", GenericMarshal.ToString(value));
        }
    }
}
