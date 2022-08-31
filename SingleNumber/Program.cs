using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int SingleNumber(int[] nums) 
            {
                Dictionary<int, int> dt = new Dictionary<int, int>();
                int singleNum = 0;
                int keyValue = 1;

                for(int i=0; i<nums.Length; i++)
                {
                    if (dt.ContainsKey(nums[i]))
                    {
                        dt[nums[i]] = keyValue + 1;
                    }
                    else
                    {
                        dt.Add(nums[i], keyValue);
                    }
                }
                foreach(var item in dt)
                {
                    if(item.Value == 1)
                    {
                        singleNum = item.Key;
                    }
                }
                return singleNum;
            }
            var nums = new int[] { 4, 1, 2, 1, 2 };
            Console.WriteLine(SingleNumber(nums));
        }
    }
}
