using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Valid_Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            int bracketBalance = 0;
           
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ')')
                {
                    if (bracketBalance < 1)
                    {
                        return false;
                    }
                    else bracketBalance--;
                }
                else if (input[i] == '(')
                {
                    bracketBalance++;
                }
            }
            if (bracketBalance == 0)
                return true;
            else
                return false;
        }
    }
}
