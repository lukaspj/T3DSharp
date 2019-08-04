using System;
using System.Collections.Generic;
using System.IO;
using DotLiquid;
using T3DSharpFramework.Interop;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating.Tags
{
    public class StructFieldFreeTag : DotLiquid.Tag
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
                TypeName = _arg?.GetType()?.GetProperty("TypeName")?.GetValue(_arg, null) as string,
                IndexedSize = (int)_arg?.GetType()?.GetProperty("IndexedSize")?.GetValue(_arg, null),
            };

            string name_CC = SanitizeNameTag.SanitizeName(field.Name, true);
            string name_cC = SanitizeNameTag.SanitizeName(field.Name, false);
            
            if (field.Type is EngineStruct @struct) {
                result.Write($"{name_CC}.internalStruct = internalStruct.{name_cC};");
                result.Write($" {name_CC}.Free();");
                return;
            }

            if (field.Type is EngineClass @class) {
                result.Write($"{name_CC}.ObjectPtr = internalStruct.{name_cC};");
                return;
            }

            string baseType = field.Type.ManagedType;
            if (baseType.StartsWith("ptr_")) {
                baseType = baseType.Substring(4);
            }

            if (field.Type is EnginePrimitive @primitive) {
                if (@primitive.NativeReturnType.Equals("IntPtr")) {
                    baseType = baseType.Substring(0, baseType.Length - 2);
                    if (field.IndexedSize > 1) {
                        result.Write($"{name_CC} = GenericMarshal.FromPtr<{baseType}>(internalStruct.{name_cC}, {field.IndexedSize}, true);");
                    } else {
                        result.Write($"{name_CC} = GenericMarshal.FromPtr<{baseType}>(internalStruct.{name_cC}, ElementCount, true);");
                    }
                } else {
                    result.Write($"{name_CC} = internalStruct.{name_cC};");
                }
                
                return;
            }
            
            throw new NotImplementedException();
        }
    }
}