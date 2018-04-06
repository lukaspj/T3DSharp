using System.Collections.Generic;

namespace T3DSharpGenerator.Model
{
    public class EngineApi
    {
        public List<EngineEnum> Enums { get; set; }
        public List<EngineStruct> Structs { get; set; }
        public List<EngineClass> Classes { get; set; }
        public List<EngineFunction> Functions { get; set; }

        public EngineApi SetEnums(List<EngineEnum> enums) {
            Enums = enums;
            return this;
        }

        public EngineApi SetStructs(List<EngineStruct> structs) {
            Structs = structs;
            return this;
        }

        public EngineApi SetClasses(List<EngineClass> classes) {
            Classes = classes;
            return this;
        }


        public EngineApi SetFunctions(List<EngineFunction> functions) {
            Functions = functions;
            return this;
        }

    }
}