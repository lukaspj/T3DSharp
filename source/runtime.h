#ifndef _CSHARP_RUNTIME_H_
#define _CSHARP_RUNTIME_H_
#include "console/runtime.h"

namespace Csharp
{
   class CsharpRuntime : public Con::Runtime
   {
   public:
      CsharpRuntime();
      ~CsharpRuntime() override;

      void expandEscapedCharacters(char* dest, const char* src) override { expandEscape(dest, src); }
      bool collapseEscapedCharacters(char* buf) override { return collapseEscape(buf); }
      Con::EvalResult evaluate(const char* string, bool echo = false, const char* fileName = NULL) override;
      Con::EvalResult evaluate(const char* script, S32 frame, bool echo = false, const char *fileName = NULL) override;
      Con::EvalResult evaluatef(const char* string, ...) override;
      bool executeFile(const char* fileName, bool noCalls, bool journalScript) override;
   };

   inline CsharpRuntime* gRuntime = new CsharpRuntime();
   inline CsharpRuntime* getRuntime() { return gRuntime; }
}

#endif
