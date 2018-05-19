using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace T3DSharpGenerator.Model
{
    public static class EngineApiPrimitives
    {
        public static List<EnginePrimitive> GetEngineApiPrimitives() {
            return new List<EnginePrimitive>() {
                new EnginePrimitive() {
                    Name = "int",
                    ManagedType = "int",
                    NativeArgType = "int",
                    NativeReturnType = "int"
                },
                new EnginePrimitive() {
                    Name = "uint",
                    ManagedType = "uint",
                    NativeArgType = "uint",
                    NativeReturnType = "uint"
                },
                new EnginePrimitive() {
                    Name = "short",
                    ManagedType = "short",
                    NativeArgType = "short",
                    NativeReturnType = "short"
                },
                new EnginePrimitive() {
                    Name = "ushort",
                    ManagedType = "ushort",
                    NativeArgType = "ushort",
                    NativeReturnType = "ushort"
                },
                new EnginePrimitive() {
                    Name = "bool",
                    ManagedType = "bool",
                    NativeArgType = "bool",
                    NativeReturnType = "bool"
                },
                new EnginePrimitive() {
                    Name = "float",
                    ManagedType = "float",
                    NativeArgType = "float",
                    NativeReturnType = "float"
                },
                new EnginePrimitive() {
                    Name = "ubyte",
                    ManagedType = "byte",
                    NativeArgType = "byte",
                    NativeReturnType = "byte"
                },
                new EnginePrimitive() {
                    Name = "byte",
                    ManagedType = "sbyte",
                    NativeArgType = "sbyte",
                    NativeReturnType = "sbyte"
                },
                new EnginePrimitive() {
                    Name = "char",
                    ManagedType = "sbyte",
                    NativeArgType = "sbyte",
                    NativeReturnType = "sbyte"
                },
                new EnginePrimitive() {
                    Name = "string",
                    ManagedType = "string",
                    NativeReturnType = "IntPtr",
                    NativeArgType = "string"
                },
                new EnginePrimitive() {
                    Name = "deprecated",
                    ManagedType = "deprecated",
                    NativeReturnType = "deprecated",
                    NativeArgType = "deprecated"
                },
                new EnginePrimitive() {
                    Name = "SimObjectPtr",
                    ManagedType = "IntPtr",
                    NativeReturnType = "IntPtr",
                    NativeArgType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "void",
                    ManagedType = "void",
                    NativeArgType = "void",
                    NativeReturnType = "void"
                },
                new EnginePrimitive() {
                    Name = "ptr",
                    ManagedType = "IntPtr",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "string[]",
                    ManagedType = "string[]",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "bool[]",
                    ManagedType = "bool[]",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "Edge[]",
                    ManagedType = "Edge[]",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "PlaneF[]",
                    ManagedType = "PlaneF[]",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "Point3F[]",
                    ManagedType = "Point3F[]",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "float[]",
                    ManagedType = "float[]",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "int[]",
                    ManagedType = "int[]",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "ubyte[]",
                    ManagedType = "byte[]",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                },
                new EnginePrimitive() {
                    Name = "uint[]",
                    ManagedType = "uint[]",
                    NativeArgType = "IntPtr",
                    NativeReturnType = "IntPtr"
                }
            };
        }

        public static EnginePrimitive Get(string type) {
            return GetEngineApiPrimitives()
                .First(x => x.Name.Equals(type));
        }
    }
}