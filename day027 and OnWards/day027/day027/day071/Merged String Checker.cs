using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Merged_String_Checker
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            if (s.Length != part1.Length + part2.Length)
            {
                return false;
            }
            if (s == string.Empty)
            {
                return true;
            }

            if (part1.Length > 0 && part1[0] == s[0])
            {
                if (isMerge(s.Substring(1), part1.Substring(1), part2))
                {
                    return true;
                }

            }
            if (part2.Length > 0 && part2[0] == s[0])
            {
                if (isMerge(s.Substring(1), part1, part2.Substring(1)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
