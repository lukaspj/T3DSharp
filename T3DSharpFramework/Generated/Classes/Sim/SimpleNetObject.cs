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
    /// <summary>A very simple example of a class derived from NetObject.</summary>
    /// <description>
    /// This object exists purely for instructional purposes. It is primarily geared toward developers that wish to understand the inner-working of Torque 3D's networking system. This is not intended for actual game development.
    /// </description>
    /// <code>
    /// // On the server, create a new SimpleNetObject.  This is a ghost always
    /// // object so it will be immediately ghosted to all connected clients.
    /// $s = new SimpleNetObject();
    /// 
    /// // All connected clients will see the following in their console:
    /// // 
    /// // Got message: Hello World!
    /// </code>
    /// <see cref="NetObject for a full breakdown of this example object" />
    public class SimpleNetObject : NetObject {
        public SimpleNetObject(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public SimpleNetObject(string pName, bool pRegister)
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

        public SimpleNetObject(string pName)
            : this(pName, false) {
        }

        public SimpleNetObject(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SimpleNetObject(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SimpleNetObject(SimObject pObj)
            : base(pObj) {
        }

        public SimpleNetObject(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct SetMessage__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string msg;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetMessage(IntPtr _this, SetMessage__Args args);
            private static _SetMessage _SetMessageFunc;
            internal static _SetMessage SetMessage() {
               _SetMessageFunc ??= Torque3D.LookupEngineFunction<_SetMessage>("fnSimpleNetObject_setMessage");

                return _SetMessageFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnSimpleNetObject_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnSimpleNetObject_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Sets the internal message variable.</summary>
        /// <description>
        /// SimpleNetObject is set up to automatically transmit this new message to all connected clients.  It will appear in the clients' console.
        /// </description>
        /// <param name="msg">The new message to send</param>
        /// <code>
        /// // On the server, create a new SimpleNetObject.  This is a ghost always
        /// // object so it will be immediately ghosted to all connected clients.
        /// $s = new SimpleNetObject();
        /// 
        /// // All connected clients will see the following in their console:
        /// // 
        /// // Got message: Hello World!
        /// 
        /// // Now again on the server, change the message.  This will cause it to
        /// // be sent to all connected clients.
        /// $s.setMessage("A new message from me!");
        /// 
        /// // All connected clients will now see in their console:
        /// // 
        /// // Go message: A new message from me!
        /// </code>
        public void SetMessage(string msg) {
             InternalUnsafeMethods.SetMessage__Args _args = new InternalUnsafeMethods.SetMessage__Args() {
                msg = msg,
             };
             InternalUnsafeMethods.SetMessage()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the SimpleNetObject class.
        /// </description>
        /// <returns>The type info object for SimpleNetObject</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
