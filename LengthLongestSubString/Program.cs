using System;
using System.Collections.Generic;


namespace LengthLongestSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the longest substring that doesn't have a repeating character.
            int LengthOfLongestSubstring(string s)
            {

                Dictionary<char, int> seen = new Dictionary<char, int>();
                int maxLength = 0;
                int start = 0;

                for (int end = 0; end < s.Length; end++)
                {
                    if (seen.ContainsKey(s[end]))
                    {
                        start = Math.Max(start, seen[s[end]] + 1);
                    }

                    seen[s[end]] = end;
                    maxLength = Math.Max(maxLength, end - start + 1);
                }
                return maxLength;
            }

            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
        }
    }
}
