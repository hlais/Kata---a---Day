using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Simple_Pig_Latin
    {
        public static string PigIt(string str)
        {
            string[] wordCollection = str.Split(' ');
            List<string> pigItList = new List<string>();
            string returnedpigListString = "";

            foreach (var word in wordCollection)
            {
                
                string remainingLetters = "";
                string firstLetter = "";
                string newWord = "";
                for (int letter = 0; letter < word.Length; letter++)
                {
                    if (word.Length == 0)
                    {
                        break;
                    }
                        
                   if (letter == 0)
                    {
                       firstLetter = word[0].ToString() + "ay";
                       
                    }
                    else
                    {
                         remainingLetters += word[letter].ToString();
                    } 
                }

                newWord += remainingLetters + firstLetter;
                pigItList.Add(newWord);
            }

            foreach (var item in pigItList)
            {
                returnedpigListString += item + " ";
            }

            return returnedpigListString.Trim();
        }
    }
}
