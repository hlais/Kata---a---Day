using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Bit_Counting
    {
        public static int CountBits(int n)
        {
            int count = 0;
            string binary = Convert.ToString(n, 2);

            char[] binChar = binary.ToCharArray();

            foreach (var item in binChar)
            {
                if (item == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }
        
}
