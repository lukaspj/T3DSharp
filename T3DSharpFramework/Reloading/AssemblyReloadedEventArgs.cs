using System;
using System.Reflection;

namespace T3DSharpFramework.Reloading;

public class AssemblyReloadedEventArgs : EventArgs {
   public AssemblyReloadedEventArgs(Assembly newAssembly) {
      NewAssembly = newAssembly;
   }

   public Assembly NewAssembly { get; }
}
