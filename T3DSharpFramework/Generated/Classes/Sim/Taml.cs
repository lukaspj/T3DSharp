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
    /// 
    public class Taml : SimObject {
        public Taml(bool pRegister = false)
            : base(pRegister) {
        }

        public Taml(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public Taml(string pName)
            : this(pName, false) {
        }

        public Taml(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Taml(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Taml(SimObject pObj)
            : base(pObj) {
        }

        public Taml(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnTaml_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnTaml_create");

                return _CreateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Read__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Read(IntPtr _this, Read__Args args);
            private static _Read _ReadFunc;
            internal static _Read Read() {
               _ReadFunc ??= Torque3D.LookupEngineFunction<_Read>("fnTaml_read");

                return _ReadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Write__Args
            {
                internal IntPtr obj;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Write(IntPtr _this, Write__Args args);
            private static _Write _WriteFunc;
            internal static _Write Write() {
               _WriteFunc ??= Torque3D.LookupEngineFunction<_Write>("fnTaml_write");

                return _WriteFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetJSONStrict__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetJSONStrict(IntPtr _this, GetJSONStrict__Args args);
            private static _GetJSONStrict _GetJSONStrictFunc;
            internal static _GetJSONStrict GetJSONStrict() {
               _GetJSONStrictFunc ??= Torque3D.LookupEngineFunction<_GetJSONStrict>("fnTaml_getJSONStrict");

                return _GetJSONStrictFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetJSONStrict__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool strict;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetJSONStrict(IntPtr _this, SetJSONStrict__Args args);
            private static _SetJSONStrict _SetJSONStrictFunc;
            internal static _SetJSONStrict SetJSONStrict() {
               _SetJSONStrictFunc ??= Torque3D.LookupEngineFunction<_SetJSONStrict>("fnTaml_setJSONStrict");

                return _SetJSONStrictFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBinaryCompression__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetBinaryCompression(IntPtr _this, GetBinaryCompression__Args args);
            private static _GetBinaryCompression _GetBinaryCompressionFunc;
            internal static _GetBinaryCompression GetBinaryCompression() {
               _GetBinaryCompressionFunc ??= Torque3D.LookupEngineFunction<_GetBinaryCompression>("fnTaml_getBinaryCompression");

                return _GetBinaryCompressionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetBinaryCompression__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool compressed;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetBinaryCompression(IntPtr _this, SetBinaryCompression__Args args);
            private static _SetBinaryCompression _SetBinaryCompressionFunc;
            internal static _SetBinaryCompression SetBinaryCompression() {
               _SetBinaryCompressionFunc ??= Torque3D.LookupEngineFunction<_SetBinaryCompression>("fnTaml_setBinaryCompression");

                return _SetBinaryCompressionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAutoFormatBinaryExtension__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAutoFormatBinaryExtension(IntPtr _this, GetAutoFormatBinaryExtension__Args args);
            private static _GetAutoFormatBinaryExtension _GetAutoFormatBinaryExtensionFunc;
            internal static _GetAutoFormatBinaryExtension GetAutoFormatBinaryExtension() {
               _GetAutoFormatBinaryExtensionFunc ??= Torque3D.LookupEngineFunction<_GetAutoFormatBinaryExtension>("fnTaml_getAutoFormatBinaryExtension");

                return _GetAutoFormatBinaryExtensionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAutoFormatBinaryExtension__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string extension;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAutoFormatBinaryExtension(IntPtr _this, SetAutoFormatBinaryExtension__Args args);
            private static _SetAutoFormatBinaryExtension _SetAutoFormatBinaryExtensionFunc;
            internal static _SetAutoFormatBinaryExtension SetAutoFormatBinaryExtension() {
               _SetAutoFormatBinaryExtensionFunc ??= Torque3D.LookupEngineFunction<_SetAutoFormatBinaryExtension>("fnTaml_setAutoFormatBinaryExtension");

                return _SetAutoFormatBinaryExtensionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAutoFormatXmlExtension__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAutoFormatXmlExtension(IntPtr _this, GetAutoFormatXmlExtension__Args args);
            private static _GetAutoFormatXmlExtension _GetAutoFormatXmlExtensionFunc;
            internal static _GetAutoFormatXmlExtension GetAutoFormatXmlExtension() {
               _GetAutoFormatXmlExtensionFunc ??= Torque3D.LookupEngineFunction<_GetAutoFormatXmlExtension>("fnTaml_getAutoFormatXmlExtension");

                return _GetAutoFormatXmlExtensionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAutoFormatXmlExtension__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string extension;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAutoFormatXmlExtension(IntPtr _this, SetAutoFormatXmlExtension__Args args);
            private static _SetAutoFormatXmlExtension _SetAutoFormatXmlExtensionFunc;
            internal static _SetAutoFormatXmlExtension SetAutoFormatXmlExtension() {
               _SetAutoFormatXmlExtensionFunc ??= Torque3D.LookupEngineFunction<_SetAutoFormatXmlExtension>("fnTaml_setAutoFormatXmlExtension");

                return _SetAutoFormatXmlExtensionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetProgenitorUpdate__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetProgenitorUpdate(IntPtr _this, GetProgenitorUpdate__Args args);
            private static _GetProgenitorUpdate _GetProgenitorUpdateFunc;
            internal static _GetProgenitorUpdate GetProgenitorUpdate() {
               _GetProgenitorUpdateFunc ??= Torque3D.LookupEngineFunction<_GetProgenitorUpdate>("fnTaml_getProgenitorUpdate");

                return _GetProgenitorUpdateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetProgenitorUpdate__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool progenitorUpdate;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetProgenitorUpdate(IntPtr _this, SetProgenitorUpdate__Args args);
            private static _SetProgenitorUpdate _SetProgenitorUpdateFunc;
            internal static _SetProgenitorUpdate SetProgenitorUpdate() {
               _SetProgenitorUpdateFunc ??= Torque3D.LookupEngineFunction<_SetProgenitorUpdate>("fnTaml_setProgenitorUpdate");

                return _SetProgenitorUpdateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetWriteDefaults__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetWriteDefaults(IntPtr _this, GetWriteDefaults__Args args);
            private static _GetWriteDefaults _GetWriteDefaultsFunc;
            internal static _GetWriteDefaults GetWriteDefaults() {
               _GetWriteDefaultsFunc ??= Torque3D.LookupEngineFunction<_GetWriteDefaults>("fnTaml_getWriteDefaults");

                return _GetWriteDefaultsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetWriteDefaults__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool writeDefaults;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetWriteDefaults(IntPtr _this, SetWriteDefaults__Args args);
            private static _SetWriteDefaults _SetWriteDefaultsFunc;
            internal static _SetWriteDefaults SetWriteDefaults() {
               _SetWriteDefaultsFunc ??= Torque3D.LookupEngineFunction<_SetWriteDefaults>("fnTaml_setWriteDefaults");

                return _SetWriteDefaultsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAutoFormat__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _GetAutoFormat(IntPtr _this, GetAutoFormat__Args args);
            private static _GetAutoFormat _GetAutoFormatFunc;
            internal static _GetAutoFormat GetAutoFormat() {
               _GetAutoFormatFunc ??= Torque3D.LookupEngineFunction<_GetAutoFormat>("fnTaml_getAutoFormat");

                return _GetAutoFormatFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAutoFormat__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool autoFormat;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAutoFormat(IntPtr _this, SetAutoFormat__Args args);
            private static _SetAutoFormat _SetAutoFormatFunc;
            internal static _SetAutoFormat SetAutoFormat() {
               _SetAutoFormatFunc ??= Torque3D.LookupEngineFunction<_SetAutoFormat>("fnTaml_setAutoFormat");

                return _SetAutoFormatFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFormat__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetFormat(IntPtr _this, GetFormat__Args args);
            private static _GetFormat _GetFormatFunc;
            internal static _GetFormat GetFormat() {
               _GetFormatFunc ??= Torque3D.LookupEngineFunction<_GetFormat>("fnTaml_getFormat");

                return _GetFormatFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetFormat__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string formatName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetFormat(IntPtr _this, SetFormat__Args args);
            private static _SetFormat _SetFormatFunc;
            internal static _SetFormat SetFormat() {
               _SetFormatFunc ??= Torque3D.LookupEngineFunction<_SetFormat>("fnTaml_setFormat");

                return _SetFormatFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the Taml class.
        /// </description>
        /// <returns>The type info object for Taml</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }

        /// <description>
        /// (filename) - Read an object from a file using Taml.
        /// </description>
        /// <param name="filename">The filename to read from.</param>
        /// <returns>(Object) The object read from the file or an empty string if read failed.</returns>
        public SimObject Read(string filename) {
             InternalUnsafeMethods.Read__Args _args = new InternalUnsafeMethods.Read__Args() {
                filename = filename,
             };
             IntPtr _engineResult = InternalUnsafeMethods.Read()(ObjectPtr, _args);
             return new SimObject(_engineResult);
        }

        /// <description>
        /// (object, filename) - Writes an object to a file using Taml.
        /// </description>
        /// <param name="object">The object to write.</param>
        /// <param name="filename">The filename to write to.</param>
        /// <returns>Whether the write was successful or not.</returns>
        public bool Write(SimObject obj, string filename) {
             InternalUnsafeMethods.Write__Args _args = new InternalUnsafeMethods.Write__Args() {
                obj = obj.ObjectPtr,
                filename = filename,
             };
             bool _engineResult = InternalUnsafeMethods.Write()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// () - Gets whether to write JSON that is strictly compatible with RFC4627 or not.
        /// </description>
        /// <returns>whether to write JSON that is strictly compatible with RFC4627 or not.</returns>
        public bool GetJSONStrict() {
             InternalUnsafeMethods.GetJSONStrict__Args _args = new InternalUnsafeMethods.GetJSONStrict__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetJSONStrict()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (jsonStrict) - Sets whether to write JSON that is strictly compatible with RFC4627 or not.
        /// </description>
        /// <param name="jsonStrict">Whether to write JSON that is strictly compatible with RFC4627 or not.</param>
        /// <returns>No return value.</returns>
        public void SetJSONStrict(bool strict) {
             InternalUnsafeMethods.SetJSONStrict__Args _args = new InternalUnsafeMethods.SetJSONStrict__Args() {
                strict = strict,
             };
             InternalUnsafeMethods.SetJSONStrict()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Gets whether ZIP compression is used on binary formatting or not.
        /// </description>
        /// <returns>Whether ZIP compression is used on binary formatting or not.</returns>
        public bool GetBinaryCompression() {
             InternalUnsafeMethods.GetBinaryCompression__Args _args = new InternalUnsafeMethods.GetBinaryCompression__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetBinaryCompression()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (compressed) - Sets whether ZIP compression is used on binary formatting or not.
        /// </description>
        /// <param name="compressed">Whether compression is on or off.</param>
        /// <returns>No return value.</returns>
        public void SetBinaryCompression(bool compressed) {
             InternalUnsafeMethods.SetBinaryCompression__Args _args = new InternalUnsafeMethods.SetBinaryCompression__Args() {
                compressed = compressed,
             };
             InternalUnsafeMethods.SetBinaryCompression()(ObjectPtr, _args);
        }

        /// <description>
        /// () Gets the extension (end of filename) used to detect the Binary format.
        /// </description>
        /// <returns>The extension (end of filename) used to detect the Binary format.</returns>
        public string GetAutoFormatBinaryExtension() {
             InternalUnsafeMethods.GetAutoFormatBinaryExtension__Args _args = new InternalUnsafeMethods.GetAutoFormatBinaryExtension__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAutoFormatBinaryExtension()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (extension) Sets the extension (end of filename) used to detect the Binary format.
        /// </description>
        /// <param name="extension">The extension (end of filename) used to detect the Binary format.</param>
        /// <returns>No return value.</returns>
        public void SetAutoFormatBinaryExtension(string extension) {
             InternalUnsafeMethods.SetAutoFormatBinaryExtension__Args _args = new InternalUnsafeMethods.SetAutoFormatBinaryExtension__Args() {
                extension = extension,
             };
             InternalUnsafeMethods.SetAutoFormatBinaryExtension()(ObjectPtr, _args);
        }

        /// <description>
        /// () Gets the extension (end of filename) used to detect the XML format.
        /// </description>
        /// <returns>The extension (end of filename) used to detect the XML format.</returns>
        public string GetAutoFormatXmlExtension() {
             InternalUnsafeMethods.GetAutoFormatXmlExtension__Args _args = new InternalUnsafeMethods.GetAutoFormatXmlExtension__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAutoFormatXmlExtension()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (extension) Sets the extension (end of filename) used to detect the XML format.
        /// </description>
        /// <param name="extension">The extension (end of filename) used to detect the XML format.</param>
        /// <returns>No return value.</returns>
        public void SetAutoFormatXmlExtension(string extension) {
             InternalUnsafeMethods.SetAutoFormatXmlExtension__Args _args = new InternalUnsafeMethods.SetAutoFormatXmlExtension__Args() {
                extension = extension,
             };
             InternalUnsafeMethods.SetAutoFormatXmlExtension()(ObjectPtr, _args);
        }

        /// <description>
        /// () Gets whether to update each type instances file-progenitor or not.
        /// </description>
        /// <returns>Whether to update each type instances file-progenitor or not.</returns>
        public bool GetProgenitorUpdate() {
             InternalUnsafeMethods.GetProgenitorUpdate__Args _args = new InternalUnsafeMethods.GetProgenitorUpdate__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetProgenitorUpdate()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (progenitorUpdate) Sets whether to update each type instances file-progenitor or not.
        /// If not updating then the progenitor stay as the script that executed the call to Taml.
        /// </description>
        /// <param name="progenitorUpdate">Whether to update each type instances file-progenitor or not.</param>
        /// <returns>No return value.</returns>
        public void SetProgenitorUpdate(bool progenitorUpdate) {
             InternalUnsafeMethods.SetProgenitorUpdate__Args _args = new InternalUnsafeMethods.SetProgenitorUpdate__Args() {
                progenitorUpdate = progenitorUpdate,
             };
             InternalUnsafeMethods.SetProgenitorUpdate()(ObjectPtr, _args);
        }

        /// <description>
        /// () Gets whether to write static fields that are at their default or not.
        /// </description>
        /// <returns>Whether to write static fields that are at their default or not.</returns>
        public bool GetWriteDefaults() {
             InternalUnsafeMethods.GetWriteDefaults__Args _args = new InternalUnsafeMethods.GetWriteDefaults__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetWriteDefaults()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (writeDefaults) Sets whether to write static fields that are at their default or not.
        /// </description>
        /// <param name="writeDefaults">Whether to write static fields that are at their default or not.</param>
        /// <returns>No return value.</returns>
        public void SetWriteDefaults(bool writeDefaults) {
             InternalUnsafeMethods.SetWriteDefaults__Args _args = new InternalUnsafeMethods.SetWriteDefaults__Args() {
                writeDefaults = writeDefaults,
             };
             InternalUnsafeMethods.SetWriteDefaults()(ObjectPtr, _args);
        }

        /// <description>
        /// () Gets whether the format type is automatically determined by the filename extension or not.
        /// </description>
        /// <returns>Whether the format type is automatically determined by the filename extension or not.</returns>
        public bool GetAutoFormat() {
             InternalUnsafeMethods.GetAutoFormat__Args _args = new InternalUnsafeMethods.GetAutoFormat__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.GetAutoFormat()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (autoFormat) Sets whether the format type is automatically determined by the filename extension or not.
        /// </description>
        /// <param name="autoFormat">Whether the format type is automatically determined by the filename extension or not.</param>
        /// <returns>No return value.</returns>
        public void SetAutoFormat(bool autoFormat) {
             InternalUnsafeMethods.SetAutoFormat__Args _args = new InternalUnsafeMethods.SetAutoFormat__Args() {
                autoFormat = autoFormat,
             };
             InternalUnsafeMethods.SetAutoFormat()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Gets the format that Taml should use to read/write.
        /// </description>
        /// <returns>The format that Taml should use to read/write.</returns>
        public string GetFormat() {
             InternalUnsafeMethods.GetFormat__Args _args = new InternalUnsafeMethods.GetFormat__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetFormat()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// (format) - Sets the format that Taml should use to read/write.
        /// </description>
        /// <param name="format">The format to use: 'xml' or 'binary'.</param>
        /// <returns>No return value.</returns>
        public void SetFormat(string formatName) {
             InternalUnsafeMethods.SetFormat__Args _args = new InternalUnsafeMethods.SetFormat__Args() {
                formatName = formatName,
             };
             InternalUnsafeMethods.SetFormat()(ObjectPtr, _args);
        }


        /// <value>
        /// <description>
        /// The read/write format that should be used.
        /// </description>
        /// </value>
        public _TamlFormatMode Format {
            get => GenericMarshal.StringTo<_TamlFormatMode>(GetFieldValue("format"));
            set => SetFieldValue("format", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to write JSON that is strictly compatible with RFC4627 or not.
        /// </description>
        /// </value>
        public bool JSONStrict {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("JSONStrict"));
            set => SetFieldValue("JSONStrict", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether ZIP compression is used on binary formatting or not.
        /// </description>
        /// </value>
        public bool BinaryCompression {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("BinaryCompression"));
            set => SetFieldValue("BinaryCompression", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to write static fields that are at their default or not.
        /// </description>
        /// </value>
        public bool WriteDefaults {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("WriteDefaults"));
            set => SetFieldValue("WriteDefaults", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to update each type instances file-progenitor or not.
        /// </description>
        /// </value>
        public bool ProgenitorUpdate {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("ProgenitorUpdate"));
            set => SetFieldValue("ProgenitorUpdate", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the format type is automatically determined by the filename extension or not.
        /// </description>
        /// </value>
        public bool AutoFormat {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("AutoFormat"));
            set => SetFieldValue("AutoFormat", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// When using auto-format, this is the extension (end of filename) used to detect the XML format.
        /// </description>
        /// </value>
        public string AutoFormatXmlExtension {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AutoFormatXmlExtension"));
            set => SetFieldValue("AutoFormatXmlExtension", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// When using auto-format, this is the extension (end of filename) used to detect the BINARY format.
        /// </description>
        /// </value>
        public string AutoFormatBinaryExtension {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AutoFormatBinaryExtension"));
            set => SetFieldValue("AutoFormatBinaryExtension", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// When using auto-format, this is the extension (end of filename) used to detect the JSON format.
        /// </description>
        /// </value>
        public string AutoFormatJSONExtension {
            get => GenericMarshal.StringTo<string>(GetFieldValue("AutoFormatJSONExtension"));
            set => SetFieldValue("AutoFormatJSONExtension", GenericMarshal.ToString(value));
        }
    }
}
