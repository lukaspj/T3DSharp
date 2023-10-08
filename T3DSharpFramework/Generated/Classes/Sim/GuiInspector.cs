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
    /// <summary>A control that allows to edit the properties of one or more SimObjects.</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiInspector : GuiStackControl {
        public GuiInspector(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiInspector(string pName, bool pRegister)
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

        public GuiInspector(string pName)
            : this(pName, false) {
        }

        public GuiInspector(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiInspector(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiInspector(SimObject pObj)
            : base(pObj) {
        }

        public GuiInspector(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveGroup__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string groupName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveGroup(IntPtr _this, RemoveGroup__Args args);
            private static _RemoveGroup _RemoveGroupFunc;
            internal static _RemoveGroup RemoveGroup() {
               _RemoveGroupFunc ??= Torque3D.LookupEngineFunction<_RemoveGroup>("fnGuiInspector_removeGroup");

                return _RemoveGroupFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FindExistentGroup__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string groupName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _FindExistentGroup(IntPtr _this, FindExistentGroup__Args args);
            private static _FindExistentGroup _FindExistentGroupFunc;
            internal static _FindExistentGroup FindExistentGroup() {
               _FindExistentGroupFunc ??= Torque3D.LookupEngineFunction<_FindExistentGroup>("fnGuiInspector_findExistentGroup");

                return _FindExistentGroupFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CreateGroup__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string groupName;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _CreateGroup(IntPtr _this, CreateGroup__Args args);
            private static _CreateGroup _CreateGroupFunc;
            internal static _CreateGroup CreateGroup() {
               _CreateGroupFunc ??= Torque3D.LookupEngineFunction<_CreateGroup>("fnGuiInspector_createGroup");

                return _CreateGroupFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FindByObject__Args
            {
                internal IntPtr obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _FindByObject(IntPtr _this, FindByObject__Args args);
            private static _FindByObject _FindByObjectFunc;
            internal static _FindByObject FindByObject() {
               _FindByObjectFunc ??= Torque3D.LookupEngineFunction<_FindByObject>("fnGuiInspector_findByObject");

                return _FindByObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetObjectField__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fieldname;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string data;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetObjectField(IntPtr _this, SetObjectField__Args args);
            private static _SetObjectField _SetObjectFieldFunc;
            internal static _SetObjectField SetObjectField() {
               _SetObjectFieldFunc ??= Torque3D.LookupEngineFunction<_SetObjectField>("fnGuiInspector_setObjectField");

                return _SetObjectFieldFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Apply__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Apply(IntPtr _this, Apply__Args args);
            private static _Apply _ApplyFunc;
            internal static _Apply Apply() {
               _ApplyFunc ??= Torque3D.LookupEngineFunction<_Apply>("fnGuiInspector_apply");

                return _ApplyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetName__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newObjectName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetName(IntPtr _this, SetName__Args args);
            private static _SetName _SetNameFunc;
            internal static _SetName SetName() {
               _SetNameFunc ??= Torque3D.LookupEngineFunction<_SetName>("fnGuiInspector_setName");

                return _SetNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNumInspectObjects__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetNumInspectObjects(IntPtr _this, GetNumInspectObjects__Args args);
            private static _GetNumInspectObjects _GetNumInspectObjectsFunc;
            internal static _GetNumInspectObjects GetNumInspectObjects() {
               _GetNumInspectObjectsFunc ??= Torque3D.LookupEngineFunction<_GetNumInspectObjects>("fnGuiInspector_getNumInspectObjects");

                return _GetNumInspectObjectsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetInspectObject__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetInspectObject(IntPtr _this, GetInspectObject__Args args);
            private static _GetInspectObject _GetInspectObjectFunc;
            internal static _GetInspectObject GetInspectObject() {
               _GetInspectObjectFunc ??= Torque3D.LookupEngineFunction<_GetInspectObject>("fnGuiInspector_getInspectObject");

                return _GetInspectObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Refresh__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Refresh(IntPtr _this, Refresh__Args args);
            private static _Refresh _RefreshFunc;
            internal static _Refresh Refresh() {
               _RefreshFunc ??= Torque3D.LookupEngineFunction<_Refresh>("fnGuiInspector_refresh");

                return _RefreshFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveInspect__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObject;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveInspect(IntPtr _this, RemoveInspect__Args args);
            private static _RemoveInspect _RemoveInspectFunc;
            internal static _RemoveInspect RemoveInspect() {
               _RemoveInspectFunc ??= Torque3D.LookupEngineFunction<_RemoveInspect>("fnGuiInspector_removeInspect");

                return _RemoveInspectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddInspect__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObject;
                [MarshalAs(UnmanagedType.I1)]
                internal bool autoSync;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddInspect(IntPtr _this, AddInspect__Args args);
            private static _AddInspect _AddInspectFunc;
            internal static _AddInspect AddInspect() {
               _AddInspectFunc ??= Torque3D.LookupEngineFunction<_AddInspect>("fnGuiInspector_addInspect");

                return _AddInspectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Inspect__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObject;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Inspect(IntPtr _this, Inspect__Args args);
            private static _Inspect _InspectFunc;
            internal static _Inspect Inspect() {
               _InspectFunc ??= Torque3D.LookupEngineFunction<_Inspect>("fnGuiInspector_inspect");

                return _InspectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiInspector_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiInspector_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Finds an existing GuiInspectorGroup if it exists removes it.
        /// </description>
        /// <param name="groupName">Name of the new GuiInspectorGroup to find in this Inspector.</param>
        public void RemoveGroup(string groupName) {
             InternalUnsafeMethods.RemoveGroup__Args _args = new InternalUnsafeMethods.RemoveGroup__Args() {
                groupName = groupName,
             };
             InternalUnsafeMethods.RemoveGroup()(ObjectPtr, _args);
        }

        /// <description>
        /// Finds an existing GuiInspectorGroup if it exists and returns it's Id.
        /// </description>
        /// <param name="groupName">Name of the new GuiInspectorGroup to find in this Inspector.</param>
        /// <returns>id of the named GuiInspectorGroup</returns>
        public int FindExistentGroup(string groupName) {
             InternalUnsafeMethods.FindExistentGroup__Args _args = new InternalUnsafeMethods.FindExistentGroup__Args() {
                groupName = groupName,
             };
             int _engineResult = InternalUnsafeMethods.FindExistentGroup()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Creates a new GuiInspectorGroup for this inspector and returns it's Id. If one already exists, then the Id of the existing one is returned.
        /// </description>
        /// <param name="groupName">Name of the new GuiInspectorGroup to add to this Inspector.</param>
        /// <param name="index(Optional)">The index where to add the new group to in this Inspector's group stack.</param>
        /// <returns>id of the named GuiInspectorGroup</returns>
        public int CreateGroup(string groupName, int index = -1) {
             InternalUnsafeMethods.CreateGroup__Args _args = new InternalUnsafeMethods.CreateGroup__Args() {
                groupName = groupName,
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.CreateGroup()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Returns the id of an awake inspector that is inspecting the passed object if one exists
        /// </description>
        /// <param name="object">Object to find away inspector for.</param>
        /// <returns>id of an awake inspector that is inspecting the passed object if one exists, else NULL or 0.</returns>
        public int FindByObject(SimObject obj) {
             InternalUnsafeMethods.FindByObject__Args _args = new InternalUnsafeMethods.FindByObject__Args() {
                obj = obj.ObjectPtr,
             };
             int _engineResult = InternalUnsafeMethods.FindByObject()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set a named fields value on the inspected object if it exists. This triggers all the usual callbacks that would occur if the field had been changed through the gui..
        /// </description>
        /// <param name="fieldname">Field name on object we are inspecting we want to change.</param>
        /// <param name="data">New Value for the given field.</param>
        public void SetObjectField(string fieldname, string data) {
             InternalUnsafeMethods.SetObjectField__Args _args = new InternalUnsafeMethods.SetObjectField__Args() {
                fieldname = fieldname,
                data = data,
             };
             InternalUnsafeMethods.SetObjectField()(ObjectPtr, _args);
        }

        /// <description>
        /// Force application of inspected object's attributes.
        /// </description>
        public void Apply() {
             InternalUnsafeMethods.Apply__Args _args = new InternalUnsafeMethods.Apply__Args() {
             };
             InternalUnsafeMethods.Apply()(ObjectPtr, _args);
        }

        /// <description>
        /// Rename the object being inspected (first object in inspect list).
        /// </description>
        /// <param name="newObjectName">new name for object being inspected.</param>
        public void SetName(string newObjectName) {
             InternalUnsafeMethods.SetName__Args _args = new InternalUnsafeMethods.SetName__Args() {
                newObjectName = newObjectName,
             };
             InternalUnsafeMethods.SetName()(ObjectPtr, _args);
        }

        /// <description>
        /// Return the number of objects currently being inspected.
        /// </description>
        /// <returns>number of objects currently being inspected.</returns>
        public int GetNumInspectObjects() {
             InternalUnsafeMethods.GetNumInspectObjects__Args _args = new InternalUnsafeMethods.GetNumInspectObjects__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetNumInspectObjects()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Returns currently inspected object.
        /// </description>
        /// <param name="index">Index of object in inspection list you want to get.</param>
        /// <returns>object being inspected.</returns>
        public string GetInspectObject(int index = 0) {
             InternalUnsafeMethods.GetInspectObject__Args _args = new InternalUnsafeMethods.GetInspectObject__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetInspectObject()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Re-inspect the currently selected object.
        /// </description>
        public void Refresh() {
             InternalUnsafeMethods.Refresh__Args _args = new InternalUnsafeMethods.Refresh__Args() {
             };
             InternalUnsafeMethods.Refresh()(ObjectPtr, _args);
        }

        /// <description>
        /// Remove the object from the list of objects being inspected.
        /// </description>
        /// <param name="simObject">Object to remove from the inspection.</param>
        public void RemoveInspect(string simObject) {
             InternalUnsafeMethods.RemoveInspect__Args _args = new InternalUnsafeMethods.RemoveInspect__Args() {
                simObject = simObject,
             };
             InternalUnsafeMethods.RemoveInspect()(ObjectPtr, _args);
        }

        /// <description>
        /// Add the object to the list of objects being inspected.
        /// </description>
        /// <param name="simObject">Object to add to the inspection.</param>
        /// <param name="autoSync">Auto sync the values when they change.</param>
        public void AddInspect(string simObject, bool autoSync = true) {
             InternalUnsafeMethods.AddInspect__Args _args = new InternalUnsafeMethods.AddInspect__Args() {
                simObject = simObject,
                autoSync = autoSync,
             };
             InternalUnsafeMethods.AddInspect()(ObjectPtr, _args);
        }

        /// <description>
        /// Inspect the given object.
        /// </description>
        /// <param name="simObject">Object to inspect.</param>
        public void Inspect(string simObject = "") {
             InternalUnsafeMethods.Inspect__Args _args = new InternalUnsafeMethods.Inspect__Args() {
                simObject = simObject,
             };
             InternalUnsafeMethods.Inspect()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiInspector class.
        /// </description>
        /// <returns>The type info object for GuiInspector</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public int DividerMargin {
            get => GenericMarshal.StringTo<int>(GetFieldValue("dividerMargin"));
            set => SetFieldValue("dividerMargin", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Specify groups that should be shown or not. Specifying 'shown' implicitly does 'not show' all other groups. Example string: +name -otherName
        /// </description>
        /// </value>
        public string GroupFilters {
            get => GenericMarshal.StringTo<string>(GetFieldValue("groupFilters"));
            set => SetFieldValue("groupFilters", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If false the custom fields Name, Id, and Source Class will not be shown.
        /// </description>
        /// </value>
        public bool ShowCustomFields {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showCustomFields"));
            set => SetFieldValue("showCustomFields", GenericMarshal.ToString(value));
        }
    }
}
