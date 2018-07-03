using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class MexicanWave
    {
        public static List<string> wave(string str)
        {
           
            List<string> listOfWaves = new List<string>();
            

            for (int i = 0; i < str.Length; i++)
            {
                char []strToChars = str.ToLower().ToCharArray();

                if (char.IsLetter(strToChars[i]))
                {

                   strToChars[i] = char.ToUpper(strToChars[i]);
                    listOfWaves.Add(new string(strToChars));

                }
                else
                    continue;
            }
            return listOfWaves;

        }
    }
}
