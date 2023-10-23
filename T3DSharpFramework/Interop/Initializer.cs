using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace T3DSharpFramework.Interop
{
    public class Initializer
    {
        private static MethodInfo mScriptEntryPointMethodInfo = null;

        public static MethodInfo GetScriptEntry() {
            return mScriptEntryPointMethodInfo;
        }

        public static void InitializeTypeDictionaries(string path) {
            Assembly assembly = Assembly.LoadFrom(path);
            InitializeTypeDictionaries(assembly.GetTypes());
        }

        public static void InitializeTypeDictionaries(IEnumerable<Type> types) {
            foreach (Type type in types) {
                List<string> attributes =
                   type.GetCustomAttributes(false).ToList()
                      .Where(x => x.GetType().FullName == typeof(ConsoleClassAttribute).FullName)
                      .Select(x => x.GetType().GetProperty("ConsoleName")!.GetMethod!.Invoke(x, null) as string)
                      .ToList();
                if (attributes.Any()) {
                    EngineCallbacks.RegisterType(attributes.First() ?? type.Name, type);
                }

                foreach (MethodInfo methodInfo in type.GetMethods()) {
                   // Attribute type inside Script different from in host
                    List<string> functionAttributes =
                        methodInfo.GetCustomAttributes(false).ToList()
                           .Where(x => x.GetType().FullName == typeof(ConsoleFunctionAttribute).FullName)
                           .Select(x => x.GetType().GetProperty("FunctionName")!.GetMethod!.Invoke(x, null) as string)
                           .ToList();
                    if (functionAttributes.Any())
                        EngineCallbacks.RegisterFunction(functionAttributes.First() ?? methodInfo.Name,
                            methodInfo);

                    // Special Engine Hooks
                    if (methodInfo.IsStatic && !methodInfo.GetParameters().Any() &&
                        methodInfo.ReturnType == typeof(void)) {

                       List<object> entryAttribute =
                          methodInfo.GetCustomAttributes(false).ToList()
                             .Where(x => x.GetType().FullName == typeof(ScriptEntryPoint).FullName)
                             .ToList();

                       if (entryAttribute.Any()) {
                           mScriptEntryPointMethodInfo = methodInfo;
                       }
                    }
                    else {
                        Console.WriteLine("ScriptEntry method: " + methodInfo.Name +
                                          " did not match the necessary signature.");
                    }
                }
            }
        }
    }
}
