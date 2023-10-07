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
    /// <summary>A generic form control.</summary>
    /// <description>
    /// Currently editor use only.
    /// </description>
    public class GuiFormCtrl : GuiPanel {
        public GuiFormCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiFormCtrl(string pName, bool pRegister)
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

        public GuiFormCtrl(string pName)
            : this(pName, false) {
        }

        public GuiFormCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiFormCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiFormCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiFormCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCaption__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string caption;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCaption(IntPtr _this, SetCaption__Args args);
            private static _SetCaption _SetCaptionFunc;
            internal static _SetCaption SetCaption() {
               _SetCaptionFunc ??= Torque3D.LookupEngineFunction<_SetCaption>("fnGuiFormCtrl_setCaption");

                return _SetCaptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMenuID__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMenuID(IntPtr _this, GetMenuID__Args args);
            private static _GetMenuID _GetMenuIDFunc;
            internal static _GetMenuID GetMenuID() {
               _GetMenuIDFunc ??= Torque3D.LookupEngineFunction<_GetMenuID>("fnGuiFormCtrl_getMenuID");

                return _GetMenuIDFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnResize__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnResize(IntPtr _this, OnResize__Args args);
            private static _OnResize _OnResizeFunc;
            internal static _OnResize OnResize() {
               _OnResizeFunc ??= Torque3D.LookupEngineFunction<_OnResize>("cbGuiFormCtrl_onResize");

                return _OnResizeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiFormCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiFormCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Sets the title of the form.
        /// </description>
        /// <param name="caption">Form caption</param>
        public void SetCaption(string caption) {
             InternalUnsafeMethods.SetCaption__Args _args = new InternalUnsafeMethods.SetCaption__Args() {
                caption = caption,
             };
             InternalUnsafeMethods.SetCaption()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the ID of this form's menu.
        /// </description>
        /// <returns>The ID of the form menu</returns>
        public int GetMenuID() {
             InternalUnsafeMethods.GetMenuID__Args _args = new InternalUnsafeMethods.GetMenuID__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetMenuID()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Called when the control is resized.
        /// </description>
        public virtual void OnResize() {
             InternalUnsafeMethods.OnResize__Args _args = new InternalUnsafeMethods.OnResize__Args() {
             };
             InternalUnsafeMethods.OnResize()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiFormCtrl class.
        /// </description>
        /// <returns>The type info object for GuiFormCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public string Caption {
            get => GenericMarshal.StringTo<string>(GetFieldValue("caption"));
            set => SetFieldValue("caption", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string ContentLibrary {
            get => GenericMarshal.StringTo<string>(GetFieldValue("contentLibrary"));
            set => SetFieldValue("contentLibrary", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string Content {
            get => GenericMarshal.StringTo<string>(GetFieldValue("content"));
            set => SetFieldValue("content", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool Movable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("movable"));
            set => SetFieldValue("movable", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool HasMenu {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hasMenu"));
            set => SetFieldValue("hasMenu", GenericMarshal.ToString(value));
        }
    }
}
