using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Fizz_Buzz
    {
        public static string[] GetFizzBuzzArray(int n)
        {
            List<string> fizzBuzz = new List<string>();

            if (n < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
                for (int i = 1; i <= n; i++)
                {
                    string results = "";

                    if (i % 15 == 0)
                    {
                        results = "FizzBuzz";
                    }
                    else if (i % 3 == 0)
                    {
                        results = "Fizz";
                    }
                    else if (i % 5 == 0)
                    {
                        results = results + "Buzz";
                    }
                    else
                    {
                        results = i.ToString();
                    }

                    fizzBuzz.Add(results);
                }
            return fizzBuzz.ToArray();
        }
    }
}


