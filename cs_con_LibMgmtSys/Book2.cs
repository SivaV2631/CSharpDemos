using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    public class Book2 : LibraryItem
    {
        public string BookTitle { get; private set; }
        public string[] Authors { get; private set; }

        public Book2(
            int id, string title, int numCopies, params string[] authors)
        {
            base.LibraryItemId = id;
            base.NumberOfCopies = numCopies;

            this.BookTitle = title;

            this.Authors = (authors.Length == 0)
                           ? new string[] { "Anonymous" }
                           : authors;
        }

        public override string ToString()
        {
            return $"Library ITEM ID: {base.LibraryItemId}\n"
                   + $"Book Title: {this.BookTitle}\n"
                   + $"Number of Copies: {base.NumberOfCopies}\n"
                   + $"Author(s): {string.Join(", ", this.Authors)}";
        }
    }
}