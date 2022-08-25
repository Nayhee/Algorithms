using System;
using System.Collections.Generic;
using System.Linq;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RansomNote(string ransomNote, string magazine)
            {

                Dictionary<char, int> table = new Dictionary<char, int>();

                foreach(char c in ransomNote)
                {
                    if(table.ContainsKey(c))
                    {
                        table[c]++;
                    }
                    else
                    {
                        table.Add(c, 1);
                    }
                }

                foreach(char c in magazine)
                {
                    if(table.ContainsKey(c))
                    {
                        table[c]--;
                    }
                }

                foreach(char key in table.Keys)
                {
                    if (table[key] > 0)
                    {
                        return false;
                    }
                }
                return true;

            }

            string ransomNote = "aa";
            string magazine = "ab";
            Console.WriteLine(RansomNote(ransomNote, magazine));
        }
    }
}
