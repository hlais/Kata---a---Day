using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CodeWars
{
    class Occurances_In_Array
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(s => s);
        }
    }
}
