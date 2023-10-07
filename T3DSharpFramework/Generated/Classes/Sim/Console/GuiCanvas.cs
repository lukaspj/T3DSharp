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
    /// <summary>A canvas on which rendering occurs.</summary>
    /// <description>
    /// 
    /// </description>
    /// <see cref="GuiControlProfile" />
    /// <see cref="GuiControl" />
    public class GuiCanvas : GuiControl {
        public GuiCanvas(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiCanvas(string pName, bool pRegister)
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

        public GuiCanvas(string pName)
            : this(pName, false) {
        }

        public GuiCanvas(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiCanvas(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiCanvas(SimObject pObj)
            : base(pObj) {
        }

        public GuiCanvas(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLastInputDevice__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLastInputDevice(IntPtr _this, GetLastInputDevice__Args args);
            private static _GetLastInputDevice _GetLastInputDeviceFunc;
            internal static _GetLastInputDevice GetLastInputDevice() {
               _GetLastInputDeviceFunc ??= Torque3D.LookupEngineFunction<_GetLastInputDevice>("fnGuiCanvas_getLastInputDevice");

                return _GetLastInputDeviceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetVideoMode__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetVideoMode(IntPtr _this, ResetVideoMode__Args args);
            private static _ResetVideoMode _ResetVideoModeFunc;
            internal static _ResetVideoMode ResetVideoMode() {
               _ResetVideoModeFunc ??= Torque3D.LookupEngineFunction<_ResetVideoMode>("fnGuiCanvas_resetVideoMode");

                return _ResetVideoModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CursorNudge__Args
            {
                internal float x;
                internal float y;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CursorNudge(IntPtr _this, CursorNudge__Args args);
            private static _CursorNudge _CursorNudgeFunc;
            internal static _CursorNudge CursorNudge() {
               _CursorNudgeFunc ??= Torque3D.LookupEngineFunction<_CursorNudge>("fnGuiCanvas_cursorNudge");

                return _CursorNudgeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CursorClick__Args
            {
                internal int buttonId;
                [MarshalAs(UnmanagedType.I1)]
                internal bool isDown;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CursorClick(IntPtr _this, CursorClick__Args args);
            private static _CursorClick _CursorClickFunc;
            internal static _CursorClick CursorClick() {
               _CursorClickFunc ??= Torque3D.LookupEngineFunction<_CursorClick>("fnGuiCanvas_cursorClick");

                return _CursorClickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct HideWindow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _HideWindow(IntPtr _this, HideWindow__Args args);
            private static _HideWindow _HideWindowFunc;
            internal static _HideWindow HideWindow() {
               _HideWindowFunc ??= Torque3D.LookupEngineFunction<_HideWindow>("fnGuiCanvas_hideWindow");

                return _HideWindowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ShowWindow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ShowWindow(IntPtr _this, ShowWindow__Args args);
            private static _ShowWindow _ShowWindowFunc;
            internal static _ShowWindow ShowWindow() {
               _ShowWindowFunc ??= Torque3D.LookupEngineFunction<_ShowWindow>("fnGuiCanvas_showWindow");

                return _ShowWindowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetVideoMode__Args
            {
                internal uint width;
                internal uint height;
                [MarshalAs(UnmanagedType.I1)]
                internal bool fullscreen;
                internal uint bitDepth;
                internal uint refreshRate;
                internal uint antialiasLevel;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetVideoMode(IntPtr _this, SetVideoMode__Args args);
            private static _SetVideoMode _SetVideoModeFunc;
            internal static _SetVideoMode SetVideoMode() {
               _SetVideoModeFunc ??= Torque3D.LookupEngineFunction<_SetVideoMode>("fnGuiCanvas_setVideoMode");

                return _SetVideoModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMenuBar__Args
            {
                internal IntPtr menu;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMenuBar(IntPtr _this, SetMenuBar__Args args);
            private static _SetMenuBar _SetMenuBarFunc;
            internal static _SetMenuBar SetMenuBar() {
               _SetMenuBarFunc ??= Torque3D.LookupEngineFunction<_SetMenuBar>("fnGuiCanvas_setMenuBar");

                return _SetMenuBarFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetFocus__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetFocus(IntPtr _this, SetFocus__Args args);
            private static _SetFocus _SetFocusFunc;
            internal static _SetFocus SetFocus() {
               _SetFocusFunc ??= Torque3D.LookupEngineFunction<_SetFocus>("fnGuiCanvas_setFocus");

                return _SetFocusFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RestoreWindow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RestoreWindow(IntPtr _this, RestoreWindow__Args args);
            private static _RestoreWindow _RestoreWindowFunc;
            internal static _RestoreWindow RestoreWindow() {
               _RestoreWindowFunc ??= Torque3D.LookupEngineFunction<_RestoreWindow>("fnGuiCanvas_restoreWindow");

                return _RestoreWindowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MaximizeWindow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _MaximizeWindow(IntPtr _this, MaximizeWindow__Args args);
            private static _MaximizeWindow _MaximizeWindowFunc;
            internal static _MaximizeWindow MaximizeWindow() {
               _MaximizeWindowFunc ??= Torque3D.LookupEngineFunction<_MaximizeWindow>("fnGuiCanvas_maximizeWindow");

                return _MaximizeWindowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsMaximized__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsMaximized(IntPtr _this, IsMaximized__Args args);
            private static _IsMaximized _IsMaximizedFunc;
            internal static _IsMaximized IsMaximized() {
               _IsMaximizedFunc ??= Torque3D.LookupEngineFunction<_IsMaximized>("fnGuiCanvas_isMaximized");

                return _IsMaximizedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsMinimized__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsMinimized(IntPtr _this, IsMinimized__Args args);
            private static _IsMinimized _IsMinimizedFunc;
            internal static _IsMinimized IsMinimized() {
               _IsMinimizedFunc ??= Torque3D.LookupEngineFunction<_IsMinimized>("fnGuiCanvas_isMinimized");

                return _IsMinimizedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct MinimizeWindow__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _MinimizeWindow(IntPtr _this, MinimizeWindow__Args args);
            private static _MinimizeWindow _MinimizeWindowFunc;
            internal static _MinimizeWindow MinimizeWindow() {
               _MinimizeWindowFunc ??= Torque3D.LookupEngineFunction<_MinimizeWindow>("fnGuiCanvas_minimizeWindow");

                return _MinimizeWindowFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsFullscreen__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsFullscreen(IntPtr _this, IsFullscreen__Args args);
            private static _IsFullscreen _IsFullscreenFunc;
            internal static _IsFullscreen IsFullscreen() {
               _IsFullscreenFunc ??= Torque3D.LookupEngineFunction<_IsFullscreen>("fnGuiCanvas_isFullscreen");

                return _IsFullscreenFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetWindowPosition__Args
            {
                internal IntPtr position;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetWindowPosition(IntPtr _this, SetWindowPosition__Args args);
            private static _SetWindowPosition _SetWindowPositionFunc;
            internal static _SetWindowPosition SetWindowPosition() {
               _SetWindowPositionFunc ??= Torque3D.LookupEngineFunction<_SetWindowPosition>("fnGuiCanvas_setWindowPosition");

                return _SetWindowPositionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetWindowPosition__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2I.InternalStruct _GetWindowPosition(IntPtr _this, GetWindowPosition__Args args);
            private static _GetWindowPosition _GetWindowPositionFunc;
            internal static _GetWindowPosition GetWindowPosition() {
               _GetWindowPositionFunc ??= Torque3D.LookupEngineFunction<_GetWindowPosition>("fnGuiCanvas_getWindowPosition");

                return _GetWindowPositionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ScreenToClient__Args
            {
                internal IntPtr coordinate;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2I.InternalStruct _ScreenToClient(IntPtr _this, ScreenToClient__Args args);
            private static _ScreenToClient _ScreenToClientFunc;
            internal static _ScreenToClient ScreenToClient() {
               _ScreenToClientFunc ??= Torque3D.LookupEngineFunction<_ScreenToClient>("fnGuiCanvas_screenToClient");

                return _ScreenToClientFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClientToScreen__Args
            {
                internal IntPtr coordinate;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2I.InternalStruct _ClientToScreen(IntPtr _this, ClientToScreen__Args args);
            private static _ClientToScreen _ClientToScreenFunc;
            internal static _ClientToScreen ClientToScreen() {
               _ClientToScreenFunc ??= Torque3D.LookupEngineFunction<_ClientToScreen>("fnGuiCanvas_clientToScreen");

                return _ClientToScreenFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ToggleFullscreen__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ToggleFullscreen(IntPtr _this, ToggleFullscreen__Args args);
            private static _ToggleFullscreen _ToggleFullscreenFunc;
            internal static _ToggleFullscreen ToggleFullscreen() {
               _ToggleFullscreenFunc ??= Torque3D.LookupEngineFunction<_ToggleFullscreen>("fnGuiCanvas_toggleFullscreen");

                return _ToggleFullscreenFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMode__Args
            {
                internal int modeId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMode(IntPtr _this, GetMode__Args args);
            private static _GetMode _GetModeFunc;
            internal static _GetMode GetMode() {
               _GetModeFunc ??= Torque3D.LookupEngineFunction<_GetMode>("fnGuiCanvas_getMode");

                return _GetModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetModeCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetModeCount(IntPtr _this, GetModeCount__Args args);
            private static _GetModeCount _GetModeCountFunc;
            internal static _GetModeCount GetModeCount() {
               _GetModeCountFunc ??= Torque3D.LookupEngineFunction<_GetModeCount>("fnGuiCanvas_getModeCount");

                return _GetModeCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetVideoMode__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetVideoMode(IntPtr _this, GetVideoMode__Args args);
            private static _GetVideoMode _GetVideoModeFunc;
            internal static _GetVideoMode GetVideoMode() {
               _GetVideoModeFunc ??= Torque3D.LookupEngineFunction<_GetVideoMode>("fnGuiCanvas_getVideoMode");

                return _GetVideoModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMonitorDesktopMode__Args
            {
                internal int monitorIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMonitorDesktopMode(IntPtr _this, GetMonitorDesktopMode__Args args);
            private static _GetMonitorDesktopMode _GetMonitorDesktopModeFunc;
            internal static _GetMonitorDesktopMode GetMonitorDesktopMode() {
               _GetMonitorDesktopModeFunc ??= Torque3D.LookupEngineFunction<_GetMonitorDesktopMode>("fnGuiCanvas_getMonitorDesktopMode");

                return _GetMonitorDesktopModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMonitorMode__Args
            {
                internal int monitorIndex;
                internal int modeIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMonitorMode(IntPtr _this, GetMonitorMode__Args args);
            private static _GetMonitorMode _GetMonitorModeFunc;
            internal static _GetMonitorMode GetMonitorMode() {
               _GetMonitorModeFunc ??= Torque3D.LookupEngineFunction<_GetMonitorMode>("fnGuiCanvas_getMonitorMode");

                return _GetMonitorModeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMonitorModeCount__Args
            {
                internal int monitorIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMonitorModeCount(IntPtr _this, GetMonitorModeCount__Args args);
            private static _GetMonitorModeCount _GetMonitorModeCountFunc;
            internal static _GetMonitorModeCount GetMonitorModeCount() {
               _GetMonitorModeCountFunc ??= Torque3D.LookupEngineFunction<_GetMonitorModeCount>("fnGuiCanvas_getMonitorModeCount");

                return _GetMonitorModeCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMonitorUsableRect__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate RectI.InternalStruct _GetMonitorUsableRect(IntPtr _this, GetMonitorUsableRect__Args args);
            private static _GetMonitorUsableRect _GetMonitorUsableRectFunc;
            internal static _GetMonitorUsableRect GetMonitorUsableRect() {
               _GetMonitorUsableRectFunc ??= Torque3D.LookupEngineFunction<_GetMonitorUsableRect>("fnGuiCanvas_getMonitorUsableRect");

                return _GetMonitorUsableRectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMonitorRect__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate RectI.InternalStruct _GetMonitorRect(IntPtr _this, GetMonitorRect__Args args);
            private static _GetMonitorRect _GetMonitorRectFunc;
            internal static _GetMonitorRect GetMonitorRect() {
               _GetMonitorRectFunc ??= Torque3D.LookupEngineFunction<_GetMonitorRect>("fnGuiCanvas_getMonitorRect");

                return _GetMonitorRectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMonitorName__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetMonitorName(IntPtr _this, GetMonitorName__Args args);
            private static _GetMonitorName _GetMonitorNameFunc;
            internal static _GetMonitorName GetMonitorName() {
               _GetMonitorNameFunc ??= Torque3D.LookupEngineFunction<_GetMonitorName>("fnGuiCanvas_getMonitorName");

                return _GetMonitorNameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMonitorCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMonitorCount(IntPtr _this, GetMonitorCount__Args args);
            private static _GetMonitorCount _GetMonitorCountFunc;
            internal static _GetMonitorCount GetMonitorCount() {
               _GetMonitorCountFunc ??= Torque3D.LookupEngineFunction<_GetMonitorCount>("fnGuiCanvas_getMonitorCount");

                return _GetMonitorCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FindFirstMatchingMonitor__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _FindFirstMatchingMonitor(IntPtr _this, FindFirstMatchingMonitor__Args args);
            private static _FindFirstMatchingMonitor _FindFirstMatchingMonitorFunc;
            internal static _FindFirstMatchingMonitor FindFirstMatchingMonitor() {
               _FindFirstMatchingMonitorFunc ??= Torque3D.LookupEngineFunction<_FindFirstMatchingMonitor>("fnGuiCanvas_findFirstMatchingMonitor");

                return _FindFirstMatchingMonitorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetWindowTitle__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string newTitle;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetWindowTitle(IntPtr _this, SetWindowTitle__Args args);
            private static _SetWindowTitle _SetWindowTitleFunc;
            internal static _SetWindowTitle SetWindowTitle() {
               _SetWindowTitleFunc ??= Torque3D.LookupEngineFunction<_SetWindowTitle>("fnGuiCanvas_setWindowTitle");

                return _SetWindowTitleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetExtent__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2I.InternalStruct _GetExtent(IntPtr _this, GetExtent__Args args);
            private static _GetExtent _GetExtentFunc;
            internal static _GetExtent GetExtent() {
               _GetExtentFunc ??= Torque3D.LookupEngineFunction<_GetExtent>("fnGuiCanvas_getExtent");

                return _GetExtentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetMouseControl__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetMouseControl(IntPtr _this, GetMouseControl__Args args);
            private static _GetMouseControl _GetMouseControlFunc;
            internal static _GetMouseControl GetMouseControl() {
               _GetMouseControlFunc ??= Torque3D.LookupEngineFunction<_GetMouseControl>("fnGuiCanvas_getMouseControl");

                return _GetMouseControlFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCursorPos__Args
            {
                internal IntPtr pos;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCursorPos(IntPtr _this, SetCursorPos__Args args);
            private static _SetCursorPos _SetCursorPosFunc;
            internal static _SetCursorPos SetCursorPos() {
               _SetCursorPosFunc ??= Torque3D.LookupEngineFunction<_SetCursorPos>("fnGuiCanvas_setCursorPos");

                return _SetCursorPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCursorPos__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point2I.InternalStruct _GetCursorPos(IntPtr _this, GetCursorPos__Args args);
            private static _GetCursorPos _GetCursorPosFunc;
            internal static _GetCursorPos GetCursorPos() {
               _GetCursorPosFunc ??= Torque3D.LookupEngineFunction<_GetCursorPos>("fnGuiCanvas_getCursorPos");

                return _GetCursorPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
               _ResetFunc ??= Torque3D.LookupEngineFunction<_Reset>("fnGuiCanvas_reset");

                return _ResetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Repaint__Args
            {
                internal int elapsedMS;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Repaint(IntPtr _this, Repaint__Args args);
            private static _Repaint _RepaintFunc;
            internal static _Repaint Repaint() {
               _RepaintFunc ??= Torque3D.LookupEngineFunction<_Repaint>("fnGuiCanvas_repaint");

                return _RepaintFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsCursorShown__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsCursorShown(IntPtr _this, IsCursorShown__Args args);
            private static _IsCursorShown _IsCursorShownFunc;
            internal static _IsCursorShown IsCursorShown() {
               _IsCursorShownFunc ??= Torque3D.LookupEngineFunction<_IsCursorShown>("fnGuiCanvas_isCursorShown");

                return _IsCursorShownFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsCursorOn__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsCursorOn(IntPtr _this, IsCursorOn__Args args);
            private static _IsCursorOn _IsCursorOnFunc;
            internal static _IsCursorOn IsCursorOn() {
               _IsCursorOnFunc ??= Torque3D.LookupEngineFunction<_IsCursorOn>("fnGuiCanvas_isCursorOn");

                return _IsCursorOnFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct HideCursor__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _HideCursor(IntPtr _this, HideCursor__Args args);
            private static _HideCursor _HideCursorFunc;
            internal static _HideCursor HideCursor() {
               _HideCursorFunc ??= Torque3D.LookupEngineFunction<_HideCursor>("fnGuiCanvas_hideCursor");

                return _HideCursorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ShowCursor__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ShowCursor(IntPtr _this, ShowCursor__Args args);
            private static _ShowCursor _ShowCursorFunc;
            internal static _ShowCursor ShowCursor() {
               _ShowCursorFunc ??= Torque3D.LookupEngineFunction<_ShowCursor>("fnGuiCanvas_showCursor");

                return _ShowCursorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RenderFront__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool enable;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RenderFront(IntPtr _this, RenderFront__Args args);
            private static _RenderFront _RenderFrontFunc;
            internal static _RenderFront RenderFront() {
               _RenderFrontFunc ??= Torque3D.LookupEngineFunction<_RenderFront>("fnGuiCanvas_renderFront");

                return _RenderFrontFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCursor__Args
            {
                internal IntPtr cursor;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetCursor(IntPtr _this, SetCursor__Args args);
            private static _SetCursor _SetCursorFunc;
            internal static _SetCursor SetCursor() {
               _SetCursorFunc ??= Torque3D.LookupEngineFunction<_SetCursor>("fnGuiCanvas_setCursor");

                return _SetCursorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CursorOff__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CursorOff(IntPtr _this, CursorOff__Args args);
            private static _CursorOff _CursorOffFunc;
            internal static _CursorOff CursorOff() {
               _CursorOffFunc ??= Torque3D.LookupEngineFunction<_CursorOff>("fnGuiCanvas_cursorOff");

                return _CursorOffFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CursorOn__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CursorOn(IntPtr _this, CursorOn__Args args);
            private static _CursorOn _CursorOnFunc;
            internal static _CursorOn CursorOn() {
               _CursorOnFunc ??= Torque3D.LookupEngineFunction<_CursorOn>("fnGuiCanvas_cursorOn");

                return _CursorOnFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PopLayer__Args
            {
                internal int layer;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PopLayer(IntPtr _this, PopLayer__Args args);
            private static _PopLayer _PopLayerFunc;
            internal static _PopLayer PopLayer() {
               _PopLayerFunc ??= Torque3D.LookupEngineFunction<_PopLayer>("fnGuiCanvas_popLayer");

                return _PopLayerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PopDialog__Args
            {
                internal IntPtr gui;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PopDialog(IntPtr _this, PopDialog__Args args);
            private static _PopDialog _PopDialogFunc;
            internal static _PopDialog PopDialog() {
               _PopDialogFunc ??= Torque3D.LookupEngineFunction<_PopDialog>("fnGuiCanvas_popDialog");

                return _PopDialogFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushDialog__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string ctrlName;
                internal int layer;
                [MarshalAs(UnmanagedType.I1)]
                internal bool center;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushDialog(IntPtr _this, PushDialog__Args args);
            private static _PushDialog _PushDialogFunc;
            internal static _PushDialog PushDialog() {
               _PushDialogFunc ??= Torque3D.LookupEngineFunction<_PushDialog>("fnGuiCanvas_pushDialog");

                return _PushDialogFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetContent__Args
            {
                internal IntPtr ctrl;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetContent(IntPtr _this, SetContent__Args args);
            private static _SetContent _SetContentFunc;
            internal static _SetContent SetContent() {
               _SetContentFunc ??= Torque3D.LookupEngineFunction<_SetContent>("fnGuiCanvas_setContent");

                return _SetContentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetContent__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetContent(IntPtr _this, GetContent__Args args);
            private static _GetContent _GetContentFunc;
            internal static _GetContent GetContent() {
               _GetContentFunc ??= Torque3D.LookupEngineFunction<_GetContent>("fnGuiCanvas_getContent");

                return _GetContentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnSetNativeAcceleratorsEnabled__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool enable;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _OnSetNativeAcceleratorsEnabled(IntPtr _this, OnSetNativeAcceleratorsEnabled__Args args);
            private static _OnSetNativeAcceleratorsEnabled _OnSetNativeAcceleratorsEnabledFunc;
            internal static _OnSetNativeAcceleratorsEnabled OnSetNativeAcceleratorsEnabled() {
               _OnSetNativeAcceleratorsEnabledFunc ??= Torque3D.LookupEngineFunction<_OnSetNativeAcceleratorsEnabled>("cbGuiCanvas_onSetNativeAcceleratorsEnabled");

                return _OnSetNativeAcceleratorsEnabledFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnSetKeyboardTranslationEnabled__Args
            {
                [MarshalAs(UnmanagedType.I1)]
                internal bool enable;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _OnSetKeyboardTranslationEnabled(IntPtr _this, OnSetKeyboardTranslationEnabled__Args args);
            private static _OnSetKeyboardTranslationEnabled _OnSetKeyboardTranslationEnabledFunc;
            internal static _OnSetKeyboardTranslationEnabled OnSetKeyboardTranslationEnabled() {
               _OnSetKeyboardTranslationEnabledFunc ??= Torque3D.LookupEngineFunction<_OnSetKeyboardTranslationEnabled>("cbGuiCanvas_onSetKeyboardTranslationEnabled");

                return _OnSetKeyboardTranslationEnabledFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiCanvas_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiCanvas_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Returns the name of the last input device that the GuiCanvas consumed.
        /// </description>
        public string GetLastInputDevice() {
             InternalUnsafeMethods.GetLastInputDevice__Args _args = new InternalUnsafeMethods.GetLastInputDevice__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLastInputDevice()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// 
        public void ResetVideoMode() {
             InternalUnsafeMethods.ResetVideoMode__Args _args = new InternalUnsafeMethods.ResetVideoMode__Args() {
             };
             InternalUnsafeMethods.ResetVideoMode()(ObjectPtr, _args);
        }

        /// 
        public void CursorNudge(float x, float y) {
             InternalUnsafeMethods.CursorNudge__Args _args = new InternalUnsafeMethods.CursorNudge__Args() {
                x = x,
                y = y,
             };
             InternalUnsafeMethods.CursorNudge()(ObjectPtr, _args);
        }

        /// 
        public void CursorClick(int buttonId, bool isDown) {
             InternalUnsafeMethods.CursorClick__Args _args = new InternalUnsafeMethods.CursorClick__Args() {
                buttonId = buttonId,
                isDown = isDown,
             };
             InternalUnsafeMethods.CursorClick()(ObjectPtr, _args);
        }

        /// 
        public void HideWindow() {
             InternalUnsafeMethods.HideWindow__Args _args = new InternalUnsafeMethods.HideWindow__Args() {
             };
             InternalUnsafeMethods.HideWindow()(ObjectPtr, _args);
        }

        /// 
        public void ShowWindow() {
             InternalUnsafeMethods.ShowWindow__Args _args = new InternalUnsafeMethods.ShowWindow__Args() {
             };
             InternalUnsafeMethods.ShowWindow()(ObjectPtr, _args);
        }

        /// <description>
        /// (int width, int height, bool fullscreen, [int bitDepth], [int refreshRate], [int antialiasLevel] )
        /// Change the video mode of this canvas. This method has the side effect of setting the $pref::Video::mode to the new values.
        /// 
        /// \param width The screen width to set.
        /// \param height The screen height to set.
        /// \param fullscreen Specify true to run fullscreen or false to run in a window
        /// \param bitDepth [optional] The desired bit-depth. Defaults to the current setting. This parameter is ignored if you are running in a window.
        /// \param refreshRate [optional] The desired refresh rate. Defaults to the current setting. This parameter is ignored if you are running in a window\param antialiasLevel [optional] The level of anti-aliasing to apply 0 = none
        /// </description>
        public void SetVideoMode(uint width, uint height, bool fullscreen = false, uint bitDepth = 0, uint refreshRate = 0, uint antialiasLevel = 0) {
             InternalUnsafeMethods.SetVideoMode__Args _args = new InternalUnsafeMethods.SetVideoMode__Args() {
                width = width,
                height = height,
                fullscreen = fullscreen,
                bitDepth = bitDepth,
                refreshRate = refreshRate,
                antialiasLevel = antialiasLevel,
             };
             InternalUnsafeMethods.SetVideoMode()(ObjectPtr, _args);
        }

        /// <description>
        /// Translate a coordinate from canvas window-space to screen-space.
        /// </description>
        /// <param name="coordinate">The coordinate in window-space.</param>
        /// <returns>The given coordinate translated to screen-space.</returns>
        public void SetMenuBar(GuiControl menu) {
             InternalUnsafeMethods.SetMenuBar__Args _args = new InternalUnsafeMethods.SetMenuBar__Args() {
                menu = menu.ObjectPtr,
             };
             InternalUnsafeMethods.SetMenuBar()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Claim OS input focus for this canvas' window.
        /// </description>
        public void SetFocus() {
             InternalUnsafeMethods.SetFocus__Args _args = new InternalUnsafeMethods.SetFocus__Args() {
             };
             InternalUnsafeMethods.SetFocus()(ObjectPtr, _args);
        }

        /// <description>
        /// () - restore this canvas' window.
        /// </description>
        public void RestoreWindow() {
             InternalUnsafeMethods.RestoreWindow__Args _args = new InternalUnsafeMethods.RestoreWindow__Args() {
             };
             InternalUnsafeMethods.RestoreWindow()(ObjectPtr, _args);
        }

        /// <description>
        /// () - maximize this canvas' window.
        /// </description>
        public void MaximizeWindow() {
             InternalUnsafeMethods.MaximizeWindow__Args _args = new InternalUnsafeMethods.MaximizeWindow__Args() {
             };
             InternalUnsafeMethods.MaximizeWindow()(ObjectPtr, _args);
        }

        /// <description>
        /// ()
        /// </description>
        public bool IsMaximized() {
             InternalUnsafeMethods.IsMaximized__Args _args = new InternalUnsafeMethods.IsMaximized__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsMaximized()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ()
        /// </description>
        public bool IsMinimized() {
             InternalUnsafeMethods.IsMinimized__Args _args = new InternalUnsafeMethods.IsMinimized__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsMinimized()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// () - minimize this canvas' window.
        /// </description>
        public void MinimizeWindow() {
             InternalUnsafeMethods.MinimizeWindow__Args _args = new InternalUnsafeMethods.MinimizeWindow__Args() {
             };
             InternalUnsafeMethods.MinimizeWindow()(ObjectPtr, _args);
        }

        /// <description>
        /// () - Is this canvas currently fullscreen?
        /// </description>
        public bool IsFullscreen() {
             InternalUnsafeMethods.IsFullscreen__Args _args = new InternalUnsafeMethods.IsFullscreen__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsFullscreen()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Set the position of the platform window associated with the canvas.
        /// </description>
        /// <param name="position">The new position of the window in screen-space.</param>
        public void SetWindowPosition(Point2I position) {
position.Alloc();             InternalUnsafeMethods.SetWindowPosition__Args _args = new InternalUnsafeMethods.SetWindowPosition__Args() {
                position = position.internalStructPtr,
             };
             InternalUnsafeMethods.SetWindowPosition()(ObjectPtr, _args);
position.Free();        }

        /// <description>
        /// Get the current position of the platform window associated with the canvas.
        /// </description>
        /// <returns>The window position of the canvas in screen-space.</returns>
        public Point2I GetWindowPosition() {
             InternalUnsafeMethods.GetWindowPosition__Args _args = new InternalUnsafeMethods.GetWindowPosition__Args() {
             };
             Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetWindowPosition()(ObjectPtr, _args);
             return new Point2I(_engineResult);
        }

        /// <description>
        /// Translate a coordinate from screen-space to canvas window-space.
        /// </description>
        /// <param name="coordinate">The coordinate in screen-space.</param>
        /// <returns>The given coordinate translated to window-space.</returns>
        public Point2I ScreenToClient(Point2I coordinate) {
coordinate.Alloc();             InternalUnsafeMethods.ScreenToClient__Args _args = new InternalUnsafeMethods.ScreenToClient__Args() {
                coordinate = coordinate.internalStructPtr,
             };
             Point2I.InternalStruct _engineResult = InternalUnsafeMethods.ScreenToClient()(ObjectPtr, _args);
coordinate.Free();             return new Point2I(_engineResult);
        }

        /// <description>
        /// Translate a coordinate from canvas window-space to screen-space.
        /// </description>
        /// <param name="coordinate">The coordinate in window-space.</param>
        /// <returns>The given coordinate translated to screen-space.</returns>
        public Point2I ClientToScreen(Point2I coordinate) {
coordinate.Alloc();             InternalUnsafeMethods.ClientToScreen__Args _args = new InternalUnsafeMethods.ClientToScreen__Args() {
                coordinate = coordinate.internalStructPtr,
             };
             Point2I.InternalStruct _engineResult = InternalUnsafeMethods.ClientToScreen()(ObjectPtr, _args);
coordinate.Free();             return new Point2I(_engineResult);
        }

        /// <summary>toggle canvas from fullscreen to windowed mode or back.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // If we are in windowed mode, the following will put is in fullscreen
        /// Canvas.toggleFullscreen();
        /// </code>
        public void ToggleFullscreen() {
             InternalUnsafeMethods.ToggleFullscreen__Args _args = new InternalUnsafeMethods.ToggleFullscreen__Args() {
             };
             InternalUnsafeMethods.ToggleFullscreen()(ObjectPtr, _args);
        }

        /// <summary>Gets information on the specified mode of this device.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="modeId">Index of the mode to get data from.</param>
        /// <returns>A video mode string given an adapter and mode index.</returns>
        /// <see cref="GuiCanvas::getVideoMode()" />
        public string GetMode(int modeId) {
             InternalUnsafeMethods.GetMode__Args _args = new InternalUnsafeMethods.GetMode__Args() {
                modeId = modeId,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMode()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets the number of modes available on this device.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="param">Description</param>
        /// <code>
        /// %modeCount = Canvas.getModeCount()
        /// </code>
        /// <returns>The number of video modes supported by the device</returns>
        public int GetModeCount() {
             InternalUnsafeMethods.GetModeCount__Args _args = new InternalUnsafeMethods.GetModeCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetModeCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Gets the current screen mode as a string.</summary>
        /// <description>
        /// The return string will contain 5 values (width, height, fullscreen, bitdepth, refreshRate). You will need to parse out each one for individual use.
        /// </description>
        /// <code>
        /// %screenWidth = getWord(Canvas.getVideoMode(), 0);
        /// %screenHeight = getWord(Canvas.getVideoMode(), 1);
        /// %isFullscreen = getWord(Canvas.getVideoMode(), 2);
        /// %bitdepth = getWord(Canvas.getVideoMode(), 3);
        /// %refreshRate = getWord(Canvas.getVideoMode(), 4);
        /// </code>
        /// <returns>String formatted with screen width, screen height, screen mode, bit depth, and refresh rate.</returns>
        public string GetVideoMode() {
             InternalUnsafeMethods.GetVideoMode__Args _args = new InternalUnsafeMethods.GetVideoMode__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetVideoMode()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the current desktop mode for the selected monitor.
        /// </description>
        public string GetMonitorDesktopMode(int monitorIndex = 0) {
             InternalUnsafeMethods.GetMonitorDesktopMode__Args _args = new InternalUnsafeMethods.GetMonitorDesktopMode__Args() {
                monitorIndex = monitorIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMonitorDesktopMode()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets a video mode string from the selected monitor.
        /// </description>
        public string GetMonitorMode(int monitorIndex, int modeIndex = 0) {
             InternalUnsafeMethods.GetMonitorMode__Args _args = new InternalUnsafeMethods.GetMonitorMode__Args() {
                monitorIndex = monitorIndex,
                modeIndex = modeIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMonitorMode()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the number of video modes available on the selected monitor.
        /// </description>
        public int GetMonitorModeCount(int monitorIndex = 0) {
             InternalUnsafeMethods.GetMonitorModeCount__Args _args = new InternalUnsafeMethods.GetMonitorModeCount__Args() {
                monitorIndex = monitorIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetMonitorModeCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Use this function to get the usable desktop area represented by a display, with the primary display located at 0,0.</summary>
        /// <description>
        /// This is the same area as Canvas.getMonitorRect() reports, but with portions reserved by the system removed. For example, on Apple Mac OS X, this subtracts the area occupied by the menu bar and dock.
        /// Setting a window to be fullscreen generally bypasses these unusable areas, so these are good guidelines for the maximum space available to a non - fullscreen window.
        /// </description>
        /// <param name="index">The monitor index.</param>
        /// <returns>The rectangular region of the requested monitor.</returns>
        public RectI GetMonitorUsableRect(int index) {
             InternalUnsafeMethods.GetMonitorUsableRect__Args _args = new InternalUnsafeMethods.GetMonitorUsableRect__Args() {
                index = index,
             };
             RectI.InternalStruct _engineResult = InternalUnsafeMethods.GetMonitorUsableRect()(ObjectPtr, _args);
             return new RectI(_engineResult);
        }

        /// <summary>Gets the region of the requested monitor.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">The monitor index.</param>
        /// <returns>The rectangular region of the requested monitor.</returns>
        public RectI GetMonitorRect(int index) {
             InternalUnsafeMethods.GetMonitorRect__Args _args = new InternalUnsafeMethods.GetMonitorRect__Args() {
                index = index,
             };
             RectI.InternalStruct _engineResult = InternalUnsafeMethods.GetMonitorRect()(ObjectPtr, _args);
             return new RectI(_engineResult);
        }

        /// <summary>Gets the name of the requested monitor.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">The monitor index.</param>
        /// <returns>The name of the requested monitor.</returns>
        public string GetMonitorName(int index) {
             InternalUnsafeMethods.GetMonitorName__Args _args = new InternalUnsafeMethods.GetMonitorName__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetMonitorName()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets the number of monitors attached to the system.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>The number of monitors attached to the system, including the default monoitor.</returns>
        public int GetMonitorCount() {
             InternalUnsafeMethods.GetMonitorCount__Args _args = new InternalUnsafeMethods.GetMonitorCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetMonitorCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Find the first monitor index that matches the given name.</summary>
        /// <description>
        /// The actual match algorithm depends on the implementation.
        /// </description>
        /// <param name="name">The name to search for.</param>
        /// <returns>The number of monitors attached to the system, including the default monoitor.</returns>
        public int FindFirstMatchingMonitor(string name) {
             InternalUnsafeMethods.FindFirstMatchingMonitor__Args _args = new InternalUnsafeMethods.FindFirstMatchingMonitor__Args() {
                name = name,
             };
             int _engineResult = InternalUnsafeMethods.FindFirstMatchingMonitor()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Change the title of the OS window.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="newTitle">String containing the new name</param>
        /// <code>
        /// Canvas.setWindowTitle("Documentation Rocks!");
        /// </code>
        public void SetWindowTitle(string newTitle) {
             InternalUnsafeMethods.SetWindowTitle__Args _args = new InternalUnsafeMethods.SetWindowTitle__Args() {
                newTitle = newTitle,
             };
             InternalUnsafeMethods.SetWindowTitle()(ObjectPtr, _args);
        }

        /// <summary>Returns the dimensions of the canvas</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// %extent = Canvas.getExtent();
        /// </code>
        /// <returns>Width and height of canvas. Formatted as numerical values in a single string "# #"</returns>
        public Point2I GetExtent() {
             InternalUnsafeMethods.GetExtent__Args _args = new InternalUnsafeMethods.GetExtent__Args() {
             };
             Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetExtent()(ObjectPtr, _args);
             return new Point2I(_engineResult);
        }

        /// <summary>Gets the gui control under the mouse.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// %underMouse = Canvas.getMouseControl();
        /// </code>
        /// <returns>ID of the gui control, if one was found. NULL otherwise</returns>
        public int GetMouseControl() {
             InternalUnsafeMethods.GetMouseControl__Args _args = new InternalUnsafeMethods.GetMouseControl__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetMouseControl()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (Point2I pos)
        /// </description>
        public void SetCursorPos(Point2I pos) {
pos.Alloc();             InternalUnsafeMethods.SetCursorPos__Args _args = new InternalUnsafeMethods.SetCursorPos__Args() {
                pos = pos.internalStructPtr,
             };
             InternalUnsafeMethods.SetCursorPos()(ObjectPtr, _args);
pos.Free();        }

        /// <summary>Get the current position of the cursor in screen-space. Note that this position might be outside the Torque window. If you want to get the position within the Canvas, call screenToClient on the result.</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="Canvas::screenToClient()" />
        /// <param name="param">Description</param>
        /// <code>
        /// %cursorPos = Canvas.getCursorPos();
        /// </code>
        /// <returns>Screen coordinates of mouse cursor, in format "X Y"</returns>
        public Point2I GetCursorPos() {
             InternalUnsafeMethods.GetCursorPos__Args _args = new InternalUnsafeMethods.GetCursorPos__Args() {
             };
             Point2I.InternalStruct _engineResult = InternalUnsafeMethods.GetCursorPos()(ObjectPtr, _args);
             return new Point2I(_engineResult);
        }

        /// <summary>Reset the update regions for the canvas.</summary>
        /// <description>
        /// 
        /// </description>
        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        /// <summary>Force canvas to redraw.</summary>
        /// <description>
        /// If the elapsed time is greater than the time since the last paint then the repaint will be skipped.
        /// </description>
        /// <param name="elapsedMS">The optional elapsed time in milliseconds.</param>
        public void Repaint(int elapsedMS = 0) {
             InternalUnsafeMethods.Repaint__Args _args = new InternalUnsafeMethods.Repaint__Args() {
                elapsedMS = elapsedMS,
             };
             InternalUnsafeMethods.Repaint()(ObjectPtr, _args);
        }

        /// <summary>Determines if mouse cursor is rendering.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // Is cursor rendering?
        /// if(Canvas.isCursorShown())
        ///   echo("Canvas cursor is rendering");
        /// </code>
        /// <returns>Returns true if the cursor is rendering.</returns>
        public bool IsCursorShown() {
             InternalUnsafeMethods.IsCursorShown__Args _args = new InternalUnsafeMethods.IsCursorShown__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsCursorShown()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Determines if mouse cursor is enabled.</summary>
        /// <description>
        /// 
        /// </description>
        /// <code>
        /// // Is cursor on?
        /// if(Canvas.isCursorOn())
        ///   echo("Canvas cursor is on");
        /// </code>
        /// <returns>Returns true if the cursor is on.</returns>
        public bool IsCursorOn() {
             InternalUnsafeMethods.IsCursorOn__Args _args = new InternalUnsafeMethods.IsCursorOn__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsCursorOn()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Disable rendering of the cursor.</summary>
        /// <description>
        /// 
        /// </description>
        public void HideCursor() {
             InternalUnsafeMethods.HideCursor__Args _args = new InternalUnsafeMethods.HideCursor__Args() {
             };
             InternalUnsafeMethods.HideCursor()(ObjectPtr, _args);
        }

        /// <summary>Enable rendering of the cursor.</summary>
        /// <description>
        /// 
        /// </description>
        public void ShowCursor() {
             InternalUnsafeMethods.ShowCursor__Args _args = new InternalUnsafeMethods.ShowCursor__Args() {
             };
             InternalUnsafeMethods.ShowCursor()(ObjectPtr, _args);
        }

        /// <summary>This turns on/off front-buffer rendering.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="enable">True if all rendering should be done to the front buffer</param>
        public void RenderFront(bool enable) {
             InternalUnsafeMethods.RenderFront__Args _args = new InternalUnsafeMethods.RenderFront__Args() {
                enable = enable,
             };
             InternalUnsafeMethods.RenderFront()(ObjectPtr, _args);
        }

        /// <summary>Sets the cursor for the canvas.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="cursor">Name of the GuiCursor to use</param>
        public void SetCursor(GuiCursor cursor) {
             InternalUnsafeMethods.SetCursor__Args _args = new InternalUnsafeMethods.SetCursor__Args() {
                cursor = cursor.ObjectPtr,
             };
             InternalUnsafeMethods.SetCursor()(ObjectPtr, _args);
        }

        /// <summary>Turns on the mouse off.</summary>
        /// <description>
        /// 
        /// </description>
        public void CursorOff() {
             InternalUnsafeMethods.CursorOff__Args _args = new InternalUnsafeMethods.CursorOff__Args() {
             };
             InternalUnsafeMethods.CursorOff()(ObjectPtr, _args);
        }

        /// <summary>Turns on the mouse cursor.</summary>
        /// <description>
        /// 
        /// </description>
        public void CursorOn() {
             InternalUnsafeMethods.CursorOn__Args _args = new InternalUnsafeMethods.CursorOn__Args() {
             };
             InternalUnsafeMethods.CursorOn()(ObjectPtr, _args);
        }

        /// <description>
        /// (int layer)
        /// </description>
        public void PopLayer(int layer = 0) {
             InternalUnsafeMethods.PopLayer__Args _args = new InternalUnsafeMethods.PopLayer__Args() {
                layer = layer,
             };
             InternalUnsafeMethods.PopLayer()(ObjectPtr, _args);
        }

        /// <description>
        /// (GuiControl ctrl=NULL)
        /// </description>
        public void PopDialog(GuiControl gui = null) {
             InternalUnsafeMethods.PopDialog__Args _args = new InternalUnsafeMethods.PopDialog__Args() {
                gui = gui.ObjectPtr,
             };
             InternalUnsafeMethods.PopDialog()(ObjectPtr, _args);
        }

        /// <description>
        /// (GuiControl ctrl, int layer=0, bool center=false)
        /// </description>
        public void PushDialog(string ctrlName, int layer = 0, bool center = false) {
             InternalUnsafeMethods.PushDialog__Args _args = new InternalUnsafeMethods.PushDialog__Args() {
                ctrlName = ctrlName,
                layer = layer,
                center = center,
             };
             InternalUnsafeMethods.PushDialog()(ObjectPtr, _args);
        }

        /// <summary>Set the content of the canvas to a specified control.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="ctrl">ID or name of GuiControl to set content to</param>
        public void SetContent(GuiControl ctrl) {
             InternalUnsafeMethods.SetContent__Args _args = new InternalUnsafeMethods.SetContent__Args() {
                ctrl = ctrl.ObjectPtr,
             };
             InternalUnsafeMethods.SetContent()(ObjectPtr, _args);
        }

        /// <summary>Get the GuiControl which is being used as the content.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>ID of current content control</returns>
        public int GetContent() {
             InternalUnsafeMethods.GetContent__Args _args = new InternalUnsafeMethods.GetContent__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetContent()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Called when the canvas receives a setNativeAcceleratorsEnabled request. This is usually the result of a GuitTextInputCtrl gaining or losing focus. Return true to allow the request to be passed to the platform window. Return false to override the request and handle it in script.
        /// </description>
        /// <remarks> This callback is only issued if nativeAcceleratorMode is set to "Callback" for this canvas.
        /// </remarks>
        /// <param name="enable">Requested accelerator state.</param>
        /// <see cref="KeyboardTranslationMode" />
        public virtual bool OnSetNativeAcceleratorsEnabled(bool enable) {
             InternalUnsafeMethods.OnSetNativeAcceleratorsEnabled__Args _args = new InternalUnsafeMethods.OnSetNativeAcceleratorsEnabled__Args() {
                enable = enable,
             };
             bool _engineResult = InternalUnsafeMethods.OnSetNativeAcceleratorsEnabled()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Called when the canvas receives an enableKeyboardTranslation request. This is usually the result of a GuitTextInputCtrl gaining or losing focus. Return true to allow the request to be passed to the platform window. Return false to override the request and handle it in script.
        /// </description>
        /// <remarks> This callback is only issued if keyTranslationMode is set to "Callback" for this canvas.
        /// </remarks>
        /// <param name="enable">Requested keyboard translation state.</param>
        /// <see cref="KeyboardTranslationMode" />
        public virtual bool OnSetKeyboardTranslationEnabled(bool enable) {
             InternalUnsafeMethods.OnSetKeyboardTranslationEnabled__Args _args = new InternalUnsafeMethods.OnSetKeyboardTranslationEnabled__Args() {
                enable = enable,
             };
             bool _engineResult = InternalUnsafeMethods.OnSetKeyboardTranslationEnabled()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the GuiCanvas class.
        /// </description>
        /// <returns>The type info object for GuiCanvas</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Deal with mouse buttons, even if the cursor is hidden.
        /// </description>
        /// </value>
        public bool AlwaysHandleMouseButtons {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("alwaysHandleMouseButtons"));
            set => SetFieldValue("alwaysHandleMouseButtons", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The number of GFX fences to use.
        /// </description>
        /// </value>
        public int NumFences {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numFences"));
            set => SetFieldValue("numFences", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Controls if the canvas window is rendered or not.
        /// </description>
        /// </value>
        public bool DisplayWindow {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("displayWindow"));
            set => SetFieldValue("displayWindow", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// How to handle enable/disable keyboard translation requests. "Platform", "Callback" or "Ignore".
        /// </description>
        /// </value>
        public KeyboardTranslationMode KeyTranslationMode {
            get => GenericMarshal.StringTo<KeyboardTranslationMode>(GetFieldValue("keyTranslationMode"));
            set => SetFieldValue("keyTranslationMode", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// How to handle enable/disable native accelerator requests. "Platform", "Callback" or "Ignore".
        /// </description>
        /// </value>
        public KeyboardTranslationMode NativeAcceleratorMode {
            get => GenericMarshal.StringTo<KeyboardTranslationMode>(GetFieldValue("nativeAcceleratorMode"));
            set => SetFieldValue("nativeAcceleratorMode", GenericMarshal.ToString(value));
        }
    }
}
