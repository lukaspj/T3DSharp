using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using DotLiquid;
using T3DSharpGenerator.Generators.Templating;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators
{
    public static class FunctionGenerator
    {
        public static void GenerateFor(EngineApi engineApi, List<EngineFunction> functions) {
            functions.GroupBy(x => x.Scope)
                .Select(x => new {Scope = x.Key, Functions = x})
                .ToList()
                .ForEach(x => GenerateFunctionsInScope(engineApi, x.Functions, x.Scope));
        }

        private static void GenerateFunctionsInScope(EngineApi engineApi, IEnumerable<EngineFunction> functions, string scope) {
            var model = Hash.FromAnonymousObject(new {
                Functions = functions,
                Scope = (string.IsNullOrEmpty(scope) ? "Global" : scope)
            });
            string output = FunctionTemplate.Get(engineApi).Render(model);
            
            Console.WriteLine($"{model["Scope"]}_functions.cs");

            Directory.CreateDirectory("Generated/Torque3D/Functions");
            
            using (StreamWriter SW = new StreamWriter($"Generated/Torque3D/Functions/{model["Scope"]}.cs")) {
                SW.Write(output);        
            }
        }
    }
}