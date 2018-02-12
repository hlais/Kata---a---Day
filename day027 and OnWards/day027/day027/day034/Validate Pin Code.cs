using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class Validate_Pin_Code
    {
        public static bool ValidateCode(string pin)
        {
            foreach (char c in pin)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
           

            if (pin.Length == 4 || pin.Length == 6)
                return true;
            return false;

        }
    }
}
