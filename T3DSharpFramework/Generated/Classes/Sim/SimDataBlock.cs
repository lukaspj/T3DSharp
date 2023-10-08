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
    /// <summary></summary>
    /// <description>
    /// 
    /// </description>
    public class SimDataBlock : SimObject {
        public SimDataBlock(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public SimDataBlock(string pName, bool pRegister)
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

        public SimDataBlock(string pName)
            : this(pName, false) {
        }

        public SimDataBlock(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SimDataBlock(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SimDataBlock(SimObject pObj)
            : base(pObj) {
        }

        public SimDataBlock(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Preload__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Preload(IntPtr _this, Preload__Args args);
            private static _Preload _PreloadFunc;
            internal static _Preload Preload() {
               _PreloadFunc ??= Torque3D.LookupEngineFunction<_Preload>("fnSimDataBlock_Preload");

                return _PreloadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AssignId__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AssignId(IntPtr _this, AssignId__Args args);
            private static _AssignId _AssignIdFunc;
            internal static _AssignId AssignId() {
               _AssignIdFunc ??= Torque3D.LookupEngineFunction<_AssignId>("fnSimDataBlock_AssignId");

                return _AssignIdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ReloadOnLocalClient__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ReloadOnLocalClient(IntPtr _this, ReloadOnLocalClient__Args args);
            private static _ReloadOnLocalClient _ReloadOnLocalClientFunc;
            internal static _ReloadOnLocalClient ReloadOnLocalClient() {
               _ReloadOnLocalClientFunc ??= Torque3D.LookupEngineFunction<_ReloadOnLocalClient>("fnSimDataBlock_reloadOnLocalClient");

                return _ReloadOnLocalClientFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnSimDataBlock_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnSimDataBlock_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public void Preload() {
             InternalUnsafeMethods.Preload__Args _args = new InternalUnsafeMethods.Preload__Args() {
             };
             InternalUnsafeMethods.Preload()(ObjectPtr, _args);
        }

        /// 
        public void AssignId() {
             InternalUnsafeMethods.AssignId__Args _args = new InternalUnsafeMethods.AssignId__Args() {
             };
             InternalUnsafeMethods.AssignId()(ObjectPtr, _args);
        }

        /// <description>
        /// Reload the datablock.  This can only be used with a local client configuration.
        /// </description>
        public void ReloadOnLocalClient() {
             InternalUnsafeMethods.ReloadOnLocalClient__Args _args = new InternalUnsafeMethods.ReloadOnLocalClient__Args() {
             };
             InternalUnsafeMethods.ReloadOnLocalClient()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the SimDataBlock class.
        /// </description>
        /// <returns>The type info object for SimDataBlock</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
