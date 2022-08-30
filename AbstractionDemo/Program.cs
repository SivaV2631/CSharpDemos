using System;

namespace AbstractionDemo
{
    abstract class Shape         // abstract class
    {
        public abstract int area();          //abstract method
        // { Console.WriteLine("error"); }      //no body for abstract method
    }
    class Square : Shape        //Inheritance
    {
        //Shape obj = new Shape();

        private int side;       // private data member

        public Square(int x = 0)    // method of  square class
        {
            side = x;
        }

        public override int area()                      // overriding of the abstract method of Shape
                                                        // class using the override keyword
        {
            Console.Write("Area of Square: ");
            return (side * side );
        }
    }
    internal class Program
    {

        public static void Main(string[] args)
        {

            Shape sh = new Square(5);                // creating reference of Shape class
                                                    // which refer to Square class instance

           
            double result = sh.area();               // calling the method 

            Console.Write("{0}", result);

        }
    }
}