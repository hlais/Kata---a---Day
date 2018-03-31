using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Sum_Mixed_Array
    {
        public static int SumMix(object[] x)
        {
            int sum = 0;
            
            foreach (var item in x)
            {

              sum +=  Convert.ToInt32(item);
            }
            return sum;
        }
    }
}
