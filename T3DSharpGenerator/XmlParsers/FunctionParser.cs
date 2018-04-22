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
            
            EngineFunction engineFunction = new EngineFunction(name) {
                Docs = docs,
                ReturnTypeName = returnType,
                Symbol = symbol,
                IsCallback = isCallback,
                IsVariadic = isVariadic,
                Scope = parseState.Scope
            };

            foreach (XmlElement childNode in element.ChildNodes[0].ChildNodes) {
                engineFunction.Add(new EngineFunction.Argument() {
                    Name = childNode.Attributes["name"].InnerText,
                    TypeName = childNode.Attributes["type"].InnerText,
                    DefaultValue = childNode.Attributes["defaultValue"]?.InnerText
                });
            }
            // TODO special-handling of argc, argv parameters to mark them as variadic. This is an assumption.
            if (engineFunction.Arguments.Count == 2
                && engineFunction.Arguments[0].Name.Equals("argc")
                && engineFunction.Arguments[1].Name.Equals("argv")) {
                engineFunction.IsVariadic = true;
            }
            
            parseState.Functions.Add(engineFunction);
            
            return parseState;
        }
    }
}