using System;

namespace ClimbStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int ClimbStairs(int n)
            {
                int first = 1;
                int second = 2;
                int temp = 0;

                for (int i = 3; i <= n; i++)
                {
                    temp = second;
                    second += first;
                    first = temp;
                }
                return second;
            }

            Console.WriteLine(ClimbStairs(5));
        }
    }
}
