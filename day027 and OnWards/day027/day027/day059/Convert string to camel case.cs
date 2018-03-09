using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Convert_string_to_camel_case
    {
        public static string ToCamelCase(string str)
        {
            string _toCamelCase = "";
           
            if (str.Contains("_") || str.Contains("-"))
            {
                string removedPunc = str.Replace("_", " ");
                string removedPunc2 = removedPunc.Replace("-", " ");
                string[] wordCollection = removedPunc2.Split(' ');
                _toCamelCase = CamelCase(wordCollection).Trim();
            }
            return _toCamelCase;
        }
        public static string CamelCase(string[] wordCollection)
        {
            string empty = "";
            for (int word = 0; word < wordCollection.Length; word++)
            {
                if (word == 0)
                {
                    empty += wordCollection[word].ToString();
                    continue;
                }
                else
                {
                    char[] chars = wordCollection[word].ToCharArray();
                    for (int letter = 0; letter < wordCollection[word].Length; letter++)
                    {
                        if (letter == 0)
                        {
                            empty = empty + char.ToUpper(chars[letter]);
                        }
                        else
                        {
                            empty += char.ToLower(chars[letter]);
                        }
                    }
                }
            }
            return empty;
        }
    }
}
