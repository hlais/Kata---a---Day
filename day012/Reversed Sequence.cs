using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CodeWars
{
    class Reversed_Sequence
    {
        public static int[] ReverseSeq(int n)
        {
            List<int> reverseValues = new List<int>();

            while (n > 0)
            {
                reverseValues.Add(n--);
            }
            return reverseValues.ToArray();
        }
    }
}
