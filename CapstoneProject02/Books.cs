using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace CapstoneProject02
{
    public class Book : IComparable
    {
        public List<Book> BooksList;

        private static int BookIdCounter;


        static Book()
        {
            Book.BookIdCounter = 0;
        }

        public Book()
        {
            this._BookId = ++Book.BookIdCounter;
        }

        private int _BookId;
        public int BookId
        {
            get
            {
                return _BookId;
            }
        }

        public string BookTitle { get; set; }
        public string BookCategory { get; set; }
        public int BookPrice { get; set; }
        public string BookStatus { get; set; }
        public int BookCount;
        public Book(string booktitle, string bookcategory, int bookprice, string bookstatus, int bookCount)
        {

            BookTitle = booktitle;
            BookCategory = bookcategory;
            BookPrice = bookprice;
            BookStatus = bookstatus;
            BookCount = bookCount;
        }

        //public delegate void BookDel(Book book);

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
                Book empOther = obj as Book;
                return this.BookTitle.CompareTo(BookTitle);      // ASC order of EmployeeID
                                                                 // return empOther.EmployeeID.CompareTo(this.EmployeeID);   // DESC order of EmployeeID
            }
        }

        #endregion

        public override string ToString()
        {
            return $"{BookId,-20} {BookTitle,-20} {BookCategory,-20} {BookPrice,-20:C} {BookStatus,-20} {BookCount,-10}";
        }
    }

}

