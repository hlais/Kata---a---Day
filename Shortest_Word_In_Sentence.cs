using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    class Shortest_Word_In_Sentence
    {
        public static int FindShort(string sentence)
        {

            string[] words = sentence.Split();
            int shortestWordLength = words.Min(p => p.Length);
            return shortestWordLength;

        }
    }
}
            
    