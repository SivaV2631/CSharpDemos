using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace LambaDemo
{  
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Func<int,int,int> sum = (x,y) => x + y;
            Func<int,int,int> sub = (x,y) => x - y;
            Func<int,int,int> mul = (x,y) => x * y; 
            Func<int,int,int> div = (x,y) => x / y;
            Func<int,int> square = x => x * x;
          

            int a = 10;
            int b = 5;

            Console.WriteLine("Sum of {0} and {1} is = {2}",a,b, sum.Invoke(a,b));
            Console.WriteLine("Sub of {0} and {1} is = {2}", a, b, sub.Invoke(a, b));
            Console.WriteLine("mul of {0} and {1} is = {2}", a, b, mul.Invoke(a, b));
            Console.WriteLine("div of {0} and {1} is = {2}", a, b, div.Invoke(a, b));
            Console.WriteLine("square of {0}  is = {1}", a, square.Invoke(a));

        }
    }
}
