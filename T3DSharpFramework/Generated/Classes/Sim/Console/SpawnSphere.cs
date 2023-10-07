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
    /// <summary>This class is used for creating any type of game object, assigning it a class, datablock, and other properties when it is spawned.</summary>
    /// <description>
    /// Torque 3D uses a simple spawn system, which can be easily modified to spawn any kind of object (of any class). Each new level already contains at least one SpawnSphere, which is represented by a green octahedron in stock Torque 3D. The spawnClass field determines the object type, such as Player, AIPlayer, etc. The spawnDataBlock field applies the pre-defined datablock to each spawned object instance. The really powerful feature of this class is provided by the spawnScript field which allows you to define a simple script (multiple lines) that will be executed once the object has been spawned.
    /// </description>
    /// <code>
    /// // Define an SpawnSphere that essentially performs the following each time an object is spawned
    /// //$SpawnObject = new Player()
    /// //{
    /// //   dataBlock = "DefaultPlayerData";
    /// //   name = "Bob";
    /// //   lifeTotal = 3;
    /// //};
    /// //echo("Spawned a Player: "@ $SpawnObject);
    /// 
    /// new SpawnSphere(DefaultSpawnSphere)
    /// {
    ///    spawnClass = "Player";
    ///    spawnDatablock = "DefaultPlayerData";
    ///    spawnScript = "echo(\"Spawned a Player: \" 
    /// </code>
    /// <see cref="MissionMarker" />
    /// <see cref="MissionMarkerData" />
    public class SpawnSphere : MissionMarker {
        public SpawnSphere(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public SpawnSphere(string pName, bool pRegister)
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

        public SpawnSphere(string pName)
            : this(pName, false) {
        }

        public SpawnSphere(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SpawnSphere(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SpawnSphere(SimObject pObj)
            : base(pObj) {
        }

        public SpawnSphere(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SpawnObject__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string additionalProps;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _SpawnObject(IntPtr _this, SpawnObject__Args args);
            private static _SpawnObject _SpawnObjectFunc;
            internal static _SpawnObject SpawnObject() {
               _SpawnObjectFunc ??= Torque3D.LookupEngineFunction<_SpawnObject>("fnSpawnSphere_spawnObject");

                return _SpawnObjectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAdd__Args
            {
                internal uint objectId;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAdd(IntPtr _this, OnAdd__Args args);
            private static _OnAdd _OnAddFunc;
            internal static _OnAdd OnAdd() {
               _OnAddFunc ??= Torque3D.LookupEngineFunction<_OnAdd>("cbSpawnSphere_onAdd");

                return _OnAddFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnSpawnSphere_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnSpawnSphere_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// ([string additionalProps]) Spawns the object based on the SpawnSphere's class, datablock, properties, and script settings. Allows you to pass in extra properties.
        /// </description>
        public int SpawnObject(string additionalProps) {
             InternalUnsafeMethods.SpawnObject__Args _args = new InternalUnsafeMethods.SpawnObject__Args() {
                additionalProps = additionalProps,
             };
             int _engineResult = InternalUnsafeMethods.SpawnObject()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Called when the SpawnSphere is being created.
        /// </description>
        /// <param name="objectId">The unique SimObjectId generated when SpawnSphere is created (%%this in script)</param>
        public virtual void OnAdd(uint objectId) {
             InternalUnsafeMethods.OnAdd__Args _args = new InternalUnsafeMethods.OnAdd__Args() {
                objectId = objectId,
             };
             InternalUnsafeMethods.OnAdd()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the SpawnSphere class.
        /// </description>
        /// <returns>The type info object for SpawnSphere</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// Object class to create (eg. Player, AIPlayer, Debris etc)
        /// </description>
        /// </value>
        public string SpawnClass {
            get => GenericMarshal.StringTo<string>(GetFieldValue("spawnClass"));
            set => SetFieldValue("spawnClass", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Predefined datablock assigned to the object when created
        /// </description>
        /// </value>
        public string SpawnDatablock {
            get => GenericMarshal.StringTo<string>(GetFieldValue("spawnDatablock"));
            set => SetFieldValue("spawnDatablock", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// String containing semicolon (;) delimited properties to set when the object is created.
        /// </description>
        /// </value>
        public string SpawnProperties {
            get => GenericMarshal.StringTo<string>(GetFieldValue("spawnProperties"));
            set => SetFieldValue("spawnProperties", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Command to execute immediately after spawning an object. New object id is stored in $SpawnObject.  Max 255 characters.
        /// </description>
        /// </value>
        public string SpawnScript {
            get => GenericMarshal.StringTo<string>(GetFieldValue("spawnScript"));
            set => SetFieldValue("spawnScript", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Flag to spawn object as soon as SpawnSphere is created, true to enable or false to disable.
        /// </description>
        /// </value>
        public bool AutoSpawn {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("autoSpawn"));
            set => SetFieldValue("autoSpawn", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Flag to set the spawned object's transform to the SpawnSphere's transform.
        /// </description>
        /// </value>
        public bool SpawnTransform {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("spawnTransform"));
            set => SetFieldValue("spawnTransform", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Deprecated
        /// </description>
        /// </value>
        public float Radius {
            get => GenericMarshal.StringTo<float>(GetFieldValue("radius"));
            set => SetFieldValue("radius", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Deprecated
        /// </description>
        /// </value>
        public float SphereWeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("sphereWeight"));
            set => SetFieldValue("sphereWeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Deprecated
        /// </description>
        /// </value>
        public float IndoorWeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("indoorWeight"));
            set => SetFieldValue("indoorWeight", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Deprecated
        /// </description>
        /// </value>
        public float OutdoorWeight {
            get => GenericMarshal.StringTo<float>(GetFieldValue("outdoorWeight"));
            set => SetFieldValue("outdoorWeight", GenericMarshal.ToString(value));
        }
    }
}
