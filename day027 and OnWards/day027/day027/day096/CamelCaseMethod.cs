using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class CamelCaseMethod
    {
        public static string CamelCase( string str)
        {

            string empty = "";
            string[] words = str.ToLower().Split(' ');

            foreach (var item in words)
            {
                if (item.Length > 0)
                {
                    empty += item.Substring(0, 1).ToUpper();
                    empty += item.Substring(1).ToLower();
                }
            }

            return empty;

        }
    }
}
