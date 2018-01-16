using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Double_Char
    {
        public static string CharDouble(string sentence)
        {
            string doubleCharSentence = "";
            char[] letters = sentence.ToCharArray();

            foreach (var item in letters)
            {
                doubleCharSentence += item.ToString() + item.ToString();

            }

            return doubleCharSentence;

        }
    }
}
       