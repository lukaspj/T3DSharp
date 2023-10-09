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
    /// <summary>Very old GUI used for terrain preview</summary>
    /// <description>
    /// Deprecated
    /// </description>
    public class GuiTerrPreviewCtrl : GuiControl {
        public GuiTerrPreviewCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiTerrPreviewCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiTerrPreviewCtrl(string pName)
            : this(pName, false) {
        }

        public GuiTerrPreviewCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiTerrPreviewCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiTerrPreviewCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiTerrPreviewCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetValue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string tuple;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetValue(IntPtr _this, SetValue__Args args);
            private static _SetValue _SetValueFunc;
            internal static _SetValue SetValue() {
               _SetValueFunc ??= Torque3D.LookupEngineFunction<_SetValue>("fnGuiTerrPreviewCtrl_setValue");

                return _SetValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetValue__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetValue(IntPtr _this, GetValue__Args args);
            private static _GetValue _GetValueFunc;
            internal static _GetValue GetValue() {
               _GetValueFunc ??= Torque3D.LookupEngineFunction<_GetValue>("fnGuiTerrPreviewCtrl_getValue");

                return _GetValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetOrigin__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2F.InternalStruct _GetOrigin(IntPtr _this, GetOrigin__Args args);
            private static _GetOrigin _GetOriginFunc;
            internal static _GetOrigin GetOrigin() {
               _GetOriginFunc ??= Torque3D.LookupEngineFunction<_GetOrigin>("fnGuiTerrPreviewCtrl_getOrigin");

                return _GetOriginFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetOrigin__Args
            {
                internal IntPtr pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetOrigin(IntPtr _this, SetOrigin__Args args);
            private static _SetOrigin _SetOriginFunc;
            internal static _SetOrigin SetOrigin() {
               _SetOriginFunc ??= Torque3D.LookupEngineFunction<_SetOrigin>("fnGuiTerrPreviewCtrl_setOrigin");

                return _SetOriginFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRoot__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2F.InternalStruct _GetRoot(IntPtr _this, GetRoot__Args args);
            private static _GetRoot _GetRootFunc;
            internal static _GetRoot GetRoot() {
               _GetRootFunc ??= Torque3D.LookupEngineFunction<_GetRoot>("fnGuiTerrPreviewCtrl_getRoot");

                return _GetRootFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRoot__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRoot(IntPtr _this, SetRoot__Args args);
            private static _SetRoot _SetRootFunc;
            internal static _SetRoot SetRoot() {
               _SetRootFunc ??= Torque3D.LookupEngineFunction<_SetRoot>("fnGuiTerrPreviewCtrl_setRoot");

                return _SetRootFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
               _ResetFunc ??= Torque3D.LookupEngineFunction<_Reset>("fnGuiTerrPreviewCtrl_reset");

                return _ResetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiTerrPreviewCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiTerrPreviewCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Accepts a 4-tuple in the same form as getValue returns.
        /// </description>
        /// <see cref="GuiTerrPreviewCtrl::getValue()" />
        public void SetValue(string tuple) {
             InternalUnsafeMethods.SetValue__Args _args = new InternalUnsafeMethods.SetValue__Args() {
                tuple = tuple,
             };
             InternalUnsafeMethods.SetValue()(ObjectPtr, _args);
        }

        /// <description>
        /// Returns a 4-tuple containing: root_x root_y origin_x origin_y
        /// </description>
        public string GetValue() {
             InternalUnsafeMethods.GetValue__Args _args = new InternalUnsafeMethods.GetValue__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetValue()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Return a Point2F containing the position of the origin.
        /// </description>
        public Point2F GetOrigin() {
             InternalUnsafeMethods.GetOrigin__Args _args = new InternalUnsafeMethods.GetOrigin__Args() {
             };
             Point2F.InternalStruct _engineResult = InternalUnsafeMethods.GetOrigin()(ObjectPtr, _args);
             return new Point2F(_engineResult);
        }

        /// <description>
        /// (float x, float y)Set the origin of the view.
        /// </description>
        public void SetOrigin(Point2F pos) {
pos.Alloc();             InternalUnsafeMethods.SetOrigin__Args _args = new InternalUnsafeMethods.SetOrigin__Args() {
                pos = pos.internalStructPtr,
             };
             InternalUnsafeMethods.SetOrigin()(ObjectPtr, _args);
pos.Free();        }

        /// <description>
        /// Return a Point2F representing the position of the root.
        /// </description>
        public Point2F GetRoot() {
             InternalUnsafeMethods.GetRoot__Args _args = new InternalUnsafeMethods.GetRoot__Args() {
             };
             Point2F.InternalStruct _engineResult = InternalUnsafeMethods.GetRoot()(ObjectPtr, _args);
             return new Point2F(_engineResult);
        }

        /// <description>
        /// Add the origin to the root and reset the origin.
        /// </description>
        public void SetRoot() {
             InternalUnsafeMethods.SetRoot__Args _args = new InternalUnsafeMethods.SetRoot__Args() {
             };
             InternalUnsafeMethods.SetRoot()(ObjectPtr, _args);
        }

        /// <description>
        /// Reset the view of the terrain.
        /// </description>
        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiTerrPreviewCtrl class.
        /// </description>
        /// <returns>The type info object for GuiTerrPreviewCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
