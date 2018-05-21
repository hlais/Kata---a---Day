using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars6Kata
{
    class CheckingGroups
    {
        public static bool validBraces(String input)
        {
             string empty = "";

            while (input.Length != empty.Length)
            {
                empty = input;

                input =input.Replace("{}", string.Empty)
                            .Replace("()", string.Empty)
                            .Replace("[]", string.Empty);

            }
            return input.Length == 0;

        }

    }
}
    

