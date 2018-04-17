using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class SplitStrings
    {
        public static string[] Solution(string str)
        {
            int splitter = 0;
            
            string[] splitStrings = new string[(int)Math.Ceiling((decimal)str.Length / 2)];
            if (str.Length % 2 == 0)
            {

                for (int i = 0; i < splitStrings.Length; i++)
                {
                    splitStrings[i] = str.Substring(splitter, 2);
                    splitter += 2;
                }
            }
            else
            {
                for (int i = 0; i < splitStrings.Length; i++)
                {
                    if (i != splitStrings.Length-1 )
                    {
                        splitStrings[i] = str.Substring(splitter, 2);
                        splitter += 2;
                        continue;
                    }
                    
                        splitStrings[i] = str.Substring(str.Length - 1) +"_";
                }
            }

            return splitStrings;
        }
    }
}
