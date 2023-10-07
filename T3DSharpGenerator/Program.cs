using System;
using System.IO;
using T3DSharpGenerator.DocGenerators;
using T3DSharpGenerator.DocParsers;
using T3DSharpGenerator.Generators;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator
{
    internal static class Program
    {
       public static void Main(string[] args)
       {
          // Run this in TorqueScript:
          // exportEngineAPIToXML().saveFile("engineApi.xml");
          ParseEngineApi();
       }

       private static void ParseEngineApi() {
            StreamReader sr = new("engineApi.xml");
            string content = sr.ReadToEnd();
            sr.Close();

            EngineApi engineApi = EngineApiParser.Parse(content);

            Console.WriteLine(engineApi.Enums.Count);
            Console.WriteLine(engineApi.Structs.Count);
            Console.WriteLine(engineApi.Functions.Count);
            Console.WriteLine(engineApi.Classes.Count);

            foreach (EngineStruct engineStruct in engineApi.Structs) {
                if (engineStruct.Fields.Count < 1) {
                    Console.WriteLine("No fields defined in struct: " + engineStruct.Name);
                }
            }

            // Careful!!! Don't choose the wrong directory or it might get deleted..
            string outputDirectory = "data/t3dsharp/T3DSharpFramework/Generated";

            if (Directory.Exists(outputDirectory)) {
                Directory.Delete(outputDirectory, true);
            }

            engineApi.Enums
                .ForEach(e => e.Docs = DotNetXmlDocGenerator.Generate(EngineApiDocStringParser.Parse(e.Docs)).Trim());

            engineApi.Structs
                .ForEach(s => s.Docs = DotNetXmlDocGenerator.Generate(EngineApiDocStringParser.Parse(s.Docs)).Trim());

            engineApi.Functions
                .ForEach(f => f.Docs = DotNetXmlDocGenerator.Generate(EngineApiDocStringParser.Parse(f.Docs)).Trim());

            engineApi.Classes
                .ForEach(c => c.Docs = DotNetXmlDocGenerator.Generate(EngineApiDocStringParser.Parse(c.Docs)).Trim());

            engineApi.Classes
                .ForEach(c => c.Methods.ForEach(m => m.Docs = DotNetXmlDocGenerator.Generate(EngineApiDocStringParser.Parse(m.Docs)).Trim()));

            engineApi.Classes
                .ForEach(c => c.Properties.ForEach(p => p.Docs = DotNetXmlDocGenerator.Generate(EngineApiDocStringParser.Parse(p.Docs)).Trim()));

            EnumGenerator.GenerateFor(outputDirectory, engineApi, engineApi.Enums);
            StructGenerator.GenerateFor(outputDirectory, engineApi, engineApi.Structs);
            FunctionGenerator.GenerateFor(outputDirectory, engineApi, engineApi.Functions);
            ClassGenerator.GenerateFor(outputDirectory, engineApi, engineApi.Classes);
            PrimitiveSizesGenerator.GenerateFor(outputDirectory, engineApi, engineApi.Primitives);
            Console.WriteLine("Finished code generation.");
        }
    }
}
