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
    public class ShapeAnimationAsset : AssetBase {
        public ShapeAnimationAsset(bool pRegister = false)
            : base(pRegister) {
        }

        public ShapeAnimationAsset(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public ShapeAnimationAsset(string pName)
            : this(pName, false) {
        }

        public ShapeAnimationAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ShapeAnimationAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ShapeAnimationAsset(SimObject pObj)
            : base(pObj) {
        }

        public ShapeAnimationAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAnimationPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAnimationPath(IntPtr _this, GetAnimationPath__Args args);
            private static _GetAnimationPath _GetAnimationPathFunc;
            internal static _GetAnimationPath GetAnimationPath() {
               _GetAnimationPathFunc ??= Torque3D.LookupEngineFunction<_GetAnimationPath>("fnShapeAnimationAsset_getAnimationPath");

                return _GetAnimationPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAnimationCount__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetAnimationCount(IntPtr _this, GetAnimationCount__Args args);
            private static _GetAnimationCount _GetAnimationCountFunc;
            internal static _GetAnimationCount GetAnimationCount() {
               _GetAnimationCountFunc ??= Torque3D.LookupEngineFunction<_GetAnimationCount>("fnShapeAnimationAsset_getAnimationCount");

                return _GetAnimationCountFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnShapeAnimationAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnShapeAnimationAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Gets the Animation file path associated to this asset.
        /// </description>
        public string GetAnimationPath() {
             InternalUnsafeMethods.GetAnimationPath__Args _args = new InternalUnsafeMethods.GetAnimationPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAnimationPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Gets the number of animations for this shape asset.
        /// </description>
        /// <returns>Animation count.</returns>
        public int GetAnimationCount() {
             InternalUnsafeMethods.GetAnimationCount__Args _args = new InternalUnsafeMethods.GetAnimationCount__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetAnimationCount()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the ShapeAnimationAsset class.
        /// </description>
        /// <returns>The type info object for ShapeAnimationAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Path to the file name containing the animation
        /// </description>
        /// </value>
        public string AnimationFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("animationFile"));
            set => SetFieldValue("animationFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Name of the animation
        /// </description>
        /// </value>
        public string AnimationName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("animationName"));
            set => SetFieldValue("animationName", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, this animation asset just referrs to an embedded animation of a regular shape mesh. If false, it is a self-contained animation file
        /// </description>
        /// </value>
        public bool IsEmbedded {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isEmbedded"));
            set => SetFieldValue("isEmbedded", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Is this animation looping?
        /// </description>
        /// </value>
        public bool IsCyclic {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isCyclic"));
            set => SetFieldValue("isCyclic", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Is this animation blended with another?
        /// </description>
        /// </value>
        public bool IsBlend {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isBlend"));
            set => SetFieldValue("isBlend", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// AssetID of the animation to reference for our blending
        /// </description>
        /// </value>
        public string BlendRefAnimation {
            get => GenericMarshal.StringTo<string>(GetFieldValue("blendRefAnimation"));
            set => SetFieldValue("blendRefAnimation", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Which frame of the reference animation do we use for our blending
        /// </description>
        /// </value>
        public int BlendFrame {
            get => GenericMarshal.StringTo<int>(GetFieldValue("blendFrame"));
            set => SetFieldValue("blendFrame", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// What frame does this animation clip start on
        /// </description>
        /// </value>
        public int StartFrame {
            get => GenericMarshal.StringTo<int>(GetFieldValue("startFrame"));
            set => SetFieldValue("startFrame", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// What fram does this animation clip end on
        /// </description>
        /// </value>
        public int EndFrame {
            get => GenericMarshal.StringTo<int>(GetFieldValue("endFrame"));
            set => SetFieldValue("endFrame", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Are the rotation values padded
        /// </description>
        /// </value>
        public bool PadRotation {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("padRotation"));
            set => SetFieldValue("padRotation", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Are the transform values padded
        /// </description>
        /// </value>
        public bool PadTransforms {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("padTransforms"));
            set => SetFieldValue("padTransforms", GenericMarshal.ToString(value));
        }
    }
}
