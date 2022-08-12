using System;

namespace SwapDemo
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = 20;
            Console.WriteLine("Before swap a =" + a);
            Console.WriteLine("Before swap b =" + b);   
            a = a + b;  //a=10+20  a=30
            b = a - b;  //b=30-20  b=10
            a = a - b;  //a=30-10  a=20
            Console.WriteLine();
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadLine();
        }
    }
}
