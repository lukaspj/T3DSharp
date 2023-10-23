#include "api.h"

#include "module.h"

#include "console/consoleInternal.h"
#include "console/engineFunctions.h"

#include "console/engineExports.h"
#include "console/engineTypes.h"


// DotNet includes
#include <nethost.h>
#include <coreclr_delegates.h>
#include <hostfxr.h>

#include "console/engineAPI.h"

#ifdef WIN32
#include <Windows.h>

#define STR(s) L ## s
#define CH(c) L ## c
#define DIR_SEPARATOR L'\\'

#define string_compare wcscmp

#else
#include <dlfcn.h>
#include <limits.h>

#define STR(s) s
#define CH(c) c
#define DIR_SEPARATOR '/'
#define MAX_PATH PATH_MAX

#define string_compare strcmp
#endif

extern "C" {
TORQUE_API void csharp_add_function(const char* pNamespace, const char* pFnName, U32 pFnOffset, const char* pDocString)
{
   if (pNamespace != NULL)
   {
      pNamespace = StringTable->insert(pNamespace);
   }
   Namespace::find(pNamespace)->addFunction(
      StringTable->insert(pFnName), Csharp::getGlobalModule(), pFnOffset, pDocString);
}

TORQUE_API void csharp_set_callbacks(void* pExecPtr)
{
   Csharp::gExecCallback = Csharp::ExecCallback(pExecPtr);
}

TORQUE_API const void* csharp_get_engine_function_pointer(const char* pFnName)
{
   // Fairly inefficient..
   for (const EngineFunctionInfo* functionInfo = EngineFunctionInfo::getFirstFunction(); functionInfo != NULL;
        functionInfo = functionInfo->getNextFunction())
   {
      // We should bind to something more sane than the binding name, but this way is easier to figure out for now.
      if (String(functionInfo->getBindingName()).equal(pFnName, String::NoCase))
      {
         return functionInfo->getAddress();
      }
   }
   return nullptr;
}
}

void InitializeDotnetRuntime()
{
   //
   // STEP 1: Load HostFxr and get exported hosting functions
   //
   AssertFatal(Csharp::loadHostfxr(NULL), "failed to load hostfxr for C# code execution");

   //
   // STEP 2: Initialize and start the .NET Core runtime
   //

   char pathBuffer[2048] = {};
   AssertFatal(Con::expandPath(pathBuffer, 2048, "T3DSharpGame.runtimeconfig.json"),
               "failed to expand path for runtimeconfig");
   const char_t* config_path = STR("T3DSharpGame.runtimeconfig.json");
   String path = pathBuffer;
   const load_assembly_and_get_function_pointer_fn load_assembly_and_get_function_pointer =
      Csharp::getDotNetLoadAssembly(path.utf16());
   AssertFatal(load_assembly_and_get_function_pointer != nullptr, "Failure: get_dotnet_load_assembly()");

   //
   // STEP 3: Load managed assembly and get function pointer to a managed method
   //
   const char_t* dotnetlib_path = STR("T3DSharpFramework.dll");

   // Load stuff from T3DSharpFramework library
   const char_t* dotnetframework_type = STR("T3DSharpFramework.Interop.Torque3D, T3DSharpFramework");
   Csharp::InitT3DSharp initDotnetFunction = nullptr;
   int rc = load_assembly_and_get_function_pointer(
      dotnetlib_path,
      dotnetframework_type,
      STR("InitT3DSharp"),
      UNMANAGEDCALLERSONLY_METHOD /*delegate_type_name*/,
      nullptr,
      (void**)&initDotnetFunction);
   AssertFatal(rc == 0 && initDotnetFunction != nullptr, "Failure: load_assembly_and_get_function_pointer()");
   initDotnetFunction((void*)csharp_add_function, (void*)csharp_get_engine_function_pointer);

   component_entry_point_fn execConsoleFunction = nullptr;
   rc = load_assembly_and_get_function_pointer(
      dotnetlib_path,
      dotnetframework_type,
      STR("ExecConsoleFunction"),
      UNMANAGEDCALLERSONLY_METHOD /*delegate_type_name*/,
      nullptr,
      (void**)&execConsoleFunction);
   AssertFatal(rc == 0 && execConsoleFunction != nullptr, "Failure: load_assembly_and_get_function_pointer()");
   Csharp::gExecCallback = reinterpret_cast<Csharp::ExecCallback>(execConsoleFunction);
}


