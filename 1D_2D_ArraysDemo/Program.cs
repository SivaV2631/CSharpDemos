using System;
using System.Collections;
using System.Linq;

namespace ArraysDemo_1D_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("One Dimensional array!");
            int[] arr = new int[5];     //declaration and instantation
            arr[0]=10;
            arr[1]=20;
            arr[2]=30;
            arr[3]=40;   
            arr[4]=50;
            Console.WriteLine("printing 1D elements :");
            for (i=0; i<arr.Length; i++)
            {
                Console.WriteLine($"Elements are {i} : {arr[i]}");



            }
            Console.WriteLine();



            int[] arr2 = { 40, 10, 50, 20, 30 };            // size is inferred because of initialization values
            Console.WriteLine("Elements in arr2 :");
            foreach (int i2 in arr2)
            {
                Console.Write($"Elements are :{i2}");
                Console.WriteLine();
            }
            Console.WriteLine();
          



            Console.WriteLine("Two Dimensional array!");
            int[ , ] arr3 = new int[3,3];     //declaration and instantation
            arr3[0,0] = 10;                     //initialization
            arr3[0, 1] = 20;
            arr3[0, 2] = 30;
            arr3[1, 0] = 40;
            arr3[1, 1] = 50;
            arr3[1, 2] = 60;
            arr3[2, 0] = 70;
            arr3[2, 1] = 80;
            arr3[2, 2] = 90;

            Console.WriteLine("printing 2D elements :");
            foreach (int i3 in arr3)
            {
                Console.WriteLine($"Elements are  : {i3}");
                
            }
            Console.WriteLine();

        }
    }
}
