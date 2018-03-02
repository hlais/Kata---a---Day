using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Persistent_Bugger
    {
        public static int Persistence(int n)
        {
            int loops = 0;
            while (NumberofDigits(n) > 1)
            {
               n=  Calculate(n);
                loops++;

            }

            return loops;

        }
        private static int NumberofDigits(int n)
        {
            int length = n.ToString().Length;
            return length;
        }
        private static int Calculate(int n)
        {
            int ans = 1;
            string stringNumbers = n.ToString();

            foreach (var ch in stringNumbers)
            {
                ans = ans * (int)char.GetNumericValue(ch);
            }

            return ans;
        }
    }
}
