using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class TrailingZerosOfN
    {
        public static int TrailingZeros(int n)
        {

            int timesZero = 0;

            while (n >= 5)
            {
                timesZero += n / 5;
                n = n / 5;
            }
            return timesZero;
        }
    }
}
