using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DSharpFramework.Generated.Classes.Global;
using T3DSharpFramework.Generated.Classes.Net;
using T3DSharpFramework.Generated.Classes.Sim;
using T3DSharpFramework.Generated.Classes.Sim.Console;
using T3DSharpFramework.Generated.Classes.Sim.Net;
using T3DSharpFramework.Generated.Enums.Global;
using T3DSharpFramework.Generated.Structs.Global;
using T3DSharpFramework.Generated.Structs.Gui;
using T3DSharpFramework.Generated.Structs.Math;
using T3DSharpFramework.Interop;

namespace T3DSharpFramework.Generated.Functions {

    public static class SDLInputManager {

        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerMappingForIndex__Args
            {
                internal int mappingIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GameControllerMappingForIndex(GameControllerMappingForIndex__Args args);
            private static _GameControllerMappingForIndex _GameControllerMappingForIndexFunc;
            internal static _GameControllerMappingForIndex GameControllerMappingForIndex() {
               _GameControllerMappingForIndexFunc ??= Torque3D.LookupEngineFunction<_GameControllerMappingForIndex>("fnSDLInputManager_GameControllerMappingForIndex");

                return _GameControllerMappingForIndexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerNumMappings__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GameControllerNumMappings(GameControllerNumMappings__Args args);
            private static _GameControllerNumMappings _GameControllerNumMappingsFunc;
            internal static _GameControllerNumMappings GameControllerNumMappings() {
               _GameControllerNumMappingsFunc ??= Torque3D.LookupEngineFunction<_GameControllerNumMappings>("fnSDLInputManager_GameControllerNumMappings");

                return _GameControllerNumMappingsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerAddMappingsFromFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GameControllerAddMappingsFromFile(GameControllerAddMappingsFromFile__Args args);
            private static _GameControllerAddMappingsFromFile _GameControllerAddMappingsFromFileFunc;
            internal static _GameControllerAddMappingsFromFile GameControllerAddMappingsFromFile() {
               _GameControllerAddMappingsFromFileFunc ??= Torque3D.LookupEngineFunction<_GameControllerAddMappingsFromFile>("fnSDLInputManager_GameControllerAddMappingsFromFile");

                return _GameControllerAddMappingsFromFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerAddMapping__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string mappingString;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GameControllerAddMapping(GameControllerAddMapping__Args args);
            private static _GameControllerAddMapping _GameControllerAddMappingFunc;
            internal static _GameControllerAddMapping GameControllerAddMapping() {
               _GameControllerAddMappingFunc ??= Torque3D.LookupEngineFunction<_GameControllerAddMapping>("fnSDLInputManager_GameControllerAddMapping");

                return _GameControllerAddMappingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerMappingForGUID__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string guidStr;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GameControllerMappingForGUID(GameControllerMappingForGUID__Args args);
            private static _GameControllerMappingForGUID _GameControllerMappingForGUIDFunc;
            internal static _GameControllerMappingForGUID GameControllerMappingForGUID() {
               _GameControllerMappingForGUIDFunc ??= Torque3D.LookupEngineFunction<_GameControllerMappingForGUID>("fnSDLInputManager_GameControllerMappingForGUID");

                return _GameControllerMappingForGUIDFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GameControllerMapping__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GameControllerMapping(GameControllerMapping__Args args);
            private static _GameControllerMapping _GameControllerMappingFunc;
            internal static _GameControllerMapping GameControllerMapping() {
               _GameControllerMappingFunc ??= Torque3D.LookupEngineFunction<_GameControllerMapping>("fnSDLInputManager_GameControllerMapping");

                return _GameControllerMappingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ControllerGetButtons__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ControllerGetButtons(ControllerGetButtons__Args args);
            private static _ControllerGetButtons _ControllerGetButtonsFunc;
            internal static _ControllerGetButtons ControllerGetButtons() {
               _ControllerGetButtonsFunc ??= Torque3D.LookupEngineFunction<_ControllerGetButtons>("fnSDLInputManager_ControllerGetButtons");

                return _ControllerGetButtonsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ControllerGetAxes__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ControllerGetAxes(ControllerGetAxes__Args args);
            private static _ControllerGetAxes _ControllerGetAxesFunc;
            internal static _ControllerGetAxes ControllerGetAxes() {
               _ControllerGetAxesFunc ??= Torque3D.LookupEngineFunction<_ControllerGetAxes>("fnSDLInputManager_ControllerGetAxes");

                return _ControllerGetAxesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetHats__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetHats(JoystickGetHats__Args args);
            private static _JoystickGetHats _JoystickGetHatsFunc;
            internal static _JoystickGetHats JoystickGetHats() {
               _JoystickGetHatsFunc ??= Torque3D.LookupEngineFunction<_JoystickGetHats>("fnSDLInputManager_JoystickGetHats");

                return _JoystickGetHatsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetButtons__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetButtons(JoystickGetButtons__Args args);
            private static _JoystickGetButtons _JoystickGetButtonsFunc;
            internal static _JoystickGetButtons JoystickGetButtons() {
               _JoystickGetButtonsFunc ??= Torque3D.LookupEngineFunction<_JoystickGetButtons>("fnSDLInputManager_JoystickGetButtons");

                return _JoystickGetButtonsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetAxes__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetAxes(JoystickGetAxes__Args args);
            private static _JoystickGetAxes _JoystickGetAxesFunc;
            internal static _JoystickGetAxes JoystickGetAxes() {
               _JoystickGetAxesFunc ??= Torque3D.LookupEngineFunction<_JoystickGetAxes>("fnSDLInputManager_JoystickGetAxes");

                return _JoystickGetAxesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetSpecs__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetSpecs(JoystickGetSpecs__Args args);
            private static _JoystickGetSpecs _JoystickGetSpecsFunc;
            internal static _JoystickGetSpecs JoystickGetSpecs() {
               _JoystickGetSpecsFunc ??= Torque3D.LookupEngineFunction<_JoystickGetSpecs>("fnSDLInputManager_JoystickGetSpecs");

                return _JoystickGetSpecsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickPowerLevel__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickPowerLevel(JoystickPowerLevel__Args args);
            private static _JoystickPowerLevel _JoystickPowerLevelFunc;
            internal static _JoystickPowerLevel JoystickPowerLevel() {
               _JoystickPowerLevelFunc ??= Torque3D.LookupEngineFunction<_JoystickPowerLevel>("fnSDLInputManager_JoystickPowerLevel");

                return _JoystickPowerLevelFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickIsHaptic__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _JoystickIsHaptic(JoystickIsHaptic__Args args);
            private static _JoystickIsHaptic _JoystickIsHapticFunc;
            internal static _JoystickIsHaptic JoystickIsHaptic() {
               _JoystickIsHapticFunc ??= Torque3D.LookupEngineFunction<_JoystickIsHaptic>("fnSDLInputManager_JoystickIsHaptic");

                return _JoystickIsHapticFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsGameController__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsGameController(IsGameController__Args args);
            private static _IsGameController _IsGameControllerFunc;
            internal static _IsGameController IsGameController() {
               _IsGameControllerFunc ??= Torque3D.LookupEngineFunction<_IsGameController>("fnSDLInputManager_IsGameController");

                return _IsGameControllerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNumHats__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickNumHats(JoystickNumHats__Args args);
            private static _JoystickNumHats _JoystickNumHatsFunc;
            internal static _JoystickNumHats JoystickNumHats() {
               _JoystickNumHatsFunc ??= Torque3D.LookupEngineFunction<_JoystickNumHats>("fnSDLInputManager_JoystickNumHats");

                return _JoystickNumHatsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNumButtons__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickNumButtons(JoystickNumButtons__Args args);
            private static _JoystickNumButtons _JoystickNumButtonsFunc;
            internal static _JoystickNumButtons JoystickNumButtons() {
               _JoystickNumButtonsFunc ??= Torque3D.LookupEngineFunction<_JoystickNumButtons>("fnSDLInputManager_JoystickNumButtons");

                return _JoystickNumButtonsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNumBalls__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickNumBalls(JoystickNumBalls__Args args);
            private static _JoystickNumBalls _JoystickNumBallsFunc;
            internal static _JoystickNumBalls JoystickNumBalls() {
               _JoystickNumBallsFunc ??= Torque3D.LookupEngineFunction<_JoystickNumBalls>("fnSDLInputManager_JoystickNumBalls");

                return _JoystickNumBallsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNumAxes__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _JoystickNumAxes(JoystickNumAxes__Args args);
            private static _JoystickNumAxes _JoystickNumAxesFunc;
            internal static _JoystickNumAxes JoystickNumAxes() {
               _JoystickNumAxesFunc ??= Torque3D.LookupEngineFunction<_JoystickNumAxes>("fnSDLInputManager_JoystickNumAxes");

                return _JoystickNumAxesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDeviceType__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDeviceType(GetDeviceType__Args args);
            private static _GetDeviceType _GetDeviceTypeFunc;
            internal static _GetDeviceType GetDeviceType() {
               _GetDeviceTypeFunc ??= Torque3D.LookupEngineFunction<_GetDeviceType>("fnSDLInputManager_GetDeviceType");

                return _GetDeviceTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetProductVersion__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetProductVersion(GetProductVersion__Args args);
            private static _GetProductVersion _GetProductVersionFunc;
            internal static _GetProductVersion GetProductVersion() {
               _GetProductVersionFunc ??= Torque3D.LookupEngineFunction<_GetProductVersion>("fnSDLInputManager_GetProductVersion");

                return _GetProductVersionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetProduct__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetProduct(GetProduct__Args args);
            private static _GetProduct _GetProductFunc;
            internal static _GetProduct GetProduct() {
               _GetProductFunc ??= Torque3D.LookupEngineFunction<_GetProduct>("fnSDLInputManager_GetProduct");

                return _GetProductFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetVendor__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetVendor(GetVendor__Args args);
            private static _GetVendor _GetVendorFunc;
            internal static _GetVendor GetVendor() {
               _GetVendorFunc ??= Torque3D.LookupEngineFunction<_GetVendor>("fnSDLInputManager_GetVendor");

                return _GetVendorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickGetGUID__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickGetGUID(JoystickGetGUID__Args args);
            private static _JoystickGetGUID _JoystickGetGUIDFunc;
            internal static _JoystickGetGUID JoystickGetGUID() {
               _JoystickGetGUIDFunc ??= Torque3D.LookupEngineFunction<_JoystickGetGUID>("fnSDLInputManager_JoystickGetGUID");

                return _JoystickGetGUIDFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ControllerNameForIndex__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ControllerNameForIndex(ControllerNameForIndex__Args args);
            private static _ControllerNameForIndex _ControllerNameForIndexFunc;
            internal static _ControllerNameForIndex ControllerNameForIndex() {
               _ControllerNameForIndexFunc ??= Torque3D.LookupEngineFunction<_ControllerNameForIndex>("fnSDLInputManager_ControllerNameForIndex");

                return _ControllerNameForIndexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct JoystickNameForIndex__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _JoystickNameForIndex(JoystickNameForIndex__Args args);
            private static _JoystickNameForIndex _JoystickNameForIndexFunc;
            internal static _JoystickNameForIndex JoystickNameForIndex() {
               _JoystickNameForIndexFunc ??= Torque3D.LookupEngineFunction<_JoystickNameForIndex>("fnSDLInputManager_JoystickNameForIndex");

                return _JoystickNameForIndexFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetTorqueInstFromDevice__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetTorqueInstFromDevice(GetTorqueInstFromDevice__Args args);
            private static _GetTorqueInstFromDevice _GetTorqueInstFromDeviceFunc;
            internal static _GetTorqueInstFromDevice GetTorqueInstFromDevice() {
               _GetTorqueInstFromDeviceFunc ??= Torque3D.LookupEngineFunction<_GetTorqueInstFromDevice>("fnSDLInputManager_getTorqueInstFromDevice");

                return _GetTorqueInstFromDeviceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct CloseDevice__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _CloseDevice(CloseDevice__Args args);
            private static _CloseDevice _CloseDeviceFunc;
            internal static _CloseDevice CloseDevice() {
               _CloseDeviceFunc ??= Torque3D.LookupEngineFunction<_CloseDevice>("fnSDLInputManager_closeDevice");

                return _CloseDeviceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OpenAsController__Args
            {
                internal int sdlIndex;
                internal int torqueInstId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _OpenAsController(OpenAsController__Args args);
            private static _OpenAsController _OpenAsControllerFunc;
            internal static _OpenAsController OpenAsController() {
               _OpenAsControllerFunc ??= Torque3D.LookupEngineFunction<_OpenAsController>("fnSDLInputManager_openAsController");

                return _OpenAsControllerFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OpenAsJoystick__Args
            {
                internal int sdlIndex;
                internal int torqueInstId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _OpenAsJoystick(OpenAsJoystick__Args args);
            private static _OpenAsJoystick _OpenAsJoystickFunc;
            internal static _OpenAsJoystick OpenAsJoystick() {
               _OpenAsJoystickFunc ??= Torque3D.LookupEngineFunction<_OpenAsJoystick>("fnSDLInputManager_openAsJoystick");

                return _OpenAsJoystickFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetDeviceOpenState__Args
            {
                internal int sdlIndex;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetDeviceOpenState(GetDeviceOpenState__Args args);
            private static _GetDeviceOpenState _GetDeviceOpenStateFunc;
            internal static _GetDeviceOpenState GetDeviceOpenState() {
               _GetDeviceOpenStateFunc ??= Torque3D.LookupEngineFunction<_GetDeviceOpenState>("fnSDLInputManager_getDeviceOpenState");

                return _GetDeviceOpenStateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct NumJoysticks__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _NumJoysticks(NumJoysticks__Args args);
            private static _NumJoysticks _NumJoysticksFunc;
            internal static _NumJoysticks NumJoysticks() {
               _NumJoysticksFunc ??= Torque3D.LookupEngineFunction<_NumJoysticks>("fnSDLInputManager_numJoysticks");

                return _NumJoysticksFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the mapping at a particular index.
        /// </description>
        /// <param name="mappingIndex">The index for which a mapping is desired.</param>
        /// <returns>Returns a mapping string or NULL if the index is out of range.</returns>
        public static string GameControllerMappingForIndex(int mappingIndex) {
             InternalUnsafeMethods.GameControllerMappingForIndex__Args _args = new InternalUnsafeMethods.GameControllerMappingForIndex__Args() {
                mappingIndex = mappingIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GameControllerMappingForIndex()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the number of mappings installed. Used with GameControllerMappingForIndex to iterate through all installed mappings.
        /// </description>
        public static int GameControllerNumMappings() {
             InternalUnsafeMethods.GameControllerNumMappings__Args _args = new InternalUnsafeMethods.GameControllerNumMappings__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GameControllerNumMappings()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_GameControllerAddMappingsFromFile() to script.</summary>
        /// <description>
        /// Use this function to load a set of Game Controller mappings from a file, filtered by the current SDL_GetPlatform(). A community sourced database of controllers is available at https://raw.githubusercontent.com/gabomdq/SDL_GameControllerDB/master/gamecontrollerdb.txt
        /// </description>
        /// <param name="fileName">The file to load mappings from.</param>
        /// <returns>Returns the number of mappings added or -1 on error.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_GameControllerAddMappingsFromFile" />
        public static int GameControllerAddMappingsFromFile(string fileName) {
             InternalUnsafeMethods.GameControllerAddMappingsFromFile__Args _args = new InternalUnsafeMethods.GameControllerAddMappingsFromFile__Args() {
                fileName = fileName,
             };
             int _engineResult = InternalUnsafeMethods.GameControllerAddMappingsFromFile()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_GameControllerAddMapping() to script.</summary>
        /// <description>
        /// Use this function to add support for controllers that SDL is unaware of or to cause an existing controller to have a different binding.
        /// </description>
        /// <param name="mappingString">The new mapping string to apply. Full details on the format of this string are available at the linked SDL wiki page.</param>
        /// <returns>Returns 1 if a new mapping is added, 0 if an existing mapping is updated, -1 on error.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_GameControllerAddMapping" />
        public static int GameControllerAddMapping(string mappingString) {
             InternalUnsafeMethods.GameControllerAddMapping__Args _args = new InternalUnsafeMethods.GameControllerAddMapping__Args() {
                mappingString = mappingString,
             };
             int _engineResult = InternalUnsafeMethods.GameControllerAddMapping()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_GameControllerMappingForGUID() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="guidStr">The GUID for which a mapping is desired.</param>
        /// <returns>Returns a mapping string or NULL on error.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_GameControllerMappingForGUID" />
        public static string GameControllerMappingForGUID(string guidStr) {
             InternalUnsafeMethods.GameControllerMappingForGUID__Args _args = new InternalUnsafeMethods.GameControllerMappingForGUID__Args() {
                guidStr = guidStr,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GameControllerMappingForGUID()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Exposes SDL_GameControllerMapping() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns a string that has the controller's mapping or NULL if no mapping is available or it does not exist.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickNameForIndex" />
        public static string GameControllerMapping(int sdlIndex = 0) {
             InternalUnsafeMethods.GameControllerMapping__Args _args = new InternalUnsafeMethods.GameControllerMapping__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GameControllerMapping()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets the current value for all controller buttons.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>A tab separated string that can be parsed from script with getField()/getFields(). Game controllers always have 15 buttons in the following order: 0-A, 1-B, 2-X, 3-Y, 4-Back, 5-Guide, 6-Start, 7-Left Stick, 8-Right Stick, 9-Left Shoulder, 10-Right Shoulder, 11-DPad Up, 12-DPad Down, 13-DPad Left, 14-DPad Right.</returns>
        public static string ControllerGetButtons(int sdlIndex = 0) {
             InternalUnsafeMethods.ControllerGetButtons__Args _args = new InternalUnsafeMethods.ControllerGetButtons__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.ControllerGetButtons()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets the current value for all controller axes.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>A tab separated string that can be parsed from script with getField()/getFields(). Game controllers always have 6 axes in the following order: 0-LX, 1-LY, 2-RX, 3-RY, 4-LT, 5-RT.</returns>
        public static string ControllerGetAxes(int sdlIndex = 0) {
             InternalUnsafeMethods.ControllerGetAxes__Args _args = new InternalUnsafeMethods.ControllerGetAxes__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.ControllerGetAxes()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets the current value for all POV hats.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>A tab separated string that can be parsed from script with getField()/getFields(). Each hat is one field. 0 - SDL_JoystickNumHats() fields. The value is a 4 bit bitmask. If no bits are set, the hat is centered. Bit 0 is up, 1 is right, 2 is down and 3 is left.</returns>
        public static string JoystickGetHats(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetHats__Args _args = new InternalUnsafeMethods.JoystickGetHats__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetHats()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets the current value for all joystick buttons.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>A tab separated string that can be parsed from script with getField()/getFields(). Each button is one field. 0 - SDL_JoystickNumButtons() fields.</returns>
        public static string JoystickGetButtons(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetButtons__Args _args = new InternalUnsafeMethods.JoystickGetButtons__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetButtons()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets the current value for all joystick axes.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>A tab separated string that can be parsed from script with getField()/getFields(). Each axis is one field, so a 4 axis device will have 4 fields.</returns>
        public static string JoystickGetAxes(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetAxes__Args _args = new InternalUnsafeMethods.JoystickGetAxes__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetAxes()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>A convenience function to reurn all of the data for a Joystick/Game Controller  packed as fields in a tab separated string.</summary>
        /// <description>
        /// There is overhead involved in querying joystick data, especially if the device is not open. If more than one field is required, it is more efficient to call JoystickGetSpecs() and parse the data out of the return string than to call the console method for each.
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>A tab separated string that can be parsed from script with getField()/getFields().
        /// 
        /// Field 0: Number of Axes
        ///       1: Number of Buttons
        ///       2: Number of POV Hats
        ///       3: Number of Trackballs
        ///       4: SDL_IsGameController() (Boolean)
        ///       5: SDL_JoystickIsHaptic() (Boolean)
        ///       6: Power Level (String)
        ///       7: Device Type (String)</returns>
        public static string JoystickGetSpecs(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetSpecs__Args _args = new InternalUnsafeMethods.JoystickGetSpecs__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetSpecs()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Exposes SDL_JoystickCurrentPowerLevel() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns the current battery level or "Wired" if it's a connected device.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickCurrentPowerLevel" />
        public static SDLPowerEnum JoystickPowerLevel(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickPowerLevel__Args _args = new InternalUnsafeMethods.JoystickPowerLevel__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickPowerLevel()(_args);
             return (SDLPowerEnum)_engineResult;
        }

        /// <summary>Exposes SDL_JoystickIsHaptic() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns true if the joystick is haptic.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickIsHaptic" />
        public static bool JoystickIsHaptic(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickIsHaptic__Args _args = new InternalUnsafeMethods.JoystickIsHaptic__Args() {
                sdlIndex = sdlIndex,
             };
             bool _engineResult = InternalUnsafeMethods.JoystickIsHaptic()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_IsGameController() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns true if the given joystick is supported by the game controller interface, false if it isn't or it's an invalid index.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_IsGameController" />
        public static bool IsGameController(int sdlIndex = 0) {
             InternalUnsafeMethods.IsGameController__Args _args = new InternalUnsafeMethods.IsGameController__Args() {
                sdlIndex = sdlIndex,
             };
             bool _engineResult = InternalUnsafeMethods.IsGameController()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_JoystickNumHats() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns the number of POV hats on success or zero on failure.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickNumHats" />
        public static int JoystickNumHats(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNumHats__Args _args = new InternalUnsafeMethods.JoystickNumHats__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickNumHats()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_JoystickNumButtons() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns the number of buttons on success or zero on failure.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickNumButtons" />
        public static int JoystickNumButtons(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNumButtons__Args _args = new InternalUnsafeMethods.JoystickNumButtons__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickNumButtons()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_JoystickNumBalls() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns the number of trackballs on success or zero on failure.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickNumBalls" />
        public static int JoystickNumBalls(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNumBalls__Args _args = new InternalUnsafeMethods.JoystickNumBalls__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickNumBalls()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_JoystickNumAxes() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns the number of axis controls/number of axes on success or zero on failure.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickNumAxes" />
        public static int JoystickNumAxes(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNumAxes__Args _args = new InternalUnsafeMethods.JoystickNumAxes__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.JoystickNumAxes()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_JoystickGetDeviceType() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>The type of device connected. Possible return strings are: "Unknown", "Game Controller", "Wheel", "Arcade Stick", "Flight Stick", "Dance Pad", "Guitar", "Drum Kit", "Arcade Pad" and "Throttle"</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickGetDeviceType" />
        public static SDLJoystickType GetDeviceType(int sdlIndex = 0) {
             InternalUnsafeMethods.GetDeviceType__Args _args = new InternalUnsafeMethods.GetDeviceType__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetDeviceType()(_args);
             return (SDLJoystickType)_engineResult;
        }

        /// <description>
        /// Gets the product version of a joystick device, if available.
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>The product version. If the product version isn't available this function returns 0.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickGetDeviceProductVersion" />
        /// <see href="https://wiki.libsdl.org/SDL_JoystickGetProductVersion" />
        /// <see href="https://wiki.libsdl.org/SDL_GameControllerGetProductVersion" />
        public static int GetProductVersion(int sdlIndex = 0) {
             InternalUnsafeMethods.GetProductVersion__Args _args = new InternalUnsafeMethods.GetProductVersion__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetProductVersion()(_args);
             return _engineResult;
        }

        /// <description>
        /// Gets the USB product ID of a joystick device, if available.
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>The USB product ID. If the product ID isn't available this function returns 0.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickGetDeviceProduct" />
        /// <see href="https://wiki.libsdl.org/SDL_JoystickGetProduct" />
        /// <see href="https://wiki.libsdl.org/SDL_GameControllerGetProduct" />
        public static int GetProduct(int sdlIndex = 0) {
             InternalUnsafeMethods.GetProduct__Args _args = new InternalUnsafeMethods.GetProduct__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetProduct()(_args);
             return _engineResult;
        }

        /// <description>
        /// Gets the USB vendor ID of a joystick device, if available.
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>The USB vendor ID. If the vendor ID isn't available this function returns 0.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickGetDeviceVendor" />
        /// <see href="https://wiki.libsdl.org/SDL_JoystickGetVendor" />
        /// <see href="https://wiki.libsdl.org/SDL_GameControllerGetVendor" />
        public static int GetVendor(int sdlIndex = 0) {
             InternalUnsafeMethods.GetVendor__Args _args = new InternalUnsafeMethods.GetVendor__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetVendor()(_args);
             return _engineResult;
        }

        /// <summary>Exposes SDL_JoystickGetDeviceGUID() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>GUID for the indexed device or Null if it does not exist.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickGetDeviceGUID" />
        public static string JoystickGetGUID(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickGetGUID__Args _args = new InternalUnsafeMethods.JoystickGetGUID__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickGetGUID()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Exposes SDL_GameControllerNameForIndex() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns the implementation dependent name for the game controller, or NULL if there is no name or the index is invalid.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_GameControllerNameForIndex" />
        public static string ControllerNameForIndex(int sdlIndex = 0) {
             InternalUnsafeMethods.ControllerNameForIndex__Args _args = new InternalUnsafeMethods.ControllerNameForIndex__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.ControllerNameForIndex()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Exposes SDL_JoystickNameForIndex() to script.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns the name of the selected joystick or Null if it does not exist.</returns>
        /// <see href="https://wiki.libsdl.org/SDL_JoystickNameForIndex" />
        public static string JoystickNameForIndex(int sdlIndex = 0) {
             InternalUnsafeMethods.JoystickNameForIndex__Args _args = new InternalUnsafeMethods.JoystickNameForIndex__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.JoystickNameForIndex()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Gets the T3D instance identifier for an open SDL joystick.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>Returns the T3D instance ID used for mapping this device or Null if it does not exist.</returns>
        public static string GetTorqueInstFromDevice(int sdlIndex = 0) {
             InternalUnsafeMethods.GetTorqueInstFromDevice__Args _args = new InternalUnsafeMethods.GetTorqueInstFromDevice__Args() {
                sdlIndex = sdlIndex,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetTorqueInstFromDevice()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Used to close the N'th item in the SDL device list.</summary>
        /// <description>
        /// This will close a Joystick or Game Controller.
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        public static void CloseDevice(int sdlIndex = 0) {
             InternalUnsafeMethods.CloseDevice__Args _args = new InternalUnsafeMethods.CloseDevice__Args() {
                sdlIndex = sdlIndex,
             };
             InternalUnsafeMethods.CloseDevice()(_args);
        }

        /// <summary>Used to open the device as a Game Controller.</summary>
        /// <description>
        /// If the device is currently open as a Joystick, it will be closed and opened as a Game Controller. If it is currently opened as a Game Controller with a different T3D instance ID, it will be changed to the requested ID if that ID is available.
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <param name="torqueInstId">Is the requested T3D device instance ID. If there is already an open Game Controller with the requested ID, The first available ID will be assigned.</param>
        /// <returns>The T3D device instance ID assigned, or -1 if the device could not be opened.</returns>
        public static int OpenAsController(int sdlIndex = 0, int torqueInstId = 0) {
             InternalUnsafeMethods.OpenAsController__Args _args = new InternalUnsafeMethods.OpenAsController__Args() {
                sdlIndex = sdlIndex,
                torqueInstId = torqueInstId,
             };
             int _engineResult = InternalUnsafeMethods.OpenAsController()(_args);
             return _engineResult;
        }

        /// <summary>Used to open the device as a Joystick.</summary>
        /// <description>
        /// If the device is currently open as a Game Controller, it will be closed and opened as a Joystick. If it is currently opened as a Joystick with a different T3D instance ID, it will be changed to the requested ID if that ID is available.
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <param name="torqueInstId">Is the requested T3D device instance ID. If there is already an open Joystick with the requested ID, The first available ID will be assigned.</param>
        /// <returns>The T3D device instance ID assigned, or -1 if the device could not be opened.</returns>
        public static int OpenAsJoystick(int sdlIndex = 0, int torqueInstId = 0) {
             InternalUnsafeMethods.OpenAsJoystick__Args _args = new InternalUnsafeMethods.OpenAsJoystick__Args() {
                sdlIndex = sdlIndex,
                torqueInstId = torqueInstId,
             };
             int _engineResult = InternalUnsafeMethods.OpenAsJoystick()(_args);
             return _engineResult;
        }

        /// <summary>Used to determine the current state of the N'th item in the SDL device list.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="sdlIndex">The SDL index for this device.</param>
        /// <returns>values:
        /// -1 if the device does not exist (invalid sdlIndex passed)
        /// 0 The device is closed
        /// 1 The device is open as a Joystick
        /// 2 The device is open as a Game Controller</returns>
        public static int GetDeviceOpenState(int sdlIndex = 0) {
             InternalUnsafeMethods.GetDeviceOpenState__Args _args = new InternalUnsafeMethods.GetDeviceOpenState__Args() {
                sdlIndex = sdlIndex,
             };
             int _engineResult = InternalUnsafeMethods.GetDeviceOpenState()(_args);
             return _engineResult;
        }

        /// <summary>Returns the number of currently connected joystick devices.</summary>
        /// <description>
        /// Game Controllers are a sub-set of joysticks and are included in the joystick count. See https://wiki.libsdl.org/SDL_NumJoysticks for more details.
        /// </description>
        public static int NumJoysticks() {
             InternalUnsafeMethods.NumJoysticks__Args _args = new InternalUnsafeMethods.NumJoysticks__Args() {
             };
             int _engineResult = InternalUnsafeMethods.NumJoysticks()(_args);
             return _engineResult;
        }

    }
}
