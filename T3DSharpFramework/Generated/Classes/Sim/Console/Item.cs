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
    /// <summary>Base Item class. Uses the ItemData datablock for common properties.</summary>
    /// <description>
    /// Items represent an object in the world, usually one that the player will interact with.  One example is a health kit on the group that is automatically picked up when the player comes into contact with it.
    /// </description>
    /// <code>
    /// // This is the "health patch" dropped by a dying player.
    /// datablock ItemData(HealthKitPatch)
    /// {
    ///    // Mission editor category, this datablock will show up in the
    ///    // specified category under the "shapes" root category.
    ///    category = "Health";
    /// 
    ///    className = "HealthPatch";
    /// 
    ///    // Basic Item properties
    ///    shapeFile = "art/shapes/items/patch/healthpatch.dts";
    ///    mass = 2;
    ///    friction = 1;
    ///    elasticity = 0.3;
    ///    // Dynamic properties used by the scripts
    ///    pickupName = "a health patch";
    ///    repairAmount = 50;
    /// };
    /// 
    /// %obj = new Item()
    /// {
    /// 	dataBlock = HealthKitSmall;
    /// 	parentGroup = EWCreatorWindow.objectGroup;
    /// 	static = true;
    /// 	rotate = true;
    /// };
    /// </code>
    /// <see cref="ItemData" />
    public class Item : ShapeBase {
        public Item(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public Item(string pName, bool pRegister)
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

        public Item(string pName)
            : this(pName, false) {
        }

        public Item(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Item(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Item(SimObject pObj)
            : base(pObj) {
        }

        public Item(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLastStickyNormal__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLastStickyNormal(IntPtr _this, GetLastStickyNormal__Args args);
            private static _GetLastStickyNormal _GetLastStickyNormalFunc;
            internal static _GetLastStickyNormal GetLastStickyNormal() {
               _GetLastStickyNormalFunc ??= Torque3D.LookupEngineFunction<_GetLastStickyNormal>("fnItem_getLastStickyNormal");

                return _GetLastStickyNormalFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetLastStickyPos__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetLastStickyPos(IntPtr _this, GetLastStickyPos__Args args);
            private static _GetLastStickyPos _GetLastStickyPosFunc;
            internal static _GetLastStickyPos GetLastStickyPos() {
               _GetLastStickyPosFunc ??= Torque3D.LookupEngineFunction<_GetLastStickyPos>("fnItem_getLastStickyPos");

                return _GetLastStickyPosFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetCollisionTimeout__Args
            {
                internal int ignoreColObj;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SetCollisionTimeout(IntPtr _this, SetCollisionTimeout__Args args);
            private static _SetCollisionTimeout _SetCollisionTimeoutFunc;
            internal static _SetCollisionTimeout SetCollisionTimeout() {
               _SetCollisionTimeoutFunc ??= Torque3D.LookupEngineFunction<_SetCollisionTimeout>("fnItem_setCollisionTimeout");

                return _SetCollisionTimeoutFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsRotating__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsRotating(IntPtr _this, IsRotating__Args args);
            private static _IsRotating _IsRotatingFunc;
            internal static _IsRotating IsRotating() {
               _IsRotatingFunc ??= Torque3D.LookupEngineFunction<_IsRotating>("fnItem_isRotating");

                return _IsRotatingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsAtRest__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsAtRest(IntPtr _this, IsAtRest__Args args);
            private static _IsAtRest _IsAtRestFunc;
            internal static _IsAtRest IsAtRest() {
               _IsAtRestFunc ??= Torque3D.LookupEngineFunction<_IsAtRest>("fnItem_isAtRest");

                return _IsAtRestFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsStatic__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsStatic(IntPtr _this, IsStatic__Args args);
            private static _IsStatic _IsStaticFunc;
            internal static _IsStatic IsStatic() {
               _IsStaticFunc ??= Torque3D.LookupEngineFunction<_IsStatic>("fnItem_isStatic");

                return _IsStaticFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLeaveLiquid__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objID;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string liquidType;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLeaveLiquid(IntPtr _this, OnLeaveLiquid__Args args);
            private static _OnLeaveLiquid _OnLeaveLiquidFunc;
            internal static _OnLeaveLiquid OnLeaveLiquid() {
               _OnLeaveLiquidFunc ??= Torque3D.LookupEngineFunction<_OnLeaveLiquid>("cbItem_onLeaveLiquid");

                return _OnLeaveLiquidFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnEnterLiquid__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objID;
                internal float waterCoverage;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string liquidType;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnEnterLiquid(IntPtr _this, OnEnterLiquid__Args args);
            private static _OnEnterLiquid _OnEnterLiquidFunc;
            internal static _OnEnterLiquid OnEnterLiquid() {
               _OnEnterLiquidFunc ??= Torque3D.LookupEngineFunction<_OnEnterLiquid>("cbItem_onEnterLiquid");

                return _OnEnterLiquidFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnStickyCollision__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnStickyCollision(IntPtr _this, OnStickyCollision__Args args);
            private static _OnStickyCollision _OnStickyCollisionFunc;
            internal static _OnStickyCollision OnStickyCollision() {
               _OnStickyCollisionFunc ??= Torque3D.LookupEngineFunction<_OnStickyCollision>("cbItem_onStickyCollision");

                return _OnStickyCollisionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnItem_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnItem_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Get the normal of the surface on which the object is stuck.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>Returns The XYZ normal from where this Item is stuck.</returns>
        /// <code>
        /// // Acquire the position where this Item is currently stuck
        /// %stuckPosition = %item.getLastStickPos();
        /// </code>
        /// <remarks> Server side only.
        /// </remarks>
        public string GetLastStickyNormal() {
             InternalUnsafeMethods.GetLastStickyNormal__Args _args = new InternalUnsafeMethods.GetLastStickyNormal__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLastStickyNormal()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Get the position on the surface on which this Item is stuck.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>Returns The XYZ position of where this Item is stuck.</returns>
        /// <code>
        /// // Acquire the position where this Item is currently stuck
        /// %stuckPosition = %item.getLastStickPos();
        /// </code>
        /// <remarks> Server side only.
        /// </remarks>
        public string GetLastStickyPos() {
             InternalUnsafeMethods.GetLastStickyPos__Args _args = new InternalUnsafeMethods.GetLastStickyPos__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetLastStickyPos()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Temporarily disable collisions against a specific ShapeBase object.</summary>
        /// <description>
        /// This is useful to prevent a player from immediately picking up an Item they have just thrown.  Only one object may be on the timeout list at a time.  The timeout is defined as 15 ticks.
        /// </description>
        /// <param name="objectID">ShapeBase object ID to disable collisions against.</param>
        /// <returns>Returns true if the ShapeBase object requested could be found, false if it could not.</returns>
        /// <code>
        /// // Set the ShapeBase Object ID to disable collisions against
        /// %ignoreColObj = %player.getID();
        /// 
        /// // Inform this Item object to ignore collisions temproarily against the %ignoreColObj.
        /// %item.setCollisionTimeout(%ignoreColObj);
        /// </code>
        public bool SetCollisionTimeout(int ignoreColObj) {
             InternalUnsafeMethods.SetCollisionTimeout__Args _args = new InternalUnsafeMethods.SetCollisionTimeout__Args() {
                ignoreColObj = ignoreColObj,
             };
             bool _engineResult = InternalUnsafeMethods.SetCollisionTimeout()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Is the object still rotating?</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>True if the object is still rotating, false if it is not.</returns>
        /// <code>
        /// // Query the item on if it is or is not rotating.
        /// %isRotating = %itemData.isRotating();
        /// </code>
        /// <see cref="rotate" />
        public bool IsRotating() {
             InternalUnsafeMethods.IsRotating__Args _args = new InternalUnsafeMethods.IsRotating__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsRotating()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Is the object at rest (ie, no longer moving)?</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>True if the object is at rest, false if it is not.</returns>
        /// <code>
        /// // Query the item on if it is or is not at rest.
        /// %isAtRest = %item.isAtRest();
        /// </code>
        public bool IsAtRest() {
             InternalUnsafeMethods.IsAtRest__Args _args = new InternalUnsafeMethods.IsAtRest__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsAtRest()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Is the object static (ie, non-movable)?</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>True if the object is static, false if it is not.</returns>
        /// <code>
        /// // Query the item on if it is or is not static.
        /// %isStatic = %itemData.isStatic();
        /// </code>
        /// <see cref="static" />
        public bool IsStatic() {
             InternalUnsafeMethods.IsStatic__Args _args = new InternalUnsafeMethods.IsStatic__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.IsStatic()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Informs an Item object that it has left a liquid, along with information about the liquid type.
        /// </description>
        /// <param name="objID">Object ID for this Item object.</param>
        /// <param name="liquidType">The type of liquid that this Item object has left.</param>
        /// <remarks> Server side only.
        /// </remarks>
        /// <see cref="Item, ItemData, WaterObject" />
        public virtual void OnLeaveLiquid(string objID, string liquidType) {
             InternalUnsafeMethods.OnLeaveLiquid__Args _args = new InternalUnsafeMethods.OnLeaveLiquid__Args() {
                objID = objID,
                liquidType = liquidType,
             };
             InternalUnsafeMethods.OnLeaveLiquid()(ObjectPtr, _args);
        }

        /// <description>
        /// Informs an Item object that it has entered liquid, along with information about the liquid type.
        /// </description>
        /// <param name="objID">Object ID for this Item object.</param>
        /// <param name="waterCoverage">How much coverage of water this Item object has.</param>
        /// <param name="liquidType">The type of liquid that this Item object has entered.</param>
        /// <remarks> Server side only.
        /// </remarks>
        /// <see cref="Item, ItemData, WaterObject" />
        public virtual void OnEnterLiquid(string objID, float waterCoverage, string liquidType) {
             InternalUnsafeMethods.OnEnterLiquid__Args _args = new InternalUnsafeMethods.OnEnterLiquid__Args() {
                objID = objID,
                waterCoverage = waterCoverage,
                liquidType = liquidType,
             };
             InternalUnsafeMethods.OnEnterLiquid()(ObjectPtr, _args);
        }

        /// <summary>Informs the Item object that it is now sticking to another object.</summary>
        /// <description>
        /// This callback is only called if the ItemData::sticky property for this Item is true.
        /// </description>
        /// <param name="objID">Object ID this Item object.</param>
        /// <remarks> Server side only.
        /// </remarks>
        /// <see cref="Item, ItemData" />
        public virtual void OnStickyCollision(string objID) {
             InternalUnsafeMethods.OnStickyCollision__Args _args = new InternalUnsafeMethods.OnStickyCollision__Args() {
                objID = objID,
             };
             InternalUnsafeMethods.OnStickyCollision()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the Item class.
        /// </description>
        /// <returns>The type info object for Item</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// If true, the object is not moving in the world.
        /// </description>
        /// </value>
        public bool Static {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("static"));
            set => SetFieldValue("static", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// If true, the object will automatically rotate around its Z axis.
        /// </description>
        /// </value>
        public bool Rotate {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("rotate"));
            set => SetFieldValue("rotate", GenericMarshal.ToString(value));
        }
    }
}
