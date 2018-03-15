using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Rot13
    {
        public static string _Rot13(string message)
        {
            string empty = "";
            foreach (var item in message)
            {

                int ascii = (int)item;
                if (ascii < 65 || ascii > 122 || ascii > 90 && ascii < 97)
                {
                    empty += item;
                }

                if (ascii > 64 && ascii < 91)
                {
                    int ascii13 = (int)item + 13;
                    if (ascii13 > 90)
                    {
                        int reminader = ascii13 - 90;
                        empty += (char)(reminader + 64);

                    }
                    else
                    {
                        empty += (char)(ascii13);
                    }
                }


                if (ascii > 96 && ascii < 123)
                {
                    int ascii13 = (int)item + 13;
                    if (ascii13 > 122)
                    {
                        int remainder = ascii13 - 122;
                        empty += (char)(remainder + 96);

                    }
                    else
                    {
                        empty += (char)ascii13;
                    }
                }

            }
            return empty;
        }
    }
}
