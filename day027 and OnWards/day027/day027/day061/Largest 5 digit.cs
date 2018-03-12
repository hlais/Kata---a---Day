using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Largest_5_digit
    {
        public static int GetNumber(string str)
        {
            int element1 = 0;
            int element2 = 0;
            int element3 = 0;
            int element4 = 0;
            int element5 = 0;
            int theHighestNumber = 0;

            char[] strChar = str.ToCharArray();
            for (int i = 0; i < strChar.Length-4; i++)
            {
                element1 = (int)char.GetNumericValue(strChar[i]);
                element2 = (int)char.GetNumericValue(strChar[i + 1]);
                element3 = (int)char.GetNumericValue(strChar[i + 2]);
                element4 = (int)char.GetNumericValue(strChar[i + 3]);
                element5 = (int)char.GetNumericValue(strChar[i + 4]);
                string stringNumbers = string.Format("{0}{1}{2}{3}{4}", element1.ToString(), element2, element3, element4, element5);

                int current = int.Parse(stringNumbers);

                if (current > theHighestNumber)
                {
                    theHighestNumber = current;
                     
                }
            }
          
            return theHighestNumber;
        }

    }
}
