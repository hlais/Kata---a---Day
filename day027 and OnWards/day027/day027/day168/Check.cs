using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Kata8
{
    class Check
    {
        public static bool CheckMethod(object[] a, object x)
        {
          

            foreach (var item in a)
            {
                if (item.Equals(x))
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
