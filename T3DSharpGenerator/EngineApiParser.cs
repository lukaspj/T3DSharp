using System.Collections.Generic;
using System.Linq;
using System.Xml;
using T3DSharpGenerator.XmlParsers;

namespace T3DSharpGenerator
{
    internal class ParseState
    {
        public string Scope { get; private set; }

        public ParseState AddScope(string scope) {
            if (string.IsNullOrEmpty(Scope)) {
                Scope = scope;
            } else if (!string.IsNullOrEmpty(scope)) {
                Scope += "." + scope;
            }

            return this;
        }
    }
    
    internal static class EngineApiParser
    {
        private static readonly List<IApiXmlParser> Parsers = new List<IApiXmlParser>() {
            new ScopeParser(),
            new ClassParser(),
            new EnumParser(),
            new StructParser(),
            new PrimitiveParser(),
            new FunctionParser(),
            new BitfieldParser()
        };

        public static void Parse(string content) {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);

            if (doc.DocumentElement == null) return;

            ParseElement(doc.DocumentElement, new ParseState());

            XmlNodeList elements = doc.ChildNodes;
            if (elements.Count == 1) {
                elements = elements[0].ChildNodes;
            }
        }

        public static void ParseElement(XmlElement element, ParseState parseState) {
            Parsers.FindAll(x => x.Parses(element))
                .DefaultIfEmpty(new NotHandledParser())
                .Single()
                .Parse(element, parseState);
        }
    }
}