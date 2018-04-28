using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodeWars5Kata
{
    class PhoneDirectory
    {
        public static string Phone(string strng, string num)
        {
           List <string> collectionsOfAddress = new List<string> (strng.Split('\n'));
            int count = 0;
            string foundNumber = "";
            string name = "";
            
            for (int i = 0; i < collectionsOfAddress.Count; i++)
            {
                if (collectionsOfAddress[i].Contains(num))
                {
                    count++;
                    foundNumber = collectionsOfAddress[i];
                }
            }

            if (count > 1)
            {
                return $"Error => Too many people: {num}";
            }
            if (count == 0)
            {
                return $"Error => Not found: {num}";
            }

            int start = foundNumber.IndexOf('<')+1;
            int end = foundNumber.IndexOf('>');
            int length = end - start;

            name = foundNumber.Substring(start, length);
           
            Regex charactersToRemove = new Regex("[*:;?/$<>+!,]");
            string address = charactersToRemove.Replace(foundNumber, "").Replace(name, "").Replace(num, "").Replace("_"," ").Replace("  ", " ").Trim();

            string organised = $"Phone => {num}, Name => {name}, Address => {address}";
            return organised;

        }
    }
}
