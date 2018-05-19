using System.Collections.Generic;
using System.IO;
using DotLiquid;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class GetReturnStatementBlock : DotLiquid.Block
    {
        private string _type;

        public override void Initialize(string tagName, string markup, List<string> tokens) {
            base.Initialize(tagName, markup, tokens);
            _type = markup;
        }

        public override void Render(Context context, TextWriter result) {
            object struc = context[_type.Trim(), true];
            string name = struc?.GetType()?.GetProperty("Name")?.GetValue(struc, null) as string;
            IEngineObject type = BaseTemplate.CurrentEngineApi.ToType(name);

            if (type.ManagedType != "void") {
                result.Write("return ");
            }

            if (type is EngineEnum @enum) {
                result.Write($"({@enum.ManagedType})");
                base.Render(context, result);
                return;
            }

            if (type.NativeReturnType == "IntPtr" && type.ManagedType == "string") {
                result.Write($"Marshal.PtrToStringUni(");
                base.Render(context, result);
                result.Write(")");
                return;
            }

            if (type.NativeReturnType == "IntPtr" && type.ManagedType != "IntPtr") {
                if (type.ManagedType == "SimObjectPtr*") {
                    result.Write($"(SimObjectPtr*)");
                    base.Render(context, result);
                    return;
                }

                result.Write($"new {type.ManagedType}(");
                base.Render(context, result);
                result.Write(")");
                return;
            }

            if (type is EngineStruct) {
                result.Write($"new {type.ManagedType}(");
                base.Render(context, result);
                result.Write(")");
                return;
            }

            base.Render(context, result);
        }
    }
}