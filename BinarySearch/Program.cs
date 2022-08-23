using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            static object BinarySearch(int[] inputArray, int key)
            {
                //get a min and max index number. 
                int min = 0;
                int max = inputArray.Length - 1;

                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    if (key == inputArray[mid])
                    {
                        return mid;
                    }
                    else if (key < inputArray[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                return "Nil";

            }

            var inputArr = new int[6] { 1, 3, 4, 5, 8, 9 };
            var inputKey = 1;

            Console.WriteLine(BinarySearch(inputArr, inputKey));
        }
    }
}
