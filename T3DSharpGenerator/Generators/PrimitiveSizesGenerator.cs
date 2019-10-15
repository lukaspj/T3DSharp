using System;
using System.Collections.Generic;
using System.IO;
using T3DSharpGenerator.Generators.Templating;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators
{
    public static class PrimitiveSizesGenerator
    {
        public static void GenerateFor(EngineApi engineApi, List<EnginePrimitive> primitives) {
            string output = PrimitiveSizesTemplate.Render(primitives);
            
            Console.WriteLine("PrimitiveSizes.cs");

            Directory.CreateDirectory("Generated");
            
            using (StreamWriter SW = new StreamWriter($"Generated/PrimitiveSizes.cs")) {
                SW.Write(output);        
            }
        }
    }
}