using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Arithmetic_Progression
    {
        public static int FindMissing(List<int> list)
        {
            int totalInList = list.Count;

            int missingNumber;
            List<int> listIncMissingNumber = new List<int>();
            int startValue = list[0];
            int firstDifference = list[1] - list[0];
            int secondDifference = list[totalInList-1] - list[totalInList- 2];
            listIncMissingNumber.Add(startValue);

            //to find the bigger difference. As the smaller difference is correct!
            if ( firstDifference > secondDifference)
            {
                listIncMissingNumber.Add(startValue);

                for (int i = 1; i < list.Count + 1; i++)
                {
                    listIncMissingNumber.Add(startValue += secondDifference);
                }
            }
            else
            {
                for (int i = 1; i < list.Count + 1; i++)
                {
                    listIncMissingNumber.Add(startValue += firstDifference);
                }
            }

            //compare the lists, removing duplicates
            foreach (var item in list)
            {
                if (listIncMissingNumber.Contains(item))
                {

                    listIncMissingNumber.RemoveAll(n => n == item);

                }
               
            }
            //last remining number 
            missingNumber = listIncMissingNumber[0];
            return missingNumber;

        
        }
        
    }
}
