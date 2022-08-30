using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    internal class Shop : System.Collections.IEnumerable
    {

        private System.Collections.ArrayList _products;
        public string ShopName { get; private set; }

        #region System.Collections.IEnumerable members

        public System.Collections.IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _products.Count; i++)
            {
                yield return _products[i];
            }

            // --- SAME AS ABOVE
            //foreach(Employee emp in this._employees)
            //{
            //    yield return emp;
            //}
        }

        #endregion

        public Shop(string shopname)
        {
            this.ShopName = shopname;
            this._products = new System.Collections.ArrayList();
        }

        public void AddProduct(Product newProduct)
        {
            this._products.Add(newProduct);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"List of Products in : {this.ShopName}");
            Console.WriteLine($"{"ProductID",-20}{"ProductName",-20}{"Quantity",-20}{"Price",-20}");
            foreach (Product emp in this._products)
            {
                Console.WriteLine($"{emp.ProductID,-20} {emp.ProductName,-20} {emp.Quantity,-20} {emp.Price,-20}");
            }
        }

    }
}
