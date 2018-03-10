using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Moving_Zeros_To_The_End
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int zeroCount = 0;
            List<int> arrList = new List<int>();
            foreach (var item in arr)
            {
                if (item == 0)
                {
                    zeroCount++;
                }
                else
                {
                    arrList.Add(item);
                }
            }
            while (zeroCount != 0)
            {
                arrList.Add(0);
                zeroCount--;
            }
            return arrList.ToArray();
        }
    }
}
