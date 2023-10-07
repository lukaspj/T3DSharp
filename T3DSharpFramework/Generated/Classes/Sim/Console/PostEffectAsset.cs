using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Engine;
using T3DSharpFramework.Engine.Util;
using T3DSharpFramework.Generated.Classes.Console;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Reflection;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Console;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Enums.Reflection;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Classes.Sim.Console {
    /// 
    public class PostEffectAsset : AssetBase {
        public PostEffectAsset(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public PostEffectAsset(string pName, bool pRegister)
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

        public PostEffectAsset(string pName)
            : this(pName, false) {
        }

        public PostEffectAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public PostEffectAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public PostEffectAsset(SimObject pObj)
            : base(pObj) {
        }

        public PostEffectAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetGLSLShaderPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetGLSLShaderPath(IntPtr _this, GetGLSLShaderPath__Args args);
            private static _GetGLSLShaderPath _GetGLSLShaderPathFunc;
            internal static _GetGLSLShaderPath GetGLSLShaderPath() {
               _GetGLSLShaderPathFunc ??= Torque3D.LookupEngineFunction<_GetGLSLShaderPath>("fnPostEffectAsset_getGLSLShaderPath");

                return _GetGLSLShaderPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetHLSLShaderPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetHLSLShaderPath(IntPtr _this, GetHLSLShaderPath__Args args);
            private static _GetHLSLShaderPath _GetHLSLShaderPathFunc;
            internal static _GetHLSLShaderPath GetHLSLShaderPath() {
               _GetHLSLShaderPathFunc ??= Torque3D.LookupEngineFunction<_GetHLSLShaderPath>("fnPostEffectAsset_getHLSLShaderPath");

                return _GetHLSLShaderPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetScriptPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetScriptPath(IntPtr _this, GetScriptPath__Args args);
            private static _GetScriptPath _GetScriptPathFunc;
            internal static _GetScriptPath GetScriptPath() {
               _GetScriptPathFunc ??= Torque3D.LookupEngineFunction<_GetScriptPath>("fnPostEffectAsset_getScriptPath");

                return _GetScriptPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnPostEffectAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnPostEffectAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Gets the GLSL Shader file path for the asset.
        /// </description>
        public string GetGLSLShaderPath() {
             InternalUnsafeMethods.GetGLSLShaderPath__Args _args = new InternalUnsafeMethods.GetGLSLShaderPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetGLSLShaderPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the HLSL Shader file path for the asset.
        /// </description>
        public string GetHLSLShaderPath() {
             InternalUnsafeMethods.GetHLSLShaderPath__Args _args = new InternalUnsafeMethods.GetHLSLShaderPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetHLSLShaderPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the script file path for the asset.
        /// </description>
        public string GetScriptPath() {
             InternalUnsafeMethods.GetScriptPath__Args _args = new InternalUnsafeMethods.GetScriptPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetScriptPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the PostEffectAsset class.
        /// </description>
        /// <returns>The type info object for PostEffectAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Path to the script file.
        /// </description>
        /// </value>
        public string ScriptFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("ScriptFile"));
            set => SetFieldValue("ScriptFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the hlsl shader file.
        /// </description>
        /// </value>
        public string HlslShader {
            get => GenericMarshal.StringTo<string>(GetFieldValue("hlslShader"));
            set => SetFieldValue("hlslShader", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Path to the glsl shader file.
        /// </description>
        /// </value>
        public string GlslShader {
            get => GenericMarshal.StringTo<string>(GetFieldValue("glslShader"));
            set => SetFieldValue("glslShader", GenericMarshal.ToString(value));
        }
    }
}
