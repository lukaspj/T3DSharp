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
    /// <summary>Data structure for storing indexed sequences of key/value pairs.</summary>
    /// <description>
    /// This is a powerful array class providing PHP style arrays in TorqueScript.
    /// 
    /// The following features are supported:<ul>
    /// <li>array pointers: this allows you to move forwards or backwards through the array as if it was a list, including jumping to the start or end.</li>
    /// <li>sorting: the array can be sorted in either alphabetic or numeric mode, on the key or the value, and in ascending or descending order</li>
    /// <li>add/remove elements: elements can be pushed/popped from the start or end of the array, or can be inserted/erased from anywhere in the middle</li>
    /// <li>removal of duplicates: remove duplicate keys or duplicate values</li>
    /// <li>searching: search the array and return the index of a particular key or value</li>
    /// <li>counting: count the number of instaces of a particular value or key in the array, as well as the total number of elements</li>
    /// <li>advanced features: array append, array crop and array duplicate</li>
    /// </ul>
    /// 
    /// Array element keys and values can be strings or numbers
    /// </description>
    public class ArrayObject : SimObject {
        public ArrayObject(bool pRegister = false)
            : base(pRegister) {
        }

        public ArrayObject(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public ArrayObject(string pName)
            : this(pName, false) {
        }

        public ArrayObject(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ArrayObject(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ArrayObject(SimObject pObj)
            : base(pObj) {
        }

        public ArrayObject(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Echo__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Echo(IntPtr _this, Echo__Args args);
            private static _Echo _EchoFunc;
            internal static _Echo Echo() {
               _EchoFunc ??= Torque3D.LookupEngineFunction<_Echo>("fnArrayObject_echo");

                return _EchoFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCurrent__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCurrent(IntPtr _this, SetCurrent__Args args);
            private static _SetCurrent _SetCurrentFunc;
            internal static _SetCurrent SetCurrent() {
               _SetCurrentFunc ??= Torque3D.LookupEngineFunction<_SetCurrent>("fnArrayObject_setCurrent");

                return _SetCurrentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCurrent__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetCurrent(IntPtr _this, GetCurrent__Args args);
            private static _GetCurrent _GetCurrentFunc;
            internal static _GetCurrent GetCurrent() {
               _GetCurrentFunc ??= Torque3D.LookupEngineFunction<_GetCurrent>("fnArrayObject_getCurrent");

                return _GetCurrentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MovePrev__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _MovePrev(IntPtr _this, MovePrev__Args args);
            private static _MovePrev _MovePrevFunc;
            internal static _MovePrev MovePrev() {
               _MovePrevFunc ??= Torque3D.LookupEngineFunction<_MovePrev>("fnArrayObject_movePrev");

                return _MovePrevFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MoveNext__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _MoveNext(IntPtr _this, MoveNext__Args args);
            private static _MoveNext _MoveNextFunc;
            internal static _MoveNext MoveNext() {
               _MoveNextFunc ??= Torque3D.LookupEngineFunction<_MoveNext>("fnArrayObject_moveNext");

                return _MoveNextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MoveLast__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _MoveLast(IntPtr _this, MoveLast__Args args);
            private static _MoveLast _MoveLastFunc;
            internal static _MoveLast MoveLast() {
               _MoveLastFunc ??= Torque3D.LookupEngineFunction<_MoveLast>("fnArrayObject_moveLast");

                return _MoveLastFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MoveFirst__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _MoveFirst(IntPtr _this, MoveFirst__Args args);
            private static _MoveFirst _MoveFirstFunc;
            internal static _MoveFirst MoveFirst() {
               _MoveFirstFunc ??= Torque3D.LookupEngineFunction<_MoveFirst>("fnArrayObject_moveFirst");

                return _MoveFirstFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortfkd__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string functionName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortfkd(IntPtr _this, Sortfkd__Args args);
            private static _Sortfkd _SortfkdFunc;
            internal static _Sortfkd Sortfkd() {
               _SortfkdFunc ??= Torque3D.LookupEngineFunction<_Sortfkd>("fnArrayObject_sortfkd");

                return _SortfkdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortfd__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string functionName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortfd(IntPtr _this, Sortfd__Args args);
            private static _Sortfd _SortfdFunc;
            internal static _Sortfd Sortfd() {
               _SortfdFunc ??= Torque3D.LookupEngineFunction<_Sortfd>("fnArrayObject_sortfd");

                return _SortfdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortfk__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string functionName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortfk(IntPtr _this, Sortfk__Args args);
            private static _Sortfk _SortfkFunc;
            internal static _Sortfk Sortfk() {
               _SortfkFunc ??= Torque3D.LookupEngineFunction<_Sortfk>("fnArrayObject_sortfk");

                return _SortfkFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortf__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string functionName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortf(IntPtr _this, Sortf__Args args);
            private static _Sortf _SortfFunc;
            internal static _Sortf Sortf() {
               _SortfFunc ??= Torque3D.LookupEngineFunction<_Sortf>("fnArrayObject_sortf");

                return _SortfFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortnkd__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortnkd(IntPtr _this, Sortnkd__Args args);
            private static _Sortnkd _SortnkdFunc;
            internal static _Sortnkd Sortnkd() {
               _SortnkdFunc ??= Torque3D.LookupEngineFunction<_Sortnkd>("fnArrayObject_sortnkd");

                return _SortnkdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortnka__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortnka(IntPtr _this, Sortnka__Args args);
            private static _Sortnka _SortnkaFunc;
            internal static _Sortnka Sortnka() {
               _SortnkaFunc ??= Torque3D.LookupEngineFunction<_Sortnka>("fnArrayObject_sortnka");

                return _SortnkaFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortnk__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool ascending;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortnk(IntPtr _this, Sortnk__Args args);
            private static _Sortnk _SortnkFunc;
            internal static _Sortnk Sortnk() {
               _SortnkFunc ??= Torque3D.LookupEngineFunction<_Sortnk>("fnArrayObject_sortnk");

                return _SortnkFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortnd__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortnd(IntPtr _this, Sortnd__Args args);
            private static _Sortnd _SortndFunc;
            internal static _Sortnd Sortnd() {
               _SortndFunc ??= Torque3D.LookupEngineFunction<_Sortnd>("fnArrayObject_sortnd");

                return _SortndFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortna__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortna(IntPtr _this, Sortna__Args args);
            private static _Sortna _SortnaFunc;
            internal static _Sortna Sortna() {
               _SortnaFunc ??= Torque3D.LookupEngineFunction<_Sortna>("fnArrayObject_sortna");

                return _SortnaFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortn__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool ascending;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortn(IntPtr _this, Sortn__Args args);
            private static _Sortn _SortnFunc;
            internal static _Sortn Sortn() {
               _SortnFunc ??= Torque3D.LookupEngineFunction<_Sortn>("fnArrayObject_sortn");

                return _SortnFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortkd__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortkd(IntPtr _this, Sortkd__Args args);
            private static _Sortkd _SortkdFunc;
            internal static _Sortkd Sortkd() {
               _SortkdFunc ??= Torque3D.LookupEngineFunction<_Sortkd>("fnArrayObject_sortkd");

                return _SortkdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortka__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortka(IntPtr _this, Sortka__Args args);
            private static _Sortka _SortkaFunc;
            internal static _Sortka Sortka() {
               _SortkaFunc ??= Torque3D.LookupEngineFunction<_Sortka>("fnArrayObject_sortka");

                return _SortkaFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortk__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool ascending;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortk(IntPtr _this, Sortk__Args args);
            private static _Sortk _SortkFunc;
            internal static _Sortk Sortk() {
               _SortkFunc ??= Torque3D.LookupEngineFunction<_Sortk>("fnArrayObject_sortk");

                return _SortkFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sortd__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sortd(IntPtr _this, Sortd__Args args);
            private static _Sortd _SortdFunc;
            internal static _Sortd Sortd() {
               _SortdFunc ??= Torque3D.LookupEngineFunction<_Sortd>("fnArrayObject_sortd");

                return _SortdFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sorta__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sorta(IntPtr _this, Sorta__Args args);
            private static _Sorta _SortaFunc;
            internal static _Sorta Sorta() {
               _SortaFunc ??= Torque3D.LookupEngineFunction<_Sorta>("fnArrayObject_sorta");

                return _SortaFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Sort__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool ascending;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Sort(IntPtr _this, Sort__Args args);
            private static _Sort _SortFunc;
            internal static _Sort Sort() {
               _SortFunc ??= Torque3D.LookupEngineFunction<_Sort>("fnArrayObject_sort");

                return _SortFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Append__Args
            {
                internal IntPtr target;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Append(IntPtr _this, Append__Args args);
            private static _Append _AppendFunc;
            internal static _Append Append() {
               _AppendFunc ??= Torque3D.LookupEngineFunction<_Append>("fnArrayObject_append");

                return _AppendFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Crop__Args
            {
                internal IntPtr target;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Crop(IntPtr _this, Crop__Args args);
            private static _Crop _CropFunc;
            internal static _Crop Crop() {
               _CropFunc ??= Torque3D.LookupEngineFunction<_Crop>("fnArrayObject_crop");

                return _CropFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Duplicate__Args
            {
                internal IntPtr target;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Duplicate(IntPtr _this, Duplicate__Args args);
            private static _Duplicate _DuplicateFunc;
            internal static _Duplicate Duplicate() {
               _DuplicateFunc ??= Torque3D.LookupEngineFunction<_Duplicate>("fnArrayObject_duplicate");

                return _DuplicateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UniqueKey__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UniqueKey(IntPtr _this, UniqueKey__Args args);
            private static _UniqueKey _UniqueKeyFunc;
            internal static _UniqueKey UniqueKey() {
               _UniqueKeyFunc ??= Torque3D.LookupEngineFunction<_UniqueKey>("fnArrayObject_uniqueKey");

                return _UniqueKeyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UniqueValue__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UniqueValue(IntPtr _this, UniqueValue__Args args);
            private static _UniqueValue _UniqueValueFunc;
            internal static _UniqueValue UniqueValue() {
               _UniqueValueFunc ??= Torque3D.LookupEngineFunction<_UniqueValue>("fnArrayObject_uniqueValue");

                return _UniqueValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Empty__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Empty(IntPtr _this, Empty__Args args);
            private static _Empty _EmptyFunc;
            internal static _Empty Empty() {
               _EmptyFunc ??= Torque3D.LookupEngineFunction<_Empty>("fnArrayObject_empty");

                return _EmptyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Erase__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Erase(IntPtr _this, Erase__Args args);
            private static _Erase _EraseFunc;
            internal static _Erase Erase() {
               _EraseFunc ??= Torque3D.LookupEngineFunction<_Erase>("fnArrayObject_erase");

                return _EraseFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Pop_front__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Pop_front(IntPtr _this, Pop_front__Args args);
            private static _Pop_front _Pop_frontFunc;
            internal static _Pop_front Pop_front() {
               _Pop_frontFunc ??= Torque3D.LookupEngineFunction<_Pop_front>("fnArrayObject_pop_front");

                return _Pop_frontFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Pop_back__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Pop_back(IntPtr _this, Pop_back__Args args);
            private static _Pop_back _Pop_backFunc;
            internal static _Pop_back Pop_back() {
               _Pop_backFunc ??= Torque3D.LookupEngineFunction<_Pop_back>("fnArrayObject_pop_back");

                return _Pop_backFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Insert__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string key;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Insert(IntPtr _this, Insert__Args args);
            private static _Insert _InsertFunc;
            internal static _Insert Insert() {
               _InsertFunc ??= Torque3D.LookupEngineFunction<_Insert>("fnArrayObject_insert");

                return _InsertFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Push_front__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string key;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Push_front(IntPtr _this, Push_front__Args args);
            private static _Push_front _Push_frontFunc;
            internal static _Push_front Push_front() {
               _Push_frontFunc ??= Torque3D.LookupEngineFunction<_Push_front>("fnArrayObject_push_front");

                return _Push_frontFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Push_back__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string key;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Push_back(IntPtr _this, Push_back__Args args);
            private static _Push_back _Push_backFunc;
            internal static _Push_back Push_back() {
               _Push_backFunc ??= Torque3D.LookupEngineFunction<_Push_back>("fnArrayObject_push_back");

                return _Push_backFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Add__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string key;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Add(IntPtr _this, Add__Args args);
            private static _Add _AddFunc;
            internal static _Add Add() {
               _AddFunc ??= Torque3D.LookupEngineFunction<_Add>("fnArrayObject_add");

                return _AddFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CountKey__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string key;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _CountKey(IntPtr _this, CountKey__Args args);
            private static _CountKey _CountKeyFunc;
            internal static _CountKey CountKey() {
               _CountKeyFunc ??= Torque3D.LookupEngineFunction<_CountKey>("fnArrayObject_countKey");

                return _CountKeyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CountValue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _CountValue(IntPtr _this, CountValue__Args args);
            private static _CountValue _CountValueFunc;
            internal static _CountValue CountValue() {
               _CountValueFunc ??= Torque3D.LookupEngineFunction<_CountValue>("fnArrayObject_countValue");

                return _CountValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Count__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _Count(IntPtr _this, Count__Args args);
            private static _Count _CountFunc;
            internal static _Count Count() {
               _CountFunc ??= Torque3D.LookupEngineFunction<_Count>("fnArrayObject_count");

                return _CountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetValue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetValue(IntPtr _this, SetValue__Args args);
            private static _SetValue _SetValueFunc;
            internal static _SetValue SetValue() {
               _SetValueFunc ??= Torque3D.LookupEngineFunction<_SetValue>("fnArrayObject_setValue");

                return _SetValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetKey__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string key;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetKey(IntPtr _this, SetKey__Args args);
            private static _SetKey _SetKeyFunc;
            internal static _SetKey SetKey() {
               _SetKeyFunc ??= Torque3D.LookupEngineFunction<_SetKey>("fnArrayObject_setKey");

                return _SetKeyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetKey__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetKey(IntPtr _this, GetKey__Args args);
            private static _GetKey _GetKeyFunc;
            internal static _GetKey GetKey() {
               _GetKeyFunc ??= Torque3D.LookupEngineFunction<_GetKey>("fnArrayObject_getKey");

                return _GetKeyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetValue__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetValue(IntPtr _this, GetValue__Args args);
            private static _GetValue _GetValueFunc;
            internal static _GetValue GetValue() {
               _GetValueFunc ??= Torque3D.LookupEngineFunction<_GetValue>("fnArrayObject_getValue");

                return _GetValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetIndexFromKey__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string key;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetIndexFromKey(IntPtr _this, GetIndexFromKey__Args args);
            private static _GetIndexFromKey _GetIndexFromKeyFunc;
            internal static _GetIndexFromKey GetIndexFromKey() {
               _GetIndexFromKeyFunc ??= Torque3D.LookupEngineFunction<_GetIndexFromKey>("fnArrayObject_getIndexFromKey");

                return _GetIndexFromKeyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetIndexFromValue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetIndexFromValue(IntPtr _this, GetIndexFromValue__Args args);
            private static _GetIndexFromValue _GetIndexFromValueFunc;
            internal static _GetIndexFromValue GetIndexFromValue() {
               _GetIndexFromValueFunc ??= Torque3D.LookupEngineFunction<_GetIndexFromValue>("fnArrayObject_getIndexFromValue");

                return _GetIndexFromValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnArrayObject_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnArrayObject_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Echos the array contents to the console
        /// </description>
        public void Echo() {
             InternalUnsafeMethods.Echo__Args _args = new InternalUnsafeMethods.Echo__Args() {
             };
             InternalUnsafeMethods.Echo()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the current pointer index.
        /// </description>
        /// <param name="index">New 0-based pointer index</param>
        public void SetCurrent(int index) {
             InternalUnsafeMethods.SetCurrent__Args _args = new InternalUnsafeMethods.SetCurrent__Args() {
                index = index,
             };
             InternalUnsafeMethods.SetCurrent()(ObjectPtr, _args);
        }

        /// <description>
        /// Gets the current pointer index
        /// </description>
        public int GetCurrent() {
             InternalUnsafeMethods.GetCurrent__Args _args = new InternalUnsafeMethods.GetCurrent__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetCurrent()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Moves array pointer to prev position
        /// </description>
        /// <returns>Returns the new array pointer, or -1 if already at the start</returns>
        public int MovePrev() {
             InternalUnsafeMethods.MovePrev__Args _args = new InternalUnsafeMethods.MovePrev__Args() {
             };
             int _engineResult = InternalUnsafeMethods.MovePrev()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Moves array pointer to next position
        /// </description>
        /// <returns>Returns the new array pointer, or -1 if already at the end</returns>
        public int MoveNext() {
             InternalUnsafeMethods.MoveNext__Args _args = new InternalUnsafeMethods.MoveNext__Args() {
             };
             int _engineResult = InternalUnsafeMethods.MoveNext()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Moves array pointer to end of array
        /// </description>
        /// <returns>Returns the new array pointer</returns>
        public int MoveLast() {
             InternalUnsafeMethods.MoveLast__Args _args = new InternalUnsafeMethods.MoveLast__Args() {
             };
             int _engineResult = InternalUnsafeMethods.MoveLast()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Moves array pointer to start of array
        /// </description>
        /// <returns>Returns the new array pointer</returns>
        public int MoveFirst() {
             InternalUnsafeMethods.MoveFirst__Args _args = new InternalUnsafeMethods.MoveFirst__Args() {
             };
             int _engineResult = InternalUnsafeMethods.MoveFirst()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Sorts the array by key in descending order using the given callback function.
        /// </description>
        /// <param name="functionName">Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.</param>
        /// <see cref="sortf" />
        public void Sortfkd(string functionName) {
             InternalUnsafeMethods.Sortfkd__Args _args = new InternalUnsafeMethods.Sortfkd__Args() {
                functionName = functionName,
             };
             InternalUnsafeMethods.Sortfkd()(ObjectPtr, _args);
        }

        /// <description>
        /// Sorts the array by value in descending order using the given callback function.
        /// </description>
        /// <param name="functionName">Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.</param>
        /// <see cref="sortf" />
        public void Sortfd(string functionName) {
             InternalUnsafeMethods.Sortfd__Args _args = new InternalUnsafeMethods.Sortfd__Args() {
                functionName = functionName,
             };
             InternalUnsafeMethods.Sortfd()(ObjectPtr, _args);
        }

        /// <description>
        /// Sorts the array by key in ascending order using the given callback function.
        /// </description>
        /// <param name="functionName">Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.</param>
        /// <see cref="sortf" />
        public void Sortfk(string functionName) {
             InternalUnsafeMethods.Sortfk__Args _args = new InternalUnsafeMethods.Sortfk__Args() {
                functionName = functionName,
             };
             InternalUnsafeMethods.Sortfk()(ObjectPtr, _args);
        }

        /// <description>
        /// Sorts the array by value in ascending order using the given callback function.
        /// </description>
        /// <param name="functionName">Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.</param>
        /// <code>
        /// function mySortCallback(%a, %b)
        /// {
        ///    return strcmp( %a.name, %b.name );
        /// }
        /// 
        /// %array.sortf( "mySortCallback" );
        /// </code>
        public void Sortf(string functionName) {
             InternalUnsafeMethods.Sortf__Args _args = new InternalUnsafeMethods.Sortf__Args() {
                functionName = functionName,
             };
             InternalUnsafeMethods.Sortf()(ObjectPtr, _args);
        }

        /// <description>
        /// Numerical sorts the array by key in descending order
        /// </description>
        public void Sortnkd() {
             InternalUnsafeMethods.Sortnkd__Args _args = new InternalUnsafeMethods.Sortnkd__Args() {
             };
             InternalUnsafeMethods.Sortnkd()(ObjectPtr, _args);
        }

        /// <description>
        /// Numerical sorts the array by key in ascending order
        /// </description>
        public void Sortnka() {
             InternalUnsafeMethods.Sortnka__Args _args = new InternalUnsafeMethods.Sortnka__Args() {
             };
             InternalUnsafeMethods.Sortnka()(ObjectPtr, _args);
        }

        /// <description>
        /// Numerically sorts the array by key
        /// </description>
        /// <param name="ascending">[optional] True for ascending sort, false for descending sort</param>
        public void Sortnk(bool ascending = false) {
             InternalUnsafeMethods.Sortnk__Args _args = new InternalUnsafeMethods.Sortnk__Args() {
                ascending = ascending,
             };
             InternalUnsafeMethods.Sortnk()(ObjectPtr, _args);
        }

        /// <description>
        /// Numerically sorts the array by value in descending order
        /// </description>
        public void Sortnd() {
             InternalUnsafeMethods.Sortnd__Args _args = new InternalUnsafeMethods.Sortnd__Args() {
             };
             InternalUnsafeMethods.Sortnd()(ObjectPtr, _args);
        }

        /// <description>
        /// Numerically sorts the array by value in ascending order
        /// </description>
        public void Sortna() {
             InternalUnsafeMethods.Sortna__Args _args = new InternalUnsafeMethods.Sortna__Args() {
             };
             InternalUnsafeMethods.Sortna()(ObjectPtr, _args);
        }

        /// <description>
        /// Numerically sorts the array by value
        /// </description>
        /// <param name="ascending">[optional] True for ascending sort, false for descending sort</param>
        public void Sortn(bool ascending = false) {
             InternalUnsafeMethods.Sortn__Args _args = new InternalUnsafeMethods.Sortn__Args() {
                ascending = ascending,
             };
             InternalUnsafeMethods.Sortn()(ObjectPtr, _args);
        }

        /// <description>
        /// Alpha sorts the array by key in descending order
        /// </description>
        public void Sortkd() {
             InternalUnsafeMethods.Sortkd__Args _args = new InternalUnsafeMethods.Sortkd__Args() {
             };
             InternalUnsafeMethods.Sortkd()(ObjectPtr, _args);
        }

        /// <description>
        /// Alpha sorts the array by key in ascending order
        /// </description>
        public void Sortka() {
             InternalUnsafeMethods.Sortka__Args _args = new InternalUnsafeMethods.Sortka__Args() {
             };
             InternalUnsafeMethods.Sortka()(ObjectPtr, _args);
        }

        /// <description>
        /// Alpha sorts the array by key
        /// </description>
        /// <param name="ascending">[optional] True for ascending sort, false for descending sort</param>
        public void Sortk(bool ascending = false) {
             InternalUnsafeMethods.Sortk__Args _args = new InternalUnsafeMethods.Sortk__Args() {
                ascending = ascending,
             };
             InternalUnsafeMethods.Sortk()(ObjectPtr, _args);
        }

        /// <description>
        /// Alpha sorts the array by value in descending order
        /// </description>
        public void Sortd() {
             InternalUnsafeMethods.Sortd__Args _args = new InternalUnsafeMethods.Sortd__Args() {
             };
             InternalUnsafeMethods.Sortd()(ObjectPtr, _args);
        }

        /// <description>
        /// Alpha sorts the array by value in ascending order
        /// </description>
        public void Sorta() {
             InternalUnsafeMethods.Sorta__Args _args = new InternalUnsafeMethods.Sorta__Args() {
             };
             InternalUnsafeMethods.Sorta()(ObjectPtr, _args);
        }

        /// <description>
        /// Alpha sorts the array by value
        /// </description>
        /// <param name="ascending">[optional] True for ascending sort, false for descending sort</param>
        public void Sort(bool ascending = false) {
             InternalUnsafeMethods.Sort__Args _args = new InternalUnsafeMethods.Sort__Args() {
                ascending = ascending,
             };
             InternalUnsafeMethods.Sort()(ObjectPtr, _args);
        }

        /// <description>
        /// Appends the target array to the array object.
        /// </description>
        /// <param name="target">ArrayObject to append to the end of this array</param>
        public bool Append(ArrayObject target) {
             InternalUnsafeMethods.Append__Args _args = new InternalUnsafeMethods.Append__Args() {
                target = target.ObjectPtr,
             };
             bool _engineResult = InternalUnsafeMethods.Append()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Removes elements with matching keys from array.
        /// </description>
        /// <param name="target">ArrayObject containing keys to remove from this array</param>
        public bool Crop(ArrayObject target) {
             InternalUnsafeMethods.Crop__Args _args = new InternalUnsafeMethods.Crop__Args() {
                target = target.ObjectPtr,
             };
             bool _engineResult = InternalUnsafeMethods.Crop()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Alters array into an exact duplicate of the target array.
        /// </description>
        /// <param name="target">ArrayObject to duplicate</param>
        public bool Duplicate(ArrayObject target) {
             InternalUnsafeMethods.Duplicate__Args _args = new InternalUnsafeMethods.Duplicate__Args() {
                target = target.ObjectPtr,
             };
             bool _engineResult = InternalUnsafeMethods.Duplicate()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Removes any elements that have duplicated keys (leaving the first instance)
        /// </description>
        public void UniqueKey() {
             InternalUnsafeMethods.UniqueKey__Args _args = new InternalUnsafeMethods.UniqueKey__Args() {
             };
             InternalUnsafeMethods.UniqueKey()(ObjectPtr, _args);
        }

        /// <description>
        /// Removes any elements that have duplicated values (leaving the first instance)
        /// </description>
        public void UniqueValue() {
             InternalUnsafeMethods.UniqueValue__Args _args = new InternalUnsafeMethods.UniqueValue__Args() {
             };
             InternalUnsafeMethods.UniqueValue()(ObjectPtr, _args);
        }

        /// <description>
        /// Emptys all elements from an array
        /// </description>
        public void Empty() {
             InternalUnsafeMethods.Empty__Args _args = new InternalUnsafeMethods.Empty__Args() {
             };
             InternalUnsafeMethods.Empty()(ObjectPtr, _args);
        }

        /// <description>
        /// Removes an element at a specific position from the array.
        /// </description>
        /// <param name="index">0-based index of the element to remove</param>
        public void Erase(int index) {
             InternalUnsafeMethods.Erase__Args _args = new InternalUnsafeMethods.Erase__Args() {
                index = index,
             };
             InternalUnsafeMethods.Erase()(ObjectPtr, _args);
        }

        /// <description>
        /// Removes the first element from the array
        /// </description>
        public void Pop_front() {
             InternalUnsafeMethods.Pop_front__Args _args = new InternalUnsafeMethods.Pop_front__Args() {
             };
             InternalUnsafeMethods.Pop_front()(ObjectPtr, _args);
        }

        /// <description>
        /// Removes the last element from the array
        /// </description>
        public void Pop_back() {
             InternalUnsafeMethods.Pop_back__Args _args = new InternalUnsafeMethods.Pop_back__Args() {
             };
             InternalUnsafeMethods.Pop_back()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds a new element to a specified position in the array.
        /// -<paramref name="" /> index = 0 will insert an element at the start of the array (same as push_front())
        /// - 
        /// </description>
        /// <param name="key">Key for the new element</param>
        /// <param name="value">Value for the new element</param>
        /// <param name="index">0-based index at which to insert the new element</param>
        public void Insert(string key, string value, int index) {
             InternalUnsafeMethods.Insert__Args _args = new InternalUnsafeMethods.Insert__Args() {
                key = key,
                value = value,
                index = index,
             };
             InternalUnsafeMethods.Insert()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds a new element to the front of an array
        /// </description>
        public void Push_front(string key, string value = "") {
             InternalUnsafeMethods.Push_front__Args _args = new InternalUnsafeMethods.Push_front__Args() {
                key = key,
                value = value,
             };
             InternalUnsafeMethods.Push_front()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds a new element to the end of an array.
        /// </description>
        /// <param name="key">Key for the new element</param>
        /// <param name="value">Value for the new element</param>
        public void Push_back(string key, string value = "") {
             InternalUnsafeMethods.Push_back__Args _args = new InternalUnsafeMethods.Push_back__Args() {
                key = key,
                value = value,
             };
             InternalUnsafeMethods.Push_back()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds a new element to the end of an array (same as push_back()).
        /// </description>
        /// <param name="key">Key for the new element</param>
        /// <param name="value">Value for the new element</param>
        public void Add(string key, string value = "") {
             InternalUnsafeMethods.Add__Args _args = new InternalUnsafeMethods.Add__Args() {
                key = key,
                value = value,
             };
             InternalUnsafeMethods.Add()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the number of times a particular key is found in the array.
        /// </description>
        /// <param name="key">Key value to count</param>
        public int CountKey(string key) {
             InternalUnsafeMethods.CountKey__Args _args = new InternalUnsafeMethods.CountKey__Args() {
                key = key,
             };
             int _engineResult = InternalUnsafeMethods.CountKey()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the number of times a particular value is found in the array.
        /// </description>
        /// <param name="value">Array element value to count</param>
        public int CountValue(string value) {
             InternalUnsafeMethods.CountValue__Args _args = new InternalUnsafeMethods.CountValue__Args() {
                value = value,
             };
             int _engineResult = InternalUnsafeMethods.CountValue()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the number of elements in the array.
        /// </description>
        public int Count() {
             InternalUnsafeMethods.Count__Args _args = new InternalUnsafeMethods.Count__Args() {
             };
             int _engineResult = InternalUnsafeMethods.Count()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set the value at the given index.
        /// </description>
        /// <param name="value">New array element value</param>
        /// <param name="index">0-based index of the array element to update</param>
        public void SetValue(string value, int index) {
             InternalUnsafeMethods.SetValue__Args _args = new InternalUnsafeMethods.SetValue__Args() {
                value = value,
                index = index,
             };
             InternalUnsafeMethods.SetValue()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the key at the given index.
        /// </description>
        /// <param name="key">New key value</param>
        /// <param name="index">0-based index of the array element to update</param>
        public void SetKey(string key, int index) {
             InternalUnsafeMethods.SetKey__Args _args = new InternalUnsafeMethods.SetKey__Args() {
                key = key,
                index = index,
             };
             InternalUnsafeMethods.SetKey()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the key of the array element at the submitted index.
        /// </description>
        /// <param name="index">0-based index of the array element to get</param>
        /// <returns>The key associated with the array element at the specified index, or "" if the index is out of range</returns>
        public string GetKey(int index) {
             InternalUnsafeMethods.GetKey__Args _args = new InternalUnsafeMethods.GetKey__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetKey()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the value of the array element at the submitted index.
        /// </description>
        /// <param name="index">0-based index of the array element to get</param>
        /// <returns>The value of the array element at the specified index, or "" if the index is out of range</returns>
        public string GetValue(int index) {
             InternalUnsafeMethods.GetValue__Args _args = new InternalUnsafeMethods.GetValue__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetValue()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Search the array from the current position for the key
        /// </description>
        /// <param name="value">Array key to search for</param>
        /// <returns>Index of the first element found, or -1 if none</returns>
        public int GetIndexFromKey(string key) {
             InternalUnsafeMethods.GetIndexFromKey__Args _args = new InternalUnsafeMethods.GetIndexFromKey__Args() {
                key = key,
             };
             int _engineResult = InternalUnsafeMethods.GetIndexFromKey()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Search the array from the current position for the element
        /// </description>
        /// <param name="value">Array value to search for</param>
        /// <returns>Index of the first element found, or -1 if none</returns>
        public int GetIndexFromValue(string value) {
             InternalUnsafeMethods.GetIndexFromValue__Args _args = new InternalUnsafeMethods.GetIndexFromValue__Args() {
                value = value,
             };
             int _engineResult = InternalUnsafeMethods.GetIndexFromValue()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the ArrayObject class.
        /// </description>
        /// <returns>The type info object for ArrayObject</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Makes the keys and values case-sensitive.
        /// By default, comparison of key and value strings will be case-insensitive.
        /// </description>
        /// </value>
        public bool CaseSensitive {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("caseSensitive"));
            set => SetFieldValue("caseSensitive", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Helper field which allows you to add new key['keyname'] = value pairs.
        /// </description>
        /// </value>
        public string Key {
            get => GenericMarshal.StringTo<string>(GetFieldValue("key"));
            set => SetFieldValue("key", GenericMarshal.ToString(value));
        }
    }
}
