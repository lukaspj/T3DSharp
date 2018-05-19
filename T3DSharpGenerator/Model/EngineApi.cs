﻿using System;
using System.Collections.Generic;
using System.Linq;
using T3DSharpGenerator.Generators.Util;

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
            foreach (EngineStruct.Field field in obj.Fields) {
                if (field.TypeName.StartsWith("ptr_")
                    && field.Name.Equals("array")) {
                    field.Type = ToType(field.TypeName.Substring(4) + "[]");
                } else if (field.IndexedSize > 1) {
                    field.Type = ToType(field.TypeName + "[]");
                } else {
                    field.Type = ToType(field.TypeName);
                }
            }
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
            foreach (EnginePrimitive enginePrimitive in Primitives) {
                if (enginePrimitive.Name.Equals(name)) {
                    return enginePrimitive;
                }
            }

            foreach (EngineEnum engineEnum in Enums) {
                if (engineEnum.Name.Equals(name)) {
                    return engineEnum;
                }
            }

            foreach (EngineStruct engineStruct in Structs) {
                if (engineStruct.Name.Equals(name)) {
                    return engineStruct;
                }
            }

            foreach (EngineClass engineClass in Classes) {
                if (engineClass.Name.Equals(name)) {
                    return engineClass;
                }
            }

            foreach (EngineFunction engineFunction in Functions) {
                if (engineFunction.Name.Equals(name)) {
                    return engineFunction;
                }
            }

            return null;
        }

        public EngineApi AnnotateFunctionOverrides() {
            foreach (EngineClass engineClass in Classes) {
                foreach (EngineFunction method in engineClass.Methods) {
                    method.IsOverride = SuperTreeContainsMethod(engineClass.SuperType, method);
                }
            }

            return this;
        }

        private bool SuperTreeContainsMethod(IEngineObject engineClassSuperType, EngineFunction method) {
            if (engineClassSuperType == null
                || !(engineClassSuperType is EngineClass @class)) {
                return false;
            }

            foreach (EngineFunction other in @class.Methods) {
                if (!other.Name.Equals(method.Name) 
                    || other.Arguments.Count != method.Arguments.Count) {
                    continue;
                }

                bool alike = true;
                for (var index = 0; index < method.Arguments.Count; index++) {
                    EngineFunction.Argument argument = method.Arguments[index];
                    EngineFunction.Argument otherArgument = other.Arguments[index];
                    if (argument.Type == otherArgument.Type) {
                        continue;
                    }

                    alike = false;
                    break;
                }

                if (alike) {
                    return true;
                }
            }

            return SuperTreeContainsMethod(@class.SuperType, method);
        }

        public EngineApi PruneSubClassProperties() {
            foreach (EngineClass engineClass in Classes) {
                var properties = new List<EngineClass.Property>();
                foreach (EngineClass.Property property in engineClass.Properties) {
                    if (!SuperTreeContainsProperty(engineClass.SuperType, property)) {
                        properties.Add(property);
                    }
                }

                engineClass.Properties = properties;
            }

            return this;
        }

        private bool SuperTreeContainsProperty(IEngineObject engineClassSuperType, EngineClass.Property property) {
            if (engineClassSuperType == null
                || !(engineClassSuperType is EngineClass @class)) {
                return false;
            }

            foreach (EngineClass.Property other in @class.Properties) {
                if (other.Equals(property)) {
                    return true;
                }
            }

            return SuperTreeContainsProperty(@class.SuperType, property);
        }

        public EngineFunction ToFunction(string symbol) {
            EngineFunction func = Functions.FirstOrDefault(x => x.Symbol.Equals(symbol));
            if (func != null) {
                return func;
            }

            foreach (EngineClass engineClass in Classes) {
                func = engineClass.Methods.FirstOrDefault(x => x.Symbol.Equals(symbol));
                if (func != null) {
                    return func;
                }
            }

            return null;
        }
    }
}