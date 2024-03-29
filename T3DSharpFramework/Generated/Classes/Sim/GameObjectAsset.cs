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
    public class GameObjectAsset : AssetBase {
        public GameObjectAsset(bool pRegister = false)
            : base(pRegister) {
        }

        public GameObjectAsset(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GameObjectAsset(string pName)
            : this(pName, false) {
        }

        public GameObjectAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GameObjectAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GameObjectAsset(SimObject pObj)
            : base(pObj) {
        }

        public GameObjectAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct CreateObject__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _CreateObject(IntPtr _this, CreateObject__Args args);
            private static _CreateObject _CreateObjectFunc;
            internal static _CreateObject CreateObject() {
               _CreateObjectFunc ??= Torque3D.LookupEngineFunction<_CreateObject>("fnGameObjectAsset_createObject");

                return _CreateObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGameObjectAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGameObjectAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Creates an instance of the given GameObject given the asset definition.
        /// </description>
        /// <returns>The GameObject entity created from the asset.</returns>
        public string CreateObject() {
             InternalUnsafeMethods.CreateObject__Args _args = new InternalUnsafeMethods.CreateObject__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.CreateObject()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the GameObjectAsset class.
        /// </description>
        /// <returns>The type info object for GameObjectAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Name of the game object. Defines the created object's class.
        /// </description>
        /// </value>
        public string GameObjectName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("gameObjectName"));
            set => SetFieldValue("gameObjectName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the script file for the GameObject's script code.
        /// </description>
        /// </value>
        public string ScriptFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ScriptFile"));
            set => SetFieldValue("ScriptFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the taml file for the GameObject's heirarchy.
        /// </description>
        /// </value>
        public string TAMLFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("TAMLFile"));
            set => SetFieldValue("TAMLFile", GenericMarshal.ToString(value));
        }
    }
}
