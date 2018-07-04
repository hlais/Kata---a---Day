using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class EqualSidesOfArray
    {
        public static int FindEvenIndex(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSide = arr.Take(i).Sum();
                int rightSide = arr.Skip(i+1).Sum();

                if (leftSide == rightSide)
                {
                    return i;
                }
            }

            return -1;

        } 
    }
}
