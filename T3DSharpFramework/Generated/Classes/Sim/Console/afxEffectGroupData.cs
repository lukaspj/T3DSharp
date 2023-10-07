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
    /// <summary>A datablock that describes an Effect Group.</summary>
    /// <description>
    /// afxEffectGroupData provides a way for adding several effects to a choreographer as a group and can be used wherever an afxEffectWrapperData is used. Basically, an effect-group is a simple list of effect-wrappers. When an effect-group is added to a choreographer, the end result is almost the same as adding all of the group's effect-wrappers directly to the choreographer. The main difference is that the grouped effects can be turned on and off collectively and created in multiples. Effect-groups can also contain other effect-groups, forming a hierarchy of effects.
    /// 
    /// A great strength of effect-groups is that they have a count setting that multiplies the number of times the effects in the group are added to the owning choreographer and this doesn't happen until the choreographer instance is created and launched. This makes a big difference for certain kinds of effects, such as fireworks, that tend to consist of small groupings of effects that are repeated many times with slight variations. With groups, an effect like this has a very compact representation for transmitting from server to clients, that only expands when actually used.
    /// 
    /// Effect-groups with a count greater than one are extremely useful when some of the effects use field substitutions. When an effect-group is expanded, it essentially runs through a for-loop from 0 to count-1 and creates a new set of effect instances each time through the loop. For each new set of effects, their group-index is set to the index of this for-loop, which in turn replaces the ## token used in any field substitutions in the child effects. In essence, the for-loop index becomes a parameter of the child effects which can be used to vary the effects created in each loop.
    /// </description>
    /// <see cref="afxEffectBaseData" />
    /// <see cref="afxEffectWrapperData" />
    public class afxEffectGroupData : afxEffectBaseData {
        public afxEffectGroupData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public afxEffectGroupData(string pName, bool pRegister)
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

        public afxEffectGroupData(string pName)
            : this(pName, false) {
        }

        public afxEffectGroupData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxEffectGroupData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxEffectGroupData(SimObject pObj)
            : base(pObj) {
        }

        public afxEffectGroupData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PushEffect__Args
            {
                internal IntPtr effect;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushEffect(IntPtr _this, PushEffect__Args args);
            private static _PushEffect _PushEffectFunc;
            internal static _PushEffect PushEffect() {
               _PushEffectFunc ??= Torque3D.LookupEngineFunction<_PushEffect>("fnafxEffectGroupData_pushEffect");

                return _PushEffectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
               _ResetFunc ??= Torque3D.LookupEngineFunction<_Reset>("fnafxEffectGroupData_reset");

                return _ResetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxEffectGroupData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxEffectGroupData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Adds an effect (wrapper or group) to an effect-group.
        /// </description>
        public void PushEffect(afxEffectBaseData effect) {
             InternalUnsafeMethods.PushEffect__Args _args = new InternalUnsafeMethods.PushEffect__Args() {
                effect = effect.ObjectPtr,
             };
             InternalUnsafeMethods.PushEffect()(ObjectPtr, _args);
        }

        /// <description>
        /// Resets an effect-group datablock during reload.
        /// </description>
        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the afxEffectGroupData class.
        /// </description>
        /// <returns>The type info object for afxEffectGroupData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public bool GroupEnabled {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("groupEnabled"));
            set => SetFieldValue("groupEnabled", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int Count {
            get => GenericMarshal.StringTo<int>(GetFieldValue("count"));
            set => SetFieldValue("count", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public sbyte IndexOffset {
            get => GenericMarshal.StringTo<sbyte>(GetFieldValue("indexOffset"));
            set => SetFieldValue("indexOffset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public bool AssignIndices {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("assignIndices"));
            set => SetFieldValue("assignIndices", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float Delay {
            get => GenericMarshal.StringTo<float>(GetFieldValue("delay"));
            set => SetFieldValue("delay", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float Lifetime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lifetime"));
            set => SetFieldValue("lifetime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float FadeInTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeInTime"));
            set => SetFieldValue("fadeInTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float FadeOutTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeOutTime"));
            set => SetFieldValue("fadeOutTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxEffectBaseData AddEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addEffect"));
            set => SetFieldValue("addEffect", GenericMarshal.ToString(value));
        }
    }
}
