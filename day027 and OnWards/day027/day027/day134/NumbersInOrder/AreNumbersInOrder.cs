using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class AreNumbersInOrder
    {
        public static bool IsAscOrder(int[] arr)
        {
            int previousNumber = 0;
            foreach (var item in arr)
            {
                if (item >= previousNumber)
                {
                    previousNumber = item;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
