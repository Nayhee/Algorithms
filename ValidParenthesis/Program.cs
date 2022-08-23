using System;

namespace ValidParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsValid(string s)
            {
                int n = -1;
                while (s.Length != n)
                {
                    n = s.Length;
                    s = s.Replace("()", "");
                    s = s.Replace("{}", "");
                    s = s.Replace("[]", "");
                }
                if (s.Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            string words = "((";
            Console.WriteLine(IsValid(words));
        }
    }
}
