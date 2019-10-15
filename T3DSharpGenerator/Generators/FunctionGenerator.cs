using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Scriban.Runtime;
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
            scope = (string.IsNullOrEmpty(scope) ? "Global" : scope);
            int lastSeparatorIndex = scope.LastIndexOf('.');
            string scopeClass = scope;
            if (lastSeparatorIndex > 0) {
                scopeClass = scope.Substring(lastSeparatorIndex + 1);
                scope = scope.Substring(0, lastSeparatorIndex);
            }
            
            string output = FunctionTemplate.Render(functions.ToList(), scope, scopeClass);
            
            Console.WriteLine($"Functions/{scope}.cs");

            const string dir = "Generated/Functions/";
            
            Directory.CreateDirectory(dir);
            
            using (StreamWriter SW = new StreamWriter($"{dir}/{scopeClass}.cs")) {
                SW.Write(output);        
            }
        }
    }
}