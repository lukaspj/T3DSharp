using System;
using System.Xml;

namespace T3DSharpGenerator.XmlParsers
{
    internal class ScopeParser : IApiXmlParser
    {
        public bool Parses(XmlElement element) {
            return element.Name.Equals("EngineExportScope");
        }

        public void Parse(XmlElement element, ParseState parseState) {
            Console.WriteLine("Parsing scope with: " + element.Attributes["name"].InnerText,
                ", " + element.Attributes["docs"].InnerText);
            foreach (XmlElement childNode in element.ChildNodes[0].ChildNodes) {
                EngineApiParser.ParseElement(childNode, parseState.AddScope(element.Attributes["name"].InnerText));
            }
        }
    }
}