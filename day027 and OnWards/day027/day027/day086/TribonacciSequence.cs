using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class TribonacciSequence
    {
        public static double[] Tribonacci(double[] signature, int n)
        {

            // if n==0, then return an empty array
            if (n == 0)
            {
                return new double[] { 0 };
            }

           
            double[] result = new double[n];

            // special cases
            if (n < signature.Length)
            {

                for (int i = 0; i < n; i++)
                {
                    result[i] = signature[i];
                }

                return result;
            }
            //end special cases

            // In N steps compute Fibonacci sequence iteratively.

            List<double> tribonacciList = new List<double>(signature);

            for (int i = 0; i < n - 1; i++)
            {

                double temp = 0;
                temp = tribonacciList[i] + tribonacciList[i + 1] + tribonacciList[i + 2];
                tribonacciList.Add(temp);
               
            }

          return tribonacciList.GetRange(0, n).ToArray();
     
        }
    }
}
