using System;
using System.Collections.Generic;
using System.IO;
using DotLiquid;
using DotLiquid.Exceptions;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class VarToStringTag : DotLiquid.Tag
    {
        private string _var;

        private Dictionary<string, string> _args;
        
        public override void Initialize(string tagName, string markup, List<string> tokens) {
            base.Initialize(tagName, markup, tokens);
            var strings = markup.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            
            _args = new Dictionary<string, string>();
            foreach (var s in strings) {
                if (_var == null) {
                    _var = s;
                } else if (s.Contains(":")) {
                    var split = s.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries);
                    if (split.Length != 2) {
                        throw new System.ArgumentException();
                    }
                    
                    _args[split[0]] = split[1];
                }
            }
        }


        public override void Render(Context context, TextWriter result) {
            if (!_args.ContainsKey("type")) {
                throw new System.ArgumentException("type argument is missing.");
            }
            object _type = context[_args["type"], true];
            string name = _type?.GetType()?.GetProperty("Name")?.GetValue(_type, null) as string;
            IEngineObject type = BaseTemplate.CurrentEngineApi.ToType(name);

            if (type.Name.Equals("string")) {
                result.Write(_var);
            }
        }
    }
}