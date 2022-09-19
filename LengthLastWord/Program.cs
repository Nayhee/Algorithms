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
                return words[words.Length - 1].Length;
            }
            string s = "Hello World";
            Console.WriteLine(LengthLastWord(s));
        }
    }
}
