using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using T3DSharpFramework.Generated.Functions;

namespace T3DSharpFramework.Reloading;

public class AssemblyReloader {
   private readonly string _assemblyPath;
   private readonly string _pdbPath;
   private AssemblyLoadContext _loadContext;
   private Assembly _assembly;
   private FileSystemWatcher _assemblyWatcher;
   private FileSystemWatcher _pdbWatcher;

   public EventHandler<AssemblyReloadedEventArgs> AssemblyReloaded;

   public AssemblyReloader(string assemblyPath, string pdbPath) {
      _assemblyPath = assemblyPath;
      _pdbPath = pdbPath;
      _loadContext = new ReloadContext(new AssemblyDependencyResolver(Assembly.GetExecutingAssembly().Location));
   }

   public void Start() {
      _assemblyWatcher = CreateFileWatcher(_assemblyPath);
      _pdbWatcher = CreateFileWatcher(_pdbPath);
      Update();
   }

   public void Update() {
      _loadContext.Unload();
      _loadContext = new ReloadContext(new AssemblyDependencyResolver(Assembly.GetExecutingAssembly().Location));

      using MemoryStream peStream = new(File.ReadAllBytes(_assemblyPath));
      using MemoryStream pdbStream = new(File.ReadAllBytes(_pdbPath));

      _assembly = _loadContext.LoadFromStream(peStream, pdbStream);

      AssemblyReloaded?.Invoke(this, new AssemblyReloadedEventArgs(_assembly));
   }

   public void Stop() {
      _loadContext.Unload();
      _assembly = null;
      _assemblyWatcher.Dispose();
      _pdbWatcher.Dispose();
   }

   private FileSystemWatcher CreateFileWatcher(string path) {
      var watcher = new FileSystemWatcher(Path.GetDirectoryName(Path.GetFullPath(path)) ?? AppContext.BaseDirectory);
      watcher.NotifyFilter = NotifyFilters.CreationTime
                             | NotifyFilters.LastWrite;
      watcher.Changed += (sender, args) => Update();
      watcher.Error += (sender, args) => Global.Error($"failed to watch {path}, due to: {args.GetException().Message}");
      watcher.EnableRaisingEvents = true;
      watcher.Filter = Path.GetFileName(path);
      return watcher;
   }
}
