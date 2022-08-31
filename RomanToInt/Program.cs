using System;
using System.Collections.Generic;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int RomanToInt(string s)
            {
                int iWk = 0;
                string strWk = s;
                if (strWk.Contains("IV"))
                {
                    iWk += 4;
                    strWk = strWk.Replace("IV", "");
                }

                if (strWk.Contains("IX"))
                {
                    iWk += 9;
                    strWk = strWk.Replace("IX", "");
                }

                if (strWk.Contains("XL"))
                {
                    iWk += 40;
                    strWk = strWk.Replace("XL", "");
                }

                if (strWk.Contains("XC"))
                {
                    iWk += 90;
                    strWk = strWk.Replace("XC", "");
                }

                if (strWk.Contains("CD"))
                {
                    iWk += 400;
                    strWk = strWk.Replace("CD", "");
                }

                if (strWk.Contains("CM"))
                {
                    iWk += 900;
                    strWk = strWk.Replace("CM", "");
                }

                char[] arr = strWk.ToCharArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    switch (arr[i].ToString())
                    {
                        case "I":
                            iWk += 1;
                            break;
                        case "V":
                            iWk += 5;
                            break;
                        case "X":
                            iWk += 10;
                            break;
                        case "L":
                            iWk += 50;
                            break;
                        case "C":
                            iWk += 100;
                            break;
                        case "D":
                            iWk += 500;
                            break;
                        case "M":
                            iWk += 1000;
                            break;
                    }
                }

                return iWk;
            }

            string s = "XLIV";
            Console.WriteLine(RomanToInt(s));
        }
    }
}
