using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class PrinterErrors
    {
        public static string PrinterError(String s)
        {
            int totalCarts = 0;
            int brokenCarts = 0;
            foreach (var item in s)
            {
                Console.WriteLine((int)item);
                if (item > 109)
                {
                    brokenCarts++;
                }
                totalCarts++;
            }

           return string.Format($"{brokenCarts}/{totalCarts}");
        }
    }
}
