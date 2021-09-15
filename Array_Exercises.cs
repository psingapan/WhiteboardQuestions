using System;

namespace Array_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountDuplicates(new int[] { 5,1,1});
            PrintUnique(new int[] { 5, 1, 2, 1, 4, 3, 5, 2 });

        }

        //Write a program in C# Sharp to count a total number of duplicate elements in an array. 
        static int CountDuplicates(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1;  j < arr.Length;  j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
            }
            Console.WriteLine(count+ "end");
            return count;
        }

        //Write a program in C# Sharp to print all unique elements in an array.
        static void PrintUnique(int[] a)
        {
            int key = 0;

            for (int i = 0; i < a.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < a.Length; j++)
                {
                    if(a[i]==a[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                    Console.WriteLine(a[i]);
            }


        }

    }
}
