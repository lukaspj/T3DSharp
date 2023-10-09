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
    /// <summary>Visual representation of markers on top and left sides of GUI Editor</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiEditorRuler : GuiControl {
        public GuiEditorRuler(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiEditorRuler(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiEditorRuler(string pName)
            : this(pName, false) {
        }

        public GuiEditorRuler(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiEditorRuler(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiEditorRuler(SimObject pObj)
            : base(pObj) {
        }

        public GuiEditorRuler(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiEditorRuler_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiEditorRuler_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiEditorRuler class.
        /// </description>
        /// <returns>The type info object for GuiEditorRuler</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public string RefCtrl {
            get => GenericMarshal.StringTo<string>(GetFieldValue("refCtrl"));
            set => SetFieldValue("refCtrl", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string EditCtrl {
            get => GenericMarshal.StringTo<string>(GetFieldValue("editCtrl"));
            set => SetFieldValue("editCtrl", GenericMarshal.ToString(value));
        }
    }
}
