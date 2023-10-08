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
    /// <summary>Base class for messages</summary>
    /// <description>
    /// Message is the base class for C++ defined messages, and may also be used in script for script defined messages if no C++ subclass is appropriate.
    /// 
    /// Messages are reference counted and will be automatically deleted when their reference count reaches zero. When you dispatch a message, a reference will be added before the dispatch and freed after the dispatch. This allows for temporary messages with no additional code. If you want to keep the message around, for example to dispatch it to multiple queues, call addReference() before dispatching it and freeReference() when you are done with it. Never delete a Message object directly unless addReference() has not been called or the message has not been dispatched.
    /// 
    /// Message IDs are pooled similarly to datablocks, with the exception that IDs are reused. If you keep a message for longer than a single dispatch, then you should ensure that you clear any script variables that refer to it after the last freeReference(). If you don't, then it is probable that the object ID will become valid again in the future and could cause hard to track down bugs.
    /// 
    /// Messages have a unique type to simplify message handling code. For object messages, the type is defined as either the script defined class name or the C++ class name if no script class was defined. The message type may be obtained through the getType() method.
    /// 
    /// By convention, any data for the message is held in script accessible fields. Messages that need to be handled in C++ as well as script provide the relevant data through persistent fields in a subclass of Message to provide best performance on the C++ side. Script defined messages usually their through dynamic fields, and may be accessed in C++ using the SimObject::getDataField() method.
    /// </description>
    public class Message : SimObject {
        public Message(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public Message(string pName, bool pRegister)
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

        public Message(string pName)
            : this(pName, false) {
        }

        public Message(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public Message(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public Message(SimObject pObj)
            : base(pObj) {
        }

        public Message(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct FreeReference__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _FreeReference(IntPtr _this, FreeReference__Args args);
            private static _FreeReference _FreeReferenceFunc;
            internal static _FreeReference FreeReference() {
               _FreeReferenceFunc ??= Torque3D.LookupEngineFunction<_FreeReference>("fnMessage_freeReference");

                return _FreeReferenceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddReference__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddReference(IntPtr _this, AddReference__Args args);
            private static _AddReference _AddReferenceFunc;
            internal static _AddReference AddReference() {
               _AddReferenceFunc ??= Torque3D.LookupEngineFunction<_AddReference>("fnMessage_addReference");

                return _AddReferenceFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetType(IntPtr _this, GetType__Args args);
            private static _GetType _GetTypeFunc;
            internal static _GetType GetType() {
               _GetTypeFunc ??= Torque3D.LookupEngineFunction<_GetType>("fnMessage_getType");

                return _GetTypeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnRemove__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnRemove(IntPtr _this, OnRemove__Args args);
            private static _OnRemove _OnRemoveFunc;
            internal static _OnRemove OnRemove() {
               _OnRemoveFunc ??= Torque3D.LookupEngineFunction<_OnRemove>("cbMessage_onRemove");

                return _OnRemoveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAdd__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAdd(IntPtr _this, OnAdd__Args args);
            private static _OnAdd _OnAddFunc;
            internal static _OnAdd OnAdd() {
               _OnAddFunc ??= Torque3D.LookupEngineFunction<_OnAdd>("cbMessage_onAdd");

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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnMessage_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnMessage_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// () Decrement the reference count for this message
        /// </description>
        public void FreeReference() {
             InternalUnsafeMethods.FreeReference__Args _args = new InternalUnsafeMethods.FreeReference__Args() {
             };
             InternalUnsafeMethods.FreeReference()(ObjectPtr, _args);
        }

        /// <description>
        /// () Increment the reference count for this message
        /// </description>
        public void AddReference() {
             InternalUnsafeMethods.AddReference__Args _args = new InternalUnsafeMethods.AddReference__Args() {
             };
             InternalUnsafeMethods.AddReference()(ObjectPtr, _args);
        }

        /// <description>
        /// () Get message type (script class name or C++ class name if no script defined class)
        /// </description>
        public string GetType() {
             InternalUnsafeMethods.GetType__Args _args = new InternalUnsafeMethods.GetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetType()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Script callback when a message is deleted.
        /// </description>
        /// <code>
        /// function Message::onRemove(%this)
        /// {
        /// 	// Perform on remove code here
        /// }
        /// </code>
        public virtual void OnRemove() {
             InternalUnsafeMethods.OnRemove__Args _args = new InternalUnsafeMethods.OnRemove__Args() {
             };
             InternalUnsafeMethods.OnRemove()(ObjectPtr, _args);
        }

        /// <description>
        /// Script callback when a message is first created and registered.
        /// </description>
        /// <code>
        /// function Message::onAdd(%this)
        /// {
        /// 	// Perform on add code here
        /// }
        /// </code>
        public virtual void OnAdd() {
             InternalUnsafeMethods.OnAdd__Args _args = new InternalUnsafeMethods.OnAdd__Args() {
             };
             InternalUnsafeMethods.OnAdd()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the Message class.
        /// </description>
        /// <returns>The type info object for Message</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
