using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Host;

namespace T3DSharpFramework.ExperimentalEditAndContinue;

public class WatchHotReloadServiceProxy {
   private readonly Type _hotReloadServiceType;
   private readonly Type _hotReloadServiceUpdateType;
   private readonly object _hotReloadService;

   public WatchHotReloadServiceProxy(HostWorkspaceServices services,
      ImmutableArray<EditAndContinueCapabilities> capabilities) {
      _hotReloadServiceType =
         Type.GetType(
            "Microsoft.CodeAnalysis.ExternalAccess.Watch.Api.WatchHotReloadService, Microsoft.CodeAnalysis.Features");
      _hotReloadServiceUpdateType =
         Type.GetType(
            "Microsoft.CodeAnalysis.ExternalAccess.Watch.Api.WatchHotReloadService+Update, Microsoft.CodeAnalysis.Features");

      var ctor = _hotReloadServiceType.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null,
         new[] { typeof(HostWorkspaceServices), typeof(ImmutableArray<string>) }, null);
      _hotReloadService = ctor!.Invoke(new object[] { services, capabilities.Select(Enum.GetName).ToImmutableArray() });
   }

   public async Task StartSessionAsync(Solution solution, CancellationToken cancellationToken = default) {
      var startSessionAsync = _hotReloadServiceType
         .GetMethods()
         .Single(m => m.Name == "StartSessionAsync");
      await ((Task)startSessionAsync!.Invoke(_hotReloadService, new object[] { solution, cancellationToken }))!;
   }

   public async Task<(ImmutableArray<Update> updates, ImmutableArray<Diagnostic> diagnostics)> EmitSolutionUpdateAsync(
      Solution solution, CancellationToken cancellationToken = default) {
      var emitSolutionUpdateAsync = _hotReloadServiceType
         .GetMethods()
         .Single(m => m.Name == "EmitSolutionUpdateAsync");

      var arrayType = typeof(ImmutableArray<>).MakeGenericType(_hotReloadServiceUpdateType);
      var tupleType = typeof(ValueTuple<,>).MakeGenericType(arrayType, typeof(ImmutableArray<Diagnostic>));

      var asyncResult = emitSolutionUpdateAsync!.Invoke(_hotReloadService,
         new object[] { solution, cancellationToken })!;
      var awaiter = asyncResult.GetType().GetMethod("GetAwaiter")!.Invoke(asyncResult, new object[] { });
      var result = awaiter!.GetType().GetMethod("GetResult")!.Invoke(awaiter, new object[] { });
      var ofTypeGeneric = arrayType.GetMethods()
         .Single(m => m.Name == "OfType");
      var ofType = ofTypeGeneric.MakeGenericMethod(typeof(object));
      var t = result!.GetType();
      IEnumerable<object> updateObjects = (IEnumerable<object>)ofType.Invoke(t.GetField("Item1")!.GetValue(result), new object[] { });
      return (updateObjects!.Select(o => new Update(o)).ToImmutableArray(), (ImmutableArray<Diagnostic>)t.GetField("Item2")!.GetValue(result)!);
   }

   public void EndSession() {
      var endSession = _hotReloadServiceType
         .GetMethods()
         .Single(m => m.Name == "EndSession");
      endSession!.Invoke(_hotReloadService, new object[] {  });
   }
}

public class Update {
   public Update(object roslynInternalUpdateType) {
      var hotReloadServiceUpdateType =
         Type.GetType(
            "Microsoft.CodeAnalysis.ExternalAccess.Watch.Api.WatchHotReloadService+Update, Microsoft.CodeAnalysis.Features");

      ModuleId = (Guid)hotReloadServiceUpdateType!.GetField("ModuleId")!.GetValue(roslynInternalUpdateType)!;
      ILDelta = (ImmutableArray<byte>)hotReloadServiceUpdateType.GetField("ILDelta")!.GetValue(roslynInternalUpdateType)!;
      MetadataDelta = (ImmutableArray<byte>)hotReloadServiceUpdateType.GetField("MetadataDelta")!.GetValue(roslynInternalUpdateType)!;
      PdbDelta = (ImmutableArray<byte>)hotReloadServiceUpdateType.GetField("PdbDelta")!.GetValue(roslynInternalUpdateType)!;
      UpdatedTypes = (ImmutableArray<int>)hotReloadServiceUpdateType.GetField("UpdatedTypes")!.GetValue(roslynInternalUpdateType)!;
   }

   public ImmutableArray<int> UpdatedTypes { get;  }

   public ImmutableArray<byte> PdbDelta { get;  }

   public ImmutableArray<byte> MetadataDelta { get;  }

   public ImmutableArray<byte> ILDelta { get;  }

   public Guid ModuleId { get;  }
}
