using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWards7Kata
{
    class LetterBox
    {
        public static IEnumerable<int> PaintLetterBoxes(int start, int end)
        {
            int[] numberCounter = new int[10];
            for (int i = start; i <= end; i++)
            {

                string number = i.ToString();

                    foreach (var item in number)
                    {
                        numberCounter[(int)char.GetNumericValue(item)]++;
                    }

            }
            return numberCounter;
        }
    }
}
