namespace T3DSharpGenerator.XmlParsers;

public static class ValueParser {
   public static bool ParseBool(string str) {
      switch (str) {
         case "1":
            return true;
         case "0":
            return false;
         case "":
            return false;
         default:
            return bool.Parse(str);
      }
   }
}
