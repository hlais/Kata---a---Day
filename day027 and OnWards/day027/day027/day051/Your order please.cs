using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Your_order_please
    {
        public static string Order(string sentence)
        {
           
            if (sentence == "")
            {
                return string.Empty;
            }
            string empty = "";
            string[] words = sentence.Split(' ');
           
            string[] newWords = new string[words.Length];

            foreach (var item in words)
            {
                if (item.Contains("1"))
                {
                    newWords[0] = item;
                }
                if (item.Contains("2"))
                {
                    newWords[1] += item;
                }
                if (item.Contains("3"))
                {
                    newWords[2] = item;
                }
                if (item.Contains("4"))
                {
                    newWords[3] = item;
                }
                if (item.Contains("5"))
                {
                    newWords[4] = item;
                }
                if (item.Contains("6"))
                {
                    newWords[5] = item;
                }
                if (item.Contains("7"))
                {
                    newWords[6] = item;
                }
                if (item.Contains("8"))
                {
                    newWords[7] = item;

                }
                if (item.Contains("9"))
                {
                    newWords[8] = item;
                }
                if (item.Contains("10"))
                {
                    newWords[9] = item;
                }

            }
            List<string> WordsContainer = new List<string>(newWords);

            foreach (var element in WordsContainer)
            {
                empty += element.ToString() + " ";

            }

            return empty.Trim();
   
        }
    }
}
