using System;

namespace cs_con_Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("GROCERY SHOP");

            int menu = -1;
            while (menu != 0)
            {
                Console.WriteLine("MENU for {0}", shop.ShopName);
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Display all products");
                Console.WriteLine("3. Remove a product");
                Console.WriteLine("4. Display all products sorted");
                Console.WriteLine("0  EXIT");
                Console.Write("Enter your choice: ");
                string menuInput = Console.ReadLine();
                int.TryParse(menuInput, out menu);

                switch (menu)
                {
                    case 0:
                        Console.WriteLine("--- Thank you");
                        break;
                    case 1:
                        shop.AddProduct();
                        break;
                    case 2:
                        Console.WriteLine();
                        shop.DisplayAllProducts();
                        break;
                    case 3:
                        shop.RemoveProduct();
                        break;
                    case 4:
                        shop.DisplayAllSortedProducts();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }   // while(true)
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--- Iterating through the Aggregated Collection using IEnumerable members");
            Console.WriteLine($"{"ProductId",-20} {"ProductName",-20} {"Quantity",-20} {"Price",-20}");
            foreach (Product emp in shop)
            {
                Console.WriteLine($"{emp.ProductId,-20} {emp.ProductName,-20} {emp.Quantity,-20} {emp.Price,-20}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--- Iterating through the Aggregated Collection using IEnumerator members");
            Console.WriteLine($"{"ProductId",-20} {"ProductName",-20} {"Quantity",-20} {"Price",-20}");
            shop.Reset();
            while (shop.MoveNext())
            {
                Product emp = shop.Current as Product;
                Console.WriteLine($"{emp.ProductId,-20} {emp.ProductName,-20} {emp.Quantity,-20} {emp.Price,-20}");

            }
            Console.WriteLine();
        }
    }
}
