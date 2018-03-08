using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Human_Readable_Time
    {
        public static string GetReadableTime(int seconds)
        {
            int hours = seconds / 3600;
            int mins = (seconds % 3600) / 60;
            seconds = seconds % 60;
            return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, mins, seconds);
        }
    }
}
