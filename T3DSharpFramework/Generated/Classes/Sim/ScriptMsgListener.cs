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
    public class ScriptMsgListener : SimObject {
        public ScriptMsgListener(bool pRegister = false)
            : base(pRegister) {
        }

        public ScriptMsgListener(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public ScriptMsgListener(string pName)
            : this(pName, false) {
        }

        public ScriptMsgListener(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ScriptMsgListener(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ScriptMsgListener(SimObject pObj)
            : base(pObj) {
        }

        public ScriptMsgListener(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct OnRemoveFromQueue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string queue;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnRemoveFromQueue(IntPtr _this, OnRemoveFromQueue__Args args);
            private static _OnRemoveFromQueue _OnRemoveFromQueueFunc;
            internal static _OnRemoveFromQueue OnRemoveFromQueue() {
               _OnRemoveFromQueueFunc ??= Torque3D.LookupEngineFunction<_OnRemoveFromQueue>("cbScriptMsgListener_onRemoveFromQueue");

                return _OnRemoveFromQueueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnAddToQueue__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string queue;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnAddToQueue(IntPtr _this, OnAddToQueue__Args args);
            private static _OnAddToQueue _OnAddToQueueFunc;
            internal static _OnAddToQueue OnAddToQueue() {
               _OnAddToQueueFunc ??= Torque3D.LookupEngineFunction<_OnAddToQueue>("cbScriptMsgListener_onAddToQueue");

                return _OnAddToQueueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMessageObjectReceived__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string queue;
                internal IntPtr msg;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _OnMessageObjectReceived(IntPtr _this, OnMessageObjectReceived__Args args);
            private static _OnMessageObjectReceived _OnMessageObjectReceivedFunc;
            internal static _OnMessageObjectReceived OnMessageObjectReceived() {
               _OnMessageObjectReceivedFunc ??= Torque3D.LookupEngineFunction<_OnMessageObjectReceived>("cbScriptMsgListener_onMessageObjectReceived");

                return _OnMessageObjectReceivedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnMessageReceived__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string queue;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string _event;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string data;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _OnMessageReceived(IntPtr _this, OnMessageReceived__Args args);
            private static _OnMessageReceived _OnMessageReceivedFunc;
            internal static _OnMessageReceived OnMessageReceived() {
               _OnMessageReceivedFunc ??= Torque3D.LookupEngineFunction<_OnMessageReceived>("cbScriptMsgListener_onMessageReceived");

                return _OnMessageReceivedFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnRemove__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnRemove(IntPtr _this, OnRemove__Args args);
            private static _OnRemove _OnRemoveFunc;
            internal static _OnRemove OnRemove() {
               _OnRemoveFunc ??= Torque3D.LookupEngineFunction<_OnRemove>("cbScriptMsgListener_onRemove");

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
               _OnAddFunc ??= Torque3D.LookupEngineFunction<_OnAdd>("cbScriptMsgListener_onAdd");

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
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnScriptMsgListener_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnScriptMsgListener_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Callback for when the listener is removed from a queue</summary>
        /// <description>
        /// The default implementation of onAddToQueue() and onRemoveFromQueue() provide tracking of the queues this listener is added to through the mQueues member. Overrides of onAddToQueue() or onRemoveFromQueue() should ensure they call the parent implementation in any overrides.
        /// </description>
        /// <param name="queue">The name of the queue that the listener was removed from</param>
        /// <see cref="onAddToQueue()" />
        public virtual void OnRemoveFromQueue(string queue) {
             InternalUnsafeMethods.OnRemoveFromQueue__Args _args = new InternalUnsafeMethods.OnRemoveFromQueue__Args() {
                queue = queue,
             };
             InternalUnsafeMethods.OnRemoveFromQueue()(ObjectPtr, _args);
        }

        /// <summary>Callback for when the listener is added to a queue</summary>
        /// <description>
        /// The default implementation of onAddToQueue() and onRemoveFromQueue() provide tracking of the queues this listener is added to through the mQueues member. Overrides of onAddToQueue() or onRemoveFromQueue() should ensure they call the parent implementation in any overrides.
        /// </description>
        /// <param name="queue">The name of the queue that the listener added to</param>
        /// <see cref="onRemoveFromQueue()" />
        public virtual void OnAddToQueue(string queue) {
             InternalUnsafeMethods.OnAddToQueue__Args _args = new InternalUnsafeMethods.OnAddToQueue__Args() {
                queue = queue,
             };
             InternalUnsafeMethods.OnAddToQueue()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when a message object (not just the message data) is passed to a listener.
        /// </description>
        /// <param name="queue">The name of the queue the message was dispatched to</param>
        /// <param name="msg">The message object</param>
        /// <returns>false to prevent other listeners receiving this message, true otherwise</returns>
        /// <see cref="Message" />
        /// <see cref="onMessageReceived" />
        public virtual bool OnMessageObjectReceived(string queue, Message msg) {
             InternalUnsafeMethods.OnMessageObjectReceived__Args _args = new InternalUnsafeMethods.OnMessageObjectReceived__Args() {
                queue = queue,
                msg = msg.ObjectPtr,
             };
             bool _engineResult = InternalUnsafeMethods.OnMessageObjectReceived()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Called when the listener has received a message.
        /// </description>
        /// <param name="queue">The name of the queue the message was dispatched to</param>
        /// <param name="event">The name of the event (function) that was triggered</param>
        /// <param name="data">The data (parameters) for the message</param>
        /// <returns>false to prevent other listeners receiving this message, true otherwise</returns>
        public virtual bool OnMessageReceived(string queue, string _event, string data) {
             InternalUnsafeMethods.OnMessageReceived__Args _args = new InternalUnsafeMethods.OnMessageReceived__Args() {
                queue = queue,
                _event = _event,
                data = data,
             };
             bool _engineResult = InternalUnsafeMethods.OnMessageReceived()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Script callback when a listener is deleted.
        /// </description>
        /// <code>
        /// function ScriptMsgListener::onRemove(%this)
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
        /// Script callback when a listener is first created and registered.
        /// </description>
        /// <code>
        /// function ScriptMsgListener::onAdd(%this)
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
        /// Get the type info object for the ScriptMsgListener class.
        /// </description>
        /// <returns>The type info object for ScriptMsgListener</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
