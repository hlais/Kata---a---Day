using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class LongestRepetition
    {
        public static Tuple<char?,int> LongestRepeted(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new Tuple<char?, int>(null, 0);
            }
           
            char[] lettersInInput = input.ToCharArray();
            int currentConsecutiveCount = 1;
            int maxConsecutiveCount = 0;
            int indexOfPreviousChar = 0;
            char mostRepeated = ' ';
            char previousChar = lettersInInput[indexOfPreviousChar];

            if (input.Length == 2)
            {
                return new Tuple<char?, int>(lettersInInput[0], 1);
            }



            for (int i = 1; i < lettersInInput.Length; i++)
            {

                if (lettersInInput[i] != lettersInInput[indexOfPreviousChar])
                {
                    currentConsecutiveCount = 1;
                }
                else
                    currentConsecutiveCount++;

                if (currentConsecutiveCount >= maxConsecutiveCount)
                {
                    mostRepeated = lettersInInput[i];
                    maxConsecutiveCount = currentConsecutiveCount;
                }

                indexOfPreviousChar++;
            }

            return new Tuple<char?, int>(mostRepeated, maxConsecutiveCount);

        }
    }
}
