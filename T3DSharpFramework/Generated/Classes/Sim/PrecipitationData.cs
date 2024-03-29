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
    /// <summary>Defines the droplets used in a storm (raindrops, snowflakes, etc).</summary>
    /// <description>
    /// 
    /// </description>
    /// <code>
    /// datablock PrecipitationData( HeavyRain )
    /// {
    ///    soundProfile = "HeavyRainSound";
    ///    dropTexture = "art/environment/precipitation/rain";
    ///    splashTexture = "art/environment/precipitation/water_splash";
    ///    dropsPerSide = 4;
    ///    splashesPerSide = 2;
    /// };
    /// </code>
    /// <see cref="Precipitation" />
    public class PrecipitationData : GameBaseData {
        public PrecipitationData(bool pRegister = false)
            : base(pRegister) {
        }

        public PrecipitationData(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public PrecipitationData(string pName)
            : this(pName, false) {
        }

        public PrecipitationData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public PrecipitationData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public PrecipitationData(SimObject pObj)
            : base(pObj) {
        }

        public PrecipitationData(IntPtr pObj)
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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnPrecipitationData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnPrecipitationData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the type info object for the PrecipitationData class.
        /// </description>
        /// <returns>The type info object for PrecipitationData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Sound"Looping SFXProfile effect to play while Precipitation is active."
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
        /// <summary>Texture filename for drop particles.</summary>
        /// <description>
        /// The drop texture can contain several different drop sub-textures arranged in a grid. There must be the same number of rows as columns. A random frame will be chosen for each drop.
        /// </description>
        /// </value>
        public string DropTexture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("dropTexture"));
            set => SetFieldValue("dropTexture", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Drop "</summary>
        /// <summary>Texture for drop particles.\n\n" "The drop texture can contain several different drop sub-textures " "arranged in a grid. There must be the same number of rows as columns. A " "random frame will be chosen for each drop."</summary>
        /// </value>
        public string Drop {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Drop"));
            set => SetFieldValue("Drop", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Drop asset "</summary>
        /// <summary>Texture for drop particles.\n\n" "The drop texture can contain several different drop sub-textures " "arranged in a grid. There must be the same number of rows as columns. A " "random frame will be chosen for each drop.".</summary>
        /// </value>
        public string DropAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("DropAsset"));
            set => SetFieldValue("DropAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The name of the shader used for raindrops.
        /// </description>
        /// </value>
        public string DropShader {
            get => GenericMarshal.StringTo<string>(GetFieldValue("dropShader"));
            set => SetFieldValue("dropShader", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Texture filename for splash particles.</summary>
        /// <description>
        /// The splash texture can contain several different splash sub-textures arranged in a grid. There must be the same number of rows as columns. A random frame will be chosen for each splash.
        /// </description>
        /// </value>
        public string SplashTexture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("splashTexture"));
            set => SetFieldValue("splashTexture", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Splash "</summary>
        /// <summary>Texture for splash particles.\n\n" "The splash texture can contain several different splash sub-textures " "arranged in a grid. There must be the same number of rows as columns. A " "random frame will be chosen for each splash."</summary>
        /// </value>
        public string Splash {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Splash"));
            set => SetFieldValue("Splash", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>Splash asset "</summary>
        /// <summary>Texture for splash particles.\n\n" "The splash texture can contain several different splash sub-textures " "arranged in a grid. There must be the same number of rows as columns. A " "random frame will be chosen for each splash.".</summary>
        /// </value>
        public string SplashAsset {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SplashAsset"));
            set => SetFieldValue("SplashAsset", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// The name of the shader used for splashes.
        /// </description>
        /// </value>
        public string SplashShader {
            get => GenericMarshal.StringTo<string>(GetFieldValue("splashShader"));
            set => SetFieldValue("splashShader", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>How many rows and columns are in the raindrop texture.</summary>
        /// <description>
        /// For example, if the texture has 16 raindrops arranged in a grid, this field should be set to 4.
        /// </description>
        /// </value>
        public int DropsPerSide {
            get => GenericMarshal.StringTo<int>(GetFieldValue("dropsPerSide"));
            set => SetFieldValue("dropsPerSide", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <summary>How many rows and columns are in the splash texture.</summary>
        /// <description>
        /// For example, if the texture has 9 splashes arranged in a grid, this field should be set to 3.
        /// </description>
        /// </value>
        public int SplashesPerSide {
            get => GenericMarshal.StringTo<int>(GetFieldValue("splashesPerSide"));
            set => SetFieldValue("splashesPerSide", GenericMarshal.ToString(value));
        }
    }
}
