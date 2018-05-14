using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Find_the_divisors
    {
        public static int[] Divisors(int n)
        {

            List<int> factors = new List<int>();
            int max = (int)Math.Sqrt(n);
            for (int factor = 1; factor <= max; factor++)
            {
                if (n % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != n / factor)
                    {
                        factors.Add(n / factor);
                    }
                }
            }
            factors.Remove(1);
            factors.Remove(n);
            if (factors.Count == 0)
            {
                return null;
            }
            
            factors.Sort();
            return factors.ToArray();
        }
    }
}

