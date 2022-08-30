using System;
namespace AsTypeCastingDemo
{
    class A { }
    class B { }

    class Demo
    {

        static void Main()
        {

            // creating and initializing object array
            object[] o = new object[5];
            o[0] = new A();
            o[1] = new B();
            o[2] = "Hello";
            o[3] = 4759.0;
            o[4] = null;

            for (int q = 0; q < o.Length; ++q)
            {

                // using as operator
                string str1 = o[q] as string;

                Console.Write("{0}:", q);

                // checking for the result
                if (str1 != null)
                {
                    Console.WriteLine("'" + str1 + "'");
                }
                else
                {
                    Console.WriteLine("Is is not a string");
                }
            }
        }
    }
}