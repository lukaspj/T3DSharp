using System;
using System.Collections.Generic;
using System.IO;
using DotLiquid;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class MarshalAsTag : DotLiquid.Tag
    {
        private string _var;
        private Dictionary<string, string> _args;

        public override void Initialize(string tagName, string markup, List<string> tokens) {
            base.Initialize(tagName, markup, tokens);
            var strings = markup.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

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
            if (!(context[_var.Trim(), true] is string type)) {
                return;
            }

            bool ret = false;
            if (_args.ContainsKey("return")) {
                ret = _args["return"].Equals("true");
            }

            if (type.Equals("string")) {
                result.Write("[");
                if (ret) {
                    result.Write("return: ");
                }
                result.Write("MarshalAs(UnmanagedType.LPUTF8Str)]");
            } else if (type.Equals("bool")) {
                result.Write("[");
                if (ret) {
                    result.Write("return: ");
                }
                result.Write("MarshalAs(UnmanagedType.I1)]");
            }
        }
    }
}