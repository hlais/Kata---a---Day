using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class GrowthOfAPopulation
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int expectedPopulation = p;

            int cityPopulation = p0;
            int newInhabitantsPerYear = aug;
            double increasePerYear = percent / 100;
            int years = 0;

            while (cityPopulation < expectedPopulation)
            {
                cityPopulation += (int)(cityPopulation * increasePerYear) + newInhabitantsPerYear;

                years++;
            }

            return years;
        }
    }
}
