using System;

namespace ConsoleApp3
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            int n = nums.Length;
            int temp = 0;


            //nested forloop to traverse through the array twice to sort items that are smaller to the left and larger
            //to the right
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    //swapping the smaller with larger element in case that the larger is on the left.
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

        }
    }