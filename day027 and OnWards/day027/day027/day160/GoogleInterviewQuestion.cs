using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWards7Kata
{
    class GoogleInterviewQuestion
    {
        public static string GetStrings(string city)
        {
            Dictionary<char, int> countingChars = new Dictionary<char, int>();
            city = city.ToLower().Replace(" ","");

            for (int i = 0; i < city.Length; i++)
            {
                int tempCounter = 0;
                for (int j = 0; j < city.Length; j++)
                {
                   
                    if (city[i] == city[j])
                    {
                        tempCounter++;
                        
                    }
                    if (j == city.Length - 1)
                    {
                        if (!countingChars.ContainsKey(city[i]))
                        {
                            countingChars.Add(city[i], tempCounter);
                        }
                    }
                    
                }
                
            }
            return astricksGenerator(countingChars).Substring(0, astricksGenerator(countingChars).Length - 1);
        
        }
        public static string astricksGenerator(Dictionary<char, int> diction)
        {
            string empty = "";
            foreach (var item in diction)
            {   
                empty += $"{item.Key.ToString()}:";

                int astrikCounter = item.Value;
                while (astrikCounter > 0)
                {
                    empty += "*";
                    astrikCounter--;

                }               
                empty += ",";
            }

            return empty;
        }

    }
}

//INTRODUCTION:

//If I give you a name of a city as a string, I want you to return a string that shows how many times each letter shows up in the string by using an asterisk*

//SEE TEST CASE!

//As you can see for Chicago, in the return string, I only show the letter "c" once even though there are 2 "c" in Chicago(regardless of upper or lowercase).

//I show 2 asteriks since there are 2 "c" in Chicago.

//In the return string there are no spaces between the letters, asteriks, and commas.

//GetStrings("Chicago") => "c:**,h:*,i:*,a:*,g:*,o:*"
//Note that the return string contains the characters in order of first appearence in the original string.

//HAVE FUN!! ;)

