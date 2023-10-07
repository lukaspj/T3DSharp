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
    public class ScriptAsset : AssetBase {
        public ScriptAsset(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public ScriptAsset(string pName, bool pRegister)
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

        public ScriptAsset(string pName)
            : this(pName, false) {
        }

        public ScriptAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ScriptAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ScriptAsset(SimObject pObj)
            : base(pObj) {
        }

        public ScriptAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ExecScript__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _ExecScript(IntPtr _this, ExecScript__Args args);
            private static _ExecScript _ExecScriptFunc;
            internal static _ExecScript ExecScript() {
               _ExecScriptFunc ??= Torque3D.LookupEngineFunction<_ExecScript>("fnScriptAsset_execScript");

                return _ExecScriptFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnUnloadAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnUnloadAsset(IntPtr _this, OnUnloadAsset__Args args);
            private static _OnUnloadAsset _OnUnloadAssetFunc;
            internal static _OnUnloadAsset OnUnloadAsset() {
               _OnUnloadAssetFunc ??= Torque3D.LookupEngineFunction<_OnUnloadAsset>("cbScriptAsset_onUnloadAsset");

                return _OnUnloadAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnRefreshAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnRefreshAsset(IntPtr _this, OnRefreshAsset__Args args);
            private static _OnRefreshAsset _OnRefreshAssetFunc;
            internal static _OnRefreshAsset OnRefreshAsset() {
               _OnRefreshAssetFunc ??= Torque3D.LookupEngineFunction<_OnRefreshAsset>("cbScriptAsset_onRefreshAsset");

                return _OnRefreshAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnInitializeAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnInitializeAsset(IntPtr _this, OnInitializeAsset__Args args);
            private static _OnInitializeAsset _OnInitializeAssetFunc;
            internal static _OnInitializeAsset OnInitializeAsset() {
               _OnInitializeAssetFunc ??= Torque3D.LookupEngineFunction<_OnInitializeAsset>("cbScriptAsset_onInitializeAsset");

                return _OnInitializeAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnScriptAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnScriptAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Executes the script file.
        /// </description>
        /// <returns>The bool result of calling exec</returns>
        public bool ExecScript() {
             InternalUnsafeMethods.ExecScript__Args _args = new InternalUnsafeMethods.ExecScript__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.ExecScript()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>When the ScriptAsset is unloaded by the AssetManager.</summary>
        /// <description>
        /// 
        /// </description>
        public virtual void OnUnloadAsset() {
             InternalUnsafeMethods.OnUnloadAsset__Args _args = new InternalUnsafeMethods.OnUnloadAsset__Args() {
             };
             InternalUnsafeMethods.OnUnloadAsset()(ObjectPtr, _args);
        }

        /// <summary>When the ScriptAsset is refreshed by the AssetManager.</summary>
        /// <description>
        /// 
        /// </description>
        public virtual void OnRefreshAsset() {
             InternalUnsafeMethods.OnRefreshAsset__Args _args = new InternalUnsafeMethods.OnRefreshAsset__Args() {
             };
             InternalUnsafeMethods.OnRefreshAsset()(ObjectPtr, _args);
        }

        /// <summary>When the ScriptAsset is initialized(loaded) by the AssetManager.</summary>
        /// <description>
        /// 
        /// </description>
        public virtual void OnInitializeAsset() {
             InternalUnsafeMethods.OnInitializeAsset__Args _args = new InternalUnsafeMethods.OnInitializeAsset__Args() {
             };
             InternalUnsafeMethods.OnInitializeAsset()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the ScriptAsset class.
        /// </description>
        /// <returns>The type info object for ScriptAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Path to the script file.
        /// </description>
        /// </value>
        public string ScriptFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ScriptFile"));
            set => SetFieldValue("ScriptFile", GenericMarshal.ToString(value));
        }
    }
}
