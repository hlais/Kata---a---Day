using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class HighestScoringWord
    {
        public static string High(string s)
        {
            string[] words = s.Split(' ');
            string highestString = "";
            int previousWordCount = 0;
            

            for (int i = 0; i < words.Length; i++)
            {
                int currentTotalWordChar = 0;
                foreach (var chars in words[i])
                {
                    int temp = char.ToUpper(chars) - 64;
                    currentTotalWordChar += temp;
                }
                int tempvalue = currentTotalWordChar;

                if (tempvalue > previousWordCount)
                {
                   previousWordCount = tempvalue;
                   highestString= words[i];
                  
                }
                tempvalue = 0;
            }


            return highestString;
       
        }
    }
}
