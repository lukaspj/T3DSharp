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
    /// <summary>Unimplemented GUI control meant to interact with Toolbox.</summary>
    /// <description>
    /// For Torque 3D editors only, soon to be deprecated
    /// </description>
    public class GuiToolboxButtonCtrl : GuiButtonCtrl {
        public GuiToolboxButtonCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiToolboxButtonCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiToolboxButtonCtrl(string pName)
            : this(pName, false) {
        }

        public GuiToolboxButtonCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiToolboxButtonCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiToolboxButtonCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiToolboxButtonCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetHoverBitmap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetHoverBitmap(IntPtr _this, SetHoverBitmap__Args args);
            private static _SetHoverBitmap _SetHoverBitmapFunc;
            internal static _SetHoverBitmap SetHoverBitmap() {
               _SetHoverBitmapFunc ??= Torque3D.LookupEngineFunction<_SetHoverBitmap>("fnGuiToolboxButtonCtrl_setHoverBitmap");

                return _SetHoverBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetHoverBitmapAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetHoverBitmapAsset(IntPtr _this, GetHoverBitmapAsset__Args args);
            private static _GetHoverBitmapAsset _GetHoverBitmapAssetFunc;
            internal static _GetHoverBitmapAsset GetHoverBitmapAsset() {
               _GetHoverBitmapAssetFunc ??= Torque3D.LookupEngineFunction<_GetHoverBitmapAsset>("fnGuiToolboxButtonCtrl_getHoverBitmapAsset");

                return _GetHoverBitmapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetHoverBitmap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetHoverBitmap(IntPtr _this, GetHoverBitmap__Args args);
            private static _GetHoverBitmap _GetHoverBitmapFunc;
            internal static _GetHoverBitmap GetHoverBitmap() {
               _GetHoverBitmapFunc ??= Torque3D.LookupEngineFunction<_GetHoverBitmap>("fnGuiToolboxButtonCtrl_getHoverBitmap");

                return _GetHoverBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetLoweredBitmap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetLoweredBitmap(IntPtr _this, SetLoweredBitmap__Args args);
            private static _SetLoweredBitmap _SetLoweredBitmapFunc;
            internal static _SetLoweredBitmap SetLoweredBitmap() {
               _SetLoweredBitmapFunc ??= Torque3D.LookupEngineFunction<_SetLoweredBitmap>("fnGuiToolboxButtonCtrl_setLoweredBitmap");

                return _SetLoweredBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLoweredBitmapAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLoweredBitmapAsset(IntPtr _this, GetLoweredBitmapAsset__Args args);
            private static _GetLoweredBitmapAsset _GetLoweredBitmapAssetFunc;
            internal static _GetLoweredBitmapAsset GetLoweredBitmapAsset() {
               _GetLoweredBitmapAssetFunc ??= Torque3D.LookupEngineFunction<_GetLoweredBitmapAsset>("fnGuiToolboxButtonCtrl_getLoweredBitmapAsset");

                return _GetLoweredBitmapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLoweredBitmap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLoweredBitmap(IntPtr _this, GetLoweredBitmap__Args args);
            private static _GetLoweredBitmap _GetLoweredBitmapFunc;
            internal static _GetLoweredBitmap GetLoweredBitmap() {
               _GetLoweredBitmapFunc ??= Torque3D.LookupEngineFunction<_GetLoweredBitmap>("fnGuiToolboxButtonCtrl_getLoweredBitmap");

                return _GetLoweredBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetNormalBitmap__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string assetName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetNormalBitmap(IntPtr _this, SetNormalBitmap__Args args);
            private static _SetNormalBitmap _SetNormalBitmapFunc;
            internal static _SetNormalBitmap SetNormalBitmap() {
               _SetNormalBitmapFunc ??= Torque3D.LookupEngineFunction<_SetNormalBitmap>("fnGuiToolboxButtonCtrl_setNormalBitmap");

                return _SetNormalBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNormalBitmapAsset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNormalBitmapAsset(IntPtr _this, GetNormalBitmapAsset__Args args);
            private static _GetNormalBitmapAsset _GetNormalBitmapAssetFunc;
            internal static _GetNormalBitmapAsset GetNormalBitmapAsset() {
               _GetNormalBitmapAssetFunc ??= Torque3D.LookupEngineFunction<_GetNormalBitmapAsset>("fnGuiToolboxButtonCtrl_getNormalBitmapAsset");

                return _GetNormalBitmapAssetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetNormalBitmap__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetNormalBitmap(IntPtr _this, GetNormalBitmap__Args args);
            private static _GetNormalBitmap _GetNormalBitmapFunc;
            internal static _GetNormalBitmap GetNormalBitmap() {
               _GetNormalBitmapFunc ??= Torque3D.LookupEngineFunction<_GetNormalBitmap>("fnGuiToolboxButtonCtrl_getNormalBitmap");

                return _GetNormalBitmapFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiToolboxButtonCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiToolboxButtonCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// HoverBitmapassignment. first tries asset then flat file.
        /// </description>
        public bool SetHoverBitmap(string assetName) {
             InternalUnsafeMethods.SetHoverBitmap__Args _args = new InternalUnsafeMethods.SetHoverBitmap__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetHoverBitmap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// HoverBitmapasset reference
        /// </description>
        public string GetHoverBitmapAsset() {
             InternalUnsafeMethods.GetHoverBitmapAsset__Args _args = new InternalUnsafeMethods.GetHoverBitmapAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetHoverBitmapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetHoverBitmap() {
             InternalUnsafeMethods.GetHoverBitmap__Args _args = new InternalUnsafeMethods.GetHoverBitmap__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetHoverBitmap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// LoweredBitmapassignment. first tries asset then flat file.
        /// </description>
        public bool SetLoweredBitmap(string assetName) {
             InternalUnsafeMethods.SetLoweredBitmap__Args _args = new InternalUnsafeMethods.SetLoweredBitmap__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetLoweredBitmap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// LoweredBitmapasset reference
        /// </description>
        public string GetLoweredBitmapAsset() {
             InternalUnsafeMethods.GetLoweredBitmapAsset__Args _args = new InternalUnsafeMethods.GetLoweredBitmapAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLoweredBitmapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetLoweredBitmap() {
             InternalUnsafeMethods.GetLoweredBitmap__Args _args = new InternalUnsafeMethods.GetLoweredBitmap__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLoweredBitmap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// NormalBitmapassignment. first tries asset then flat file.
        /// </description>
        public bool SetNormalBitmap(string assetName) {
             InternalUnsafeMethods.SetNormalBitmap__Args _args = new InternalUnsafeMethods.SetNormalBitmap__Args() {
                assetName = assetName,
             };
             bool _engineResult = InternalUnsafeMethods.SetNormalBitmap()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// NormalBitmapasset reference
        /// </description>
        public string GetNormalBitmapAsset() {
             InternalUnsafeMethods.GetNormalBitmapAsset__Args _args = new InternalUnsafeMethods.GetNormalBitmapAsset__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNormalBitmapAsset()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// get name
        /// </description>
        public string GetNormalBitmap() {
             InternalUnsafeMethods.GetNormalBitmap__Args _args = new InternalUnsafeMethods.GetNormalBitmap__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetNormalBitmap()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the GuiToolboxButtonCtrl class.
        /// </description>
        /// <returns>The type info object for GuiToolboxButtonCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <summary>NormalBitmap ""</summary>
        /// </value>
        public string NormalBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("NormalBitmap"));
            set => SetFieldValue("NormalBitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>NormalBitmap asset "".</summary>
        /// </value>
        public string NormalBitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("NormalBitmapAsset"));
            set => SetFieldValue("NormalBitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>LoweredBitmap ""</summary>
        /// </value>
        public string LoweredBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("LoweredBitmap"));
            set => SetFieldValue("LoweredBitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>LoweredBitmap asset "".</summary>
        /// </value>
        public string LoweredBitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("LoweredBitmapAsset"));
            set => SetFieldValue("LoweredBitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>HoverBitmap ""</summary>
        /// </value>
        public string HoverBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("HoverBitmap"));
            set => SetFieldValue("HoverBitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>HoverBitmap asset "".</summary>
        /// </value>
        public string HoverBitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("HoverBitmapAsset"));
            set => SetFieldValue("HoverBitmapAsset", GenericMarshal.ToString(value));
        }
    }
}
