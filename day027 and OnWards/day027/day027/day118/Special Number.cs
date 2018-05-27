using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Special_Number
    {
        public static string SpecialNumber(int number)
        {
            int[] numbersArry = Array.ConvertAll(number.ToString().ToCharArray(), x => Convert.ToInt32(x) - 48);

            for (int i = 0; i < numbersArry.Length; i++)
            {
                if (numbersArry[i] > 5)
                {
                    return "NOT!!";
                }
            }
            return "Special!!";
        }
    }
}
