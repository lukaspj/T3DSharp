#include "module.h"

#include "api.h"
#include "console/consoleInternal.h"

namespace Csharp
{
   CsharpModule::CsharpModule()
   = default;

   CsharpModule::~CsharpModule()
   = default;

   const char* CsharpModule::getName()
   {
      // Should be able to get that from C# reflection somehow
      return "CSharpScriptingSystem";
   }

   const char* CsharpModule::getPath()
   {
      // Should be able to get that from C# reflection somehow
      return "CSharpScriptingSystem";
   }

   const char* CsharpModule::getFunctionArgs(StringTableEntry functionName, U32 functionOffset)
   {
      // Should be able to get that from C# reflection
      return "(...)";
   }

   Con::EvalResult CsharpModule::exec(U32 offset, const char* fnName, Namespace* ns, U32 argc, ConsoleValue* argv, bool noCalls, StringTableEntry packageName, S32 setFrame)
   {
      Con::printf("[C#] exec");
      Con::printf("[C#] exec %s(%s,...[%d total])", fnName, argv[0].getString(), argc);
      ConsoleValueToStringArrayWrapper args(argc - 1, argv + 1);
      bool result = false;
      const char* execResult = Csharp::gExecCallback(ns->getName(), fnName, args.count(), args, &result);

      ConsoleValue val;
      val.setString(execResult);
      if (result)
      {
         return { std::move(val) };
      }
      return { "unable to find the specified function" };
   }
}
