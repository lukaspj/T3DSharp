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
    /// <summary>A container that allows to view one or more possibly larger controls inside its area by providing horizontal and/or vertical scroll bars.</summary>
    /// <description>
    /// 
    /// </description>
    public class GuiScrollCtrl : GuiContainer {
        public GuiScrollCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiScrollCtrl(string pName, bool pRegister)
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

        public GuiScrollCtrl(string pName)
            : this(pName, false) {
        }

        public GuiScrollCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiScrollCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiScrollCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiScrollCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct ComputeSizes__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ComputeSizes(IntPtr _this, ComputeSizes__Args args);
            private static _ComputeSizes _ComputeSizesFunc;
            internal static _ComputeSizes ComputeSizes() {
               _ComputeSizesFunc ??= Torque3D.LookupEngineFunction<_ComputeSizes>("fnGuiScrollCtrl_computeSizes");

                return _ComputeSizesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetScrollPositionY__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetScrollPositionY(IntPtr _this, GetScrollPositionY__Args args);
            private static _GetScrollPositionY _GetScrollPositionYFunc;
            internal static _GetScrollPositionY GetScrollPositionY() {
               _GetScrollPositionYFunc ??= Torque3D.LookupEngineFunction<_GetScrollPositionY>("fnGuiScrollCtrl_getScrollPositionY");

                return _GetScrollPositionYFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetScrollPositionX__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetScrollPositionX(IntPtr _this, GetScrollPositionX__Args args);
            private static _GetScrollPositionX _GetScrollPositionXFunc;
            internal static _GetScrollPositionX GetScrollPositionX() {
               _GetScrollPositionXFunc ??= Torque3D.LookupEngineFunction<_GetScrollPositionX>("fnGuiScrollCtrl_getScrollPositionX");

                return _GetScrollPositionXFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetScrollPosition__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2I.InternalStruct _GetScrollPosition(IntPtr _this, GetScrollPosition__Args args);
            private static _GetScrollPosition _GetScrollPositionFunc;
            internal static _GetScrollPosition GetScrollPosition() {
               _GetScrollPositionFunc ??= Torque3D.LookupEngineFunction<_GetScrollPosition>("fnGuiScrollCtrl_getScrollPosition");

                return _GetScrollPositionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ScrollToObject__Args
            {
                internal IntPtr control;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ScrollToObject(IntPtr _this, ScrollToObject__Args args);
            private static _ScrollToObject _ScrollToObjectFunc;
            internal static _ScrollToObject ScrollToObject() {
               _ScrollToObjectFunc ??= Torque3D.LookupEngineFunction<_ScrollToObject>("fnGuiScrollCtrl_scrollToObject");

                return _ScrollToObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetScrollPosition__Args
            {
                internal int x;
                internal int y;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetScrollPosition(IntPtr _this, SetScrollPosition__Args args);
            private static _SetScrollPosition _SetScrollPositionFunc;
            internal static _SetScrollPosition SetScrollPosition() {
               _SetScrollPositionFunc ??= Torque3D.LookupEngineFunction<_SetScrollPosition>("fnGuiScrollCtrl_setScrollPosition");

                return _SetScrollPositionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ScrollToBottom__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ScrollToBottom(IntPtr _this, ScrollToBottom__Args args);
            private static _ScrollToBottom _ScrollToBottomFunc;
            internal static _ScrollToBottom ScrollToBottom() {
               _ScrollToBottomFunc ??= Torque3D.LookupEngineFunction<_ScrollToBottom>("fnGuiScrollCtrl_scrollToBottom");

                return _ScrollToBottomFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ScrollToTop__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ScrollToTop(IntPtr _this, ScrollToTop__Args args);
            private static _ScrollToTop _ScrollToTopFunc;
            internal static _ScrollToTop ScrollToTop() {
               _ScrollToTopFunc ??= Torque3D.LookupEngineFunction<_ScrollToTop>("fnGuiScrollCtrl_scrollToTop");

                return _ScrollToTopFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnScroll__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnScroll(IntPtr _this, OnScroll__Args args);
            private static _OnScroll _OnScrollFunc;
            internal static _OnScroll OnScroll() {
               _OnScrollFunc ??= Torque3D.LookupEngineFunction<_OnScroll>("cbGuiScrollCtrl_onScroll");

                return _OnScrollFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiScrollCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiScrollCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Refresh sizing and positioning of child controls.
        /// </description>
        public void ComputeSizes() {
             InternalUnsafeMethods.ComputeSizes__Args _args = new InternalUnsafeMethods.ComputeSizes__Args() {
             };
             InternalUnsafeMethods.ComputeSizes()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the current Y coordinate of the scrolled content.
        /// </description>
        /// <returns>The current Y coordinate of the scrolled content.</returns>
        public int GetScrollPositionY() {
             InternalUnsafeMethods.GetScrollPositionY__Args _args = new InternalUnsafeMethods.GetScrollPositionY__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetScrollPositionY()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the current X coordinate of the scrolled content.
        /// </description>
        /// <returns>The current X coordinate of the scrolled content.</returns>
        public int GetScrollPositionX() {
             InternalUnsafeMethods.GetScrollPositionX__Args _args = new InternalUnsafeMethods.GetScrollPositionX__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetScrollPositionX()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the current coordinates of the scrolled content.
        /// </description>
        /// <returns>The current position of the scrolled content.</returns>
        public Point2I GetScrollPosition() {
             InternalUnsafeMethods.GetScrollPosition__Args _args = new InternalUnsafeMethods.GetScrollPosition__Args() {
             };
             Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetScrollPosition()(ObjectPtr, _args);
             return new Point2I(_engineResult);
        }

        /// <description>
        /// Scroll the control so that the given child<paramref name="" /> control is visible.
        /// 
        /// 
        /// </description>
        /// <param name="control">A child control.</param>
        public void ScrollToObject(GuiControl control) {
             InternalUnsafeMethods.ScrollToObject__Args _args = new InternalUnsafeMethods.ScrollToObject__Args() {
                control = control.ObjectPtr,
             };
             InternalUnsafeMethods.ScrollToObject()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the position of the scrolled content.
        /// </description>
        /// <param name="x">Position on X axis.</param>
        /// <param name="y">Position on y axis.</param>
        public void SetScrollPosition(int x, int y) {
             InternalUnsafeMethods.SetScrollPosition__Args _args = new InternalUnsafeMethods.SetScrollPosition__Args() {
                x = x,
                y = y,
             };
             InternalUnsafeMethods.SetScrollPosition()(ObjectPtr, _args);
        }

        /// <description>
        /// Scroll all the way to the bottom of the vertical scrollbar and the left of the horizontal bar.
        /// </description>
        public void ScrollToBottom() {
             InternalUnsafeMethods.ScrollToBottom__Args _args = new InternalUnsafeMethods.ScrollToBottom__Args() {
             };
             InternalUnsafeMethods.ScrollToBottom()(ObjectPtr, _args);
        }

        /// <description>
        /// Scroll all the way to the top of the vertical and left of the horizontal scrollbar.
        /// </description>
        public void ScrollToTop() {
             InternalUnsafeMethods.ScrollToTop__Args _args = new InternalUnsafeMethods.ScrollToTop__Args() {
             };
             InternalUnsafeMethods.ScrollToTop()(ObjectPtr, _args);
        }

        /// <description>
        /// Called each time the child controls are scrolled by some amount.
        /// </description>
        public virtual void OnScroll() {
             InternalUnsafeMethods.OnScroll__Args _args = new InternalUnsafeMethods.OnScroll__Args() {
             };
             InternalUnsafeMethods.OnScroll()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiScrollCtrl class.
        /// </description>
        /// <returns>The type info object for GuiScrollCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public bool WillFirstRespond {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("willFirstRespond"));
            set => SetFieldValue("willFirstRespond", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// When to display the horizontal scrollbar.
        /// </description>
        /// </value>
        public GuiScrollBarBehavior HScrollBar {
            get => GenericMarshal.StringTo<GuiScrollBarBehavior>(GetFieldValue("hScrollBar"));
            set => SetFieldValue("hScrollBar", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// When to display the vertical scrollbar.
        /// </description>
        /// </value>
        public GuiScrollBarBehavior VScrollBar {
            get => GenericMarshal.StringTo<GuiScrollBarBehavior>(GetFieldValue("vScrollBar"));
            set => SetFieldValue("vScrollBar", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Horizontal scrolling not allowed if set.
        /// </description>
        /// </value>
        public bool LockHorizScroll {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("lockHorizScroll"));
            set => SetFieldValue("lockHorizScroll", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Vertical scrolling not allowed if set.
        /// </description>
        /// </value>
        public bool LockVertScroll {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("lockVertScroll"));
            set => SetFieldValue("lockVertScroll", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool ConstantThumbHeight {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("constantThumbHeight"));
            set => SetFieldValue("constantThumbHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Padding region to put around child contents.
        /// </description>
        /// </value>
        public Point2I ChildMargin {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("childMargin"));
            set => SetFieldValue("childMargin", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Pixels/Tick - if not positive then mousewheel scrolling occurs instantly (like other scrolling).
        /// </description>
        /// </value>
        public int MouseWheelScrollSpeed {
            get => GenericMarshal.StringTo<int>(GetFieldValue("mouseWheelScrollSpeed"));
            set => SetFieldValue("mouseWheelScrollSpeed", GenericMarshal.ToString(value));
        }
    }
}
