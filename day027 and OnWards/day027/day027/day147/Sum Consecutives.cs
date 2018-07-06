using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Sum_Consecutives
    {
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> results = new List<int>();

            int consecutiveSum = 0;

            for (int i = 0; i < s.Count; i++)
            {

                consecutiveSum += s[i];

                if (s[i]== s[s.Count-1]|| s[i] != s[i + 1])
                {
                    results.Add(consecutiveSum);
                    consecutiveSum = 0;
                }

            }
            return results;
        }
    }
}
