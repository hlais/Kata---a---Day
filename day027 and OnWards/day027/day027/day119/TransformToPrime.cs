using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class TransformToPrime
    {
        public static int MinimumNumber(int[] numbers)
        {
            int incrementCounter = 0;
            int sum =  numbers.Sum();

            while (!isPrimeNumber(sum))
            {
                sum += 1;
                incrementCounter++;
            }
            return incrementCounter;
        }


        public static bool isPrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
