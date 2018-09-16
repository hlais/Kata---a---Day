using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class ReduceButGrow
    {
        public static int Grow(int[] x)
        {
            int firstNum = x[0];
            for (int i = 1; i < x.Length; i++)
            {
              firstNum=  firstNum* x[i];
            }
            return firstNum;
        }
    }
}
