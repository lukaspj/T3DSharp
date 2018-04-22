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
    public static class ClassGenerator
    {
        public static void GenerateFor(EngineApi engineApi, List<EngineClass> classes) {
            classes.ForEach(x => GenerateFor(engineApi, x));
        }

        private static void GenerateFor(EngineApi engineApi, EngineClass @class) {
            string scope = (string.IsNullOrEmpty(@class.Scope) ? "Global" : @class.Scope);
            
            string output = ClassTemplate.Get(engineApi).Render(Hash.FromAnonymousObject(new {Class = @class}));
            Console.WriteLine($"Generated/Torque3D/Classes/{scope.Replace('.', '/')}/{@class.Name}.cs");

            Directory.CreateDirectory($"Generated/Torque3D/Classes/{scope.Replace('.', '/')}");
            
            using (StreamWriter SW = new StreamWriter($"Generated/Torque3D/Classes/{scope.Replace('.', '/')}/{@class.Name}.cs")) {
                SW.Write(output);        
            }
        }
    }
}