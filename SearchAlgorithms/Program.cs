using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 12, 34, 89, 26 };
            int v = 9999;

            int resultIndex = LinearSearch(nums, v);

            int[] nums2 = new int[100000];
            for(int i = 0; i<nums2.Length; i++)
            {
                nums2[i] = i;
            }

            //BinarySearchAverage(nums2);
            foreach (int num in nums2)
            {
                Console.WriteLine(num);
                Console.Clear();
                LinearSearch(nums2, num);
            }
            Console.WriteLine("Linear Search done!");
        }

        public static void BinarySearchAverage(int[] nums)
        {
            int[] averages = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                averages[i] = BinarySearch(nums, 0, nums.Length, i, 0);
            }

            int result = AverageArray(averages);
            Console.WriteLine("The average Case is " + result);
        }

        public static int AverageArray(int[] nums)
        {
            int total = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }

            return total / nums.Length;
        }

        public static int BinarySearch(int[] nums, int min, int max, int key, int counter)
        {
            counter++;
           // Console.WriteLine();
            if(min > max)
            {
                //Console.WriteLine("Min was greater than max, cannot perform the binary search");
                return -1;
            }
            else
            {
                int mid = (max + min) / 2;

                int numsOut = nums[mid];

                if(numsOut == key)
                {
                    Console.WriteLine("The number was found!");
                    Console.WriteLine($"We ran {counter} number of times");
                    //return mid;
                    //Swapped for averaging
                    return counter;
                }
                else if(key < numsOut)
                {
                   // Console.WriteLine($"Key {key} is lower than {numsOut}");
                    //Console.WriteLine($"All ints higher than {mid} have been eliminated");
                    return BinarySearch(nums, min, mid - 1, key, counter);
                }
                else
                {
                    //Console.WriteLine($"Key {key} is higher than {numsOut}");
                    //Console.WriteLine($"All ints lower than {mid} have been eliminated");
                    return BinarySearch(nums, mid + 1, max, key, counter);
                }
            }

        }

        public static int LinearSearch(int[] nums, int value)
        {
            for(int i = 0; i <nums.Length; i++)
            {
               // Console.WriteLine($"Testing {i} index");
                int v = nums[i];
                if (v == value)
                {
                    //Console.WriteLine($"Value {value} found at index {i}");
                    return i;
                }
                else
                {
                   // Console.WriteLine($"Value {value} was not found at index {i}");
                }
            }
           // Console.WriteLine($"No value {value} was found");
            return -1; 
        }
    }
}
