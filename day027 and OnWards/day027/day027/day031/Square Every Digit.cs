using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class Square_Every_Digit
    {
        public static int SquareDigits(int n)
        {
            string numbers = n.ToString();
            char[] charDigits = numbers.ToCharArray();

            string empty = "";

            foreach (var item in charDigits)
            {
                int temp =  (int)Char.GetNumericValue(item);
                int square = temp * temp;

                empty += square.ToString();
            }

           return Convert.ToInt32(empty);

        }
    }
}
