using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Text;
using T3DSharpFramework.Reloading;

namespace T3DSharpFramework.ExperimentalEditAndContinue;


public class HotReloader {
   private readonly string _solutionPath;
   private readonly string _projectName;
   private MetadataReader _pdbReader;
   private MSBuildWorkspace _workspace;
   private Solution _solution;
   private Project _project;
   private Compilation _compilation;
   private EmitBaseline _baseline;
   private AssemblyLoadContext _loadContext;
   private int _reloadCount = 0;
   private WatchHotReloadServiceProxy _hotReloadService;
   private Assembly _assembly;
   private Guid _moduleId;

   public HotReloader(string solutionPath, string projectName) {
      _solutionPath = solutionPath;
      _projectName = projectName;
   }


   public static ImmutableArray<EditAndContinueCapabilities> net5RuntimeCapabilities = new[] {
      EditAndContinueCapabilities.Baseline,
      EditAndContinueCapabilities.AddInstanceFieldToExistingType,
      EditAndContinueCapabilities.AddStaticFieldToExistingType,
      EditAndContinueCapabilities.AddMethodToExistingType,
      EditAndContinueCapabilities.NewTypeDefinition
   }.ToImmutableArray();

   public static ImmutableArray<EditAndContinueCapabilities> net6RuntimeCapabilities =
      net5RuntimeCapabilities
         .Append(EditAndContinueCapabilities.ChangeCustomAttributes)
         .Append(EditAndContinueCapabilities.UpdateParameters).ToImmutableArray();

   public Assembly Assembly => _assembly;

   public async Task Initialize()
   {
      var dotNetSdkPath = @"C:\Users\lukas\scoop\apps\dotnet-sdk\current\sdk\6.0.100";
      Environment.SetEnvironmentVariable("MSBUILD_EXE_PATH", Path.Combine(dotNetSdkPath, "MSBuild.dll"), EnvironmentVariableTarget.Process);
      Environment.SetEnvironmentVariable("MSBuildExtensionsPath", dotNetSdkPath, EnvironmentVariableTarget.Process);
      Environment.SetEnvironmentVariable("MSBuildSDKsPath", Path.Combine(dotNetSdkPath, "Sdks"), EnvironmentVariableTarget.Process);
      MSBuildLocator.RegisterMSBuildPath(dotNetSdkPath);

      _workspace = MSBuildWorkspace.Create(new Dictionary<string, string>
      {
         ["Configuration"] = @"Debug",
      });
      _solution = await _workspace.OpenSolutionAsync(_solutionPath);
      _project = _solution.Projects.Single(p => p.Name.Contains("T3DSharpGame"));

      _loadContext = new ReloadContext(new AssemblyDependencyResolver(AppContext.BaseDirectory));

      _compilation = await _project.GetCompilationAsync(); ;
      Stream peStream = new MemoryStream();
      Stream pdbStream = new MemoryStream();
      Stream metadataStream = new MemoryStream();
      EmitResult emitResult = _compilation!.Emit(peStream, pdbStream, metadataPEStream: metadataStream);
      peStream.Seek(0, SeekOrigin.Begin);
      pdbStream.Seek(0, SeekOrigin.Begin);
      _assembly = _loadContext.LoadFromStream(peStream, pdbStream);
      metadataStream.Seek(0, SeekOrigin.Begin);
      var metadata = ModuleMetadata.CreateFromStream(metadataStream);
      var metadataReader = metadata.GetMetadataReader();
      _moduleId = metadataReader.GetGuid(metadataReader.GetModuleDefinition().Mvid);

      if (Debugger.IsAttached == false && MetadataUpdater.IsSupported)
      {
         _hotReloadService = new WatchHotReloadServiceProxy(_workspace.Services, net6RuntimeCapabilities);
         await _hotReloadService.StartSessionAsync(_solution);
      }
   }

   public async Task Update(string updatedFile) {
      var documentId = _solution.GetDocumentIdsWithFilePath(updatedFile).Single();
      if (documentId.ProjectId != _project.Id) return;

      var contents = await File.ReadAllTextAsync(updatedFile);
      var solution = _solution.WithDocumentText(documentId, SourceText.From(contents, Encoding.UTF8));

      _solution = solution;
      _project = _solution.GetProject(_project!.Id);

      if (Debugger.IsAttached == false && MetadataUpdater.IsSupported)
      {
         var updates = await _hotReloadService.EmitSolutionUpdateAsync(solution);
         var update = updates.updates.Single();
         MetadataUpdater.ApplyUpdate(_assembly, update.MetadataDelta.AsSpan(), update.ILDelta.AsSpan(),
            update.PdbDelta.AsSpan());
      }
      else
      {
         _loadContext.Unload();
         _loadContext = new ReloadContext(new AssemblyDependencyResolver(AppContext.BaseDirectory));

         _compilation = await _project.WithCompilationOptions(_project.CompilationOptions.WithModuleName($"{_project.CompilationOptions.ModuleName}-{_reloadCount}")).WithAssemblyName($"{_compilation.AssemblyName}-{_reloadCount}").GetCompilationAsync();
         _compilation = _compilation!;
         Stream peStream = new MemoryStream();
         Stream pdbStream = new MemoryStream();
         Stream metadataStream = new MemoryStream();
         EmitResult emitResult = _compilation!.Emit(peStream, pdbStream, metadataPEStream: metadataStream);
         peStream.Seek(0, SeekOrigin.Begin);
         pdbStream.Seek(0, SeekOrigin.Begin);
         _assembly = _loadContext.LoadFromStream(peStream, pdbStream);
      }
   }
}
