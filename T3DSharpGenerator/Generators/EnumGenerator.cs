using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using DotLiquid;
using DotLiquid.FileSystems;
using T3DSharpGenerator.Generators.Templating;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators
{
    public static class EnumGenerator
    {
        public static void GenerateFor(List<EngineEnum> enums) {
            enums.GroupBy(x => x.Scope)
                .Select(x => new {Scope = x.Key, Enums = x.Select(ToEnumModel)})
                .ToList()
                .ForEach(x => GenerateEnumsInScope(x.Enums.ToList(), x.Scope));
        }

        private static void GenerateEnumsInScope(List<Hash> enums, string scope) {
            var model = Hash.FromAnonymousObject(new {
                Enums = enums,
                Scope = (string.IsNullOrEmpty(scope) ? "Global" : scope)
            });
            string output = EnumTemplate.Get().Render(model);
            Console.WriteLine(model["Scope"] + "_enums.cs");

            Directory.CreateDirectory("Generated/Torque3D/Enums");

            using (StreamWriter SW =
                new StreamWriter($"Generated/Torque3D/Enums/{model["Scope"]}.cs")) {
                SW.Write(output);
            }
        }

        private static Hash ToEnumModel(EngineEnum engineEnum) {
            return Hash.FromAnonymousObject(new {
                Name = engineEnum.Name,
                Docs = engineEnum.Docs,
                Fields = engineEnum.Fields.Select(ToEnumModel)
            });
        }

        private static Hash ToEnumModel(EngineEnum.Field engineEnum) {
            return Hash.FromAnonymousObject(new {
                Name = engineEnum.Name,
                Value = engineEnum.Value,
                Docs = engineEnum.Docs
            });
        }
    }
}