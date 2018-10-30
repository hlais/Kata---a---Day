using System;
class Kata
{
    public static int StrCount(string str, string letter)
    {
        int countOfMatchChars = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == Convert.ToChar(letter))
            {
                countOfMatchChars++;
            }
        }
        return countOfMatchChars;
    }
}