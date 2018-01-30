using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CodeWars
{
    class Finding_String_In_Array
    {
        public static string FindNeedle(object[] haystack)
        {
            int indexOfString = Array.IndexOf(haystack, "needle");

            return "found the needle at position " + indexOfString;



        }
    }
}

