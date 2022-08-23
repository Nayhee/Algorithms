using System;

namespace PivotIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int PivotIndex(int[] nums)
            {
                int totalSum = 0;
                int currentSum = 0;

                //calculate the total sum. 
                foreach (int i in nums)
                {
                    totalSum += i;
                };

                //loop through each num and check if the currentSum = totalSum - currentSum - the current number
                //if it is, return that index number.
                // if its NOT, add the current number to the currentSum
                for (int i = 0; i < nums.Length; i++)
                {
                    if (currentSum == totalSum - currentSum - nums[i])
                    {
                        return i;
                    }
                    currentSum += nums[i];
                }
                //if it never equaled, return -1.
                return -1;
            }
            var nums = new int[3] { 2, 1, -1 };
            Console.WriteLine(PivotIndex(nums));
        }
    }
}
