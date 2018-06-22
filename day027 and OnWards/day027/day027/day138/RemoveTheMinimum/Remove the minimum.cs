using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class Remove_the_minimum
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {

            int smallestNumber = int.MaxValue;
            int indexOfSmallest = 0;

            if (numbers.Count == 0)
            {
                return new List<int>();
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                    indexOfSmallest = i;
                }
            }
            numbers.RemoveAt(indexOfSmallest);

            return numbers;
          
        }
    }
}
