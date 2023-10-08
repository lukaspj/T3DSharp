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
    /// <summary>File I/O object used for creating, reading, and writing XML documents.</summary>
    /// <description>
    /// A SimXMLDocument is a container of various XML nodes.  The Document level may contain a header (sometimes called a declaration), comments and child Elements.  Elements may contain attributes, data (or text) and child Elements.
    /// 
    /// You build new Elements using addNewElement().  This makes the new Element the current one you're working with.  You then use setAttribute() to add attributes to the Element.  You use addData() or addText() to write to the text area of an Element.
    /// </description>
    /// <code>
    /// // Thanks to Rex Hiebert for this example
    /// // Given the following XML
    /// <?xml version="1.0" encoding="utf-8" standalone="yes" ?>
    /// <DataTables>
    ///   <table tableName="2DShapes">
    ///      <rec id="1">Triangle</rec>
    ///      <rec id="2">Square</rec>
    ///      <rec id="3">Circle</rec>
    ///   </table>
    ///   <table tableName="3DShapes">
    ///      <rec id="1">Pyramid</rec>
    ///      <rec id="2">Cube</rec>
    ///      <rec id="3">Sphere</rec>
    ///   </table>
    /// </DataTables>
    /// 
    /// // Using SimXMLDocument by itself
    /// function readXmlExample(%filename)
    /// {
    ///    %xml = new SimXMLDocument() {};
    ///    %xml.loadFile(%filename);
    /// 
    ///    %xml.pushChildElement("DataTables");
    ///    %xml.pushFirstChildElement("table");
    ///    while(true)
    ///    {
    ///     echo("TABLE:" SPC %xml.attribute("tableName"));
    ///     %xml.pushFirstChildElement("rec");
    ///     while (true)
    ///     {
    ///       %id = %xml.attribute("id");
    ///       %desc = %xml.getData();
    ///       echo("  Shape" SPC %id SPC %desc);
    ///       if (!%xml.nextSiblingElement("rec")) break;
    ///     }
    ///     %xml.popElement();
    ///     if (!%xml.nextSiblingElement("table")) break;
    ///    }
    /// }
    /// 
    /// // Thanks to Scott Peal for this example
    /// // Using FileObject in conjunction with SimXMLDocument
    /// // This example uses an XML file with a format of:
    /// // <Models>
    /// //    <Model category="" name="" path="" />
    /// // </Models>
    /// function getModelsInCatagory()
    /// {
    ///    %file = "./Catalog.xml";
    ///    %fo = new FileObject();
    ///    %text = "";
    /// 
    ///    if(%fo.openForRead(%file))
    ///    {
    ///     while(!%fo.isEOF())
    ///     {
    ///       %text = %text@ %fo.readLine();
    ///       if (!%fo.isEOF()) %text = %text 
    /// </code>
    /// <remarks> SimXMLDocument is a wrapper around TinyXml, a standard XML library.  If you're familiar with its concepts, you'll find they also apply here.
    /// 
    /// </remarks>
    /// <see cref="FileObject" />
    public class SimXMLDocument : SimObject {
        public SimXMLDocument(bool pRegister = false)
            : base(pRegister) {
           // Always set the Class Namespace to the C# class name
           ClassName = ((object)this).GetType().Name;
        }

        public SimXMLDocument(string pName, bool pRegister)
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

        public SimXMLDocument(string pName)
            : this(pName, false) {
        }

        public SimXMLDocument(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SimXMLDocument(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SimXMLDocument(SimObject pObj)
            : base(pObj) {
        }

        public SimXMLDocument(IntPtr pObj)
            : base(pObj) {
        }

		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}


        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct GetData__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetData(IntPtr _this, GetData__Args args);
            private static _GetData _GetDataFunc;
            internal static _GetData GetData() {
               _GetDataFunc ??= Torque3D.LookupEngineFunction<_GetData>("fnSimXMLDocument_getData");

                return _GetDataFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddData__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddData(IntPtr _this, AddData__Args args);
            private static _AddData _AddDataFunc;
            internal static _AddData AddData() {
               _AddDataFunc ??= Torque3D.LookupEngineFunction<_AddData>("fnSimXMLDocument_addData");

                return _AddDataFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct RemoveText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _RemoveText(IntPtr _this, RemoveText__Args args);
            private static _RemoveText _RemoveTextFunc;
            internal static _RemoveText RemoveText() {
               _RemoveTextFunc ??= Torque3D.LookupEngineFunction<_RemoveText>("fnSimXMLDocument_removeText");

                return _RemoveTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetText__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetText(IntPtr _this, GetText__Args args);
            private static _GetText _GetTextFunc;
            internal static _GetText GetText() {
               _GetTextFunc ??= Torque3D.LookupEngineFunction<_GetText>("fnSimXMLDocument_getText");

                return _GetTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddText__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string text;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddText(IntPtr _this, AddText__Args args);
            private static _AddText _AddTextFunc;
            internal static _AddText AddText() {
               _AddTextFunc ??= Torque3D.LookupEngineFunction<_AddText>("fnSimXMLDocument_addText");

                return _AddTextFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ReadComment__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ReadComment(IntPtr _this, ReadComment__Args args);
            private static _ReadComment _ReadCommentFunc;
            internal static _ReadComment ReadComment() {
               _ReadCommentFunc ??= Torque3D.LookupEngineFunction<_ReadComment>("fnSimXMLDocument_readComment");

                return _ReadCommentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddComment__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string comment;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddComment(IntPtr _this, AddComment__Args args);
            private static _AddComment _AddCommentFunc;
            internal static _AddComment AddComment() {
               _AddCommentFunc ??= Torque3D.LookupEngineFunction<_AddComment>("fnSimXMLDocument_addComment");

                return _AddCommentFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddHeader__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddHeader(IntPtr _this, AddHeader__Args args);
            private static _AddHeader _AddHeaderFunc;
            internal static _AddHeader AddHeader() {
               _AddHeaderFunc ??= Torque3D.LookupEngineFunction<_AddHeader>("fnSimXMLDocument_addHeader");

                return _AddHeaderFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AddNewElement__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _AddNewElement(IntPtr _this, AddNewElement__Args args);
            private static _AddNewElement _AddNewElementFunc;
            internal static _AddNewElement AddNewElement() {
               _AddNewElementFunc ??= Torque3D.LookupEngineFunction<_AddNewElement>("fnSimXMLDocument_addNewElement");

                return _AddNewElementFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushNewElement__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PushNewElement(IntPtr _this, PushNewElement__Args args);
            private static _PushNewElement _PushNewElementFunc;
            internal static _PushNewElement PushNewElement() {
               _PushNewElementFunc ??= Torque3D.LookupEngineFunction<_PushNewElement>("fnSimXMLDocument_pushNewElement");

                return _PushNewElementFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetObjectAttributes__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string objectID;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetObjectAttributes(IntPtr _this, SetObjectAttributes__Args args);
            private static _SetObjectAttributes _SetObjectAttributesFunc;
            internal static _SetObjectAttributes SetObjectAttributes() {
               _SetObjectAttributesFunc ??= Torque3D.LookupEngineFunction<_SetObjectAttributes>("fnSimXMLDocument_setObjectAttributes");

                return _SetObjectAttributesFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SetAttribute__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string value;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _SetAttribute(IntPtr _this, SetAttribute__Args args);
            private static _SetAttribute _SetAttributeFunc;
            internal static _SetAttribute SetAttribute() {
               _SetAttributeFunc ??= Torque3D.LookupEngineFunction<_SetAttribute>("fnSimXMLDocument_setAttribute");

                return _SetAttributeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PrevAttribute__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _PrevAttribute(IntPtr _this, PrevAttribute__Args args);
            private static _PrevAttribute _PrevAttributeFunc;
            internal static _PrevAttribute PrevAttribute() {
               _PrevAttributeFunc ??= Torque3D.LookupEngineFunction<_PrevAttribute>("fnSimXMLDocument_prevAttribute");

                return _PrevAttributeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct NextAttribute__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _NextAttribute(IntPtr _this, NextAttribute__Args args);
            private static _NextAttribute _NextAttributeFunc;
            internal static _NextAttribute NextAttribute() {
               _NextAttributeFunc ??= Torque3D.LookupEngineFunction<_NextAttribute>("fnSimXMLDocument_nextAttribute");

                return _NextAttributeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct LastAttribute__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _LastAttribute(IntPtr _this, LastAttribute__Args args);
            private static _LastAttribute _LastAttributeFunc;
            internal static _LastAttribute LastAttribute() {
               _LastAttributeFunc ??= Torque3D.LookupEngineFunction<_LastAttribute>("fnSimXMLDocument_lastAttribute");

                return _LastAttributeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct FirstAttribute__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _FirstAttribute(IntPtr _this, FirstAttribute__Args args);
            private static _FirstAttribute _FirstAttributeFunc;
            internal static _FirstAttribute FirstAttribute() {
               _FirstAttributeFunc ??= Torque3D.LookupEngineFunction<_FirstAttribute>("fnSimXMLDocument_firstAttribute");

                return _FirstAttributeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AttributeExists__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _AttributeExists(IntPtr _this, AttributeExists__Args args);
            private static _AttributeExists _AttributeExistsFunc;
            internal static _AttributeExists AttributeExists() {
               _AttributeExistsFunc ??= Torque3D.LookupEngineFunction<_AttributeExists>("fnSimXMLDocument_attributeExists");

                return _AttributeExistsFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AttributeS32__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate int _AttributeS32(IntPtr _this, AttributeS32__Args args);
            private static _AttributeS32 _AttributeS32Func;
            internal static _AttributeS32 AttributeS32() {
               _AttributeS32Func ??= Torque3D.LookupEngineFunction<_AttributeS32>("fnSimXMLDocument_attributeS32");

                return _AttributeS32Func;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct AttributeF32__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate float _AttributeF32(IntPtr _this, AttributeF32__Args args);
            private static _AttributeF32 _AttributeF32Func;
            internal static _AttributeF32 AttributeF32() {
               _AttributeF32Func ??= Torque3D.LookupEngineFunction<_AttributeF32>("fnSimXMLDocument_attributeF32");

                return _AttributeF32Func;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Attribute__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string attributeName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _Attribute(IntPtr _this, Attribute__Args args);
            private static _Attribute _AttributeFunc;
            internal static _Attribute Attribute() {
               _AttributeFunc ??= Torque3D.LookupEngineFunction<_Attribute>("fnSimXMLDocument_attribute");

                return _AttributeFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PopElement__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _PopElement(IntPtr _this, PopElement__Args args);
            private static _PopElement _PopElementFunc;
            internal static _PopElement PopElement() {
               _PopElementFunc ??= Torque3D.LookupEngineFunction<_PopElement>("fnSimXMLDocument_popElement");

                return _PopElementFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ElementValue__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _ElementValue(IntPtr _this, ElementValue__Args args);
            private static _ElementValue _ElementValueFunc;
            internal static _ElementValue ElementValue() {
               _ElementValueFunc ??= Torque3D.LookupEngineFunction<_ElementValue>("fnSimXMLDocument_elementValue");

                return _ElementValueFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct NextSiblingElement__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _NextSiblingElement(IntPtr _this, NextSiblingElement__Args args);
            private static _NextSiblingElement _NextSiblingElementFunc;
            internal static _NextSiblingElement NextSiblingElement() {
               _NextSiblingElementFunc ??= Torque3D.LookupEngineFunction<_NextSiblingElement>("fnSimXMLDocument_nextSiblingElement");

                return _NextSiblingElementFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushChildElement__Args
            {
                internal int index;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _PushChildElement(IntPtr _this, PushChildElement__Args args);
            private static _PushChildElement _PushChildElementFunc;
            internal static _PushChildElement PushChildElement() {
               _PushChildElementFunc ??= Torque3D.LookupEngineFunction<_PushChildElement>("fnSimXMLDocument_pushChildElement");

                return _PushChildElementFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct PushFirstChildElement__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string name;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _PushFirstChildElement(IntPtr _this, PushFirstChildElement__Args args);
            private static _PushFirstChildElement _PushFirstChildElementFunc;
            internal static _PushFirstChildElement PushFirstChildElement() {
               _PushFirstChildElementFunc ??= Torque3D.LookupEngineFunction<_PushFirstChildElement>("fnSimXMLDocument_pushFirstChildElement");

                return _PushFirstChildElementFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct ClearError__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _ClearError(IntPtr _this, ClearError__Args args);
            private static _ClearError _ClearErrorFunc;
            internal static _ClearError ClearError() {
               _ClearErrorFunc ??= Torque3D.LookupEngineFunction<_ClearError>("fnSimXMLDocument_clearError");

                return _ClearErrorFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct GetErrorDesc__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            
            internal delegate IntPtr _GetErrorDesc(IntPtr _this, GetErrorDesc__Args args);
            private static _GetErrorDesc _GetErrorDescFunc;
            internal static _GetErrorDesc GetErrorDesc() {
               _GetErrorDescFunc ??= Torque3D.LookupEngineFunction<_GetErrorDesc>("fnSimXMLDocument_getErrorDesc");

                return _GetErrorDescFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Clear__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Clear(IntPtr _this, Clear__Args args);
            private static _Clear _ClearFunc;
            internal static _Clear Clear() {
               _ClearFunc ??= Torque3D.LookupEngineFunction<_Clear>("fnSimXMLDocument_clear");

                return _ClearFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Parse__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string xmlString;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Parse(IntPtr _this, Parse__Args args);
            private static _Parse _ParseFunc;
            internal static _Parse Parse() {
               _ParseFunc ??= Torque3D.LookupEngineFunction<_Parse>("fnSimXMLDocument_parse");

                return _ParseFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct SaveFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _SaveFile(IntPtr _this, SaveFile__Args args);
            private static _SaveFile _SaveFileFunc;
            internal static _SaveFile SaveFile() {
               _SaveFileFunc ??= Torque3D.LookupEngineFunction<_SaveFile>("fnSimXMLDocument_saveFile");

                return _SaveFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct LoadFile__Args
            {
                [MarshalAs(UnmanagedType.LPUTF8Str)]
                internal string fileName;
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool _LoadFile(IntPtr _this, LoadFile__Args args);
            private static _LoadFile _LoadFileFunc;
            internal static _LoadFile LoadFile() {
               _LoadFileFunc ??= Torque3D.LookupEngineFunction<_LoadFile>("fnSimXMLDocument_loadFile");

                return _LoadFileFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct Reset__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void _Reset(IntPtr _this, Reset__Args args);
            private static _Reset _ResetFunc;
            internal static _Reset Reset() {
               _ResetFunc ??= Torque3D.LookupEngineFunction<_Reset>("fnSimXMLDocument_reset");

                return _ResetFunc;
            }


            [StructLayout(LayoutKind.Sequential)]
            internal struct StaticGetType__Args
            {
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
            private static _StaticGetType _StaticGetTypeFunc;
            internal static _StaticGetType StaticGetType() {
               _StaticGetTypeFunc ??= Torque3D.LookupEngineFunction<_StaticGetType>("fnSimXMLDocument_staticGetType");

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
               _CreateFunc ??= Torque3D.LookupEngineFunction<_Create>("fnSimXMLDocument_create");

                return _CreateFunc;
            }

        }
        #endregion

        /// <summary>Gets the text from the current Element.</summary>
        /// <description>
        /// Use addData() to add text to the current Element.
        /// 
        /// getData() and getText() may be used interchangeably.  As there is no difference between data and text, you may also use removeText() to clear any data from the current Element.
        /// </description>
        /// <returns>String containing the text in the current Element.</returns>
        /// <code>
        /// // Using the following test.xml file as an example:
        /// // <?xml version="1.0" encoding="utf-8" standalone="yes" ?>
        /// // <NewElement>Some data</NewElement>
        /// 
        /// // Load in the file
        /// %x = new SimXMLDocument();
        /// %x.loadFile("test.xml");
        /// 
        /// // Make the first Element the current one
        /// %x.pushFirstChildElement("NewElement");
        /// 
        /// // Store the current Element's data ('Some data' in this example)
        /// // into 'result'
        /// %result = %x.getData();
        /// echo( %result );
        /// </code>
        /// <see cref="addData()" />
        /// <see cref="addText()" />
        /// <see cref="getText()" />
        /// <see cref="removeText()" />
        public string GetData() {
             InternalUnsafeMethods.GetData__Args _args = new InternalUnsafeMethods.GetData__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetData()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Add the given text as a child of current Element.</summary>
        /// <description>
        /// Use getData() to retrieve any text from the current Element.
        /// 
        /// addData() and addText() may be used interchangeably.  As there is no difference between data and text, you may also use removeText() to clear any data from the current Element.
        /// </description>
        /// <param name="text">String containing the text.</param>
        /// <code>
        /// // Create a new XML document with a header and single element
        /// // with some added data.
        /// %x = new SimXMLDocument();
        /// %x.addHeader();
        /// %x.addNewElement("NewElement");
        /// %x.addData("Some text");
        /// %x.saveFile("test.xml");
        /// 
        /// // Produces the following file:
        /// // <?xml version="1.0" encoding="utf-8" standalone="yes" ?>
        /// // <NewElement>Some text</NewElement>
        /// </code>
        /// <see cref="getData()" />
        /// <see cref="addText()" />
        /// <see cref="getText()" />
        /// <see cref="removeText()" />
        public void AddData(string text) {
             InternalUnsafeMethods.AddData__Args _args = new InternalUnsafeMethods.AddData__Args() {
                text = text,
             };
             InternalUnsafeMethods.AddData()(ObjectPtr, _args);
        }

        /// <summary>Remove any text on the current Element.</summary>
        /// <description>
        /// Use getText() to retrieve any text from the current Element and addText() to add text to the current Element.  As getData() and addData() are equivalent to getText() and addText(), removeText() will also remove any data from the current Element.
        /// </description>
        /// <see cref="addText()" />
        /// <see cref="getText()" />
        /// <see cref="addData()" />
        /// <see cref="getData()" />
        public void RemoveText() {
             InternalUnsafeMethods.RemoveText__Args _args = new InternalUnsafeMethods.RemoveText__Args() {
             };
             InternalUnsafeMethods.RemoveText()(ObjectPtr, _args);
        }

        /// <summary>Gets the text from the current Element.</summary>
        /// <description>
        /// Use addText() to add text to the current Element and removeText() to clear any text.
        /// 
        /// getText() and getData() may be used interchangeably.
        /// </description>
        /// <returns>String containing the text in the current Element.</returns>
        /// <code>
        /// // Using the following test.xml file as an example:
        /// // <?xml version="1.0" encoding="utf-8" standalone="yes" ?>
        /// // <NewElement>Some text</NewElement>
        /// 
        /// // Load in the file
        /// %x = new SimXMLDocument();
        /// %x.loadFile("test.xml");
        /// 
        /// // Make the first Element the current one
        /// %x.pushFirstChildElement("NewElement");
        /// 
        /// // Store the current Element's text ('Some text' in this example)
        /// // into 'result'
        /// %result = %x.getText();
        /// echo( %result );
        /// </code>
        /// <see cref="addText()" />
        /// <see cref="removeText()" />
        /// <see cref="addData()" />
        /// <see cref="getData()" />
        public string GetText() {
             InternalUnsafeMethods.GetText__Args _args = new InternalUnsafeMethods.GetText__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetText()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Add the given text as a child of current Element.</summary>
        /// <description>
        /// Use getText() to retrieve any text from the current Element and removeText() to clear any text.
        /// 
        /// addText() and addData() may be used interchangeably.
        /// </description>
        /// <param name="text">String containing the text.</param>
        /// <code>
        /// // Create a new XML document with a header and single element
        /// // with some added text.
        /// %x = new SimXMLDocument();
        /// %x.addHeader();
        /// %x.addNewElement("NewElement");
        /// %x.addText("Some text");
        /// %x.saveFile("test.xml");
        /// 
        /// // Produces the following file:
        /// // <?xml version="1.0" encoding="utf-8" standalone="yes" ?>
        /// // <NewElement>Some text</NewElement>
        /// </code>
        /// <see cref="getText()" />
        /// <see cref="removeText()" />
        /// <see cref="addData()" />
        /// <see cref="getData()" />
        public void AddText(string text) {
             InternalUnsafeMethods.AddText__Args _args = new InternalUnsafeMethods.AddText__Args() {
                text = text,
             };
             InternalUnsafeMethods.AddText()(ObjectPtr, _args);
        }

        /// <description>
        /// Gives the comment at the specified index, if any.
        /// 
        /// Unlike addComment() that only works at the document level, readComment() may read comments from the document or any child Element.  The current Element (or document if no Elements have been pushed to the stack) is the parent for any comments, and the provided index is the number of comments in to read back.
        /// </description>
        /// <param name="index">Comment index number to query from the current Element stack</param>
        /// <returns>String containing the comment, or an empty string if no comment is found.</returns>
        /// <see cref="addComment()" />
        public string ReadComment(int index) {
             InternalUnsafeMethods.ReadComment__Args _args = new InternalUnsafeMethods.ReadComment__Args() {
                index = index,
             };
             IntPtr _engineResult = InternalUnsafeMethods.ReadComment()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Add the given comment as a child of the document.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="comment">String containing the comment.</param>
        /// <code>
        /// // Create a new XML document with a header, a comment and single element.
        /// %x = new SimXMLDocument();
        /// %x.addHeader();
        /// %x.addComment("This is a test comment");
        /// %x.addNewElement("NewElement");
        /// %x.saveFile("test.xml");
        /// 
        /// // Produces the following file:
        /// // <?xml version="1.0" encoding="utf-8" standalone="yes" ?>
        /// // <!--This is a test comment-->
        /// // <NewElement />
        /// </code>
        /// <see cref="readComment()" />
        public void AddComment(string comment) {
             InternalUnsafeMethods.AddComment__Args _args = new InternalUnsafeMethods.AddComment__Args() {
                comment = comment,
             };
             InternalUnsafeMethods.AddComment()(ObjectPtr, _args);
        }

        /// <summary>Add a XML header to a document.</summary>
        /// <description>
        /// Sometimes called a declaration, you typically add a standard header to the document before adding any elements.  SimXMLDocument always produces the following header:
        /// 
        /// <?xml version="1.0" encoding="utf-8" standalone="yes" ?>
        /// </description>
        /// <code>
        /// // Create a new XML document with just a header and single element.
        /// %x = new SimXMLDocument();
        /// %x.addHeader();
        /// %x.addNewElement("NewElement");
        /// %x.saveFile("test.xml");
        /// 
        /// // Produces the following file:
        /// // <?xml version="1.0" encoding="utf-8" standalone="yes" ?>
        /// // <NewElement />
        /// </code>
        public void AddHeader() {
             InternalUnsafeMethods.AddHeader__Args _args = new InternalUnsafeMethods.AddHeader__Args() {
             };
             InternalUnsafeMethods.AddHeader()(ObjectPtr, _args);
        }

        /// <summary>Create a new element with the given name as child of current Element's parent and push it onto the Element stack making it the current one.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> This differs from pushNewElement() in that it adds the new Element to the current Element's parent (or document if there is no parent Element).  This makes the new Element a sibling of the current one.
        /// 
        /// </remarks>
        /// <param name="name">XML tag for the new Element.</param>
        /// <see cref="pushNewElement()" />
        public void AddNewElement(string name) {
             InternalUnsafeMethods.AddNewElement__Args _args = new InternalUnsafeMethods.AddNewElement__Args() {
                name = name,
             };
             InternalUnsafeMethods.AddNewElement()(ObjectPtr, _args);
        }

        /// <summary>Create a new element with the given name as child of current Element and push it onto the Element stack making it the current one.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> This differs from addNewElement() in that it adds the new Element as a child of the current Element (or a child of the document if no Element exists).
        /// 
        /// </remarks>
        /// <param name="name">XML tag for the new Element.</param>
        /// <see cref="addNewElement()" />
        public void PushNewElement(string name) {
             InternalUnsafeMethods.PushNewElement__Args _args = new InternalUnsafeMethods.PushNewElement__Args() {
                name = name,
             };
             InternalUnsafeMethods.PushNewElement()(ObjectPtr, _args);
        }

        /// <summary>Add the given SimObject's fields as attributes of the current Element on the stack.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="objectID">ID of SimObject being copied.</param>
        public void SetObjectAttributes(string objectID) {
             InternalUnsafeMethods.SetObjectAttributes__Args _args = new InternalUnsafeMethods.SetObjectAttributes__Args() {
                objectID = objectID,
             };
             InternalUnsafeMethods.SetObjectAttributes()(ObjectPtr, _args);
        }

        /// <summary>Set the attribute of the current Element on the stack to the given value.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="attributeName">Name of attribute being changed</param>
        /// <param name="value">New value to assign to the attribute</param>
        public void SetAttribute(string attributeName, string value) {
             InternalUnsafeMethods.SetAttribute__Args _args = new InternalUnsafeMethods.SetAttribute__Args() {
                attributeName = attributeName,
                value = value,
             };
             InternalUnsafeMethods.SetAttribute()(ObjectPtr, _args);
        }

        /// <summary>Get the name of the previous attribute for the current Element after a call to lastAttribute().</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>String containing the previous attribute's name, or an empty string if none is found.</returns>
        /// <see cref="lastAttribute()" />
        /// <see cref="firstAttribute()" />
        /// <see cref="nextAttribute()" />
        public string PrevAttribute() {
             InternalUnsafeMethods.PrevAttribute__Args _args = new InternalUnsafeMethods.PrevAttribute__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.PrevAttribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Get the name of the next attribute for the current Element after a call to firstAttribute().</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>String containing the next attribute's name, or an empty string if none is found.</returns>
        /// <see cref="firstAttribute()" />
        /// <see cref="lastAttribute()" />
        /// <see cref="prevAttribute()" />
        public string NextAttribute() {
             InternalUnsafeMethods.NextAttribute__Args _args = new InternalUnsafeMethods.NextAttribute__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.NextAttribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Obtain the name of the current Element's last attribute.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>String containing the last attribute's name, or an empty string if none is found.</returns>
        /// <see cref="prevAttribute()" />
        /// <see cref="firstAttribute()" />
        /// <see cref="lastAttribute()" />
        public string LastAttribute() {
             InternalUnsafeMethods.LastAttribute__Args _args = new InternalUnsafeMethods.LastAttribute__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.LastAttribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Obtain the name of the current Element's first attribute.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>String containing the first attribute's name, or an empty string if none is found.</returns>
        /// <see cref="nextAttribute()" />
        /// <see cref="lastAttribute()" />
        /// <see cref="prevAttribute()" />
        public string FirstAttribute() {
             InternalUnsafeMethods.FirstAttribute__Args _args = new InternalUnsafeMethods.FirstAttribute__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.FirstAttribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Tests if the requested attribute exists.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="attributeName">Name of attribute being queried for.</param>
        /// <returns>True if the attribute exists.</returns>
        public bool AttributeExists(string attributeName) {
             InternalUnsafeMethods.AttributeExists__Args _args = new InternalUnsafeMethods.AttributeExists__Args() {
                attributeName = attributeName,
             };
             bool _engineResult = InternalUnsafeMethods.AttributeExists()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (string attributeName)
        /// </description>
        /// <summary>Get int attribute from the current Element on the stack.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="attributeName">Name of attribute to retrieve.</param>
        /// <returns>The value of the given attribute in the form of an integer.</returns>
        public int AttributeS32(string attributeName) {
             InternalUnsafeMethods.AttributeS32__Args _args = new InternalUnsafeMethods.AttributeS32__Args() {
                attributeName = attributeName,
             };
             int _engineResult = InternalUnsafeMethods.AttributeS32()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <description>
        /// (string attributeName)
        /// </description>
        /// <summary>Get float attribute from the current Element on the stack.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="attributeName">Name of attribute to retrieve.</param>
        /// <returns>The value of the given attribute in the form of a float.</returns>
        public float AttributeF32(string attributeName) {
             InternalUnsafeMethods.AttributeF32__Args _args = new InternalUnsafeMethods.AttributeF32__Args() {
                attributeName = attributeName,
             };
             float _engineResult = InternalUnsafeMethods.AttributeF32()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Get a string attribute from the current Element on the stack.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="attributeName">Name of attribute to retrieve.</param>
        /// <returns>The attribute string if found.  Otherwise returns an empty string.</returns>
        public string Attribute(string attributeName) {
             InternalUnsafeMethods.Attribute__Args _args = new InternalUnsafeMethods.Attribute__Args() {
                attributeName = attributeName,
             };
             IntPtr _engineResult = InternalUnsafeMethods.Attribute()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Pop the last Element off the stack.</summary>
        /// <description>
        /// 
        /// </description>
        public void PopElement() {
             InternalUnsafeMethods.PopElement__Args _args = new InternalUnsafeMethods.PopElement__Args() {
             };
             InternalUnsafeMethods.PopElement()(ObjectPtr, _args);
        }

        /// <summary>Get the Element's value if it exists.</summary>
        /// <description>
        /// Usually returns the text from the Element.
        /// </description>
        /// <returns>The value from the Element, or an empty string if none is found.</returns>
        public string ElementValue() {
             InternalUnsafeMethods.ElementValue__Args _args = new InternalUnsafeMethods.ElementValue__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.ElementValue()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Put the next sibling Element with the given name on the stack, making it the current one.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="name">String containing name of the next sibling.</param>
        /// <returns>True if the Element was found and made the current one.</returns>
        public bool NextSiblingElement(string name) {
             InternalUnsafeMethods.NextSiblingElement__Args _args = new InternalUnsafeMethods.NextSiblingElement__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.NextSiblingElement()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Push the child Element at the given index onto the stack, making it the current one.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="index">Numerical index of Element being pushed.</param>
        /// <returns>True if the Element was found and made the current one.</returns>
        public bool PushChildElement(int index) {
             InternalUnsafeMethods.PushChildElement__Args _args = new InternalUnsafeMethods.PushChildElement__Args() {
                index = index,
             };
             bool _engineResult = InternalUnsafeMethods.PushChildElement()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Push the first child Element with the given name onto the stack, making it the current Element.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="name">String containing name of the child Element.</param>
        /// <returns>True if the Element was found and made the current one.</returns>
        /// <code>
        /// // Using the following test.xml file as an example:
        /// // <?xml version="1.0" encoding="utf-8" standalone="yes" ?>
        /// // <NewElement>Some text</NewElement>
        /// 
        /// // Load in the file
        /// %x = new SimXMLDocument();
        /// %x.loadFile("test.xml");
        /// 
        /// // Make the first Element the current one
        /// %x.pushFirstChildElement("NewElement");
        /// 
        /// // Store the current Element's text ('Some text' in this example)
        /// // into 'result'
        /// %result = %x.getText();
        /// echo( %result );
        /// </code>
        public bool PushFirstChildElement(string name) {
             InternalUnsafeMethods.PushFirstChildElement__Args _args = new InternalUnsafeMethods.PushFirstChildElement__Args() {
                name = name,
             };
             bool _engineResult = InternalUnsafeMethods.PushFirstChildElement()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Clear the last error description.</summary>
        /// <description>
        /// 
        /// </description>
        public void ClearError() {
             InternalUnsafeMethods.ClearError__Args _args = new InternalUnsafeMethods.ClearError__Args() {
             };
             InternalUnsafeMethods.ClearError()(ObjectPtr, _args);
        }

        /// <summary>Get last error description.</summary>
        /// <description>
        /// 
        /// </description>
        /// <returns>A string of the last error message.</returns>
        public string GetErrorDesc() {
             InternalUnsafeMethods.GetErrorDesc__Args _args = new InternalUnsafeMethods.GetErrorDesc__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.GetErrorDesc()(ObjectPtr, _args);
             return StringMarshal.IntPtrToUtf8String(_engineResult);
        }

        /// <summary>Set this document to its default state.</summary>
        /// <description>
        /// Clears all Elements from the documents.  Equivalent to using reset()
        /// </description>
        /// <see cref="reset()" />
        public void Clear() {
             InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
             };
             InternalUnsafeMethods.Clear()(ObjectPtr, _args);
        }

        /// <summary>Create a document from a XML string.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> Clears the current document's contents.
        /// 
        /// </remarks>
        /// <param name="xmlString">Valid XML to parse and store as a document.</param>
        public void Parse(string xmlString) {
             InternalUnsafeMethods.Parse__Args _args = new InternalUnsafeMethods.Parse__Args() {
                xmlString = xmlString,
             };
             InternalUnsafeMethods.Parse()(ObjectPtr, _args);
        }

        /// <summary>Save document to the given file name.</summary>
        /// <description>
        /// 
        /// </description>
        /// <param name="fileName">Path and name of XML file to save to.</param>
        /// <returns>True if the file was successfully saved.</returns>
        public bool SaveFile(string fileName) {
             InternalUnsafeMethods.SaveFile__Args _args = new InternalUnsafeMethods.SaveFile__Args() {
                fileName = fileName,
             };
             bool _engineResult = InternalUnsafeMethods.SaveFile()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Load in given filename and prepare it for use.</summary>
        /// <description>
        /// 
        /// </description>
        /// <remarks> Clears the current document's contents.
        /// 
        /// </remarks>
        /// <param name="fileName">Name and path of XML document</param>
        /// <returns>True if the file was loaded successfully.</returns>
        public bool LoadFile(string fileName) {
             InternalUnsafeMethods.LoadFile__Args _args = new InternalUnsafeMethods.LoadFile__Args() {
                fileName = fileName,
             };
             bool _engineResult = InternalUnsafeMethods.LoadFile()(ObjectPtr, _args);
             return _engineResult;
        }

        /// <summary>Set this document to its default state.</summary>
        /// <description>
        /// Clears all Elements from the documents.  Equivalent to using clear()
        /// </description>
        /// <see cref="clear()" />
        public void Reset() {
             InternalUnsafeMethods.Reset__Args _args = new InternalUnsafeMethods.Reset__Args() {
             };
             InternalUnsafeMethods.Reset()(ObjectPtr, _args);
        }

        /// <description>
        /// Get the type info object for the SimXMLDocument class.
        /// </description>
        /// <returns>The type info object for SimXMLDocument</returns>
        public static EngineTypeInfo StaticGetType() {
             InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
             };
             IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);
             return new EngineTypeInfo(_engineResult);
        }
    }
}
