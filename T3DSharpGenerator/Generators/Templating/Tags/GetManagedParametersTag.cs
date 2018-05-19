using System.Collections.Generic;
using System.IO;
using DotLiquid;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class GetManagedParametersTag : DotLiquid.Tag
    {
        private string _type;

        public override void Initialize(string tagName, string markup, List<string> tokens) {
            base.Initialize(tagName, markup, tokens);
            _type = markup;
        }

        //{% for arg in function.Args offset:1 %}{{arg.Type.ManagedType}} {% sanitizeName arg.Name %}{% defaultParamValue arg %}{% if forloop.rindex0 != 0 %}, {% endif %}{% endfor %}
        //{% for arg in function.Args %}{{arg.Type.ManagedType}} {% sanitizeName arg.Name %}{% defaultParamValue arg %}{% if forloop.rindex0 != 0 %}, {% endif %}{% endfor %}
        public override void Render(Context context, TextWriter result) {
            object struc = context[_type.Trim(), true];
            string symbol = struc?.GetType()?.GetProperty("Symbol")?.GetValue(struc, null) as string;
            EngineFunction function = BaseTemplate.CurrentEngineApi.ToFunction(symbol);

            int firstArgIndex = function.IsStatic ? 0 : 1;
            
            for (var index = firstArgIndex; index < function.Arguments.Count; index++) {
                EngineFunction.Argument functionArgument = function.Arguments[index];
                result.Write(functionArgument.Type.ManagedType);
                if (functionArgument.Type is EngineStruct @struct
                    && functionArgument.DefaultValue != null) {
                    //result.Write("?");
                }

                result.Write($" {SanitizeNameTag.SanitizeName(functionArgument.Name, false)}");
                if (functionArgument.DefaultValue != null) {
                    result.Write(DefaultParamValueTag.DefaultParamValue(functionArgument));
                }

                if (index != function.Arguments.Count - 1) {
                    result.Write(", ");
                }
            }
        }
    }
}