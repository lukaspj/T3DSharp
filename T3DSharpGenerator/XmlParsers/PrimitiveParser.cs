using System.Xml;

namespace T3DSharpGenerator.XmlParsers
{
    internal class PrimitiveParser : IApiXmlParser
    {
        public bool Parses(XmlElement element) {
            return element.Name.Equals("EnginePrimitiveType");
        }

        public ParseState Parse(XmlElement element, ParseState parseState) {
            return parseState;
        }
    }
}