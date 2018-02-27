using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Counting_Duplicates
    {
        public static int DuplicateCount(string str)
        {
            int count = 0;
            string lowerStr = str.ToLower();
            
            foreach (var item in lowerStr.ToLower().Where(n => lowerStr.Count(n2 => n2 == n) > 1).Distinct())
            {
                
                count++;
            }

            return count;
            
        }
    }
}
