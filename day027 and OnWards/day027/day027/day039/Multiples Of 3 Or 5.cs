using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Multiples_Of_3_Or_5
    {
        public static int Solution(int value)
        {
            int adusted = value - 1;
            List<int> storedNumbers = new List<int>();
            List<int> divisibleNumbers = new List<int>();

            while (adusted > 0)
            {
                storedNumbers.Add(adusted--);
            }
            foreach (var item in storedNumbers)
            {
                if (item % 3 == 0)
                {
                    divisibleNumbers.Add(item);
                }
                if (item % 5 == 0)
                {
                    divisibleNumbers.Add(item);
                }
            }
            int total = divisibleNumbers.Distinct().Sum();
            return total;
        }
    } 
}
