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
    /// <summary>Defines the properties of an afxSelectronData.</summary>
    /// <description>
    /// 
    /// </description>
    public class afxSelectronData : afxChoreographerData {
        public afxSelectronData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public afxSelectronData(string pName, bool pRegister)
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

        public afxSelectronData(string pName)
            : this(pName, false) {
        }

        public afxSelectronData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxSelectronData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxSelectronData(SimObject pObj)
            : base(pObj) {
        }

        public afxSelectronData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
               _ResetFunc ??= Torque3D.LookupEngineFunction<_Reset>("fnafxSelectronData_reset");

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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxSelectronData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxSelectronData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Resets a selectron datablock during reload.
        /// </description>
        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the afxSelectronData class.
        /// </description>
        /// <returns>The type info object for afxSelectronData</returns>
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
        public float MainDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mainDur"));
            set => SetFieldValue("mainDur", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float SelectDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("selectDur"));
            set => SetFieldValue("selectDur", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float DeselectDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("deselectDur"));
            set => SetFieldValue("deselectDur", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int MainRepeats {
            get => GenericMarshal.StringTo<int>(GetFieldValue("mainRepeats"));
            set => SetFieldValue("mainRepeats", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int SelectRepeats {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectRepeats"));
            set => SetFieldValue("selectRepeats", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int DeselectRepeats {
            get => GenericMarshal.StringTo<int>(GetFieldValue("deselectRepeats"));
            set => SetFieldValue("deselectRepeats", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int SelectionTypeMask {
            get => GenericMarshal.StringTo<int>(GetFieldValue("selectionTypeMask"));
            set => SetFieldValue("selectionTypeMask", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public sbyte SelectionTypeStyle {
            get => GenericMarshal.StringTo<sbyte>(GetFieldValue("selectionTypeStyle"));
            set => SetFieldValue("selectionTypeStyle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxEffectBaseData AddMainEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addMainEffect"));
            set => SetFieldValue("addMainEffect", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxEffectBaseData AddSelectEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addSelectEffect"));
            set => SetFieldValue("addSelectEffect", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxEffectBaseData AddDeselectEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addDeselectEffect"));
            set => SetFieldValue("addDeselectEffect", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int NumMainLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numMainLoops"));
            set => SetFieldValue("numMainLoops", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int NumSelectLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numSelectLoops"));
            set => SetFieldValue("numSelectLoops", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int NumDeselectLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numDeselectLoops"));
            set => SetFieldValue("numDeselectLoops", GenericMarshal.ToString(value));
        }
    }
}
