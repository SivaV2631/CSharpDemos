using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop objShop = new Shop("GROCERY SHOP");


            objShop.AddProduct(new Product { ProductID = 1, ProductName = "Rice", Quantity = 2, Price = 1000 });
            objShop.AddProduct(new Product { ProductID = 2, ProductName = "Wheat", Quantity = 2, Price = 100 });
            objShop.AddProduct(new Product { ProductID = 3, ProductName = "Sugar", Quantity = 1, Price = 150 });
            objShop.AddProduct(new Product { ProductID = 4, ProductName = "Cooking Oil", Quantity = 1, Price = 200 });
            objShop.AddProduct(new Product { ProductID = 5, ProductName = "Vegetables", Quantity = 5, Price = 500 });

            objShop.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("--- Iterating through the Aggregated Collection using IEnumerator members");
            Console.WriteLine($"{"ProductID",-20}{"ProductName",-20}{"Quantity",-20}{"Price",-20}");
            objShop.Reset();
            while (objShop.MoveNext())
            {
                Product emp = objShop.Current as Product;
                Console.WriteLine($"{emp.ProductID,-20} {emp.ProductName,-20} {emp.Quantity,-20} {emp.Price,-20}");
            }
            Console.WriteLine();


            Product ProductThird = objShop[3];          // idToFind == 3
            if (ProductThird != null)
            {
                Console.WriteLine($"ID and Name of the searched Product: {ProductThird.ProductID} {ProductThird.ProductName}");
            }
            else
            {
                Console.WriteLine("Sorry!  Did not find the product");
            }
            Console.WriteLine();


            System.Collections.ArrayList proFound = objShop["Sugar"];
            if (proFound != null || proFound.Count != 0)
            {
                Console.WriteLine("ProductName of Product: Sugar");
                foreach (Product emp in proFound)
                {
                    Console.WriteLine($"{emp.ProductID,-20} {emp.ProductName,-20} {emp.Quantity,-20} {emp.Price,-20}");
                }
            }
            else
            {
                Console.WriteLine("No Products were found in the name of Sugar");
            }
        }
    }
}