using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Engine
{
    public unsafe class Sim
   {
      [StructLayout(LayoutKind.Explicit, Size = 4)]
      public struct SimObjectPtr
      {
         [FieldOffset(0)]
         public WeakRefPtr* RefPtr;
      }

      [StructLayout(LayoutKind.Explicit, Size = 4)]
      public struct WeakRefPtr
      {
         [FieldOffset(0)]
         public IntPtr ObjPtr;
      }

      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [StructLayout(LayoutKind.Explicit)]
         public struct FindObjectById_Struct
         {
            [FieldOffset(0)]
            public uint id;
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FindObjectById(FindObjectById_Struct args);

         private static _FindObjectById _FindObjectByIdFunc;
         internal static IntPtr FindObjectById(FindObjectById_Struct args) {
            _FindObjectByIdFunc ??= Torque3D.LookupEngineFunction<_FindObjectById>("fnFindObjectById");

            return _FindObjectByIdFunc(args);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FindObjectByName([MarshalAs(UnmanagedType.LPUTF8Str)]string name);
         private static _FindObjectByName _FindObjectByNameFunc;
         internal static IntPtr FindObjectByName(string name)
         {
            _FindObjectByNameFunc ??= Torque3D.LookupEngineFunction<_FindObjectByName>("fnFindObjectByName");

            return _FindObjectByNameFunc(name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FindDataBlockByName(string name);
         private static _FindDataBlockByName _FindDataBlockByNameFunc;
         internal static IntPtr FindDataBlockByName(string name)
         {
            _FindDataBlockByNameFunc ??= Torque3D.LookupEngineFunction<_FindDataBlockByName>("fnFindDataBlockByName");

            return _FindDataBlockByNameFunc(name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sim_WrapObject(IntPtr obj);
         private static _Sim_WrapObject _Sim_WrapObjectFunc;
         internal static IntPtr Sim_WrapObject(IntPtr obj)
         {
            _Sim_WrapObjectFunc ??= Torque3D.LookupEngineFunction<_Sim_WrapObject>("fnWrapObject");

            return _Sim_WrapObjectFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sim_DeleteObjectPtr(IntPtr obj);
         private static _Sim_DeleteObjectPtr _Sim_DeleteObjectPtrFunc;
         internal static void Sim_DeleteObjectPtr(IntPtr obj)
         {
            _Sim_DeleteObjectPtrFunc ??= Torque3D.LookupEngineFunction<_Sim_DeleteObjectPtr>("fnDeleteObjectPtr");

            _Sim_DeleteObjectPtrFunc(obj);
         }
      }

      #endregion

      #region Functions

      public static T FindObject<T>(string objRep) where T : class, ISimObject
      {
         uint id;
         if (uint.TryParse(objRep, out id))
         {
            return FindObjectById<T>(id);
         }

         return FindObjectByName<T>(objRep);
      }

      public static T FindObject<T>(int objRep) where T : class, ISimObject
      {
         return FindObjectById<T>((uint)objRep);
      }

      public static T FindObjectById<T>(uint id) where T : class, ISimObject
      {
         IntPtr objPtr = FindObjectPtrById(id);
         T obj = SimDictionary.Find<T>(id);
         if (obj != null && obj.ObjectPtr == objPtr) return obj;
         obj = (T)FormatterServices.GetUninitializedObject(typeof(T));
         obj.SetPointer(objPtr);
         SimDictionary.RegisterObject(obj);
         return obj;
      }

      public static IntPtr FindObjectPtrById(uint id)
      {
         InternalUnsafeMethods.FindObjectById_Struct idStruct =
            new InternalUnsafeMethods.FindObjectById_Struct
            {
               id = id
            };
         ISimObject obj = SimDictionary.Find<ISimObject>(id);
         if (obj != null) return obj.ObjectPtr;
         return InternalUnsafeMethods.FindObjectById(idStruct);
      }

      public static T FindObjectByName<T>(string name) where T : class, ISimObject
      {
         T dictObj = SimDictionary.Find<T>(name);
         if (dictObj != null) return dictObj;
         T obj = (T)FormatterServices.GetUninitializedObject(typeof(T));
         if (obj is IDataBlock)
         {
            IntPtr objPtr = FindDataBlockPtrByName(name);
            if (objPtr == IntPtr.Zero) objPtr = FindObjectPtrByName(name);
            if (objPtr == IntPtr.Zero) return default(T);
            obj.SetPointer(objPtr);
         }
         else
         {
            IntPtr objPtr = FindObjectPtrByName(name);
            if (objPtr == IntPtr.Zero) return default(T);
            obj.SetPointer(objPtr);
         }
         if (obj.ObjectPtr == IntPtr.Zero)
            return default(T);
         SimDictionary.RegisterObject(obj);
         return obj;
      }

      public static IntPtr FindObjectPtrByName(string name)
      {
         ISimObject obj = SimDictionary.Find<ISimObject>(name);
         if (obj != null) return obj.ObjectPtr;
         return InternalUnsafeMethods.FindObjectByName(name);
      }

      public static IntPtr FindDataBlockPtrByName(string name)
      {
         ISimObject obj = SimDictionary.Find<ISimObject>(name);
         if (obj != null) return obj.ObjectPtr;
         return InternalUnsafeMethods.FindDataBlockByName(name);
      }

      public static unsafe SimObjectPtr* WrapObject(IntPtr obj)
      {
         return (SimObjectPtr*)InternalUnsafeMethods.Sim_WrapObject(obj);
      }

      internal static void DeleteObjectPtr(SimObjectPtr* objPtr)
      {
         InternalUnsafeMethods.Sim_DeleteObjectPtr((IntPtr) objPtr);
      }

      #endregion
   }
}
