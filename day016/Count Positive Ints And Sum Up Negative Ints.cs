using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    class Count_Positive_Ints_And_Sum_Up_Negative_Ints
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {

            if (input == null || input.Length == 0)
            {
                return new int[] { };
            }
            int countPositiveNumber = input.Count(n => n > 0);
            int addUpAllNegativesNumbers = input.Where(n => n < 0).Sum();

            return new int[] { countPositiveNumber, addUpAllNegativesNumbers };
        }

    }
}
