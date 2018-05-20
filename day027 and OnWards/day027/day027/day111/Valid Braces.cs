using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Valid_Braces
    {
        public static bool validBraces(String braces)
        {
            Stack<char> stackBraces = new Stack<char>();

            foreach (var cha in braces)
            {
                if (cha == '{' || cha == '(' || cha == '[')
                {
                    stackBraces.Push(cha);
                }
                if (cha == '}' || cha == ')' || cha == ']')
                {
                    if (stackBraces.Count == 0)
                    {
                        return false;
                    }
                    if (IsMatching(stackBraces.Peek(), cha))
                    {
                        stackBraces.Pop();
                    }
                    else
                        return false;
                }
            }
               
            
            if (stackBraces.Count == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsMatching(char firstChar, char secondChar)
        {
            return firstChar == '{' && secondChar == '}' || firstChar == '[' && secondChar == ']' ||
                    firstChar == '(' && secondChar == ')' ? true : false;

        }

    }
}
    

