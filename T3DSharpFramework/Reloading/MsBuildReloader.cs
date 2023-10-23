using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.MSBuild;
using Modules.T3DSharpGenerator;
using T3DSharpFramework.Generated.Functions;

namespace T3DSharpFramework.Reloading;

public class MsBuildReloader {
   private readonly string _assemblyPath;
   private readonly string _pdbPath;
   private AssemblyLoadContext _loadContext;
   private Assembly _assembly;

   public EventHandler<AssemblyReloadedEventArgs> AssemblyReloaded;
   private readonly string _solutionPath;
   private readonly string _projectName;
   private MSBuildWorkspace _workspace;
   private Solution _solution;
   private Project _project;
   private int _reloadCount;

   private FileSystemWatcher _fileSystemWatcher;

   public MsBuildReloader(string solutionPath, string projectName) {
      _solutionPath = solutionPath;
      _projectName = projectName;
      _loadContext = new ReloadContext(new AssemblyDependencyResolver(Assembly.GetExecutingAssembly().Location));
   }

   public async Task Start() {
      var dotNetSdkPath = CMakeSettings.DOTNET_SDK_PATH;
      Environment.SetEnvironmentVariable("MSBUILD_EXE_PATH", Path.Combine(dotNetSdkPath, "MSBuild.dll"),
         EnvironmentVariableTarget.Process);
      Environment.SetEnvironmentVariable("MSBuildExtensionsPath", dotNetSdkPath, EnvironmentVariableTarget.Process);
      Environment.SetEnvironmentVariable("MSBuildSDKsPath", Path.Combine(dotNetSdkPath, "Sdks"),
         EnvironmentVariableTarget.Process);
      MSBuildLocator.RegisterMSBuildPath(dotNetSdkPath);

      _workspace = MSBuildWorkspace.Create(new Dictionary<string, string> {
         ["Configuration"] = @"Debug",
      });
      _solution = await _workspace.OpenSolutionAsync(_solutionPath);
      _project = _solution.Projects.Single(p => p.Name.Contains(_projectName));


      await Reload();
   }

   public async Task Reload() {
      var watch = System.Diagnostics.Stopwatch.StartNew();
      _loadContext.Unload();
      _loadContext = new ReloadContext(new AssemblyDependencyResolver(Assembly.GetExecutingAssembly().Location));
      _reloadCount++;
      _solution = await _workspace.OpenSolutionAsync(_solutionPath);
      _project = _workspace.CurrentSolution.Projects.Single(p => p.Name.Contains(_projectName));
      var compilation = await _project
         .WithCompilationOptions(
            _project.CompilationOptions!.WithModuleName($"{_project.CompilationOptions.ModuleName}-{_reloadCount}"))
         .WithAssemblyName($"{_project.AssemblyName}-{_reloadCount}").GetCompilationAsync();
      await using Stream peStream = new MemoryStream();
      await using Stream pdbStream = new MemoryStream();
      Stream metadataStream = new MemoryStream();
      EmitResult emitResult = compilation!.Emit(peStream, pdbStream, metadataPEStream: metadataStream);
      peStream.Seek(0, SeekOrigin.Begin);
      pdbStream.Seek(0, SeekOrigin.Begin);
      _assembly = _loadContext.LoadFromStream(peStream, pdbStream);

      AssemblyReloaded?.Invoke(this, new AssemblyReloadedEventArgs(_assembly));
      watch.Stop();
      var elapsedMs = watch.ElapsedMilliseconds;

      Global.Echo($"Reloading T3DSharpGame took {elapsedMs}ms");
   }

   public void Stop() {
      _loadContext.Unload();
      _assembly = null;
   }
}
