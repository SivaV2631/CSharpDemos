using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace cs_con_Assignment03
{
    internal class Shop : IEnumerable, IEnumerator
    {
        // Aggregated Collection of Objects
        private ArrayList products;


        public string ShopName { get; private set; }




        #region System.Collections.IEnumerable members

        public System.Collections.IEnumerator GetEnumerator()
        {
            
            for (int i = 0; i < products.Count; i++)
            {
                yield return products[i];
            }

            // --- SAME AS ABOVE
            //foreach(Employee emp in this._employees)
            //{
            //    yield return emp;
            //}
        }

        #endregion


        #region System.Collections.IEnumerator members

        private int _currentPosition;

        public object Current
        {
            get
            {
                return products[_currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (_currentPosition < products.Count - 1)
            {
                _currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _currentPosition = -1;
        }

        #endregion

        public Shop(string name)
        {
            this.ShopName = name;
            products = new ArrayList();
        }

        public void AddProduct()
        {
            Product product = new Product();

            Console.WriteLine();
            Console.WriteLine("Enter the details of the Product");
            Console.Write("Product Name : ");
            product.ProductName = Console.ReadLine();
            Console.Write("Quantity : ");
            product.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Price : ");
            product.Price = decimal.Parse(Console.ReadLine());

            this.products.Add(product);                         // boxing
        }

        public void RemoveProduct()
        {
            this.DisplayAllProducts();
            Console.WriteLine("Enter the ID of the product to remove:");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < products.Count; i++)
            {
                Product p = this.products[i] as Product;        // unboxing
                if (p.ProductId == id)
                {
                    this.products.Remove(p);
                    break;          // exit the for loop
                }
            }

        }

        public void DisplayAllProducts()
        {
            Console.WriteLine();
            Console.WriteLine($"List of Products in {this.ShopName.ToUpper()}:");

            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4, -20}", "ProductID", "Product Name", "Qty", "Price", "Cost");

            foreach (Product p in this.products)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
           
        }

        public void DisplayAllSortedProducts()
        {
            Console.WriteLine();
            Console.WriteLine($"List of Products in {this.ShopName.ToUpper()}:");

            Console.WriteLine("---------------------Before Sorting---------------------------");
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4, -20}", "ProductID", "Product Name", "Qty", "Price", "Cost");

            foreach (Product p in this.products)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();


            products.Sort();


            Console.WriteLine("---------------------After Sorting---------------------------");
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4, -20}", "ProductID", "Product Name", "Qty", "Price", "Cost");

            foreach (Product p in this.products)
            {
                Console.WriteLine(p);
            }
        }

    }
}