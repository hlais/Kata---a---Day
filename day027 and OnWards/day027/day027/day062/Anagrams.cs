using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Anagrams
    {
        public static List<string> FindTheAnagrams(string word, List<string> words)
        {
            string orderedWord =  string.Concat(word.OrderBy(c => c));
            List<string> foundAnagrams = new List<string>();
            foreach (var item in words)
            {
               string tempOrderdWord = string.Concat(item.OrderBy(c => c));

                if (orderedWord == tempOrderdWord)
                {
                    foundAnagrams.Add(item);
                }
            }
            return foundAnagrams;
        }
    }
}