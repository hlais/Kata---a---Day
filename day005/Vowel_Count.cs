using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    class Vowel_Count
    {
        public static int GetVowelCount(string str)
        {
            nt vowelCount = 0;
            char[] charInString = str.ToCharArray();
            foreach (var item in charInString)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                {
                    vowelCount++;
                }


            }
            return vowelCount;

        }

    }
}
