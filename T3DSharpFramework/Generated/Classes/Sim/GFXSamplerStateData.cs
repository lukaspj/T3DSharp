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
    /// <summary>A sampler state used by GFXStateBlockData.</summary>
    /// <description>
    /// The samplers define how a texture will be sampled when used from the shader or fixed function device
    /// </description>
    /// <code>
    /// singleton GFXSamplerStateData(SamplerClampLinear)
    /// {
    ///    textureColorOp = GFXTOPModulate;
    ///    addressModeU = GFXAddressClamp;
    ///    addressModeV = GFXAddressClamp;
    ///    addressModeW = GFXAddressClamp;
    ///    magFilter = GFXTextureFilterLinear;
    ///    minFilter = GFXTextureFilterLinear;
    ///    mipFilter = GFXTextureFilterLinear;
    /// };
    /// </code>
    /// <see cref="GFXStateBlockData" />
    public class GFXSamplerStateData : SimObject {
        public GFXSamplerStateData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GFXSamplerStateData(string pName, bool pRegister)
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

        public GFXSamplerStateData(string pName)
            : this(pName, false) {
        }

        public GFXSamplerStateData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GFXSamplerStateData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GFXSamplerStateData(SimObject pObj)
            : base(pObj) {
        }

        public GFXSamplerStateData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGFXSamplerStateData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGFXSamplerStateData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the GFXSamplerStateData class.
        /// </description>
        /// <returns>The type info object for GFXSamplerStateData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// The texture address mode for the u coordinate.  The default is GFXAddressWrap.
        /// </description>
        /// </value>
        public GFXTextureAddressMode AddressModeU {
            get => GenericMarshal.StringTo<GFXTextureAddressMode>(GetFieldValue("addressModeU"));
            set => SetFieldValue("addressModeU", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The texture address mode for the v coordinate.  The default is GFXAddressWrap.
        /// </description>
        /// </value>
        public GFXTextureAddressMode AddressModeV {
            get => GenericMarshal.StringTo<GFXTextureAddressMode>(GetFieldValue("addressModeV"));
            set => SetFieldValue("addressModeV", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The texture address mode for the w coordinate.  The default is GFXAddressWrap.
        /// </description>
        /// </value>
        public GFXTextureAddressMode AddressModeW {
            get => GenericMarshal.StringTo<GFXTextureAddressMode>(GetFieldValue("addressModeW"));
            set => SetFieldValue("addressModeW", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The texture magnification filter.  The default is GFXTextureFilterLinear.
        /// </description>
        /// </value>
        public GFXTextureFilterType MagFilter {
            get => GenericMarshal.StringTo<GFXTextureFilterType>(GetFieldValue("magFilter"));
            set => SetFieldValue("magFilter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The texture minification filter.  The default is GFXTextureFilterLinear.
        /// </description>
        /// </value>
        public GFXTextureFilterType MinFilter {
            get => GenericMarshal.StringTo<GFXTextureFilterType>(GetFieldValue("minFilter"));
            set => SetFieldValue("minFilter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The texture mipmap filter used during minification.  The default is GFXTextureFilterLinear.
        /// </description>
        /// </value>
        public GFXTextureFilterType MipFilter {
            get => GenericMarshal.StringTo<GFXTextureFilterType>(GetFieldValue("mipFilter"));
            set => SetFieldValue("mipFilter", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The mipmap level of detail bias.  The default value is zero.
        /// </description>
        /// </value>
        public float MipLODBias {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mipLODBias"));
            set => SetFieldValue("mipLODBias", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The maximum texture anisotropy.  The default value is 1.
        /// </description>
        /// </value>
        public int MaxAnisotropy {
            get => GenericMarshal.StringTo<int>(GetFieldValue("maxAnisotropy"));
            set => SetFieldValue("maxAnisotropy", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI BorderColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColor"));
            set => SetFieldValue("borderColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Compares sampled data against existing sampled data.  The default is GFXCmpNever.
        /// </description>
        /// </value>
        public GFXCmpFunc SamplerFunc {
            get => GenericMarshal.StringTo<GFXCmpFunc>(GetFieldValue("samplerFunc"));
            set => SetFieldValue("samplerFunc", GenericMarshal.ToString(value));
        }
    }
}
