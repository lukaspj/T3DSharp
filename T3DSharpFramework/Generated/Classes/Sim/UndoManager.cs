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
    /// <summary>SimObject which adds, tracks, and deletes UndoAction objects.</summary>
    /// <description>
    /// Not intended for game development, for editors or internal use only.
    /// </description>
    public class UndoManager : SimObject {
        public UndoManager(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public UndoManager(string pName, bool pRegister)
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

        public UndoManager(string pName)
            : this(pName, false) {
        }

        public UndoManager(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public UndoManager(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public UndoManager(SimObject pObj)
            : base(pObj) {
        }

        public UndoManager(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PopCompound__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool discard;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PopCompound(IntPtr _this, PopCompound__Args args);
            private static _PopCompound _PopCompoundFunc;
            internal static _PopCompound PopCompound() {
               _PopCompoundFunc ??= Torque3D.LookupEngineFunction<_PopCompound>("fnUndoManager_popCompound");

                return _PopCompoundFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushCompound__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _PushCompound(IntPtr _this, PushCompound__Args args);
            private static _PushCompound _PushCompoundFunc;
            internal static _PushCompound PushCompound() {
               _PushCompoundFunc ??= Torque3D.LookupEngineFunction<_PushCompound>("fnUndoManager_pushCompound");

                return _PushCompoundFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNextRedoName__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNextRedoName(IntPtr _this, GetNextRedoName__Args args);
            private static _GetNextRedoName _GetNextRedoNameFunc;
            internal static _GetNextRedoName GetNextRedoName() {
               _GetNextRedoNameFunc ??= Torque3D.LookupEngineFunction<_GetNextRedoName>("fnUndoManager_getNextRedoName");

                return _GetNextRedoNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNextUndoName__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNextUndoName(IntPtr _this, GetNextUndoName__Args args);
            private static _GetNextUndoName _GetNextUndoNameFunc;
            internal static _GetNextUndoName GetNextUndoName() {
               _GetNextUndoNameFunc ??= Torque3D.LookupEngineFunction<_GetNextUndoName>("fnUndoManager_getNextUndoName");

                return _GetNextUndoNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Redo__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Redo(IntPtr _this, Redo__Args args);
            private static _Redo _RedoFunc;
            internal static _Redo Redo() {
               _RedoFunc ??= Torque3D.LookupEngineFunction<_Redo>("fnUndoManager_redo");

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
               _UndoFunc ??= Torque3D.LookupEngineFunction<_Undo>("fnUndoManager_undo");

                return _UndoFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRedoAction__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRedoAction(IntPtr _this, GetRedoAction__Args args);
            private static _GetRedoAction _GetRedoActionFunc;
            internal static _GetRedoAction GetRedoAction() {
               _GetRedoActionFunc ??= Torque3D.LookupEngineFunction<_GetRedoAction>("fnUndoManager_getRedoAction");

                return _GetRedoActionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRedoName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetRedoName(IntPtr _this, GetRedoName__Args args);
            private static _GetRedoName _GetRedoNameFunc;
            internal static _GetRedoName GetRedoName() {
               _GetRedoNameFunc ??= Torque3D.LookupEngineFunction<_GetRedoName>("fnUndoManager_getRedoName");

                return _GetRedoNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRedoCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRedoCount(IntPtr _this, GetRedoCount__Args args);
            private static _GetRedoCount _GetRedoCountFunc;
            internal static _GetRedoCount GetRedoCount() {
               _GetRedoCountFunc ??= Torque3D.LookupEngineFunction<_GetRedoCount>("fnUndoManager_getRedoCount");

                return _GetRedoCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetUndoAction__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetUndoAction(IntPtr _this, GetUndoAction__Args args);
            private static _GetUndoAction _GetUndoActionFunc;
            internal static _GetUndoAction GetUndoAction() {
               _GetUndoActionFunc ??= Torque3D.LookupEngineFunction<_GetUndoAction>("fnUndoManager_getUndoAction");

                return _GetUndoActionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetUndoName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetUndoName(IntPtr _this, GetUndoName__Args args);
            private static _GetUndoName _GetUndoNameFunc;
            internal static _GetUndoName GetUndoName() {
               _GetUndoNameFunc ??= Torque3D.LookupEngineFunction<_GetUndoName>("fnUndoManager_getUndoName");

                return _GetUndoNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetUndoCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetUndoCount(IntPtr _this, GetUndoCount__Args args);
            private static _GetUndoCount _GetUndoCountFunc;
            internal static _GetUndoCount GetUndoCount() {
               _GetUndoCountFunc ??= Torque3D.LookupEngineFunction<_GetUndoCount>("fnUndoManager_getUndoCount");

                return _GetUndoCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearAll__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearAll(IntPtr _this, ClearAll__Args args);
            private static _ClearAll _ClearAllFunc;
            internal static _ClearAll ClearAll() {
               _ClearAllFunc ??= Torque3D.LookupEngineFunction<_ClearAll>("fnUndoManager_clearAll");

                return _ClearAllFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnUndoManager_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnUndoManager_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// ( bool discard=false ) - Pop the current CompoundUndoAction off the stack.
        /// </description>
        public void PopCompound(bool discard = false) {
             InternalUnsafeMethods.PopCompound__Args _args = new InternalUnsafeMethods.PopCompound__Args() {
                discard = discard,
             };
             InternalUnsafeMethods.PopCompound()(ObjectPtr, _args);
        }

        /// <description>
        /// ( string name="" ) - Push a CompoundUndoAction onto the compound stack for assembly.
        /// </description>
        public string PushCompound(string name = "") {
             InternalUnsafeMethods.PushCompound__Args _args = new InternalUnsafeMethods.PushCompound__Args() {
                name = name,
             };
             IntPtr _engineResult = InternalUnsafeMethods.PushCompound()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// UndoManager.getNextRedoName();
        /// </description>
        public string GetNextRedoName() {
             InternalUnsafeMethods.GetNextRedoName__Args _args = new InternalUnsafeMethods.GetNextRedoName__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNextRedoName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// UndoManager.getNextUndoName();
        /// </description>
        public string GetNextUndoName() {
             InternalUnsafeMethods.GetNextUndoName__Args _args = new InternalUnsafeMethods.GetNextUndoName__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNextUndoName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// UndoManager.redo();
        /// </description>
        public void Redo() {
             InternalUnsafeMethods.Redo__Args _args = new InternalUnsafeMethods.Redo__Args() {
             };
             InternalUnsafeMethods.Redo()(ObjectPtr, _args);
        }

        /// <description>
        /// UndoManager.undo();
        /// </description>
        public void Undo() {
             InternalUnsafeMethods.Undo__Args _args = new InternalUnsafeMethods.Undo__Args() {
             };
             InternalUnsafeMethods.Undo()(ObjectPtr, _args);
        }

        /// <description>
        /// (index)
        /// </description>
        public int GetRedoAction(int index) {
             InternalUnsafeMethods.GetRedoAction__Args _args = new InternalUnsafeMethods.GetRedoAction__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetRedoAction()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (index)
        /// </description>
        public string GetRedoName(int index) {
             InternalUnsafeMethods.GetRedoName__Args _args = new InternalUnsafeMethods.GetRedoName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetRedoName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// 
        public int GetRedoCount() {
             InternalUnsafeMethods.GetRedoCount__Args _args = new InternalUnsafeMethods.GetRedoCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetRedoCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (index)
        /// </description>
        public int GetUndoAction(int index) {
             InternalUnsafeMethods.GetUndoAction__Args _args = new InternalUnsafeMethods.GetUndoAction__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetUndoAction()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (index)
        /// </description>
        public string GetUndoName(int index) {
             InternalUnsafeMethods.GetUndoName__Args _args = new InternalUnsafeMethods.GetUndoName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetUndoName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// 
        public int GetUndoCount() {
             InternalUnsafeMethods.GetUndoCount__Args _args = new InternalUnsafeMethods.GetUndoCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetUndoCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Clears the undo manager.
        /// </description>
        public void ClearAll() {
             InternalUnsafeMethods.ClearAll__Args _args = new InternalUnsafeMethods.ClearAll__Args() {
             };
             InternalUnsafeMethods.ClearAll()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the UndoManager class.
        /// </description>
        /// <returns>The type info object for UndoManager</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Number of undo & redo levels.
        /// </description>
        /// </value>
        public int NumLevels {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numLevels"));
            set => SetFieldValue("numLevels", GenericMarshal.ToString(value));
        }
    }
}
