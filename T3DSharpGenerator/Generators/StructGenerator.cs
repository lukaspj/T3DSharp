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
        public static void GenerateFor(List<EngineStruct> structs) {
            structs.GroupBy(x => x.Scope)
                .Select(x => new {Scope = x.Key, Structs = x.Select(ToStructModel)})
                .ToList()
                .ForEach(x => GenerateStructsInScope(x.Structs, x.Scope));
        }

        private static void GenerateStructsInScope(IEnumerable<Hash> structs, string scope) {
            var model = Hash.FromAnonymousObject(new {
                Structs = structs,
                Scope = (string.IsNullOrEmpty(scope) ? "Global" : scope)
            });
            string output = StructTemplate.Get().Render(model);
            
            Console.WriteLine(model["Scope"] + "_structs.cs");

            Directory.CreateDirectory("Generated/Torque3D/Structs");
            
            using (StreamWriter SW = new StreamWriter($"Generated/Torque3D/Structs/{model["Scope"]}.cs")) {
                SW.Write(output);        
            }
        }

        private static Hash ToStructModel(EngineStruct engineStruct) {
            return Hash.FromAnonymousObject(new {
                Name = engineStruct.Name,
                Docs = engineStruct.Docs,
                Fields = engineStruct.Fields.Select(ToStructModel)
            });
        }

        private static Hash ToStructModel(EngineStruct.Field engineStructField) {
            return Hash.FromAnonymousObject(new {
                Name = engineStructField.Name,
                Offset = engineStructField.Offset,
                Type = engineStructField.Type,
                Docs = engineStructField.Docs
            });
        }
    }
}