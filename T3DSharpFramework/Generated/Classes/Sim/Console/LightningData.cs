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
    /// <summary>Common data for a Lightning emitter object.</summary>
    /// <description>
    /// 
    /// </description>
    /// <see cref="Lightning" />
    public class LightningData : GameBaseData {
        public LightningData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public LightningData(string pName, bool pRegister)
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

        public LightningData(string pName)
            : this(pName, false) {
        }

        public LightningData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public LightningData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public LightningData(SimObject pObj)
            : base(pObj) {
        }

        public LightningData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnLightningData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnLightningData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the LightningData class.
        /// </description>
        /// <returns>The type info object for LightningData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// StrikeSound"Sound to play when lightning STRIKES!"
        /// </description>
        /// </value>
        public string StrikeSoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("StrikeSoundFile"));
            set => SetFieldValue("StrikeSoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// StrikeSoundasset reference.
        /// </description>
        /// </value>
        public string StrikeSoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("StrikeSoundAsset"));
            set => SetFieldValue("StrikeSoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>ThunderSound "Sounds for thunder."</summary>
        /// </value>
        public DynamicFieldVector<string> ThunderSound {
            get => new DynamicFieldVector<string>(
                    this, 
                    "ThunderSound", 
                    8, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <summary>ThunderSound asset "Sounds for thunder.".</summary>
        /// </value>
        public DynamicFieldVector<string> ThunderSoundAsset {
            get => new DynamicFieldVector<string>(
                    this, 
                    "ThunderSoundAsset", 
                    8, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }


        /// <value>
        /// <description>
        /// List of textures to use to render lightning strikes.
        /// </description>
        /// </value>
        public DynamicFieldVector<string> StrikeTextures {
            get => new DynamicFieldVector<string>(
                    this, 
                    "strikeTextures", 
                    8, 
                    val => GenericMarshal.StringTo<string>(val),
                    obj => GenericMarshal.ToString(obj)
                );
        }
    }
}
