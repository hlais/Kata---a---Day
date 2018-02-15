using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class Isograms
    {
        
        public static bool IsIsogram(string str)
        {
            int repeatedCharCount = 0;
            List<char> listChar = new List<char>(str.ToString().ToLower().ToCharArray());
            char[] strChar = str.ToLower().ToCharArray();
            for (int i = 0; i < strChar.Length; i++)
            {
                x = listChar.Count(f => f == strChar[i]);
                {
                    if (repeatedCharCount == 2)
                    {
                        return false;
                    }
                }
            }

                return true;

        }
    }
}
