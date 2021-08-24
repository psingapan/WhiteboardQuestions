using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = new char[] {'a', 'b', 'c', 'd', 'e'};
            ReverseString(charArray);
        }

        public static void ReverseString(char[] s)
        {

            //reversing an array in place requires a starting point, an ending point, and a temp variable used to store values during swaps.
            int start = 0;
            int end = s.Length - 1;
            char temp;

            while (start < end)
            {
                // swapping the characters between start and ending values. Starting index increments as ending index
                // decrements until all values are swapped.
                temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;

            }


            
        }
    }

}
