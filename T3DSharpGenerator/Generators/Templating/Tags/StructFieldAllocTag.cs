using System;
using System.Collections.Generic;
using System.IO;
using DotLiquid;
using T3DSharpFramework.Interop;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class StructFieldAllocTag : DotLiquid.Tag
    {
        private string _obj;

        public override void Initialize(string tagName, string markup, List<string> tokens) {
            base.Initialize(tagName, markup, tokens);
            _obj = markup;
        }

        public override void Render(Context context, TextWriter result) {
            object _arg = context[_obj.Trim(), true];
            EngineStruct.Field field = new EngineStruct.Field {
                Name = _arg?.GetType()?.GetProperty("Name")?.GetValue(_arg, null) as string,
                Type = _arg?.GetType()?.GetProperty("Type")?.GetValue(_arg, null) as IEngineObject,
                TypeName = _arg?.GetType()?.GetProperty("TypeName")?.GetValue(_arg, null) as string
            };

            string name_cC = SanitizeNameTag.SanitizeName(field.Name, false);
            string name_CC = SanitizeNameTag.SanitizeName(field.Name, true);
            
            if (field.Type is EngineStruct @struct) {
                result.Write($"{name_CC}.Alloc();");
                result.Write($"internalStruct.{name_cC} = {name_CC}.internalStruct;");
                return;
            }

            if (field.Type is EngineClass @class) {
                result.Write($"internalStruct.{name_cC} = {name_CC}.ObjectPtr;");
                return;
            }

            if (field.Type is EnginePrimitive @primitive) {
                if (@primitive.NativeReturnType.Equals("IntPtr")) {
                    result.Write($"internalStruct.{name_cC} = GenericMarshal.ToPtr({name_CC});");
                } else {
                    result.Write($"internalStruct.{name_cC} = {name_CC};");                    
                }
                
                return;
            }
            
            throw new NotImplementedException();
        }
    }
}