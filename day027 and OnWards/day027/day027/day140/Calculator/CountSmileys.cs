using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class CountSmileys
    {
        public static int SmileCount (string[] smileys)
        {   
            int count = 0;
            //varations of smileys
            List<string> smiles = new List<string> { ":D", ";D", ":-D", ";-D", ":~D", ";~D",
                                                      ":)",";)", ";-)", ":-)",":~)", ";~)" };
            
            for (int i = 0; i < smiles.Count; i++)
            {
                for (int j = 0; j < smileys.Length; j++)
                {   
                    // camparing smileys in Array with smiles List . 
                    if (smiles[i] == smileys[j])
                    {
                        count++;
                    }
                }
            }
            
            return count;
        }
    }
}
