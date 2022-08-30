using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Assignment01
{
    internal struct Product
    {
        public int ProductId;
        public string ProductName;
        public int Quantity;
        public decimal Price;

        public override string ToString()
        {
            return $"{ProductId,-20} {ProductName,-20} {Quantity,-20} {Price,-20:C}";
        }
    }
}