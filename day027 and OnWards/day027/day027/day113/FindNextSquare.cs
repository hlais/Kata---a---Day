using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class FindNextSquare
    {
        public static long NextSquare(long num)
        {
            
            long nextSquare = 0;
            if (Math.Sqrt(num) % 1 != 0)
            {
                return -1;
            }
            else
            {
                long currentSqr = (long)Math.Sqrt(num);
                nextSquare = currentSqr + 1;

            }
            return nextSquare * nextSquare;
        }
    }
}
