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
    /// <summary>The base class for the Decal Editor tool</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiDecalEditorCtrl : EditTSCtrl {
        public GuiDecalEditorCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiDecalEditorCtrl(string pName, bool pRegister)
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

        public GuiDecalEditorCtrl(string pName)
            : this(pName, false) {
        }

        public GuiDecalEditorCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiDecalEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiDecalEditorCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiDecalEditorCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct RetargetDecalDatablock__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string dbFrom;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string dbTo;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RetargetDecalDatablock(IntPtr _this, RetargetDecalDatablock__Args args);
            private static _RetargetDecalDatablock _RetargetDecalDatablockFunc;
            internal static _RetargetDecalDatablock RetargetDecalDatablock() {
               _RetargetDecalDatablockFunc ??= Torque3D.LookupEngineFunction<_RetargetDecalDatablock>("fnGuiDecalEditorCtrl_retargetDecalDatablock");

                return _RetargetDecalDatablockFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSelectionCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSelectionCount(IntPtr _this, GetSelectionCount__Args args);
            private static _GetSelectionCount _GetSelectionCountFunc;
            internal static _GetSelectionCount GetSelectionCount() {
               _GetSelectionCountFunc ??= Torque3D.LookupEngineFunction<_GetSelectionCount>("fnGuiDecalEditorCtrl_getSelectionCount");

                return _GetSelectionCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct EditDecalDetails__Args
            {
                internal uint id;
                internal IntPtr pos;
                internal IntPtr tan;
                internal float size;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _EditDecalDetails(IntPtr _this, EditDecalDetails__Args args);
            private static _EditDecalDetails _EditDecalDetailsFunc;
            internal static _EditDecalDetails EditDecalDetails() {
               _EditDecalDetailsFunc ??= Torque3D.LookupEngineFunction<_EditDecalDetails>("fnGuiDecalEditorCtrl_editDecalDetails");

                return _EditDecalDetailsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SelectDecal__Args
            {
                internal uint id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SelectDecal(IntPtr _this, SelectDecal__Args args);
            private static _SelectDecal _SelectDecalFunc;
            internal static _SelectDecal SelectDecal() {
               _SelectDecalFunc ??= Torque3D.LookupEngineFunction<_SelectDecal>("fnGuiDecalEditorCtrl_selectDecal");

                return _SelectDecalFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDecalLookupName__Args
            {
                internal uint id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDecalLookupName(IntPtr _this, GetDecalLookupName__Args args);
            private static _GetDecalLookupName _GetDecalLookupNameFunc;
            internal static _GetDecalLookupName GetDecalLookupName() {
               _GetDecalLookupNameFunc ??= Torque3D.LookupEngineFunction<_GetDecalLookupName>("fnGuiDecalEditorCtrl_getDecalLookupName");

                return _GetDecalLookupNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDecalTransform__Args
            {
                internal uint id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDecalTransform(IntPtr _this, GetDecalTransform__Args args);
            private static _GetDecalTransform _GetDecalTransformFunc;
            internal static _GetDecalTransform GetDecalTransform() {
               _GetDecalTransformFunc ??= Torque3D.LookupEngineFunction<_GetDecalTransform>("fnGuiDecalEditorCtrl_getDecalTransform");

                return _GetDecalTransformFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDecalCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDecalCount(IntPtr _this, GetDecalCount__Args args);
            private static _GetDecalCount _GetDecalCountFunc;
            internal static _GetDecalCount GetDecalCount() {
               _GetDecalCountFunc ??= Torque3D.LookupEngineFunction<_GetDecalCount>("fnGuiDecalEditorCtrl_getDecalCount");

                return _GetDecalCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMode__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMode(IntPtr _this, GetMode__Args args);
            private static _GetMode _GetModeFunc;
            internal static _GetMode GetMode() {
               _GetModeFunc ??= Torque3D.LookupEngineFunction<_GetMode>("fnGuiDecalEditorCtrl_getMode");

                return _GetModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMode__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newMode;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMode(IntPtr _this, SetMode__Args args);
            private static _SetMode _SetModeFunc;
            internal static _SetMode SetMode() {
               _SetModeFunc ??= Torque3D.LookupEngineFunction<_SetMode>("fnGuiDecalEditorCtrl_setMode");

                return _SetModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteDecalDatablock__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string datablock;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteDecalDatablock(IntPtr _this, DeleteDecalDatablock__Args args);
            private static _DeleteDecalDatablock _DeleteDecalDatablockFunc;
            internal static _DeleteDecalDatablock DeleteDecalDatablock() {
               _DeleteDecalDatablockFunc ??= Torque3D.LookupEngineFunction<_DeleteDecalDatablock>("fnGuiDecalEditorCtrl_deleteDecalDatablock");

                return _DeleteDecalDatablockFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteSelectedDecal__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteSelectedDecal(IntPtr _this, DeleteSelectedDecal__Args args);
            private static _DeleteSelectedDecal _DeleteSelectedDecalFunc;
            internal static _DeleteSelectedDecal DeleteSelectedDecal() {
               _DeleteSelectedDecalFunc ??= Torque3D.LookupEngineFunction<_DeleteSelectedDecal>("fnGuiDecalEditorCtrl_deleteSelectedDecal");

                return _DeleteSelectedDecalFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiDecalEditorCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiDecalEditorCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public void RetargetDecalDatablock(string dbFrom, string dbTo) {
             InternalUnsafeMethods.RetargetDecalDatablock__Args _args = new InternalUnsafeMethods.RetargetDecalDatablock__Args() {
                dbFrom = dbFrom,
                dbTo = dbTo,
             };
             InternalUnsafeMethods.RetargetDecalDatablock()(ObjectPtr, _args);
        }

        /// 
        public int GetSelectionCount() {
             InternalUnsafeMethods.GetSelectionCount__Args _args = new InternalUnsafeMethods.GetSelectionCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSelectionCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// editDecalDetails( S32 )()
        /// </description>
        public void EditDecalDetails(uint id, Point3F pos, Point3F tan, float size) {
pos.Alloc();tan.Alloc();             InternalUnsafeMethods.EditDecalDetails__Args _args = new InternalUnsafeMethods.EditDecalDetails__Args() {
                id = id,
                pos = pos.internalStructPtr,
                tan = tan.internalStructPtr,
                size = size,
             };
             InternalUnsafeMethods.EditDecalDetails()(ObjectPtr, _args);
pos.Free();tan.Free();        }

        /// <description>
        /// selectDecal( S32 )()
        /// </description>
        public void SelectDecal(uint id) {
             InternalUnsafeMethods.SelectDecal__Args _args = new InternalUnsafeMethods.SelectDecal__Args() {
                id = id,
             };
             InternalUnsafeMethods.SelectDecal()(ObjectPtr, _args);
        }

        /// <description>
        /// getDecalLookupName( S32 )()
        /// </description>
        public string GetDecalLookupName(uint id) {
             InternalUnsafeMethods.GetDecalLookupName__Args _args = new InternalUnsafeMethods.GetDecalLookupName__Args() {
                id = id,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDecalLookupName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// getDecalTransform()
        /// </description>
        public string GetDecalTransform(uint id) {
             InternalUnsafeMethods.GetDecalTransform__Args _args = new InternalUnsafeMethods.GetDecalTransform__Args() {
                id = id,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDecalTransform()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// getDecalCount()
        /// </description>
        public int GetDecalCount() {
             InternalUnsafeMethods.GetDecalCount__Args _args = new InternalUnsafeMethods.GetDecalCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetDecalCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// getMode()
        /// </description>
        public string GetMode() {
             InternalUnsafeMethods.GetMode__Args _args = new InternalUnsafeMethods.GetMode__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMode()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// setMode( String mode )()
        /// </description>
        public void SetMode(string newMode) {
             InternalUnsafeMethods.SetMode__Args _args = new InternalUnsafeMethods.SetMode__Args() {
                newMode = newMode,
             };
             InternalUnsafeMethods.SetMode()(ObjectPtr, _args);
        }

        /// <description>
        /// deleteSelectedDecalDatablock( String datablock )
        /// </description>
        public void DeleteDecalDatablock(string datablock) {
             InternalUnsafeMethods.DeleteDecalDatablock__Args _args = new InternalUnsafeMethods.DeleteDecalDatablock__Args() {
                datablock = datablock,
             };
             InternalUnsafeMethods.DeleteDecalDatablock()(ObjectPtr, _args);
        }

        /// <description>
        /// deleteSelectedDecal()
        /// </description>
        public void DeleteSelectedDecal() {
             InternalUnsafeMethods.DeleteSelectedDecal__Args _args = new InternalUnsafeMethods.DeleteSelectedDecal__Args() {
             };
             InternalUnsafeMethods.DeleteSelectedDecal()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiDecalEditorCtrl class.
        /// </description>
        /// <returns>The type info object for GuiDecalEditorCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public DecalData CurrentDecalData {
            get => GenericMarshal.StringTo<DecalData>(GetFieldValue("currentDecalData"));
            set => SetFieldValue("currentDecalData", GenericMarshal.ToString(value));
        }
    }
}
