using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class FibonacciAndFriends
    {
        public static double[] xbonacci(double[] signature, int n)
        {

            double[] fibonacciElements = new double[n];

            for (int i = 0; i < n; i++)
            {
                if (i < signature.Length)
                {
                    fibonacciElements[i] = signature[i];
                }
                else
                {
                    for (int j  = 1 ; j <= signature.Length; j ++)
                    {
                        fibonacciElements[i] += fibonacciElements[i - j];
                    }
                }

            }
            return fibonacciElements;
        }
    }
}
