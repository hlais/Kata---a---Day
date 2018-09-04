using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class ElapsedSeconds
    {
        public static int ElapsedSecondsCal (DateTime startDate, DateTime endDate)
        {

           TimeSpan elapsed = endDate - startDate;
            return (int)elapsed.TotalSeconds;
        }
    }
}
