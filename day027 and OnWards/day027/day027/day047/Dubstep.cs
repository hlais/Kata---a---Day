using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars6Kata
{
    class Dubstep
    {
        public static string SongDecoder(string input)
        {
            List<string> newWordsList = new List<string>();
            string empty = "";
            string withOutWub = input.Replace("WUB", " ").Trim(); ;

            string[] newWords = withOutWub.Split();
            foreach (var item in newWords)
            {
                if (item == " " || item == "")
                {
                    continue;
                }
                newWordsList.Add(item);

            }

            foreach (var item in newWordsList)
            {
                empty += item + " ";
            }
            return empty.Trim();




        }
    }
}
