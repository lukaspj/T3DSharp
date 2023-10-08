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
    /// <summary>A container that shows a single child with an optional header bar that can be used to collapse and expand the rollout.</summary>
    /// <description>
    /// A rollout is a container that can be collapsed and expanded using smooth animation.  By default, rollouts will display a header with a caption along the top edge of the control which can be clicked by the user to toggle the collapse state of the rollout.
    /// 
    /// Rollouts will automatically size themselves to exactly fit around their child control.  They will also automatically position their child control in their upper left corner below the header (if present).
    /// </description>
    /// <remarks> GuiRolloutCtrls will only work correctly with a single child control.  To put multiple controls in a rollout, put them in their own group using a new GuiControl which then can be put inside the rollout.
    /// 
    /// </remarks>
    public class GuiRolloutCtrl : GuiControl {
        public GuiRolloutCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiRolloutCtrl(string pName, bool pRegister)
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

        public GuiRolloutCtrl(string pName)
            : this(pName, false) {
        }

        public GuiRolloutCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiRolloutCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiRolloutCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiRolloutCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SizeToContents__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SizeToContents(IntPtr _this, SizeToContents__Args args);
            private static _SizeToContents _SizeToContentsFunc;
            internal static _SizeToContents SizeToContents() {
               _SizeToContentsFunc ??= Torque3D.LookupEngineFunction<_SizeToContents>("fnGuiRolloutCtrl_sizeToContents");

                return _SizeToContentsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct InstantExpand__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _InstantExpand(IntPtr _this, InstantExpand__Args args);
            private static _InstantExpand _InstantExpandFunc;
            internal static _InstantExpand InstantExpand() {
               _InstantExpandFunc ??= Torque3D.LookupEngineFunction<_InstantExpand>("fnGuiRolloutCtrl_instantExpand");

                return _InstantExpandFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct InstantCollapse__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _InstantCollapse(IntPtr _this, InstantCollapse__Args args);
            private static _InstantCollapse _InstantCollapseFunc;
            internal static _InstantCollapse InstantCollapse() {
               _InstantCollapseFunc ??= Torque3D.LookupEngineFunction<_InstantCollapse>("fnGuiRolloutCtrl_instantCollapse");

                return _InstantCollapseFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ToggleExpanded__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool instantly;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ToggleExpanded(IntPtr _this, ToggleExpanded__Args args);
            private static _ToggleExpanded _ToggleExpandedFunc;
            internal static _ToggleExpanded ToggleExpanded() {
               _ToggleExpandedFunc ??= Torque3D.LookupEngineFunction<_ToggleExpanded>("fnGuiRolloutCtrl_toggleExpanded");

                return _ToggleExpandedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ToggleCollapse__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ToggleCollapse(IntPtr _this, ToggleCollapse__Args args);
            private static _ToggleCollapse _ToggleCollapseFunc;
            internal static _ToggleCollapse ToggleCollapse() {
               _ToggleCollapseFunc ??= Torque3D.LookupEngineFunction<_ToggleCollapse>("fnGuiRolloutCtrl_toggleCollapse");

                return _ToggleCollapseFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Expand__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Expand(IntPtr _this, Expand__Args args);
            private static _Expand _ExpandFunc;
            internal static _Expand Expand() {
               _ExpandFunc ??= Torque3D.LookupEngineFunction<_Expand>("fnGuiRolloutCtrl_expand");

                return _ExpandFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Collapse__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Collapse(IntPtr _this, Collapse__Args args);
            private static _Collapse _CollapseFunc;
            internal static _Collapse Collapse() {
               _CollapseFunc ??= Torque3D.LookupEngineFunction<_Collapse>("fnGuiRolloutCtrl_collapse");

                return _CollapseFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsExpanded__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsExpanded(IntPtr _this, IsExpanded__Args args);
            private static _IsExpanded _IsExpandedFunc;
            internal static _IsExpanded IsExpanded() {
               _IsExpandedFunc ??= Torque3D.LookupEngineFunction<_IsExpanded>("fnGuiRolloutCtrl_isExpanded");

                return _IsExpandedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnCollapsed__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnCollapsed(IntPtr _this, OnCollapsed__Args args);
            private static _OnCollapsed _OnCollapsedFunc;
            internal static _OnCollapsed OnCollapsed() {
               _OnCollapsedFunc ??= Torque3D.LookupEngineFunction<_OnCollapsed>("cbGuiRolloutCtrl_onCollapsed");

                return _OnCollapsedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnExpanded__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnExpanded(IntPtr _this, OnExpanded__Args args);
            private static _OnExpanded _OnExpandedFunc;
            internal static _OnExpanded OnExpanded() {
               _OnExpandedFunc ??= Torque3D.LookupEngineFunction<_OnExpanded>("cbGuiRolloutCtrl_onExpanded");

                return _OnExpandedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnHeaderRightClick__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnHeaderRightClick(IntPtr _this, OnHeaderRightClick__Args args);
            private static _OnHeaderRightClick _OnHeaderRightClickFunc;
            internal static _OnHeaderRightClick OnHeaderRightClick() {
               _OnHeaderRightClickFunc ??= Torque3D.LookupEngineFunction<_OnHeaderRightClick>("cbGuiRolloutCtrl_onHeaderRightClick");

                return _OnHeaderRightClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiRolloutCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiRolloutCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Resize the rollout to exactly fit around its child control.  This can be used to manually trigger a recomputation of the rollout size.
        /// </description>
        public void SizeToContents() {
             InternalUnsafeMethods.SizeToContents__Args _args = new InternalUnsafeMethods.SizeToContents__Args() {
             };
             InternalUnsafeMethods.SizeToContents()(ObjectPtr, _args);
        }

        /// <description>
        /// Instantly expand the rollout without animation.  To smoothly slide the rollout to expanded state, use expand().
        /// </description>
        public void InstantExpand() {
             InternalUnsafeMethods.InstantExpand__Args _args = new InternalUnsafeMethods.InstantExpand__Args() {
             };
             InternalUnsafeMethods.InstantExpand()(ObjectPtr, _args);
        }

        /// <description>
        /// Instantly collapse the rollout without animation.  To smoothly slide the rollout to collapsed state, use collapse().
        /// </description>
        public void InstantCollapse() {
             InternalUnsafeMethods.InstantCollapse__Args _args = new InternalUnsafeMethods.InstantCollapse__Args() {
             };
             InternalUnsafeMethods.InstantCollapse()(ObjectPtr, _args);
        }

        /// <description>
        /// Toggle the current expansion state of the rollout  If it is currently expanded, then collapse it.  If it is currently collapsed, then expand it.
        /// </description>
        /// <param name="instant">If true, the rollout will toggle its state without animation.  Otherwise, the rollout will smoothly slide into the opposite state.</param>
        public void ToggleExpanded(bool instantly = false) {
             InternalUnsafeMethods.ToggleExpanded__Args _args = new InternalUnsafeMethods.ToggleExpanded__Args() {
                instantly = instantly,
             };
             InternalUnsafeMethods.ToggleExpanded()(ObjectPtr, _args);
        }

        /// <description>
        /// Toggle the current collapse state of the rollout.  If it is currently expanded, then collapse it.  If it is currently collapsed, then expand it.
        /// </description>
        public void ToggleCollapse() {
             InternalUnsafeMethods.ToggleCollapse__Args _args = new InternalUnsafeMethods.ToggleCollapse__Args() {
             };
             InternalUnsafeMethods.ToggleCollapse()(ObjectPtr, _args);
        }

        /// <description>
        /// Expand the rollout if it is currently collapsed.  This will make the rollout's child control visible.
        /// </description>
        /// <remarks> The rollout will animate to expanded state.  To instantly expand without animation, use instantExpand().</remarks>
        public void Expand() {
             InternalUnsafeMethods.Expand__Args _args = new InternalUnsafeMethods.Expand__Args() {
             };
             InternalUnsafeMethods.Expand()(ObjectPtr, _args);
        }

        /// <description>
        /// Collapse the rollout if it is currently expanded.  This will make the rollout's child control invisible.
        /// </description>
        /// <remarks> The rollout will animate to collapsed state.  To instantly collapse without animation, use instantCollapse().</remarks>
        public void Collapse() {
             InternalUnsafeMethods.Collapse__Args _args = new InternalUnsafeMethods.Collapse__Args() {
             };
             InternalUnsafeMethods.Collapse()(ObjectPtr, _args);
        }

        /// <description>
        /// Determine whether the rollout is currently expanded, i.e. whether the child control is visible.
        /// </description>
        /// <returns>True if the rollout is expanded, false if not.</returns>
        public bool IsExpanded() {
             InternalUnsafeMethods.IsExpanded__Args _args = new InternalUnsafeMethods.IsExpanded__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsExpanded()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Called when the rollout is collapsed.
        /// </description>
        public virtual void OnCollapsed() {
             InternalUnsafeMethods.OnCollapsed__Args _args = new InternalUnsafeMethods.OnCollapsed__Args() {
             };
             InternalUnsafeMethods.OnCollapsed()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the rollout is expanded.
        /// </description>
        public virtual void OnExpanded() {
             InternalUnsafeMethods.OnExpanded__Args _args = new InternalUnsafeMethods.OnExpanded__Args() {
             };
             InternalUnsafeMethods.OnExpanded()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the user right-clicks on the rollout's header.  This is useful for implementing context menus for rollouts.
        /// </description>
        public virtual void OnHeaderRightClick() {
             InternalUnsafeMethods.OnHeaderRightClick__Args _args = new InternalUnsafeMethods.OnHeaderRightClick__Args() {
             };
             InternalUnsafeMethods.OnHeaderRightClick()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiRolloutCtrl class.
        /// </description>
        /// <returns>The type info object for GuiRolloutCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Text label to display on the rollout header.
        /// </description>
        /// </value>
        public string Caption {
            get => GenericMarshal.StringTo<string>(GetFieldValue("caption"));
            set => SetFieldValue("caption", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Margin to put around child control.
        /// </description>
        /// </value>
        public RectI Margin {
            get => GenericMarshal.StringTo<RectI>(GetFieldValue("margin"));
            set => SetFieldValue("margin", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Default height of the client area.  This is used when no child control has been added to the rollout.
        /// </description>
        /// </value>
        public int DefaultHeight {
            get => GenericMarshal.StringTo<int>(GetFieldValue("defaultHeight"));
            set => SetFieldValue("defaultHeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The current rollout expansion state.
        /// </description>
        /// </value>
        public bool Expanded {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("expanded"));
            set => SetFieldValue("expanded", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether the rollout can be collapsed by clicking its header.
        /// </description>
        /// </value>
        public bool ClickCollapse {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("clickCollapse"));
            set => SetFieldValue("clickCollapse", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to render the rollout header.
        /// </description>
        /// <remarks> If this is false, the user cannot toggle the rollout state with the mouse.</remarks>
        /// </value>
        public bool HideHeader {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("hideHeader"));
            set => SetFieldValue("hideHeader", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Whether to automatically collapse sibling rollouts.
        /// 
        /// If this is true, the rollout will automatically collapse all sibling rollout controls when it is expanded.  If this is false, the auto-collapse behavior can be triggered by CTRL (CMD on MAC) clicking the rollout header.  CTRL/CMD clicking also works if this is false, in which case the auto-collapsing of sibling controls will be temporarily deactivated.
        /// </description>
        /// </value>
        public bool AutoCollapseSiblings {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoCollapseSiblings"));
            set => SetFieldValue("autoCollapseSiblings", GenericMarshal.ToString(value));
        }
    }
}
