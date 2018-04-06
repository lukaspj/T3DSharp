using System.Collections.Generic;
using System.Net;

namespace T3DSharpGenerator.Model
{
    public class EngineClass
    {
        public string Name { get; set; }
        public string Docs { get; set; }
        public string SuperType { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsInstantiable { get; set; }
        public bool IsDispoable { get; set; }
        public bool IsSingleton { get; set; }
        public string Scope { get; set; }
        public List<Property> Properties { get; set; }
        public List<EngineFunction> Methods { get; set; }

        public EngineClass() {
            Properties = new List<Property>();
            Methods = new List<EngineFunction>();
        }
        
        public class Property
        {
            public string Name { get; set; }
            public string Docs { get; set; }
            public string Type { get; set; }
            public string Group { get; set; }
            public string IsConstant { get; set; }
            public string IsTransient { get; set; }
            public string IsVisible { get; set; }
        }

        public void Add(Property property) {
            Properties.Add(property);
        }

        public void Add(EngineFunction engineFunction) {
            Methods.Add(engineFunction);
        }
    }
}