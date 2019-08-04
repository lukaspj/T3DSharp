using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using DotLiquid;

namespace T3DSharpGenerator.Model
{
    public class EngineFunction : ILiquidizable
    {
        public string Name { get; set; }
        public string Docs { get; set; }
        public string Scope { get; set; }
        public bool IsCallback { get; set; }
        public bool IsVariadic { get; set; }
        public bool IsStatic { get; set; }
        public bool IsOverride { get; set; }
        public IEngineObject ReturnType { get; set; }
        public string ReturnTypeName { get; set; }
        public string Symbol { get; set; }
        public List<Argument> Arguments { get; set; }

        public EngineFunction(string name) {
            Arguments = new List<Argument>();

            Name = name;
            
            // Default to static.
            IsStatic = true;
        }

        public class Argument : ILiquidizable
        {
            public string Name { get; set; }
            public IEngineObject Type { get; set; }
            public string TypeName { get; set; }
            public string DefaultValue { get; set; }
            public bool IsVariadic { get; set; }
            public int Offset { get; set; }
            public object ToLiquid() {
                return new {
                    Name = Name,
                    Type = Type,
                    DefaultValue = DefaultValue,
                    Offset = Offset,
                };
            }
        }

        public void Add(Argument arg) {
            Arguments.Add(arg);
        }

        public object ToLiquid() {
            return new {
                Name = Name,
                Docs = Docs,
                IsCallback = IsCallback,
                IsVariadic = IsVariadic,
                IsStatic = IsStatic,
                IsOverride = IsOverride,
                ReturnType = ReturnType,
                Symbol = Symbol,
                Args = Arguments
            };
        }
    }
}