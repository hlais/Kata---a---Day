using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    public class Consonant_Value
    {
        public static int Solve(string s)
        {
            int maxChar = 0;
            int temp = 0;
            char[] characters = s.ToLower().ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == 'a' || characters[i] == 'e' || characters[i] == 'i' ||
                    characters[i] == 'o' || characters[i] == 'u')
                {
                    characters[i] = '-';
                }
            }

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == '-')
                {
                    if (temp > maxChar)
                    {
                        maxChar = temp;
                    }
                    temp = 0;
                    continue;
                }
                else
                {
                    int ascii = (int)characters[i] - 96;
                    temp += ascii;
                }
            }
            return maxChar;
        }
    }
}
