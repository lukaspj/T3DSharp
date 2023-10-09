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
    /// <summary>Inspector field type for rotation</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiInspectorTypeMatrixRotation : GuiInspectorField {
        public GuiInspectorTypeMatrixRotation(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiInspectorTypeMatrixRotation(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiInspectorTypeMatrixRotation(string pName)
            : this(pName, false) {
        }

        public GuiInspectorTypeMatrixRotation(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiInspectorTypeMatrixRotation(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiInspectorTypeMatrixRotation(SimObject pObj)
            : base(pObj) {
        }

        public GuiInspectorTypeMatrixRotation(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ApplyRotation__Args
            {
                internal IntPtr angAx;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ApplyRotation(IntPtr _this, ApplyRotation__Args args);
            private static _ApplyRotation _ApplyRotationFunc;
            internal static _ApplyRotation ApplyRotation() {
               _ApplyRotationFunc ??= Torque3D.LookupEngineFunction<_ApplyRotation>("fnGuiInspectorTypeMatrixRotation_applyRotation");

                return _ApplyRotationFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiInspectorTypeMatrixRotation_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiInspectorTypeMatrixRotation_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public void ApplyRotation(AngAxisF angAx) {
angAx.Alloc();             InternalUnsafeMethods.ApplyRotation__Args _args = new InternalUnsafeMethods.ApplyRotation__Args() {
                angAx = angAx.internalStructPtr,
             };
             InternalUnsafeMethods.ApplyRotation()(ObjectPtr, _args);
angAx.Free();        }

        /// <description>
        /// Get the type info object for the GuiInspectorTypeMatrixRotation class.
        /// </description>
        /// <returns>The type info object for GuiInspectorTypeMatrixRotation</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
