using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class SpaceRemover
    {

        public static string NoSpace(string input)
        {
            String result = "";

            result = input.Replace(" ", "");

            return result;
        }
    }
}
