using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class NthSmallestInArray
    {
        public static int NthSmallest(int[] arr, int pos)
        {
             var sorted = arr.OrderBy(x => x).ToArray();
              return  sorted.ElementAt(pos);
            
        }
    }
}
