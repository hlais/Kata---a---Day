using System;


namespace CodeWards7Kata
{
    class AnagramDetection
    {
        public static bool IsAnagram(string test, string original)
        {
            Console.WriteLine(test,original);
            char[] charTest = test.ToLower().ToCharArray();
            Array.Sort<char>(charTest);
            char[] charOriginal = original.ToLower().ToCharArray();
            Array.Sort<char>(charOriginal);

            string testString = string.Join("", charTest);
            string originalString = string.Join("", charOriginal);

            return testString == originalString ? true : false;

        }
    }
}
