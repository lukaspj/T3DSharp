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
    public class MaterialAsset : AssetBase {
        public MaterialAsset(bool pRegister = false)
            : base(pRegister) {
        }

        public MaterialAsset(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public MaterialAsset(string pName)
            : this(pName, false) {
        }

        public MaterialAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public MaterialAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public MaterialAsset(SimObject pObj)
            : base(pObj) {
        }

        public MaterialAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetScriptPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetScriptPath(IntPtr _this, GetScriptPath__Args args);
            private static _GetScriptPath _GetScriptPathFunc;
            internal static _GetScriptPath GetScriptPath() {
               _GetScriptPathFunc ??= Torque3D.LookupEngineFunction<_GetScriptPath>("fnMaterialAsset_getScriptPath");

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
               _FindMaterialDefinitionByAssetIdFunc ??= Torque3D.LookupEngineFunction<_FindMaterialDefinitionByAssetId>("fnMaterialAsset_findMaterialDefinitionByAssetId");

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
               _GetAssetIdByMaterialNameFunc ??= Torque3D.LookupEngineFunction<_GetAssetIdByMaterialName>("fnMaterialAsset_getAssetIdByMaterialName");

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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnMaterialAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnMaterialAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Gets the script file path for the asset.
        /// </description>
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
        /// Get the type info object for the MaterialAsset class.
        /// </description>
        /// <returns>The type info object for MaterialAsset</returns>
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
