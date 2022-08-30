using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomparableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop[] products =
            {
                new Shop() {
                    ProductID = 2,
                    ProductName = "Rice",
                    Quantity = "2",
                    Price = 200
                },
                new Shop() {
                    ProductID = 1,
                    ProductName = "Wheat",
                    Quantity = "2",
                    Price=500
                },
                new Shop() {
                    ProductID = 5,
                    ProductName = "Sugar",
                    Quantity = "2",
                    Price=100
                },
                new Shop() {
                    ProductID = 4,
                    ProductName = "cooking oil",
                    Quantity = "2",
                    Price=150
                },
                new Shop() {
                    ProductID = 3,
                    ProductName = "vegetables",
                    Quantity = "2",
                    Price=500
                },

            };
            Console.WriteLine("Before Sorting");
            Console.WriteLine($"{"ProductID",-20}{"ProductName",-20}{"Quantity",-20}{"Price",-20}");

            foreach (Shop emp in products)
            {
                Console.WriteLine($"{emp.ProductID,-20} {emp.ProductName,-20}\t{emp.Quantity,-20}\t{emp.Price,-20}");
            }
            Console.WriteLine();

            Array.Sort(products);          // interally calling CompareTo() method for each of the objects in the array

            Console.WriteLine("After sorting");
            Console.WriteLine($"{"ProductID",-20}{"ProductName",-20}{"Quantity",-20}{"Price",-20}");

            foreach (Shop emp in products)
            {
                Console.WriteLine($"{emp.ProductID,-20} {emp.ProductName,-20}\t{emp.Quantity,-20}\t{emp.Price,-20}");
            }
            Console.WriteLine();
        }
    }
}