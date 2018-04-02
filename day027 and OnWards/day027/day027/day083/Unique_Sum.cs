using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
    

namespace CodeWards7Kata
{
    class Unique_Sum
    {
        public static int UniqueSum(List<int> lst)
        {


            if (lst.Count == 0)
            {
                return  null;
            }
            return lst.Distinct().Sum();

        }
    }
}
