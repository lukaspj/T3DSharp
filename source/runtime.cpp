#include "runtime.h"

#include "console/script.h"
#include "console/runtime.h"

namespace Csharp
{
   CsharpRuntime::CsharpRuntime()
   {
      Con::registerRuntime(1, this);
   }

   CsharpRuntime::~CsharpRuntime()
   = default;

   Con::EvalResult CsharpRuntime::evaluate(const char* string, bool echo, const char* fileName)
   {
      return {"Not Implemented"};
   }

   Con::EvalResult CsharpRuntime::evaluate(const char* script, S32 frame, bool echo, const char* fileName)
   {
      return {"Not Implemented"};
   }

   //------------------------------------------------------------------------------
   Con::EvalResult CsharpRuntime::evaluatef(const char* string, ...)
   {
      return {"Not Implemented"};
   }

   bool CsharpRuntime::executeFile(const char* fileName, bool noCalls, bool journalScript)
   {
      return false;
   }
}
