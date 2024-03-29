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
    /// <summary>A collection of arbitrary objects which can be allocated and manipulated as a group.</summary>
    /// <description>
    /// %Prefab always points to a (.prefab) file which defines its objects. In fact more than one %Prefab can reference this file and both will update if the file is modified.
    /// 
    /// %Prefab is a very simple object and only exists on the server. When it is created it allocates children objects by reading the (.prefab) file like a list of instructions.  It then sets their transform relative to the %Prefab and Torque networking handles the rest by ghosting the new objects to clients. %Prefab itself is not ghosted.
    /// </description>
    public class Prefab : SceneObject {
        public Prefab(bool pRegister = false)
            : base(pRegister) {
        }

        public Prefab(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public Prefab(string pName)
            : this(pName, false) {
        }

        public Prefab(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Prefab(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Prefab(SimObject pObj)
            : base(pObj) {
        }

        public Prefab(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetChildGroup__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetChildGroup(IntPtr _this, GetChildGroup__Args args);
            private static _GetChildGroup _GetChildGroupFunc;
            internal static _GetChildGroup GetChildGroup() {
               _GetChildGroupFunc ??= Torque3D.LookupEngineFunction<_GetChildGroup>("fnPrefab_getChildGroup");

                return _GetChildGroupFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLoad__Args
            {
                internal IntPtr children;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLoad(IntPtr _this, OnLoad__Args args);
            private static _OnLoad _OnLoadFunc;
            internal static _OnLoad OnLoad() {
               _OnLoadFunc ??= Torque3D.LookupEngineFunction<_OnLoad>("cbPrefab_onLoad");

                return _OnLoadFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnPrefab_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnPrefab_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public int GetChildGroup() {
             InternalUnsafeMethods.GetChildGroup__Args _args = new InternalUnsafeMethods.GetChildGroup__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetChildGroup()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Called when the prefab file is loaded and children objects are created.
        /// </description>
        /// <param name="children">SimGroup containing all children objects.</param>
        public virtual void OnLoad(SimGroup children) {
             InternalUnsafeMethods.OnLoad__Args _args = new InternalUnsafeMethods.OnLoad__Args() {
                children = children.ObjectPtr,
             };
             InternalUnsafeMethods.OnLoad()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the Prefab class.
        /// </description>
        /// <returns>The type info object for Prefab</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// (.prefab) File describing objects within this prefab.
        /// </description>
        /// </value>
        public string FileName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("fileName"));
            set => SetFieldValue("fileName", GenericMarshal.ToString(value));
        }
    }
}
