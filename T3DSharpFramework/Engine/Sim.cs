﻿using System;
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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FindObjectById(uint id);
         private static _FindObjectById _FindObjectByIdFunc;
         internal static IntPtr FindObjectById(uint id)
         {
            if (_FindObjectByIdFunc == null)
            {
               _FindObjectByIdFunc =
                  (_FindObjectById)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "Sim_FindObjectById"), typeof(_FindObjectById));
            }

            return _FindObjectByIdFunc(id);
         }
         
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FindObjectByName(string name);
         private static _FindObjectByName _FindObjectByNameFunc;
         internal static IntPtr FindObjectByName(string name)
         {
            if (_FindObjectByNameFunc == null)
            {
               _FindObjectByNameFunc =
                  (_FindObjectByName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "Sim_FindObjectByName"), typeof(_FindObjectByName));
            }

            return _FindObjectByNameFunc(name);
         }
         
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FindDataBlockByName(string name);
         private static _FindDataBlockByName _FindDataBlockByNameFunc;
         internal static IntPtr FindDataBlockByName(string name)
         {
            if (_FindDataBlockByNameFunc == null)
            {
               _FindDataBlockByNameFunc =
                  (_FindDataBlockByName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "Sim_FindDataBlockByName"), typeof(_FindDataBlockByName));
            }

            return _FindDataBlockByNameFunc(name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sim_WrapObject(IntPtr obj);
         private static _Sim_WrapObject _Sim_WrapObjectFunc;
         internal static IntPtr Sim_WrapObject(IntPtr obj)
         {
            if (_Sim_WrapObjectFunc == null)
            {
               _Sim_WrapObjectFunc =
                  (_Sim_WrapObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "Sim_WrapObject"), typeof(_Sim_WrapObject));
            }

            return _Sim_WrapObjectFunc(obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Sim_DeleteObjectPtr(IntPtr obj);
         private static _Sim_DeleteObjectPtr _Sim_DeleteObjectPtrFunc;
         internal static void Sim_DeleteObjectPtr(IntPtr obj)
         {
            if (_Sim_DeleteObjectPtrFunc == null)
            {
               _Sim_DeleteObjectPtrFunc =
                  (_Sim_DeleteObjectPtr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
                     "Sim_DeleteObjectPtr"), typeof(_Sim_DeleteObjectPtr));
            }

            _Sim_DeleteObjectPtrFunc(obj);
         }
      }

      #endregion

      #region Functions

      public static T FindObject<T>(string objRep) where T : ConsoleObject
      {
         uint id;
         if (uint.TryParse(objRep, out id))
         {
            return FindObjectById<T>(id);
         }

         return FindObjectByName<T>(objRep);
      }

      public static T FindObject<T>(int objRep) where T : ConsoleObject
      {
         return FindObjectById<T>((uint)objRep);
      }

      public static T FindObjectById<T>(uint id) where T : ConsoleObject
      {
         IntPtr objPtr = InternalUnsafeMethods.FindObjectById(id);
         T obj = SimDictionary.Find<T>(id);
         if (obj != null && obj.ObjectPtr == objPtr) return obj;
         obj = (T)FormatterServices.GetUninitializedObject(typeof(T));
         obj.SetPointer(objPtr);
         SimDictionary.RegisterObject(obj);
         return obj;
      }

      public static IntPtr FindObjectPtrById(uint id)
      {
         ConsoleObject obj = SimDictionary.Find<ConsoleObject>(id);
         if (obj != null) return obj.ObjectPtr;
         return InternalUnsafeMethods.FindObjectById(id);
      }

      public static T FindObjectByName<T>(string name) where T : ConsoleObject
      {
         T dictObj = SimDictionary.Find<T>(name);
         if (dictObj != null) return dictObj;
         T obj = (T)FormatterServices.GetUninitializedObject(typeof(T));
         if (obj is IDataBlock)
         {
            IntPtr objPtr = FindDataBlockPtrByName(name);
            if (objPtr == IntPtr.Zero) objPtr = FindObjectPtrByName(name);
            if (objPtr == IntPtr.Zero) return null;
            obj.SetPointer(objPtr);
         }
         else
         {
            IntPtr objPtr = FindObjectPtrByName(name);
            if (objPtr == IntPtr.Zero) return null;
            obj.SetPointer(objPtr);
         }
         if (obj.ObjectPtr == IntPtr.Zero)
            return null;
         SimDictionary.RegisterObject(obj);
         return obj;
      }

      public static IntPtr FindObjectPtrByName(string name)
      {
         ConsoleObject obj = SimDictionary.Find<ConsoleObject>(name);
         if (obj != null) return obj.ObjectPtr;
         return InternalUnsafeMethods.FindObjectByName(name);
      }

      public static IntPtr FindDataBlockPtrByName(string name)
      {
         ConsoleObject obj = SimDictionary.Find<ConsoleObject>(name);
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