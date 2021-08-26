using System;

class Program {
  public static void Main (string[] args) 
  {
    ReverseString("hello");
  }

  public static void ReverseString(string s)
  {
    //reversing a string requires traversing through the string.
    //strings are immutable so I would create a character array, and copy the elements backwards into the character array then turn it back to a string.
    char[] charArray= new char[s.Length];
    string reverse="";

    for(int i=s.Length-1;i>=0; i--)
    {
      charArray[i]=s[i];
      Console.WriteLine(charArray[i]);
      reverse += charArray[i];
    }

    Console.WriteLine(reverse);
  }
}