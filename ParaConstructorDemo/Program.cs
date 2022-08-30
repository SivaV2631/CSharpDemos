using System;

namespace ParaConstructorDemo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Demo for Parameterized Constructor and Constructor Overloading!");
            Console.WriteLine("\t");

            paraconstructor obj = new paraconstructor(10, 20);                     // Creating object of Parameterized Constructor and int values
            obj.show();                     //1st Constructor
            Console.WriteLine();

            paraconstructor obj1 = new paraconstructor("Thank " ,"you");                     // Creating object of Parameterized Constructor and int values
            obj1.show1();                     //1st Constructor
        }
        class paraconstructor
        {
            public int a, b;
            public string s,s1;
      
            public paraconstructor(int x, int y)     //first constructor    // declaring Paremetrized Constructor with int x,y parameter
            {
                a = x;
                b = y;
            }

            public paraconstructor(string x, string y)     //Second  constructor    // declaring Paremetrized Constructor with string x,y parameter
            {
                s = x;
                s1 = y;
            }

            public void show()                          // showing 1st constructor's result
            {
                Console.WriteLine("1st constructor (int + int): {0} " , ( a + b));
            }
            public void show1()                          // shows 2nd constructor's result
            {
             
                Console.WriteLine("2nd constructor (string + string): {0}",  (s + s1));
            }
        }
    }
}











