using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class God
    {
        public static Human[] Create()
        {
            Man man = new Man();
            Woman woman = new Woman();

            Human[] humans = new Human[] { man, woman };
            return humans;
        }
    }
    public class Human
    {

    }
    public class Man : Human
    {
    }
    public class Woman : Human
    {
    }
}
