using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class SomeOfOddNumbers
    {
        public static long rowSumOddNumbers(long n)
        {
            long start = ((n * n) - n) + 1;
            int counter = 1;
            long sumOfOdd = start;

            while (counter < n)
            {
                long incre =  start += 2;
                sumOfOdd += incre;
                counter++;
            }

            return sumOfOdd;
        }
    }
}
