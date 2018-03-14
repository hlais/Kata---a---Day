using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CodeWars5Kata
{

    class Palindrome_Chain_Length
    {

        public static int PalindromeChainLength(long n)
        {
            
            ProuducingPalidrome(n);
            bool isNotPalidrome = false;
            int attempt = 0;

            while (!isNotPalidrome)
            {
               isNotPalidrome = IsPalidromeOrNot(n);
                if (isNotPalidrome == true)
                {
                    break;
                }
                else
                {                    
                   attempt++;
                   n = ProuducingPalidrome(n) ;
                }
            }
            return attempt;
        }

        private static bool IsPalidromeOrNot(long n)
        {
            string original = n.ToString();
            string reversed = new string (original.ToCharArray().Reverse().ToArray());
            
            if (reversed == original)
            {
                return true;
            }
            else
                return false;

        }

        private static long ProuducingPalidrome(long n)
        {
            string reversed = new string(n.ToString().ToCharArray().Reverse().ToArray());   
            return n += Convert.ToInt64(reversed);
        }
    }
}

