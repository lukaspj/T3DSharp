using System.Xml;

namespace T3DSharpGenerator.XmlParsers
{
    internal class EnumParser : IApiXmlParser
    {
        public bool Parses(XmlElement element) {
            return element.Name.Equals("EngineEnumType");
        }

        public void Parse(XmlElement element, ParseState parseState) {
            string name = element.Attributes["name"].InnerText;
            string docs = element.Attributes["docs"].InnerText;
            
            foreach (XmlElement childNode in element.ChildNodes[0].ChildNodes) {
                EngineApiParser.ParseElement(childNode, parseState.AddScope(element.Attributes["name"].InnerText));
            }
        }
    }
}