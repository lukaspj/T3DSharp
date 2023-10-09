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
    /// 
    public class TerrainMaterialAsset : AssetBase {
        public TerrainMaterialAsset(bool pRegister = false)
            : base(pRegister) {
        }

        public TerrainMaterialAsset(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public TerrainMaterialAsset(string pName)
            : this(pName, false) {
        }

        public TerrainMaterialAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public TerrainMaterialAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public TerrainMaterialAsset(SimObject pObj)
            : base(pObj) {
        }

        public TerrainMaterialAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFXMaterialDefinition__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetFXMaterialDefinition(IntPtr _this, GetFXMaterialDefinition__Args args);
            private static _GetFXMaterialDefinition _GetFXMaterialDefinitionFunc;
            internal static _GetFXMaterialDefinition GetFXMaterialDefinition() {
               _GetFXMaterialDefinitionFunc ??= Torque3D.LookupEngineFunction<_GetFXMaterialDefinition>("fnTerrainMaterialAsset_getFXMaterialDefinition");

                return _GetFXMaterialDefinitionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMaterialDefinition__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMaterialDefinition(IntPtr _this, GetMaterialDefinition__Args args);
            private static _GetMaterialDefinition _GetMaterialDefinitionFunc;
            internal static _GetMaterialDefinition GetMaterialDefinition() {
               _GetMaterialDefinitionFunc ??= Torque3D.LookupEngineFunction<_GetMaterialDefinition>("fnTerrainMaterialAsset_getMaterialDefinition");

                return _GetMaterialDefinitionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetScriptPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetScriptPath(IntPtr _this, GetScriptPath__Args args);
            private static _GetScriptPath _GetScriptPathFunc;
            internal static _GetScriptPath GetScriptPath() {
               _GetScriptPathFunc ??= Torque3D.LookupEngineFunction<_GetScriptPath>("fnTerrainMaterialAsset_getScriptPath");

                return _GetScriptPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FindMaterialDefinitionByAssetId__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _FindMaterialDefinitionByAssetId(FindMaterialDefinitionByAssetId__Args args);
            private static _FindMaterialDefinitionByAssetId _FindMaterialDefinitionByAssetIdFunc;
            internal static _FindMaterialDefinitionByAssetId FindMaterialDefinitionByAssetId() {
               _FindMaterialDefinitionByAssetIdFunc ??= Torque3D.LookupEngineFunction<_FindMaterialDefinitionByAssetId>("fnTerrainMaterialAsset_findMaterialDefinitionByAssetId");

                return _FindMaterialDefinitionByAssetIdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetIdByMaterialName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string materialName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAssetIdByMaterialName(GetAssetIdByMaterialName__Args args);
            private static _GetAssetIdByMaterialName _GetAssetIdByMaterialNameFunc;
            internal static _GetAssetIdByMaterialName GetAssetIdByMaterialName() {
               _GetAssetIdByMaterialNameFunc ??= Torque3D.LookupEngineFunction<_GetAssetIdByMaterialName>("fnTerrainMaterialAsset_getAssetIdByMaterialName");

                return _GetAssetIdByMaterialNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnTerrainMaterialAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnTerrainMaterialAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Queries the Asset Database to see if any asset exists that is associated with the provided material name.
        /// </description>
        /// <returns>The AssetId of the associated asset, if any.</returns>
        public int GetFXMaterialDefinition() {
             InternalUnsafeMethods.GetFXMaterialDefinition__Args _args = new InternalUnsafeMethods.GetFXMaterialDefinition__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetFXMaterialDefinition()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Queries the Asset Database to see if any asset exists that is associated with the provided material name.
        /// </description>
        /// <returns>The AssetId of the associated asset, if any.</returns>
        public int GetMaterialDefinition() {
             InternalUnsafeMethods.GetMaterialDefinition__Args _args = new InternalUnsafeMethods.GetMaterialDefinition__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetMaterialDefinition()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Queries the Asset Database to see if any asset exists that is associated with the provided material name.
        /// </description>
        /// <returns>The AssetId of the associated asset, if any.</returns>
        public string GetScriptPath() {
             InternalUnsafeMethods.GetScriptPath__Args _args = new InternalUnsafeMethods.GetScriptPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetScriptPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Queries the MaterialSet to see if any MaterialDefinition exists that is associated to the provided assetId.
        /// </description>
        /// <returns>The MaterialDefinition Id associated to the assetId, if any</returns>
        public static int FindMaterialDefinitionByAssetId(string assetId = "") {
             InternalUnsafeMethods.FindMaterialDefinitionByAssetId__Args _args = new InternalUnsafeMethods.FindMaterialDefinitionByAssetId__Args() {
                assetId = assetId,
             };
             int _engineResult = InternalUnsafeMethods.FindMaterialDefinitionByAssetId()(_args);
             return _engineResult;
        }

        /// <description>
        /// Queries the Asset Database to see if any asset exists that is associated with the provided material name.
        /// </description>
        /// <returns>The AssetId of the associated asset, if any.</returns>
        public static string GetAssetIdByMaterialName(string materialName = "") {
             InternalUnsafeMethods.GetAssetIdByMaterialName__Args _args = new InternalUnsafeMethods.GetAssetIdByMaterialName__Args() {
                materialName = materialName,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetIdByMaterialName()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the TerrainMaterialAsset class.
        /// </description>
        /// <returns>The type info object for TerrainMaterialAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public string ScriptFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ScriptFile"));
            set => SetFieldValue("ScriptFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Name of the material definition this asset is for.
        /// </description>
        /// </value>
        public string MaterialDefinitionName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("materialDefinitionName"));
            set => SetFieldValue("materialDefinitionName", GenericMarshal.ToString(value));
        }
    }
}
