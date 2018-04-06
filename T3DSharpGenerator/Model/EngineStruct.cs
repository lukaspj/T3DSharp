using System.Collections.Generic;

namespace T3DSharpGenerator.Model
{
    public class EngineStruct
    {
        public string Name { get; set; }
        public string Docs { get; set; }
        public string Scope { get; set; }
        public List<Field> Fields { get; set; }

        public EngineStruct() {
            Fields = new List<Field>();
        }

        public struct Field
        {
            public string Name { get; set; }
            public string Docs { get; set; }
            public string Offset { get; set; }
            public string Type { get; set; }
        }

        public void Add(Field field) {
            Fields.Add(field);
        }

    }
}