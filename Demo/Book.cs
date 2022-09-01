using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Demo
{
    class Book : IComparable
    {
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


        public string BookName;
        public int BookPrice;
        public int BookCount;
        public int x;

        public Book(string booktitle, int bookprice, int bookCount, int totalbooks)
        {

            BookName = booktitle;
            BookPrice = bookprice;
            BookCount = bookCount;
            x = totalbooks;
        }



        #region System.IComparable members
        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }
            else
            {
                Book empOther = obj as Book;
                return this.BookName.CompareTo(BookName);      // ASC order of EmployeeID
                                                               // return empOther.EmployeeID.CompareTo(this.EmployeeID);   // DESC order of EmployeeID
            }
        }

        #endregion

        public override string ToString()
        {
            return $"{BookId,-20} {BookName,-20} {BookPrice,-20:C} {BookCount,-10} {x,-20}";
        }


    }
}
