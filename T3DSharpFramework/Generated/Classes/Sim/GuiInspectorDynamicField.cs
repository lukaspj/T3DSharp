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
    /// <summary>Custom field type for dynamic variable modification on SimObjects.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiInspectorDynamicField : GuiInspectorField {
        public GuiInspectorDynamicField(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiInspectorDynamicField(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiInspectorDynamicField(string pName)
            : this(pName, false) {
        }

        public GuiInspectorDynamicField(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiInspectorDynamicField(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiInspectorDynamicField(SimObject pObj)
            : base(pObj) {
        }

        public GuiInspectorDynamicField(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct RenameField__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newDynamicFieldName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RenameField(IntPtr _this, RenameField__Args args);
            private static _RenameField _RenameFieldFunc;
            internal static _RenameField RenameField() {
               _RenameFieldFunc ??= Torque3D.LookupEngineFunction<_RenameField>("fnGuiInspectorDynamicField_renameField");

                return _RenameFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiInspectorDynamicField_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiInspectorDynamicField_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// field.renameField(newDynamicFieldName);
        /// </description>
        public void RenameField(string newDynamicFieldName) {
             InternalUnsafeMethods.RenameField__Args _args = new InternalUnsafeMethods.RenameField__Args() {
                newDynamicFieldName = newDynamicFieldName,
             };
             InternalUnsafeMethods.RenameField()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiInspectorDynamicField class.
        /// </description>
        /// <returns>The type info object for GuiInspectorDynamicField</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
