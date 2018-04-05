using System.Xml;

namespace T3DSharpGenerator.XmlParsers
{
    internal interface IApiXmlParser
    {
        bool Parses(XmlElement element);
        void Parse(XmlElement element, ParseState parseState);
    }
}