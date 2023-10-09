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
    /// <summary>A GUI button with some special features that are useful for casting AFX spells.</summary>
    /// <description>
    /// 
    /// </description>
    public class afxSpellButton : GuiButtonCtrl {
        public afxSpellButton(bool pRegister = false)
            : base(pRegister) {
        }

        public afxSpellButton(string pName, bool pRegister)
            : base(pName, pRegister) {
        }

        public afxSpellButton(string pName)
            : this(pName, false) {
        }

        public afxSpellButton(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public afxSpellButton(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public afxSpellButton(SimObject pObj)
            : base(pObj) {
        }

        public afxSpellButton(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetFreeTargetStyle__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetFreeTargetStyle(IntPtr _this, GetFreeTargetStyle__Args args);
            private static _GetFreeTargetStyle _GetFreeTargetStyleFunc;
            internal static _GetFreeTargetStyle GetFreeTargetStyle() {
               _GetFreeTargetStyleFunc ??= Torque3D.LookupEngineFunction<_GetFreeTargetStyle>("fnafxSpellButton_getFreeTargetStyle");

                return _GetFreeTargetStyleFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct UseFreeTargeting__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _UseFreeTargeting(IntPtr _this, UseFreeTargeting__Args args);
            private static _UseFreeTargeting _UseFreeTargetingFunc;
            internal static _UseFreeTargeting UseFreeTargeting() {
               _UseFreeTargetingFunc ??= Torque3D.LookupEngineFunction<_UseFreeTargeting>("fnafxSpellButton_useFreeTargeting");

                return _UseFreeTargetingFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSpellRPGDataBlock__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSpellRPGDataBlock(IntPtr _this, GetSpellRPGDataBlock__Args args);
            private static _GetSpellRPGDataBlock _GetSpellRPGDataBlockFunc;
            internal static _GetSpellRPGDataBlock GetSpellRPGDataBlock() {
               _GetSpellRPGDataBlockFunc ??= Torque3D.LookupEngineFunction<_GetSpellRPGDataBlock>("fnafxSpellButton_getSpellRPGDataBlock");

                return _GetSpellRPGDataBlockFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSpellDataBlock__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _GetSpellDataBlock(IntPtr _this, GetSpellDataBlock__Args args);
            private static _GetSpellDataBlock _GetSpellDataBlockFunc;
            internal static _GetSpellDataBlock GetSpellDataBlock() {
               _GetSpellDataBlockFunc ??= Torque3D.LookupEngineFunction<_GetSpellDataBlock>("fnafxSpellButton_getSpellDataBlock");

                return _GetSpellDataBlockFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetSpellDescription__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetSpellDescription(IntPtr _this, GetSpellDescription__Args args);
            private static _GetSpellDescription _GetSpellDescriptionFunc;
            internal static _GetSpellDescription GetSpellDescription() {
               _GetSpellDescriptionFunc ??= Torque3D.LookupEngineFunction<_GetSpellDescription>("fnafxSpellButton_getSpellDescription");

                return _GetSpellDescriptionFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnTurnPage__Args
            {
                internal uint page;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnTurnPage(IntPtr _this, OnTurnPage__Args args);
            private static _OnTurnPage _OnTurnPageFunc;
            internal static _OnTurnPage OnTurnPage() {
               _OnTurnPageFunc ??= Torque3D.LookupEngineFunction<_OnTurnPage>("fnafxSpellButton_onTurnPage");

                return _OnTurnPageFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct OnSpellbookChange__Args
            {
                internal IntPtr spellbook;
                internal uint page;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _OnSpellbookChange(IntPtr _this, OnSpellbookChange__Args args);
            private static _OnSpellbookChange _OnSpellbookChangeFunc;
            internal static _OnSpellbookChange OnSpellbookChange() {
               _OnSpellbookChangeFunc ??= Torque3D.LookupEngineFunction<_OnSpellbookChange>("fnafxSpellButton_onSpellbookChange");

                return _OnSpellbookChangeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnafxSpellButton_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnafxSpellButton_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <description>
        /// Get the free targeting style used by the spell.
        /// </description>
        public int GetFreeTargetStyle() {
             InternalUnsafeMethods.GetFreeTargetStyle__Args _args = new InternalUnsafeMethods.GetFreeTargetStyle__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetFreeTargetStyle()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Test if spell uses free targeting.
        /// </description>
        public bool UseFreeTargeting() {
             InternalUnsafeMethods.UseFreeTargeting__Args _args = new InternalUnsafeMethods.UseFreeTargeting__Args() {
             };
             bool _engineResult = InternalUnsafeMethods.UseFreeTargeting()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the spell's RPG datablock.
        /// </description>
        public int GetSpellRPGDataBlock() {
             InternalUnsafeMethods.GetSpellRPGDataBlock__Args _args = new InternalUnsafeMethods.GetSpellRPGDataBlock__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSpellRPGDataBlock()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the spell's datablock.
        /// </description>
        public int GetSpellDataBlock() {
             InternalUnsafeMethods.GetSpellDataBlock__Args _args = new InternalUnsafeMethods.GetSpellDataBlock__Args() {
             };
             int _engineResult = InternalUnsafeMethods.GetSpellDataBlock()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// Get the text description of a spell.
        /// </description>
        public string GetSpellDescription() {
             InternalUnsafeMethods.GetSpellDescription__Args _args = new InternalUnsafeMethods.GetSpellDescription__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetSpellDescription()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <description>
        /// Notify an afxSpellButton when the spellbook turns to a new page.
        /// </description>
        public void OnTurnPage(uint page) {
             InternalUnsafeMethods.OnTurnPage__Args _args = new InternalUnsafeMethods.OnTurnPage__Args() {
                page = page,
             };
             InternalUnsafeMethods.OnTurnPage()(ObjectPtr, _args);
        }

        /// <description>
        /// Notify an afxSpellButton when its associated spellbook has changed.
        /// </description>
        public void OnSpellbookChange(afxSpellBook spellbook, uint page) {
             InternalUnsafeMethods.OnSpellbookChange__Args _args = new InternalUnsafeMethods.OnSpellbookChange__Args() {
                spellbook = spellbook.ObjectPtr,
                page = page,
             };
             InternalUnsafeMethods.OnSpellbookChange()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the afxSpellButton class.
        /// </description>
        /// <returns>The type info object for afxSpellButton</returns>
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
        public string Bitmap {
            get => GenericMarshal.StringTo<string>(GetFieldValue("Bitmap"));
            set => SetFieldValue("Bitmap", GenericMarshal.ToString(value));
        }


        /// <value>
        /// <description>
        /// ...
        /// </description>
        /// </value>
        public Point2I Book_slot {
            get => GenericMarshal.StringTo<Point2I>(GetFieldValue("book_slot"));
            set => SetFieldValue("book_slot", GenericMarshal.ToString(value));
        }
    }
}
