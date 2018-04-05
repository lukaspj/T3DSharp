using System.Xml;

namespace T3DSharpGenerator.XmlParsers
{
    internal class BitfieldParser : IApiXmlParser
    {
        public bool Parses(XmlElement element) {
            return element.Name.Equals("EngineBitfieldType");
        }

        public void Parse(XmlElement element, ParseState parseState) {
        }
    }
}