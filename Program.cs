using System;

namespace Anagram_Detection
{
    public class Kata
    {
        public static void Main(string[] args)
        {
            Tests.checkTest(true, IsAnagram("dumble", "bumble"));
        }
        public static bool IsAnagram(string test, string original)
        {
            // your code goes here
            original = original.ToLower();
            test = test.ToLower();
            int Count = 0;
            char[] originalChar = original.ToCharArray();
            char[] testChar = test.ToCharArray();
            if (test.Length == original.Length)
            {
                for (int i = 0; i < originalChar.Length; i++)
                {
                    if (original.Contains(testChar[i]))
                    {
                        Count++;
                    }
                }
            } else return false;
            if (originalChar.Length == Count) return true;
            else return false;
        }
    }

    public class Tests
    {
        public static void checkTest(bool a, bool b) 
        {
            if (a == b) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}
