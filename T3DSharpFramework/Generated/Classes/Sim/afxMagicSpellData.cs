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
    /// <summary>Defines the properties of an afxMagicSpell.</summary>
    /// <description>
    /// 
    /// </description>
    public class afxMagicSpellData : afxChoreographerData {
        public afxMagicSpellData(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public afxMagicSpellData(string pName, bool pRegister)
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

        public afxMagicSpellData(string pName)
            : this(pName, false) {
        }

        public afxMagicSpellData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxMagicSpellData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxMagicSpellData(SimObject pObj)
            : base(pObj) {
        }

        public afxMagicSpellData(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct PushLingerEffect__Args
            {
                internal IntPtr effect;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushLingerEffect(IntPtr _this, PushLingerEffect__Args args);
            private static _PushLingerEffect _PushLingerEffectFunc;
            internal static _PushLingerEffect PushLingerEffect() {
               _PushLingerEffectFunc ??= Torque3D.LookupEngineFunction<_PushLingerEffect>("fnafxMagicSpellData_pushLingerEffect");

                return _PushLingerEffectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushImpactEffect__Args
            {
                internal IntPtr effect;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushImpactEffect(IntPtr _this, PushImpactEffect__Args args);
            private static _PushImpactEffect _PushImpactEffectFunc;
            internal static _PushImpactEffect PushImpactEffect() {
               _PushImpactEffectFunc ??= Torque3D.LookupEngineFunction<_PushImpactEffect>("fnafxMagicSpellData_pushImpactEffect");

                return _PushImpactEffectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushDeliveryEffect__Args
            {
                internal IntPtr effect;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushDeliveryEffect(IntPtr _this, PushDeliveryEffect__Args args);
            private static _PushDeliveryEffect _PushDeliveryEffectFunc;
            internal static _PushDeliveryEffect PushDeliveryEffect() {
               _PushDeliveryEffectFunc ??= Torque3D.LookupEngineFunction<_PushDeliveryEffect>("fnafxMagicSpellData_pushDeliveryEffect");

                return _PushDeliveryEffectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushLaunchEffect__Args
            {
                internal IntPtr effect;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushLaunchEffect(IntPtr _this, PushLaunchEffect__Args args);
            private static _PushLaunchEffect _PushLaunchEffectFunc;
            internal static _PushLaunchEffect PushLaunchEffect() {
               _PushLaunchEffectFunc ??= Torque3D.LookupEngineFunction<_PushLaunchEffect>("fnafxMagicSpellData_pushLaunchEffect");

                return _PushLaunchEffectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushCastingEffect__Args
            {
                internal IntPtr effect;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushCastingEffect(IntPtr _this, PushCastingEffect__Args args);
            private static _PushCastingEffect _PushCastingEffectFunc;
            internal static _PushCastingEffect PushCastingEffect() {
               _PushCastingEffectFunc ??= Torque3D.LookupEngineFunction<_PushCastingEffect>("fnafxMagicSpellData_pushCastingEffect");

                return _PushCastingEffectFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
               _ResetFunc ??= Torque3D.LookupEngineFunction<_Reset>("fnafxMagicSpellData_reset");

                return _ResetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnActivate__Args
            {
                internal IntPtr spell;
                internal IntPtr caster;
                internal IntPtr target;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnActivate(IntPtr _this, OnActivate__Args args);
            private static _OnActivate _OnActivateFunc;
            internal static _OnActivate OnActivate() {
               _OnActivateFunc ??= Torque3D.LookupEngineFunction<_OnActivate>("cbafxMagicSpellData_onActivate");

                return _OnActivateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnPreactivate__Args
            {
                internal IntPtr param_holder;
                internal IntPtr caster;
                internal IntPtr target;
                internal IntPtr extra;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _OnPreactivate(IntPtr _this, OnPreactivate__Args args);
            private static _OnPreactivate _OnPreactivateFunc;
            internal static _OnPreactivate OnPreactivate() {
               _OnPreactivateFunc ??= Torque3D.LookupEngineFunction<_OnPreactivate>("cbafxMagicSpellData_onPreactivate");

                return _OnPreactivateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnImpact__Args
            {
                internal IntPtr spell;
                internal IntPtr caster;
                internal IntPtr impacted;
                internal IntPtr pos;
                internal IntPtr normal;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnImpact(IntPtr _this, OnImpact__Args args);
            private static _OnImpact _OnImpactFunc;
            internal static _OnImpact OnImpact() {
               _OnImpactFunc ??= Torque3D.LookupEngineFunction<_OnImpact>("cbafxMagicSpellData_onImpact");

                return _OnImpactFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnLaunch__Args
            {
                internal IntPtr spell;
                internal IntPtr caster;
                internal IntPtr target;
                internal IntPtr missile;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnLaunch(IntPtr _this, OnLaunch__Args args);
            private static _OnLaunch _OnLaunchFunc;
            internal static _OnLaunch OnLaunch() {
               _OnLaunchFunc ??= Torque3D.LookupEngineFunction<_OnLaunch>("cbafxMagicSpellData_onLaunch");

                return _OnLaunchFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnInterrupt__Args
            {
                internal IntPtr spell;
                internal IntPtr caster;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnInterrupt(IntPtr _this, OnInterrupt__Args args);
            private static _OnInterrupt _OnInterruptFunc;
            internal static _OnInterrupt OnInterrupt() {
               _OnInterruptFunc ??= Torque3D.LookupEngineFunction<_OnInterrupt>("cbafxMagicSpellData_onInterrupt");

                return _OnInterruptFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDeactivate__Args
            {
                internal IntPtr spell;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDeactivate(IntPtr _this, OnDeactivate__Args args);
            private static _OnDeactivate _OnDeactivateFunc;
            internal static _OnDeactivate OnDeactivate() {
               _OnDeactivateFunc ??= Torque3D.LookupEngineFunction<_OnDeactivate>("cbafxMagicSpellData_onDeactivate");

                return _OnDeactivateFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnDamage__Args
            {
                internal IntPtr spell;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string label;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string flaver;
                internal uint target_id;
                internal float amount;
                internal byte n;
                internal IntPtr pos;
                internal float ad_amount;
                internal float radius;
                internal float impulse;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnDamage(IntPtr _this, OnDamage__Args args);
            private static _OnDamage _OnDamageFunc;
            internal static _OnDamage OnDamage() {
               _OnDamageFunc ??= Torque3D.LookupEngineFunction<_OnDamage>("cbafxMagicSpellData_onDamage");

                return _OnDamageFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxMagicSpellData_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxMagicSpellData_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Adds an effect (wrapper or group) to a spell's linger phase.
        /// </description>
        public void PushLingerEffect(afxEffectBaseData effect) {
             InternalUnsafeMethods.PushLingerEffect__Args _args = new InternalUnsafeMethods.PushLingerEffect__Args() {
                effect = effect.ObjectPtr,
             };
             InternalUnsafeMethods.PushLingerEffect()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds an effect (wrapper or group) to a spell's impact phase.
        /// </description>
        public void PushImpactEffect(afxEffectBaseData effect) {
             InternalUnsafeMethods.PushImpactEffect__Args _args = new InternalUnsafeMethods.PushImpactEffect__Args() {
                effect = effect.ObjectPtr,
             };
             InternalUnsafeMethods.PushImpactEffect()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds an effect (wrapper or group) to a spell's delivery phase.
        /// </description>
        public void PushDeliveryEffect(afxEffectBaseData effect) {
             InternalUnsafeMethods.PushDeliveryEffect__Args _args = new InternalUnsafeMethods.PushDeliveryEffect__Args() {
                effect = effect.ObjectPtr,
             };
             InternalUnsafeMethods.PushDeliveryEffect()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds an effect (wrapper or group) to a spell's launch phase.
        /// </description>
        public void PushLaunchEffect(afxEffectBaseData effect) {
             InternalUnsafeMethods.PushLaunchEffect__Args _args = new InternalUnsafeMethods.PushLaunchEffect__Args() {
                effect = effect.ObjectPtr,
             };
             InternalUnsafeMethods.PushLaunchEffect()(ObjectPtr, _args);
        }

        /// <description>
        /// Adds an effect (wrapper or group) to a spell's casting phase.
        /// </description>
        public void PushCastingEffect(afxEffectBaseData effect) {
             InternalUnsafeMethods.PushCastingEffect__Args _args = new InternalUnsafeMethods.PushCastingEffect__Args() {
                effect = effect.ObjectPtr,
             };
             InternalUnsafeMethods.PushCastingEffect()(ObjectPtr, _args);
        }

        /// <description>
        /// Resets a spell datablock during reload.
        /// </description>
        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the spell starts.
        /// </description>
        /// <param name="spell">the spell object</param>
        public virtual void OnActivate(afxMagicSpell spell, ShapeBase caster, SceneObject target) {
             InternalUnsafeMethods.OnActivate__Args _args = new InternalUnsafeMethods.OnActivate__Args() {
                spell = spell.ObjectPtr,
                caster = caster.ObjectPtr,
                target = target.ObjectPtr,
             };
             InternalUnsafeMethods.OnActivate()(ObjectPtr, _args);
        }

        /// <description>
        /// Called during spell casting before spell instance is fully created.
        /// </description>
        public virtual bool OnPreactivate(SimObject param_holder, ShapeBase caster, SceneObject target, SimObject extra) {
             InternalUnsafeMethods.OnPreactivate__Args _args = new InternalUnsafeMethods.OnPreactivate__Args() {
                param_holder = param_holder.ObjectPtr,
                caster = caster.ObjectPtr,
                target = target.ObjectPtr,
                extra = extra.ObjectPtr,
             };
             bool _engineResult = InternalUnsafeMethods.OnPreactivate()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Called at the spell's missile impact marking the end of the deliver stage and the start of the linger stage.
        /// </description>
        /// <param name="spell">the spell object</param>
        public virtual void OnImpact(afxMagicSpell spell, ShapeBase caster, SceneObject impacted, Point3F pos, Point3F normal) {
pos.Alloc();normal.Alloc();             InternalUnsafeMethods.OnImpact__Args _args = new InternalUnsafeMethods.OnImpact__Args() {
                spell = spell.ObjectPtr,
                caster = caster.ObjectPtr,
                impacted = impacted.ObjectPtr,
                pos = pos.internalStructPtr,
                normal = normal.internalStructPtr,
             };
             InternalUnsafeMethods.OnImpact()(ObjectPtr, _args);
pos.Free();normal.Free();        }

        /// <description>
        /// Called when the spell's casting stage ends and the delivery stage begins.
        /// </description>
        /// <param name="spell">the spell object</param>
        public virtual void OnLaunch(afxMagicSpell spell, ShapeBase caster, SceneObject target, afxMagicMissile missile) {
             InternalUnsafeMethods.OnLaunch__Args _args = new InternalUnsafeMethods.OnLaunch__Args() {
                spell = spell.ObjectPtr,
                caster = caster.ObjectPtr,
                target = target.ObjectPtr,
                missile = missile.ObjectPtr,
             };
             InternalUnsafeMethods.OnLaunch()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the spell ends unnaturally due to an interruption.
        /// </description>
        /// <param name="spell">the spell object</param>
        public virtual void OnInterrupt(afxMagicSpell spell, ShapeBase caster) {
             InternalUnsafeMethods.OnInterrupt__Args _args = new InternalUnsafeMethods.OnInterrupt__Args() {
                spell = spell.ObjectPtr,
                caster = caster.ObjectPtr,
             };
             InternalUnsafeMethods.OnInterrupt()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the spell ends naturally.
        /// </description>
        /// <param name="spell">the spell object</param>
        public virtual void OnDeactivate(afxMagicSpell spell) {
             InternalUnsafeMethods.OnDeactivate__Args _args = new InternalUnsafeMethods.OnDeactivate__Args() {
                spell = spell.ObjectPtr,
             };
             InternalUnsafeMethods.OnDeactivate()(ObjectPtr, _args);
        }

        /// <description>
        /// Called when the spell deals damage.
        /// </description>
        /// <param name="spell">the spell object</param>
        public virtual void OnDamage(afxMagicSpell spell, string label, string flaver, uint target_id, float amount, byte n, Point3F pos, float ad_amount, float radius, float impulse) {
pos.Alloc();             InternalUnsafeMethods.OnDamage__Args _args = new InternalUnsafeMethods.OnDamage__Args() {
                spell = spell.ObjectPtr,
                label = label,
                flaver = flaver,
                target_id = target_id,
                amount = amount,
                n = n,
                pos = pos.internalStructPtr,
                ad_amount = ad_amount,
                radius = radius,
                impulse = impulse,
             };
             InternalUnsafeMethods.OnDamage()(ObjectPtr, _args);
pos.Free();        }

        /// <description>
        /// Get the type info object for the afxMagicSpellData class.
        /// </description>
        /// <returns>The type info object for afxMagicSpellData</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float CastingDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("castingDur"));
            set => SetFieldValue("castingDur", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int NumCastingLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numCastingLoops"));
            set => SetFieldValue("numCastingLoops", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float ExtraCastingTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("extraCastingTime"));
            set => SetFieldValue("extraCastingTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxEffectBaseData AddCastingEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addCastingEffect"));
            set => SetFieldValue("addCastingEffect", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float DeliveryDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("deliveryDur"));
            set => SetFieldValue("deliveryDur", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int NumDeliveryLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numDeliveryLoops"));
            set => SetFieldValue("numDeliveryLoops", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float ExtraDeliveryTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("extraDeliveryTime"));
            set => SetFieldValue("extraDeliveryTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxEffectBaseData AddLaunchEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addLaunchEffect"));
            set => SetFieldValue("addLaunchEffect", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxEffectBaseData AddDeliveryEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addDeliveryEffect"));
            set => SetFieldValue("addDeliveryEffect", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float LingerDur {
            get => GenericMarshal.StringTo<float>(GetFieldValue("lingerDur"));
            set => SetFieldValue("lingerDur", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int NumLingerLoops {
            get => GenericMarshal.StringTo<int>(GetFieldValue("numLingerLoops"));
            set => SetFieldValue("numLingerLoops", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float ExtraLingerTime {
            get => GenericMarshal.StringTo<float>(GetFieldValue("extraLingerTime"));
            set => SetFieldValue("extraLingerTime", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxEffectBaseData AddImpactEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addImpactEffect"));
            set => SetFieldValue("addImpactEffect", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxEffectBaseData AddLingerEffect {
            get => GenericMarshal.StringTo<afxEffectBaseData>(GetFieldValue("addLingerEffect"));
            set => SetFieldValue("addLingerEffect", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public bool AllowMovementInterrupts {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("allowMovementInterrupts"));
            set => SetFieldValue("allowMovementInterrupts", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public float MovementInterruptSpeed {
            get => GenericMarshal.StringTo<float>(GetFieldValue("movementInterruptSpeed"));
            set => SetFieldValue("movementInterruptSpeed", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public afxMagicMissileData Missile {
            get => GenericMarshal.StringTo<afxMagicMissileData>(GetFieldValue("missile"));
            set => SetFieldValue("missile", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public bool LaunchOnServerSignal {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("launchOnServerSignal"));
            set => SetFieldValue("launchOnServerSignal", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public int PrimaryTargetTypes {
            get => GenericMarshal.StringTo<int>(GetFieldValue("primaryTargetTypes"));
            set => SetFieldValue("primaryTargetTypes", GenericMarshal.ToString(value));
        }
    }
}
