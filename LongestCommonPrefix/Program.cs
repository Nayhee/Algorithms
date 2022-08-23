using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string LongestCommonPrefix(string[] strs)
            {

                if (strs.Length == 0)
                {
                    return "";
                }

                string prefix = strs[0]; //prefix starts out as full first word. 

                for (int i = 1; i < strs.Length; i++)
                {
                    while (strs[i].IndexOf(prefix) != 0)
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1); //reduces prefix by last letter. 
                        if (string.IsNullOrEmpty(prefix))
                        {
                            return "";
                        }
                    }
                }
                return prefix;

            }
            var words = new string[] { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(words));
        }
    }
}
