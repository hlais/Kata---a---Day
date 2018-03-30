using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Find_the_unique_number
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
          int unique =  numbers.GroupBy(group => group).Single(group => group.Count() == 1).First();
            return unique;
        }
    }
}
