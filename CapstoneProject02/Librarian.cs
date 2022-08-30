using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace CapstoneProject02
{

    public class Librarian
    {
        //Aggregated Collection of Objects
        //private ArrayList BooksList = new ArrayList();
        //private ArrayList CustomersList = new ArrayList();
        //private List<Book> bl;

        List<Book> BooksList = new List<Book>();
        List<Customer> CustomersList = new List<Customer>();
        public int CCount;
        public int BookCount;

       


        public void LibrarianMenu()
        {
            int menuL = -1;
            while (menuL != 0)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("\tMENU for Librarian");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1.  Add a Book to Library ");
                Console.WriteLine("2. Remove a Book from Library");
                Console.WriteLine("3.Display all Books");
                Console.WriteLine("4. Add a  new Customer ");
                Console.WriteLine("5. Remove a Customer ");
                Console.WriteLine("6. Display Customer List ");
                //Console.WriteLine("7. Issue Book to Customer ");
                Console.WriteLine("7. Return Book From Customer ");
                Console.WriteLine("8. Search Book");
                Console.WriteLine("0  EXIT");
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
                        AddCustomer();
                        break;
                    case 5:
                        RemoveCustomer();
                        break;
                    case 6:
                        DisplayCustomerList();
                        break;
                    case 7:
                        ReturnBook();
                        break;
                    case 8:
                        SearchBook();
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
            Console.Write("Enter Book Category : ");
            addbook.BookCategory = Console.ReadLine();
            Console.Write("BookPrice : ");
            addbook.BookPrice = int.Parse(Console.ReadLine());
            Console.Write("Book Status : ");
            addbook.BookStatus = (Console.ReadLine());


            this.BooksList.Add(addbook);                         // boxing

            addbook.BookCount = this.BooksList.Count;
            BookCount = BookCount + 1;
            Console.WriteLine("CCount :{0}", CCount);


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
                    BookCount = BookCount - 1;
                    Console.WriteLine();
                    Console.WriteLine($" Removed Book of ID = {id} Sucessfully....");
                    break;          // exit the for loop
                }

            }

        }
        public void DisplayBooksList()
        {
            Console.WriteLine("List of Books in Library :");

            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4, -20} {5,-20}", "BookID", "Book Title", "Book Category", "Book Price", "Book Status", "Book Count");

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

            if (BooksList.Exists(x => book.BookId == find))
            {
                foreach (Book searchId in BooksList)
                {
                    if (searchId.BookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book category:{2}\n" +
                        "Book price :{3}\n" +
                        "Book Status :{4}", searchId.BookId, searchId.BookTitle, searchId.BookCategory, searchId.BookPrice, searchId.BookStatus);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }
        public void IssueBook()
        {
            Book book = new Book();
            Customer issuebook = new Customer();

            Console.Write("Name :");

            issuebook.CustomerName = Console.ReadLine();


            Console.Write("Number of Books : ");
            issuebook.CCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            issuebook.CustomerDetails = Console.ReadLine();
            issuebook.IssuedDateTime = DateTime.Now;
            Console.WriteLine("Date and Time- {0}", issuebook.IssuedDateTime.ToString());
            issuebook.CCount = this.CustomersList.Count;

            Console.WriteLine("CCount :{0}", CCount);

            if (BooksList.Exists(x => x.BookId == issuebook.BorrowBookId))
            {
                foreach (Book searchId in BooksList)
                {
                    if (searchId.BookCount >= searchId.BookCount - issuebook.CCount && searchId.BookCount - issuebook.CCount >= 0)
                    {
                        if (searchId.BookId == issuebook.BorrowBookId)
                        {
                            searchId.BookCount = searchId.BookCount - issuebook.CCount;
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
                Console.WriteLine("Book id {0} not found", issuebook.BorrowBookId);
            }
            CustomersList.Add(issuebook);

        }



        //-------------------------------------//

        public void AddCustomer()
        {
            Customer addcustomer = new Customer();

            Console.WriteLine();
            Console.WriteLine("Enter the Customer details ");
            Console.Write("Enter Customer Name : ");
            addcustomer.CustomerName = Console.ReadLine();
            Console.Write("Enter Customer Details: ");
            addcustomer.CustomerDetails = Console.ReadLine();
            addcustomer.IssuedDateTime = DateTime.Now;
            addcustomer.ReturnedDateTime = DateTime.Now;
            //addcustomer.TotalBooksForCustomer = 4;
            this.CustomersList.Add(addcustomer);                         // boxing
            addcustomer.CCount = this.CustomersList.Count;
            CCount = CCount + 1;
            Console.WriteLine("CCount :{0}", CCount);



            Console.WriteLine();
            Console.WriteLine($"Added {addcustomer.CustomerName} named Customer Sucessfully....");

        }
        public void RemoveCustomer()
        {
            Console.WriteLine("Enter the ID  of Customer to remove:");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < CustomersList.Count; i++)
            {
                Customer b = this.CustomersList[i] as Customer;        // unboxing
                if (b.CustomerId == id)
                {
                    this.CustomersList.Remove(b);
                    CCount = CCount - 1;
                    Console.WriteLine();
                    Console.WriteLine($" Removed Customer of ID = {id} Sucessfully....");
                    break;          // exit the for loop
                }

            }

        }
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
        public void BorrowBook()
        {
            Book book = new Book();
            Customer addcustomer = new Customer();
            // Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            addcustomer.CustomerName = Console.ReadLine();

            Console.Write("Book id :");
            Console.WriteLine("Enter the Customer details ");
            Console.Write("Enter Customer Name : ");
            addcustomer.CustomerName = Console.ReadLine();
            Console.Write("Enter Customer Details: ");
            addcustomer.CustomerDetails = Console.ReadLine();
            addcustomer.IssuedDateTime = DateTime.Now;
            addcustomer.ReturnedDateTime = DateTime.Now;

            Console.Write("Number of Books : ");
            //addcustomer.CustomerCount = int.Parse(Console.ReadLine());


            Console.WriteLine("IssuedDateTime - {0} ", addcustomer.IssuedDateTime.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine("ReturnedDateTime - {0} ", addcustomer.IssuedDateTime.ToString("MM/dd/yyyy hh:mm tt"));
            var count = BooksList.Count;
            if (BooksList.Exists(x => x.BookId == addcustomer.BorrowBookId))
            {
                foreach (Book searchId in BooksList)
                {
                    if (searchId.BookCount >= searchId.BookCount - addcustomer.CCount && searchId.BookCount - addcustomer.CCount >= 0)
                    {
                        if (searchId.BookId == addcustomer.BorrowBookId)
                        {
                            //searchId.BookCount = searchId.bookCount - borrow.borrowCount;
                            this.CustomersList.Add(addcustomer);
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
                Console.WriteLine("Book id {0} not found", addcustomer.BorrowBookId);
            }
            CustomersList.Add(addcustomer);
        }

        public void ReturnBook()
        {
            Book book = new Book();
            Customer customer = new Customer();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (BooksList.Exists(y => y.BookId == returnId))
            {
                foreach (Book addReturnBookCount in BooksList)
                {

                    //if (addReturnBookCount.x >= returnCount + addReturnBookCount.BookCount)
                    // {
                    if (addReturnBookCount.BookId == returnId)
                    {
                        addReturnBookCount.BookCount = addReturnBookCount.BookCount + returnCount;
                        break;
                    }
                    // }
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


