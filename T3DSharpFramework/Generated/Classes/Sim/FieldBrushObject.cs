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
    /// <summary>For static-field copying/pasting, editor use only</summary>
    /// <description>
    /// 
    /// </description>
    public class FieldBrushObject : SimObject {
        public FieldBrushObject(bool pRegister = false)
            : base(pRegister) {
        }

        public FieldBrushObject(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public FieldBrushObject(string pName)
            : this(pName, false) {
        }

        public FieldBrushObject(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public FieldBrushObject(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public FieldBrushObject(SimObject pObj)
            : base(pObj) {
        }

        public FieldBrushObject(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PasteFields__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObjName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PasteFields(IntPtr _this, PasteFields__Args args);
            private static _PasteFields _PasteFieldsFunc;
            internal static _PasteFields PasteFields() {
               _PasteFieldsFunc ??= Torque3D.LookupEngineFunction<_PasteFields>("fnFieldBrushObject_pasteFields");

                return _PasteFieldsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CopyFields__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObjName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pFieldList;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CopyFields(IntPtr _this, CopyFields__Args args);
            private static _CopyFields _CopyFieldsFunc;
            internal static _CopyFields CopyFields() {
               _CopyFieldsFunc ??= Torque3D.LookupEngineFunction<_CopyFields>("fnFieldBrushObject_copyFields");

                return _CopyFieldsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct QueryFields__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObjName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string groupList;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _QueryFields(IntPtr _this, QueryFields__Args args);
            private static _QueryFields _QueryFieldsFunc;
            internal static _QueryFields QueryFields() {
               _QueryFieldsFunc ??= Torque3D.LookupEngineFunction<_QueryFields>("fnFieldBrushObject_queryFields");

                return _QueryFieldsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct QueryGroups__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string simObjName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _QueryGroups(IntPtr _this, QueryGroups__Args args);
            private static _QueryGroups _QueryGroupsFunc;
            internal static _QueryGroups QueryGroups() {
               _QueryGroupsFunc ??= Torque3D.LookupEngineFunction<_QueryGroups>("fnFieldBrushObject_queryGroups");

                return _QueryGroupsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnFieldBrushObject_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnFieldBrushObject_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// (simObject) Paste copied static-fields to selected object./
        /// </description>
        /// <param name="simObject">Object to paste static-fields to.</param>
        /// <returns>No return value.</returns>
        public void PasteFields(string simObjName) {
             InternalUnsafeMethods.PasteFields__Args _args = new InternalUnsafeMethods.PasteFields__Args() {
                simObjName = simObjName,
             };
             InternalUnsafeMethods.PasteFields()(ObjectPtr, _args);
        }

        /// <description>
        /// (simObject, [fieldList]) Copy selected static-fields for selected object./
        /// </description>
        /// <param name="simObject">Object to copy static-fields from.</param>
        /// <param name="fieldList">fields to filter static-fields against.</param>
        /// <returns>No return value.</returns>
        public void CopyFields(string simObjName, string pFieldList = "") {
             InternalUnsafeMethods.CopyFields__Args _args = new InternalUnsafeMethods.CopyFields__Args() {
                simObjName = simObjName,
                pFieldList = pFieldList,
             };
             InternalUnsafeMethods.CopyFields()(ObjectPtr, _args);
        }

        /// <description>
        /// (simObject, [groupList]) Query available static-fields for selected object./
        /// </description>
        /// <param name="simObject">Object to query static-fields on.</param>
        /// <param name="groupList">groups to filter static-fields against.</param>
        /// <returns>Space-seperated static-field list.</returns>
        public string QueryFields(string simObjName, string groupList = "") {
             InternalUnsafeMethods.QueryFields__Args _args = new InternalUnsafeMethods.QueryFields__Args() {
                simObjName = simObjName,
                groupList = groupList,
             };
             IntPtr _engineResult = InternalUnsafeMethods.QueryFields()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (simObject) Query available static-field groups for selected object./
        /// </description>
        /// <param name="simObject">Object to query static-field groups on.</param>
        /// <returns>Space-seperated static-field group list.</returns>
        public string QueryGroups(string simObjName) {
             InternalUnsafeMethods.QueryGroups__Args _args = new InternalUnsafeMethods.QueryGroups__Args() {
                simObjName = simObjName,
             };
             IntPtr _engineResult = InternalUnsafeMethods.QueryGroups()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the FieldBrushObject class.
        /// </description>
        /// <returns>The type info object for FieldBrushObject</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public string Description {
            get => GenericMarshal.StringTo<string>(GetFieldValue("description"));
            set => SetFieldValue("description", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string SortName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("sortName"));
            set => SetFieldValue("sortName", GenericMarshal.ToString(value));
        }
    }
}
