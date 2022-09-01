using System;
using System.Collections.Generic;
using System.Linq;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int MajorityElement(int[] nums)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();

                foreach(int num in nums)
                {
                    if(dict.ContainsKey(num))
                    {
                        dict[num]++;
                    }
                    else
                    {
                        dict.Add(num, 1);
                    }
                }

                var maxValueKey = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                return maxValueKey;
            }

            var nums = new int[7] { 2, 2, 1, 1, 1, 2, 2, };
            Console.WriteLine(MajorityElement(nums));
        }
    }
}
