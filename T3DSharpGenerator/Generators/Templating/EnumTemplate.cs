using System.IO;
using DotLiquid;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating
{
    public static class EnumTemplate
    {
        private static Template Template { get; set; }
        
        public static Template Get(EngineApi engineApi) {
            if (Template == null) {
                InitializeTemplate(engineApi);
            }

            return Template;
        }

        private static Template InitializeTemplate(EngineApi engineApi) {
            BaseTemplate.InitializeTemplatingSystem(engineApi);
            
            using (StreamReader reader = new StreamReader("Resources/Templates/SimEnum.liquid")) {
                Template = DotLiquid.Template.Parse(reader.ReadToEnd());
            }
            
            return Template;
        }
    }
}