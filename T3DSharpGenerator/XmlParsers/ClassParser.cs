using System.Xml;

namespace T3DSharpGenerator.XmlParsers
{
    internal class ClassParser : IApiXmlParser
    {
        public bool Parses(XmlElement element) {
            return element.Name.Equals("EngineClassType");
        }

        public void Parse(XmlElement element, ParseState parseState) {
        }
    }
}