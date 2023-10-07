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
    /// <summary>An event which signals the editors to undo the last action</summary>
    /// <description>
    /// Not intended for game development, for editors or internal use only.
    /// </description>
    public class UndoAction : SimObject {
        public UndoAction(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public UndoAction(string pName, bool pRegister)
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

        public UndoAction(string pName)
            : this(pName, false) {
        }

        public UndoAction(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public UndoAction(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public UndoAction(SimObject pObj)
            : base(pObj) {
        }

        public UndoAction(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Redo__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Redo(IntPtr _this, Redo__Args args);
            private static _Redo _RedoFunc;
            internal static _Redo Redo() {
               _RedoFunc ??= Torque3D.LookupEngineFunction<_Redo>("fnUndoAction_redo");

                return _RedoFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Undo__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Undo(IntPtr _this, Undo__Args args);
            private static _Undo _UndoFunc;
            internal static _Undo Undo() {
               _UndoFunc ??= Torque3D.LookupEngineFunction<_Undo>("fnUndoAction_undo");

                return _UndoFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddToManager__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string undoManager;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddToManager(IntPtr _this, AddToManager__Args args);
            private static _AddToManager _AddToManagerFunc;
            internal static _AddToManager AddToManager() {
               _AddToManagerFunc ??= Torque3D.LookupEngineFunction<_AddToManager>("fnUndoAction_addToManager");

                return _AddToManagerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnUndoAction_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnUndoAction_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// () - Reo action contained in undo.
        /// </description>
        public void Redo() {
             InternalUnsafeMethods.Redo__Args _args = new InternalUnsafeMethods.Redo__Args() {
             };
             InternalUnsafeMethods.Redo()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Undo action contained in undo.
        /// </description>
        public void Undo() {
             InternalUnsafeMethods.Undo__Args _args = new InternalUnsafeMethods.Undo__Args() {
             };
             InternalUnsafeMethods.Undo()(ObjectPtr, _args);
        }

        /// <description>
        /// action.addToManager([undoManager])
        /// </description>
        public void AddToManager(string undoManager = "") {
             InternalUnsafeMethods.AddToManager__Args _args = new InternalUnsafeMethods.AddToManager__Args() {
                undoManager = undoManager,
             };
             InternalUnsafeMethods.AddToManager()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the UndoAction class.
        /// </description>
        /// <returns>The type info object for UndoAction</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// A brief description of the action, for UI representation of this undo/redo action.
        /// </description>
        /// </value>
        public string ActionName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("actionName"));
            set => SetFieldValue("actionName", GenericMarshal.ToString(value));
        }
    }
}
