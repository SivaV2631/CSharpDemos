using System;

namespace OddEvenDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check Odd or Even!");

            int i;

            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());      //user input

            
            if (i % 2 == 0)
            {
                Console.Write(i + " is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write(i + " is an Odd Number");
                Console.Read();
            }
        }
    }
}
