using System;
using System.Numerics;


namespace CodeWars6Kata
{
    class ComparePowers
    {
        public static int comparePowers(int[] a, int[] b)
        {
         
            BigInteger groupAPowers = (BigInteger)Math.Pow(a[0], a[1]);
            BigInteger groupBPowers = (BigInteger)Math.Pow(b[0], b[1]);

            if (groupAPowers == groupBPowers)
            {
                return 0;
            }
            return groupAPowers > groupBPowers ? -1 : 1;
        }
    }
}
