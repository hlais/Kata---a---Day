using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Welcome
    {
        private static Dictionary<string, string> texts = new Dictionary<string, string>()
    {
      {"english", "Welcome"},
      {"czech", "Vitejte"},
      {"danish", "Velkomst"},
      {"dutch", "Welkom"},
      {"estonian", "Tere tulemast"},
      {"finnish", "Tervetuloa"},
      {"flemish", "Welgekomen"},
      {"french", "Bienvenue"},
      {"german", "Willkommen"},
      {"irish", "Failte"},
      {"italian", "Benvenuto"},
      {"latvian", "Gaidits"},
      {"lithuanian", "Laukiamas"},
      {"polish", "Witamy"},
      {"spanish", "Bienvenido"},
      {"swedish", "Valkommen"},
      {"welsh", "Croeso"}
    };
        public static string Greet(string language)
        {
            string greetting = "";
            if (texts.ContainsKey(language))
            {
                greetting = texts[language];

            }
            else
            {
                greetting = "Welcome";
            }
            return greetting;
            
            
        }


    }
}
