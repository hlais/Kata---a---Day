using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Numerics;

namespace CodeWars5Kata
{
    class Squares_in_a_Rectangle
    {
        public static BigInteger perimeter(BigInteger n)
        {
            n = n + 1;

            int a = 0;
            int b = 1;
            int sum = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n-1 ; ++i)
            {
                int temp = a;
                a = b;
                b = temp + b;
                sum += b;
            }
            return sum * 4;
        }

    }
}
