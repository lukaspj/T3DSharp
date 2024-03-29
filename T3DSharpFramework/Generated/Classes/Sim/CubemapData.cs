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
    /// <summary>Used to create static or dynamic cubemaps.</summary>
    /// <description>
    /// This object is used with Material, WaterObject, and other objects for cubemap reflections.
    /// 
    /// A simple declaration of a static cubemap:
    /// </description>
    /// <code>
    /// singleton CubemapData( SkyboxCubemap )
    /// {
    ///    cubeFace[0] = "./skybox_1";
    ///    cubeFace[1] = "./skybox_2";
    ///    cubeFace[2] = "./skybox_3";
    ///    cubeFace[3] = "./skybox_4";
    ///    cubeFace[4] = "./skybox_5";
    ///    cubeFace[5] = "./skybox_6";
    /// };
    /// </code>
    /// <remarks> The dynamic cubemap functionality in CubemapData has been depreciated in favor of ReflectorDesc.
    /// </remarks>
    /// <see cref="ReflectorDesc" />
    public class CubemapData : SimObject {
        public CubemapData(bool pRegister = false)
            : base(pRegister) {
        }

        public CubemapData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public CubemapData(string pName)
            : this(pName, false) {
        }

        public CubemapData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public CubemapData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public CubemapData(SimObject pObj)
            : base(pObj) {
        }

        public CubemapData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Save__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filename;
                internal int format;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Save(IntPtr _this, Save__Args args);
            private static _Save _SaveFunc;
            internal static _Save Save() {
               _SaveFunc ??= Torque3D.LookupEngineFunction<_Save>("fnCubemapData_save");

                return _SaveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFilename__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetFilename(IntPtr _this, GetFilename__Args args);
            private static _GetFilename _GetFilenameFunc;
            internal static _GetFilename GetFilename() {
               _GetFilenameFunc ??= Torque3D.LookupEngineFunction<_GetFilename>("fnCubemapData_getFilename");

                return _GetFilenameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UpdateFaces__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UpdateFaces(IntPtr _this, UpdateFaces__Args args);
            private static _UpdateFaces _UpdateFacesFunc;
            internal static _UpdateFaces UpdateFaces() {
               _UpdateFacesFunc ??= Torque3D.LookupEngineFunction<_UpdateFaces>("fnCubemapData_updateFaces");

                return _UpdateFacesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnCubemapData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnCubemapData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Returns the script filename of where the CubemapData object was defined.  This is used by the material editor.
        /// </description>
        public void Save(string filename = "", GFXFormat format = GFXFormat.GFXFormatBC1) {
             InternalUnsafeMethods.Save__Args _args = new InternalUnsafeMethods.Save__Args() {
                filename = filename,
                format = (int)format,
             };
             InternalUnsafeMethods.Save()(ObjectPtr, _args);
        }

        /// <description>
        /// Returns the script filename of where the CubemapData object was defined.  This is used by the material editor.
        /// </description>
        public string GetFilename() {
             InternalUnsafeMethods.GetFilename__Args _args = new InternalUnsafeMethods.GetFilename__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetFilename()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Update the assigned cubemaps faces.
        /// </description>
        public void UpdateFaces() {
             InternalUnsafeMethods.UpdateFaces__Args _args = new InternalUnsafeMethods.UpdateFaces__Args() {
             };
             InternalUnsafeMethods.UpdateFaces()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the CubemapData class.
        /// </description>
        /// <returns>The type info object for CubemapData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>The 6 cubemap face textures for a static cubemap.</summary>
        /// <description>
        /// They are in the following order:
        ///   - cubeFace[0] is -X
        ///   - cubeFace[1] is +X
        ///   - cubeFace[2] is -Z
        ///   - cubeFace[3] is +Z
        ///   - cubeFace[4] is -Y
        ///   - cubeFace[5] is +Y
        /// </description>
        /// </value>
        public DynamicFieldVector<string> CubeFace {
            get => new DynamicFieldVector<string>(
                    this, 
                    "cubeFace", 
                    6, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>CubeMapFace "</summary>
        /// <summary>The 6 cubemap face textures for a static cubemap.\n\n" "They are in the following order:\n" "  - cubeFace[0] is -X\n" "  - cubeFace[1] is +X\n" "  - cubeFace[2] is -Z\n" "  - cubeFace[3] is +Z\n" "  - cubeFace[4] is -Y\n" "  - cubeFace[5] is +Y\n"</summary>
        /// </value>
        public DynamicFieldVector<string> CubeMapFace {
            get => new DynamicFieldVector<string>(
                    this, 
                    "CubeMapFace", 
                    6, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>CubeMapFace asset "</summary>
        /// <summary>The 6 cubemap face textures for a static cubemap.\n\n" "They are in the following order:\n" "  - cubeFace[0] is -X\n" "  - cubeFace[1] is +X\n" "  - cubeFace[2] is -Z\n" "  - cubeFace[3] is +Z\n" "  - cubeFace[4] is -Y\n" "  - cubeFace[5] is +Y\n".</summary>
        /// </value>
        public DynamicFieldVector<string> CubeMapFaceAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "CubeMapFaceAsset", 
                    6, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>CubeMap "</summary>
        /// <summary>Cubemap dds Image Asset.\n\n"</summary>
        /// </value>
        public string Cubemap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("cubemap"));
            set => SetFieldValue("cubemap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>CubeMap asset "</summary>
        /// <summary>Cubemap dds Image Asset.\n\n".</summary>
        /// </value>
        public string CubemapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("CubemapAsset"));
            set => SetFieldValue("CubemapAsset", GenericMarshal.ToString(value));
        }
    }
}
