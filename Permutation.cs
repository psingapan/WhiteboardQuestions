//Problem 1: Given strings s1 & s2, write a function that returns a boolean value: true if the
//           strings are permutations of each other, false otherwise.
//Examples:

//IsPermutation("rats", "star") = true
//IsPermutation("rats", "tar") = false
//IsPermutation("rats", "stars") = false

//Video of me explaining this code https://youtu.be/bRm-jqU7Q1g

using System;

namespace TechInterviewPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Permute("ccma", "mmacc"));
        }

        public static bool Permute(string s1, string s2)
        {
            s1 = s1.ToLower(); //lowercase the values of the string before inserting into the array
            s2 = s2.ToLower();

            char[] charArrays1 = s1.ToCharArray(); Array.Sort(charArrays1);
            char[] charArrays2 = s2.ToCharArray(); Array.Sort(charArrays2);


            if (s1.Length != s2.Length) // if the length of both strings are not equal, return false because you cannot permutate.
                return false;
            
            for (int i = 0; i < charArrays1.Length && i < charArrays2.Length; i++) //iterating through the sorted arrays s1, s2 and comparing the values. If the characters are not equivalent, return false.
              {
                var char1 = charArrays1.GetValue(i);
                var char2 = charArrays2.GetValue(i);

                 if (!char1.Equals(char2))
                     return false;
              } return true;
        }
    }
}
    

                            
        
    



