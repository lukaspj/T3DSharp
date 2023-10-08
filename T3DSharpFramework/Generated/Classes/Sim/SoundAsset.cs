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
    public class SoundAsset : AssetBase {
        public SoundAsset(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public SoundAsset(string pName, bool pRegister)
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

        public SoundAsset(string pName)
            : this(pName, false) {
        }

        public SoundAsset(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SoundAsset(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SoundAsset(SimObject pObj)
            : base(pObj) {
        }

        public SoundAsset(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetAssetIdByFilename__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string filePath;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetAssetIdByFilename(GetAssetIdByFilename__Args args);
            private static _GetAssetIdByFilename _GetAssetIdByFilenameFunc;
            internal static _GetAssetIdByFilename GetAssetIdByFilename() {
               _GetAssetIdByFilenameFunc ??= Torque3D.LookupEngineFunction<_GetAssetIdByFilename>("fnSoundAsset_getAssetIdByFilename");

                return _GetAssetIdByFilenameFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PlaySound__Args
            {
                internal IntPtr position;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _PlaySound(IntPtr _this, PlaySound__Args args);
            private static _PlaySound _PlaySoundFunc;
            internal static _PlaySound PlaySound() {
               _PlaySoundFunc ??= Torque3D.LookupEngineFunction<_PlaySound>("fnSoundAsset_playSound");

                return _PlaySoundFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSoundPath__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSoundPath(IntPtr _this, GetSoundPath__Args args);
            private static _GetSoundPath _GetSoundPathFunc;
            internal static _GetSoundPath GetSoundPath() {
               _GetSoundPathFunc ??= Torque3D.LookupEngineFunction<_GetSoundPath>("fnSoundAsset_getSoundPath");

                return _GetSoundPathFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnSoundAsset_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnSoundAsset_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Queries the Asset Database to see if any asset exists that is associated with the provided file path.
        /// </description>
        /// <returns>The AssetId of the associated asset, if any.</returns>
        public static string GetAssetIdByFilename(string filePath = "") {
             InternalUnsafeMethods.GetAssetIdByFilename__Args _args = new InternalUnsafeMethods.GetAssetIdByFilename__Args() {
                filePath = filePath,
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetAssetIdByFilename()(_args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Plays the sound for this asset.
        /// </description>
        /// <returns>(sound plays).</returns>
        public int PlaySound(Point3F position = null) {
position = position ?? new Point3F("0 0 0");
position.Alloc();             InternalUnsafeMethods.PlaySound__Args _args = new InternalUnsafeMethods.PlaySound__Args() {
                position = position.internalStructPtr,
             };
             int _engineResult = InternalUnsafeMethods.PlaySound()(ObjectPtr, _args);
position.Free();             return _engineResult;
        }

        /// 
        public string GetSoundPath() {
             InternalUnsafeMethods.GetSoundPath__Args _args = new InternalUnsafeMethods.GetSoundPath__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSoundPath()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Get the type info object for the SoundAsset class.
        /// </description>
        /// <returns>The type info object for SoundAsset</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Path to the sound file.
        /// </description>
        /// </value>
        public string SoundFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("SoundFile"));
            set => SetFieldValue("SoundFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Adjustment of the pitch value 1 is default.
        /// </description>
        /// </value>
        public float PitchAdjust {
            get => GenericMarshal.StringTo<float>(GetFieldValue("PitchAdjust"));
            set => SetFieldValue("PitchAdjust", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Adjustment to the volume.
        /// </description>
        /// </value>
        public float VolumeAdjust {
            get => GenericMarshal.StringTo<float>(GetFieldValue("VolumeAdjust"));
            set => SetFieldValue("VolumeAdjust", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Set this sound to 3D.
        /// </description>
        /// </value>
        public bool Is3D {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("is3D"));
            set => SetFieldValue("is3D", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Does this sound loop.
        /// </description>
        /// </value>
        public bool IsLooping {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isLooping"));
            set => SetFieldValue("isLooping", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Use streaming.
        /// </description>
        /// </value>
        public bool IsStreaming {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isStreaming"));
            set => SetFieldValue("isStreaming", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Use hardware mixing for this sound.
        /// </description>
        /// </value>
        public bool UseHardware {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useHardware"));
            set => SetFieldValue("useHardware", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Minimum distance for sound.
        /// </description>
        /// </value>
        public float MinDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("minDistance"));
            set => SetFieldValue("minDistance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Max distance for sound.
        /// </description>
        /// </value>
        public float MaxDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxDistance"));
            set => SetFieldValue("maxDistance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Cone inside angle.
        /// </description>
        /// </value>
        public int ConeInsideAngle {
            get => GenericMarshal.StringTo<int>(GetFieldValue("coneInsideAngle"));
            set => SetFieldValue("coneInsideAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Cone outside angle.
        /// </description>
        /// </value>
        public int ConeOutsideAngle {
            get => GenericMarshal.StringTo<int>(GetFieldValue("coneOutsideAngle"));
            set => SetFieldValue("coneOutsideAngle", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Cone outside volume.
        /// </description>
        /// </value>
        public float ConeOutsideVolume {
            get => GenericMarshal.StringTo<float>(GetFieldValue("coneOutsideVolume"));
            set => SetFieldValue("coneOutsideVolume", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Rolloff factor.
        /// </description>
        /// </value>
        public float RolloffFactor {
            get => GenericMarshal.StringTo<float>(GetFieldValue("rolloffFactor"));
            set => SetFieldValue("rolloffFactor", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Randomization to the spacial position of the sound.
        /// </description>
        /// </value>
        public Point3F ScatterDistance {
            get => GenericMarshal.StringTo<Point3F>(GetFieldValue("scatterDistance"));
            set => SetFieldValue("scatterDistance", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Group that sources playing with this description should be put into.
        /// </description>
        /// </value>
        public SFXSource SourceGroup {
            get => GenericMarshal.StringTo<SFXSource>(GetFieldValue("sourceGroup"));
            set => SetFieldValue("sourceGroup", GenericMarshal.ToString(value));
        }
    }
}
