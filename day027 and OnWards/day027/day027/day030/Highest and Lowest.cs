using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class Highest_and_Lowest
    {
        public static string HighAndLow(string numbers)
        {

            string[] numbersSplit = numbers.Split();

            int converted = numbersSplit.Select(int32);
            int largest = converted.Max();
            int smallest = converted.Min();

            return largest + " " + smallest;



        }
    }
}
