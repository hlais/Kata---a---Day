using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Which_are_in
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> theyAreInHere = new List<string>();
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j].Contains(array1[i]) && theyAreInHere.Contains(array1[i]) == false)
                    {
                        //keep 
                        theyAreInHere.Add(array1[i]);
                       
                    }
                }
            }

            theyAreInHere.Sort();
            return theyAreInHere.ToArray();
        }
    }
}
