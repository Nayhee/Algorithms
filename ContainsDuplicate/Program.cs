using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ContainsDuplicate(int[] nums)
            {
                HashSet<int> uniqueNums = new HashSet<int>();

                foreach(int num in nums)
                {
                    if (uniqueNums.Contains(num)) return false;
                    else uniqueNums.Add(num);
                }
                return true;
            }

            var nums = new int[6] { 1, 3, 3, 5, 6, 7 };
            Console.WriteLine(ContainsDuplicate(nums));
        }
    }
}
