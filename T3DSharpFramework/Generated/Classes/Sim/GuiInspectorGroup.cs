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
    /// <summary>The GuiInspectorGroup control is a helper control that the inspector makes use of which houses a collapsible pane type control for separating inspected objects fields into groups.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiInspectorGroup : GuiRolloutCtrl {
        public GuiInspectorGroup(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiInspectorGroup(string pName, bool pRegister)
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

        public GuiInspectorGroup(string pName)
            : this(pName, false) {
        }

        public GuiInspectorGroup(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiInspectorGroup(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiInspectorGroup(SimObject pObj)
            : base(pObj) {
        }

        public GuiInspectorGroup(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveField__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveField(IntPtr _this, RemoveField__Args args);
            private static _RemoveField _RemoveFieldFunc;
            internal static _RemoveField RemoveField() {
               _RemoveFieldFunc ??= Torque3D.LookupEngineFunction<_RemoveField>("fnGuiInspectorGroup_removeField");

                return _RemoveFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddInspectorField__Args
            {
                internal IntPtr field;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddInspectorField(IntPtr _this, AddInspectorField__Args args);
            private static _AddInspectorField _AddInspectorFieldFunc;
            internal static _AddInspectorField AddInspectorField() {
               _AddInspectorFieldFunc ??= Torque3D.LookupEngineFunction<_AddInspectorField>("fnGuiInspectorGroup_addInspectorField");

                return _AddInspectorFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddField__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldTypeName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string description;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callbackName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddField(IntPtr _this, AddField__Args args);
            private static _AddField _AddFieldFunc;
            internal static _AddField AddField() {
               _AddFieldFunc ??= Torque3D.LookupEngineFunction<_AddField>("fnGuiInspectorGroup_addField");

                return _AddFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CreateInspectorField__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _CreateInspectorField(IntPtr _this, CreateInspectorField__Args args);
            private static _CreateInspectorField _CreateInspectorFieldFunc;
            internal static _CreateInspectorField CreateInspectorField() {
               _CreateInspectorFieldFunc ??= Torque3D.LookupEngineFunction<_CreateInspectorField>("fnGuiInspectorGroup_createInspectorField");

                return _CreateInspectorFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiInspectorGroup_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiInspectorGroup_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Removes a Inspector field to this group of a given name.
        /// </description>
        /// <param name="fieldName">The name of the field to be removed.</param>
        public void RemoveField(string fieldName = "") {
             InternalUnsafeMethods.RemoveField__Args _args = new InternalUnsafeMethods.RemoveField__Args() {
                fieldName = fieldName,
             };
             InternalUnsafeMethods.RemoveField()(ObjectPtr, _args);
        }

        /// <description>
        /// addInspectorField( GuiInspectorFieldObject )
        /// </description>
        public void AddInspectorField(GuiInspectorField field = null) {
             InternalUnsafeMethods.AddInspectorField__Args _args = new InternalUnsafeMethods.AddInspectorField__Args() {
                field = field.ObjectPtr,
             };
             InternalUnsafeMethods.AddInspectorField()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds a new Inspector field to this group.
        /// </description>
        /// <param name="fieldName">The name of the field to add. The field will associate to a variable of the same name on the inspected object for editing purposes.</param>
        /// <param name="fieldTypeName">The name of the type of field it is. If it's an understood existing type, it will create it as normal. If it's an unknown type, it will attempt to call into script to create it.</param>
        /// <param name="description">(Optional) Description of the field.</param>
        /// <param name="callbackName">(Optional) Sets a special callback function to be called when this field is edited.</param>
        public void AddField(string fieldName = "", string fieldTypeName = "", string description = "", string callbackName = "") {
             InternalUnsafeMethods.AddField__Args _args = new InternalUnsafeMethods.AddField__Args() {
                fieldName = fieldName,
                fieldTypeName = fieldTypeName,
                description = description,
                callbackName = callbackName,
             };
             InternalUnsafeMethods.AddField()(ObjectPtr, _args);
        }

        /// <description>
        /// createInspectorField()
        /// </description>
        public GuiInspectorField CreateInspectorField() {
             InternalUnsafeMethods.CreateInspectorField__Args _args = new InternalUnsafeMethods.CreateInspectorField__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.CreateInspectorField()(ObjectPtr, _args);
             return new GuiInspectorField(_engineResult);
        }

        /// <description>
        /// Get the type info object for the GuiInspectorGroup class.
        /// </description>
        /// <returns>The type info object for GuiInspectorGroup</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
