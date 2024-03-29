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
    public class StateMachineAsset : AssetBase {
        public StateMachineAsset(bool pRegister = false)
            : base(pRegister) {
        }

        public StateMachineAsset(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public StateMachineAsset(string pName)
            : this(pName, false) {
        }

        public StateMachineAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public StateMachineAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public StateMachineAsset(SimObject pObj)
            : base(pObj) {
        }

        public StateMachineAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct NotifyAssetChanged__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _NotifyAssetChanged(IntPtr _this, NotifyAssetChanged__Args args);
            private static _NotifyAssetChanged _NotifyAssetChangedFunc;
            internal static _NotifyAssetChanged NotifyAssetChanged() {
               _NotifyAssetChangedFunc ??= Torque3D.LookupEngineFunction<_NotifyAssetChanged>("fnStateMachineAsset_notifyAssetChanged");

                return _NotifyAssetChangedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnStateMachineAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnStateMachineAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public void NotifyAssetChanged() {
             InternalUnsafeMethods.NotifyAssetChanged__Args _args = new InternalUnsafeMethods.NotifyAssetChanged__Args() {
             };
             InternalUnsafeMethods.NotifyAssetChanged()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the StateMachineAsset class.
        /// </description>
        /// <returns>The type info object for StateMachineAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Path to the state machine file.
        /// </description>
        /// </value>
        public string StateMachineFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("stateMachineFile"));
            set => SetFieldValue("stateMachineFile", GenericMarshal.ToString(value));
        }
    }
}
