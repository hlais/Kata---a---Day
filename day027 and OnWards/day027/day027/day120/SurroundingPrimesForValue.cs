using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class SurroundingPrimesForValue
    {
        public static long[] PrimeBefAft(long num)
        {
            long[] primeBeforeNumberPrimeAfterNumber = new long[2];
            long numAfter = num + 1;
            long numBefore = num - 1;
            while (!isNumberPrime(numAfter))
            {
                numAfter++;
            }

            while (!isNumberPrime(numBefore))
            {
                numBefore--;
            }
            primeBeforeNumberPrimeAfterNumber[0] = numBefore;
            primeBeforeNumberPrimeAfterNumber[1] = numAfter;

            return primeBeforeNumberPrimeAfterNumber;

        }
        private static bool isNumberPrime(long number)
        {
           

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
