using System;
using System.Collections.Generic;

namespace Demo
{

    class Program
    {
        List<Book> bookList = new List<Book>();
        List<Borrow> borrowList = new List<Borrow>();
        public Book book = new Book();
        //public Borrow borrow = new Borrow();

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|\tLIBRARY MANAGEMENT SYSTEM\t|");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("-----------------------------------------------------");



            Console.Write("Enter User Name : ");
            string username = Console.ReadLine();
            Console.Write("Enter Password :");
            string password = Console.ReadLine();

            if (username == "siva" && password == "pass")
            {

                int menu = -1;
                while (menu != 0)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine(" \tMAIN MENU");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("1. To Go Librarian Menu ");
                    Console.WriteLine("2. To GO Customer Menu");
                    Console.WriteLine("0.  EXIT");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.Write("Enter your choice: ");
                    string menuInput = Console.ReadLine();
                    int.TryParse(menuInput, out menu);


                    switch (menu)
                    {
                        case 0:
                            Console.WriteLine("-----Thank You, Visit Again..------");
                            break;
                        case 1:
                            LibrarianMenu();
                            break;
                        case 2:
                            BorrowMenu();
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }
            Console.ReadLine();

            //-----------------------------------------------------------------------------------------------------

        }

        static void LibrarianMenu()
        {
            int menuL = -1;
            while (menuL != 0)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("\tMENU for Librarian");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1.  Add a Book  ");
                Console.WriteLine("2. Remove a Book ");
                Console.WriteLine("3.Display all Books");
                Console.WriteLine("4.Search Book");
                Console.WriteLine("5. Display Borrowers List");
                Console.WriteLine("0.  EXIT");
                Console.WriteLine("--------------------------------------------------");

                Console.Write("Enter your choice: ");
                string menuInput = Console.ReadLine();
                int.TryParse(menuInput, out menuL);



                Program p = new Program();
                switch (menuL)
                {
                    case 0:
                        Console.WriteLine("--- Thank you");
                        break;
                    case 1:

                        p.AddBook();
                        break;
                    case 2:
                        p.RemoveBook();
                        break;
                    case 3:
                        p.DisplayBooksList();
                        break;
                    case 4:
                        p.SearchBook();
                        break;
                    case 5:
                        p.DisplayBorrowersList();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }

        static void BorrowMenu()
        {

            int menuC = -1;
            while (menuC != 0)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("MENU for Borrower");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1. Borrow Book ");
                Console.WriteLine("2. Return Book ");
                Console.WriteLine("3. Display  Books List");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. Display Borrower List");
                Console.WriteLine("0  EXIT");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Enter your choice: ");
                string menuInput = Console.ReadLine();
                int.TryParse(menuInput, out menuC);

                Program p = new Program();
                switch (menuC)
                {
                    case 0:
                        Console.WriteLine("--- Thank you");
                        break;
                    case 1:
                        p.BorrowBook();
                        break;
                    case 2:
                        p.RemoveBook();
                        break;
                    case 3:
                        p.DisplayBooksList();
                        break;
                    case 4:
                        p.SearchBook();
                        break;
                    case 5:
                        p.DisplayBorrowersList();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }

        }
        public void AddBook()
        {
            Book addbook = new Book();

            Console.WriteLine();
            Console.WriteLine("Enter the details of the Book");
            Console.Write("Enter Book Title : ");
            addbook.BookName = Console.ReadLine();
            Console.Write("BookPrice : ");
            addbook.BookPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of books :");
            addbook.x = int.Parse(Console.ReadLine());
            addbook.BookCount = addbook.BookCount + 1;
            this.bookList.Add(addbook);                         // boxing

            Console.WriteLine();
            Console.WriteLine($"Added {addbook.BookName} Book Sucessfully....");
            Console.WriteLine("List of Books in Library :");

            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4, -20} ", "BookID", "BookName", "Book Price", "Book Count", "TotalBooksAdded");

            foreach (Book b in this.bookList)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();
        }

        //To delete book details from the Library database 
        public void RemoveBook()
        {

            Console.WriteLine("Enter the ID  of Book to remove:");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < bookList.Count; i++)
            {
                Book b = this.bookList[i] as Book;        // unboxing
                if (b.BookId == id)
                {
                    this.bookList.Remove(b);
                    Console.WriteLine();
                    Console.WriteLine($" Removed Book of ID = {id} Sucessfully....");
                    break;          // exit the for loop
                }

            }
        }
        public void DisplayBooksList()
        {

            Console.WriteLine("List of Books in Library :");

            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4, -20} ", "BookID", "BookName", "Book Price", "Book Count", "TotalBooksAdded");

            foreach (Book b in this.bookList)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();

        }

        //To search book details from the Library database using Book id 
        public void SearchBook()
        {
            Book book = new Book();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.BookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.BookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.BookId, searchId.BookName, searchId.BookPrice, searchId.BookCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        //To borrow book details from the Library
        public void BorrowBook()
        {
            Book book = new Book();
            Borrow borrow = new Borrow();

            Console.Write("Name :");

            borrow.UserName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.BorrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.BorrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.UserAddress = Console.ReadLine();
            borrow.BorrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.BorrowDate.ToShortDateString(), borrow.BorrowDate.ToShortTimeString());

            if (bookList.Exists(x => x.BookId == borrow.BorrowBookId))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.BookCount >= searchId.BookCount - borrow.BorrowCount && searchId.BookCount - borrow.BorrowCount >= 0)
                    {
                        if (searchId.BookId == borrow.BorrowBookId)
                        {
                            searchId.BookCount = searchId.BookCount - borrow.BorrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.BookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.BorrowBookId);
            }
            borrowList.Add(borrow);
        }

        //To return borrowed book to the library 
        public void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.BookId == returnId))
            {
                foreach (Book addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.BookCount)
                    {
                        if (addReturnBookCount.BookId == returnId)
                        {
                            addReturnBookCount.BookCount = addReturnBookCount.BookCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }

        public void DisplayBorrowersList()
        {

        }


    }
}