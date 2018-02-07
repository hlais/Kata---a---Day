using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Replacing_Chars_Around
    {
        public static string MakeComplement(string dna)
        {
            char[] lettersInDna = dna.ToCharArray();
            string empty = "";
            for (int i = 0; i < dna.Length; i++)
            {
                if (lettersInDna[i] == 'A')
                {
                    empty += 'T';
                }
                if (lettersInDna[i] == 'T')
                {
                    empty += 'A';
                }
                if (lettersInDna[i] == 'G')
                {
                    empty +=  'C';
                }
                if (lettersInDna[i] == 'C')
                {
                    empty +='G';
                }
            }
            return empty;
   
        }
    }
}

           