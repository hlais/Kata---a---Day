using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CodeWars
{
    class Filling_An_Array
    {
        public static int[] Arr(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] += i;
            }

            return arr;
        }
    }
}
        
