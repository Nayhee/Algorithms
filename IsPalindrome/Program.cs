using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
           bool IsPalindrome(string s)
            {
                s = s.ToLower(); //make lowercase
                s = Regex.Replace(s, "[^a-z0-9]", string.Empty); //replace all non alphanumeric characters
                char[] charArr = s.ToCharArray(); //convert to character array so we can reverse it. 
                Array.Reverse(charArr); //reverse it
                var reversedString = new string(charArr); //convert back to string.

                return s == reversedString ? true : false; //see if they the same. 
            }

            var s = "A man, a plan, a canal: Panama";
            Console.WriteLine(IsPalindrome(s));

        }
    }
}
