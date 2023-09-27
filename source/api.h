#ifndef _CSHARP_API_H
#define _CSHARP_API_H

namespace Csharp
{
   typedef const char*(*ExecCallback)(const char* pNamespace, const char* pFunctionName, int pArgC, const char** pArgV, bool* result);
   inline ExecCallback gExecCallback;
}

#endif // _CSHARP_API_H
