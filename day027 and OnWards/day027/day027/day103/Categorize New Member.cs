using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Categorize_New_Member
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> someChars = new List<string>();
            
            foreach (var item in data)
            {
                if (item[0] >= 55 && item[1] > 7)
                {
                    someChars.Add("Senior");
                }
                else
                    someChars.Add("Open");
            }

            return someChars;
        }
    }
}
