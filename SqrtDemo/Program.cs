using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrtDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, a1, a2;
            Console.WriteLine("Sqrt using pass by value!");
            a = 4;
            Console.WriteLine("Before calling the method :" + a);
            passbyvalue(a);
            Console.WriteLine("after calling the method :" + a);
            Console.WriteLine();

            Console.WriteLine("Sqrt using pass by reference!");
            a1 = 36;
            Console.WriteLine("Before calling the method :" + a1);
            passbyref(ref a1);
            Console.WriteLine("after calling the method :" + a1);
            Console.WriteLine();

            Console.WriteLine("Sqrt using pass by out!");
            a2 = 49;
            Console.WriteLine("Before calling the method :" + a2);
            passbyout(out a2);
            Console.WriteLine("after calling the method :" + a2);
            Console.WriteLine();


        }

        public static void passbyvalue(double b)
        {
            b = Math.Sqrt(b);
            Console.WriteLine("variable value inside method(sqrt) :" + b);
        }

        public static void passbyref(ref double b1)
        {
            b1 = 36;   //intialize the ref method variable
            b1 = Math.Sqrt(b1);
            Console.WriteLine("variable value inside method(sqrt) :" + b1);
        }

        public static void passbyout(out double b2)
        {
            b2 = 49;   //intialize the out method variable(without it shows error)
            b2 = Math.Sqrt(b2);
            Console.WriteLine("variable value inside method(sqrt) :" + b2);
        }
    }
}
