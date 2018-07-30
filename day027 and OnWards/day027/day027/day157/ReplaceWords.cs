using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class ReplaceWords
    {
        public static string Covfefe(string tweet)
        {
            if (tweet.Contains("coverage"))
            {
                return tweet.Replace("coverage", "covfefe");
            }
            else
                return tweet + " covfefe";
                
            
        }
    }
}
