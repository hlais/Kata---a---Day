using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class IQTest
    {
        public static int Test(string numbers)
        {
            int[] stringToNumbersArray= Array.ConvertAll(numbers.Split(' '), int.Parse);
            List<int> intListNumbers = new List<int>(stringToNumbersArray);
     
            int thatNumber = intListNumbers.GroupBy(num => num % 2).Single(group => group.Count() == 1).First();
            return intListNumbers.IndexOf(thatNumber) +1; 
        }
    }
}
