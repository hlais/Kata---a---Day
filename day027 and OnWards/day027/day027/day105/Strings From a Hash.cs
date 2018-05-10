using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Strings_From_a_Hash
    {
        public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
        {
            string empty = "";

            if (hash.Count == 0 )
            {
                return empty;
            }

                foreach (var item in hash)
            {
                empty += $"{item.Key} = {item.Value},";
                empty.TrimEnd();
            }
            return empty.Substring(0, empty.Length - 1);
            
        }
    }
}
