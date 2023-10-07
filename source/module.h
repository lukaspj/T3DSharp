#ifndef _CSHARP_MODULE_H_
#define _CSHARP_MODULE_H_
#include <coreclr_delegates.h>
#include <hostfxr.h>

#include "console/module.h"
#include "console/runtime.h"

namespace Csharp
{
   class CsharpModule : public Con::Module
   {
   public:
      CsharpModule();
      ~CsharpModule() override;
      const char* getFunctionArgs(StringTableEntry functionName, U32 functionOffset) override;
      const char* getPath() override;
      const char* getName() override;
      Con::EvalResult exec(U32 offset, const char* fnName, Namespace* ns, U32 argc, ConsoleValue* argv, bool noCalls,
         StringTableEntry packageName, S32 setFrame) override;
   };

   inline CsharpModule* gModule = new CsharpModule();
   inline CsharpModule* getGlobalModule() { return gModule; }
}

#endif
