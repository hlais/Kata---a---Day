using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Sum_Arrays
    {
        public static double SumArray(double[] array)
        {
            
             double sumOfArrayElements = 0;

             for (int i = 0; i < array.Length; i++)
             {
                sumOfArrayElements+= array[i];

             }
             return sumOfArrayElements;
  
        }
    }
}