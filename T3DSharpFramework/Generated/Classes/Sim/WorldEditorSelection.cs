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
    /// <summary>Specialized simset that stores the objects selected by the World Editor</summary>
    /// <description>
    /// Editor use only.
    /// </description>
    public class WorldEditorSelection : SimPersistSet {
        public WorldEditorSelection(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public WorldEditorSelection(string pName, bool pRegister)
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

        public WorldEditorSelection(string pName)
            : this(pName, false) {
        }

        public WorldEditorSelection(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public WorldEditorSelection(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public WorldEditorSelection(SimObject pObj)
            : base(pObj) {
        }

        public WorldEditorSelection(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct Subtract__Args
            {
                internal IntPtr selection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Subtract(IntPtr _this, Subtract__Args args);
            private static _Subtract _SubtractFunc;
            internal static _Subtract Subtract() {
               _SubtractFunc ??= Torque3D.LookupEngineFunction<_Subtract>("fnWorldEditorSelection_subtract");

                return _SubtractFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Union__Args
            {
                internal IntPtr selection;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Union(IntPtr _this, Union__Args args);
            private static _Union _UnionFunc;
            internal static _Union Union() {
               _UnionFunc ??= Torque3D.LookupEngineFunction<_Union>("fnWorldEditorSelection_union");

                return _UnionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Offset__Args
            {
                internal IntPtr delta;
                internal float gridSnap;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Offset(IntPtr _this, Offset__Args args);
            private static _Offset _OffsetFunc;
            internal static _Offset Offset() {
               _OffsetFunc ??= Torque3D.LookupEngineFunction<_Offset>("fnWorldEditorSelection_offset");

                return _OffsetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetBoxCentroid__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetBoxCentroid(IntPtr _this, GetBoxCentroid__Args args);
            private static _GetBoxCentroid _GetBoxCentroidFunc;
            internal static _GetBoxCentroid GetBoxCentroid() {
               _GetBoxCentroidFunc ??= Torque3D.LookupEngineFunction<_GetBoxCentroid>("fnWorldEditorSelection_getBoxCentroid");

                return _GetBoxCentroidFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetCentroid__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Point3F.InternalStruct _GetCentroid(IntPtr _this, GetCentroid__Args args);
            private static _GetCentroid _GetCentroidFunc;
            internal static _GetCentroid GetCentroid() {
               _GetCentroidFunc ??= Torque3D.LookupEngineFunction<_GetCentroid>("fnWorldEditorSelection_getCentroid");

                return _GetCentroidFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ContainsGlobalBounds__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _ContainsGlobalBounds(IntPtr _this, ContainsGlobalBounds__Args args);
            private static _ContainsGlobalBounds _ContainsGlobalBoundsFunc;
            internal static _ContainsGlobalBounds ContainsGlobalBounds() {
               _ContainsGlobalBoundsFunc ??= Torque3D.LookupEngineFunction<_ContainsGlobalBounds>("fnWorldEditorSelection_containsGlobalBounds");

                return _ContainsGlobalBoundsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnWorldEditorSelection_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnWorldEditorSelection_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Remove all objects in the given set from this selection.
        /// </description>
        public void Subtract(SimSet selection) {
             InternalUnsafeMethods.Subtract__Args _args = new InternalUnsafeMethods.Subtract__Args() {
                selection = selection.ObjectPtr,
             };
             InternalUnsafeMethods.Subtract()(ObjectPtr, _args);
        }

        /// <description>
        /// Add all objects in the given set to this selection.
        /// </description>
        public void Union(SimSet selection) {
             InternalUnsafeMethods.Union__Args _args = new InternalUnsafeMethods.Union__Args() {
                selection = selection.ObjectPtr,
             };
             InternalUnsafeMethods.Union()(ObjectPtr, _args);
        }

        /// <description>
        /// Move all objects in the selection by the given delta.
        /// </description>
        public void Offset(Point3F delta, float gridSnap = 0f) {
delta.Alloc();             InternalUnsafeMethods.Offset__Args _args = new InternalUnsafeMethods.Offset__Args() {
                delta = delta.internalStructPtr,
                gridSnap = gridSnap,
             };
             InternalUnsafeMethods.Offset()(ObjectPtr, _args);
delta.Free();        }

        /// <description>
        /// Return the center of the bounding box around the selection.
        /// </description>
        public Point3F GetBoxCentroid() {
             InternalUnsafeMethods.GetBoxCentroid__Args _args = new InternalUnsafeMethods.GetBoxCentroid__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetBoxCentroid()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <description>
        /// Return the median of all object positions in the selection.
        /// </description>
        public Point3F GetCentroid() {
             InternalUnsafeMethods.GetCentroid__Args _args = new InternalUnsafeMethods.GetCentroid__Args() {
             };
             Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetCentroid()(ObjectPtr, _args);
             return new Point3F(_engineResult);
        }

        /// <description>
        /// True if an object with global bounds is contained in the selection.
        /// </description>
        public bool ContainsGlobalBounds() {
             InternalUnsafeMethods.ContainsGlobalBounds__Args _args = new InternalUnsafeMethods.ContainsGlobalBounds__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.ContainsGlobalBounds()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the WorldEditorSelection class.
        /// </description>
        /// <returns>The type info object for WorldEditorSelection</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
