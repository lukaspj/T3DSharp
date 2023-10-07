#include "module.h"


#include "api.h"
#include "console/consoleInternal.h"
#include "core/frameAllocator.h"
#include "core/volume.h"
#include "core/util/path.h"

// Heavily based on https://github.com/dotnet/samples/blob/main/core/hosting/src/NativeHost/nativehost.cpp
namespace Csharp
{
   CsharpModule::CsharpModule()
   {
   };

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

   Con::EvalResult CsharpModule::exec(U32 offset, const char* fnName, Namespace* ns, U32 argc, ConsoleValue* argv,
                                      bool noCalls, StringTableEntry packageName, S32 setFrame)
   {
      ConsoleValueToStringArrayWrapper args(argc - 1, argv + 1);
      bool result = false;
      const char* nsName = ns->getName();
      const char* execResult = Csharp::gExecCallback(nsName, fnName, args.count(), args, &result);

      ConsoleValue val;
      val.setString(execResult);
      if (result)
      {
         return {std::move(val)};
      }
      return {"unable to find the specified function"};
   }
}
