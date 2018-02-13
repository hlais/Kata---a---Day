using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Credit_Card_Masking
    {
        public static string Maskify(string cc)
        {
            char[] letters = cc.ToCharArray();
            string empty = "";
            if (letters.Length <= 4)
            {
                return cc;
            }

            for (int i = 0; i < cc.Length -4; i++)
            {
                empty += "#";
            }
           return empty + cc.Substring(cc.Length - 4);
            
        }
    }
}
