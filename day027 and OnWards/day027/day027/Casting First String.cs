using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWards7Kata
{
    class Casting_First_String
    {
        public static string ToJadenCase( string phrase)
        {
         
            char[] letters = phrase.ToLower().ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = i == 0 || letters[i -1 ] == ' ' ? char.ToUpper(letters[i]) : letters[i];

            }

            return new string(letters);
            
        }
    }
}
