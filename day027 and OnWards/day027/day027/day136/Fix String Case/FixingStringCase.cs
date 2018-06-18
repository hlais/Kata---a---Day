using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class FixingStringCase
    {   
        public static string Solve(string s)
        {
            int lowerCharCount = 0;
            int upperCharCount = 0;
            foreach (var item in s)
            {
                if (char.IsLower(item))
                {
                    lowerCharCount++;
                }
                else
                    upperCharCount++;
            }

            if (lowerCharCount > upperCharCount || lowerCharCount == upperCharCount)
            {
                return s.ToLower();
            }
            else
                return s.ToUpper();
            
        }
    }   
}
