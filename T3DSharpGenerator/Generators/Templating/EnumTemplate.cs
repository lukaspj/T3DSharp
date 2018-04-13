using System.IO;
using DotLiquid;

namespace T3DSharpGenerator.Generators.Templating
{
    public static class EnumTemplate
    {
        private static Template Template { get; set; }
        
        public static Template Get() {
            if (Template == null) {
                InitializeTemplate();
            }

            return Template;
        }

        private static Template InitializeTemplate() {
            BaseTemplate.InitializeTemplatingSystem();
            
            using (StreamReader reader = new StreamReader("Resources/Templates/SimEnum.liquid")) {
                Template = DotLiquid.Template.Parse(reader.ReadToEnd());
            }
            
            return Template;
        }
    }
}