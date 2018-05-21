using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars6Kata
{
    class CheckingGroups
    {
        public static bool validBraces(String braces)
        {
            string prev = "";
            while (str.Length != prev.Length)
            {
                prev = str;
                str = str
                    .Replace("()", String.Empty)
                    .Replace("[]", String.Empty)
                    .Replace("{}", String.Empty);
            }
            return (str.Length == 0);

        }

    }
}
    

