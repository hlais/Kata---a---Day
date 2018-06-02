using System;

namespace CodeWars6Kata
{
    class CountZeros
    {
        public static ulong CountZeroes(long n)
        {

           ulong limit= (9 *((ulong)n-1)-1) *(ulong)Math.Pow(10, n-1) +1;
            return limit/9;
        }
    }
}
