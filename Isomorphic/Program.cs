using System;

namespace Isomorphic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsIsomorphic(string s, string t)
            {
                Dictionary<char, char> StoT = new Dictionary<char, char>();
                Dictionary<char, char> TtoS = new Dictionary<char, char>();

                for (int i = 0; i < s.Length; i++)
                {
                    char c1 = s[i];
                    char c2 = t[i];

                    if (!StoT.ContainsKey(c1) && !TtoS.ContainsKey(c2))
                    {
                        StoT[c1] = c2;
                        TtoS[c2] = c1;
                    }

                    if (!(StoT[c1] == c2 && TtoS[c2] == c1))
                    {
                        return false;
                    }
                }
                return true;
            }

            string s = "badc";
            string t = "baba";

            Console.WriteLine(IsIsomorphic(s, t));
        }
    }
}
