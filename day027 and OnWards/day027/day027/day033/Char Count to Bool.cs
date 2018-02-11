using System;
using System.Collections.Generic;

using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class Char_Count_to_Bool
    {
        public static bool XO(string input)
        {
            List<char> arr = new List<char>(input.ToString().ToLower().ToCharArray());

            int x = arr.Count(f => f == 'x');
            int y = arr.Count(f => f == 'o');

            if (x == y)
            {
                return true;
            }
            else return
                false;
          
            




        }
    }
}