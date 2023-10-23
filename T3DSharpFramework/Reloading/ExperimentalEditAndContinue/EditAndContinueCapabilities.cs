using System;

namespace T3DSharpFramework.ExperimentalEditAndContinue;

/// <summary>
/// The capabilities that the runtime has with respect to edit and continue
/// </summary>
[Flags]
public enum EditAndContinueCapabilities {
   None = 0,

   /// <summary>
   /// Edit and continue is generally available with the set of capabilities that Mono 6, .NET Framework and .NET 5 have in common.
   /// </summary>
   Baseline = 1 << 0,

   /// <summary>
   /// Adding a static or instance method to an existing type.
   /// </summary>
   AddMethodToExistingType = 1 << 1,

   /// <summary>
   /// Adding a static field to an existing type.
   /// </summary>
   AddStaticFieldToExistingType = 1 << 2,

   /// <summary>
   /// Adding an instance field to an existing type.
   /// </summary>
   AddInstanceFieldToExistingType = 1 << 3,

   /// <summary>
   /// Creating a new type definition.
   /// </summary>
   NewTypeDefinition = 1 << 4,

   /// <summary>
   /// Adding, updating and deleting of custom attributes (as distinct from pseudo-custom attributes)
   /// </summary>
   ChangeCustomAttributes = 1 << 5,

   /// <summary>
   /// Whether the runtime supports updating the Param table, and hence related edits (eg parameter renames)
   /// </summary>
   UpdateParameters = 1 << 6,
}
