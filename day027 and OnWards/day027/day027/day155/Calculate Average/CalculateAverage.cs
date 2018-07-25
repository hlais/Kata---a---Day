using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    class CalculateAverage
    {
        public static double FindAverage(double[] array)
        {
            return array.Length == 0? 0: (double)array.Sum() / array.Length;
        }
    }
}
