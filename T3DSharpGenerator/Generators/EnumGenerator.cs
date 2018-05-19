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
        public static void GenerateFor(EngineApi engineApi, List<EngineEnum> enums) {
            enums.GroupBy(x => x.Scope)
                .Select(x => new {Scope = x.Key, Enums = x})
                .ToList()
                .ForEach(x => GenerateEnumsInScope(engineApi, x.Enums.ToList(), x.Scope));
        }

        private static void GenerateEnumsInScope(EngineApi engineApi, List<EngineEnum> enums, string scope) {
            var model = Hash.FromAnonymousObject(new {
                Enums = enums,
                Scope = (string.IsNullOrEmpty(scope) ? "Global" : scope)
            });
            string output = EnumTemplate.Get(engineApi).Render(model);
            Console.WriteLine(model["Scope"] + "_enums.cs");

            Directory.CreateDirectory("Generated/Enums");

            using (StreamWriter SW =
                new StreamWriter($"Generated/Enums/{model["Scope"]}.cs")) {
                SW.Write(output);
            }
        }
    }
}