using System;

namespace IShapeDemo
{
    public interface Shape
    {
        public abstract double area();
        public abstract double perimeter();
    }
    public class Circle : Shape
    {
        private double radius;
        public double pi = 3.14;

        public Circle(double r)
        {
            radius = r;
        }
        public double area()
        {
            return (pi * radius * radius);
        }

        public  double perimeter()
        {
            return (2 * pi * radius);
        }
    }


    public class Square : Shape
    {
        private double A;
        public double pi = 3.14;

        public Square(double a)
        {
            A = a;
        }
        public  double area()
        {
            return (A * A);
        }

        public double perimeter()
        {
            return (4 * A);
        }
    }

    public class Rectangle : Shape
    {
        private double H;
        private double B;

        public double pi = 3.14;

        public Rectangle(double a, double b)
        {
            H = a;
            B = b;
        }
        public double area()
        {
            return (H * B);
        }

        public double perimeter()
        {
            return (2 * (H + B));
        }
    }

    public class Triangle : Shape
    {
        private double H;
        private double B;
        private double A;


        public double pi = 3.14;

        public Triangle(double a, double b, double c)
        {
            H = a;
            B = b;
            A = c;
        }
        public double area()
        {
            return ( (H * B)/2);     // 1/2*H*B
        }

        public double perimeter()
        {
            return (A + A + B);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of Shapes Using Interface");
            Console.WriteLine();

            Circle obj = new Circle(6.0);
            Console.WriteLine($"Area of Circle = {obj.area()}");
            Console.WriteLine($"Perimeter of Circle = {obj.perimeter()}");
            Console.WriteLine();

            Square obj1 = new Square(7.0);
            Console.WriteLine($"Area of Square= {obj1.area()}");
            Console.WriteLine($"Perimeter of Square = {obj1.perimeter()}");
            Console.WriteLine();

            Rectangle obj2 = new Rectangle(8.0, 8.0);
            Console.WriteLine($"Area of Rectangle = {obj2.area()}");
            Console.WriteLine($"Perimeter of Rectangle = {obj2.perimeter()}");
            Console.WriteLine();

            Triangle obj3 = new Triangle(8.0, 8.0, 8.0);
            Console.WriteLine($"Area of Triangle = {obj3.area()}");
            Console.WriteLine($"Perimeter of Triangle = {obj3.perimeter()}");
            Console.WriteLine();
        }
    }
}
