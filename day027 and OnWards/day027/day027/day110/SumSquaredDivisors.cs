using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class SumSquaredDivisors
    {
        public static string listSquared(long m, long n)
        {
            var result = new List<string>();
            for (var i = m; i <= n; i++)
            {
                var sumOfSquaredDivs = Divisors(i).Select(d => d * d).Sum();
                if (IsSquared(sumOfSquaredDivs))
                {
                    result.Add($"[{i}, {sumOfSquaredDivs}]");
                }
            }
            return "[" + String.Join(", ", result) + "]";
        }

        private static List <int> Divisors(long input)
        {
            List<int> divs = new List<int>();

            for (int i= 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    divs.Add(i);
                }
            }
            return divs;
        }

        private static bool IsSquared(long number)
        {
            return Math.Sqrt(number) % 1 == 0;
        }
    }
}
