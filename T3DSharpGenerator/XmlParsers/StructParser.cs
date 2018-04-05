using System.Xml;

namespace T3DSharpGenerator.XmlParsers
{
    internal class StructParser : IApiXmlParser
    {
        public bool Parses(XmlElement element) {
            return element.Name.Equals("EngineStructType");
        }

        public void Parse(XmlElement element, ParseState parseState) {
        }
    }
}