using System;
using System.Collections.Generic;

namespace HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsHappy(int n)
            {

                HashSet<int> seen = new HashSet<int>();
                while (n != 1 && !seen.Contains(n))
                {
                    seen.Add(n);
                    n = getNext(n);
                }
                return n == 1;
            }

            int getNext(int n)
            {
                int totalSum = 0;

                while (n > 0)
                {
                    int d = n % 10;
                    n = n / 10;
                    totalSum += d * d;
                }
                return totalSum;
            }

            int n = 19;
            Console.WriteLine(IsHappy(n));
        }
    }
}
