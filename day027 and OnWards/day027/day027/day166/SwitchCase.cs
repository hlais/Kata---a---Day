using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class SwitchCase
    {
        double result = 0;
            switch (operation)
            {
                case '+':

                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '/':
                    result = value1 / value2;
                    break;
                case '*':
                    result = value1 * value2;
                    break;
                case '%':
                    result = value1 % value2;
                    break;
                case '^':
                    result = Math.Pow(value1, value2);
                    break;
            }
            return result;
    }
}
