using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    class Hero
    {

        string Name { get; set; }
        string Position { get; set; }
        float Health { get; set; }
        float Damage { get; set; }
        int Experience { get; set; }

        public Hero()
        {
            Name = "Hero";
            Position = "00";
            Health = 100;
            Damage = 5;
            Experience = 0;
        }
        public Hero(string name)
        {
            Name = name;
            Position = "00";
            Health = 100;
            Damage = 5;
            Experience = 0;

        }
    }    
}
          
        

    

    

