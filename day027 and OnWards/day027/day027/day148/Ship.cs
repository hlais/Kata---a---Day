using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Ship
    {
        public int Draft;
        public int Crew;
       

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Console.WriteLine(draft);
            Crew = crew;
            Console.WriteLine(crew);
        }

        public bool IsWorthIt()
        {
            return this.Draft - this.Crew * 1.5 >= 20;
            
        }

    }
}
