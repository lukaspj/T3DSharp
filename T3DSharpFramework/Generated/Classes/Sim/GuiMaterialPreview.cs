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
    /// <summary>Visual preview of a specified Material</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class GuiMaterialPreview : GuiTSCtrl {
        public GuiMaterialPreview(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiMaterialPreview(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiMaterialPreview(string pName)
            : this(pName, false) {
        }

        public GuiMaterialPreview(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiMaterialPreview(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiMaterialPreview(SimObject pObj)
            : base(pObj) {
        }

        public GuiMaterialPreview(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAmbientLightColor__Args
            {
                internal IntPtr color;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAmbientLightColor(IntPtr _this, SetAmbientLightColor__Args args);
            private static _SetAmbientLightColor _SetAmbientLightColorFunc;
            internal static _SetAmbientLightColor SetAmbientLightColor() {
               _SetAmbientLightColorFunc ??= Torque3D.LookupEngineFunction<_SetAmbientLightColor>("fnGuiMaterialPreview_setAmbientLightColor");

                return _SetAmbientLightColorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetLightColor__Args
            {
                internal IntPtr color;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetLightColor(IntPtr _this, SetLightColor__Args args);
            private static _SetLightColor _SetLightColorFunc;
            internal static _SetLightColor SetLightColor() {
               _SetLightColorFunc ??= Torque3D.LookupEngineFunction<_SetLightColor>("fnGuiMaterialPreview_setLightColor");

                return _SetLightColorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
               _ResetFunc ??= Torque3D.LookupEngineFunction<_Reset>("fnGuiMaterialPreview_reset");

                return _ResetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetOrbitDistance__Args
            {
                internal float distance;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetOrbitDistance(IntPtr _this, SetOrbitDistance__Args args);
            private static _SetOrbitDistance _SetOrbitDistanceFunc;
            internal static _SetOrbitDistance SetOrbitDistance() {
               _SetOrbitDistanceFunc ??= Torque3D.LookupEngineFunction<_SetOrbitDistance>("fnGuiMaterialPreview_setOrbitDistance");

                return _SetOrbitDistanceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DeleteModel__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DeleteModel(IntPtr _this, DeleteModel__Args args);
            private static _DeleteModel _DeleteModelFunc;
            internal static _DeleteModel DeleteModel() {
               _DeleteModelFunc ??= Torque3D.LookupEngineFunction<_DeleteModel>("fnGuiMaterialPreview_deleteModel");

                return _DeleteModelFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetModel__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string shapeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetModel(IntPtr _this, SetModel__Args args);
            private static _SetModel _SetModelFunc;
            internal static _SetModel SetModel() {
               _SetModelFunc ??= Torque3D.LookupEngineFunction<_SetModel>("fnGuiMaterialPreview_setModel");

                return _SetModelFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiMaterialPreview_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiMaterialPreview_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Sets the color of the ambient light in the scene.
        /// </description>
        public void SetAmbientLightColor(LinearColorF color) {
color.Alloc();             InternalUnsafeMethods.SetAmbientLightColor__Args _args = new InternalUnsafeMethods.SetAmbientLightColor__Args() {
                color = color.internalStructPtr,
             };
             InternalUnsafeMethods.SetAmbientLightColor()(ObjectPtr, _args);
color.Free();        }

        /// <description>
        /// Sets the color of the light in the scene.
        /// </description>
        public void SetLightColor(LinearColorF color) {
color.Alloc();             InternalUnsafeMethods.SetLightColor__Args _args = new InternalUnsafeMethods.SetLightColor__Args() {
                color = color.internalStructPtr,
             };
             InternalUnsafeMethods.SetLightColor()(ObjectPtr, _args);
color.Free();        }

        /// <description>
        /// Resets the viewport to default zoom, pan, rotate and lighting.
        /// </description>
        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the distance at which the camera orbits the object. Clamped to the acceptable range defined in the class by min and max orbit distances.
        /// </description>
        /// <param name="distance">The distance to set the orbit to (will be clamped).</param>
        public void SetOrbitDistance(float distance) {
             InternalUnsafeMethods.SetOrbitDistance__Args _args = new InternalUnsafeMethods.SetOrbitDistance__Args() {
                distance = distance,
             };
             InternalUnsafeMethods.SetOrbitDistance()(ObjectPtr, _args);
        }

        /// <description>
        /// Deletes the preview model.
        /// </description>
        public void DeleteModel() {
             InternalUnsafeMethods.DeleteModel__Args _args = new InternalUnsafeMethods.DeleteModel__Args() {
             };
             InternalUnsafeMethods.DeleteModel()(ObjectPtr, _args);
        }

        /// <description>
        /// Sets the model to be displayed in this control
        /// </description>
        /// <param name="shapeName">Name of the model to display.</param>
        public void SetModel(string shapeName) {
             InternalUnsafeMethods.SetModel__Args _args = new InternalUnsafeMethods.SetModel__Args() {
                shapeName = shapeName,
             };
             InternalUnsafeMethods.SetModel()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiMaterialPreview class.
        /// </description>
        /// <returns>The type info object for GuiMaterialPreview</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
