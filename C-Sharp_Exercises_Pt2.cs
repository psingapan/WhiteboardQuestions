using System;

namespace ExercisesPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveA("abcd");
            RightDigits(new int[] { 10,22,35,41});
            HashTags(new string[] { "1", "2", "3", "4" });
        }

        //Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string
        static string RemoveA(string d)
        {
            string b = "";
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == 'a')
                    continue;
                b += d[i];
            }
            Console.WriteLine(b);
            return b;
        }

        //Write a C# Sharp program to create a new list of the rightmost digits from a given list of positive integers
        static int[] RightDigits(int[] arr)
        {
            int[] newarr = new int[arr.Length];
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i]%10;
                newarr[i] = result;
                result /= 10;

            }
            foreach (var item in newarr)
            {
                Console.WriteLine(item + " ");
            }
            return newarr;
        }

        //Write a C# Sharp program to create a new list from a given list of strings where each element
        //has "#" added at the beginning and end position.
        static string[] HashTags(string[] list)
        {
          string[] list2 = new string[list.Length*2];
            for (int i = 0; i < list.Length; i++)
            {
                list2[i]=list[i] + "#";
                Console.WriteLine(list2[i]);
            }
            return list2;
        }
    }
}
