using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace cs_con_LibMgmtSys
{
    internal class Library
        : System.Collections.IEnumerable
    {
        private int _idCounter;

        public string LibraryName { get; private set; }
        private List<Borrowable> borrowables;

        public Library(string name)
        {
            this.LibraryName = name;
            this.borrowables = null;                 // Late-Instantiation Pattern

            this._idCounter = 0;
        }

        public LibraryItem this[int itemId]
        {
            get
            {
                var itemToFind = this.borrowables.SingleOrDefault(i => i.ItemID == itemId);
                return itemToFind.LibraryItem;
            }
        }

        public void Add(Book2 book)
        {
            // safety check for Late-Instantiation Pattern
            if (borrowables == null)
            {
                borrowables = new List<Borrowable>();
            }
            book.LibraryItemId = ++_idCounter;
            borrowables.Add(new Borrowable(book));
        }

        public void Add(Newspaper newspaper)
        {
            // safety check for Late-Instantiation Pattern
            if (borrowables == null)
            {
                borrowables = new List<Borrowable>();
            }
            newspaper.LibraryItemId = ++_idCounter;
            borrowables.Add(new Borrowable(newspaper));
        }

        public void Borrow(int itemID, string membername)
        {
            //var query = (from item in this.borrowables
            //             where item.ItemID == itemID
            //             select item).SingleOrDefault();

            var itemToFind = this.borrowables.SingleOrDefault(i => i.ItemID == itemID);
            if (itemToFind != null)
            {
                itemToFind.BorrowItem(membername);
                Console.WriteLine($"Item [{itemID}] has been borrowed successfully by {membername}");
            }
            else
            {
                Console.WriteLine($"Item with ID = {itemID} was not found in the library!");
            }
        }

        public void Return(int itemID, string membername)
        {
            var itemToFind = this.borrowables.SingleOrDefault(i => i.ItemID == itemID);
            if (itemToFind != null)
            {
                itemToFind.ReturnItem(membername);
                Console.WriteLine($"Item [{itemID}] has been returned successfully by {membername}");
            }
            else
            {
                Console.WriteLine($"Item with ID = {itemID} was not found in the library!");
            }
        }


        #region System.Collections.IEnumerable members

        public IEnumerator GetEnumerator()
        {
            // safety check for Late-Instantiation Pattern
            if (borrowables == null)
            {
                yield break;
            }
            else
            {
                foreach (var item in this.borrowables)
                {
                    yield return item;
                }
            }
        }

        #endregion

        public void DisplayLibraryItems()
        {
            Console.WriteLine($"----- {this.LibraryName}");
            foreach (var item in this.borrowables)
            {
                Console.WriteLine(item);
                Console.WriteLine("=============");
            }
        }


    }
}