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
    public static class StructGenerator
    {
        public static void GenerateFor(EngineApi engineApi, List<EngineStruct> structs) {
            structs.GroupBy(x => x.Scope)
                .Select(x => new {Scope = x.Key, Structs = x})
                .ToList()
                .ForEach(x => GenerateStructsInScope(engineApi, x.Structs, x.Scope));
        }

        private static void GenerateStructsInScope(EngineApi engineApi, IEnumerable<EngineStruct> structs, string scope) {
            var model = Hash.FromAnonymousObject(new {
                Structs = structs,
                Scope = (string.IsNullOrEmpty(scope) ? "Global" : scope)
            });
            string output = StructTemplate.Get(engineApi).Render(model);
            
            Console.WriteLine(model["Scope"] + "_structs.cs");

            Directory.CreateDirectory("Generated/Torque3D/Structs");
            
            using (StreamWriter SW = new StreamWriter($"Generated/Torque3D/Structs/{model["Scope"]}.cs")) {
                SW.Write(output);        
            }
        }
    }
}