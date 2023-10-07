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
    /// <summary>Provides access to a zip file.</summary>
    /// <description>
    /// A ZipObject add, delete and extract files that are within a zip archive.  You may also read and write directly to the files within the archive by obtaining a StreamObject for the file.
    /// </description>
    /// <code>
    /// // Open a zip archive, creating it if it doesn't exist
    /// %archive = new ZipObject();
    /// %archive.openArchive("testArchive.zip", Write);
    /// 
    /// // Add a file to the archive with the given name
    /// %archive.addFile("./water.png", "water.png");
    /// 
    /// // Close the archive to save the changes
    /// %archive.closeArchive();
    /// </code>
    /// <remarks> Behind the scenes all of the work is being done with the ZipArchive and StreamObject classes.
    /// </remarks>
    /// <see cref="StreamObject when using methods such as openFileForRead() and openFileForWrite()" />
    public class ZipObject : SimObject {
        public ZipObject(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public ZipObject(string pName, bool pRegister)
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

        public ZipObject(string pName)
            : this(pName, false) {
        }

        public ZipObject(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ZipObject(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ZipObject(SimObject pObj)
            : base(pObj) {
        }

        public ZipObject(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFileEntry__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetFileEntry(IntPtr _this, GetFileEntry__Args args);
            private static _GetFileEntry _GetFileEntryFunc;
            internal static _GetFileEntry GetFileEntry() {
               _GetFileEntryFunc ??= Torque3D.LookupEngineFunction<_GetFileEntry>("fnZipObject_getFileEntry");

                return _GetFileEntryFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFileEntryCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetFileEntryCount(IntPtr _this, GetFileEntryCount__Args args);
            private static _GetFileEntryCount _GetFileEntryCountFunc;
            internal static _GetFileEntryCount GetFileEntryCount() {
               _GetFileEntryCountFunc ??= Torque3D.LookupEngineFunction<_GetFileEntryCount>("fnZipObject_getFileEntryCount");

                return _GetFileEntryCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pathInZip;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _DeleteFile(IntPtr _this, DeleteFile__Args args);
            private static _DeleteFile _DeleteFileFunc;
            internal static _DeleteFile DeleteFile() {
               _DeleteFileFunc ??= Torque3D.LookupEngineFunction<_DeleteFile>("fnZipObject_deleteFile");

                return _DeleteFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ExtractFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pathInZip;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _ExtractFile(IntPtr _this, ExtractFile__Args args);
            private static _ExtractFile _ExtractFileFunc;
            internal static _ExtractFile ExtractFile() {
               _ExtractFileFunc ??= Torque3D.LookupEngineFunction<_ExtractFile>("fnZipObject_extractFile");

                return _ExtractFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string pathInZip;
                [MarshalAs(UnmanagedType.I1)]
                internal bool replace;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _AddFile(IntPtr _this, AddFile__Args args);
            private static _AddFile _AddFileFunc;
            internal static _AddFile AddFile() {
               _AddFileFunc ??= Torque3D.LookupEngineFunction<_AddFile>("fnZipObject_addFile");

                return _AddFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CloseFile__Args
            {
                internal IntPtr stream;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CloseFile(IntPtr _this, CloseFile__Args args);
            private static _CloseFile _CloseFileFunc;
            internal static _CloseFile CloseFile() {
               _CloseFileFunc ??= Torque3D.LookupEngineFunction<_CloseFile>("fnZipObject_closeFile");

                return _CloseFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OpenFileForWrite__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _OpenFileForWrite(IntPtr _this, OpenFileForWrite__Args args);
            private static _OpenFileForWrite _OpenFileForWriteFunc;
            internal static _OpenFileForWrite OpenFileForWrite() {
               _OpenFileForWriteFunc ??= Torque3D.LookupEngineFunction<_OpenFileForWrite>("fnZipObject_openFileForWrite");

                return _OpenFileForWriteFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OpenFileForRead__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _OpenFileForRead(IntPtr _this, OpenFileForRead__Args args);
            private static _OpenFileForRead _OpenFileForReadFunc;
            internal static _OpenFileForRead OpenFileForRead() {
               _OpenFileForReadFunc ??= Torque3D.LookupEngineFunction<_OpenFileForRead>("fnZipObject_openFileForRead");

                return _OpenFileForReadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CloseArchive__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CloseArchive(IntPtr _this, CloseArchive__Args args);
            private static _CloseArchive _CloseArchiveFunc;
            internal static _CloseArchive CloseArchive() {
               _CloseArchiveFunc ??= Torque3D.LookupEngineFunction<_CloseArchive>("fnZipObject_closeArchive");

                return _CloseArchiveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OpenArchive__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string accessMode;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _OpenArchive(IntPtr _this, OpenArchive__Args args);
            private static _OpenArchive _OpenArchiveFunc;
            internal static _OpenArchive OpenArchive() {
               _OpenArchiveFunc ??= Torque3D.LookupEngineFunction<_OpenArchive>("fnZipObject_openArchive");

                return _OpenArchiveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnZipObject_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnZipObject_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Get information on the requested file within the zip archive.</summary>
        /// <description>
        /// This methods provides five different pieces of information for the requested file:
        /// <ul><li>filename - The path and name of the file within the zip archive</li><li>uncompressed size</li><li>compressed size</li><li>compression method</li><li>CRC32</li></ul>
        /// Use getFileEntryCount() to obtain the total number of files within the archive.
        /// </description>
        /// <param name="index">The index of the file within the zip archive.  Use getFileEntryCount() to determine the number of files.</param>
        /// <returns>A tab delimited list of information on the requested file, or an empty string if the file could not be found.</returns>
        /// <see cref="getFileEntryCount()" />
        public string GetFileEntry(int index) {
             InternalUnsafeMethods.GetFileEntry__Args _args = new InternalUnsafeMethods.GetFileEntry__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetFileEntry()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Get the number of files within the zip archive.</summary>
        /// <description>
        /// Use getFileEntry() to retrive information on each file within the archive.
        /// </description>
        /// <returns>The number of files within the zip archive.</returns>
        /// <remarks> The returned count will include any files that have been deleted from the archive using deleteFile().  To clear out all deleted files, you could close and then open the archive again.
        /// </remarks>
        /// <see cref="getFileEntry()" />
        /// <see cref="closeArchive()" />
        /// <see cref="openArchive()" />
        public int GetFileEntryCount() {
             InternalUnsafeMethods.GetFileEntryCount__Args _args = new InternalUnsafeMethods.GetFileEntryCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetFileEntryCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Deleted the given file from the zip archive</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="pathInZip">The path and name of the file to be deleted from the zip archive.</param>
        /// <returns>True of the file was successfully deleted.</returns>
        /// <remarks> Files that have been deleted from the archive will still show up with a getFileEntryCount() until you close the archive.  If you need to have the file count up to date with only valid files within the archive, you could close and then open the archive again.
        /// </remarks>
        /// <see cref="getFileEntryCount()" />
        /// <see cref="closeArchive()" />
        /// <see cref="openArchive()" />
        public bool DeleteFile(string pathInZip) {
             InternalUnsafeMethods.DeleteFile__Args _args = new InternalUnsafeMethods.DeleteFile__Args() {
                pathInZip = pathInZip,
             };
             bool _engineResult = InternalUnsafeMethods.DeleteFile()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Extact a file from the zip archive and save it to the requested location.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="pathInZip">The path and name of the file to be extracted within the zip archive.</param>
        /// <param name="filename">The path and name to give the extracted file.</param>
        /// <returns>True if the file was successfully extracted.</returns>
        public bool ExtractFile(string pathInZip, string filename) {
             InternalUnsafeMethods.ExtractFile__Args _args = new InternalUnsafeMethods.ExtractFile__Args() {
                pathInZip = pathInZip,
                filename = filename,
             };
             bool _engineResult = InternalUnsafeMethods.ExtractFile()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Add a file to the zip archive</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="filename">The path and name of the file to add to the zip archive.</param>
        /// <param name="pathInZip">The path and name to be given to the file within the zip archive.</param>
        /// <param name="replace">If a file already exists within the zip archive at the same location as this new file, this parameter indicates if it should be replaced.  By default, it will be replaced.</param>
        /// <returns>True if the file was successfully added to the zip archive.</returns>
        public bool AddFile(string filename, string pathInZip, bool replace = true) {
             InternalUnsafeMethods.AddFile__Args _args = new InternalUnsafeMethods.AddFile__Args() {
                filename = filename,
                pathInZip = pathInZip,
                replace = replace,
             };
             bool _engineResult = InternalUnsafeMethods.AddFile()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Close a previously opened file within the zip archive.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="stream">The StreamObject of a previously opened file within the zip archive.</param>
        /// <see cref="openFileForRead()" />
        /// <see cref="openFileForWrite()" />
        public void CloseFile(SimObject stream) {
             InternalUnsafeMethods.CloseFile__Args _args = new InternalUnsafeMethods.CloseFile__Args() {
                stream = stream.ObjectPtr,
             };
             InternalUnsafeMethods.CloseFile()(ObjectPtr, _args);
        }

        /// <summary>Open a file within the zip archive for writing to.</summary>
        /// <description>
        /// Be sure to close the file when you are done with it.
        /// </description>
        /// <param name="filename">The path and name of the file to open within the zip archive.</param>
        /// <returns>A standard StreamObject is returned for working with the file.</returns>
        /// <remarks> You must first open the zip archive before working with files within it.
        /// </remarks>
        /// <see cref="closeFile()" />
        /// <see cref="openArchive()" />
        public SimObject OpenFileForWrite(string filename) {
             InternalUnsafeMethods.OpenFileForWrite__Args _args = new InternalUnsafeMethods.OpenFileForWrite__Args() {
                filename = filename,
             };
             IntPtr _engineResult = InternalUnsafeMethods.OpenFileForWrite()(ObjectPtr, _args);
             return new SimObject(_engineResult);
        }

        /// <summary>Open a file within the zip archive for reading.</summary>
        /// <description>
        /// Be sure to close the file when you are done with it.
        /// </description>
        /// <param name="filename">The path and name of the file to open within the zip archive.</param>
        /// <returns>A standard StreamObject is returned for working with the file.</returns>
        /// <remarks> You must first open the zip archive before working with files within it.
        /// </remarks>
        /// <see cref="closeFile()" />
        /// <see cref="openArchive()" />
        public SimObject OpenFileForRead(string filename) {
             InternalUnsafeMethods.OpenFileForRead__Args _args = new InternalUnsafeMethods.OpenFileForRead__Args() {
                filename = filename,
             };
             IntPtr _engineResult = InternalUnsafeMethods.OpenFileForRead()(ObjectPtr, _args);
             return new SimObject(_engineResult);
        }

        /// <summary>Close an already opened zip archive.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="openArchive()" />
        public void CloseArchive() {
             InternalUnsafeMethods.CloseArchive__Args _args = new InternalUnsafeMethods.CloseArchive__Args() {
             };
             InternalUnsafeMethods.CloseArchive()(ObjectPtr, _args);
        }

        /// <summary>Open a zip archive for manipulation.</summary>
        /// <description>
        /// Once a zip archive is opened use the various ZipObject methods for working with the files within the archive.  Be sure to close the archive when you are done with it.
        /// </description>
        /// <param name="filename">The path and file name of the zip archive to open.</param>
        /// <param name="accessMode">One of read, write or readwrite</param>
        /// <returns>True is the archive was successfully opened.</returns>
        /// <remarks> If you wish to make any changes to the archive, be sure to open it with a write or readwrite access mode.
        /// </remarks>
        /// <see cref="closeArchive()" />
        public bool OpenArchive(string filename, string accessMode = "read") {
             InternalUnsafeMethods.OpenArchive__Args _args = new InternalUnsafeMethods.OpenArchive__Args() {
                filename = filename,
                accessMode = accessMode,
             };
             bool _engineResult = InternalUnsafeMethods.OpenArchive()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the ZipObject class.
        /// </description>
        /// <returns>The type info object for ZipObject</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
