using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Does_my_number_look_big_in_this
    {
        public static bool Narcissistic(int value)
        {
            int storedTotal = 0;
            int length = value.ToString().Length;
            string stringNumberCollection = value.ToString();

            foreach (var number in stringNumberCollection)
            {
                int temp = (int)Math.Pow((int)char.GetNumericValue(number), Convert.ToInt32(length));
                storedTotal += temp;
            }

            if (storedTotal == value)
            {
                return true;
            }
            else return false;
        }
    }
}

//For example, take 153 (3 digits):

//    1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
//and 1634 (4 digits):

//    1^4 + 6^4 + 3^4 + 4^4 = 1 + 1296 + 81 + 256 = 1634
