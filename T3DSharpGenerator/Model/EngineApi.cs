using System;
using System.Collections.Generic;

namespace T3DSharpGenerator.Model
{
    public class EngineApi
    {
        public List<EngineEnum> Enums { get; set; }
        public List<EngineStruct> Structs { get; set; }
        public List<EngineClass> Classes { get; set; }
        public List<EngineFunction> Functions { get; set; }
        public List<EnginePrimitive> Primitives { get; set; }

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

        public EngineApi SetPrimitives(List<EnginePrimitive> primitives) {
            Primitives = primitives;
            return this;
        }


        public EngineApi AnnotateTypes() {
            
            Structs.ForEach(AnnotateStructTypes);
            Classes.ForEach(AnnotateClassTypes);
            Functions.ForEach(AnnotateFunctionTypes);

            return this;
        }

        private void AnnotateFunctionTypes(EngineFunction obj) {
            obj.ReturnType = ToType(obj.ReturnTypeName);
            obj.Arguments.ForEach(x => x.Type = ToType(x.TypeName));
        }

        private void AnnotateClassTypes(EngineClass obj) {
            obj.SuperType = ToType(obj.SuperTypeName);
            obj.Properties.ForEach(x => x.Type = ToType(x.TypeName));
            obj.Methods.ForEach(AnnotateFunctionTypes);
        }

        private void AnnotateStructTypes(EngineStruct obj) {
            obj.Fields.ForEach(x => x.Type = ToType(x.TypeName));
        }

        public IEngineObject ToType(string typeName) {

            if (typeName == null) {
                return null;
            }

            if (typeName.StartsWith("Math::")) {
                typeName = typeName.Substring(6);
            }

            if (typeName.StartsWith("Net::")) {
                typeName = typeName.Substring(5);
            }

            if (typeName.StartsWith("Gui::")) {
                typeName = typeName.Substring(5);
            }

            if (typeName.StartsWith("Reflection::")) {
                typeName = typeName.Substring(12);
            }

            if (typeName.Equals("MatrixPosition")) {
                typeName = "MatrixF";
            }

            if (typeName.Equals("MatrixRotation")) {
                typeName = "MatrixF";
            }

            if (typeName.Equals("pid")) {
                typeName = "SimPersistID";
            }

            if (typeName.Equals("caseString")) {
                typeName = "string";
            }

            if (typeName.Equals("filename")) {
                typeName = "string";
            }

            if (typeName.Equals("floatList")) {
                typeName = "FloatVector";
            }

            if (typeName.Equals("intList")) {
                typeName = "IntVector";
            }

            if (typeName.Equals("ComponentAssetPtr")) {
                typeName = "SimObjectPtr";
            }

            if (typeName.Equals("GameObjectAssetPtr")) {
                typeName = "SimObjectPtr";
            }

            if (typeName.Equals("assetIdString")) {
                typeName = "string";
            }

            if (typeName.Equals("")) {
                Console.WriteLine("Found empty type");
                return null;
            }

            foreach (EnginePrimitive enginePrimitive in Primitives) {
                if (enginePrimitive.Name.Equals(typeName)) {
                    return enginePrimitive;
                }
            }
            
            foreach (EngineEnum engineEnum in Enums) {
                if (engineEnum.Name.Equals(typeName)) {
                    return engineEnum;
                }
            }

            foreach (EngineStruct engineStruct in Structs) {
                if (engineStruct.Name.Equals(typeName)) {
                    return engineStruct;
                }
            }

            foreach (EngineClass engineClass in Classes) {
                if (engineClass.Name.Equals(typeName)) {
                    return engineClass;
                }
            }

            throw new NotImplementedException($"Unhandled type: {typeName}");
        }

        public object GetObject(string name) {
            foreach (EngineClass engineClass in Classes) {
                if (engineClass.Name.Equals(name)) {
                    return engineClass;
                }
            }

            foreach (EngineStruct engineStruct in Structs) {
                if (engineStruct.Name.Equals(name)) {
                    return engineStruct;
                }
            }

            foreach (EngineFunction engineFunction in Functions) {
                if (engineFunction.Name.Equals(name)) {
                    return engineFunction;
                }
            }

            foreach (EngineEnum engineEnum in Enums) {
                if (engineEnum.Name.Equals(name)) {
                    return engineEnum;
                }
            }

            foreach (EnginePrimitive enginePrimitive in Primitives) {
                if (enginePrimitive.Name.Equals(name)) {
                    return enginePrimitive;
                }
            }

            return null;
        }
    }
}