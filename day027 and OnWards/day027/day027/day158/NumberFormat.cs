using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class NumberFormat
    {
        public static string numberFormat(int number)
        {
            string stringNumber = number.ToString("N0");
            return stringNumber;
        }
    }
}
