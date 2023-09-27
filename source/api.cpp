#include "api.h"

#include "module.h"

#include "console/consoleInternal.h"
#include "console/engineFunctions.h"


extern "C" {
   TORQUE_API void csharp_add_function(const char* pNamespace, const char* pFnName, U32 pFnOffset, const char* pDocString)
   {
      Con::printf("[C#] Adding %s function to %s namespace", pFnName, pNamespace);
      if (pNamespace != NULL)
      {
         pNamespace = StringTable->insert(pNamespace);
      }
      Namespace::find(pNamespace)->addFunction(
         StringTable->insert(pFnName), Csharp::getGlobalModule(), pFnOffset, pDocString);
   }

   TORQUE_API void csharp_set_callbacks(void* pExecPtr) {
      Csharp::gExecCallback = Csharp::ExecCallback(pExecPtr);
   }
}
