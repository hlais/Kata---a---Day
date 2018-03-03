using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class ReplaceAlphapetPostions
    {
        public static string AlphabetPosition(string text)
        {
            string numberText = "";
            foreach (var chars in text.Replace(" ", ""))
            {
               int value = char.ToUpper(chars) - 64;

                if (value <= 26 && value > 0)
                {
                    numberText += value.ToString() + " ";
                }
                else 
                {
                    continue;
                }

            }
            return numberText.Trim();
        }
    }
}