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
    /// <summary>Represent a terrain object in a Torque 3D level</summary>
    /// <description>
    /// 
    /// </description>
    /// <code>
    /// new TerrainBlock(theTerrain)
    /// {
    ///    terrainFile = "art/terrains/Deathball Desert_0.ter";
    ///    squareSize = "2";
    ///    tile = "0";
    ///    baseTexSize = "1024";
    ///    screenError = "16";
    ///    position = "-1024 -1024 179.978";
    ///    rotation = "1 0 0 0";
    ///    scale = "1 1 1";
    ///    isRenderEnabled = "true";
    ///    canSaveDynamicFields = "1";
    /// };
    /// </code>
    /// <see cref="TerrainMaterial" />
    public class TerrainBlock : SceneObject {
        public TerrainBlock(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public TerrainBlock(string pName, bool pRegister)
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

        public TerrainBlock(string pName)
            : this(pName, false) {
        }

        public TerrainBlock(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public TerrainBlock(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public TerrainBlock(SimObject pObj)
            : base(pObj) {
        }

        public TerrainBlock(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Import__Args
            {
                internal int terrainObjectId;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string heightMapFile;
                internal float metersPerPixel;
                internal float heightScale;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string opacityLayerFiles;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string materialsStr;
                [MarshalAs(UnmanagedType.I1)]
                internal bool flipYAxis;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _Import(Import__Args args);
            private static _Import _ImportFunc;
            internal static _Import Import() {
               _ImportFunc ??= Torque3D.LookupEngineFunction<_Import>("fnTerrainBlock_import");

                return _ImportFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CreateNew__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string terrainName;
                internal uint resolution;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string materialName;
                [MarshalAs(UnmanagedType.I1)]
                internal bool genNoise;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _CreateNew(CreateNew__Args args);
            private static _CreateNew _CreateNewFunc;
            internal static _CreateNew CreateNew() {
               _CreateNewFunc ??= Torque3D.LookupEngineFunction<_CreateNew>("fnTerrainBlock_createNew");

                return _CreateNewFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ExportLayerMaps__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filePrefixStr;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string format;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _ExportLayerMaps(IntPtr _this, ExportLayerMaps__Args args);
            private static _ExportLayerMaps _ExportLayerMapsFunc;
            internal static _ExportLayerMaps ExportLayerMaps() {
               _ExportLayerMapsFunc ??= Torque3D.LookupEngineFunction<_ExportLayerMaps>("fnTerrainBlock_exportLayerMaps");

                return _ExportLayerMapsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ExportHeightMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileNameStr;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string format;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _ExportHeightMap(IntPtr _this, ExportHeightMap__Args args);
            private static _ExportHeightMap _ExportHeightMapFunc;
            internal static _ExportHeightMap ExportHeightMap() {
               _ExportHeightMapFunc ??= Torque3D.LookupEngineFunction<_ExportHeightMap>("fnTerrainBlock_exportHeightMap");

                return _ExportHeightMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RenameTerrainMaterial__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string oldMaterialName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newMaterialName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RenameTerrainMaterial(IntPtr _this, RenameTerrainMaterial__Args args);
            private static _RenameTerrainMaterial _RenameTerrainMaterialFunc;
            internal static _RenameTerrainMaterial RenameTerrainMaterial() {
               _RenameTerrainMaterialFunc ??= Torque3D.LookupEngineFunction<_RenameTerrainMaterial>("fnTerrainBlock_renameTerrainMaterial");

                return _RenameTerrainMaterialFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTerrainMaterialName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTerrainMaterialName(IntPtr _this, GetTerrainMaterialName__Args args);
            private static _GetTerrainMaterialName _GetTerrainMaterialNameFunc;
            internal static _GetTerrainMaterialName GetTerrainMaterialName() {
               _GetTerrainMaterialNameFunc ??= Torque3D.LookupEngineFunction<_GetTerrainMaterialName>("fnTerrainBlock_getTerrainMaterialName");

                return _GetTerrainMaterialNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTerrainMaterialCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetTerrainMaterialCount(IntPtr _this, GetTerrainMaterialCount__Args args);
            private static _GetTerrainMaterialCount _GetTerrainMaterialCountFunc;
            internal static _GetTerrainMaterialCount GetTerrainMaterialCount() {
               _GetTerrainMaterialCountFunc ??= Torque3D.LookupEngineFunction<_GetTerrainMaterialCount>("fnTerrainBlock_getTerrainMaterialCount");

                return _GetTerrainMaterialCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTerrain__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string terrain;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetTerrain(IntPtr _this, SetTerrain__Args args);
            private static _SetTerrain _SetTerrainFunc;
            internal static _SetTerrain SetTerrain() {
               _SetTerrainFunc ??= Torque3D.LookupEngineFunction<_SetTerrain>("fnTerrainBlock_setTerrain");

                return _SetTerrainFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTerrainAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTerrainAsset(IntPtr _this, GetTerrainAsset__Args args);
            private static _GetTerrainAsset _GetTerrainAssetFunc;
            internal static _GetTerrainAsset GetTerrainAsset() {
               _GetTerrainAssetFunc ??= Torque3D.LookupEngineFunction<_GetTerrainAsset>("fnTerrainBlock_getTerrainAsset");

                return _GetTerrainAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTerrain__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTerrain(IntPtr _this, GetTerrain__Args args);
            private static _GetTerrain _GetTerrainFunc;
            internal static _GetTerrain GetTerrain() {
               _GetTerrainFunc ??= Torque3D.LookupEngineFunction<_GetTerrain>("fnTerrainBlock_getTerrain");

                return _GetTerrainFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMaterialsDirty__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMaterialsDirty(IntPtr _this, SetMaterialsDirty__Args args);
            private static _SetMaterialsDirty _SetMaterialsDirtyFunc;
            internal static _SetMaterialsDirty SetMaterialsDirty() {
               _SetMaterialsDirtyFunc ??= Torque3D.LookupEngineFunction<_SetMaterialsDirty>("fnTerrainBlock_setMaterialsDirty");

                return _SetMaterialsDirtyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SaveAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SaveAsset(IntPtr _this, SaveAsset__Args args);
            private static _SaveAsset _SaveAssetFunc;
            internal static _SaveAsset SaveAsset() {
               _SaveAssetFunc ??= Torque3D.LookupEngineFunction<_SaveAsset>("fnTerrainBlock_saveAsset");

                return _SaveAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Save__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Save(IntPtr _this, Save__Args args);
            private static _Save _SaveFunc;
            internal static _Save Save() {
               _SaveFunc ??= Torque3D.LookupEngineFunction<_Save>("fnTerrainBlock_save");

                return _SaveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnTerrainBlock_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnTerrainBlock_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public static int Import(int terrainObjectId, string heightMapFile, float metersPerPixel, float heightScale, string opacityLayerFiles, string materialsStr, bool flipYAxis = true) {
             InternalUnsafeMethods.Import__Args _args = new InternalUnsafeMethods.Import__Args() {
                terrainObjectId = terrainObjectId,
                heightMapFile = heightMapFile,
                metersPerPixel = metersPerPixel,
                heightScale = heightScale,
                opacityLayerFiles = opacityLayerFiles,
                materialsStr = materialsStr,
                flipYAxis = flipYAxis,
             };
             int _engineResult = InternalUnsafeMethods.Import()(_args);
             return _engineResult;
        }

        /// 
        public static int CreateNew(string terrainName, uint resolution, string materialName, bool genNoise) {
             InternalUnsafeMethods.CreateNew__Args _args = new InternalUnsafeMethods.CreateNew__Args() {
                terrainName = terrainName,
                resolution = resolution,
                materialName = materialName,
                genNoise = genNoise,
             };
             int _engineResult = InternalUnsafeMethods.CreateNew()(_args);
             return _engineResult;
        }

        /// <description>
        /// (string filePrefix, [string format]) - export the terrain block's layer maps to bitmap files (default: png)
        /// </description>
        public bool ExportLayerMaps(string filePrefixStr, string format = "png") {
             InternalUnsafeMethods.ExportLayerMaps__Args _args = new InternalUnsafeMethods.ExportLayerMaps__Args() {
                filePrefixStr = filePrefixStr,
                format = format,
             };
             bool _engineResult = InternalUnsafeMethods.ExportLayerMaps()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (string filename, [string format]) - export the terrain block's heightmap to a bitmap file (default: png)
        /// </description>
        public bool ExportHeightMap(string fileNameStr, string format = "png") {
             InternalUnsafeMethods.ExportHeightMap__Args _args = new InternalUnsafeMethods.ExportHeightMap__Args() {
                fileNameStr = fileNameStr,
                format = format,
             };
             bool _engineResult = InternalUnsafeMethods.ExportHeightMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Updates the terrain material from the original to the new name in the file. Mostly used for import/conversions.
        /// </description>
        public bool RenameTerrainMaterial(string oldMaterialName, string newMaterialName) {
             InternalUnsafeMethods.RenameTerrainMaterial__Args _args = new InternalUnsafeMethods.RenameTerrainMaterial__Args() {
                oldMaterialName = oldMaterialName,
                newMaterialName = newMaterialName,
             };
             bool _engineResult = InternalUnsafeMethods.RenameTerrainMaterial()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the number of terrain materials for this block
        /// </description>
        public string GetTerrainMaterialName(int index) {
             InternalUnsafeMethods.GetTerrainMaterialName__Args _args = new InternalUnsafeMethods.GetTerrainMaterialName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTerrainMaterialName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the number of terrain materials for this block
        /// </description>
        public int GetTerrainMaterialCount() {
             InternalUnsafeMethods.GetTerrainMaterialCount__Args _args = new InternalUnsafeMethods.GetTerrainMaterialCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetTerrainMaterialCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Terrain assignment.first tries asset then flat file.
        /// </description>
        public bool SetTerrain(string terrain) {
             InternalUnsafeMethods.SetTerrain__Args _args = new InternalUnsafeMethods.SetTerrain__Args() {
                terrain = terrain,
             };
             bool _engineResult = InternalUnsafeMethods.SetTerrain()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Returns the assetId used for this terrain block
        /// </description>
        public string GetTerrainAsset() {
             InternalUnsafeMethods.GetTerrainAsset__Args _args = new InternalUnsafeMethods.GetTerrainAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTerrainAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Returns the terrain file used for this terrain block, either via the asset or the filename assigned, which ever is valid
        /// </description>
        public string GetTerrain() {
             InternalUnsafeMethods.GetTerrain__Args _args = new InternalUnsafeMethods.GetTerrain__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTerrain()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// 
        public void SetMaterialsDirty() {
             InternalUnsafeMethods.SetMaterialsDirty__Args _args = new InternalUnsafeMethods.SetMaterialsDirty__Args() {
             };
             InternalUnsafeMethods.SetMaterialsDirty()(ObjectPtr, _args);
        }

        /// <summary>Saves the terrain block's terrain file to the specified file name.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="fileName">Name and path of file to save terrain data to.</param>
        /// <returns>True if file save was successful, false otherwise</returns>
        public bool SaveAsset() {
             InternalUnsafeMethods.SaveAsset__Args _args = new InternalUnsafeMethods.SaveAsset__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.SaveAsset()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Saves the terrain block's terrain file to the specified file name.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="fileName">Name and path of file to save terrain data to.</param>
        /// <returns>True if file save was successful, false otherwise</returns>
        public bool Save(string fileName) {
             InternalUnsafeMethods.Save__Args _args = new InternalUnsafeMethods.Save__Args() {
                fileName = fileName,
             };
             bool _engineResult = InternalUnsafeMethods.Save()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the TerrainBlock class.
        /// </description>
        /// <returns>The type info object for TerrainBlock</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// The source terrain data asset.
        /// </description>
        /// </value>
        public string TerrainAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("TerrainAsset"));
            set => SetFieldValue("TerrainAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The source terrain data file.
        /// </description>
        /// </value>
        public string TerrainFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("terrainFile"));
            set => SetFieldValue("terrainFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Allows the terrain to cast shadows onto itself and other objects.
        /// </description>
        /// </value>
        public bool CastShadows {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("castShadows"));
            set => SetFieldValue("castShadows", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Indicates the spacing between points on the XY plane on the terrain.
        /// </description>
        /// </value>
        public float SquareSize {
            get => GenericMarshal.StringTo<float>(GetFieldValue("squareSize"));
            set => SetFieldValue("squareSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Size of base texture size per meter.
        /// </description>
        /// </value>
        public int BaseTexSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("baseTexSize"));
            set => SetFieldValue("baseTexSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public baseTexFormat BaseTexFormat {
            get => GenericMarshal.StringTo<baseTexFormat>(GetFieldValue("baseTexFormat"));
            set => SetFieldValue("baseTexFormat", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Light map dimensions in pixels.
        /// </description>
        /// </value>
        public int LightMapSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("lightMapSize"));
            set => SetFieldValue("lightMapSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Not yet implemented.
        /// </description>
        /// </value>
        public int ScreenError {
            get => GenericMarshal.StringTo<int>(GetFieldValue("screenError"));
            set => SetFieldValue("screenError", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether or not to update the Base Texture
        /// </description>
        /// </value>
        public bool UpdateBasetex {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("updateBasetex"));
            set => SetFieldValue("updateBasetex", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool IgnoreZodiacs {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ignoreZodiacs"));
            set => SetFieldValue("ignoreZodiacs", GenericMarshal.ToString(value));
        }
    }
}
