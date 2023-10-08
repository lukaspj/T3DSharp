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
    /// <summary>Defines properties for an AssetImportObject object.</summary>
    /// <description>
    /// 
    /// </description>
    public class AssetImporter : SimObject {
        public AssetImporter(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public AssetImporter(string pName, bool pRegister)
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

        public AssetImporter(string pName)
            : this(pName, false) {
        }

        public AssetImporter(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public AssetImporter(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public AssetImporter(SimObject pObj)
            : base(pObj) {
        }

        public AssetImporter(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnAssetImporter_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnAssetImporter_create");

                return _CreateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetImportConfig__Args
            {
                internal IntPtr importConfig;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetImportConfig(IntPtr _this, SetImportConfig__Args args);
            private static _SetImportConfig _SetImportConfigFunc;
            internal static _SetImportConfig SetImportConfig() {
               _SetImportConfigFunc ??= Torque3D.LookupEngineFunction<_SetImportConfig>("fnAssetImporter_setImportConfig");

                return _SetImportConfigFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteImportingAsset__Args
            {
                internal IntPtr assetItem;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteImportingAsset(IntPtr _this, DeleteImportingAsset__Args args);
            private static _DeleteImportingAsset _DeleteImportingAssetFunc;
            internal static _DeleteImportingAsset DeleteImportingAsset() {
               _DeleteImportingAssetFunc ??= Torque3D.LookupEngineFunction<_DeleteImportingAsset>("fnAssetImporter_deleteImportingAsset");

                return _DeleteImportingAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetItemChild__Args
            {
                internal IntPtr assetItem;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetAssetItemChild(IntPtr _this, GetAssetItemChild__Args args);
            private static _GetAssetItemChild _GetAssetItemChildFunc;
            internal static _GetAssetItemChild GetAssetItemChild() {
               _GetAssetItemChildFunc ??= Torque3D.LookupEngineFunction<_GetAssetItemChild>("fnAssetImporter_getAssetItemChild");

                return _GetAssetItemChildFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetItemChildCount__Args
            {
                internal IntPtr assetItem;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAssetItemChildCount(IntPtr _this, GetAssetItemChildCount__Args args);
            private static _GetAssetItemChildCount _GetAssetItemChildCountFunc;
            internal static _GetAssetItemChildCount GetAssetItemChildCount() {
               _GetAssetItemChildCountFunc ??= Torque3D.LookupEngineFunction<_GetAssetItemChildCount>("fnAssetImporter_getAssetItemChildCount");

                return _GetAssetItemChildCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetItem__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _GetAssetItem(IntPtr _this, GetAssetItem__Args args);
            private static _GetAssetItem _GetAssetItemFunc;
            internal static _GetAssetItem GetAssetItem() {
               _GetAssetItemFunc ??= Torque3D.LookupEngineFunction<_GetAssetItem>("fnAssetImporter_getAssetItem");

                return _GetAssetItemFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetItemCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAssetItemCount(IntPtr _this, GetAssetItemCount__Args args);
            private static _GetAssetItemCount _GetAssetItemCountFunc;
            internal static _GetAssetItemCount GetAssetItemCount() {
               _GetAssetItemCountFunc ??= Torque3D.LookupEngineFunction<_GetAssetItemCount>("fnAssetImporter_getAssetItemCount");

                return _GetAssetItemCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ImportAssets__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ImportAssets(IntPtr _this, ImportAssets__Args args);
            private static _ImportAssets _ImportAssetsFunc;
            internal static _ImportAssets ImportAssets() {
               _ImportAssetsFunc ??= Torque3D.LookupEngineFunction<_ImportAssets>("fnAssetImporter_importAssets");

                return _ImportAssetsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ResolveAssetItemIssues__Args
            {
                internal IntPtr assetItem;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResolveAssetItemIssues(IntPtr _this, ResolveAssetItemIssues__Args args);
            private static _ResolveAssetItemIssues _ResolveAssetItemIssuesFunc;
            internal static _ResolveAssetItemIssues ResolveAssetItemIssues() {
               _ResolveAssetItemIssuesFunc ??= Torque3D.LookupEngineFunction<_ResolveAssetItemIssues>("fnAssetImporter_resolveAssetItemIssues");

                return _ResolveAssetItemIssuesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct HasImportIssues__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _HasImportIssues(IntPtr _this, HasImportIssues__Args args);
            private static _HasImportIssues _HasImportIssuesFunc;
            internal static _HasImportIssues HasImportIssues() {
               _HasImportIssuesFunc ??= Torque3D.LookupEngineFunction<_HasImportIssues>("fnAssetImporter_hasImportIssues");

                return _HasImportIssuesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ProcessImportingAssets__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ProcessImportingAssets(IntPtr _this, ProcessImportingAssets__Args args);
            private static _ProcessImportingAssets _ProcessImportingAssetsFunc;
            internal static _ProcessImportingAssets ProcessImportingAssets() {
               _ProcessImportingAssetsFunc ??= Torque3D.LookupEngineFunction<_ProcessImportingAssets>("fnAssetImporter_processImportingAssets");

                return _ProcessImportingAssetsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddImportingAssetItem__Args
            {
                internal IntPtr assetItem;
                internal IntPtr parentItem;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddImportingAssetItem(IntPtr _this, AddImportingAssetItem__Args args);
            private static _AddImportingAssetItem _AddImportingAssetItemFunc;
            internal static _AddImportingAssetItem AddImportingAssetItem() {
               _AddImportingAssetItemFunc ??= Torque3D.LookupEngineFunction<_AddImportingAssetItem>("fnAssetImporter_addImportingAssetItem");

                return _AddImportingAssetItemFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddImportingFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _AddImportingFile(IntPtr _this, AddImportingFile__Args args);
            private static _AddImportingFile _AddImportingFileFunc;
            internal static _AddImportingFile AddImportingFile() {
               _AddImportingFileFunc ??= Torque3D.LookupEngineFunction<_AddImportingFile>("fnAssetImporter_addImportingFile");

                return _AddImportingFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AutoImportFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string typeHint;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _AutoImportFile(IntPtr _this, AutoImportFile__Args args);
            private static _AutoImportFile _AutoImportFileFunc;
            internal static _AutoImportFile AutoImportFile() {
               _AutoImportFileFunc ??= Torque3D.LookupEngineFunction<_AutoImportFile>("fnAssetImporter_autoImportFile");

                return _AutoImportFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetActivityLogLine__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetActivityLogLine(IntPtr _this, GetActivityLogLine__Args args);
            private static _GetActivityLogLine _GetActivityLogLineFunc;
            internal static _GetActivityLogLine GetActivityLogLine() {
               _GetActivityLogLineFunc ??= Torque3D.LookupEngineFunction<_GetActivityLogLine>("fnAssetImporter_getActivityLogLine");

                return _GetActivityLogLineFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetActivityLogLineCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetActivityLogLineCount(IntPtr _this, GetActivityLogLineCount__Args args);
            private static _GetActivityLogLineCount _GetActivityLogLineCountFunc;
            internal static _GetActivityLogLineCount GetActivityLogLineCount() {
               _GetActivityLogLineCountFunc ??= Torque3D.LookupEngineFunction<_GetActivityLogLineCount>("fnAssetImporter_getActivityLogLineCount");

                return _GetActivityLogLineCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpActivityLog__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpActivityLog(IntPtr _this, DumpActivityLog__Args args);
            private static _DumpActivityLog _DumpActivityLogFunc;
            internal static _DumpActivityLog DumpActivityLog() {
               _DumpActivityLogFunc ??= Torque3D.LookupEngineFunction<_DumpActivityLog>("fnAssetImporter_dumpActivityLog");

                return _DumpActivityLogFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetImportSession__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool forceResetSession;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetImportSession(IntPtr _this, ResetImportSession__Args args);
            private static _ResetImportSession _ResetImportSessionFunc;
            internal static _ResetImportSession ResetImportSession() {
               _ResetImportSessionFunc ??= Torque3D.LookupEngineFunction<_ResetImportSession>("fnAssetImporter_resetImportSession");

                return _ResetImportSessionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetTargetPath__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetTargetPath(IntPtr _this, SetTargetPath__Args args);
            private static _SetTargetPath _SetTargetPathFunc;
            internal static _SetTargetPath SetTargetPath() {
               _SetTargetPathFunc ??= Torque3D.LookupEngineFunction<_SetTargetPath>("fnAssetImporter_setTargetPath");

                return _SetTargetPathFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the AssetImporter class.
        /// </description>
        /// <returns>The type info object for AssetImporter</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        /// <description>
        /// Sets the import config to be used via a AssetImportConfig object.
        /// </description>
        /// <param name="importConfig">The AssetImportConfig object to use.</param>
        public void SetImportConfig(AssetImportConfig importConfig = null) {
             InternalUnsafeMethods.SetImportConfig__Args _args = new InternalUnsafeMethods.SetImportConfig__Args() {
                importConfig = importConfig.ObjectPtr,
             };
             InternalUnsafeMethods.SetImportConfig()(ObjectPtr, _args);
        }

        /// <description>
        /// Deletes an importing AssetImportObject from the import session.
        /// </description>
        /// <param name="assetItem">The AssetImportObject to delete.</param>
        public void DeleteImportingAsset(AssetImportObject assetItem = null) {
             InternalUnsafeMethods.DeleteImportingAsset__Args _args = new InternalUnsafeMethods.DeleteImportingAsset__Args() {
                assetItem = assetItem.ObjectPtr,
             };
             InternalUnsafeMethods.DeleteImportingAsset()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets a specific child item of a given importing asset item.
        /// </description>
        /// <param name="assetItem">The AssetImportObject to get the child from.</param>
        /// <param name="index">The index of the child to get.</param>
        /// <returns>The child AssetImportObect</returns>
        public AssetImportObject GetAssetItemChild(AssetImportObject assetItem = null, int index = 0) {
             InternalUnsafeMethods.GetAssetItemChild__Args _args = new InternalUnsafeMethods.GetAssetItemChild__Args() {
                assetItem = assetItem.ObjectPtr,
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetItemChild()(ObjectPtr, _args);
             return new AssetImportObject(_engineResult);
        }

        /// <description>
        /// Gets number of child items for a given importing asset item.
        /// </description>
        /// <param name="assetItem">The AssetImportObject to get the number of children of.</param>
        /// <returns>The number of child items</returns>
        public int GetAssetItemChildCount(AssetImportObject assetItem = null) {
             InternalUnsafeMethods.GetAssetItemChildCount__Args _args = new InternalUnsafeMethods.GetAssetItemChildCount__Args() {
                assetItem = assetItem.ObjectPtr,
             };
             int _engineResult = InternalUnsafeMethods.GetAssetItemChildCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Gets a specific import asset item.
        /// </description>
        /// <param name="index">The index of the AssetImportObject to be returned.</param>
        /// <returns>AssetImportObject</returns>
        public AssetImportObject GetAssetItem(int index = 0) {
             InternalUnsafeMethods.GetAssetItem__Args _args = new InternalUnsafeMethods.GetAssetItem__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetItem()(ObjectPtr, _args);
             return new AssetImportObject(_engineResult);
        }

        /// <description>
        /// Gets the number of importing asset items.
        /// </description>
        /// <returns>The number of importing asset items</returns>
        public int GetAssetItemCount() {
             InternalUnsafeMethods.GetAssetItemCount__Args _args = new InternalUnsafeMethods.GetAssetItemCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetAssetItemCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Runs the actual import action on the items.
        /// </description>
        public void ImportAssets() {
             InternalUnsafeMethods.ImportAssets__Args _args = new InternalUnsafeMethods.ImportAssets__Args() {
             };
             InternalUnsafeMethods.ImportAssets()(ObjectPtr, _args);
        }

        /// <description>
        /// Runs the issue resolver to attempt to correct any simple issues, such as utilizing the config's settings to resolve collisions.
        /// </description>
        public void ResolveAssetItemIssues(AssetImportObject assetItem = null) {
             InternalUnsafeMethods.ResolveAssetItemIssues__Args _args = new InternalUnsafeMethods.ResolveAssetItemIssues__Args() {
                assetItem = assetItem.ObjectPtr,
             };
             InternalUnsafeMethods.ResolveAssetItemIssues()(ObjectPtr, _args);
        }

        /// <description>
        /// Validates the status of the importing items.
        /// </description>
        /// <returns>False if there are no issues, true if there are importing issues</returns>
        public bool HasImportIssues() {
             InternalUnsafeMethods.HasImportIssues__Args _args = new InternalUnsafeMethods.HasImportIssues__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.HasImportIssues()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Processes the importing assets.
        /// </description>
        public void ProcessImportingAssets() {
             InternalUnsafeMethods.ProcessImportingAssets__Args _args = new InternalUnsafeMethods.ProcessImportingAssets__Args() {
             };
             InternalUnsafeMethods.ProcessImportingAssets()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds an existing AssetImportObject to the current improting session.
        /// </description>
        /// <param name="assetItem">The AssetImportObject to be added to the import session.</param>
        /// <param name="parentItem">An AssetImportObject that to act as the parent of the item being added.</param>
        public void AddImportingAssetItem(AssetImportObject assetItem = null, AssetImportObject parentItem = null) {
             InternalUnsafeMethods.AddImportingAssetItem__Args _args = new InternalUnsafeMethods.AddImportingAssetItem__Args() {
                assetItem = assetItem.ObjectPtr,
                parentItem = parentItem.ObjectPtr,
             };
             InternalUnsafeMethods.AddImportingAssetItem()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds a filepath to the current importing session.
        /// </description>
        /// <param name="path">The path to the file to be imported.</param>
        /// <returns>The AssetImportObject from the import session.</returns>
        public AssetImportObject AddImportingFile(string path = "") {
             InternalUnsafeMethods.AddImportingFile__Args _args = new InternalUnsafeMethods.AddImportingFile__Args() {
                path = path,
             };
             IntPtr _engineResult = InternalUnsafeMethods.AddImportingFile()(ObjectPtr, _args);
             return new AssetImportObject(_engineResult);
        }

        /// <description>
        /// Run the full import process on a specific file.
        /// </description>
        /// <returns>If import is successful, the assetId of the new asset. If it failed, an empty string.</returns>
        public string AutoImportFile(string path = "", string typeHint = "") {
             InternalUnsafeMethods.AutoImportFile__Args _args = new InternalUnsafeMethods.AutoImportFile__Args() {
                path = path,
                typeHint = typeHint,
             };
             IntPtr _engineResult = InternalUnsafeMethods.AutoImportFile()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets a specific line in the import activity log.
        /// </description>
        /// <param name="index">The index of the line to be returned.</param>
        /// <returns>The string of the requested line of the activity log</returns>
        public string GetActivityLogLine(int index = 0) {
             InternalUnsafeMethods.GetActivityLogLine__Args _args = new InternalUnsafeMethods.GetActivityLogLine__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetActivityLogLine()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the number of lines in the import activity log.
        /// </description>
        /// <returns>The number of lines in the import activity log.</returns>
        public int GetActivityLogLineCount() {
             InternalUnsafeMethods.GetActivityLogLineCount__Args _args = new InternalUnsafeMethods.GetActivityLogLineCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetActivityLogLineCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Dumps the import activity log. If the importer is set to, it will save to file, otherwise dump to console.
        /// </description>
        public void DumpActivityLog() {
             InternalUnsafeMethods.DumpActivityLog__Args _args = new InternalUnsafeMethods.DumpActivityLog__Args() {
             };
             InternalUnsafeMethods.DumpActivityLog()(ObjectPtr, _args);
        }

        /// <description>
        /// Resets the importer's import session. All existing import items, logs, etc will be cleared.
        /// </description>
        public void ResetImportSession(bool forceResetSession = false) {
             InternalUnsafeMethods.ResetImportSession__Args _args = new InternalUnsafeMethods.ResetImportSession__Args() {
                forceResetSession = forceResetSession,
             };
             InternalUnsafeMethods.ResetImportSession()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the target path the importing assets will be put into.
        /// </description>
        /// <param name="A">string of the target path.</param>
        public void SetTargetPath(string path = "") {
             InternalUnsafeMethods.SetTargetPath__Args _args = new InternalUnsafeMethods.SetTargetPath__Args() {
                path = path,
             };
             InternalUnsafeMethods.SetTargetPath()(ObjectPtr, _args);
        }


        /// <value>
        /// <description>
        /// The Id of the module the assets are to be imported into
        /// </description>
        /// </value>
        public string TargetModuleId {
            get => GenericMarshal.StringTo<string>(GetFieldValue("targetModuleId"));
            set => SetFieldValue("targetModuleId", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The Id of the module the assets are to be imported into
        /// </description>
        /// </value>
        public string FinalImportedAssetPath {
            get => GenericMarshal.StringTo<string>(GetFieldValue("finalImportedAssetPath"));
            set => SetFieldValue("finalImportedAssetPath", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The path any imported assets are placed in as their destination
        /// </description>
        /// </value>
        public string TargetPath {
            get => GenericMarshal.StringTo<string>(GetFieldValue("targetPath"));
            set => SetFieldValue("targetPath", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Indicates if the importer always dumps its logs or not
        /// </description>
        /// </value>
        public bool DumpLogs {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("dumpLogs"));
            set => SetFieldValue("dumpLogs", GenericMarshal.ToString(value));
        }
    }
}
