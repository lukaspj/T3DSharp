using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Scriban.Runtime;
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
            scope = string.IsNullOrEmpty(scope) ? "Global" : scope;
            
            string output = EnumTemplate.Render(enums, scope);
            
            Console.WriteLine(scope + "_enums.cs");

            Directory.CreateDirectory("Generated/Enums");

            using (StreamWriter SW =
                new StreamWriter($"Generated/Enums/{scope}.cs")) {
                SW.Write(output);
            }
        }
    }
}