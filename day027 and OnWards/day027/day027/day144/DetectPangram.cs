using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class DetectPangram
    {
        public static bool IsPangram(string str)
        {
            
            char[] charStr = str.ToLower().ToCharArray();
            List<char> alphapet = new List<char>();

            foreach (var item in charStr)
            {
                if (alphapet.Contains(item) || char.IsLetter(item) == false)
                {
                    continue;
                }
                alphapet.Add(item);


            }

            return alphapet.Count == 26 ? true : false;  
            
        }
    }
}
