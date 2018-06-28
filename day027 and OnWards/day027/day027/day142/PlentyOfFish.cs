using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class PlentyOfFish
    {
      
        public static int fish(string shoal)
        {
            int currentLevelOfFish = 1;
            int consumption = 0;
            int bellyLimit = 4; // current belly limit

            //convert char to int array
            int[] fishes = Array.ConvertAll(shoal.ToCharArray(), x=> Convert.ToInt32(x)- 48 );
            Array.Sort(fishes); 


            for (int i = 0; i < fishes.Length; i++)
            {
                //fish can only eat fish same size or less
                if (fishes[i] <= currentLevelOfFish)
                {
                    consumption += fishes[i];
                }

                if (consumption >= bellyLimit)
                {
                    consumption = Math.Abs(bellyLimit - consumption); // reset belly intake leaving remainder
                    currentLevelOfFish++; // level increase                
                    bellyLimit += 4; // belly limit increase!
                }
            }
            return currentLevelOfFish;

        }
    }
}
