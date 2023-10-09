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
    /// <summary>Material Editor create undo instance</summary>
    /// <description>
    /// Not intended for game development, for editors or internal use only.
    /// </description>
    public class MECreateUndoAction : UndoAction {
        public MECreateUndoAction(bool pRegister = false)
            : base(pRegister) {
        }

        public MECreateUndoAction(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public MECreateUndoAction(string pName)
            : this(pName, false) {
        }

        public MECreateUndoAction(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public MECreateUndoAction(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public MECreateUndoAction(SimObject pObj)
            : base(pObj) {
        }

        public MECreateUndoAction(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct AddObject__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddObject(IntPtr _this, AddObject__Args args);
            private static _AddObject _AddObjectFunc;
            internal static _AddObject AddObject() {
               _AddObjectFunc ??= Torque3D.LookupEngineFunction<_AddObject>("fnMECreateUndoAction_addObject");

                return _AddObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnMECreateUndoAction_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnMECreateUndoAction_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Add the object being created to an undo action.
        /// </description>
        /// <param name="obj">Object being created you want to create the undo for.</param>
        public void AddObject(SimObject obj) {
             InternalUnsafeMethods.AddObject__Args _args = new InternalUnsafeMethods.AddObject__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.AddObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the MECreateUndoAction class.
        /// </description>
        /// <returns>The type info object for MECreateUndoAction</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
