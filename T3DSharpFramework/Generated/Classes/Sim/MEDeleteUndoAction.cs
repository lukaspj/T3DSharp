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
    /// <summary>Material Editor delete undo instance</summary>
    /// <description>
    /// Not intended for game development, for editors or internal use only.
    /// </description>
    public class MEDeleteUndoAction : UndoAction {
        public MEDeleteUndoAction(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public MEDeleteUndoAction(string pName, bool pRegister)
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

        public MEDeleteUndoAction(string pName)
            : this(pName, false) {
        }

        public MEDeleteUndoAction(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public MEDeleteUndoAction(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public MEDeleteUndoAction(SimObject pObj)
            : base(pObj) {
        }

        public MEDeleteUndoAction(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteObject__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteObject(IntPtr _this, DeleteObject__Args args);
            private static _DeleteObject _DeleteObjectFunc;
            internal static _DeleteObject DeleteObject() {
               _DeleteObjectFunc ??= Torque3D.LookupEngineFunction<_DeleteObject>("fnMEDeleteUndoAction_deleteObject");

                return _DeleteObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnMEDeleteUndoAction_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnMEDeleteUndoAction_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Delete the object and add it to the undo action.
        /// </description>
        /// <param name="obj">Object to delete and add to the undo action.</param>
        public void DeleteObject(SimObject obj) {
             InternalUnsafeMethods.DeleteObject__Args _args = new InternalUnsafeMethods.DeleteObject__Args() {
                obj = obj.ObjectPtr,
             };
             InternalUnsafeMethods.DeleteObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the MEDeleteUndoAction class.
        /// </description>
        /// <returns>The type info object for MEDeleteUndoAction</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
