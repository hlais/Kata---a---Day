using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class ArrayDiff
    {
        public static int[] Array_Diff(int[] a, int[] b)
        {
            List<int> mainArray = new List<int>(a);
            foreach (var item in b)
            {
                if (mainArray.Contains(item))
                {

                    mainArray.RemoveAll(n => n == item);

                }
            }
            return mainArray.ToArray();

        }
    }
}
