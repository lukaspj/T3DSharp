using System.Collections.Generic;

namespace T3DSharpGenerator.Model
{
    public class EngineEnum
    {
        public string Name { get; set; }
        public string Docs { get; set; }
        public string Scope { get; set; }
        public List<Field> Fields { get; set; }

        public EngineEnum() {
            Fields = new List<Field>();
        }

        public struct Field
        {
            public string Name { get; set; }
            public int Value { get; set; }
            public string Docs { get; set; }
        }

        public void Add(Field field) {
            Fields.Add(field);
        }
    }
}