using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Directions_Reduction
    {

        public static string[] dirReduc(string[] arr)
        {

            bool optimized = false;
            int totalLength = arr.Length;
            List<string> directions = new List<string>(arr);
           

            do
            {
                optimized = true;
                for (int index = 1; index < totalLength; index++)
                {
                    if (directions.ElementAt(index).Length == directions.ElementAt(index - 1).Length
                        && 
                        directions.ElementAt(index) != directions.ElementAt(index - 1))
                    {
                        directions.RemoveAt(index);
                        directions.RemoveAt(index - 1);
                        optimized = false;
                        totalLength = directions.Count;
                        break;
                    }
                }
            } while (!optimized);

            return directions.ToArray();


        }
    }
}



