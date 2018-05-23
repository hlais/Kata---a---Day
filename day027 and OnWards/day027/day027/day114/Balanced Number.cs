using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Numerics;

namespace CodeWards7Kata
{
    class Balanced_Number
    {
        public static string BalancedNumber(int number)
        {
            string numberStr = number.ToString();
            int pad = 0;
            int leftSide = 0;
            int rightSide = 0;
            
            if ((decimal)numberStr.Length / 2 % 1 == 0)
            {
                pad = (numberStr.Length / 2) - 1; 
            }
            else
                pad = (numberStr.Length / 2) ;

            if (numberStr.Length <= 2)
            {
                return "Balanced";
            }
            else
            {
                string leftSideStr = numberStr.Substring(0, pad);
                string rightSideStr = numberStr.Substring(numberStr.Length - leftSideStr.Length, pad);
                leftSide= leftSideStr.Select(x => Convert.ToInt32(x)-48).Sum();
                rightSide = rightSideStr.Select(x => Convert.ToInt32(x)-48).Sum();
            }
            return leftSide == rightSide ? "Balanced" : "Not Balanced";
            

        }
    }
}
