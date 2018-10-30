using System;
namespace Solution
{
    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int doubleAge = sonYears * 2;
            return (int)MathF.Abs(dadYears - doubleAge);
        }
    }
}