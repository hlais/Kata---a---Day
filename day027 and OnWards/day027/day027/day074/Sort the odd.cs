using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Sort_the_odd
    {
        public static int[] SortArray(int[] array)
        {   
            //will use list to sort
            List<int> oddNumbers = new List<int>();

            int arrayElement = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0 || item == 0)
                {
                    array[arrayElement] = item;  
                }
                else
                {
                    //make element (minus)value, to pick out easier
                    array[arrayElement] = -item;
                    oddNumbers.Add(item);            
                }
                arrayElement++;
            }

            int[] sorted = oddNumbers.OrderByDescending(x => x).Reverse().ToArray();
            int sortedIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {   //if value less than one, insert with []sort
                    array[i] = sorted[sortedIndex];
                    sortedIndex++;
                }
            }
                
            return array;

        }
    }
}
