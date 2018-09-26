using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata8
{
    class RentalCar
    {
        public static int RentalCarCost(int d)
        {
            int cost = d * 40;
            if (d >= 7)
            {
                return cost - 50;
            }
            else if (d >= 3)
            {
                return cost - 20;
            }
            else return cost;
  
        }
    }
}

