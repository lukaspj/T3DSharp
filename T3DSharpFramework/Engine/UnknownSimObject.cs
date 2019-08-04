using System;

namespace T3DSharpFramework.Engine
{
    public class UnknownSimObject : ConsoleObjectBase, ISimObject
    {
        public void SetPointerFromObject(ISimObject pObj)
        {
            if (!SimDictionary.Contains(pObj)) SimDictionary.RegisterObject(pObj);
            ObjectPtr = pObj.ObjectPtr;
        }

        public T As<T>() where T : class, ISimObject
        {
            return (T)SimDictionary.CreateInstance(typeof(T), this);
        }

        public ISimObject As(Type t)
        {
            if (!typeof(ISimObject).IsAssignableFrom(t)) return null;
            return (ISimObject)SimDictionary.CreateInstance(t, this);
        }

        public string Name { get; set; }

        public bool RegisterObject()
        {
            throw new NotImplementedException();
        }

        public string GetFieldValue(string name, int index)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldValue(string fieldName, string value, int index)
        {
            throw new NotImplementedException();
        }
    }
}