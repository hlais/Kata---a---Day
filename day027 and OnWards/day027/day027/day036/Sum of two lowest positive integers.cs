using System;

namespace CodeWards7Kata
{
    class Sum_of_two_lowest_positive_integers
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            int totalOfTwoLowestInts;
            Array.Sort(numbers);

            return totalOfTwoLowestInts = numbers[0] + numbers[1];
                
        }
    }
}
