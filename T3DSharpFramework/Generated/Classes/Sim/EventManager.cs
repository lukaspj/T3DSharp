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
    /// <summary>The EventManager class is a wrapper for the standard messaging system.</summary>
    /// <description>
    /// It provides functionality for management of event queues, events, and subscriptions. Creating an EventManager is as simple as calling new EventManager and specifying a queue name.
    /// </description>
    /// <code>
    /// // Create the EventManager.
    /// $MyEventManager = new EventManager() { queue = "MyEventManager"; };
    /// 
    /// // Create an event.
    /// $MyEventManager.registerEvent( "SomeCoolEvent" );
    /// 
    /// // Create a listener and subscribe.
    /// $MyListener = new ScriptMsgListener() { class = MyListener; };
    /// $MyEventManager.subscribe( $MyListener, "SomeCoolEvent" );
    /// 
    /// function MyListener::onSomeCoolEvent( %this, %data )
    /// {
    /// 	  echo( "onSomeCoolEvent Triggered" );
    /// }
    /// 
    /// // Trigger the event.
    /// $MyEventManager.postEvent( "SomeCoolEvent", "Data" );
    /// </code>
    /// <see cref="ScriptMsgListener" />
    public class EventManager : SimObject {
        public EventManager(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public EventManager(string pName, bool pRegister)
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

        public EventManager(string pName)
            : this(pName, false) {
        }

        public EventManager(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public EventManager(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public EventManager(SimObject pObj)
            : base(pObj) {
        }

        public EventManager(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpSubscribers__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string listenerName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpSubscribers(IntPtr _this, DumpSubscribers__Args args);
            private static _DumpSubscribers _DumpSubscribersFunc;
            internal static _DumpSubscribers DumpSubscribers() {
               _DumpSubscribersFunc ??= Torque3D.LookupEngineFunction<_DumpSubscribers>("fnEventManager_dumpSubscribers");

                return _DumpSubscribersFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct DumpEvents__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _DumpEvents(IntPtr _this, DumpEvents__Args args);
            private static _DumpEvents _DumpEventsFunc;
            internal static _DumpEvents DumpEvents() {
               _DumpEventsFunc ??= Torque3D.LookupEngineFunction<_DumpEvents>("fnEventManager_dumpEvents");

                return _DumpEventsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveAll__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string listenerName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveAll(IntPtr _this, RemoveAll__Args args);
            private static _RemoveAll _RemoveAllFunc;
            internal static _RemoveAll RemoveAll() {
               _RemoveAllFunc ??= Torque3D.LookupEngineFunction<_RemoveAll>("fnEventManager_removeAll");

                return _RemoveAllFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Remove__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string listenerName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Remove(IntPtr _this, Remove__Args args);
            private static _Remove _RemoveFunc;
            internal static _Remove Remove() {
               _RemoveFunc ??= Torque3D.LookupEngineFunction<_Remove>("fnEventManager_remove");

                return _RemoveFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Subscribe__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string listenerName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string callback;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _Subscribe(IntPtr _this, Subscribe__Args args);
            private static _Subscribe _SubscribeFunc;
            internal static _Subscribe Subscribe() {
               _SubscribeFunc ??= Torque3D.LookupEngineFunction<_Subscribe>("fnEventManager_subscribe");

                return _SubscribeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PostEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string data;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _PostEvent(IntPtr _this, PostEvent__Args args);
            private static _PostEvent _PostEventFunc;
            internal static _PostEvent PostEvent() {
               _PostEventFunc ??= Torque3D.LookupEngineFunction<_PostEvent>("fnEventManager_postEvent");

                return _PostEventFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct IsRegisteredEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _IsRegisteredEvent(IntPtr _this, IsRegisteredEvent__Args args);
            private static _IsRegisteredEvent _IsRegisteredEventFunc;
            internal static _IsRegisteredEvent IsRegisteredEvent() {
               _IsRegisteredEventFunc ??= Torque3D.LookupEngineFunction<_IsRegisteredEvent>("fnEventManager_isRegisteredEvent");

                return _IsRegisteredEventFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UnregisterEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _UnregisterEvent(IntPtr _this, UnregisterEvent__Args args);
            private static _UnregisterEvent _UnregisterEventFunc;
            internal static _UnregisterEvent UnregisterEvent() {
               _UnregisterEventFunc ??= Torque3D.LookupEngineFunction<_UnregisterEvent>("fnEventManager_unregisterEvent");

                return _UnregisterEventFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RegisterEvent__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string evt;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _RegisterEvent(IntPtr _this, RegisterEvent__Args args);
            private static _RegisterEvent _RegisterEventFunc;
            internal static _RegisterEvent RegisterEvent() {
               _RegisterEventFunc ??= Torque3D.LookupEngineFunction<_RegisterEvent>("fnEventManager_registerEvent");

                return _RegisterEventFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnEventManager_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnEventManager_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// ( String event )
        /// 
        /// Print all subscribers to an event to the console.
        /// </description>
        /// <param name="event">The event whose subscribers are to be printed. If this parameter isn't specified, all events will be dumped.</param>
        public void DumpSubscribers(string listenerName = "") {
             InternalUnsafeMethods.DumpSubscribers__Args _args = new InternalUnsafeMethods.DumpSubscribers__Args() {
                listenerName = listenerName,
             };
             InternalUnsafeMethods.DumpSubscribers()(ObjectPtr, _args);
        }

        /// <description>
        /// ()
        /// 
        /// Print all registered events to the console.
        /// </description>
        public void DumpEvents() {
             InternalUnsafeMethods.DumpEvents__Args _args = new InternalUnsafeMethods.DumpEvents__Args() {
             };
             InternalUnsafeMethods.DumpEvents()(ObjectPtr, _args);
        }

        /// <description>
        /// ( SimObject listener )
        /// 
        /// Remove a listener from all events.
        /// </description>
        /// <param name="listener">The listener to remove.</param>
        public void RemoveAll(string listenerName) {
             InternalUnsafeMethods.RemoveAll__Args _args = new InternalUnsafeMethods.RemoveAll__Args() {
                listenerName = listenerName,
             };
             InternalUnsafeMethods.RemoveAll()(ObjectPtr, _args);
        }

        /// <description>
        /// ( SimObject listener, String event )
        /// 
        /// Remove a listener from an event.
        /// </description>
        /// <param name="listener">The listener to remove.</param>
        /// <param name="event">The event to be removed from.</param>
        public void Remove(string listenerName, string evt) {
             InternalUnsafeMethods.Remove__Args _args = new InternalUnsafeMethods.Remove__Args() {
                listenerName = listenerName,
                evt = evt,
             };
             InternalUnsafeMethods.Remove()(ObjectPtr, _args);
        }

        /// <description>
        /// ( SimObject listener, String event, String callback )
        /// 
        /// Subscribe a listener to an event.
        /// </description>
        /// <param name="listener">The listener to subscribe.</param>
        /// <param name="event">The event to subscribe to.</param>
        /// <param name="callback">Optional method name to receive the event notification. If this is not specified, "on[event]" will be used.</param>
        /// <returns>Whether or not the subscription was successful.</returns>
        public bool Subscribe(string listenerName, string evt, string callback = "") {
             InternalUnsafeMethods.Subscribe__Args _args = new InternalUnsafeMethods.Subscribe__Args() {
                listenerName = listenerName,
                evt = evt,
                callback = callback,
             };
             bool _engineResult = InternalUnsafeMethods.Subscribe()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ( String event, String data )
        /// ~Trigger an event.
        /// </description>
        /// <param name="event">The event to trigger.</param>
        /// <param name="data">The data associated with the event.</param>
        /// <returns>Whether or not the event was dispatched successfully.</returns>
        public bool PostEvent(string evt, string data = "") {
             InternalUnsafeMethods.PostEvent__Args _args = new InternalUnsafeMethods.PostEvent__Args() {
                evt = evt,
                data = data,
             };
             bool _engineResult = InternalUnsafeMethods.PostEvent()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ( String event )
        /// Check if an event is registered or not.
        /// </description>
        /// <param name="event">The event to check.</param>
        /// <returns>Whether or not the event exists.</returns>
        public bool IsRegisteredEvent(string evt) {
             InternalUnsafeMethods.IsRegisteredEvent__Args _args = new InternalUnsafeMethods.IsRegisteredEvent__Args() {
                evt = evt,
             };
             bool _engineResult = InternalUnsafeMethods.IsRegisteredEvent()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// ( String event )
        /// Remove an event from the EventManager.
        /// </description>
        /// <param name="event">The event to remove.</param>
        public void UnregisterEvent(string evt) {
             InternalUnsafeMethods.UnregisterEvent__Args _args = new InternalUnsafeMethods.UnregisterEvent__Args() {
                evt = evt,
             };
             InternalUnsafeMethods.UnregisterEvent()(ObjectPtr, _args);
        }

        /// <description>
        /// ( String event )
        /// Register an event with the event manager.
        /// </description>
        /// <param name="event">The event to register.</param>
        /// <returns>Whether or not the event was registered successfully.</returns>
        public bool RegisterEvent(string evt) {
             InternalUnsafeMethods.RegisterEvent__Args _args = new InternalUnsafeMethods.RegisterEvent__Args() {
                evt = evt,
             };
             bool _engineResult = InternalUnsafeMethods.RegisterEvent()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the type info object for the EventManager class.
        /// </description>
        /// <returns>The type info object for EventManager</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// List of events currently waiting
        /// </description>
        /// </value>
        public string Queue {
            get => GenericMarshal.StringTo<string>(GetFieldValue("queue"));
            set => SetFieldValue("queue", GenericMarshal.ToString(value));
        }
    }
}
