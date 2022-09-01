using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace CP2
{

    public class Librarian
    {
        //Aggregated Collection of Objects
        //private ArrayList BooksList = new ArrayList();
        //private ArrayList CustomersList = new ArrayList();
        //private List<Book> bl;

        List<Book> BooksList = new List<Book>();
        List<Customer> CustomersList = new List<Customer>();
       // public int CCount;
        public int BookCount;




        public void LibrarianMenu()
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
                Console.WriteLine("6. borrow Book");
                Console.WriteLine("7. return book");    
                Console.WriteLine("0.  EXIT");
                Console.WriteLine("--------------------------------------------------");

                Console.Write("Enter your choice: ");
                string menuInput = Console.ReadLine();
                int.TryParse(menuInput, out menuL);


                //Book book = new Book();
                Customer customer = new Customer();
                Librarian librarian = new Librarian();

                switch (menuL)
                {
                    case 0:
                        Console.WriteLine("--- Thank you");
                        break;
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        RemoveBook();
                        break;
                    case 3:
                        DisplayBooksList();
                        break;
                    case 4:
                        SearchBook();
                        break;
                    case 5:
                        DisplayCustomerList();
                        break;
                    case 6:
                        BorrowBook();
                        break;
                    case 7:
                        ReturnBook();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }

        public void CustomerMenu()
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

                //Book book = new Book();
                Customer customer = new Customer();
                Librarian librarian1 = new Librarian();
                List<Book> librarianList = new List<Book>();
                List<Customer> customerList1 = new List<Customer>();
                switch (menuC)
                {
                    case 0:
                        Console.WriteLine("--- Thank you");
                        break;
                    case 1:
                        librarian1.BorrowBook();
                        break;
                    case 2:
                        librarian1.ReturnBook();
                        break;
                    case 3:
                        librarian1.DisplayBooksList();
                        break;
                    case 4:
                        librarian1.SearchBook();
                        break;
                    case 5:
                        librarian1.DisplayCustomerList();
                        break;
                    case 6:
                        librarian1.AddBook();
                        break;
                    case 7:
                        librarian1.RemoveBook();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }

        }


        // Aggregated Collection of Objects
        //public ArrayList BooksList = new ArrayList();
        //private ArrayList CustomersList = new ArrayList();




        public void AddBook()
        {

            Book addbook = new Book();

            Console.WriteLine();
            Console.WriteLine("Enter the details of the Book");
            Console.Write("Enter Book Title : ");
            addbook.BookTitle = Console.ReadLine();
            
            Console.Write("BookPrice : ");
            addbook.BookPrice = int.Parse(Console.ReadLine());
            Console.Write("Enter total books : ");
            addbook.x = int.Parse(Console.ReadLine());
            addbook.BookCount = this.BooksList.Count + 1;
           
            this.BooksList.Add(addbook);                         // boxing

        
            Console.WriteLine();
            Console.WriteLine($"Added {addbook.BookTitle} Book Sucessfully....");

        }
        public void RemoveBook()
        {
            Console.WriteLine("Enter the ID  of Book to remove:");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < BooksList.Count; i++)
            {
                Book b = this.BooksList[i] as Book;        // unboxing
                if (b.BookId == id)
                {
                    this.BooksList.Remove(b);
                    BookCount = BooksList.Count -1;
                    Console.WriteLine();
                    Console.WriteLine($" Removed Book of ID = {id} Sucessfully....");
                    break;          // exit the for loop
                }

            }

        }
        public void DisplayBooksList()
        {
            Console.WriteLine("List of Books in Library :");

            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4, -20} ", "BookID", "Book Title", "Book Price", "Book Count","Total books added");

            foreach (Book b in this.BooksList)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();

        }
        public void SearchBook()
        {
            Book book = new Book();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (this.BooksList.Exists(x => x.BookId == find))
            {
                foreach (Book searchId in this.BooksList)
                {
                    if (searchId.BookId == find)
                    {
                        Console.WriteLine("Book id : {0}\n" +
                        "Book name : {1}\n" +
                        "Book price : {2}\n" +
                        "Book Count : {3}\n" + 
                        "Total Books Available: {4}", searchId.BookId, searchId.BookTitle, searchId.BookPrice, searchId.BookCount,searchId.x);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }
       

        //-------------------------------------//

        public void DisplayCustomerList()
        {

            Console.WriteLine("List of Customers :");

            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4, -15} {5,-20} {6,-20}", "CustomerID", "Customer Name", "Customer Details", "Issued Date", "Returned Date", "BorrowBookID", "CustomerCount");

            foreach (Customer b in this.CustomersList)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();

        }
        public  void BorrowBook()
        {
            Book book = new Book();
            Customer borrow = new Customer();
            Console.WriteLine("Customer Id :" + borrow.CustomerId);
            Console.Write("Enter CustomerName :");

            borrow.CustomerName = Console.ReadLine();

            Console.Write("Enter Book id  to borrow:");
            borrow.BorrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Books to Borrow : ");
            borrow.BorrowCount = int.Parse(Console.ReadLine());
            Console.Write("Enter Customer Address :");
            borrow.CustomerDetails = Console.ReadLine();

            borrow.IssuedDateTime = DateTime.Now;
            borrow.ReturnedDateTime = DateTime.Now;
            Console.WriteLine("IssuedDateTime - {0} ", borrow.IssuedDateTime.ToString("26/07/2000 11:02:G"));
            Console.WriteLine("ReturnedDateTime - {0} ", borrow.IssuedDateTime.ToString("MM/dd/yyyy hh:mm tt"));
            if (this.BooksList.Any(x => x.BookId == borrow.BorrowBookId))
            {
                foreach (Book searchId in this.BooksList)
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
                        Console.WriteLine("Book(s)  borrowed Sucessfully", searchId.BookCount);
                        book.x = book.x - borrow.BorrowCount;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.BorrowBookId);
            }
            CustomersList.Add(borrow);
        }

        public  void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter following details :");

            Console.Write("Enter Book id to Return : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Books to Return:");
            int returnCount = int.Parse(Console.ReadLine());

            if (this.BooksList.Any(y => y.BookId == returnId))
            {
                foreach (Book addReturnBookCount in this.BooksList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.BookCount)
                    {
                        if (addReturnBookCount.BookId == returnId)
                        {
                            addReturnBookCount.BookCount = addReturnBookCount.BookCount + returnCount;
                            Console.WriteLine($"Book(s) of ID = {returnId} returned sucessfully");
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


    }


}


