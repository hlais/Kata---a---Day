using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Delete_Nth_Occurrences
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            int occurence = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                occurence = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        occurence++;

                        if (occurence >= x)
                        {
                            arr[j] = -1;
                        }
                    }
                }
            }

            List<int> withExcess = new List<int>(arr);
            withExcess.RemoveAll(y => y == -1);

            return withExcess.ToArray();
        }
    }
}
