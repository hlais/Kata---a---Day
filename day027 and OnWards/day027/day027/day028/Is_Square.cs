using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Is_Square
    {
        public static bool IsSquare(int n)
        {
           if ((Math.Sqrt(n) % 1) == 0)
   
            {
                return true;
            }
            else
                return false;
        }
    }
}
