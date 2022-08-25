using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            void Merge(int[] nums1, int m, int[] nums2, int n)
            {

                List<int> unsortedList = new List<int>();
                for(int i = 0; i < nums1.Length; i++)
                {

                    unsortedList.Add(nums1[i]);
                    unsortedList.Add(nums2[i]);
                };
                unsortedList.Sort();

                int[] finalArray = unsortedList.ToArray();




                //if(Array.IndexOf(nums1, 0) != -1)
                //{
                //    List<int> newList = nums2.ToList();
                //    for(int i = 0; i < nums1.Length; i++)
                //    {
                //        if (nums1[i] == 0)
                //        {
                //            nums1[i] = newList[0];
                //            newList.Remove(newList[0]);
                //        }
                //    }
                //    unsortedList = nums1.ToList();
                //}
                //if (Array.IndexOf(nums2, 0) != -1)
                //{
                //    List<int> newList = nums1.ToList();
                //    for(int i = 0; i < nums2.Length; i++)
                //    {
                //        if (nums2[i] == 0)
                //        {
                //            nums2[i] = newList[0];
                //            newList.Remove(newList[0]);
                //        }
                //    }
                //    unsortedList = nums2.ToList();
                //}

                //unsortedList.Sort();


                //foreach(int num in unsortedList)
                //{
                //    Console.WriteLine(num);
                //}

            }

            int[] nums1 = new int[6] {1, 2, 3, 0,0,0,};
            int[] nums2 = new int[3] {2, 5, 6};
            int m = nums1.Length;
            int n = nums2.Length;

            Merge(nums1, m, nums2, n);
        }
    }
}
