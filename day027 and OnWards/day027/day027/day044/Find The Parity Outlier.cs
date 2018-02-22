using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Find_The_Parity_Outlier
    {
        public static int Find(int[] integers)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    even.Add(integers[i]);

                }
                else
                {
                    odd.Add(integers[i]);
                }
            }
            if (even.Count > odd.Count)
            {
                return odd[0];
            }
            else return even[0];

        }
    }
}

