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
    /// <summary>A gui control allowing a window to be subdivided into panes, each of which displays a gui control child of the GuiFrameSetCtrl.</summary>
    /// <description>
    /// Each gui control child will have an associated FrameDetail through which frame-specific details can be assigned. Frame-specific values override the values specified for the entire frameset.
    /// 
    /// Note that it is possible to have more children than frames, or more frames than children. In the former case, the extra children will not be visible (they are moved beyond the visible extent of the frameset). In the latter case, frames will be empty. For example, if a frameset had two columns and two rows but only three gui control children they would be assigned to frames as follows:
    /// <pre>
    ///                  1 | 2
    ///                  -----
    ///                  3 |
    /// </pre>
    /// The last frame would be blank.
    /// </description>
    /// <code>
    /// new GuiFrameSetCtrl()
    /// {
    ///    columns = "3";
    ///    rows = "2";
    ///    borderWidth = "1";
    ///    borderColor = "128 128 128";
    ///    borderEnable = "dynamic";
    ///    borderMovable = "dynamic";
    ///    autoBalance = "1";
    ///    fudgeFactor = "0";
    ///    //Properties not specific to this control have been omitted from this example.
    /// };
    /// </code>
    public class GuiFrameSetCtrl : GuiContainer {
        public GuiFrameSetCtrl(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiFrameSetCtrl(string pName, bool pRegister)
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

        public GuiFrameSetCtrl(string pName)
            : this(pName, false) {
        }

        public GuiFrameSetCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiFrameSetCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiFrameSetCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiFrameSetCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct UpdateSizes__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UpdateSizes(IntPtr _this, UpdateSizes__Args args);
            private static _UpdateSizes _UpdateSizesFunc;
            internal static _UpdateSizes UpdateSizes() {
               _UpdateSizesFunc ??= Torque3D.LookupEngineFunction<_UpdateSizes>("fnGuiFrameSetCtrl_updateSizes");

                return _UpdateSizesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetRowOffset__Args
            {
                internal int index;
                internal int offset;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetRowOffset(IntPtr _this, SetRowOffset__Args args);
            private static _SetRowOffset _SetRowOffsetFunc;
            internal static _SetRowOffset SetRowOffset() {
               _SetRowOffsetFunc ??= Torque3D.LookupEngineFunction<_SetRowOffset>("fnGuiFrameSetCtrl_setRowOffset");

                return _SetRowOffsetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetColumnOffset__Args
            {
                internal int index;
                internal int offset;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetColumnOffset(IntPtr _this, SetColumnOffset__Args args);
            private static _SetColumnOffset _SetColumnOffsetFunc;
            internal static _SetColumnOffset SetColumnOffset() {
               _SetColumnOffsetFunc ??= Torque3D.LookupEngineFunction<_SetColumnOffset>("fnGuiFrameSetCtrl_setColumnOffset");

                return _SetColumnOffsetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowOffset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRowOffset(IntPtr _this, GetRowOffset__Args args);
            private static _GetRowOffset _GetRowOffsetFunc;
            internal static _GetRowOffset GetRowOffset() {
               _GetRowOffsetFunc ??= Torque3D.LookupEngineFunction<_GetRowOffset>("fnGuiFrameSetCtrl_getRowOffset");

                return _GetRowOffsetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetColumnOffset__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetColumnOffset(IntPtr _this, GetColumnOffset__Args args);
            private static _GetColumnOffset _GetColumnOffsetFunc;
            internal static _GetColumnOffset GetColumnOffset() {
               _GetColumnOffsetFunc ??= Torque3D.LookupEngineFunction<_GetColumnOffset>("fnGuiFrameSetCtrl_getColumnOffset");

                return _GetColumnOffsetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetRowCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetRowCount(IntPtr _this, GetRowCount__Args args);
            private static _GetRowCount _GetRowCountFunc;
            internal static _GetRowCount GetRowCount() {
               _GetRowCountFunc ??= Torque3D.LookupEngineFunction<_GetRowCount>("fnGuiFrameSetCtrl_getRowCount");

                return _GetRowCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetColumnCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetColumnCount(IntPtr _this, GetColumnCount__Args args);
            private static _GetColumnCount _GetColumnCountFunc;
            internal static _GetColumnCount GetColumnCount() {
               _GetColumnCountFunc ??= Torque3D.LookupEngineFunction<_GetColumnCount>("fnGuiFrameSetCtrl_getColumnCount");

                return _GetColumnCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveRow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveRow(IntPtr _this, RemoveRow__Args args);
            private static _RemoveRow _RemoveRowFunc;
            internal static _RemoveRow RemoveRow() {
               _RemoveRowFunc ??= Torque3D.LookupEngineFunction<_RemoveRow>("fnGuiFrameSetCtrl_removeRow");

                return _RemoveRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveColumn__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveColumn(IntPtr _this, RemoveColumn__Args args);
            private static _RemoveColumn _RemoveColumnFunc;
            internal static _RemoveColumn RemoveColumn() {
               _RemoveColumnFunc ??= Torque3D.LookupEngineFunction<_RemoveColumn>("fnGuiFrameSetCtrl_removeColumn");

                return _RemoveColumnFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddRow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddRow(IntPtr _this, AddRow__Args args);
            private static _AddRow _AddRowFunc;
            internal static _AddRow AddRow() {
               _AddRowFunc ??= Torque3D.LookupEngineFunction<_AddRow>("fnGuiFrameSetCtrl_addRow");

                return _AddRowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddColumn__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddColumn(IntPtr _this, AddColumn__Args args);
            private static _AddColumn _AddColumnFunc;
            internal static _AddColumn AddColumn() {
               _AddColumnFunc ??= Torque3D.LookupEngineFunction<_AddColumn>("fnGuiFrameSetCtrl_addColumn");

                return _AddColumnFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFramePadding__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate RectSpacingI.InternalStruct _GetFramePadding(IntPtr _this, GetFramePadding__Args args);
            private static _GetFramePadding _GetFramePaddingFunc;
            internal static _GetFramePadding GetFramePadding() {
               _GetFramePaddingFunc ??= Torque3D.LookupEngineFunction<_GetFramePadding>("fnGuiFrameSetCtrl_getFramePadding");

                return _GetFramePaddingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FramePadding__Args
            {
                internal int index;
                internal IntPtr padding;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FramePadding(IntPtr _this, FramePadding__Args args);
            private static _FramePadding _FramePaddingFunc;
            internal static _FramePadding FramePadding() {
               _FramePaddingFunc ??= Torque3D.LookupEngineFunction<_FramePadding>("fnGuiFrameSetCtrl_framePadding");

                return _FramePaddingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FrameMinExtent__Args
            {
                internal int index;
                internal int width;
                internal int height;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FrameMinExtent(IntPtr _this, FrameMinExtent__Args args);
            private static _FrameMinExtent _FrameMinExtentFunc;
            internal static _FrameMinExtent FrameMinExtent() {
               _FrameMinExtentFunc ??= Torque3D.LookupEngineFunction<_FrameMinExtent>("fnGuiFrameSetCtrl_frameMinExtent");

                return _FrameMinExtentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FrameMovable__Args
            {
                internal int index;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string state;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FrameMovable(IntPtr _this, FrameMovable__Args args);
            private static _FrameMovable _FrameMovableFunc;
            internal static _FrameMovable FrameMovable() {
               _FrameMovableFunc ??= Torque3D.LookupEngineFunction<_FrameMovable>("fnGuiFrameSetCtrl_frameMovable");

                return _FrameMovableFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FrameBorder__Args
            {
                internal int index;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string state;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FrameBorder(IntPtr _this, FrameBorder__Args args);
            private static _FrameBorder _FrameBorderFunc;
            internal static _FrameBorder FrameBorder() {
               _FrameBorderFunc ??= Torque3D.LookupEngineFunction<_FrameBorder>("fnGuiFrameSetCtrl_frameBorder");

                return _FrameBorderFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiFrameSetCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiFrameSetCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Recalculates child control sizes.
        /// </description>
        public void UpdateSizes() {
             InternalUnsafeMethods.UpdateSizes__Args _args = new InternalUnsafeMethods.UpdateSizes__Args() {
             };
             InternalUnsafeMethods.UpdateSizes()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the vertical offset of a row.
        /// 
        /// Note that row offsets must always be in increasing order, and therefore this offset must be between the offsets of the rows either side.
        /// </description>
        /// <param name="index">Index of the row to modify</param>
        /// <param name="offset">New row offset</param>
        public void SetRowOffset(int index, int offset) {
             InternalUnsafeMethods.SetRowOffset__Args _args = new InternalUnsafeMethods.SetRowOffset__Args() {
                index = index,
                offset = offset,
             };
             InternalUnsafeMethods.SetRowOffset()(ObjectPtr, _args);
        }

        /// <description>
        /// Set the horizontal offset of a column.
        /// 
        /// Note that column offsets must always be in increasing order, and therefore this offset must be between the offsets of the colunns either side.
        /// </description>
        /// <param name="index">Index of the column to modify</param>
        /// <param name="offset">New column offset</param>
        public void SetColumnOffset(int index, int offset) {
             InternalUnsafeMethods.SetColumnOffset__Args _args = new InternalUnsafeMethods.SetColumnOffset__Args() {
                index = index,
                offset = offset,
             };
             InternalUnsafeMethods.SetColumnOffset()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the vertical offset of a row.
        /// </description>
        /// <param name="index">Index of the row to query</param>
        /// <returns>Row offset in pixels</returns>
        public int GetRowOffset(int index) {
             InternalUnsafeMethods.GetRowOffset__Args _args = new InternalUnsafeMethods.GetRowOffset__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetRowOffset()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the horizontal offset of a column.
        /// </description>
        /// <param name="index">Index of the column to query</param>
        /// <returns>Column offset in pixels</returns>
        public int GetColumnOffset(int index) {
             InternalUnsafeMethods.GetColumnOffset__Args _args = new InternalUnsafeMethods.GetColumnOffset__Args() {
                index = index,
             };
             int _engineResult = InternalUnsafeMethods.GetColumnOffset()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the number of rows.
        /// </description>
        /// <returns>The number of rows</returns>
        public int GetRowCount() {
             InternalUnsafeMethods.GetRowCount__Args _args = new InternalUnsafeMethods.GetRowCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetRowCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the number of columns.
        /// </description>
        /// <returns>The number of columns</returns>
        public int GetColumnCount() {
             InternalUnsafeMethods.GetColumnCount__Args _args = new InternalUnsafeMethods.GetColumnCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetColumnCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Remove the last (bottom) row.
        /// </description>
        public void RemoveRow() {
             InternalUnsafeMethods.RemoveRow__Args _args = new InternalUnsafeMethods.RemoveRow__Args() {
             };
             InternalUnsafeMethods.RemoveRow()(ObjectPtr, _args);
        }

        /// <description>
        /// Remove the last (rightmost) column.
        /// </description>
        public void RemoveColumn() {
             InternalUnsafeMethods.RemoveColumn__Args _args = new InternalUnsafeMethods.RemoveColumn__Args() {
             };
             InternalUnsafeMethods.RemoveColumn()(ObjectPtr, _args);
        }

        /// <description>
        /// Add a new row.
        /// </description>
        public void AddRow() {
             InternalUnsafeMethods.AddRow__Args _args = new InternalUnsafeMethods.AddRow__Args() {
             };
             InternalUnsafeMethods.AddRow()(ObjectPtr, _args);
        }

        /// <description>
        /// Add a new column.
        /// </description>
        public void AddColumn() {
             InternalUnsafeMethods.AddColumn__Args _args = new InternalUnsafeMethods.AddColumn__Args() {
             };
             InternalUnsafeMethods.AddColumn()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the padding for this frame.
        /// </description>
        /// <param name="index">Index of the frame to query</param>
        public RectSpacingI GetFramePadding(int index) {
             InternalUnsafeMethods.GetFramePadding__Args _args = new InternalUnsafeMethods.GetFramePadding__Args() {
                index = index,
             };
             RectSpacingI.InternalStruct _engineResult = InternalUnsafeMethods.GetFramePadding()(ObjectPtr, _args);
             return new RectSpacingI(_engineResult);
        }

        /// <description>
        /// Set the padding for this frame. Padding introduces blank space on the inside edge of the frame.
        /// </description>
        /// <param name="index">Index of the frame to modify</param>
        /// <param name="padding">Frame top, bottom, left, and right padding</param>
        public void FramePadding(int index, RectSpacingI padding) {
padding.Alloc();             InternalUnsafeMethods.FramePadding__Args _args = new InternalUnsafeMethods.FramePadding__Args() {
                index = index,
                padding = padding.internalStructPtr,
             };
             InternalUnsafeMethods.FramePadding()(ObjectPtr, _args);
padding.Free();        }

        /// <description>
        /// Set the minimum width and height for the frame. It will not be possible for the user to resize the frame smaller than this.
        /// </description>
        /// <param name="index">Index of the frame to modify</param>
        /// <param name="width">Minimum width in pixels</param>
        /// <param name="height">Minimum height in pixels</param>
        public void FrameMinExtent(int index, int width, int height) {
             InternalUnsafeMethods.FrameMinExtent__Args _args = new InternalUnsafeMethods.FrameMinExtent__Args() {
                index = index,
                width = width,
                height = height,
             };
             InternalUnsafeMethods.FrameMinExtent()(ObjectPtr, _args);
        }

        /// <description>
        /// Override the <i>borderMovable</i> setting for this frame.
        /// </description>
        /// <param name="index">Index of the frame to modify</param>
        /// <param name="state">New borderEnable state: "on", "off" or "dynamic"</param>
        public void FrameMovable(int index, string state = "dynamic") {
             InternalUnsafeMethods.FrameMovable__Args _args = new InternalUnsafeMethods.FrameMovable__Args() {
                index = index,
                state = state,
             };
             InternalUnsafeMethods.FrameMovable()(ObjectPtr, _args);
        }

        /// <description>
        /// Override the <i>borderEnable</i> setting for this frame.
        /// </description>
        /// <param name="index">Index of the frame to modify</param>
        /// <param name="state">New borderEnable state: "on", "off" or "dynamic"</param>
        public void FrameBorder(int index, string state = "dynamic") {
             InternalUnsafeMethods.FrameBorder__Args _args = new InternalUnsafeMethods.FrameBorder__Args() {
                index = index,
                state = state,
             };
             InternalUnsafeMethods.FrameBorder()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiFrameSetCtrl class.
        /// </description>
        /// <returns>The type info object for GuiFrameSetCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// A vector of column offsets (determines the width of each column).
        /// </description>
        /// </value>
        public IntVector Columns {
            get => GenericMarshal.StringTo<IntVector>(GetFieldValue("columns"));
            set => SetFieldValue("columns", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// A vector of row offsets (determines the height of each row).
        /// </description>
        /// </value>
        public IntVector Rows {
            get => GenericMarshal.StringTo<IntVector>(GetFieldValue("rows"));
            set => SetFieldValue("rows", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Width of interior borders between cells in pixels.
        /// </description>
        /// </value>
        public int BorderWidth {
            get => GenericMarshal.StringTo<int>(GetFieldValue("borderWidth"));
            set => SetFieldValue("borderWidth", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Color of interior borders between cells.
        /// </description>
        /// </value>
        public ColorI BorderColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("borderColor"));
            set => SetFieldValue("borderColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Controls whether frame borders are enabled.
        /// 
        /// Frames use this value unless overridden for that frame using <i>%ctrl.frameBorder(index)</i>
        /// </description>
        /// </value>
        public GuiFrameState BorderEnable {
            get => GenericMarshal.StringTo<GuiFrameState>(GetFieldValue("borderEnable"));
            set => SetFieldValue("borderEnable", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Controls whether borders can be dynamically repositioned with the mouse by the user.
        /// 
        /// Frames use this value unless overridden for that frame using <i>%ctrl.frameMovable(index)</i>
        /// </description>
        /// </value>
        public GuiFrameState BorderMovable {
            get => GenericMarshal.StringTo<GuiFrameState>(GetFieldValue("borderMovable"));
            set => SetFieldValue("borderMovable", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, row and column offsets are automatically scaled to match the new extents when the control is resized.
        /// </description>
        /// </value>
        public bool AutoBalance {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoBalance"));
            set => SetFieldValue("autoBalance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Offset for row and column dividers in pixels
        /// </description>
        /// </value>
        public int FudgeFactor {
            get => GenericMarshal.StringTo<int>(GetFieldValue("fudgeFactor"));
            set => SetFieldValue("fudgeFactor", GenericMarshal.ToString(value));
        }
    }
}
