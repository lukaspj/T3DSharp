#ifndef _CSHARP_API_H
#define _CSHARP_API_H
#include <coreclr_delegates.h>
#include <hostfxr.h>

namespace Csharp
{
   // Globals to hold hostfxr exports
   inline hostfxr_initialize_for_dotnet_command_line_fn init_for_cmd_line_fptr;
   inline hostfxr_initialize_for_runtime_config_fn init_for_config_fptr;
   inline hostfxr_get_runtime_delegate_fn get_delegate_fptr;
   inline hostfxr_run_app_fn run_app_fptr;
   inline hostfxr_close_fn close_fptr;

   bool loadHostfxr(const char_t* assembly_path);
   static load_assembly_and_get_function_pointer_fn getDotNetLoadAssembly(const char_t* config_path);


   typedef const char*(*ExecCallback)(const char* pNamespace, const char* pFunctionName, int pArgC, const char** pArgV, bool* result);
   inline ExecCallback gExecCallback;

   typedef void(*InitT3DSharp)(void* addFunctionDelegate, void* lookupFunctionDelegate);
}

#endif // _CSHARP_API_H
