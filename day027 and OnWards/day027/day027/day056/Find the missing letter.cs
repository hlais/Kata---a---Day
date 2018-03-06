using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Find_the_missing_letter
    {
        public static char FindMissingLetter(char[] array)
        {
            List<int> charNumber = new List<int>();
            int missingCharIndex = 0;
            foreach (var chars in array)
            {
             
              int value =  (int)chars;
              charNumber.Add(value);

            }



            for (int i = 0; i < charNumber.Count; i++)
            {
                int j = i + 1;
                try
                {
                    if (charNumber[j] - charNumber[i] != 1)
                    {
                        missingCharIndex = charNumber[i];
                        break;
                    }
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
            missingCharIndex =  missingCharIndex + 1;
            char key = (char)(missingCharIndex);

            return key;

        }

    }
}