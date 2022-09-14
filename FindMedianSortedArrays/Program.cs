using System;
using System.Collections.Generic;


namespace FindMedianSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the median value given 2 arrays

            double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {
                List<int> combined = new List<int>(); //initialize empty list so that we can add array items to list. 
                foreach (var num in nums1) //add nums1 to new list we initiated
                {
                    combined.Add(num);
                }
                foreach (var num in nums2) //add nums1 to new list we initiated
                {
                    combined.Add(num);
                };
                int[] allNums = combined.ToArray(); //turn the list into an Array. 
                Array.Sort(allNums); // sort the array. 

                int length = allNums.Length;
                double medianSpot = length / 2;
                int medianSpotInt = (int)Math.Floor(medianSpot);
                bool isEven = length % 2 == 0 ? true : false;

                if (isEven)
                {
                    int topValue = allNums[(int)medianSpot];
                    int bottomValue = allNums[(int)medianSpot - 1];
                    double answer = ((double)topValue + (double)bottomValue) / 2;
                    return answer;
                }
                else
                {
                    return allNums[medianSpotInt];
                }

            }
            int[] n1 = { 1, 2, 9, 12 };
            int[] n2 = { 4, 1 };

            Console.WriteLine($"The Answer is" + " " + FindMedianSortedArrays(n1, n2));
        }
    }
}
