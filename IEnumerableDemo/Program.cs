using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop objShop = new Shop("GROCERY SHOP");

            objShop.AddProduct(new Product { ProductID = 1, ProductName = "Rice", Quantity = 2, Price=1000 });
            objShop.AddProduct(new Product { ProductID = 2, ProductName = "Wheat", Quantity = 2, Price = 100});
            objShop.AddProduct(new Product { ProductID = 3, ProductName = "Sugar", Quantity = 1, Price = 150 });
            objShop.AddProduct(new Product { ProductID = 4, ProductName = "Cooking Oil", Quantity = 1, Price = 200 });
            objShop.AddProduct(new Product { ProductID = 5, ProductName = "Vegetables", Quantity = 5, Price = 500 });

            objShop.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("--- Iterating through the Aggregated Collection using IEnumerable members");
            Console.WriteLine($"{"ProductID",-20}{"ProductName",-20}{"Quantity",-20}{"Price",-20}");
            foreach (Product emp in objShop)
            {
                Console.WriteLine($"{emp.ProductID,-20} {emp.ProductName,-20} {emp.Quantity,-20} {emp.Price,-20}");
            }
        }
    }
}
