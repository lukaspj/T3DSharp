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
    public class AssetBase : SimGroup {
        public AssetBase(bool pRegister = false)
            : base(pRegister) {
        }

        public AssetBase(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public AssetBase(string pName)
            : this(pName, false) {
        }

        public AssetBase(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public AssetBase(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public AssetBase(SimObject pObj)
            : base(pObj) {
        }

        public AssetBase(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnAssetBase_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnAssetBase_create");

                return _CreateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetStatusString__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetStatusString(IntPtr _this, GetStatusString__Args args);
            private static _GetStatusString _GetStatusStringFunc;
            internal static _GetStatusString GetStatusString() {
               _GetStatusStringFunc ??= Torque3D.LookupEngineFunction<_GetStatusString>("fnAssetBase_getStatusString");

                return _GetStatusStringFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetStatus__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetStatus(IntPtr _this, GetStatus__Args args);
            private static _GetStatus _GetStatusFunc;
            internal static _GetStatus GetStatus() {
               _GetStatusFunc ??= Torque3D.LookupEngineFunction<_GetStatus>("fnAssetBase_getStatus");

                return _GetStatusFunc;
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
               _SaveAssetFunc ??= Torque3D.LookupEngineFunction<_SaveAsset>("fnAssetBase_saveAsset");

                return _SaveAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddAssetDependencyField__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pFieldName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pAssetId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddAssetDependencyField(IntPtr _this, AddAssetDependencyField__Args args);
            private static _AddAssetDependencyField _AddAssetDependencyFieldFunc;
            internal static _AddAssetDependencyField AddAssetDependencyField() {
               _AddAssetDependencyFieldFunc ??= Torque3D.LookupEngineFunction<_AddAssetDependencyField>("fnAssetBase_addAssetDependencyField");

                return _AddAssetDependencyFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearAssetDependencyFields__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pFieldName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearAssetDependencyFields(IntPtr _this, ClearAssetDependencyFields__Args args);
            private static _ClearAssetDependencyFields _ClearAssetDependencyFieldsFunc;
            internal static _ClearAssetDependencyFields ClearAssetDependencyFields() {
               _ClearAssetDependencyFieldsFunc ??= Torque3D.LookupEngineFunction<_ClearAssetDependencyFields>("fnAssetBase_clearAssetDependencyFields");

                return _ClearAssetDependencyFieldsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetDependencyField__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pFieldName;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAssetDependencyField(IntPtr _this, GetAssetDependencyField__Args args);
            private static _GetAssetDependencyField _GetAssetDependencyFieldFunc;
            internal static _GetAssetDependencyField GetAssetDependencyField() {
               _GetAssetDependencyFieldFunc ??= Torque3D.LookupEngineFunction<_GetAssetDependencyField>("fnAssetBase_getAssetDependencyField");

                return _GetAssetDependencyFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetDependencyFieldCount__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pFieldName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAssetDependencyFieldCount(IntPtr _this, GetAssetDependencyFieldCount__Args args);
            private static _GetAssetDependencyFieldCount _GetAssetDependencyFieldCountFunc;
            internal static _GetAssetDependencyFieldCount GetAssetDependencyFieldCount() {
               _GetAssetDependencyFieldCountFunc ??= Torque3D.LookupEngineFunction<_GetAssetDependencyFieldCount>("fnAssetBase_getAssetDependencyFieldCount");

                return _GetAssetDependencyFieldCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetId__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAssetId(IntPtr _this, GetAssetId__Args args);
            private static _GetAssetId _GetAssetIdFunc;
            internal static _GetAssetId GetAssetId() {
               _GetAssetIdFunc ??= Torque3D.LookupEngineFunction<_GetAssetId>("fnAssetBase_getAssetId");

                return _GetAssetIdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RefreshAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RefreshAsset(IntPtr _this, RefreshAsset__Args args);
            private static _RefreshAsset _RefreshAssetFunc;
            internal static _RefreshAsset RefreshAsset() {
               _RefreshAssetFunc ??= Torque3D.LookupEngineFunction<_RefreshAsset>("fnAssetBase_refreshAsset");

                return _RefreshAssetFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the AssetBase class.
        /// </description>
        /// <returns>The type info object for AssetBase</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        /// <description>
        /// Returns the load status of the asset.
        /// </description>
        /// <returns>What status code the asset had after being loaded.</returns>
        public string GetStatusString() {
             InternalUnsafeMethods.GetStatusString__Args _args = new InternalUnsafeMethods.GetStatusString__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetStatusString()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get status
        /// </description>
        public int GetStatus() {
             InternalUnsafeMethods.GetStatus__Args _args = new InternalUnsafeMethods.GetStatus__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetStatus()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Saves the asset definition.
        /// </description>
        /// <returns>Whether the save was successful.</returns>
        public bool SaveAsset() {
             InternalUnsafeMethods.SaveAsset__Args _args = new InternalUnsafeMethods.SaveAsset__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.SaveAsset()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Adds an asset dependency field to the asset definition.
        /// </description>
        /// <param name="fieldName">The name of the field. Will automatically increment the tailing number if the field is used multiple times</param>
        /// <param name="assetId">The assetId to be marked as a dependency</param>
        public void AddAssetDependencyField(string pFieldName = "", string pAssetId = "") {
             InternalUnsafeMethods.AddAssetDependencyField__Args _args = new InternalUnsafeMethods.AddAssetDependencyField__Args() {
                pFieldName = pFieldName,
                pAssetId = pAssetId,
             };
             InternalUnsafeMethods.AddAssetDependencyField()(ObjectPtr, _args);
        }

        /// <description>
        /// Clears any asset dependency fields matching the name provided.
        /// </description>
        /// <param name="fieldName">The name of the fields to be cleared</param>
        public void ClearAssetDependencyFields(string pFieldName = "") {
             InternalUnsafeMethods.ClearAssetDependencyFields__Args _args = new InternalUnsafeMethods.ClearAssetDependencyFields__Args() {
                pFieldName = pFieldName,
             };
             InternalUnsafeMethods.ClearAssetDependencyFields()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets an asset dependency field to the asset definition at a given index.
        /// </description>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="index">The index of the field to look up in the event there are multiple dependency fields. Defaults to 0</param>
        /// <returns>The assetID assigned to the given dependency field.</returns>
        public string GetAssetDependencyField(string pFieldName = "", int index = 0) {
             InternalUnsafeMethods.GetAssetDependencyField__Args _args = new InternalUnsafeMethods.GetAssetDependencyField__Args() {
                pFieldName = pFieldName,
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetDependencyField()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the number of asset dependencies of a given field name.
        /// eg. Would return '2' if you searched for 'myDependencyField'
        /// and the asset had myDependencyField0 and myDependencyField1
        /// </description>
        /// <param name="fieldName">The name of the field to get a count of</param>
        /// <returns>The number of dependency fields matching the search name.</returns>
        public int GetAssetDependencyFieldCount(string pFieldName = "") {
             InternalUnsafeMethods.GetAssetDependencyFieldCount__Args _args = new InternalUnsafeMethods.GetAssetDependencyFieldCount__Args() {
                pFieldName = pFieldName,
             };
             int _engineResult = InternalUnsafeMethods.GetAssetDependencyFieldCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets the assets' Asset Id.  This is only available if the asset was acquired from the asset manager.
        /// </description>
        /// <returns>The assets' Asset Id.</returns>
        public string GetAssetId() {
             InternalUnsafeMethods.GetAssetId__Args _args = new InternalUnsafeMethods.GetAssetId__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetId()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Refresh the asset.
        /// </description>
        /// <returns>No return value.</returns>
        public void RefreshAsset() {
             InternalUnsafeMethods.RefreshAsset__Args _args = new InternalUnsafeMethods.RefreshAsset__Args() {
             };
             InternalUnsafeMethods.RefreshAsset()(ObjectPtr, _args);
        }


        /// <value>
        /// <description>
        /// The name of the asset.  The is not a unique identification like an asset Id.
        /// </description>
        /// </value>
        public string AssetName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetName"));
            set => SetFieldValue("AssetName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The simple description of the asset contents.
        /// </description>
        /// </value>
        public string AssetDescription {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetDescription"));
            set => SetFieldValue("AssetDescription", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// An arbitrary category that can be used to categorized assets.
        /// </description>
        /// </value>
        public string AssetCategory {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AssetCategory"));
            set => SetFieldValue("AssetCategory", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the asset is automatically unloaded when an asset is released and has no other acquisitions or not.
        /// </description>
        /// </value>
        public bool AssetAutoUnload {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AssetAutoUnload"));
            set => SetFieldValue("AssetAutoUnload", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the asset is used internally only or not.
        /// </description>
        /// </value>
        public bool AssetInternal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AssetInternal"));
            set => SetFieldValue("AssetInternal", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the asset is private or not.
        /// </description>
        /// </value>
        public bool AssetPrivate {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AssetPrivate"));
            set => SetFieldValue("AssetPrivate", GenericMarshal.ToString(value));
        }
    }
}
