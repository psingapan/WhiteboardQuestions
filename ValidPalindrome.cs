using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "race a car";
            IsPalindrome(s);
        }
        public static Boolean IsPalindrome(string s)
        {
            //transform to character array. Remove all special characters and spaces
           
            s=s.ToLower();
            string b = "";
    
            //copy only letters and digit characters from string s onto string b.
            for (int i = s.Length-1; i >= 0; i--)
            {
                if (char.IsLetterOrDigit(s[i]))
                    b += s[i];
            }

            //check if each element from both ends are equivalent to each other.
            for (int i = 0, j=b.Length-1; i < b.Length; i++, j--)
            {
                if (b[i] != b[j])
                {
                    Console.WriteLine(false);
                    return false;
                }
            }
            Console.WriteLine(true);
            return true;
            

        }
        
    }
    
}
