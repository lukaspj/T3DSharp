using System.Collections.Generic;
using System.Linq;
using DotLiquid;

namespace T3DSharpGenerator.Model
{
    public class EngineEnum : IEngineObject
    {
        public string Name { get; set; }
        public string ManagedType { get; set; }
        public string NativeReturnType { get; set; }
        public string NativeArgType { get; set; }
        public string Docs { get; set; }
        public string Scope { get; set; }
        public List<Field> Fields { get; set; }

        public EngineEnum(string name) {
            Fields = new List<Field>();

            Name = name;
            ManagedType = Name;
            NativeArgType = "int";
            NativeReturnType = "int";
        }

        public class Field : ILiquidizable
        {
            public string Name { get; set; }
            public int Value { get; set; }
            public string Docs { get; set; }
            public object ToLiquid() {
                return new {
                    Name = Name,
                    Value = Value,
                    Docs = Docs
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
                Fields = Fields.Select(x => x.ToLiquid())
            };
        }
    }
}