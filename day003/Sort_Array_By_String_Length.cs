using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CodeWars
{
    public class Sort_Array_By_String_Length
    {
        public static string[] SortArrayByStringLength(string[] array)
        {


            string[] sortedArray = new string[array.Length];


            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            for (int i = 0; i < array.Length; i++)
            {
                sortedArray[i] = array[i];

            }



            return sortedArray;

        }
    }
}





