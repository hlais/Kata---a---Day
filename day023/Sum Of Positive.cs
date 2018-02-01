using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    class Sum_Of_Positive
    {
        public static int PositiveSum(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            int sum = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    sum += item;

                }
            }

            return sum;
        }
    }
}
