using System.IO;
using DotLiquid;
using DotLiquid.FileSystems;

namespace T3DSharpGenerator.Generators.Templating
{
    public static class BaseTemplate
    {
        public static void InitializeTemplatingSystem() {
            Template.FileSystem = new LocalFileSystem(Path.GetFullPath("Resources/Templates"));
            
        }
    }
}