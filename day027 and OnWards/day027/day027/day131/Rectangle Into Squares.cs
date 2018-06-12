using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Rectangle_Into_Squares
    {
        public static List<int> sqInRect(int lng, int wdth)
        {
            List<int> squareArea = new List<int>();

            if (lng == wdth)
            {
                return null;
            }
            while (true)
            {
               
                int sqr= lng > wdth ? wdth : lng;
                squareArea.Add(sqr);

                if (lng > wdth)
                {
                    lng -= sqr;
                   
                }
                else
                {
                    wdth -= sqr;

                }
                //the final block 
                if (lng == wdth)
                {
                    squareArea.Add(lng);
                    break;
                }
            }
            return squareArea;
        }
    }
}
