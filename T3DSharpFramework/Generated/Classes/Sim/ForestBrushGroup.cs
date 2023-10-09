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
    /// <summary>Container class for ForestBrushes</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class ForestBrushGroup : SimGroup {
        public ForestBrushGroup(bool pRegister = false)
            : base(pRegister) {
        }

        public ForestBrushGroup(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public ForestBrushGroup(string pName)
            : this(pName, false) {
        }

        public ForestBrushGroup(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ForestBrushGroup(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ForestBrushGroup(SimObject pObj)
            : base(pObj) {
        }

        public ForestBrushGroup(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ContainsBrushData__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string obj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _ContainsBrushData(IntPtr _this, ContainsBrushData__Args args);
            private static _ContainsBrushData _ContainsBrushDataFunc;
            internal static _ContainsBrushData ContainsBrushData() {
               _ContainsBrushDataFunc ??= Torque3D.LookupEngineFunction<_ContainsBrushData>("fnForestBrushGroup_containsBrushData");

                return _ContainsBrushDataFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnForestBrushGroup_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnForestBrushGroup_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// ( ForestBrush obj )
        /// </description>
        public bool ContainsBrushData(string obj) {
             InternalUnsafeMethods.ContainsBrushData__Args _args = new InternalUnsafeMethods.ContainsBrushData__Args() {
                obj = obj,
             };
             bool _engineResult = InternalUnsafeMethods.ContainsBrushData()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the ForestBrushGroup class.
        /// </description>
        /// <returns>The type info object for ForestBrushGroup</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
