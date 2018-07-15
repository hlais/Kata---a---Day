using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class DeadFish
    {
        public static int[] Parse(string data)
        {
            List<int> parsed = new List<int>();
            int dataNumber = 0;
            for (int i = 0; i < data.Length; i++)
            {
                
                switch (data[i])
                {
                    case 'i':
                        dataNumber++;
                        break;
                    case 's':
                        dataNumber = dataNumber * dataNumber;
                        break;
                    case 'o':
                        parsed.Add(dataNumber);
                        break;
                    case 'd':
                        dataNumber--;
                        break;

                    default:
                        break;
                }

            }
            return parsed.ToArray();
        }
    }
}
