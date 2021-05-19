using System;

namespace SortingAandD
{
     class Program
     {
         static void Main(string[] args)
         {
             int i, j;
             int[] a = new int[20];
             for (i = 0; i < 5; i++)
             {
                 Console.WriteLine("enter the num" + " " + (i + 1) + ":");
                 a[i] = Convert.ToInt16(Console.ReadLine());
             }
             for (i = 0; i < 5; i++)
             {
                 for (j = 0; j < 4; j++)
                 {
                     if (a[j] > a[j + 1])

                     {
                         int temp = a[j + 1];
                         a[j + 1] = a[j];
                         a[j] = temp;
                     }
                 }
             }
             Console.WriteLine("Ascending Sort:");
             for (i = 0; i < 5; i++)
             {
                 Console.WriteLine(a[i] + "");
             }
             Console.ReadKey();
         }
     }

 
}

