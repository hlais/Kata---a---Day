using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata8
{
    class SuperSize
    {
        public static long SuperSizeMethod(long num)
        {
            char[] chaNums = num.ToString().ToCharArray();
            Array.Sort(chaNums);
           var organisedChars = chaNums.Reverse();
            string strOrganised  = string.Concat(organisedChars);
            long.TryParse(strOrganised, out long result);
            return result;
  

        }
    }
}


