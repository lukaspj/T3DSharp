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
    public static class PrimitiveSizesGenerator
    {
        public static void GenerateFor(EngineApi engineApi, List<EnginePrimitive> primitives) {
            var model = Hash.FromAnonymousObject(new {
                Primitives = primitives
            });
            string output = PrimitiveSizesTemplate.Get(engineApi).Render(model);
            
            Console.WriteLine("PrimitiveSizes.cs");

            Directory.CreateDirectory("Generated");
            
            using (StreamWriter SW = new StreamWriter($"Generated/PrimitiveSizes.cs")) {
                SW.Write(output);        
            }
        }
    }
}