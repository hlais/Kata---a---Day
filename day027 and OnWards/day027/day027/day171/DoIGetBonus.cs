using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class DoIGetBonus
    {
        public static string bonus_time(int salary, bool bonus)
        {

           return bonus ? $"${(salary * 10)}" : $"${salary}";
        }
    }
}
