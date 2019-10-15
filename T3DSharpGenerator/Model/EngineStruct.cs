using System.Collections.Generic;

namespace T3DSharpGenerator.Model
{
    public class EngineStruct : IEngineObject
    {
        public string Name { get; set; }
        public string ManagedType { get; set; }
        public string NativeReturnType { get; set; }
        public string NativeArgType { get; set; }
        public string Docs { get; set; }
        public string Scope { get; set; }
        public List<Field> Fields { get; set; }

        public EngineStruct(string name) {
            Fields = new List<Field>();

            Name = name;
            ManagedType = Name;
            NativeReturnType = Name + ".InternalStruct";
            NativeArgType = "IntPtr";
            //NativeArgType = "ref " + Name + ".InternalStruct";
        }

        public class Field
        {
            public string Name { get; set; }
            public string Docs { get; set; }
            public string Offset { get; set; }
            public IEngineObject Type { get; set; }
            public string TypeName { get; set; }
            public int IndexedSize { get; set; }
        }

        public void Add(Field field) {
            Fields.Add(field);
        }
    }
}