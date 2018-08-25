using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class FindDivisors
    {
        public static int Divisors(int n)
        {
            int divisorCount = 0;
            if (n == 0)
            {
                return 0;
            }
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisorCount++;
                }

            }
            return divisorCount;
        }
    }
}
