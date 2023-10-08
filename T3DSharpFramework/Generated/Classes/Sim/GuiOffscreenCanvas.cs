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
    /// 
    public class GuiOffscreenCanvas : GuiCanvas {
        public GuiOffscreenCanvas(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public GuiOffscreenCanvas(string pName, bool pRegister)
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

        public GuiOffscreenCanvas(string pName)
            : this(pName, false) {
        }

        public GuiOffscreenCanvas(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiOffscreenCanvas(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiOffscreenCanvas(SimObject pObj)
            : base(pObj) {
        }

        public GuiOffscreenCanvas(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct MarkDirty__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _MarkDirty(IntPtr _this, MarkDirty__Args args);
            private static _MarkDirty _MarkDirtyFunc;
            internal static _MarkDirty MarkDirty() {
               _MarkDirtyFunc ??= Torque3D.LookupEngineFunction<_MarkDirty>("fnGuiOffscreenCanvas_markDirty");

                return _MarkDirtyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ResetTarget__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ResetTarget(IntPtr _this, ResetTarget__Args args);
            private static _ResetTarget _ResetTargetFunc;
            internal static _ResetTarget ResetTarget() {
               _ResetTargetFunc ??= Torque3D.LookupEngineFunction<_ResetTarget>("fnGuiOffscreenCanvas_resetTarget");

                return _ResetTargetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiOffscreenCanvas_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiOffscreenCanvas_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// 
        public void MarkDirty() {
             InternalUnsafeMethods.MarkDirty__Args _args = new InternalUnsafeMethods.MarkDirty__Args() {
             };
             InternalUnsafeMethods.MarkDirty()(ObjectPtr, _args);
        }

        /// 
        public void ResetTarget() {
             InternalUnsafeMethods.ResetTarget__Args _args = new InternalUnsafeMethods.ResetTarget__Args() {
             };
             InternalUnsafeMethods.ResetTarget()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the GuiOffscreenCanvas class.
        /// </description>
        /// <returns>The type info object for GuiOffscreenCanvas</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// 
        /// </value>
        public Point2I TargetSize {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("targetSize"));
            set => SetFieldValue("targetSize", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public GFXFormat TargetFormat {
            get => GenericMarshal.StringTo<GFXFormat>(GetFieldValue("targetFormat"));
            set => SetFieldValue("targetFormat", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public string TargetName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("targetName"));
            set => SetFieldValue("targetName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool DynamicTarget {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("dynamicTarget"));
            set => SetFieldValue("dynamicTarget", GenericMarshal.ToString(value));
        }


        /// <value>
        /// 
        /// </value>
        public bool UseDepth {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useDepth"));
            set => SetFieldValue("useDepth", GenericMarshal.ToString(value));
        }
    }
}
