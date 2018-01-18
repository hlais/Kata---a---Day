using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Repeat_String
    {
        public static string repeatStr (string input, int numberOfTimes)
        {
            string repeatedString = "";

            for (int x = 0; x < numberOfTimes; x++)
            {
                repeatedString += input;
            }
            return repeatedString;
        }
    }
}

