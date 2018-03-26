using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars4Kata
{
    class Middle_Permutation
    {
        public static string MiddlePermutation(string s)
        {
            List<char> sChar = new List<char>(s);
            string middleChar = "";
            string remainderChars = "";
            string empty = "";
         
            if (s.Length % 2 == 0)
            {
                empty = WorkingWithEven(s);

            }
            else
            {
                //find middle element and removing it
                int element = (s.Length / 2) ;
                sChar.Sort();
                middleChar = sChar[element].ToString();
                sChar.Remove(sChar[element]);

                remainderChars = new string(sChar.ToArray());
                //no s is Even with can call workingWithEven Method
                empty = middleChar + WorkingWithEven(remainderChars);

            }
            return empty;

        }
        private static string WorkingWithEven(string s)
        {
            List<char> sChar = new List<char>(s);
            sChar.Sort();
            string middle = "";
            string remainder = "";
            //find middle element and removing it
            int element = (s.Length / 2) - 1;
            middle = sChar[element].ToString();
            sChar.Remove(sChar[element]);
          
            sChar.Reverse();
            remainder = new string(sChar.ToArray());

            return middle += remainder;
        }
    }
}
