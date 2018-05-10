using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class From_the_Largest
    {
        public static int MaxNumber(int n)
        {
            List<int> numbers = n.ToString().Select(x => Convert.ToInt32(x)-48).ToList();

            numbers.Sort();
             numbers.Reverse();

           return Convert.ToInt32(string.Join(null, numbers));

        }
    }
}
