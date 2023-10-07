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
    /// <summary>Used to inspect an object's FieldDictionary (dynamic fields) instead of regular persistent fields.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiInspectorDynamicGroup : GuiInspectorGroup {
        public GuiInspectorDynamicGroup(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiInspectorDynamicGroup(string pName, bool pRegister)
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

        public GuiInspectorDynamicGroup(string pName)
            : this(pName, false) {
        }

        public GuiInspectorDynamicGroup(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiInspectorDynamicGroup(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiInspectorDynamicGroup(SimObject pObj)
            : base(pObj) {
        }

        public GuiInspectorDynamicGroup(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveDynamicField__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveDynamicField(IntPtr _this, RemoveDynamicField__Args args);
            private static _RemoveDynamicField _RemoveDynamicFieldFunc;
            internal static _RemoveDynamicField RemoveDynamicField() {
               _RemoveDynamicFieldFunc ??= Torque3D.LookupEngineFunction<_RemoveDynamicField>("fnGuiInspectorDynamicGroup_removeDynamicField");

                return _RemoveDynamicFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddDynamicField__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddDynamicField(IntPtr _this, AddDynamicField__Args args);
            private static _AddDynamicField _AddDynamicFieldFunc;
            internal static _AddDynamicField AddDynamicField() {
               _AddDynamicFieldFunc ??= Torque3D.LookupEngineFunction<_AddDynamicField>("fnGuiInspectorDynamicGroup_addDynamicField");

                return _AddDynamicFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct InspectGroup__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _InspectGroup(IntPtr _this, InspectGroup__Args args);
            private static _InspectGroup _InspectGroupFunc;
            internal static _InspectGroup InspectGroup() {
               _InspectGroupFunc ??= Torque3D.LookupEngineFunction<_InspectGroup>("fnGuiInspectorDynamicGroup_inspectGroup");

                return _InspectGroupFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiInspectorDynamicGroup_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiInspectorDynamicGroup_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public void RemoveDynamicField() {
             InternalUnsafeMethods.RemoveDynamicField__Args _args = new InternalUnsafeMethods.RemoveDynamicField__Args() {
             };
             InternalUnsafeMethods.RemoveDynamicField()(ObjectPtr, _args);
        }

        /// <description>
        /// obj.addDynamicField();
        /// </description>
        public void AddDynamicField() {
             InternalUnsafeMethods.AddDynamicField__Args _args = new InternalUnsafeMethods.AddDynamicField__Args() {
             };
             InternalUnsafeMethods.AddDynamicField()(ObjectPtr, _args);
        }

        /// <description>
        /// Refreshes the dynamic fields in the inspector.
        /// </description>
        public bool InspectGroup() {
             InternalUnsafeMethods.InspectGroup__Args _args = new InternalUnsafeMethods.InspectGroup__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.InspectGroup()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the GuiInspectorDynamicGroup class.
        /// </description>
        /// <returns>The type info object for GuiInspectorDynamicGroup</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
