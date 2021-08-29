using System;
using System.Collections;

class Program 
{
  public static void Main (string[] args) 
  {

    //Selection sort- find smallest element in unsorted array.
     int[] a= new int[] {5,1,8,1,3,7,2,8,10,9};
     
     for(int i=0; i<a.Length; i++)
     {
       int small=i;
      
       for (int j=i+1; j<a.Length;j++)
       {
         if(a[j]<a[small])
         {
          small=j;
         }
       }

       // swapping the smallest element with current position and continue to traverse through the array.
        int temp= a[small];
        a[small]=a[i];
        a[i]=temp;
        Console.WriteLine(a[i]+ " ");
     }
  }
}








