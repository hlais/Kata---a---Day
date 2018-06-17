using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Correct
    {
        
        public static string CorrectMistakes(string text)
        {
            return text.Replace('0', 'O').Replace('1', 'I').Replace('5','S');
           
        }
    }
}
