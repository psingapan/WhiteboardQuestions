using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 11, 7, 2, 15 };
            int target = 9;
            TwoSum(nums, target);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            //Time & space complexity is O(n).

            //Use a dictionary to append and track the current index position for each time we pass through an element. 
            Dictionary<int, int> mydic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                //cur is a marker to keep track of the current value that we pass over. We are looking for x which
                //equates to the target minus the current value of nums[i].
                int current = nums[i];
                int x = target - current;

                //search through the dictionary for the key of (x) which is the value of nums[i] and (value) i= index.
                //if not found, then we append the current value of nums[i] as the key, and value of i as index position.
                if(mydic.ContainsKey(x))
                {
                    Console.WriteLine("{0}, {1}", mydic[x], i );
                    return new int[] { mydic[x], i };
                }
                    
                mydic.Add(current, i);
            }
            return null;
        }
    }
}
