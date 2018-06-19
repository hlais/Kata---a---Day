using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CodeWars3Kata
{
    class Calculator
    {
        public static double Evaluate(string expression)
        {
            string answer = new DataTable().Compute(expression, null).ToString();
           return Convert.ToDouble(answer);
        }
    }
}
