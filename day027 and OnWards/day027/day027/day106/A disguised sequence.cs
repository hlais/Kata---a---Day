using System;
using System.Numerics;



namespace CodeWars6Kata
{
    class A_disguised_sequence
    {
        public static BigInteger fcn(int n)
        {
            BigInteger result;

            result = (BigInteger)Math.Pow(2, n);
            return result;

        }
    }
}
