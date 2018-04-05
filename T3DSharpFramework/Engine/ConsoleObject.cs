using System;

namespace T3DSharpFramework.Engine
{
    public class ConsoleObject : IDisposable
    {
        public IntPtr ObjectPtr { get; protected set; }
        
        public void SetPointerFromObject(ConsoleObject pObj)
        {
            if (!SimDictionary.Contains(pObj)) SimDictionary.RegisterObject(pObj);
            ObjectPtr = pObj.ObjectPtr;
        }

        public void SetPointer(IntPtr pObjPtr)
        {
            ObjectPtr = pObjPtr;
            SimDictionary.RegisterObject(this);
        }

        public T As<T>() where T : ConsoleObject
        {
            return (T)SimDictionary.CreateInstance(typeof(T), this);
        }

        public ConsoleObject As(Type t)
        {
            if (!typeof(ConsoleObject).IsAssignableFrom(t)) return null;
            return (ConsoleObject)SimDictionary.CreateInstance(t, this);
        }

        public bool IsDead()
        {
            return SimDictionary.IsDead(ObjectPtr);
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool pDisposing)
        {
            /*if (((IntPtr)ObjectPtr->RefPtr) != IntPtr.Zero)
            {
            Marshal.FreeHGlobal((IntPtr) ObjectPtr);
            }*/

            SimDictionary.UnregisterObjectPtr(ObjectPtr);
        }

        ~ConsoleObject()
        {
            Dispose(false);
        }

        #endregion

        public string Name = null;
        public string getName() => null;

        public int getId() => -1;
        
        #region Implicits and operators

        public static bool operator ==(ConsoleObject obj, string str)
        {
            if (str == null) return ReferenceEquals(obj, null);
            if (ReferenceEquals(obj, null)) return false;
            return obj.Name == str || obj.getId().ToString().Equals(str);
        }

        public static bool operator !=(ConsoleObject obj, string str)
        {
            return !(obj == str);
        }

        public static bool operator ==(ConsoleObject obj, object other)
        {
            if (ReferenceEquals(other, null)) return ReferenceEquals(obj, null);
            if (ReferenceEquals(obj, null)) return false;
            if (other is string str)
            {
                return obj.Name == str || obj.getId().ToString().Equals(str);
            }
            ConsoleObject sobj = other as ConsoleObject;
            if(sobj != null)
                return obj.ObjectPtr == sobj.ObjectPtr;
            return obj.Equals(other);
        }

        public static bool operator !=(ConsoleObject obj, object other)
        {
            return !(obj == other);
        }

        #endregion
    }
}