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
    /// <summary>Class used for writing out preferences and settings for editors</summary>
    /// <description>
    /// Not intended for game development, for editors or internal use only.
    /// </description>
    public class Settings : SimObject {
        public Settings(bool pRegister = false)
            : base(pRegister) {
        }

        public Settings(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public Settings(string pName)
            : this(pName, false) {
        }

        public Settings(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Settings(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Settings(SimObject pObj)
            : base(pObj) {
        }

        public Settings(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrentGroups__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetCurrentGroups(IntPtr _this, GetCurrentGroups__Args args);
            private static _GetCurrentGroups _GetCurrentGroupsFunc;
            internal static _GetCurrentGroups GetCurrentGroups() {
               _GetCurrentGroupsFunc ??= Torque3D.LookupEngineFunction<_GetCurrentGroups>("fnSettings_getCurrentGroups");

                return _GetCurrentGroupsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearGroups__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearGroups(IntPtr _this, ClearGroups__Args args);
            private static _ClearGroups _ClearGroupsFunc;
            internal static _ClearGroups ClearGroups() {
               _ClearGroupsFunc ??= Torque3D.LookupEngineFunction<_ClearGroups>("fnSettings_clearGroups");

                return _ClearGroupsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct EndGroup__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _EndGroup(IntPtr _this, EndGroup__Args args);
            private static _EndGroup _EndGroupFunc;
            internal static _EndGroup EndGroup() {
               _EndGroupFunc ??= Torque3D.LookupEngineFunction<_EndGroup>("fnSettings_endGroup");

                return _EndGroupFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct BeginGroup__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string groupName;
                [MarshalAs(UnmanagedType.I1)]
                internal bool includeDefaults;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _BeginGroup(IntPtr _this, BeginGroup__Args args);
            private static _BeginGroup _BeginGroupFunc;
            internal static _BeginGroup BeginGroup() {
               _BeginGroupFunc ??= Torque3D.LookupEngineFunction<_BeginGroup>("fnSettings_beginGroup");

                return _BeginGroupFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Read__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Read(IntPtr _this, Read__Args args);
            private static _Read _ReadFunc;
            internal static _Read Read() {
               _ReadFunc ??= Torque3D.LookupEngineFunction<_Read>("fnSettings_read");

                return _ReadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Write__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Write(IntPtr _this, Write__Args args);
            private static _Write _WriteFunc;
            internal static _Write Write() {
               _WriteFunc ??= Torque3D.LookupEngineFunction<_Write>("fnSettings_write");

                return _WriteFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Remove__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string settingName;
                [MarshalAs(UnmanagedType.I1)]
                internal bool includeDefaults;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Remove(IntPtr _this, Remove__Args args);
            private static _Remove _RemoveFunc;
            internal static _Remove Remove() {
               _RemoveFunc ??= Torque3D.LookupEngineFunction<_Remove>("fnSettings_remove");

                return _RemoveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Value__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string settingName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string defaultValue;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _Value(IntPtr _this, Value__Args args);
            private static _Value _ValueFunc;
            internal static _Value Value() {
               _ValueFunc ??= Torque3D.LookupEngineFunction<_Value>("fnSettings_value");

                return _ValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetDefaultValue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string settingName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetDefaultValue(IntPtr _this, SetDefaultValue__Args args);
            private static _SetDefaultValue _SetDefaultValueFunc;
            internal static _SetDefaultValue SetDefaultValue() {
               _SetDefaultValueFunc ??= Torque3D.LookupEngineFunction<_SetDefaultValue>("fnSettings_setDefaultValue");

                return _SetDefaultValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetValue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string settingName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetValue(IntPtr _this, SetValue__Args args);
            private static _SetValue _SetValueFunc;
            internal static _SetValue SetValue() {
               _SetValueFunc ??= Torque3D.LookupEngineFunction<_SetValue>("fnSettings_setValue");

                return _SetValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FindNextValue__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _FindNextValue(IntPtr _this, FindNextValue__Args args);
            private static _FindNextValue _FindNextValueFunc;
            internal static _FindNextValue FindNextValue() {
               _FindNextValueFunc ??= Torque3D.LookupEngineFunction<_FindNextValue>("fnSettings_findNextValue");

                return _FindNextValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FindFirstValue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pattern;
                [MarshalAs(UnmanagedType.I1)]
                internal bool deepSearch;
                [MarshalAs(UnmanagedType.I1)]
                internal bool includeDefaults;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _FindFirstValue(IntPtr _this, FindFirstValue__Args args);
            private static _FindFirstValue _FindFirstValueFunc;
            internal static _FindFirstValue FindFirstValue() {
               _FindFirstValueFunc ??= Torque3D.LookupEngineFunction<_FindFirstValue>("fnSettings_findFirstValue");

                return _FindFirstValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnSettings_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnSettings_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// settingObj.getCurrentGroups();
        /// </description>
        public string GetCurrentGroups() {
             InternalUnsafeMethods.GetCurrentGroups__Args _args = new InternalUnsafeMethods.GetCurrentGroups__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetCurrentGroups()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// settingObj.clearGroups();
        /// </description>
        public void ClearGroups() {
             InternalUnsafeMethods.ClearGroups__Args _args = new InternalUnsafeMethods.ClearGroups__Args() {
             };
             InternalUnsafeMethods.ClearGroups()(ObjectPtr, _args);
        }

        /// <description>
        /// settingObj.endGroup();
        /// </description>
        public void EndGroup() {
             InternalUnsafeMethods.EndGroup__Args _args = new InternalUnsafeMethods.EndGroup__Args() {
             };
             InternalUnsafeMethods.EndGroup()(ObjectPtr, _args);
        }

        /// <description>
        /// settingObj.beginGroup(groupName, fromStart = false);
        /// </description>
        public void BeginGroup(string groupName, bool includeDefaults = false) {
             InternalUnsafeMethods.BeginGroup__Args _args = new InternalUnsafeMethods.BeginGroup__Args() {
                groupName = groupName,
                includeDefaults = includeDefaults,
             };
             InternalUnsafeMethods.BeginGroup()(ObjectPtr, _args);
        }

        /// <description>
        /// %success = settingObj.read();
        /// </description>
        public bool Read() {
             InternalUnsafeMethods.Read__Args _args = new InternalUnsafeMethods.Read__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.Read()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// %success = settingObj.write();
        /// </description>
        public bool Write() {
             InternalUnsafeMethods.Write__Args _args = new InternalUnsafeMethods.Write__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.Write()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// settingObj.remove(settingName, includeDefaults = false);
        /// </description>
        public void Remove(string settingName, bool includeDefaults = false) {
             InternalUnsafeMethods.Remove__Args _args = new InternalUnsafeMethods.Remove__Args() {
                settingName = settingName,
                includeDefaults = includeDefaults,
             };
             InternalUnsafeMethods.Remove()(ObjectPtr, _args);
        }

        /// <description>
        /// settingObj.value(settingName, defaultValue);
        /// </description>
        public string Value(string settingName, string defaultValue = "") {
             InternalUnsafeMethods.Value__Args _args = new InternalUnsafeMethods.Value__Args() {
                settingName = settingName,
                defaultValue = defaultValue,
             };
             IntPtr _engineResult = InternalUnsafeMethods.Value()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// settingObj.setDefaultValue(settingName, value);
        /// </description>
        public void SetDefaultValue(string settingName, string value) {
             InternalUnsafeMethods.SetDefaultValue__Args _args = new InternalUnsafeMethods.SetDefaultValue__Args() {
                settingName = settingName,
                value = value,
             };
             InternalUnsafeMethods.SetDefaultValue()(ObjectPtr, _args);
        }

        /// <description>
        /// settingObj.setValue(settingName, value);
        /// </description>
        public void SetValue(string settingName, string value = "") {
             InternalUnsafeMethods.SetValue__Args _args = new InternalUnsafeMethods.SetValue__Args() {
                settingName = settingName,
                value = value,
             };
             InternalUnsafeMethods.SetValue()(ObjectPtr, _args);
        }

        /// <description>
        /// settingObj.findNextValue();
        /// </description>
        public string FindNextValue() {
             InternalUnsafeMethods.FindNextValue__Args _args = new InternalUnsafeMethods.FindNextValue__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.FindNextValue()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// settingObj.findFirstValue();
        /// </description>
        public string FindFirstValue(string pattern = "", bool deepSearch = false, bool includeDefaults = false) {
             InternalUnsafeMethods.FindFirstValue__Args _args = new InternalUnsafeMethods.FindFirstValue__Args() {
                pattern = pattern,
                deepSearch = deepSearch,
                includeDefaults = includeDefaults,
             };
             IntPtr _engineResult = InternalUnsafeMethods.FindFirstValue()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the Settings class.
        /// </description>
        /// <returns>The type info object for Settings</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// The file path and name to be saved to and loaded from.
        /// </description>
        /// </value>
        public string File {
            get => GenericMarshal.StringTo<string>(GetFieldValue("file"));
            set => SetFieldValue("file", GenericMarshal.ToString(value));
        }
    }
}
