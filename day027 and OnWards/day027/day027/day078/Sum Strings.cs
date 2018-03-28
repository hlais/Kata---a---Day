using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace CodeWars4Kata
{
    class Sum_Strings
    {
        public static string SumStrings(string a, string b)
        {
            BigInteger number1;
            BigInteger number2;

            BigInteger.TryParse(a, out number1);
            BigInteger.TryParse(b, out number2);
            
            BigInteger sum;
            sum = number1 + number2;


            

            return sum.ToString();

           
        }


    }
}
