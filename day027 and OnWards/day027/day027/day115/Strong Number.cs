using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWards7Kata
{
    class Strong_Number
    {
        public static string StrongNumber(int number)
        {
            int sum = 0;
            char[] chaNumber = number.ToString().ToCharArray();
            List<int> collectionNum = new List<int>();
            foreach (var item in chaNumber)
            {
               collectionNum.Add(Convert.ToInt32(item - 48));
            }

            foreach (var item in collectionNum)
            {
                int iteration = item;
                int curFactorial = 1;
                while (iteration > 0)
                {
                    curFactorial *= iteration;
                    iteration--;
                }
                sum += curFactorial;
            }
            return sum == number ? "STRONG!!!!" : "Not Strong !!";
        }
    }
}
