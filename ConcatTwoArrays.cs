//Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n(0 - indexed).
//Specifically, ans is the concatenation of two nums arrays.
//Return the array ans.

//Example 1:

//Input: nums = [1, 2, 1]
//Output: [1, 2, 1, 1, 2, 1]
//Explanation: The array ans is formed as follows:
//-ans = [nums[0], nums[1], nums[2], nums[0], nums[1], nums[2]]
//- ans = [1, 2, 1, 1, 2, 1]
//Example 2:

//Input: nums = [1, 3, 2, 1]
//Output: [1,3,2,1,1,3,2,1]
//Explanation: The array ans is formed as follows:
//-ans = [nums[0], nums[1], nums[2], nums[3], nums[0], nums[1], nums[2], nums[3]]
//- ans = [1, 3, 2, 1, 1, 3, 2, 1]

//Constraints:

//n == nums.length
//1 <= n <= 1000
//1 <= nums[i] <= 1000

using System;

namespace ConcatTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //int[] num1 = new int[] { 1,2,3,4 }; //1st test case
            //ConcatenationArray(num1);

            //int[] num2 = new int[] { 1, 2, 1}; //2nd test case
            //ConcatenationArray(num2);

            int[] num3 = new int[] { 1, 3, 2, 1 }; //3rd test case
            ConcatenationArray(num3);

        }
      
        public static int[] ConcatenationArray(int[] numbers) //taking in an array, and outputting an extra array and the sum of those two arrays.
        {

            //assigning n length of array to declare a new array with the doubled given length.
            int n = 2 * (numbers.Length);
            int[] ans = new int[n];
            int index = n/2;


            if (1 <= n && n <= 1000 && n != numbers.Length) //constraints
            {
                for (int i = 0; i < numbers.Length; i++) //iterating through the array and copying into the new array. since memory is already allocated,
                                                         //we can insert the values starting from the beginning half of the new array.
                {
                    ans[i] = numbers[i];
                    ans[index] = numbers[i];
                    Console.Write(ans[i]);
                   
                }
                
                for (int i = 0; i < numbers.Length; i++) //broke this into two separate for loops to print out sum of two arrays together in the same order.
                {
                    ans[index] = numbers[i];
                    Console.Write(ans[index]);
                    
                }
            }
            return ans;
        }
    }
}
