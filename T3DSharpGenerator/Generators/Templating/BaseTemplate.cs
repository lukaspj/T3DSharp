using System;
using System.IO;
using System.Text.RegularExpressions;
using DotLiquid;
using DotLiquid.FileSystems;
using T3DSharpGenerator.Generators.Templating.Tags;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.Generators.Templating
{
    public static class BaseTemplate
    {
        public static EngineApi CurrentEngineApi = null;

        public static void InitializeTemplatingSystem(EngineApi engineApi) {
            CurrentEngineApi = engineApi;
            Template.FileSystem = new LocalFileSystem(Path.GetFullPath("Resources/Templates"));
            Template.RegisterTag<GetReturnStatementBlock>("getReturnString");
            Template.RegisterTag<GetManagedParametersTag>("getManagedParameters");
            Template.RegisterTag<VarToStringTag>("varToString");
            Template.RegisterTag<MarshalTag>("marshal");
            Template.RegisterTag<MarshalAsTag>("marshalAs");
            Template.RegisterTag<SanitizeNameTag>("sanitizeName");
            Template.RegisterTag<DefaultParamValueTag>("defaultParamValue");
            Template.RegisterTag<DefaultBodyValueTag>("defaultBodyValue");
            Template.RegisterTag<StructFieldAllocTag>("structFieldAlloc");
            Template.RegisterTag<StructFieldFreeTag>("structFieldFree");
            Template.RegisterTag<AllocTag>("alloc");
            Template.RegisterTag<FreeTag>("free");
        }
    }
}