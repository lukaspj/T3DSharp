using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace T3DSharpFramework.Engine
{
    internal unsafe class SimDictionary
    {
        private static readonly Dictionary<int, ConsoleObject> ObjectDictionary =
            new Dictionary<int, ConsoleObject>();

        private static readonly Dictionary<string, int> ObjectNameDictionary = new Dictionary<string, int>();
        private static readonly Dictionary<IntPtr, IntPtr> ObjectWrapperDictionary = new Dictionary<IntPtr, IntPtr>();
        private static readonly Dictionary<IntPtr, int> ObjectWrapperCountDictionary = new Dictionary<IntPtr, int>();

        public static object CreateInstance(Type type, ConsoleObject objectWrapper) {
            if (!ObjectDictionary.ContainsKey(objectWrapper.getId())
                || !(type.IsInstanceOfType(ObjectDictionary[objectWrapper.getId()]))) {
                ConsoleObject obj = (ConsoleObject) FormatterServices.GetUninitializedObject(type);
                obj.SetPointerFromObject(objectWrapper);
                RegisterObject(obj);
                ObjectDictionary[objectWrapper.getId()] = obj;
            }

            ConsoleObject dicObject = ObjectDictionary[objectWrapper.getId()];
            if (!string.IsNullOrEmpty(dicObject.Name)) {
                ObjectNameDictionary[dicObject.Name] = dicObject.getId();
            }

            return dicObject;
        }

        public static object RegisterObject(ConsoleObject obj) {
            RegisterObjectPtr(obj.ObjectPtr);

            int id = obj.getId();

            if (!ObjectDictionary.ContainsKey(id)
                || ObjectDictionary[id].GetType().IsInstanceOfType(obj)) {
                ObjectDictionary[id] = obj;
            }

            if (!string.IsNullOrEmpty(obj.Name)) {
                ObjectNameDictionary[obj.Name] = id;
            }

            return ObjectDictionary[id];
        }

        public static bool UnregisterObject(ConsoleObject obj) {
            bool isDead = IsDead(obj.ObjectPtr);
            UnregisterObjectPtr(obj.ObjectPtr);
            if (isDead) return true;
            if (!ObjectDictionary.ContainsKey(obj.getId())) {
                return false;
            }

            ObjectDictionary.Remove(obj.getId());
            return true;
        }

        public static unsafe void RegisterObjectPtr(IntPtr objectPtr) {
            if (!ObjectWrapperDictionary.ContainsKey(objectPtr)) {
                ObjectWrapperDictionary[objectPtr] = (IntPtr) Sim.WrapObject(objectPtr);
                ObjectWrapperCountDictionary[objectPtr] = 0;
            }

            ObjectWrapperCountDictionary[objectPtr]++;
        }

        public static unsafe void UnregisterObjectPtr(IntPtr objectPtr) {
            if (!ObjectWrapperDictionary.ContainsKey(objectPtr)) return;
            if (ObjectWrapperCountDictionary[objectPtr] < 0) {
                throw new Exception("Less than 0 references to the object.");
            }

            ObjectWrapperCountDictionary[objectPtr]--;
            if (ObjectWrapperCountDictionary[objectPtr] <= 0) {
                Sim.DeleteObjectPtr((Sim.SimObjectPtr*) ObjectWrapperDictionary[objectPtr]);
                ObjectWrapperDictionary.Remove(objectPtr);
                ObjectWrapperCountDictionary.Remove(objectPtr);
            }
        }

        internal static void DisposeAndClear() {
            List<ConsoleObject> objects = new List<ConsoleObject>(ObjectDictionary.Values);
            foreach (ConsoleObject obj in objects) {
                obj.Dispose();
            }

            ObjectDictionary.Clear();
        }

        public static ConsoleObject Find(string name) {
            if (string.IsNullOrEmpty(name)
                || !ObjectNameDictionary.ContainsKey(name)
                || ObjectDictionary[ObjectNameDictionary[name]].IsDead()) return null;

            return ObjectDictionary[ObjectNameDictionary[name]];
        }

        public static ConsoleObject Find(int id) {
            if (!ObjectDictionary.ContainsKey(id) || ObjectDictionary[id].IsDead()) return null;

            return ObjectDictionary[id];
        }

        public static T Find<T>(string name) where T : ConsoleObject {
            if (string.IsNullOrEmpty(name)
                || !ObjectNameDictionary.ContainsKey(name) 
                || ObjectDictionary[ObjectNameDictionary[name]].IsDead()) return null;

            if (ObjectDictionary[ObjectNameDictionary[name]] is T)
                return (T) ObjectDictionary[ObjectNameDictionary[name]];
            return ObjectDictionary[ObjectNameDictionary[name]].As<T>();
        }

        public static T Find<T>(uint id) where T : ConsoleObject {
            if (!ObjectDictionary.ContainsKey((int) id) || ObjectDictionary[(int) id].IsDead()) return null;
            if (ObjectDictionary[(int) id] is T) return ObjectDictionary[(int) id] as T;
            return ObjectDictionary[(int) id].As<T>();
        }

        public static bool Contains(ConsoleObject pObj) {
            return ObjectWrapperDictionary.ContainsKey(pObj.ObjectPtr);
        }

        public static unsafe bool IsDead(IntPtr objectPtr) {
            if (!ObjectWrapperDictionary.ContainsKey(objectPtr)) return true;
            return ((IntPtr) ((Sim.SimObjectPtr*) ObjectWrapperDictionary[objectPtr])->RefPtr->ObjPtr) == IntPtr.Zero;
        }

        public static void Shutdown() {
            ObjectDictionary.Clear();
            ObjectNameDictionary.Clear();
            foreach (KeyValuePair<IntPtr, IntPtr> pair in ObjectWrapperDictionary)
                unsafe {
                    Sim.DeleteObjectPtr((Sim.SimObjectPtr*) pair.Value);
                }

            ObjectWrapperDictionary.Clear();
            ObjectWrapperCountDictionary.Clear();
        }
    }
}