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
    /// <summary>%Forest is a global-bounds scene object provides collision and rendering for a (.forest) data file.</summary>
    /// <description>
    /// %Forest is designed to efficiently render a large number of static meshes: trees, rocks plants, etc. These cannot be moved at game-time or play animations but do support wind effects using vertex shader transformations guided by vertex color in the asset and user placed wind emitters ( or weapon explosions ).
    /// 
    /// Script level manipulation of forest data is not possible through %Forest, it is only the rendering/collision. All editing is done through the world editor.
    /// </description>
    /// <see cref="TSForestItemData Defines a tree type." />
    /// <see cref="GuiForestEditorCtrl Used by the world editor to provide manipulation of forest data." />
    public class Forest : SceneObject {
        public Forest(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public Forest(string pName, bool pRegister)
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

        public Forest(string pName)
            : this(pName, false) {
        }

        public Forest(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Forest(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Forest(SimObject pObj)
            : base(pObj) {
        }

        public Forest(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Clear__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Clear(IntPtr _this, Clear__Args args);
            private static _Clear _ClearFunc;
            internal static _Clear Clear() {
               _ClearFunc ??= Torque3D.LookupEngineFunction<_Clear>("fnForest_clear");

                return _ClearFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RegenCells__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RegenCells(IntPtr _this, RegenCells__Args args);
            private static _RegenCells _RegenCellsFunc;
            internal static _RegenCells RegenCells() {
               _RegenCellsFunc ??= Torque3D.LookupEngineFunction<_RegenCells>("fnForest_regenCells");

                return _RegenCellsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsDirty__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsDirty(IntPtr _this, IsDirty__Args args);
            private static _IsDirty _IsDirtyFunc;
            internal static _IsDirty IsDirty() {
               _IsDirtyFunc ??= Torque3D.LookupEngineFunction<_IsDirty>("fnForest_isDirty");

                return _IsDirtyFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SaveDataFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string path;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SaveDataFile(IntPtr _this, SaveDataFile__Args args);
            private static _SaveDataFile _SaveDataFileFunc;
            internal static _SaveDataFile SaveDataFile() {
               _SaveDataFileFunc ??= Torque3D.LookupEngineFunction<_SaveDataFile>("fnForest_saveDataFile");

                return _SaveDataFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnForest_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnForest_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// ()
        /// </description>
        public void Clear() {
             InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
             };
             InternalUnsafeMethods.Clear()(ObjectPtr, _args);
        }

        /// <description>
        /// ()
        /// </description>
        public void RegenCells() {
             InternalUnsafeMethods.RegenCells__Args _args = new InternalUnsafeMethods.RegenCells__Args() {
             };
             InternalUnsafeMethods.RegenCells()(ObjectPtr, _args);
        }

        /// <description>
        /// ()
        /// </description>
        public bool IsDirty() {
             InternalUnsafeMethods.IsDirty__Args _args = new InternalUnsafeMethods.IsDirty__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsDirty()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// saveDataFile( [path] )
        /// </description>
        public void SaveDataFile(string path = "") {
             InternalUnsafeMethods.SaveDataFile__Args _args = new InternalUnsafeMethods.SaveDataFile__Args() {
                path = path,
             };
             InternalUnsafeMethods.SaveDataFile()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the Forest class.
        /// </description>
        /// <returns>The type info object for Forest</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// The source forest data file.
        /// </description>
        /// </value>
        public string DataFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("dataFile"));
            set => SetFieldValue("dataFile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// Scalar applied to the farclip distance when Forest renders into a reflection.
        /// </description>
        /// </value>
        public float LodReflectScalar {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lodReflectScalar"));
            set => SetFieldValue("lodReflectScalar", GenericMarshal.ToString(value));
        }
    }
}
