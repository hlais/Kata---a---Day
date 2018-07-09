using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Cat : Animal
    {
        string name;
        public Cat(string name) : base(name)
        {
            this.name = name;
        }

        public override string Speak()
        {
            return name + " meows.";
        }
    }
}
