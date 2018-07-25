using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class IsItNumber
    {
        public static bool IsDigit(string s)
        {
            double test;
            return  double.TryParse(s, out  test);
        }
    }
}
