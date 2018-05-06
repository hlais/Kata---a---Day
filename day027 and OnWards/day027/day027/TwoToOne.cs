using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            
            List<char> distinct = new List<char>(string.Concat((s1 + s2).Select(x => x).Distinct()));
            distinct.Sort();
            return string.Join(null,distinct);

        }
    }
}
