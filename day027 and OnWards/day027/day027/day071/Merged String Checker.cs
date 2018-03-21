using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5Kata
{
    class Merged_String_Checker
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            if (s.Length != part1.Length + part2.Length)
            {
                return false;
            }
            if (s == string.Empty)
            {
                return true;
            }

            if (part1.Length > 0 && part1[0] == s[0])
            {
                if (isMerge(s.Substring(1), part1.Substring(1), part2))
                {
                    return true;
                }

            }
            if (part2.Length > 0 && part2[0] == s[0])
            {
                if (isMerge(s.Substring(1), part1, part2.Substring(1)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}


    

//foreach (var item in jointString)
//{
//    if (sChar.Contains(item))
//    {
//        sChar.Remove( item);
//    }
//}
//if (sChar.Count < 1)
//{
//    return true;
//}
//else return false;
///////////////////////
//string jointString = part1 + part2;
//List<char> jointCharList = new List<char>();
//string sSorted = "";
//string jointStringSorted = "";

//foreach (var item in jointString)
//{
//    jointCharList.Add(item);
//}
//jointCharList.Sort();

//List<char> sStringCharList = new List<char>();

//foreach (var item in s)
//{
//    sStringCharList.Add(item);
//}
//sStringCharList.Sort();

//foreach (var item in jointCharList)
//{
//    jointStringSorted += item.ToString();
//}

//foreach (var item in sStringCharList)
//{
//    sSorted += item.ToString();
//}

//if (jointStringSorted == sSorted)
//{
//    return true;
//}
//else return false;