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
    /// <summary>Inspector field type for Material Asset Objects</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public unsafe class GuiInspectorTypeMaterialAssetPtr : GuiInspectorField {
        public GuiInspectorTypeMaterialAssetPtr(bool pRegister = false) 
            : base(pRegister) {
        }
        
        public GuiInspectorTypeMaterialAssetPtr(string pName, bool pRegister) 
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }
        
        public GuiInspectorTypeMaterialAssetPtr(string pName) 
            : this(pName, false) {
        }
        
        public GuiInspectorTypeMaterialAssetPtr(string pName, string pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }
        
        public GuiInspectorTypeMaterialAssetPtr(string pName, SimObject pParent, bool pRegister = false) 
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }
        
        public GuiInspectorTypeMaterialAssetPtr(SimObject pObj) 
            : base(pObj) {
        }
        
        public GuiInspectorTypeMaterialAssetPtr(IntPtr pObj) 
            : base(pObj) {
        }
        
		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMaterialAsset__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMaterialAsset(IntPtr _this, SetMaterialAsset__Args args);
            private static _SetMaterialAsset _SetMaterialAssetFunc;
            internal static _SetMaterialAsset SetMaterialAsset() {
                if (_SetMaterialAssetFunc == null) {
                    _SetMaterialAssetFunc =
                        (_SetMaterialAsset)Marshal.GetDelegateForFunctionPointer(
                            NativeLibrary.GetExport(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorTypeMaterialAssetPtr_setMaterialAsset"), typeof(_SetMaterialAsset));
                }
                
                return _SetMaterialAssetFunc;
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
                if (_StaticGetTypeFunc == null) {
                    _StaticGetTypeFunc =
                        (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                            NativeLibrary.GetExport(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorTypeMaterialAssetPtr_staticGetType"), typeof(_StaticGetType));
                }
                
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
                if (_CreateFunc == null) {
                    _CreateFunc =
                        (_Create)Marshal.GetDelegateForFunctionPointer(
                            NativeLibrary.GetExport(
                                Torque3D.Torque3DLibHandle,
                                "fnGuiInspectorTypeMaterialAssetPtr_create"), typeof(_Create));
                }
                
                return _CreateFunc;
            }
        }
        #endregion

        /// <description>
        /// Gets a particular shape animation asset for this shape.
        /// </description>
        /// <param name="animation">asset index.</param>
        /// <returns>Shape Animation Asset.</returns>
        public void SetMaterialAsset(string assetId = "") {
             InternalUnsafeMethods.SetMaterialAsset__Args _args = new InternalUnsafeMethods.SetMaterialAsset__Args() {
                assetId = assetId,
             };
             InternalUnsafeMethods.SetMaterialAsset()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiInspectorTypeMaterialAssetPtr class.
        /// </description>
        /// <returns>The type info object for GuiInspectorTypeMaterialAssetPtr</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}