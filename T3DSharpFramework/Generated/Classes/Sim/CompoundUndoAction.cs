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
    /// <summary>An undo action that is comprised of other undo actions.</summary>
    /// <description>
    /// Not intended for game development, for editors or internal use only.
    /// </description>
    public class CompoundUndoAction : UndoAction {
        public CompoundUndoAction(bool pRegister = false)
            : base(pRegister) {
        }

        public CompoundUndoAction(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public CompoundUndoAction(string pName)
            : this(pName, false) {
        }

        public CompoundUndoAction(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public CompoundUndoAction(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public CompoundUndoAction(SimObject pObj)
            : base(pObj) {
        }

        public CompoundUndoAction(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct AddAction__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddAction(IntPtr _this, AddAction__Args args);
            private static _AddAction _AddActionFunc;
            internal static _AddAction AddAction() {
               _AddActionFunc ??= Torque3D.LookupEngineFunction<_AddAction>("fnCompoundUndoAction_addAction");

                return _AddActionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnCompoundUndoAction_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnCompoundUndoAction_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// addAction( UndoAction )
        /// </description>
        public void AddAction(string objName) {
             InternalUnsafeMethods.AddAction__Args _args = new InternalUnsafeMethods.AddAction__Args() {
                objName = objName,
             };
             InternalUnsafeMethods.AddAction()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the CompoundUndoAction class.
        /// </description>
        /// <returns>The type info object for CompoundUndoAction</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
