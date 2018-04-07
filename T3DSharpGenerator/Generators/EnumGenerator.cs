using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators
{
    public static class EnumGenerator
    {
        private static Func<IDictionary<string, object>, string> Template { get; set; }

        public static void GenerateFor(List<EngineEnum> enums) {
            enums.GroupBy(x => x.Scope)
                .Select(x => new {Scope = x.Key, Enums = x.Select(y => ToEnumModel(y))})
                .ToList()
                .ForEach(x => GenerateEnumsInScope(x.Enums.ToList(), x.Scope));
        }

        private static Func<IDictionary<string, object>, string> GetTemplate() {
            if (Template != null) return Template;
            
            using (StreamReader reader = new StreamReader("Resources/Templates/SimEnum.mustache")) {
                Template = Mustachio.Parser.Parse(reader.ReadToEnd());
            }

            return Template;
        }

        private static void GenerateEnumsInScope(List<object> enums, string scope) {
            dynamic model = new ExpandoObject();
            model.Enums = enums;
            model.Scope = scope;
            string output = GetTemplate()(model);
            Console.WriteLine(scope + "_enums.cs");

            Directory.CreateDirectory("Generated/Torque3D/Enums");
            
            using (StreamWriter SW = new StreamWriter("Generated/Torque3D/Enums/" + (string.IsNullOrEmpty(scope) ? "Global" : scope) + ".cs")) {
                SW.Write(output);        
            }
        }

        private static object ToEnumModel(EngineEnum engineEnum) {
            dynamic enumModel = new ExpandoObject();
            enumModel.Name = engineEnum.Name;
            var enumerable = engineEnum.Fields.Select(ToEnumModel).ToList();
            enumerable[enumerable.Count - 1].Last = true;
            enumModel.Fields = enumerable;
            return enumModel;
        }

        private static dynamic ToEnumModel(EngineEnum.Field engineEnum) {
            dynamic fieldModel = new ExpandoObject();
            fieldModel.Name = engineEnum.Name;
            fieldModel.Value = engineEnum.Value;
            fieldModel.Docs = engineEnum.Docs;
            return fieldModel;
        }
    }
}