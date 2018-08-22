using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class UnluckyDays
    {
        public static int UnluckyDaysInYear(int year)
        {

            int friday13thCounter = 0;

            for (int i = 1; i <= 12; i++)
            {
                DateTime monthIteratar = new DateTime(year, i, 13);

                if (monthIteratar.DayOfWeek == DayOfWeek.Friday)
                {
                    friday13thCounter++;
                }
            }
             return friday13thCounter;
        }
    }
}

