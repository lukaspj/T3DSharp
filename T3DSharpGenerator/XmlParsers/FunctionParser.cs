using System.Xml;

namespace T3DSharpGenerator.XmlParsers
{
    internal class FunctionParser : IApiXmlParser
    {
        public bool Parses(XmlElement element) {
            return element.Name.Equals("EngineFunction");
        }

        public void Parse(XmlElement element, ParseState parseState) {
        }
    }
}