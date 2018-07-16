using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Abbreviate
    {
        public static string AbbrevName(string name)
        {
            string[] subName = name.Split(' ');
           return  subName[0][0].ToString().ToUpper() + "." + subName[1][0].ToString().ToUpper();
    
        }

    }
}
