using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class LeapYears
    {
        public static bool IsLeapYear(int year)
        {
           return DateTime.IsLeapYear(year);
        }
    }
}
