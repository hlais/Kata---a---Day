using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    class Squar_n_Sum
    {
        public static int SquareSum(int[] n)
        {


           return  n.Sum(t => t * t);

        }
    }
}

