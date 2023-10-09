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
    /// <summary>Brief Description.</summary>
    /// <description>
    /// Audio PLayback.
    /// </description>
    public class GuiAudioCtrl : GuiTickCtrl {
        public GuiAudioCtrl(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiAudioCtrl(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public GuiAudioCtrl(string pName)
            : this(pName, false) {
        }

        public GuiAudioCtrl(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiAudioCtrl(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiAudioCtrl(SimObject pObj)
            : base(pObj) {
        }

        public GuiAudioCtrl(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnGuiAudioCtrl_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnGuiAudioCtrl_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the GuiAudioCtrl class.
        /// </description>
        /// <returns>The type info object for GuiAudioCtrl</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Sound"Looping SoundAsset to play while GuiAudioCtrl is active."
        /// </description>
        /// </value>
        public string SoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SoundFile"));
            set => SetFieldValue("SoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Soundasset reference.
        /// </description>
        /// </value>
        public string SoundAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SoundAsset"));
            set => SetFieldValue("SoundAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Time in milliseconds between calls to onTick().</summary>
        /// <description>
        /// 
        /// </description>
        /// <see cref="onTickTrigger()" />
        /// </value>
        public int TickPeriodMS {
            get => GenericMarshal.StringTo<int>(GetFieldValue("tickPeriodMS"));
            set => SetFieldValue("tickPeriodMS", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// evaluation condition to trip playback (true/false)
        /// </description>
        /// </value>
        public string PlayIf {
            get => GenericMarshal.StringTo<string>(GetFieldValue("playIf"));
            set => SetFieldValue("playIf", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If this is true, all fields except for #playOnAdd and #track are ignored on the emitter object.
        /// This is useful to prevent fields in the #track's description from being overridden by emitter fields.
        /// </description>
        /// </value>
        public bool UseTrackDescriptionOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useTrackDescriptionOnly"));
            set => SetFieldValue("useTrackDescriptionOnly", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The SFXSource to which to assign the sound of this emitter as a child.
        /// </description>
        /// <remarks> This field is ignored if #useTrackDescriptionOnly is true.
        /// 
        /// </remarks>
        /// <see cref="SFXDescription::sourceGroup" />
        /// </value>
        public SFXSource SourceGroup {
            get => GenericMarshal.StringTo<SFXSource>(GetFieldValue("sourceGroup"));
            set => SetFieldValue("sourceGroup", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Volume level to apply to the sound.
        /// </description>
        /// <remarks> This field is ignored if #useTrackDescriptionOnly is true.
        /// 
        /// </remarks>
        /// <see cref="SFXDescription::volume" />
        /// </value>
        public float Volume {
            get => GenericMarshal.StringTo<float>(GetFieldValue("volume"));
            set => SetFieldValue("volume", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Pitch shift to apply to the sound.  Default is 1 = play at normal speed.
        /// </description>
        /// <remarks> This field is ignored if #useTrackDescriptionOnly is true.
        /// 
        /// </remarks>
        /// <see cref="SFXDescription::pitch" />
        /// </value>
        public float Pitch {
            get => GenericMarshal.StringTo<float>(GetFieldValue("pitch"));
            set => SetFieldValue("pitch", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Number of seconds to gradually fade in volume from zero when playback starts.
        /// </description>
        /// <remarks> This field is ignored if #useTrackDescriptionOnly is true.
        /// 
        /// </remarks>
        /// <see cref="SFXDescription::fadeInTime" />
        /// </value>
        public float FadeInTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeInTime"));
            set => SetFieldValue("fadeInTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Number of seconds to gradually fade out volume down to zero when playback is stopped or paused.
        /// </description>
        /// <remarks> This field is ignored if #useTrackDescriptionOnly is true.
        /// 
        /// </remarks>
        /// <see cref="SFXDescription::fadeOutTime" />
        /// </value>
        public float FadeOutTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("fadeOutTime"));
            set => SetFieldValue("fadeOutTime", GenericMarshal.ToString(value));
        }
    }
}
