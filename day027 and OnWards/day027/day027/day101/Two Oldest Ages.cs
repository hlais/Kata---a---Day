using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class Two_Oldest_Ages
    {
        public static int[] TwoOldestAges(int[] ages)
        {

            int eldest = -1;
            int secondEldest = -1;

            foreach (var age in ages)
            {

                if (age > eldest)
                {
                    
                    secondEldest = eldest;
                    eldest = age;
                }
               else if (age > secondEldest)
                {
                    secondEldest = age;
                }


            }
            int[] twoEldest = { secondEldest, eldest };
            return twoEldest;


        }
    }
}
