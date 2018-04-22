using DotLiquid;

namespace T3DSharpGenerator.Model
{
    public class EnginePrimitive : IEngineObject
    {
        public string Name { get; set; }
        
        public string ManagedType { get; set; }
        public string NativeReturnType { get; set; }
        public string NativeArgType { get; set; }

        public object ToLiquid() {
            return new {
                Name = Name,
                ManagedType = ManagedType,
                NativeReturnType = NativeReturnType,
                NativeArgType = NativeArgType
            };
        }
    }
}