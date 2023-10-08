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
    /// <summary>The GuiInspectorField control is a representation of a single abstract field for a given ConsoleObject derived object.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiInspectorField : GuiControl {
        public GuiInspectorField(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiInspectorField(string pName, bool pRegister)
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

        public GuiInspectorField(string pName)
            : this(pName, false) {
        }

        public GuiInspectorField(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiInspectorField(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiInspectorField(SimObject pObj)
            : base(pObj) {
        }

        public GuiInspectorField(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetEditControl__Args
            {
                internal IntPtr editCtrl;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetEditControl(IntPtr _this, SetEditControl__Args args);
            private static _SetEditControl _SetEditControlFunc;
            internal static _SetEditControl SetEditControl() {
               _SetEditControlFunc ??= Torque3D.LookupEngineFunction<_SetEditControl>("fnGuiInspectorField_setEditControl");

                return _SetEditControlFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetHeightOverride__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool useOverride;
                internal uint heightOverride;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetHeightOverride(IntPtr _this, SetHeightOverride__Args args);
            private static _SetHeightOverride _SetHeightOverrideFunc;
            internal static _SetHeightOverride SetHeightOverride() {
               _SetHeightOverrideFunc ??= Torque3D.LookupEngineFunction<_SetHeightOverride>("fnGuiInspectorField_setHeightOverride");

                return _SetHeightOverrideFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetFieldDocs__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string documentation;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetFieldDocs(IntPtr _this, SetFieldDocs__Args args);
            private static _SetFieldDocs _SetFieldDocsFunc;
            internal static _SetFieldDocs SetFieldDocs() {
               _SetFieldDocsFunc ??= Torque3D.LookupEngineFunction<_SetFieldDocs>("fnGuiInspectorField_setFieldDocs");

                return _SetFieldDocsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSpecialEditCallbackName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callbackName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSpecialEditCallbackName(IntPtr _this, SetSpecialEditCallbackName__Args args);
            private static _SetSpecialEditCallbackName _SetSpecialEditCallbackNameFunc;
            internal static _SetSpecialEditCallbackName SetSpecialEditCallbackName() {
               _SetSpecialEditCallbackNameFunc ??= Torque3D.LookupEngineFunction<_SetSpecialEditCallbackName>("fnGuiInspectorField_setSpecialEditCallbackName");

                return _SetSpecialEditCallbackNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSpecialEditVariableType__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newVariableType;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSpecialEditVariableType(IntPtr _this, SetSpecialEditVariableType__Args args);
            private static _SetSpecialEditVariableType _SetSpecialEditVariableTypeFunc;
            internal static _SetSpecialEditVariableType SetSpecialEditVariableType() {
               _SetSpecialEditVariableTypeFunc ??= Torque3D.LookupEngineFunction<_SetSpecialEditVariableType>("fnGuiInspectorField_setSpecialEditVariableType");

                return _SetSpecialEditVariableTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetSpecialEditVariableName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newCaption;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetSpecialEditVariableName(IntPtr _this, SetSpecialEditVariableName__Args args);
            private static _SetSpecialEditVariableName _SetSpecialEditVariableNameFunc;
            internal static _SetSpecialEditVariableName SetSpecialEditVariableName() {
               _SetSpecialEditVariableNameFunc ??= Torque3D.LookupEngineFunction<_SetSpecialEditVariableName>("fnGuiInspectorField_setSpecialEditVariableName");

                return _SetSpecialEditVariableNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCaption__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newCaption;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCaption(IntPtr _this, SetCaption__Args args);
            private static _SetCaption _SetCaptionFunc;
            internal static _SetCaption SetCaption() {
               _SetCaptionFunc ??= Torque3D.LookupEngineFunction<_SetCaption>("fnGuiInspectorField_setCaption");

                return _SetCaptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
               _ResetFunc ??= Torque3D.LookupEngineFunction<_Reset>("fnGuiInspectorField_reset");

                return _ResetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetData__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetData(IntPtr _this, GetData__Args args);
            private static _GetData _GetDataFunc;
            internal static _GetData GetData() {
               _GetDataFunc ??= Torque3D.LookupEngineFunction<_GetData>("fnGuiInspectorField_getData");

                return _GetDataFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ApplyWithoutUndo__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string data;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ApplyWithoutUndo(IntPtr _this, ApplyWithoutUndo__Args args);
            private static _ApplyWithoutUndo _ApplyWithoutUndoFunc;
            internal static _ApplyWithoutUndo ApplyWithoutUndo() {
               _ApplyWithoutUndoFunc ??= Torque3D.LookupEngineFunction<_ApplyWithoutUndo>("fnGuiInspectorField_applyWithoutUndo");

                return _ApplyWithoutUndoFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Apply__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newValue;
                [MarshalAs(UnmanagedType.I1)]
                internal bool callbacks;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Apply(IntPtr _this, Apply__Args args);
            private static _Apply _ApplyFunc;
            internal static _Apply Apply() {
               _ApplyFunc ??= Torque3D.LookupEngineFunction<_Apply>("fnGuiInspectorField_apply");

                return _ApplyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetInspectedFieldType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetInspectedFieldType(IntPtr _this, GetInspectedFieldType__Args args);
            private static _GetInspectedFieldType _GetInspectedFieldTypeFunc;
            internal static _GetInspectedFieldType GetInspectedFieldType() {
               _GetInspectedFieldTypeFunc ??= Torque3D.LookupEngineFunction<_GetInspectedFieldType>("fnGuiInspectorField_getInspectedFieldType");

                return _GetInspectedFieldTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetInspectedFieldName__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetInspectedFieldName(IntPtr _this, GetInspectedFieldName__Args args);
            private static _GetInspectedFieldName _GetInspectedFieldNameFunc;
            internal static _GetInspectedFieldName GetInspectedFieldName() {
               _GetInspectedFieldNameFunc ??= Torque3D.LookupEngineFunction<_GetInspectedFieldName>("fnGuiInspectorField_getInspectedFieldName");

                return _GetInspectedFieldNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetInspector__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetInspector(IntPtr _this, GetInspector__Args args);
            private static _GetInspector _GetInspectorFunc;
            internal static _GetInspector GetInspector() {
               _GetInspectorFunc ??= Torque3D.LookupEngineFunction<_GetInspector>("fnGuiInspectorField_getInspector");

                return _GetInspectorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiInspectorField_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiInspectorField_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// () - Reset to default value.
        /// </description>
        public void SetEditControl(GuiControl editCtrl = null) {
             InternalUnsafeMethods.SetEditControl__Args _args = new InternalUnsafeMethods.SetEditControl__Args() {
                editCtrl = editCtrl.ObjectPtr,
             };
             InternalUnsafeMethods.SetEditControl()(ObjectPtr, _args);
        }

        /// 
        public void SetHeightOverride(bool useOverride, uint heightOverride) {
             InternalUnsafeMethods.SetHeightOverride__Args _args = new InternalUnsafeMethods.SetHeightOverride__Args() {
                useOverride = useOverride,
                heightOverride = heightOverride,
             };
             InternalUnsafeMethods.SetHeightOverride()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Sets the field's documentation string.
        /// </description>
        public void SetFieldDocs(string documentation) {
             InternalUnsafeMethods.SetFieldDocs__Args _args = new InternalUnsafeMethods.SetFieldDocs__Args() {
                documentation = documentation,
             };
             InternalUnsafeMethods.SetFieldDocs()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Sets the callback name for special edit fields.
        /// </description>
        public void SetSpecialEditCallbackName(string callbackName) {
             InternalUnsafeMethods.SetSpecialEditCallbackName__Args _args = new InternalUnsafeMethods.SetSpecialEditCallbackName__Args() {
                callbackName = callbackName,
             };
             InternalUnsafeMethods.SetSpecialEditCallbackName()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Sets the variable type for special edit fields.
        /// </description>
        public void SetSpecialEditVariableType(string newVariableType) {
             InternalUnsafeMethods.SetSpecialEditVariableType__Args _args = new InternalUnsafeMethods.SetSpecialEditVariableType__Args() {
                newVariableType = newVariableType,
             };
             InternalUnsafeMethods.SetSpecialEditVariableType()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Sets the variable name for special edit fields.
        /// </description>
        public void SetSpecialEditVariableName(string newCaption) {
             InternalUnsafeMethods.SetSpecialEditVariableName__Args _args = new InternalUnsafeMethods.SetSpecialEditVariableName__Args() {
                newCaption = newCaption,
             };
             InternalUnsafeMethods.SetSpecialEditVariableName()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Sets the caption of the field.
        /// </description>
        public void SetCaption(string newCaption) {
             InternalUnsafeMethods.SetCaption__Args _args = new InternalUnsafeMethods.SetCaption__Args() {
                newCaption = newCaption,
             };
             InternalUnsafeMethods.SetCaption()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Reset to default value.
        /// </description>
        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Return the value currently displayed on the field.
        /// </description>
        public string GetData() {
             InternalUnsafeMethods.GetData__Args _args = new InternalUnsafeMethods.GetData__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetData()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// () - Set field value without recording undo (same as 'apply( value, false )').
        /// </description>
        public void ApplyWithoutUndo(string data) {
             InternalUnsafeMethods.ApplyWithoutUndo__Args _args = new InternalUnsafeMethods.ApplyWithoutUndo__Args() {
                data = data,
             };
             InternalUnsafeMethods.ApplyWithoutUndo()(ObjectPtr, _args);
        }

        /// <description>
        /// ( string newValue, bool callbacks=true ) - Set the field's value. Suppress callbacks for undo if callbacks=false.
        /// </description>
        public void Apply(string newValue, bool callbacks = true) {
             InternalUnsafeMethods.Apply__Args _args = new InternalUnsafeMethods.Apply__Args() {
                newValue = newValue,
                callbacks = callbacks,
             };
             InternalUnsafeMethods.Apply()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Return the type of the field edited by this inspector field.
        /// </description>
        public string GetInspectedFieldType() {
             InternalUnsafeMethods.GetInspectedFieldType__Args _args = new InternalUnsafeMethods.GetInspectedFieldType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetInspectedFieldType()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// () - Return the name of the field edited by this inspector field.
        /// </description>
        public string GetInspectedFieldName() {
             InternalUnsafeMethods.GetInspectedFieldName__Args _args = new InternalUnsafeMethods.GetInspectedFieldName__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetInspectedFieldName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// () - Return the GuiInspector to which this field belongs.
        /// </description>
        public int GetInspector() {
             InternalUnsafeMethods.GetInspector__Args _args = new InternalUnsafeMethods.GetInspector__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetInspector()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the GuiInspectorField class.
        /// </description>
        /// <returns>The type info object for GuiInspectorField</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
