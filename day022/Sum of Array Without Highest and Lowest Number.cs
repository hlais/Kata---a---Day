using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    class Sum_of_Array_Without_Highest_and_Lowest_Number
    {
        public static int Sum(int[] numbers)
        {

           if (numbers == null || numbers.Length == 0) return 0;

           int[] organNumber =   numbers.OrderByDescending(n=> n).ToArray();
           int sum = 0;
           for (int i = 1; i < numbers.Length - 1; i++)
           {
               sum = sum + organNumber[i]; 
           }

           return sum;
           

        }
    }
}
