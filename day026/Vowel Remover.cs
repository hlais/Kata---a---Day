using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class Vowel_Remover
    {
        public static string Disemvowel(string str)
        {
            
            var vowels = new string[] { "a", "e", "i", "o", "u",
                                           "A", "E", "I", "O", "U"};
            foreach (var letter in vowels)
            {
                str = str.Replace(letter, string.Empty);
            }

            return str;
        }
    }
}
