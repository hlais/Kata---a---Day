using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Maximum_Multiple
    {
        public static int MaxMultiply(int divisor, int bound)
        {
            int maximumMultiple = (bound / divisor) * divisor;
            return maximumMultiple;
        }
    }
}
