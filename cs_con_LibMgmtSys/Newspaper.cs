using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    internal class Newspaper : LibraryItem
    {
        public string Title { get; private set; }

        public DateTime PublishedOn { get; private set; }

        public Newspaper(int id, string title, DateTime publishedOn)
        {
            base.LibraryItemId = id;
            base.NumberOfCopies = 1;

            this.Title = title;
            this.PublishedOn = publishedOn;
        }

        public override string ToString()
        {
            return $"Library ITEM ID: {base.LibraryItemId}\n"
                  + $"Title: {this.Title} [ {this.PublishedOn.ToString("dd-MMM-yyyy")} ]\n"
                  + $"Number of Copies: {base.NumberOfCopies}";
        }
    }
}