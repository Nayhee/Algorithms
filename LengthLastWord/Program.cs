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

                int answer = 0;
                int lastIndex = words.Length-1;

                while(answer == 0 && lastIndex > 0)
                {
                    var currentWord = words[lastIndex];
                    if (!currentWord.Contains(" "))
                    {
                        answer = currentWord.Length;
                    }
                    lastIndex--;
                }
                return answer;
            }
            string s = "Hello World";
            Console.WriteLine(LengthLastWord(s));
        }
    }
}
