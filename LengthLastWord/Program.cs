using System;
using System.Collections.Generic;
using System.Linq;

namespace LengthLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int LengthLastWord(string s)
            {
                string[] words = s.Split(' ');
                if (words.Length == 1) return words[0].Length;

                int answer = 0;
                int lastIndex = words.Length-1;

                while(answer == 0)
                {
                    var currentWord = words[lastIndex];
                    if (!currentWord.StartsWith(" ") && !currentWord.EndsWith(" "))
                    {
                        answer = currentWord.Trim().Length;
                    }
                    lastIndex--;
                }
                return answer;
            }
            string s = "day";
            Console.WriteLine(LengthLastWord(s));
        }
    }
}
