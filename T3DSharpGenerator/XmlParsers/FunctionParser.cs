using System.Xml;
using T3DSharpFramework.Interop;
using T3DSharpGenerator.Model;

namespace T3DSharpGenerator.XmlParsers
{
    internal class FunctionParser : IApiXmlParser
    {
        public bool Parses(XmlElement element) {
            return element.Name.Equals("EngineFunction");
        }

        public ParseState Parse(XmlElement element, ParseState parseState) {
            string name = element.Attributes["name"].InnerText;
            string docs = element.Attributes["docs"].InnerText;
            string returnType = element.Attributes["returnType"].InnerText;
            string symbol = element.Attributes["symbol"].InnerText;
            bool isCallback = GenericMarshal.StringToBool(element.Attributes["isCallback"].InnerText);
            bool isVariadic = GenericMarshal.StringToBool(element.Attributes["isVariadic"].InnerText);
            
            EngineFunction engineFunction = new EngineFunction() {
                Name = name,
                Docs = docs,
                ReturnType = returnType,
                Symbol = symbol,
                IsCallback = isCallback,
                IsVariadic = isVariadic,
                Scope = parseState.Scope
            };

            foreach (XmlElement childNode in element.ChildNodes[0].ChildNodes) {
                engineFunction.Add(new EngineFunction.Argument() {
                    Name = childNode.Attributes["name"].InnerText,
                    Type = childNode.Attributes["type"].InnerText,
                    DefaultValue = childNode.Attributes["defaultValue"]?.InnerText
                });
            }
            parseState.Functions.Add(engineFunction);
            
            return parseState;
        }
    }
}