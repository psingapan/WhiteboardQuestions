using System;
using System.Text;

namespace ShuffleString
{
    class Program
    {
        static void Main(string[] args)
        {
            //driver code
            string ss = "Hello";
            int[] array1 = new int[] { 3, 1, 2, 0, 4 };
            RestoreString(ss, array1);
            
        }
            public static void RestoreString(string s, int[] indices)
            {
                //initialize a new character array to store characters of string
                char[] charArray=new char[indices.Length];

                for (int i = 0; i < indices.Length; i++)
                {

                //the new charArray at index position[i] of indices is = to string position[i]
                charArray[indices[i]] = s[i];
                }
            Console.WriteLine(new string(charArray));
            }
        
    }
}
