using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Format_words_into_a_sentence
    {
        public static string FormatWords(string[]words)
        {
            if (words == null)
            {
                return "";
            }
            //remove all empty strings 
            words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int lastWord = words.Length - 1;
            string empty = "";

            //single word 
            if (words.Length - 1 == 0)
            {
                return empty += words[0];
            
            }
            
            //more than single word
            for (int i = 0; i < words.Length; i++)
            {
                if (i == lastWord)
                {
                    empty += " and " + words[i];
                    continue;
                }
                if (i == lastWord - 1)
                {
                    empty += words[i];
                    continue;
                }
               empty += words[i]+", ";
            }
            return empty;
        }
    }
}
