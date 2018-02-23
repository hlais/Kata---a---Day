using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Find_Odd_Int
    {
        public static int find_it(int[] seq)
        {

            return seq.GroupBy(num => num).Single(group => group.Count() % 2 != 0).First();
        }
    }
}

