using System;

namespace ReadPrintArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo for read and print Array!");
            Console.WriteLine();

            int[] arr = new int[10];  //declare and instantiate array
            int i;

            Console.Write("Enter the no of elements to be entered in array :");
            int values = int.Parse(Console.ReadLine());

            for (i=0 ; i<values ; i++)
            {
                Console.Write($"Element {i} :");
                arr[i] = int.Parse(Console.ReadLine());           //initalization   //Reading elements into array
            }

            Console.WriteLine("Elements in the array :");
            for (i=0 ; i<values ; i++)
            {
                Console.Write($"Element {i} :" + arr[i] );      //printing elements
                Console.WriteLine();
            }
                
                








        }
    }
}
