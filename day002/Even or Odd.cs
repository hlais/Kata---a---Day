using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class Even_or_Odd
    {
        public static string EvenOrOdd(int number)
        {
            string EvenOrOdd = "";

            if (number % 2 == 0)
            {
                EvenOrOdd = "Even";
                return EvenOrOdd;
            }
            else
            {
                EvenOrOdd = "Odd";
                return EvenOrOdd;
            }
            
        }
    }
}
