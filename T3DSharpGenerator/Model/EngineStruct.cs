using System.Collections.Generic;
using DotLiquid;
using Hash = DotLiquid.Hash;

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

        public class Field : ILiquidizable
        {
            public string Name { get; set; }
            public string Docs { get; set; }
            public string Offset { get; set; }
            public IEngineObject Type { get; set; }
            public string TypeName { get; set; }
            public int IndexedSize { get; set; }

            public object ToLiquid() {
                return new {
                    Name = Name,
                    Docs = Docs,
                    Offset = Offset,
                    Type = Type,
                    IndexedSize = IndexedSize
                };
            }
        }

        public void Add(Field field) {
            Fields.Add(field);
        }

        public object ToLiquid() {
            return new {
                Name = Name,
                Docs = Docs,
                Scope = Scope,
                Fields = Fields,
                
                ManagedType = ManagedType,
                NativeReturnType = NativeReturnType,
                NativeArgType = NativeArgType
            };
        }
    }
}