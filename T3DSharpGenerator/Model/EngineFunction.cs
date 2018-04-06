using System.Collections.Generic;
using System.Runtime.Hosting;

namespace T3DSharpGenerator.Model
{
    public class EngineFunction
    {
        public string Name { get; set; }
        public string Docs { get; set; }
        public string Scope { get; set; }
        public bool IsCallback { get; set; }
        public bool IsVariadic { get; set; }
        public string ReturnType { get; set; }
        public string Symbol { get; set; }
        public List<Argument> Arguments { get; set; }

        public EngineFunction() {
            Arguments = new List<Argument>();
        }

        public struct Argument
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string DefaultValue { get; set; }
        }

        public void Add(Argument arg) {
            Arguments.Add(arg);
        }
    }
}