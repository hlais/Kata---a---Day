using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Occuring_Characters
    {
        public static Dictionary <char, int> OccuringCharacters (string str)
        {
            Dictionary<char, int> charCounting = new Dictionary<char, int>();

            foreach (var item in str)
            {   //if the list already contains key we should go to next item
                if (charCounting.ContainsKey(item))
                { 
                    continue;
                }
                    int count = str.Count(f => f == item);
                    charCounting.Add(item, count);
                
            }
            return charCounting;
      
        }
    }
}
