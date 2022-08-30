using System;
using System.Collections;

namespace ProductDemo
{
    internal class Program
    {
         public int ProductID;
        string ProductName;
        int Quantity;
        int Price;
        public static void Main(string[] args)
        {
            int ProductID;
            string ProductName;
            int Quantity;
            int Price;

            ArrayList Products = new ArrayList();     //declaration and instantation

            Console.Write("Enter no. of products to be entered : ");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine();

        




            Console.WriteLine($"{"ProductID"} \t {"ProductName"} \t {"Quantity"} \t {"Price"} \t");
            
            for (int i=0; i<no; i++)
            {
                string output = string.Format($"{ProductID,-20}\t  {ProductName,-20}\t {Quantity,-20}\t {Price,-20}\t");
                Console.WriteLine(output);
       
            }
            
        }
        static void GetProduct()
        {

            int ProductID;
            string ProductName;
            int Quantity;
            int Price;
            for (int i = 0; i < input; i++)
            {
                Console.Write("ProductID :");
                ProductID = int.Parse(Console.ReadLine());

                Console.Write("ProductName :");
                ProductName = Console.ReadLine();
                Console.Write("Quantity :");
                Quantity = int.Parse(Console.ReadLine());
                Console.Write("Price :");
                Price = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
        }
    }
}
