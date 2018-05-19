using System;
using System.Collections.Generic;
using System.IO;
using DotLiquid;
using T3DSharpFramework.Interop;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class FreeTag : DotLiquid.Tag
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
            
            if (arg.Type is EngineStruct @struct) {
                result.Write($"{SanitizeNameTag.SanitizeName(arg.Name, false)}.Free();");
                return;
            }
        }
    }
}