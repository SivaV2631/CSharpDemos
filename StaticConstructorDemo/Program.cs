using System;

namespace StaticConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Constructor Demo");
            Console.WriteLine();

            Demo obj = new Demo();          //creating object of class Demo
            Console.WriteLine();

            Demo obj1 = new Demo();         //Creating another object of class Demo
        }

        class Demo
        {
            // Static Constructor
            static Demo()
            {
                Console.WriteLine("Welcome");
            }
            // Default Constructor
            public Demo()
            {
                Console.WriteLine("Hello world");
            }
        }

    }
}




