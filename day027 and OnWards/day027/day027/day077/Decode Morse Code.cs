using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Decode_Morse_Code
    {
        public static string Decode(string morseCode)
        {

            string empty = "";
            Dictionary<string, String> morseCodeDictionary = new Dictionary<string, String>()
            {
                {"SOS", "...---..." }, { "!", "-.-.--"}, {".", ".-.-.-"} ,{"a" , ".-"},{"b" , "-..."},{"c" , "-.-."}, //alpha
                {"d" , "-.."},{"e" , "."},{"f" , "..-."},
                {"g" , "--."},{"h" , "...."},{"i" , ".."},
                {"j" , ".---"},{"k" , "-.-"},{"l" , ".-.."},
                {"m" , "--"},{"n" , "-."},{"o" , "---"},
                {"p" , ".--."},{"q" , "--.-"},{"r" , ".-."},
                {"s" , "..."},{"t" , "-"},{"u" , "..-"},
                {"v" , "...-"},{"w" , ".--"},{"x" , "-..-"},
                {"y" , "-.--"},{"z" , "--.."},
                //Numbers 
                {"0" , "-----"},{"1" , ".----"},{"2" , "..----"},{"3" , "...--"},
                {"4" , "....-"},{"5" , "....."},{"6" , "-...."},{"7" , "--..."},
                {"8" , "---.."},{"9" , "----."}
            };

            string[] morseWords = morseCode.Split();
            int counter = 1;
            foreach (var item in morseWords)
            {
                if (item == "")
                {
                    counter++;
                    if (counter % 2 == 0)
                    {
                        empty += " ";

                    }

                }

                if (morseCodeDictionary.ContainsValue(item))
                {
                    var myKey = morseCodeDictionary.FirstOrDefault(x => x.Value == item).Key;
                    empty += myKey;
                }
            }
        
            return empty.Trim().ToUpper().TrimEnd();
        }
    }
    
}