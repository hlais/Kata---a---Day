using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class SpinWords
    {
        public static string Spin_Words (string sentence)
        {
            string empty = "";
            string[] words = sentence.Split();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    string output = new string(words[i].ToCharArray().Reverse().ToArray());
                    empty += output + " ";
                }

                if (words[i].Length < 5)
                {
                    empty += words[i] + " ";
                }
            }
            
            return empty.TrimEnd();

        }
    }
}
