using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Greed_Is_Good
    {
        public static int Score(int[] dice)
        {
            List<int> diceList = new List<int>(dice);
            int oneCount = 0, twoCount =0, threeCount =0, fourCount =0, fiveCount =0, sixCount = 0;

            int score = 0;
            foreach (var item in diceList)
            {
                if (item == 1)
                {
                    oneCount++;
                }
                if (item == 2)
                {
                    twoCount++;
                }
                if (item == 3)
                {
                    threeCount++;
                }
                if (item == 4)
                {
                    fourCount++;
                }
                if (item == 5)
                {
                    fiveCount++;
                }
                if (item == 6)
                {
                    sixCount++;
                }
            }

            if (oneCount > 0)
            {
                if (oneCount == 6)
                {
                    score += 2000;
                }
                if (oneCount == 5)
                {
                    score += 1200;
                }
                if (oneCount == 4)
                {
                    score += 1100;
                }
                    
                if (oneCount == 3)
                {
                    score += 1000;
                }
                if (oneCount == 2)
                {
                    score += 200;
                }
                if (oneCount == 1)
                {
                    score += 100;
                }
            }
            if (twoCount > 2)
            {
                if (twoCount > 2 && twoCount < 6)
                {
                    score += 200;
                }
                if (twoCount == 6)
                {
                    score += 400;
                }

            }
            if (threeCount > 2)
            {
                if (threeCount > 2 && threeCount < 6)
                {
                    score += 300;
                }
                if (twoCount == 6)
                {
                    score += 600;
                }
            }
            if (fourCount > 2)
            {
                if (fourCount > 2 && fourCount < 6)
                {
                    score += 400;
                }
                if (fourCount == 6)
                {
                    score += 800;
                }
            }
            if (fiveCount > 0)
            {
                if (fiveCount == 6)
                {
                    score += 1000;
                }
                if (fiveCount == 5)
                {
                    score += 600;
                }
                if (fiveCount == 4)
                {
                    score += 550;
                }

                if (fiveCount == 3)
                {
                    score += 500;
                }
                if (fiveCount == 2)
                {
                    score += 100;
                }
                if (fiveCount == 1)
                {
                    score += 50;

                }
            }
            if (sixCount > 2)
            {
                if (sixCount > 2 && sixCount < 6)
                {
                    score += 600;
                }
                if (sixCount == 6)
                {
                    score += 1200;
                }
            }
            return score;
        }
    }
}
