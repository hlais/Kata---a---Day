using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Validate_Credit_Card_Number
    {
        public static bool Validate(string n)
        {
            int[] numbers= stringToNumberArray(n);
            //check if numbers are odd
            if (numbers.Length % 2 == 0)
            {
                for (int i = 0; i < numbers.Length; i+=2)
                {
                    numbers[i] = numbers[i] + numbers[i];
                }
            }
            else //else odd:
            {
                for (int i = 1; i < numbers.Length; i += 2)
                {
                    numbers[i] = numbers[i] + numbers[i];
                }
            }
            //make double digits, single
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 9)
                {
                    numbers[i] = (numbers[i] - 9);
                }
            }
            //sum elements in array. if even condition true;
            if (numbers.Sum() % 10 == 0)
            {
                return true;
            }
            else return
                    false;
           
        }
        private static int[] stringToNumberArray(string n)
        {
            string nSpaceRemoved = n.Replace(" ", "");//remove spaces
            int[] nArraryIntSpaceRemov = new int[nSpaceRemoved.Length];
            int index = 0;
            foreach (var item in nSpaceRemoved)
            {
                int temp = (int)char.GetNumericValue(item);
                nArraryIntSpaceRemov[index] = temp;
                index++;
            }
            return nArraryIntSpaceRemov;
        }
    }
}
//1714 ==> [1*, 7, 1*, 4] ==> [2, 7, 2, 4]

//12345 ==> [1, 2*, 3, 4*, 5] ==> [1, 4, 3, 8, 5]

//891 ==> [8, 9*, 1] ==> [8, 18, 1]
//If a resulting number is greater than 9, replace it with the sum of its own digits(which is the same as subtracting 9 from it) :

//[8, 18*, 1] ==> [8, (1 + 8), 1] ==> [8, 9, 1]

//or:

//[8, 18*, 1] ==> [8, (18 - 9), 1] ==> [8, 9, 1]
//Sum all of the final digits:

//[8, 9, 1] ==> 8 + 9 + 1 = 18