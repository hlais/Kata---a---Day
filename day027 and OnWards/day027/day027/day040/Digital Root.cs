using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Digital_Root
    {
        public static int DigitalRoot(long n)
        {
            string number = n.ToString();
            int digitPhase1 = BreakDownInt(number);

            do
            {
                int result = 0;

                for (; digitPhase1 > 9; digitPhase1 /= 10)
                    result += digitPhase1 % 10;

                digitPhase1 = result + digitPhase1;
            }
            while (digitPhase1 > 9);

            return digitPhase1;


        }

        public static int BreakDownInt(string number)
        {
            int empty = 0;
            char[] charNumber = number.ToCharArray();
            foreach (var item in charNumber)
            {

                empty += (int)Char.GetNumericValue(item);
            }

            return empty;
        }
    }
}


