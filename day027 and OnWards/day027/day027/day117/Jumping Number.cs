 using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Jumping_Number
    {
        public static string JumpingNumber(int number)
        {
            int[] arrNumber = Array.ConvertAll(number.ToString().ToCharArray(), x => Convert.ToInt32(x) - 48);

            if (arrNumber.Length < 1)
            {
                return "Jumping!!";
            }

            for (int i = 1; i < arrNumber.Length; i++)
            {
                int previousNumber = arrNumber[i - 1];
                if (Math.Abs(previousNumber - arrNumber[i]) != 1)
                {
                    return "Not!!";
                }
            }
            return "Jumping!!";
        }
    }
}
