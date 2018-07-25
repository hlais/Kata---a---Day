using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Switch
    {
        public static string SwitchItUp(int number)
        {
            string numberString = "";
            switch (number)
            {
                case 0:
                    numberString = "Zero";
                    break;

                case 1:
                    numberString = "One";
                    break;

                case 2:
                    numberString = "Two";
                    break;

                case 3:
                    numberString = "Three";
                    break;

                case 4:
                    numberString = "Four";
                    break;

                case 5:
                    numberString = "Five";
                    break;

                case 6:
                    numberString = "Six";
                    break;

                case 7:
                    numberString = "Seven";
                    break;

                case 8:
                    numberString = "Eight";
                    break;

                case 9:
                    numberString = "Nine";
                    break;
            }
            return numberString;
        }
    }
}
