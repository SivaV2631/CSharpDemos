using System;

namespace TypeCastingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Casting Demo!");

            Console.Write("Enter int value :");
            int myInt = int.Parse(Console.ReadLine());

            Console.Write("Enter double value :");
            double myDouble = double.Parse(Console.ReadLine());

            bool myBool = true;

            double myDouble2 = myInt;       //implict type casting
            double a = myDouble2;

            string b = Convert.ToString(myInt);     //explicit type casting
            double c = Convert.ToDouble(myInt);
            int d = Convert.ToInt32(myDouble);
            string e = Convert.ToString(myBool);

            Console.WriteLine("int to double(implict) is : {0}, type = {1}", a, a.GetType());
            Console.WriteLine("int to string is : {0}, type = {1}" ,b, b.GetType() );    // Convert int to string
            Console.WriteLine("int to double is : {0}, type = {1}" , c, c.GetType());    // Convert int to double
            Console.WriteLine("double to int is : {0}, type = {1}", d, d.GetType());  // Convert double to int
            Console.WriteLine("bool to string is : {0}, type = {1}", e, e.GetType());   // Convert bool to string
        }
    }
    
}
