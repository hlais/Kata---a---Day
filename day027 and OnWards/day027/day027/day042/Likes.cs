using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Likes
    {
        public static string WhoLikesThis(string[] name)
        {

            string empty = "";

            if (name.Length == 0)
            {
                empty = "no one likes this";
                return empty;

            }
            if (name.Length == 1)
            {
                empty = string.Format(name[0] += " likes this");
                return empty;

            }
            if (name.Length == 2)
            {
                empty = string.Format(name[0] + " and " + name[1] + " like this");
                return empty;
            }
            if (name.Length == 3)
            {
                empty = string.Format(name[0] + ", " + name[1] + " and " + name[2] + " like this");
                return empty;
            }
            if (name.Length >= 4)
            {
                empty = string.Format(name[0] + ", " + name[1] + " and " + "{0}", (name.Length - 2).ToString() + " others like this");
                return empty;

            }
            return empty;

        }
    }
}
