using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Pascal_To_Snake_Case
    {
        public static string ToUnderscore(int str)
        {
            return str.ToString();
          
        }
        public static string ToUnderscore(string str)
        {
            string empty = "";
            bool isFirstCharUpper = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!isFirstCharUpper)
                {
                    if (char.IsUpper(str[0]))
                    {
                        empty += char.ToLower(str[i]);
                        isFirstCharUpper = true;
                        continue;

                    }
                }
                if (char.IsUpper(str[i]))
                {
                    empty += "_" + char.ToLower(str[i]);
                }
                else
                    empty += str[i].ToString();

            }

            return empty;
        }
    }
}