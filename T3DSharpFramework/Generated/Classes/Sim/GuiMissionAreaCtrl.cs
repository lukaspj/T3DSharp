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
    /// <summary>Visual representation of Mission Area Editor.</summary>
    /// <description>
    /// 
    /// </description>
    public class GuiMissionAreaCtrl : GuiBitmapCtrl {
        public GuiMissionAreaCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiMissionAreaCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiMissionAreaCtrl(string pName)
            : this(pName, false) {
        }

        public GuiMissionAreaCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiMissionAreaCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiMissionAreaCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiMissionAreaCtrl(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct UpdateTerrain__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UpdateTerrain(IntPtr _this, UpdateTerrain__Args args);
            private static _UpdateTerrain _UpdateTerrainFunc;
            internal static _UpdateTerrain UpdateTerrain() {
               _UpdateTerrainFunc ??= Torque3D.LookupEngineFunction<_UpdateTerrain>("fnGuiMissionAreaCtrl_updateTerrain");

                return _UpdateTerrainFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMissionArea__Args
            {
                internal IntPtr area;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMissionArea(IntPtr _this, SetMissionArea__Args args);
            private static _SetMissionArea _SetMissionAreaFunc;
            internal static _SetMissionArea SetMissionArea() {
               _SetMissionAreaFunc ??= Torque3D.LookupEngineFunction<_SetMissionArea>("fnGuiMissionAreaCtrl_setMissionArea");

                return _SetMissionAreaFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiMissionAreaCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiMissionAreaCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Update the terrain bitmap.</summary>
        /// <description>
        /// 
        /// </description>
        public void UpdateTerrain() {
             InternalUnsafeMethods.UpdateTerrain__Args _args = new InternalUnsafeMethods.UpdateTerrain__Args() {
             };
             InternalUnsafeMethods.UpdateTerrain()(ObjectPtr, _args);
        }

        /// <summary>Set the MissionArea to edit.</summary>
        /// <description>
        /// 
        /// </description>
        public void SetMissionArea(MissionArea area) {
             InternalUnsafeMethods.SetMissionArea__Args _args = new InternalUnsafeMethods.SetMissionArea__Args() {
                area = area.ObjectPtr,
             };
             InternalUnsafeMethods.SetMissionArea()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiMissionAreaCtrl class.
        /// </description>
        /// <returns>The type info object for GuiMissionAreaCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public bool SquareBitmap {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("squareBitmap"));
            set => SetFieldValue("squareBitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>HandleBitmap "Bitmap for the mission area handles.\n"</summary>
        /// </value>
        public string HandleBitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("HandleBitmap"));
            set => SetFieldValue("HandleBitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>HandleBitmap asset "Bitmap for the mission area handles.\n".</summary>
        /// </value>
        public string HandleBitmapAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("HandleBitmapAsset"));
            set => SetFieldValue("HandleBitmapAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI MissionBoundsColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("missionBoundsColor"));
            set => SetFieldValue("missionBoundsColor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public ColorI CameraColor {
            get => GenericMarshal.StringTo<ColorI>(GetFieldValue("cameraColor"));
            set => SetFieldValue("cameraColor", GenericMarshal.ToString(value));
        }
    }
}