MODULE_BEGIN(CSharp)

   MODULE_INIT
   {
      InitializeDotnetRuntime();
   }

   MODULE_SHUTDOWN
   {
   }

MODULE_END;

namespace Csharp
{
#ifdef WIN32
   void* load_library(const char_t* path)
   {
      const HMODULE h = LoadLibraryW(path);
      AssertFatal(h != nullptr, String::ToString("failed to load library %s", path));
      return h;
   }

   void* get_export(void* h, const char* name)
   {
      void* f = static_cast<void*>(GetProcAddress(static_cast<HMODULE>(h), name));
      AssertFatal(f != nullptr, String::ToString("failed to get export %s", name));
      return f;
   }
#else
   void *load_library(const char_t *path)
   {
      void *h = dlopen(path, RTLD_LAZY | RTLD_LOCAL);
      AssertFatal(h != nullptr);
      return h;
   }
   void *get_export(void *h, const char *name)
   {
      void *f = dlsym(h, name);
      AssertFatal(f != nullptr);
      return f;
   }
#endif

   bool loadHostfxr(const char_t* assembly_path)
   {
      // <SnippetLoadHostFxr>
      // Using the nethost library, discover the location of hostfxr and get exports
      get_hostfxr_parameters params{sizeof(get_hostfxr_parameters), assembly_path, nullptr};
      // Pre-allocate a large buffer for the path to hostfxr
      char_t buffer[1024];
      size_t buffer_size = sizeof(buffer) / sizeof(char_t);
      int rc = get_hostfxr_path(buffer, &buffer_size, &params);
      if (rc != 0)
         return false;

      // Load hostfxr and get desired exports
      void* lib = load_library(buffer);
      init_for_cmd_line_fptr = (hostfxr_initialize_for_dotnet_command_line_fn)get_export(
         lib, "hostfxr_initialize_for_dotnet_command_line");
      init_for_config_fptr = (hostfxr_initialize_for_runtime_config_fn)get_export(
         lib, "hostfxr_initialize_for_runtime_config");
      get_delegate_fptr = (hostfxr_get_runtime_delegate_fn)get_export(lib, "hostfxr_get_runtime_delegate");
      run_app_fptr = (hostfxr_run_app_fn)get_export(lib, "hostfxr_run_app");
      close_fptr = (hostfxr_close_fn)get_export(lib, "hostfxr_close");

      return (init_for_config_fptr && get_delegate_fptr && close_fptr);
      // </SnippetLoadHostFxr>
   }

   // <SnippetInitialize>
   // Load and initialize .NET Core and get desired function pointer for scenario
   load_assembly_and_get_function_pointer_fn getDotNetLoadAssembly(const char_t* config_path)
   {
      // Load .NET Core
      void* load_assembly_and_get_function_pointer = nullptr;
      hostfxr_handle cxt = nullptr;
      int rc = init_for_config_fptr(config_path, nullptr, &cxt);
      if (rc != 0 || cxt == nullptr)
      {
         Con::errorf("Init failed: %d", rc);
         if (cxt != nullptr)
         {
            close_fptr(cxt);
         }
         return nullptr;
      }

      // Get the load assembly function pointer
      rc = get_delegate_fptr(
         cxt,
         hdt_load_assembly_and_get_function_pointer,
         &load_assembly_and_get_function_pointer);
      if (rc != 0 || load_assembly_and_get_function_pointer == nullptr)
         Con::errorf("Get delegate failed: %d", rc);

      close_fptr(cxt);
      return (load_assembly_and_get_function_pointer_fn)load_assembly_and_get_function_pointer;
   }

   // </SnippetInitialize>
}
