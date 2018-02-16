using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Binary_Addition
    {
        public static string AddBinary(int a, int b)
        {
            int sum = a + b;
            string binary = Convert.ToString(sum, 2);

            return binary;
        }
    }
}
