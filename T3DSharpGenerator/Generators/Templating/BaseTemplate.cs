using System;
using System.Collections.Generic;
using System.IO;
using DotLiquid;
using DotLiquid.FileSystems;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating
{
    public static class BaseTemplate
    {
        public static EngineApi CurrentEngineApi = null;
        public static void InitializeTemplatingSystem(EngineApi engineApi) {
            CurrentEngineApi = engineApi;
            Template.FileSystem = new LocalFileSystem(Path.GetFullPath("Resources/Templates"));
            Template.RegisterTag<GetReturnStringBlock>("getReturnString");
            Template.RegisterTag<MarshalTag>("marshal");
        }
    }

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

            object name = obj?.GetType()?.GetProperty("Name")?.GetValue(obj, null);
            
            object typeObj = obj?.GetType()?.GetProperty("Type")?.GetValue(obj, null);
            string typeName = typeObj?.GetType()?.GetProperty("Name")?.GetValue(typeObj, null) as string;
            
            object type = BaseTemplate.CurrentEngineApi.GetObject(typeName);

            if (type is EngineClass @class) {
                result.Write($"{name}.ObjectPtr");
                return;
            }
            
            result.Write($"{name}");
        }
    }

    public class GetReturnStringBlock : DotLiquid.Block
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
                //result.Write($"new {type.ManagedType}(");
                base.Render(context, result);
                //result.Write(")");
                return;
            }
            
            base.Render(context, result);
        }
    }
}