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
    public class GUIAsset : AssetBase {
        public GUIAsset(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GUIAsset(string pName, bool pRegister)
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

        public GUIAsset(string pName)
            : this(pName, false) {
        }

        public GUIAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GUIAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GUIAsset(SimObject pObj)
            : base(pObj) {
        }

        public GUIAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGUIPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetGUIPath(IntPtr _this, GetGUIPath__Args args);
            private static _GetGUIPath _GetGUIPathFunc;
            internal static _GetGUIPath GetGUIPath() {
               _GetGUIPathFunc ??= Torque3D.LookupEngineFunction<_GetGUIPath>("fnGUIAsset_getGUIPath");

                return _GetGUIPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetScriptPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetScriptPath(IntPtr _this, GetScriptPath__Args args);
            private static _GetScriptPath _GetScriptPathFunc;
            internal static _GetScriptPath GetScriptPath() {
               _GetScriptPathFunc ??= Torque3D.LookupEngineFunction<_GetScriptPath>("fnGUIAsset_getScriptPath");

                return _GetScriptPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetIdByGUIName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string guiName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAssetIdByGUIName(GetAssetIdByGUIName__Args args);
            private static _GetAssetIdByGUIName _GetAssetIdByGUINameFunc;
            internal static _GetAssetIdByGUIName GetAssetIdByGUIName() {
               _GetAssetIdByGUINameFunc ??= Torque3D.LookupEngineFunction<_GetAssetIdByGUIName>("fnGUIAsset_getAssetIdByGUIName");

                return _GetAssetIdByGUINameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGUIAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGUIAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Gets the GUI file path associated to this asset.
        /// </description>
        /// <returns>The full script file path.</returns>
        public string GetGUIPath() {
             InternalUnsafeMethods.GetGUIPath__Args _args = new InternalUnsafeMethods.GetGUIPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetGUIPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the script file path associated to this asset.
        /// </description>
        /// <returns>The full script file path.</returns>
        public string GetScriptPath() {
             InternalUnsafeMethods.GetScriptPath__Args _args = new InternalUnsafeMethods.GetScriptPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetScriptPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Queries the Asset Database to see if any asset exists that is associated with the provided GUI Name.
        /// </description>
        /// <returns>The AssetId of the associated asset, if any.</returns>
        public static string GetAssetIdByGUIName(string guiName = "") {
             InternalUnsafeMethods.GetAssetIdByGUIName__Args _args = new InternalUnsafeMethods.GetAssetIdByGUIName__Args() {
                guiName = guiName,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetIdByGUIName()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the GUIAsset class.
        /// </description>
        /// <returns>The type info object for GUIAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Path to the script file for the gui
        /// </description>
        /// </value>
        public string ScriptFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ScriptFile"));
            set => SetFieldValue("ScriptFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the gui file
        /// </description>
        /// </value>
        public string GUIFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("GUIFile"));
            set => SetFieldValue("GUIFile", GenericMarshal.ToString(value));
        }
    }
}
