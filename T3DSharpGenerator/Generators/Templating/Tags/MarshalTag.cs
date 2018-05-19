using System.Collections.Generic;
using System.IO;
using DotLiquid;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class MarshalTag : DotLiquid.Tag
    {
        private string _obj;

        public override void Initialize(string tagName, string markup, List<string> tokens) {
            base.Initialize(tagName, markup, tokens);
            _obj = markup;
        }

        public override void Render(Context context, TextWriter result) {
            if (!(context[_obj.Trim(), true] is object obj)) {
                return;
            }

            string name = obj?.GetType()?.GetProperty("Name")?.GetValue(obj, null) as string;

            name = SanitizeNameTag.SanitizeName(name, false);

            object typeObj = obj?.GetType()?.GetProperty("Type")?.GetValue(obj, null);
            string typeName = typeObj?.GetType()?.GetProperty("Name")?.GetValue(typeObj, null) as string;

            object type = BaseTemplate.CurrentEngineApi.GetObject(typeName);

            if (type is EngineClass @class) {
                result.Write($"{name}.ObjectPtr");
                return;
            }

            if (type is EngineEnum @enum) {
                result.Write($"(int){name}");
                return;
            }
            
            object _arg = context[_obj.Trim(), true];
            EngineFunction.Argument arg = new EngineFunction.Argument {
                DefaultValue = _arg?.GetType()?.GetProperty("DefaultValue")?.GetValue(_arg, null) as string,
                Name = _arg?.GetType()?.GetProperty("Name")?.GetValue(_arg, null) as string,
                Type = _arg?.GetType()?.GetProperty("Type")?.GetValue(_arg, null) as IEngineObject,
                TypeName = _arg?.GetType()?.GetProperty("TypeName")?.GetValue(_arg, null) as string
            };

            if (type is EngineStruct @struct) {
                //result.Write($"GenericMarshal.ToPtr({arg.Name}");
                result.Write($"ref ({arg.Name}");
                if (arg.DefaultValue != null) {
                    result.Write($" ?? new {@struct.Name}(\"{arg.DefaultValue}\")");
                }
                result.Write(").internalStruct");
                return;
            }

            result.Write($"{name}");
        }
    }
}