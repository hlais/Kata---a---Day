using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Friday_the_13th
    {
        public static string FridayTheThirteenths(int Start, int End = int.MinValue)
        {
            //int.MinValue appears to be the same as null :O
            if (End == int.MinValue)
            {
                End = Start;
            }

            DateTime start = new DateTime(Start, 1, 01);
            DateTime end = new DateTime(End, 12, 28);

            int startYear = start.Year;
            int endYear = end.Year;
            string empty = "";

            for (int year = startYear; year <= endYear; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    DateTime theDate13th = new DateTime(year, month, 13);


                    if (theDate13th.DayOfWeek == DayOfWeek.Friday)
                    {
                        empty += String.Format("{0:M/d/yyyy}", theDate13th) + " ";

                    }

                }

            }

            return empty.TrimEnd();

        }
    }
}
