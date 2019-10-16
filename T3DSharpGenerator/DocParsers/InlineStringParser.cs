using T3DSharpGenerator.Model.Docs;

namespace T3DSharpGenerator.DocParsers {
   public class InlineStringParser : IDocStringParser {
      public bool MatchesTag(DocTag tag) {
         return tag.Tag.Trim().Equals("@");
      }
      
      public IDocElement Parse(DocTag tag) {
         return new TextDocElement {
            Text = tag.Tag + tag.Text
         };
      }
   }
}