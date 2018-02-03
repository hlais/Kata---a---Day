using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Get_the_Middle_Character
    {
        public static string GetMiddle(string s)
        {
            int lenghOfString = s.Length;

            string middle = "";
            if (lenghOfString % 2 == 0)
            {

              int newMiddle = (lenghOfString / 2) - 1;
                middle = s.Substring(newMiddle,2);
            }
            if (lenghOfString % 2 != 0)
            {
               middle = s.Substring(lenghOfString / 2,1);
            }
            return middle;
  
        }
    }
}
