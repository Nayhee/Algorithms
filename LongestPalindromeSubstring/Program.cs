using System;

namespace LongestPalindromeSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string LongestPalindrome(string s)
            {
                int maxPalinLength = 0, startIndex = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    int start = i, end = i;

                    while (end < s.Length - 1 && s[start] == s[end + 1])
                    {
                        end++;
                    }

                    while (end < s.Length - 1 && start > 0 && s[start - 1] == s[end + 1])
                    {
                        start--;
                        end++;
                    }

                    if (maxPalinLength < end - start + 1)
                    {
                        maxPalinLength = end - start + 1;
                        startIndex = start;
                    }
                }
                return s.Substring(startIndex, maxPalinLength);
            }

            string input = "abac";
            Console.WriteLine(LongestPalindrome(input));
        }
    }
}
