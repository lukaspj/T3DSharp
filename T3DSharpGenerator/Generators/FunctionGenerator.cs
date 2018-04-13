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
        public static void GenerateFor(List<EngineFunction> functions) {
            functions.GroupBy(x => x.Scope)
                .Select(x => new {Scope = x.Key, Functions = x.Select(ToFunctionModel)})
                .ToList()
                .ForEach(x => GenerateFunctionsInScope(x.Functions, x.Scope));
        }

        private static void GenerateFunctionsInScope(IEnumerable<Hash> functions, string scope) {
            var model = Hash.FromAnonymousObject(new {
                Functions = functions,
                Scope = (string.IsNullOrEmpty(scope) ? "Global" : scope)
            });
            string output = FunctionTemplate.Get().Render(model);
            
            Console.WriteLine($"{model["Scope"]}_functions.cs");

            Directory.CreateDirectory("Generated/Torque3D/Functions");
            
            using (StreamWriter SW = new StreamWriter($"Generated/Torque3D/Functions/{model["Scope"]}.cs")) {
                SW.Write(output);        
            }
        }

        private static Hash ToFunctionModel(EngineFunction engineFunction) {
            return Hash.FromAnonymousObject(new {
                Name = engineFunction.Name,
                Docs = engineFunction.Docs,
                IsCallback = engineFunction.IsCallback,
                IsVariadic = engineFunction.IsVariadic,
                ReturnType = engineFunction.ReturnType,
                Symbol = engineFunction.Symbol,
                Args = engineFunction.Arguments.Select(ToFunctionModel)
            });
        }

        private static Hash ToFunctionModel(EngineFunction.Argument engineFunctionArgument) {
            return Hash.FromAnonymousObject(new {
                Name = engineFunctionArgument.Name,
                Type = engineFunctionArgument.Type,
                DefaultValue = engineFunctionArgument.DefaultValue
            });
        }
    }
}