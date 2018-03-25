using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Parse_and_Count
    {
        public static int PaC(string str)
        {
            DataTable mathOperatorsAccepted = new DataTable();
            int numberIndex = 0;
            char[] starChar = str.ToCharArray();

            //search for the character sequence
            for (int i = 0; i < starChar.Length; i++)
            {
                if (starChar[i] == 'e' && starChar[i + 1] == 'r' && starChar[i + 2] == ':')
                {   
                    //store index
                    numberIndex = i + 4;
                    break;
                }

            }
            //remove unwated chars
            string sorted = str.Substring(numberIndex);
            //calucate 
            int answer = (int)mathOperatorsAccepted.Compute(sorted, "");
            return answer;
        }
    }
}
