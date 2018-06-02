using System;
using System.Linq;

namespace CodeWards7Kata
{
    class StringCalculator
    {
        public static int AddStrings(string numbers)
        {

           return numbers.Split(',').Select(x => Convert.ToInt32(x)).Sum();
        }
    }
}
