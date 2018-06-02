using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class FizzBuzz
    {
        public static int[] Solution(int number)
        {
            int counter = 1;
            int arr0 = 0;
            int arr1 = 0;
            int arr2 = 0;

            while (counter < number)
            {
                if (counter % 15 == 0)
                {
                    arr2++;
                }
                else if (counter % 5 == 0)
                {
                    arr1++;
                }
                else if (counter %3 ==0)
                {
                    arr0++;
                }
                counter++;
            }

            int[] fizzBuzzCounter = { arr0, arr1, arr2 };
            return fizzBuzzCounter;
        }
    }
}
