using System.Reflection;
using System.Runtime.Loader;

namespace T3DSharpFramework.Reloading;

public class ReloadContext : AssemblyLoadContext
{
   private AssemblyDependencyResolver _resolver;
   public ReloadContext(AssemblyDependencyResolver resolver)
      : base("ReloadContext", true)
   {
      _resolver = resolver;
   }

   protected override Assembly Load(AssemblyName assemblyName)
   {
      if (assemblyName.FullName.StartsWith("T3DSharpFramework"))
      {
         return Assembly.GetAssembly(typeof(ReloadContext));
      }

      string assemblyPath = _resolver.ResolveAssemblyToPath(assemblyName);
      if (assemblyPath != null)
      {
         return LoadFromAssemblyPath(assemblyPath);
      }

      return null;
   }
}
