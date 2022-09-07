using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDuplicatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] RemoveDuplicates(int[] nums)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();

                List<int> numsList = nums.ToList();

                for(int i = 0; i < nums.Length; i++)
                {
                    int key = nums[i];
                    if(dict.ContainsKey(nums[i]))
                    {
                        numsList.Remove(key);
                    }
                    else
                    {
                        dict.Add(key, 1);
                    }
                }

                var listLength = numsList.Count;

                int[] answer = numsList.ToArray();

                return answer;

            }

            int[] nums = new int[3] { 1, 1, 2};
            var result = RemoveDuplicates(nums);
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
