using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Odd_Or_Even
    {
        public static string OddOrEven(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            if (sum % 2 == 0)
            {
                return "even";
            }
            else
                return "odd";
        }
    }
}
