using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Minutes_to_Midnight
    {
        static public string countMinutes(DateTime d)
        {
            TimeSpan midnight = new TimeSpan(24, 00, 00);

            TimeSpan midDifTime = midnight.Subtract(d.TimeOfDay);

            double diff = Math.Round(midDifTime.TotalMinutes);

            if (diff < 10)
            {
                return $"{diff} minute";
            }
            else
                return $"{diff} minutes";

        }
    }
}
