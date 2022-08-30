using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    public class Book1 : LibraryItem
    {
        public string BookTitle { get; private set; }
        public string[] Authors { get; private set; }

        public Book1(string title, int numCopies, string[] authors = null)
        {
            BookTitle = title;
            base.NumberOfCopies = numCopies;

            // -- Version 1
            //if(authors == null)
            //{
            //    Authors = new string[] { "Anonymous" };
            //}
            //else
            //{
            //    Authors = authors;
            //}

            // --- Version 2
            //Authors = (authors == null) 
            //          ? new string[] { "Anonymous" }
            //          : authors;

            // --- Version 3
            Authors = authors ?? new string[] { "Anonymous" };
        }

        public override string ToString()
        {
            return $"Book Title: {this.BookTitle}\n"
                   + $"Number of Copies: {base.NumberOfCopies}\n"
                   + $"Author(s): {string.Join(", ", this.Authors)}";
        }
    }
}