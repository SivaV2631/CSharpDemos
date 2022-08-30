using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorDemo
{
    internal class Shop : System.Collections.IEnumerator
    {
        private System.Collections.ArrayList _products;
        public string ShopName { get; private set; }


        #region System.Collections.IEnumerator members

        private int _currentPosition;

        public object Current
        {
            get
            {
                return _products[_currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (_currentPosition < _products.Count - 1)
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


        public Shop(string shopname)
        {
            this.ShopName = shopname;
            this._products = new System.Collections.ArrayList();
        }

        public System.Collections.ArrayList this[string ProductName]
        {
            get
            {
                System.Collections.ArrayList productFoundCollection = new System.Collections.ArrayList();

                foreach (Product emp in _products)
                {
                    if (emp.ProductName == ProductName)
                    {
                        productFoundCollection.Add(emp);
                    }
                }

                return productFoundCollection;
            }
        }


        public Product this[int findID]
        {
            get
            {
                Product ProductFound = null;

                foreach (Product pro in this._products)
                {
                    if (pro.ProductID == findID)
                    {
                        ProductFound = pro;
                        break;          // no need to continue searching for the product
                    }
                }

                return ProductFound;
            }
        }

        public void AddProduct(Product newProduct)
        {
            this._products.Add(newProduct);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"List of Employees in : {this.ShopName}");
            Console.WriteLine($"{"ProductID",-20}\t {"ProductName",-20}\t {"Quantity",-20}\t {"Price",-20}");
            foreach (Product emp in this._products)
            {
                Console.WriteLine($"{emp.ProductID,-20} {emp.ProductName,-20} {emp.Quantity,-20} {emp.Price,-20}");
            }
        }
    }
}