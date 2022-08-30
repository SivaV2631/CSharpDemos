using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomparableDemo
{
    internal class Shop : System.IComparable
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }



        #region System.IComparable members

        /// <summary>
        ///     Called during any Comparison or Sorting operations of the Employee Object
        /// </summary>
        /// <param name="obj">Object to compare against with the current object </param>
        /// <returns>
        ///     0           this    equal to      otherEmployee
        ///     -negative   this    lesser than   otherEmployee
        ///     +positive   this    greater than  otherEmployee OR otherEmployee == NULL
        /// </returns>
        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }
            else
            {
                Shop empOther = obj as Shop;
                return this.ProductName.CompareTo(empOther.ProductName);      // ASC order of EmployeeID
                // return empOther.EmployeeID.CompareTo(this.EmployeeID);   // DESC order of EmployeeID
            }
        }

        #endregion
    }
}