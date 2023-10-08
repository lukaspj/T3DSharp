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
    public class LevelAsset : AssetBase {
        public LevelAsset(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public LevelAsset(string pName, bool pRegister)
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

        public LevelAsset(string pName)
            : this(pName, false) {
        }

        public LevelAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public LevelAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public LevelAsset(SimObject pObj)
            : base(pObj) {
        }

        public LevelAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct UnloadDependencies__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UnloadDependencies(IntPtr _this, UnloadDependencies__Args args);
            private static _UnloadDependencies _UnloadDependenciesFunc;
            internal static _UnloadDependencies UnloadDependencies() {
               _UnloadDependenciesFunc ??= Torque3D.LookupEngineFunction<_UnloadDependencies>("fnLevelAsset_unloadDependencies");

                return _UnloadDependenciesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct LoadDependencies__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _LoadDependencies(IntPtr _this, LoadDependencies__Args args);
            private static _LoadDependencies _LoadDependenciesFunc;
            internal static _LoadDependencies LoadDependencies() {
               _LoadDependenciesFunc ??= Torque3D.LookupEngineFunction<_LoadDependencies>("fnLevelAsset_loadDependencies");

                return _LoadDependenciesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNavmeshPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNavmeshPath(IntPtr _this, GetNavmeshPath__Args args);
            private static _GetNavmeshPath _GetNavmeshPathFunc;
            internal static _GetNavmeshPath GetNavmeshPath() {
               _GetNavmeshPathFunc ??= Torque3D.LookupEngineFunction<_GetNavmeshPath>("fnLevelAsset_getNavmeshPath");

                return _GetNavmeshPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetForestPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetForestPath(IntPtr _this, GetForestPath__Args args);
            private static _GetForestPath _GetForestPathFunc;
            internal static _GetForestPath GetForestPath() {
               _GetForestPathFunc ??= Torque3D.LookupEngineFunction<_GetForestPath>("fnLevelAsset_getForestPath");

                return _GetForestPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDecalsPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDecalsPath(IntPtr _this, GetDecalsPath__Args args);
            private static _GetDecalsPath _GetDecalsPathFunc;
            internal static _GetDecalsPath GetDecalsPath() {
               _GetDecalsPathFunc ??= Torque3D.LookupEngineFunction<_GetDecalsPath>("fnLevelAsset_getDecalsPath");

                return _GetDecalsPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetPostFXPresetPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetPostFXPresetPath(IntPtr _this, GetPostFXPresetPath__Args args);
            private static _GetPostFXPresetPath _GetPostFXPresetPathFunc;
            internal static _GetPostFXPresetPath GetPostFXPresetPath() {
               _GetPostFXPresetPathFunc ??= Torque3D.LookupEngineFunction<_GetPostFXPresetPath>("fnLevelAsset_getPostFXPresetPath");

                return _GetPostFXPresetPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetPreviewImagePath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetPreviewImagePath(IntPtr _this, GetPreviewImagePath__Args args);
            private static _GetPreviewImagePath _GetPreviewImagePathFunc;
            internal static _GetPreviewImagePath GetPreviewImagePath() {
               _GetPreviewImagePathFunc ??= Torque3D.LookupEngineFunction<_GetPreviewImagePath>("fnLevelAsset_getPreviewImagePath");

                return _GetPreviewImagePathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetPreviewImageAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetPreviewImageAsset(IntPtr _this, GetPreviewImageAsset__Args args);
            private static _GetPreviewImageAsset _GetPreviewImageAssetFunc;
            internal static _GetPreviewImageAsset GetPreviewImageAsset() {
               _GetPreviewImageAssetFunc ??= Torque3D.LookupEngineFunction<_GetPreviewImageAsset>("fnLevelAsset_getPreviewImageAsset");

                return _GetPreviewImageAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLevelPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLevelPath(IntPtr _this, GetLevelPath__Args args);
            private static _GetLevelPath _GetLevelPathFunc;
            internal static _GetLevelPath GetLevelPath() {
               _GetLevelPathFunc ??= Torque3D.LookupEngineFunction<_GetLevelPath>("fnLevelAsset_getLevelPath");

                return _GetLevelPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnLevelAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnLevelAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Initiates the unloading of previously loaded asset dependencies for this level.
        /// </description>
        public void UnloadDependencies() {
             InternalUnsafeMethods.UnloadDependencies__Args _args = new InternalUnsafeMethods.UnloadDependencies__Args() {
             };
             InternalUnsafeMethods.UnloadDependencies()(ObjectPtr, _args);
        }

        /// <description>
        /// Initiates the loading of asset dependencies for this level.
        /// </description>
        public void LoadDependencies() {
             InternalUnsafeMethods.LoadDependencies__Args _args = new InternalUnsafeMethods.LoadDependencies__Args() {
             };
             InternalUnsafeMethods.LoadDependencies()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the full path of the asset's defined navmesh file.
        /// </description>
        /// <returns>The string result of the navmesh path</returns>
        public string GetNavmeshPath() {
             InternalUnsafeMethods.GetNavmeshPath__Args _args = new InternalUnsafeMethods.GetNavmeshPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNavmeshPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the full path of the asset's defined forest file.
        /// </description>
        /// <returns>The string result of the forest path</returns>
        public string GetForestPath() {
             InternalUnsafeMethods.GetForestPath__Args _args = new InternalUnsafeMethods.GetForestPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetForestPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the full path of the asset's defined decal file.
        /// </description>
        /// <returns>The string result of the decal path</returns>
        public string GetDecalsPath() {
             InternalUnsafeMethods.GetDecalsPath__Args _args = new InternalUnsafeMethods.GetDecalsPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDecalsPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the full path of the asset's defined postFX preset file.
        /// </description>
        /// <returns>The string result of the postFX preset path</returns>
        public string GetPostFXPresetPath() {
             InternalUnsafeMethods.GetPostFXPresetPath__Args _args = new InternalUnsafeMethods.GetPostFXPresetPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetPostFXPresetPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the full path of the asset's defined preview image file.
        /// </description>
        /// <returns>The string result of the level preview image path</returns>
        public string GetPreviewImagePath() {
             InternalUnsafeMethods.GetPreviewImagePath__Args _args = new InternalUnsafeMethods.GetPreviewImagePath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetPreviewImagePath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the full path of the asset's defined preview image file.
        /// </description>
        /// <returns>The string result of the level preview image path</returns>
        public string GetPreviewImageAsset() {
             InternalUnsafeMethods.GetPreviewImageAsset__Args _args = new InternalUnsafeMethods.GetPreviewImageAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetPreviewImageAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the full path of the asset's defined level file.
        /// </description>
        /// <returns>The string result of the level path</returns>
        public string GetLevelPath() {
             InternalUnsafeMethods.GetLevelPath__Args _args = new InternalUnsafeMethods.GetLevelPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLevelPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the LevelAsset class.
        /// </description>
        /// <returns>The type info object for LevelAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Path to the actual level file.
        /// </description>
        /// </value>
        public string LevelFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("LevelFile"));
            set => SetFieldValue("LevelFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Human-friendly name for the level.
        /// </description>
        /// </value>
        public string LevelName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("LevelName"));
            set => SetFieldValue("LevelName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the level's postFXPreset.
        /// </description>
        /// </value>
        public string PostFXPresetFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("PostFXPresetFile"));
            set => SetFieldValue("PostFXPresetFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the decals cache file.
        /// </description>
        /// </value>
        public string DecalsFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DecalsFile"));
            set => SetFieldValue("DecalsFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the Forest cache file.
        /// </description>
        /// </value>
        public string ForestFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ForestFile"));
            set => SetFieldValue("ForestFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the navmesh file.
        /// </description>
        /// </value>
        public string NavmeshFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("NavmeshFile"));
            set => SetFieldValue("NavmeshFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the level file with objects that were removed as part of the baking process. Loaded when the editor is loaded for ease of editing.
        /// </description>
        /// </value>
        public string EditorFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("EditorFile"));
            set => SetFieldValue("EditorFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the level file with the objects generated as part of the baking process
        /// </description>
        /// </value>
        public string BakedSceneFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("BakedSceneFile"));
            set => SetFieldValue("BakedSceneFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Is this a sublevel to another Scene
        /// </description>
        /// </value>
        public bool IsSubscene {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isSubscene"));
            set => SetFieldValue("isSubscene", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Name of the Game Mode to be used with this level
        /// </description>
        /// </value>
        public string GameModeName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("gameModeName"));
            set => SetFieldValue("gameModeName", GenericMarshal.ToString(value));
        }
    }
}
