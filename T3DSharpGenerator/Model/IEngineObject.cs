using DotLiquid;

namespace T3DSharpGenerator.Model
{
    public interface IEngineObject : ILiquidizable
    {
        string Name { get; set; }
        string ManagedType { get; set; }
        string NativeReturnType { get; set; }
        string NativeArgType { get; set; }
    }
}