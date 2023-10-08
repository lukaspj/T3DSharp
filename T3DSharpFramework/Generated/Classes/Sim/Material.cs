using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim {
    /// <summary>A material in Torque 3D is a data structure that describes a surface.</summary>
    /// <description>
    /// It contains many different types of information for rendering properties. Torque 3D generates shaders from Material definitions. The shaders are compiled at runtime and output into the example/shaders directory. Any errors or warnings generated from compiling the procedurally generated shaders are output to the console as well as the output window in the Visual C IDE.
    /// </description>
    /// <code>
    /// singleton Material(DECAL_scorch)
    /// {
    /// 	baseTex[0] = "./scorch_decal.png";
    /// 	vertColor[ 0 ] = true;
    /// 
    /// 	translucent = true;
    /// 	translucentBlendOp = None;
    /// 	translucentZWrite = true;
    /// 	alphaTest = true;
    /// 	alphaRef = 84;
    /// };
    /// </code>
    /// <see cref="Rendering" />
    /// <see cref="ShaderData" />
    public class Material : SimObject {
        public Material(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public Material(string pName, bool pRegister)
            : base(false) {
            Name = pName;
            // Handle the case where the class name refers to the name of
            // the object, and thus only meant to be used for that specific object,
            // not encompassing an actual type
            var managedClassName = ((object)this).GetType().Name;
            if (managedClassName != Name) {
               ClassName = managedClassName;
            }
            if (pRegister) {
                RegisterObject();
            }
        }

        public Material(string pName)
            : this(pName, false) {
        }

        public Material(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Material(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Material(SimObject pObj)
            : base(pObj) {
        }

        public Material(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetDetailNormalMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetDetailNormalMap(IntPtr _this, SetDetailNormalMap__Args args);
            private static _SetDetailNormalMap _SetDetailNormalMapFunc;
            internal static _SetDetailNormalMap SetDetailNormalMap() {
               _SetDetailNormalMapFunc ??= Torque3D.LookupEngineFunction<_SetDetailNormalMap>("fnMaterial_setDetailNormalMap");

                return _SetDetailNormalMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailNormalMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDetailNormalMapAsset(IntPtr _this, GetDetailNormalMapAsset__Args args);
            private static _GetDetailNormalMapAsset _GetDetailNormalMapAssetFunc;
            internal static _GetDetailNormalMapAsset GetDetailNormalMapAsset() {
               _GetDetailNormalMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetDetailNormalMapAsset>("fnMaterial_getDetailNormalMapAsset");

                return _GetDetailNormalMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailNormalMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDetailNormalMap(IntPtr _this, GetDetailNormalMap__Args args);
            private static _GetDetailNormalMap _GetDetailNormalMapFunc;
            internal static _GetDetailNormalMap GetDetailNormalMap() {
               _GetDetailNormalMapFunc ??= Torque3D.LookupEngineFunction<_GetDetailNormalMap>("fnMaterial_getDetailNormalMap");

                return _GetDetailNormalMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetGlowMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetGlowMap(IntPtr _this, SetGlowMap__Args args);
            private static _SetGlowMap _SetGlowMapFunc;
            internal static _SetGlowMap SetGlowMap() {
               _SetGlowMapFunc ??= Torque3D.LookupEngineFunction<_SetGlowMap>("fnMaterial_setGlowMap");

                return _SetGlowMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGlowMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetGlowMapAsset(IntPtr _this, GetGlowMapAsset__Args args);
            private static _GetGlowMapAsset _GetGlowMapAssetFunc;
            internal static _GetGlowMapAsset GetGlowMapAsset() {
               _GetGlowMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetGlowMapAsset>("fnMaterial_getGlowMapAsset");

                return _GetGlowMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGlowMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetGlowMap(IntPtr _this, GetGlowMap__Args args);
            private static _GetGlowMap _GetGlowMapFunc;
            internal static _GetGlowMap GetGlowMap() {
               _GetGlowMapFunc ??= Torque3D.LookupEngineFunction<_GetGlowMap>("fnMaterial_getGlowMap");

                return _GetGlowMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMetalMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetMetalMap(IntPtr _this, SetMetalMap__Args args);
            private static _SetMetalMap _SetMetalMapFunc;
            internal static _SetMetalMap SetMetalMap() {
               _SetMetalMapFunc ??= Torque3D.LookupEngineFunction<_SetMetalMap>("fnMaterial_setMetalMap");

                return _SetMetalMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMetalMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMetalMapAsset(IntPtr _this, GetMetalMapAsset__Args args);
            private static _GetMetalMapAsset _GetMetalMapAssetFunc;
            internal static _GetMetalMapAsset GetMetalMapAsset() {
               _GetMetalMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetMetalMapAsset>("fnMaterial_getMetalMapAsset");

                return _GetMetalMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMetalMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMetalMap(IntPtr _this, GetMetalMap__Args args);
            private static _GetMetalMap _GetMetalMapFunc;
            internal static _GetMetalMap GetMetalMap() {
               _GetMetalMapFunc ??= Torque3D.LookupEngineFunction<_GetMetalMap>("fnMaterial_getMetalMap");

                return _GetMetalMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAOMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetAOMap(IntPtr _this, SetAOMap__Args args);
            private static _SetAOMap _SetAOMapFunc;
            internal static _SetAOMap SetAOMap() {
               _SetAOMapFunc ??= Torque3D.LookupEngineFunction<_SetAOMap>("fnMaterial_setAOMap");

                return _SetAOMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAOMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAOMapAsset(IntPtr _this, GetAOMapAsset__Args args);
            private static _GetAOMapAsset _GetAOMapAssetFunc;
            internal static _GetAOMapAsset GetAOMapAsset() {
               _GetAOMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetAOMapAsset>("fnMaterial_getAOMapAsset");

                return _GetAOMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAOMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAOMap(IntPtr _this, GetAOMap__Args args);
            private static _GetAOMap _GetAOMapFunc;
            internal static _GetAOMap GetAOMap() {
               _GetAOMapFunc ??= Torque3D.LookupEngineFunction<_GetAOMap>("fnMaterial_getAOMap");

                return _GetAOMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRoughMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetRoughMap(IntPtr _this, SetRoughMap__Args args);
            private static _SetRoughMap _SetRoughMapFunc;
            internal static _SetRoughMap SetRoughMap() {
               _SetRoughMapFunc ??= Torque3D.LookupEngineFunction<_SetRoughMap>("fnMaterial_setRoughMap");

                return _SetRoughMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRoughMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetRoughMapAsset(IntPtr _this, GetRoughMapAsset__Args args);
            private static _GetRoughMapAsset _GetRoughMapAssetFunc;
            internal static _GetRoughMapAsset GetRoughMapAsset() {
               _GetRoughMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetRoughMapAsset>("fnMaterial_getRoughMapAsset");

                return _GetRoughMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRoughMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetRoughMap(IntPtr _this, GetRoughMap__Args args);
            private static _GetRoughMap _GetRoughMapFunc;
            internal static _GetRoughMap GetRoughMap() {
               _GetRoughMapFunc ??= Torque3D.LookupEngineFunction<_GetRoughMap>("fnMaterial_getRoughMap");

                return _GetRoughMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetORMConfigMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetORMConfigMap(IntPtr _this, SetORMConfigMap__Args args);
            private static _SetORMConfigMap _SetORMConfigMapFunc;
            internal static _SetORMConfigMap SetORMConfigMap() {
               _SetORMConfigMapFunc ??= Torque3D.LookupEngineFunction<_SetORMConfigMap>("fnMaterial_setORMConfigMap");

                return _SetORMConfigMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetORMConfigMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetORMConfigMapAsset(IntPtr _this, GetORMConfigMapAsset__Args args);
            private static _GetORMConfigMapAsset _GetORMConfigMapAssetFunc;
            internal static _GetORMConfigMapAsset GetORMConfigMapAsset() {
               _GetORMConfigMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetORMConfigMapAsset>("fnMaterial_getORMConfigMapAsset");

                return _GetORMConfigMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetORMConfigMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetORMConfigMap(IntPtr _this, GetORMConfigMap__Args args);
            private static _GetORMConfigMap _GetORMConfigMapFunc;
            internal static _GetORMConfigMap GetORMConfigMap() {
               _GetORMConfigMapFunc ??= Torque3D.LookupEngineFunction<_GetORMConfigMap>("fnMaterial_getORMConfigMap");

                return _GetORMConfigMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNormalMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetNormalMap(IntPtr _this, SetNormalMap__Args args);
            private static _SetNormalMap _SetNormalMapFunc;
            internal static _SetNormalMap SetNormalMap() {
               _SetNormalMapFunc ??= Torque3D.LookupEngineFunction<_SetNormalMap>("fnMaterial_setNormalMap");

                return _SetNormalMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNormalMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNormalMapAsset(IntPtr _this, GetNormalMapAsset__Args args);
            private static _GetNormalMapAsset _GetNormalMapAssetFunc;
            internal static _GetNormalMapAsset GetNormalMapAsset() {
               _GetNormalMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetNormalMapAsset>("fnMaterial_getNormalMapAsset");

                return _GetNormalMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNormalMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNormalMap(IntPtr _this, GetNormalMap__Args args);
            private static _GetNormalMap _GetNormalMapFunc;
            internal static _GetNormalMap GetNormalMap() {
               _GetNormalMapFunc ??= Torque3D.LookupEngineFunction<_GetNormalMap>("fnMaterial_getNormalMap");

                return _GetNormalMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetDetailMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetDetailMap(IntPtr _this, SetDetailMap__Args args);
            private static _SetDetailMap _SetDetailMapFunc;
            internal static _SetDetailMap SetDetailMap() {
               _SetDetailMapFunc ??= Torque3D.LookupEngineFunction<_SetDetailMap>("fnMaterial_setDetailMap");

                return _SetDetailMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDetailMapAsset(IntPtr _this, GetDetailMapAsset__Args args);
            private static _GetDetailMapAsset _GetDetailMapAssetFunc;
            internal static _GetDetailMapAsset GetDetailMapAsset() {
               _GetDetailMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetDetailMapAsset>("fnMaterial_getDetailMapAsset");

                return _GetDetailMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDetailMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDetailMap(IntPtr _this, GetDetailMap__Args args);
            private static _GetDetailMap _GetDetailMapFunc;
            internal static _GetDetailMap GetDetailMap() {
               _GetDetailMapFunc ??= Torque3D.LookupEngineFunction<_GetDetailMap>("fnMaterial_getDetailMap");

                return _GetDetailMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetToneMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetToneMap(IntPtr _this, SetToneMap__Args args);
            private static _SetToneMap _SetToneMapFunc;
            internal static _SetToneMap SetToneMap() {
               _SetToneMapFunc ??= Torque3D.LookupEngineFunction<_SetToneMap>("fnMaterial_setToneMap");

                return _SetToneMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetToneMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetToneMapAsset(IntPtr _this, GetToneMapAsset__Args args);
            private static _GetToneMapAsset _GetToneMapAssetFunc;
            internal static _GetToneMapAsset GetToneMapAsset() {
               _GetToneMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetToneMapAsset>("fnMaterial_getToneMapAsset");

                return _GetToneMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetToneMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetToneMap(IntPtr _this, GetToneMap__Args args);
            private static _GetToneMap _GetToneMapFunc;
            internal static _GetToneMap GetToneMap() {
               _GetToneMapFunc ??= Torque3D.LookupEngineFunction<_GetToneMap>("fnMaterial_getToneMap");

                return _GetToneMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetLightMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetLightMap(IntPtr _this, SetLightMap__Args args);
            private static _SetLightMap _SetLightMapFunc;
            internal static _SetLightMap SetLightMap() {
               _SetLightMapFunc ??= Torque3D.LookupEngineFunction<_SetLightMap>("fnMaterial_setLightMap");

                return _SetLightMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLightMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLightMapAsset(IntPtr _this, GetLightMapAsset__Args args);
            private static _GetLightMapAsset _GetLightMapAssetFunc;
            internal static _GetLightMapAsset GetLightMapAsset() {
               _GetLightMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetLightMapAsset>("fnMaterial_getLightMapAsset");

                return _GetLightMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLightMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLightMap(IntPtr _this, GetLightMap__Args args);
            private static _GetLightMap _GetLightMapFunc;
            internal static _GetLightMap GetLightMap() {
               _GetLightMapFunc ??= Torque3D.LookupEngineFunction<_GetLightMap>("fnMaterial_getLightMap");

                return _GetLightMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetOverlayMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetOverlayMap(IntPtr _this, SetOverlayMap__Args args);
            private static _SetOverlayMap _SetOverlayMapFunc;
            internal static _SetOverlayMap SetOverlayMap() {
               _SetOverlayMapFunc ??= Torque3D.LookupEngineFunction<_SetOverlayMap>("fnMaterial_setOverlayMap");

                return _SetOverlayMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetOverlayMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetOverlayMapAsset(IntPtr _this, GetOverlayMapAsset__Args args);
            private static _GetOverlayMapAsset _GetOverlayMapAssetFunc;
            internal static _GetOverlayMapAsset GetOverlayMapAsset() {
               _GetOverlayMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetOverlayMapAsset>("fnMaterial_getOverlayMapAsset");

                return _GetOverlayMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetOverlayMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetOverlayMap(IntPtr _this, GetOverlayMap__Args args);
            private static _GetOverlayMap _GetOverlayMapFunc;
            internal static _GetOverlayMap GetOverlayMap() {
               _GetOverlayMapFunc ??= Torque3D.LookupEngineFunction<_GetOverlayMap>("fnMaterial_getOverlayMap");

                return _GetOverlayMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetDiffuseMap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string map;
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetDiffuseMap(IntPtr _this, SetDiffuseMap__Args args);
            private static _SetDiffuseMap _SetDiffuseMapFunc;
            internal static _SetDiffuseMap SetDiffuseMap() {
               _SetDiffuseMapFunc ??= Torque3D.LookupEngineFunction<_SetDiffuseMap>("fnMaterial_setDiffuseMap");

                return _SetDiffuseMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDiffuseMapAsset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDiffuseMapAsset(IntPtr _this, GetDiffuseMapAsset__Args args);
            private static _GetDiffuseMapAsset _GetDiffuseMapAssetFunc;
            internal static _GetDiffuseMapAsset GetDiffuseMapAsset() {
               _GetDiffuseMapAssetFunc ??= Torque3D.LookupEngineFunction<_GetDiffuseMapAsset>("fnMaterial_getDiffuseMapAsset");

                return _GetDiffuseMapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDiffuseMap__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetDiffuseMap(IntPtr _this, GetDiffuseMap__Args args);
            private static _GetDiffuseMap _GetDiffuseMapFunc;
            internal static _GetDiffuseMap GetDiffuseMap() {
               _GetDiffuseMapFunc ??= Torque3D.LookupEngineFunction<_GetDiffuseMap>("fnMaterial_getDiffuseMap");

                return _GetDiffuseMapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAutogeneratedFile__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAutogeneratedFile(IntPtr _this, GetAutogeneratedFile__Args args);
            private static _GetAutogeneratedFile _GetAutogeneratedFileFunc;
            internal static _GetAutogeneratedFile GetAutogeneratedFile() {
               _GetAutogeneratedFileFunc ??= Torque3D.LookupEngineFunction<_GetAutogeneratedFile>("fnMaterial_getAutogeneratedFile");

                return _GetAutogeneratedFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAutoGenerated__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool isAutoGenerated;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAutoGenerated(IntPtr _this, SetAutoGenerated__Args args);
            private static _SetAutoGenerated _SetAutoGeneratedFunc;
            internal static _SetAutoGenerated SetAutoGenerated() {
               _SetAutoGeneratedFunc ??= Torque3D.LookupEngineFunction<_SetAutoGenerated>("fnMaterial_setAutoGenerated");

                return _SetAutoGeneratedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsAutoGenerated__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsAutoGenerated(IntPtr _this, IsAutoGenerated__Args args);
            private static _IsAutoGenerated _IsAutoGeneratedFunc;
            internal static _IsAutoGenerated IsAutoGenerated() {
               _IsAutoGeneratedFunc ??= Torque3D.LookupEngineFunction<_IsAutoGenerated>("fnMaterial_isAutoGenerated");

                return _IsAutoGeneratedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFilename__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetFilename(IntPtr _this, GetFilename__Args args);
            private static _GetFilename _GetFilenameFunc;
            internal static _GetFilename GetFilename() {
               _GetFilenameFunc ??= Torque3D.LookupEngineFunction<_GetFilename>("fnMaterial_getFilename");

                return _GetFilenameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAnimFlags__Args
            {
                internal int id;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string flags;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAnimFlags(IntPtr _this, SetAnimFlags__Args args);
            private static _SetAnimFlags _SetAnimFlagsFunc;
            internal static _SetAnimFlags SetAnimFlags() {
               _SetAnimFlagsFunc ??= Torque3D.LookupEngineFunction<_SetAnimFlags>("fnMaterial_setAnimFlags");

                return _SetAnimFlagsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAnimFlags__Args
            {
                internal uint id;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAnimFlags(IntPtr _this, GetAnimFlags__Args args);
            private static _GetAnimFlags _GetAnimFlagsFunc;
            internal static _GetAnimFlags GetAnimFlags() {
               _GetAnimFlagsFunc ??= Torque3D.LookupEngineFunction<_GetAnimFlags>("fnMaterial_getAnimFlags");

                return _GetAnimFlagsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMaterialInstances__Args
            {
                internal IntPtr matTree;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _GetMaterialInstances(IntPtr _this, GetMaterialInstances__Args args);
            private static _GetMaterialInstances _GetMaterialInstancesFunc;
            internal static _GetMaterialInstances GetMaterialInstances() {
               _GetMaterialInstancesFunc ??= Torque3D.LookupEngineFunction<_GetMaterialInstances>("fnMaterial_getMaterialInstances");

                return _GetMaterialInstancesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpInstances__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpInstances(IntPtr _this, DumpInstances__Args args);
            private static _DumpInstances _DumpInstancesFunc;
            internal static _DumpInstances DumpInstances() {
               _DumpInstancesFunc ??= Torque3D.LookupEngineFunction<_DumpInstances>("fnMaterial_dumpInstances");

                return _DumpInstancesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Reload__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reload(IntPtr _this, Reload__Args args);
            private static _Reload _ReloadFunc;
            internal static _Reload Reload() {
               _ReloadFunc ??= Torque3D.LookupEngineFunction<_Reload>("fnMaterial_reload");

                return _ReloadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Flush__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Flush(IntPtr _this, Flush__Args args);
            private static _Flush _FlushFunc;
            internal static _Flush Flush() {
               _FlushFunc ??= Torque3D.LookupEngineFunction<_Flush>("fnMaterial_flush");

                return _FlushFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnMaterial_staticGetType");

                return _StaticGetTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Create__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _Create(Create__Args args);
            private static _Create _CreateFunc;
            internal static _Create Create() {
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnMaterial_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// DetailNormalMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetDetailNormalMap(string map, int index) {
             InternalUnsafeMethods.SetDetailNormalMap__Args _args = new InternalUnsafeMethods.SetDetailNormalMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetDetailNormalMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// DetailNormalMapasset reference
        /// </description>
        public string GetDetailNormalMapAsset(int index) {
             InternalUnsafeMethods.GetDetailNormalMapAsset__Args _args = new InternalUnsafeMethods.GetDetailNormalMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDetailNormalMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetDetailNormalMap(int index) {
             InternalUnsafeMethods.GetDetailNormalMap__Args _args = new InternalUnsafeMethods.GetDetailNormalMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDetailNormalMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// GlowMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetGlowMap(string map, int index) {
             InternalUnsafeMethods.SetGlowMap__Args _args = new InternalUnsafeMethods.SetGlowMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetGlowMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// GlowMapasset reference
        /// </description>
        public string GetGlowMapAsset(int index) {
             InternalUnsafeMethods.GetGlowMapAsset__Args _args = new InternalUnsafeMethods.GetGlowMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetGlowMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetGlowMap(int index) {
             InternalUnsafeMethods.GetGlowMap__Args _args = new InternalUnsafeMethods.GetGlowMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetGlowMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// MetalMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetMetalMap(string map, int index) {
             InternalUnsafeMethods.SetMetalMap__Args _args = new InternalUnsafeMethods.SetMetalMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetMetalMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// MetalMapasset reference
        /// </description>
        public string GetMetalMapAsset(int index) {
             InternalUnsafeMethods.GetMetalMapAsset__Args _args = new InternalUnsafeMethods.GetMetalMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMetalMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetMetalMap(int index) {
             InternalUnsafeMethods.GetMetalMap__Args _args = new InternalUnsafeMethods.GetMetalMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMetalMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// AOMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetAOMap(string map, int index) {
             InternalUnsafeMethods.SetAOMap__Args _args = new InternalUnsafeMethods.SetAOMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetAOMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// AOMapasset reference
        /// </description>
        public string GetAOMapAsset(int index) {
             InternalUnsafeMethods.GetAOMapAsset__Args _args = new InternalUnsafeMethods.GetAOMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAOMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetAOMap(int index) {
             InternalUnsafeMethods.GetAOMap__Args _args = new InternalUnsafeMethods.GetAOMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAOMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// RoughMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetRoughMap(string map, int index) {
             InternalUnsafeMethods.SetRoughMap__Args _args = new InternalUnsafeMethods.SetRoughMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetRoughMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// RoughMapasset reference
        /// </description>
        public string GetRoughMapAsset(int index) {
             InternalUnsafeMethods.GetRoughMapAsset__Args _args = new InternalUnsafeMethods.GetRoughMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetRoughMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetRoughMap(int index) {
             InternalUnsafeMethods.GetRoughMap__Args _args = new InternalUnsafeMethods.GetRoughMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetRoughMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// ORMConfigMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetORMConfigMap(string map, int index) {
             InternalUnsafeMethods.SetORMConfigMap__Args _args = new InternalUnsafeMethods.SetORMConfigMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetORMConfigMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ORMConfigMapasset reference
        /// </description>
        public string GetORMConfigMapAsset(int index) {
             InternalUnsafeMethods.GetORMConfigMapAsset__Args _args = new InternalUnsafeMethods.GetORMConfigMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetORMConfigMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetORMConfigMap(int index) {
             InternalUnsafeMethods.GetORMConfigMap__Args _args = new InternalUnsafeMethods.GetORMConfigMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetORMConfigMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// NormalMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetNormalMap(string map, int index) {
             InternalUnsafeMethods.SetNormalMap__Args _args = new InternalUnsafeMethods.SetNormalMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetNormalMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// NormalMapasset reference
        /// </description>
        public string GetNormalMapAsset(int index) {
             InternalUnsafeMethods.GetNormalMapAsset__Args _args = new InternalUnsafeMethods.GetNormalMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNormalMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetNormalMap(int index) {
             InternalUnsafeMethods.GetNormalMap__Args _args = new InternalUnsafeMethods.GetNormalMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNormalMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// DetailMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetDetailMap(string map, int index) {
             InternalUnsafeMethods.SetDetailMap__Args _args = new InternalUnsafeMethods.SetDetailMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetDetailMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// DetailMapasset reference
        /// </description>
        public string GetDetailMapAsset(int index) {
             InternalUnsafeMethods.GetDetailMapAsset__Args _args = new InternalUnsafeMethods.GetDetailMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDetailMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetDetailMap(int index) {
             InternalUnsafeMethods.GetDetailMap__Args _args = new InternalUnsafeMethods.GetDetailMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDetailMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// ToneMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetToneMap(string map, int index) {
             InternalUnsafeMethods.SetToneMap__Args _args = new InternalUnsafeMethods.SetToneMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetToneMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ToneMapasset reference
        /// </description>
        public string GetToneMapAsset(int index) {
             InternalUnsafeMethods.GetToneMapAsset__Args _args = new InternalUnsafeMethods.GetToneMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetToneMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetToneMap(int index) {
             InternalUnsafeMethods.GetToneMap__Args _args = new InternalUnsafeMethods.GetToneMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetToneMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// LightMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetLightMap(string map, int index) {
             InternalUnsafeMethods.SetLightMap__Args _args = new InternalUnsafeMethods.SetLightMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetLightMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// LightMapasset reference
        /// </description>
        public string GetLightMapAsset(int index) {
             InternalUnsafeMethods.GetLightMapAsset__Args _args = new InternalUnsafeMethods.GetLightMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLightMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetLightMap(int index) {
             InternalUnsafeMethods.GetLightMap__Args _args = new InternalUnsafeMethods.GetLightMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLightMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// OverlayMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetOverlayMap(string map, int index) {
             InternalUnsafeMethods.SetOverlayMap__Args _args = new InternalUnsafeMethods.SetOverlayMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetOverlayMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// OverlayMapasset reference
        /// </description>
        public string GetOverlayMapAsset(int index) {
             InternalUnsafeMethods.GetOverlayMapAsset__Args _args = new InternalUnsafeMethods.GetOverlayMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetOverlayMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetOverlayMap(int index) {
             InternalUnsafeMethods.GetOverlayMap__Args _args = new InternalUnsafeMethods.GetOverlayMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetOverlayMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// DiffuseMapassignment. first tries asset then flat file.
        /// </description>
        public bool SetDiffuseMap(string map, int index) {
             InternalUnsafeMethods.SetDiffuseMap__Args _args = new InternalUnsafeMethods.SetDiffuseMap__Args() {
                map = map,
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.SetDiffuseMap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// DiffuseMapasset reference
        /// </description>
        public string GetDiffuseMapAsset(int index) {
             InternalUnsafeMethods.GetDiffuseMapAsset__Args _args = new InternalUnsafeMethods.GetDiffuseMapAsset__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDiffuseMapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetDiffuseMap(int index) {
             InternalUnsafeMethods.GetDiffuseMap__Args _args = new InternalUnsafeMethods.GetDiffuseMap__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetDiffuseMap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get filename of autogenerated shader file
        /// </description>
        public string GetAutogeneratedFile() {
             InternalUnsafeMethods.GetAutogeneratedFile__Args _args = new InternalUnsafeMethods.GetAutogeneratedFile__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAutogeneratedFile()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// setAutoGenerated(bool isAutoGenerated): Set whether or not the Material is autogenerated.
        /// </description>
        public void SetAutoGenerated(bool isAutoGenerated) {
             InternalUnsafeMethods.SetAutoGenerated__Args _args = new InternalUnsafeMethods.SetAutoGenerated__Args() {
                isAutoGenerated = isAutoGenerated,
             };
             InternalUnsafeMethods.SetAutoGenerated()(ObjectPtr, _args);
        }

        /// <description>
        /// Returns true if this Material was automatically generated by MaterialList::mapMaterials()
        /// </description>
        public bool IsAutoGenerated() {
             InternalUnsafeMethods.IsAutoGenerated__Args _args = new InternalUnsafeMethods.IsAutoGenerated__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsAutoGenerated()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get filename of material
        /// </description>
        public string GetFilename() {
             InternalUnsafeMethods.GetFilename__Args _args = new InternalUnsafeMethods.GetFilename__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetFilename()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// setAnimFlags
        /// </description>
        public void SetAnimFlags(int id = 0, string flags = "") {
             InternalUnsafeMethods.SetAnimFlags__Args _args = new InternalUnsafeMethods.SetAnimFlags__Args() {
                id = id,
                flags = flags,
             };
             InternalUnsafeMethods.SetAnimFlags()(ObjectPtr, _args);
        }

        /// 
        public string GetAnimFlags(uint id) {
             InternalUnsafeMethods.GetAnimFlags__Args _args = new InternalUnsafeMethods.GetAnimFlags__Args() {
                id = id,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAnimFlags()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Dumps a formatted list of the currently allocated material instances for this material to the console.
        /// </description>
        public void GetMaterialInstances(GuiTreeViewCtrl matTree = null) {
             InternalUnsafeMethods.GetMaterialInstances__Args _args = new InternalUnsafeMethods.GetMaterialInstances__Args() {
                matTree = matTree.ObjectPtr,
             };
             InternalUnsafeMethods.GetMaterialInstances()(ObjectPtr, _args);
        }

        /// <description>
        /// Dumps a formatted list of the currently allocated material instances for this material to the console.
        /// </description>
        public void DumpInstances() {
             InternalUnsafeMethods.DumpInstances__Args _args = new InternalUnsafeMethods.DumpInstances__Args() {
             };
             InternalUnsafeMethods.DumpInstances()(ObjectPtr, _args);
        }

        /// <description>
        /// Reloads all material instances that use this material.
        /// </description>
        public void Reload() {
             InternalUnsafeMethods.Reload__Args _args = new InternalUnsafeMethods.Reload__Args() {
             };
             InternalUnsafeMethods.Reload()(ObjectPtr, _args);
        }

        /// <description>
        /// Flushes all material instances that use this material.
        /// </description>
        public void Flush() {
             InternalUnsafeMethods.Flush__Args _args = new InternalUnsafeMethods.Flush__Args() {
             };
             InternalUnsafeMethods.Flush()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the Material class.
        /// </description>
        /// <returns>The type info object for Material</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Used to map this material to the material name used by TSShape.
        /// </description>
        /// </value>
        public string MapTo {
            get => GenericMarshal.StringTo<string>(GetFieldValue("mapTo"));
            set => SetFieldValue("mapTo", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// This color is multiplied against the diffuse texture color.  If no diffuse texture is present this is the material color.
        /// </description>
        /// </value>
        public DynamicFieldVector<LinearColorF> DiffuseColor {
            get => new DynamicFieldVector<LinearColorF>(
                    this, 
                    "DiffuseColor", 
                    4, 
                    val => GenericMarshal.StringTo<LinearColorF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>DiffuseMap "Albedo"</summary>
        /// </value>
        public DynamicFieldVector<string> DiffuseMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "DiffuseMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>DiffuseMap asset "Albedo".</summary>
        /// </value>
        public DynamicFieldVector<string> DiffuseMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "DiffuseMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>OverlayMap "Overlay"</summary>
        /// </value>
        public DynamicFieldVector<string> OverlayMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "OverlayMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>OverlayMap asset "Overlay".</summary>
        /// </value>
        public DynamicFieldVector<string> OverlayMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "OverlayMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>LightMap "LightMap"</summary>
        /// </value>
        public DynamicFieldVector<string> LightMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "LightMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>LightMap asset "LightMap".</summary>
        /// </value>
        public DynamicFieldVector<string> LightMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "LightMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>ToneMap "ToneMap"</summary>
        /// </value>
        public DynamicFieldVector<string> ToneMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "ToneMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>ToneMap asset "ToneMap".</summary>
        /// </value>
        public DynamicFieldVector<string> ToneMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "ToneMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>DetailMap "DetailMap"</summary>
        /// </value>
        public DynamicFieldVector<string> DetailMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "DetailMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>DetailMap asset "DetailMap".</summary>
        /// </value>
        public DynamicFieldVector<string> DetailMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "DetailMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>NormalMap "NormalMap"</summary>
        /// </value>
        public DynamicFieldVector<string> NormalMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "NormalMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>NormalMap asset "NormalMap".</summary>
        /// </value>
        public DynamicFieldVector<string> NormalMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "NormalMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>ORMConfigMap "AO|Roughness|metalness map"</summary>
        /// </value>
        public DynamicFieldVector<string> ORMConfigMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "ORMConfigMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>ORMConfigMap asset "AO|Roughness|metalness map".</summary>
        /// </value>
        public DynamicFieldVector<string> ORMConfigMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "ORMConfigMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>RoughMap "RoughMap (also needs MetalMap)"</summary>
        /// </value>
        public DynamicFieldVector<string> RoughMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "RoughMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>RoughMap asset "RoughMap (also needs MetalMap)".</summary>
        /// </value>
        public DynamicFieldVector<string> RoughMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "RoughMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>AOMap "AOMap"</summary>
        /// </value>
        public DynamicFieldVector<string> AOMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "AOMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>AOMap asset "AOMap".</summary>
        /// </value>
        public DynamicFieldVector<string> AOMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "AOMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>MetalMap "MetalMap (also needs RoughMap)"</summary>
        /// </value>
        public DynamicFieldVector<string> MetalMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "MetalMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>MetalMap asset "MetalMap (also needs RoughMap)".</summary>
        /// </value>
        public DynamicFieldVector<string> MetalMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "MetalMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>GlowMap "GlowMap (needs Albedo)"</summary>
        /// </value>
        public DynamicFieldVector<string> GlowMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "GlowMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>GlowMap asset "GlowMap (needs Albedo)".</summary>
        /// </value>
        public DynamicFieldVector<string> GlowMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "GlowMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>DetailNormalMap "DetailNormalMap"</summary>
        /// </value>
        public DynamicFieldVector<string> DetailNormalMap {
            get => new DynamicFieldVector<string>(
                    this, 
                    "DetailNormalMap", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>DetailNormalMap asset "DetailNormalMap".</summary>
        /// </value>
        public DynamicFieldVector<string> DetailNormalMapAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "DetailNormalMapAsset", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Enable sRGB for the diffuse color texture map.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> DiffuseMapSRGB {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "DiffuseMapSRGB", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The scale factor for the detail map.
        /// </description>
        /// </value>
        public DynamicFieldVector<Point2F> DetailScale {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "DetailScale", 
                    4, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Used to scale the strength of the detail normal map when blended with the base normal map.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> DetailNormalMapStrength {
            get => new DynamicFieldVector<float>(
                    this, 
                    "DetailNormalMapStrength", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The degree of roughness when not using a ORMConfigMap.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> Roughness {
            get => new DynamicFieldVector<float>(
                    this, 
                    "Roughness", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The degree of Metalness when not using a ORMConfigMap.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> Metalness {
            get => new DynamicFieldVector<float>(
                    this, 
                    "Metalness", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// glow mask multiplier
        /// </description>
        /// </value>
        public DynamicFieldVector<float> GlowMul {
            get => new DynamicFieldVector<float>(
                    this, 
                    "GlowMul", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Accumulation texture.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> AccuEnabled {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "AccuEnabled", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The scale that is applied to the accu map texture. You can use this to fit the texture to smaller or larger objects.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> AccuScale {
            get => new DynamicFieldVector<float>(
                    this, 
                    "AccuScale", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The direction of the accumulation. Chose whether you want the accu map to go from top to bottom (ie. snow) or upwards (ie. mold).
        /// </description>
        /// </value>
        public DynamicFieldVector<float> AccuDirection {
            get => new DynamicFieldVector<float>(
                    this, 
                    "AccuDirection", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The strength of the accu map. This changes the transparency of the accu map texture. Make it subtle or add more contrast.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> AccuStrength {
            get => new DynamicFieldVector<float>(
                    this, 
                    "AccuStrength", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The coverage ratio of the accu map texture. Use this to make the entire shape pick up some of the accu map texture or none at all.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> AccuCoverage {
            get => new DynamicFieldVector<float>(
                    this, 
                    "AccuCoverage", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Changes specularity to this value where the accumulated material is present.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> AccuSpecular {
            get => new DynamicFieldVector<float>(
                    this, 
                    "AccuSpecular", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Substance Designer Workaround.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> IsSRGb {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "IsSRGb", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Treat Roughness as Roughness
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> InvertRoughness {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "InvertRoughness", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The input channel roughness maps use.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> RoughnessChan {
            get => new DynamicFieldVector<float>(
                    this, 
                    "RoughnessChan", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The input channel AO maps use.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> AOChan {
            get => new DynamicFieldVector<float>(
                    this, 
                    "AOChan", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The input channel metalness maps use.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> MetalChan {
            get => new DynamicFieldVector<float>(
                    this, 
                    "MetalChan", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Enables rendering as glowing.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> Glow {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "Glow", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Enables parallax mapping and defines the scale factor for the parallax effect.  Typically this value is less than 0.4 else the effect breaks down.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> ParallaxScale {
            get => new DynamicFieldVector<float>(
                    this, 
                    "ParallaxScale", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Use anisotropic filtering for the textures of this stage.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> UseAnisotropic {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "UseAnisotropic", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// If true the vertex color is used for lighting.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> VertLit {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "VertLit", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// If enabled, vertex colors are premultiplied with diffuse colors.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> VertColor {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "VertColor", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The Minnaert shading constant value.  Must be greater than 0 to enable the effect.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> MinnaertConstant {
            get => new DynamicFieldVector<float>(
                    this, 
                    "MinnaertConstant", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Enables the subsurface scattering approximation.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> SubSurface {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "SubSurface", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The color used for the subsurface scattering approximation.
        /// </description>
        /// </value>
        public DynamicFieldVector<LinearColorF> SubSurfaceColor {
            get => new DynamicFieldVector<LinearColorF>(
                    this, 
                    "SubSurfaceColor", 
                    4, 
                    val => GenericMarshal.StringTo<LinearColorF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The 0 to 1 rolloff factor used in the subsurface scattering approximation.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> SubSurfaceRolloff {
            get => new DynamicFieldVector<float>(
                    this, 
                    "SubSurfaceRolloff", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Shadows being cast onto the material.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> ReceiveShadows {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "ReceiveShadows", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Enables emissive lighting for the material.
        /// </description>
        /// </value>
        public DynamicFieldVector<bool> IgnoreLighting {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "IgnoreLighting", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// Disables backface culling casing surfaces to be double sided. Note that the lighting on the backside will be a mirror of the front side of the surface.
        /// </description>
        /// </value>
        public bool DoubleSided {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("doubleSided"));
            set => SetFieldValue("doubleSided", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The types of animation to play on this material.
        /// </description>
        /// </value>
        public DynamicFieldVector<MaterialAnimType> AnimFlags {
            get => new DynamicFieldVector<MaterialAnimType>(
                    this, 
                    "AnimFlags", 
                    4, 
                    val => GenericMarshal.StringTo<MaterialAnimType>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The scroll direction in UV space when scroll animation is enabled.
        /// </description>
        /// </value>
        public DynamicFieldVector<Point2F> ScrollDir {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "ScrollDir", 
                    4, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The speed to scroll the texture in UVs per second when scroll animation is enabled.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> ScrollSpeed {
            get => new DynamicFieldVector<float>(
                    this, 
                    "ScrollSpeed", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The speed to rotate the texture in degrees per second when rotation animation is enabled.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> RotSpeed {
            get => new DynamicFieldVector<float>(
                    this, 
                    "RotSpeed", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The piviot position in UV coordinates to center the rotation animation.
        /// </description>
        /// </value>
        public DynamicFieldVector<Point2F> RotPivotOffset {
            get => new DynamicFieldVector<Point2F>(
                    this, 
                    "RotPivotOffset", 
                    4, 
                    val => GenericMarshal.StringTo<Point2F>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The type of wave animation to perform when wave animation is enabled.
        /// </description>
        /// </value>
        public DynamicFieldVector<MaterialWaveType> WaveType {
            get => new DynamicFieldVector<MaterialWaveType>(
                    this, 
                    "WaveType", 
                    4, 
                    val => GenericMarshal.StringTo<MaterialWaveType>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The wave frequency when wave animation is enabled.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> WaveFreq {
            get => new DynamicFieldVector<float>(
                    this, 
                    "WaveFreq", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The wave amplitude when wave animation is enabled.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> WaveAmp {
            get => new DynamicFieldVector<float>(
                    this, 
                    "WaveAmp", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The number of frames per second for frame based sequence animations if greater than zero.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> SequenceFramePerSec {
            get => new DynamicFieldVector<float>(
                    this, 
                    "SequenceFramePerSec", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// The size of each frame in UV units for sequence animations.
        /// </description>
        /// </value>
        public DynamicFieldVector<float> SequenceSegmentSize {
            get => new DynamicFieldVector<float>(
                    this, 
                    "SequenceSegmentSize", 
                    4, 
                    val => GenericMarshal.StringTo<float>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// 
        /// </value>
        public DynamicFieldVector<Point2I> CellIndex {
            get => new DynamicFieldVector<Point2I>(
                    this, 
                    "CellIndex", 
                    4, 
                    val => GenericMarshal.StringTo<Point2I>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// 
        /// </value>
        public DynamicFieldVector<Point2I> CellLayout {
            get => new DynamicFieldVector<Point2I>(
                    this, 
                    "CellLayout", 
                    4, 
                    val => GenericMarshal.StringTo<Point2I>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// 
        /// </value>
        public DynamicFieldVector<int> CellSize {
            get => new DynamicFieldVector<int>(
                    this, 
                    "CellSize", 
                    4, 
                    val => GenericMarshal.StringTo<int>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// 
        /// </value>
        public DynamicFieldVector<bool> BumpAtlas {
            get => new DynamicFieldVector<bool>(
                    this, 
                    "BumpAtlas", 
                    4, 
                    val => GenericMarshal.StringTo<bool>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// For backwards compatibility.
        /// </description>
        /// <see cref="diffuseMap" />
        /// </value>
        public DynamicFieldVector<string> BaseTex {
            get => new DynamicFieldVector<string>(
                    this, 
                    "BaseTex", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// For backwards compatibility.
        /// </description>
        /// <see cref="detailMap" />
        /// </value>
        public DynamicFieldVector<string> DetailTex {
            get => new DynamicFieldVector<string>(
                    this, 
                    "DetailTex", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// For backwards compatibility.
        /// </description>
        /// <see cref="overlayMap" />
        /// </value>
        public DynamicFieldVector<string> OverlayTex {
            get => new DynamicFieldVector<string>(
                    this, 
                    "OverlayTex", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// For backwards compatibility.
        /// </description>
        /// <see cref="normalMap" />
        /// </value>
        public DynamicFieldVector<string> BumpTex {
            get => new DynamicFieldVector<string>(
                    this, 
                    "BumpTex", 
                    4, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// For backwards compatibility.
        /// </description>
        /// <see cref="diffuseColor" />
        /// </value>
        public DynamicFieldVector<LinearColorF> ColorMultiply {
            get => new DynamicFieldVector<LinearColorF>(
                    this, 
                    "ColorMultiply", 
                    4, 
                    val => GenericMarshal.StringTo<LinearColorF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// If set to false the lighting system will not cast shadows from this material.
        /// </description>
        /// </value>
        public bool CastShadows {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("castShadows"));
            set => SetFieldValue("castShadows", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool PlanarReflection {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("planarReflection"));
            set => SetFieldValue("planarReflection", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true this material is translucent blended.
        /// </description>
        /// </value>
        public bool Translucent {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("translucent"));
            set => SetFieldValue("translucent", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The type of blend operation to use when the material is translucent.
        /// </description>
        /// </value>
        public MaterialBlendOp TranslucentBlendOp {
            get => GenericMarshal.StringTo<MaterialBlendOp>(GetFieldValue("translucentBlendOp"));
            set => SetFieldValue("translucentBlendOp", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If enabled and the material is translucent it will write into the depth buffer.
        /// </description>
        /// </value>
        public bool TranslucentZWrite {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("translucentZWrite"));
            set => SetFieldValue("translucentZWrite", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Enables alpha test when rendering the material.
        /// </description>
        /// <see cref="alphaRef" />
        /// </value>
        public bool AlphaTest {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("alphaTest"));
            set => SetFieldValue("alphaTest", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The alpha reference value for alpha testing.  Must be between 0 to 255.
        /// </description>
        /// <see cref="alphaTest" />
        /// </value>
        public int AlphaRef {
            get => GenericMarshal.StringTo<int>(GetFieldValue("alphaRef"));
            set => SetFieldValue("alphaRef", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The name of a CubemapData for environment mapping.
        /// </description>
        /// </value>
        public string Cubemap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("cubemap"));
            set => SetFieldValue("cubemap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Enables the material to use the dynamic cubemap from the ShapeBase object its applied to.
        /// </description>
        /// </value>
        public bool DynamicCubemap {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("dynamicCubemap"));
            set => SetFieldValue("dynamicCubemap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to show player footprint decals on this material.
        /// </description>
        /// <see cref="PlayerData::decalData" />
        /// </value>
        public bool ShowFootprints {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showFootprints"));
            set => SetFieldValue("showFootprints", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to emit dust particles from a shape moving over the material.  This is, for example, used by vehicles or players to decide whether to show dust trails.
        /// </description>
        /// </value>
        public bool ShowDust {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("showDust"));
            set => SetFieldValue("showDust", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If #showDust is true, this is the set of colors to use for the ParticleData of the dust emitter.
        /// </description>
        /// <see cref="ParticleData::colors" />
        /// </value>
        public DynamicFieldVector<LinearColorF> EffectColor {
            get => new DynamicFieldVector<LinearColorF>(
                    this, 
                    "EffectColor", 
                    2, 
                    val => GenericMarshal.StringTo<LinearColorF>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// What sound to play from the PlayerData sound list when the player walks over the material.  -1 (default) to not play any sound.
        /// 
        /// The IDs are:
        /// 
        /// - 0: PlayerData::FootSoftSound
        /// - 1: PlayerData::FootHardSound
        /// - 2: PlayerData::FootMetalSound
        /// - 3: PlayerData::FootSnowSound
        /// - 4: PlayerData::FootShallowSound
        /// - 5: PlayerData::FootWadingSound
        /// - 6: PlayerData::FootUnderwaterSound
        /// - 7: PlayerData::FootBubblesSound
        /// - 8: PlayerData::movingBubblesSound
        /// - 9: PlayerData::waterBreathSound
        /// - 10: PlayerData::impactSoftSound
        /// - 11: PlayerData::impactHardSound
        /// - 12: PlayerData::impactMetalSound
        /// - 13: PlayerData::impactSnowSound
        /// - 14: PlayerData::impactWaterEasy
        /// - 15: PlayerData::impactWaterMedium
        /// - 16: PlayerData::impactWaterHard
        /// - 17: PlayerData::exitingWater
        /// </description>
        /// </value>
        public int FootstepSoundId {
            get => GenericMarshal.StringTo<int>(GetFieldValue("footstepSoundId"));
            set => SetFieldValue("footstepSoundId", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// CustomFootstepSound"The sound to play when the player walks over the material.  If this is set, it overrides #footstepSoundId.  This field is " "useful for directly assigning custom footstep sounds to materials without having to rely on the PlayerData sound assignment.\n\n" "
        /// </description>
        /// </value>
        public string CustomFootstepSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("CustomFootstepSoundFile"));
            set => SetFieldValue("CustomFootstepSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// CustomFootstepSoundasset reference.
        /// </description>
        /// </value>
        public string CustomFootstepSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("CustomFootstepSoundAsset"));
            set => SetFieldValue("CustomFootstepSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// What sound to play from the PlayerData sound list when the player impacts on the surface with a velocity equal or greater than PlayerData::groundImpactMinSpeed.
        /// 
        /// For a list of IDs, see #footstepSoundId
        /// </description>
        /// </value>
        public int ImpactSoundId {
            get => GenericMarshal.StringTo<int>(GetFieldValue("impactSoundId"));
            set => SetFieldValue("impactSoundId", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// What FX to play from the PlayerData sound list when the player impacts on the surface with a velocity equal or greater than PlayerData::groundImpactMinSpeed.
        /// 
        /// For a list of IDs, see #impactFXId
        /// </description>
        /// </value>
        public int ImpactFXIndex {
            get => GenericMarshal.StringTo<int>(GetFieldValue("ImpactFXIndex"));
            set => SetFieldValue("ImpactFXIndex", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// CustomImpactSound"The sound to play when the player impacts on the surface with a velocity equal or greater than PlayerData::groundImpactMinSpeed.  " "If this is set, it overrides #impactSoundId.  This field is useful for directly assigning custom impact sounds to materials " "without having to rely on the PlayerData sound assignment.\n\n" "
        /// </description>
        /// </value>
        public string CustomImpactSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("CustomImpactSoundFile"));
            set => SetFieldValue("CustomImpactSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// CustomImpactSoundasset reference.
        /// </description>
        /// </value>
        public string CustomImpactSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("CustomImpactSoundAsset"));
            set => SetFieldValue("CustomImpactSoundAsset", GenericMarshal.ToString(value));
        }
    }
}
