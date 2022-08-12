using System;

namespace StringLenDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  empty String :");
            string empty = Console.ReadLine();
            Console.WriteLine(empty);
            Console.WriteLine("String Length = " + empty.Length);
        }
    }
}
