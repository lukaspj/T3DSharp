using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;

namespace T3DSharpFramework.EditAndContinue;

public class EditAndContinueAnalyzerProxy {
   private readonly Type _csharpEditAndContinueAnalyzerType;
   private readonly Type _activeStatementSpanType;
   private readonly Type _activeStatementsMapType;
   private readonly Type _editAndContinueEnumType;
   private readonly Type _editSessionType;
   private readonly Type _asyncLazyType;
   private readonly dynamic _csharpEditAndContinueAnalyzer;

   public EditAndContinueAnalyzerProxy() {
      //Load our CSharpAnalyzer and ActiveStatementSpan types via reflection
      _csharpEditAndContinueAnalyzerType = Type.GetType("Microsoft.CodeAnalysis.CSharp.EditAndContinue.CSharpEditAndContinueAnalyzer, Microsoft.CodeAnalysis.CSharp.Features");
      _activeStatementSpanType = Type.GetType("Microsoft.CodeAnalysis.EditAndContinue.ActiveStatementSpan, Microsoft.CodeAnalysis.Features");
      _activeStatementsMapType = Type.GetType("Microsoft.CodeAnalysis.EditAndContinue.ActiveStatementsMap, Microsoft.CodeAnalysis.Features");
      _editAndContinueEnumType = Type.GetType("Microsoft.CodeAnalysis.EditAndContinue.EditAndContinueCapabilities, Microsoft.CodeAnalysis.Features");
      _editSessionType = Type.GetType("Microsoft.CodeAnalysis.EditAndContinue.EditSession, Microsoft.CodeAnalysis.Features");
      _asyncLazyType = Type.GetType("Roslyn.Utilities.AsyncLazy, Microsoft.CodeAnalysis.Workspaces");

      var ctor = _csharpEditAndContinueAnalyzerType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null,
         new[] { typeof(Action<SyntaxNode>) }, null);
      _csharpEditAndContinueAnalyzer = ctor!.Invoke(new object[] {null});

   }

   public const EditAndContinueCapabilities Net5RuntimeCapabilities =
      EditAndContinueCapabilities.Baseline |
      EditAndContinueCapabilities.AddInstanceFieldToExistingType |
      EditAndContinueCapabilities.AddStaticFieldToExistingType |
      EditAndContinueCapabilities.AddMethodToExistingType |
      EditAndContinueCapabilities.NewTypeDefinition;

   public const EditAndContinueCapabilities Net6RuntimeCapabilities =
      Net5RuntimeCapabilities |
      EditAndContinueCapabilities.ChangeCustomAttributes |
      EditAndContinueCapabilities.UpdateParameters;

   public object AnalyzeDocumentAsync(Project baseProject, Document updatedDocument, object activeStatementMap = null, ImmutableArray<LinePositionSpan>? newActiveStatementsSpan = null, EditAndContinueCapabilities capabilities = Net6RuntimeCapabilities, CancellationToken cancellationToken = default(CancellationToken)) {
      var lazyBaseActiveStatements = AsyncLazyCreate(activeStatementMap ?? ActiveStatementsMapEmpty());
      newActiveStatementsSpan ??= ImmutableArray<LinePositionSpan>.Empty;
      var lazyCapabilities = AsyncLazyCreate(ToInternalCapabilitiesEnum(capabilities));

      //Create an empty ImmutableArray<ActiveStatementSpan> because we're not currently running the code
      var method = (MethodInfo)_csharpEditAndContinueAnalyzerType.GetMethod("AnalyzeDocumentAsync");
      var myParams = new[] { baseProject, lazyBaseActiveStatements, updatedDocument, newActiveStatementsSpan, lazyCapabilities, cancellationToken };
      object task = method.Invoke(_csharpEditAndContinueAnalyzer, myParams);

      var documentAnalysisResults = task.GetType().GetProperty("Result").GetValue(task);

      var bindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
      //Get the semantic edits from DocumentAnalysisResults
      var edits = documentAnalysisResults!.GetType().GetProperty("SemanticEdits", bindingFlags)!.GetValue(documentAnalysisResults);
      
      return edits;
   }

   public void MergePartialEdits(Compilation oldCompilation, Compilation newCompilation, object edits,
      out ImmutableArray<SemanticEdit> mergedEdits, out ImmutableHashSet<ISymbol> addedSymbols,
      CancellationToken cancellationToken = default(CancellationToken))
   {
      var mergePartialEdits = _editSessionType
         .GetMethods(BindingFlags.Static | BindingFlags.NonPublic)
         .Single(m => m.Name == "MergePartialEdits");
      
      var parameters = new[]
      {
         oldCompilation,
         newCompilation,
         edits,
         ImmutableArray<SemanticEdit>.Empty,
         ImmutableHashSet<ISymbol>.Empty,
         cancellationToken
      };
      mergePartialEdits.Invoke(null, parameters);

      mergedEdits = (ImmutableArray<SemanticEdit>)parameters[3];
      addedSymbols = (ImmutableHashSet<ISymbol>)parameters[4];
   }

   private object ToInternalCapabilitiesEnum(EditAndContinueCapabilities capabilities)
   {
      return Enum.ToObject(_editAndContinueEnumType, (int)capabilities);
   }

   private object CreateEmptyImmutableArray(Type t)
   {
      var bindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
      Type[] targetParams = { };
      var immutableArrayCreateT = typeof(ImmutableArray).GetMethod("Create", bindingFlags, binder: null, types: targetParams, modifiers: null);
      var immutableArrayCreateActiveStatementSpan = immutableArrayCreateT!.MakeGenericMethod(t);

      return immutableArrayCreateActiveStatementSpan.Invoke(null, new object[] { });
   }

   private object AsyncLazyCreate(object item)
   {
      var bindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
      var asyncLazyCreate = _asyncLazyType
         .GetMethods()
         .Single(m => m.Name == "Create" && m.GetParameters().Length == 1 && m.GetParameters().Single().ParameterType.Name == m.GetGenericArguments().Single().Name);
      var asyncLazyCreateConcrete = asyncLazyCreate!.MakeGenericMethod(item.GetType());

      return asyncLazyCreateConcrete.Invoke(null, new[] { item });
   }

   private object ActiveStatementsMapEmpty()
   {
      FieldInfo fieldInfo = _activeStatementsMapType.GetField("Empty");
      return fieldInfo!.GetValue(null);
   }
}
