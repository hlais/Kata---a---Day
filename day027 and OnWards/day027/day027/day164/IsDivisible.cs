using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class IsDivisible
    {
        public static bool IsDivisibleMethod(int wallLength, int pixelSize)
        {
            //    float test = (float)wallLength / pixelSize;

            //    Console.WriteLine(test);
            return (float)wallLength / pixelSize % 1 ==0 ? true:false;
        }
    }
}
