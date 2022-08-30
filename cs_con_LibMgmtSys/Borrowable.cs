using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    /// <summary>
    ///     The Concrete Decorator
    /// </summary>
    public class Borrowable
    {
        private LibraryItem libraryItem;

        private System.Collections.ArrayList borrowers;


        public int ItemID
        {
            get
            {
                return this.libraryItem.LibraryItemId;
            }
        }

        public LibraryItem LibraryItem
        {
            get
            {
                return this.LibraryItem;
            }
        }

        public Borrowable(LibraryItem item)
        {
            this.libraryItem = item;
            this.borrowers = new System.Collections.ArrayList();        // Early Instantaition Pattern
        }

        public void BorrowItem(string memberName)
        {
            this.borrowers.Add(memberName);
            this.libraryItem.NumberOfCopies--;
        }

        public void ReturnItem(string memberName)
        {
            this.borrowers.Remove(memberName);
            this.libraryItem.NumberOfCopies++;
        }

        public override string ToString()
        {
            string output = this.libraryItem.ToString();
            if (this.borrowers.Count != 0)
            {
                output += "\n\tList of Borrowers:";
                foreach (string membername in this.borrowers)
                {
                    output += $"\n\t{membername}";
                }
            }
            return output;
        }
    }
}