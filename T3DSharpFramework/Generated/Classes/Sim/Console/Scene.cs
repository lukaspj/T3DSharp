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
    public class Scene : NetObject {
        public Scene(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public Scene(string pName, bool pRegister)
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

        public Scene(string pName)
            : this(pName, false) {
        }

        public Scene(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Scene(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Scene(SimObject pObj)
            : base(pObj) {
        }

        public Scene(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
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
               _SaveFunc ??= Torque3D.LookupEngineFunction<_Save>("fnScene_save");

                return _SaveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLevelAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLevelAsset(IntPtr _this, GetLevelAsset__Args args);
            private static _GetLevelAsset _GetLevelAssetFunc;
            internal static _GetLevelAsset GetLevelAsset() {
               _GetLevelAssetFunc ??= Torque3D.LookupEngineFunction<_GetLevelAsset>("fnScene_getLevelAsset");

                return _GetLevelAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetOriginatingFile__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetOriginatingFile(IntPtr _this, GetOriginatingFile__Args args);
            private static _GetOriginatingFile _GetOriginatingFileFunc;
            internal static _GetOriginatingFile GetOriginatingFile() {
               _GetOriginatingFileFunc ??= Torque3D.LookupEngineFunction<_GetOriginatingFile>("fnScene_getOriginatingFile");

                return _GetOriginatingFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpUtilizedAssets__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpUtilizedAssets(IntPtr _this, DumpUtilizedAssets__Args args);
            private static _DumpUtilizedAssets _DumpUtilizedAssetsFunc;
            internal static _DumpUtilizedAssets DumpUtilizedAssets() {
               _DumpUtilizedAssetsFunc ??= Torque3D.LookupEngineFunction<_DumpUtilizedAssets>("fnScene_dumpUtilizedAssets");

                return _DumpUtilizedAssetsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetObjectsByClass__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string className;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetObjectsByClass(IntPtr _this, GetObjectsByClass__Args args);
            private static _GetObjectsByClass _GetObjectsByClassFunc;
            internal static _GetObjectsByClass GetObjectsByClass() {
               _GetObjectsByClassFunc ??= Torque3D.LookupEngineFunction<_GetObjectsByClass>("fnScene_getObjectsByClass");

                return _GetObjectsByClassFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveDynamicObject__Args
            {
                internal IntPtr sceneObj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveDynamicObject(IntPtr _this, RemoveDynamicObject__Args args);
            private static _RemoveDynamicObject _RemoveDynamicObjectFunc;
            internal static _RemoveDynamicObject RemoveDynamicObject() {
               _RemoveDynamicObjectFunc ??= Torque3D.LookupEngineFunction<_RemoveDynamicObject>("fnScene_removeDynamicObject");

                return _RemoveDynamicObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddDynamicObject__Args
            {
                internal IntPtr sceneObj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddDynamicObject(IntPtr _this, AddDynamicObject__Args args);
            private static _AddDynamicObject _AddDynamicObjectFunc;
            internal static _AddDynamicObject AddDynamicObject() {
               _AddDynamicObjectFunc ??= Torque3D.LookupEngineFunction<_AddDynamicObject>("fnScene_addDynamicObject");

                return _AddDynamicObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRootScene__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRootScene(IntPtr _this, GetRootScene__Args args);
            private static _GetRootScene _GetRootSceneFunc;
            internal static _GetRootScene GetRootScene() {
               _GetRootSceneFunc ??= Torque3D.LookupEngineFunction<_GetRootScene>("fnScene_getRootScene");

                return _GetRootSceneFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnScene_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnScene_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Save out the object to the given file.
        /// </description>
        /// <param name="fileName">The name of the file to save to.</param>
        /// <param name="selectedOnly">If true, only objects marked as selected will be saved out.</param>
        /// <param name="preAppendString">Text which will be preprended directly to the object serialization.</param>
        /// <param name="True">on success, false on failure.</param>
        public bool Save(string fileName = "") {
             InternalUnsafeMethods.Save__Args _args = new InternalUnsafeMethods.Save__Args() {
                fileName = fileName,
             };
             bool _engineResult = InternalUnsafeMethods.Save()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public string GetLevelAsset() {
             InternalUnsafeMethods.GetLevelAsset__Args _args = new InternalUnsafeMethods.GetLevelAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLevelAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public string GetOriginatingFile() {
             InternalUnsafeMethods.GetOriginatingFile__Args _args = new InternalUnsafeMethods.GetOriginatingFile__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetOriginatingFile()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public void DumpUtilizedAssets() {
             InternalUnsafeMethods.DumpUtilizedAssets__Args _args = new InternalUnsafeMethods.DumpUtilizedAssets__Args() {
             };
             InternalUnsafeMethods.DumpUtilizedAssets()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public string GetObjectsByClass(string className = "") {
             InternalUnsafeMethods.GetObjectsByClass__Args _args = new InternalUnsafeMethods.GetObjectsByClass__Args() {
                className = className,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetObjectsByClass()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public void RemoveDynamicObject(SceneObject sceneObj = null) {
             InternalUnsafeMethods.RemoveDynamicObject__Args _args = new InternalUnsafeMethods.RemoveDynamicObject__Args() {
                sceneObj = sceneObj.ObjectPtr,
             };
             InternalUnsafeMethods.RemoveDynamicObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public void AddDynamicObject(SceneObject sceneObj = null) {
             InternalUnsafeMethods.AddDynamicObject__Args _args = new InternalUnsafeMethods.AddDynamicObject__Args() {
                sceneObj = sceneObj.ObjectPtr,
             };
             InternalUnsafeMethods.AddDynamicObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the root Scene object that is loaded.
        /// </description>
        /// <returns>The id of the Root Scene. Will be 0 if no root scene is loaded</returns>
        public int GetRootScene() {
             InternalUnsafeMethods.GetRootScene__Args _args = new InternalUnsafeMethods.GetRootScene__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetRootScene()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the Scene class.
        /// </description>
        /// <returns>The type info object for Scene</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public bool IsSubscene {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isSubscene"));
            set => SetFieldValue("isSubscene", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool IsEditing {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isEditing"));
            set => SetFieldValue("isEditing", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool IsDirty {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isDirty"));
            set => SetFieldValue("isDirty", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The name of the gamemode that this scene utilizes
        /// </description>
        /// </value>
        public string GameModeName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("gameModeName"));
            set => SetFieldValue("gameModeName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Edit Scene's default Post Effects
        /// </description>
        /// </value>
        public bool EditPostEffects {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("EditPostEffects"));
            set => SetFieldValue("EditPostEffects", GenericMarshal.ToString(value));
        }
    }
}
