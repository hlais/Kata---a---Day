using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWards7Kata
{
    class SumOfNumbers
    {
        public static int GetSum(int a, int b)
        {
            int[] numbers = { a, b };
            int sum = 0;
           int start = numbers.Min();
            int fin = numbers.Max();

            for (; start <= fin; start++)
            {
                sum += start;
            }

            return sum;

        }
    }
}
