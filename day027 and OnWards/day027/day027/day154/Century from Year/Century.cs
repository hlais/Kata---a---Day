using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Century
    {
        public static int СenturyFromYear(int year)
        {
            return (int)Math.Ceiling(year * 0.01);

        }
    }
}
