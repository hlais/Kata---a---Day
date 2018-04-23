using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class BuildTower
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] pyramid = new string[nFloors];
            int padding = nFloors - 1;

            for (int i = 0; i < nFloors; i++)
            {
                string sign = "";
                int pad = Math.Abs(padding - i);
                //left padding
                sign = sign.PadLeft(pad, ' ');
                for (int j = 0; j < i + i + 1; j++)
                {
                    sign += "*";
                }
                //right padding
                sign = sign.PadRight((sign.Length + pad), ' ');
                
                pyramid[i] = sign ;

            }
            return pyramid;
        }
    }
}
