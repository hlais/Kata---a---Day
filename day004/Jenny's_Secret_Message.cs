using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Jenny_s_Secret_Message
    {
        public static string greet(string name)
        {
            string greeting = "";
            {

                greeting = "Hello, " + name + "!";

                if (name == "Johnny")
                {
                    greeting = "Hello, my love!";
                }
                return greeting;

            }
        }
    }
}

   
