using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Are_You_Playing_Banjo
    {
        public static string AreYouPlayingBanjo(string name)
        {
            return name.ToUpper().Substring(0,1) == "R" ? name + " plays banjo" : name + " does not play banjo";
       
        }
    }
}
