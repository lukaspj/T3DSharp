using System;
using System.Collections.Generic;
using System.IO;
using DotLiquid;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class SanitizeNameTag : DotLiquid.Tag
    {
        private string _var;
        private Dictionary<string, string> _args;
        private static readonly List<string> ReservedKeywords = new List<string> {
            "this",
            "object",
            "checked",
            "event",
            "params",
            "static",
            "string",
            "lock",
            "class"
        };

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
            if (!(context[_var.Trim(), true] is string str)) {
                return;
            }

            bool camelCase = false;
            if (_args.ContainsKey("CamelCase")) {
                camelCase = _args["CamelCase"].Equals("true");
            }

            string name = SanitizeName(str, camelCase);
            result.Write(name);
        }

        public static string SanitizeName(string str, bool camelCase) {
            if (str.Equals("sizeof")) {
                return "sizeOf";
            }

            str = str.Replace('.', '_');
            str = str.Replace(' ', '_');
            str = str.Replace("+", "plus");
            str = str.Replace("-", "minus");

            if (camelCase) {
                str = char.ToUpper(str[0]) + str.Substring(1);
            }

            if (ReservedKeywords.Contains(str)) {
                str = "_" + str;
            }

            return str;
        }
    }
}