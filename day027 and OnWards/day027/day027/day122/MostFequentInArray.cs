
using System.Collections.Generic;
using System.Linq;

namespace CodeWars6Kata
{
    class MostFequentInArray
    {
        public static int HighestRank(int[] arr)
        {
            int freqCount = 0;
            int highestFreqNum = 0;
            List<int> listOfmx = new List<int>(arr);
            listOfmx.Sort();

            foreach (var item in listOfmx)
            {
               int  curfreqCount = (arr.Count(x => x == item));

                if (curfreqCount >= freqCount)
                {
                    freqCount = curfreqCount;
                    highestFreqNum= item;
                } 
            }
            return highestFreqNum;
        }
    }
}
