using System.Collections.Generic;
using System.IO;
using DotLiquid;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class DefaultParamValueTag : DotLiquid.Tag
    {
        private string _obj;

        public override void Initialize(string tagName, string markup, List<string> tokens) {
            base.Initialize(tagName, markup, tokens);
            _obj = markup;
        }

        public override void Render(Context context, TextWriter result) {
            object _arg = context[_obj.Trim(), true];
            EngineFunction.Argument arg = new EngineFunction.Argument {
                DefaultValue = _arg?.GetType()?.GetProperty("DefaultValue")?.GetValue(_arg, null) as string,
                Name = _arg?.GetType()?.GetProperty("Name")?.GetValue(_arg, null) as string,
                Type = _arg?.GetType()?.GetProperty("Type")?.GetValue(_arg, null) as IEngineObject,
                TypeName = _arg?.GetType()?.GetProperty("TypeName")?.GetValue(_arg, null) as string
            };
            
            result.Write(DefaultParamValue(arg));
        }

        public static string DefaultParamValue(EngineFunction.Argument arg) {
            if (arg.DefaultValue == null) return "";


            if (arg.Type.ManagedType.Equals("string")) {
                return $" = \"{arg.DefaultValue}\"";
            }

            if (arg.Type is EnginePrimitive @primitive) {
                string result = "";
                result += $" = {arg.DefaultValue}";
                if (@primitive.ManagedType == "float"
                    && !arg.DefaultValue.EndsWith("f")) {
                    result += "f";
                }

                return result;
            }

            if (arg.Type is EngineStruct @struct) {
                return $" = null";
            }

            if (arg.Type is EngineClass @class) {
                if (arg.DefaultValue.Equals("null")) {
                    return $" = null";
                }
            }

            if (arg.Type is EngineEnum @enum) {
                return $" = {@enum.Name}.{SanitizeNameTag.SanitizeName(arg.DefaultValue, true)}";
            }

            return "<<Unhandled defaultValue type.>>";
        }
    }
}