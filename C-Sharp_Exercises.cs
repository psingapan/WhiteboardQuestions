using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(51));
            // RemovingChar("Python", 1);
            // ExchangingChar("abcd");
            RemovingA("abc");
        }


        //Write a C# Sharp program to get the absolute difference between n and 51.
        //If n is greater than 51 return triple the absolute difference.
        static int Sum(int n)
        {
            return n > 51 ? Math.Abs((n - 51) * 3) :Math.Abs( n - 51);
        }

        //Write a C# Sharp program to remove the character in a given position of a given string.
        //The given position will be in the range 0.. string length -1 inclusive.
        static void RemovingChar (string s, int c)
        {
            string b = "";
            //c is character position
            for (int i = 0; i < s.Length; i++)
            {
                if (i == c)
                    continue;
                b += s[i];
            }
            Console.WriteLine(b);
        }

        //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
        static void ExchangingChar (string s)
        {
            int last = s.Length - 1;
            int first = 0;
            string b = "";

            if(s.Length>1)
            {
                b += s.Substring(last) + s.Substring(1, s.Length - 2) + s.Substring(0, 1);
            }
            Console.WriteLine(b);
        }

        // Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.
        // If the given string length is less than 2 return the original string.
        static string FourCopiesString(string s)
        {
            
            string b = "";
            int i = 0;
            if (s.Length < 2)
                return s;
            else
                return b+=s.Substring(0, 2) + s.Substring(0, 2)+ s.Substring(0, 2)+ s.Substring(0, 2);
        }

        //Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string.
        private static string RemoveA(string d)
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


    }
}
