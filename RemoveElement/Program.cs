using System;
using System.Linq;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4] { 3, 2, 1, 3 };
            int val = 3;
            Console.WriteLine($"The Answer is {RemoveElement(nums, val)}");
        }

        static int RemoveElement(int[] nums, int val)
        {
            var nonValueCount = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nonValueCount++;
                    nums[i] = 0;
                }
            }
         
            MoveFront(nums);
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
            return nonValueCount;
        }

        static void MoveFront(int[] arr)
        {
            int leftIndex = 0;
            int rightIndex = 1;

            while(rightIndex < arr.Length)
            {
                var left = arr[leftIndex];
                var right = arr[rightIndex];

                if (left == 0 && right != 0) 
                    Swap(arr, leftIndex++, rightIndex++);

                if (left != 0 && right == 0)
                {
                    leftIndex++;
                    rightIndex++;
                }

                if (left == 0 && right == 0)
                    rightIndex++;

                if(left != 0 && right != 0)
                {
                    rightIndex += 2;
                    leftIndex += 2;
                }

            }

        }

        static void Swap(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }


    }
}
