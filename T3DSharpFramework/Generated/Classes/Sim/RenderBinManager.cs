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
    /// <summary>The abstract base for all render bins.</summary>
    /// <description>
    /// The render bins are used by the engine as a high level method to order and batch rendering operations.
    /// </description>
    public class RenderBinManager : SimObject {
        public RenderBinManager(bool pRegister = false)
            : base(pRegister) {
        }

        public RenderBinManager(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public RenderBinManager(string pName)
            : this(pName, false) {
        }

        public RenderBinManager(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public RenderBinManager(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public RenderBinManager(SimObject pObj)
            : base(pObj) {
        }

        public RenderBinManager(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRenderOrder__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _GetRenderOrder(IntPtr _this, GetRenderOrder__Args args);
            private static _GetRenderOrder _GetRenderOrderFunc;
            internal static _GetRenderOrder GetRenderOrder() {
               _GetRenderOrderFunc ??= Torque3D.LookupEngineFunction<_GetRenderOrder>("fnRenderBinManager_getRenderOrder");

                return _GetRenderOrderFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBinType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetBinType(IntPtr _this, GetBinType__Args args);
            private static _GetBinType _GetBinTypeFunc;
            internal static _GetBinType GetBinType() {
               _GetBinTypeFunc ??= Torque3D.LookupEngineFunction<_GetBinType>("fnRenderBinManager_getBinType");

                return _GetBinTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnRenderBinManager_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnRenderBinManager_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Returns the bin render order.
        /// </description>
        public float GetRenderOrder() {
             InternalUnsafeMethods.GetRenderOrder__Args _args = new InternalUnsafeMethods.GetRenderOrder__Args() {
             };
             float _engineResult = InternalUnsafeMethods.GetRenderOrder()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Returns the bin type string.
        /// </description>
        public string GetBinType() {
             InternalUnsafeMethods.GetBinType__Args _args = new InternalUnsafeMethods.GetBinType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetBinType()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the RenderBinManager class.
        /// </description>
        /// <returns>The type info object for RenderBinManager</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Sets the render bin type which limits what render instances are added to this bin.
        /// </description>
        /// </value>
        public string BinType {
            get => GenericMarshal.StringTo<string>(GetFieldValue("binType"));
            set => SetFieldValue("binType", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Defines the order for rendering in relation to other bins.
        /// </description>
        /// </value>
        public float RenderOrder {
            get => GenericMarshal.StringTo<float>(GetFieldValue("renderOrder"));
            set => SetFieldValue("renderOrder", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Defines the order for adding instances in relation to other bins.
        /// </description>
        /// </value>
        public float ProcessAddOrder {
            get => GenericMarshal.StringTo<float>(GetFieldValue("processAddOrder"));
            set => SetFieldValue("processAddOrder", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Limites the render bin to basic lighting only.
        /// </description>
        /// </value>
        public bool BasicOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("basicOnly"));
            set => SetFieldValue("basicOnly", GenericMarshal.ToString(value));
        }
    }
}
