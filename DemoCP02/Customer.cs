using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DemoCP02
{

    class Customer : IEnumerable
    {
       public List<Customer> CustomersList = new List<Customer>(); 
        private static int CustomerIdCounter;
        private static int Counter;

      

      





        static Customer()
        {
            Customer.CustomerIdCounter = 0;
            
            Customer.Counter = 0;
            
        }
        public Customer()
        {
            this._CustomerId = ++Customer.CustomerIdCounter;
            this._BorrowBookId = ++Counter;
            


        }
        

        private int _CustomerId;
        public int CustomerId
        {
            get
            {
                return _CustomerId;
            }
        }

        public string CustomerName { get; set; }
        public string CustomerDetails { get; set; }
        public DateTime IssuedDateTime { get; set; }
        public DateTime ReturnedDateTime { get; set; }
        private int _BorrowBookId;
        public int BorrowBookId
        {
            get { return _BorrowBookId; }
        }
        public int CCount;
       
       

       

        #region System.Collections.IEnumerable members

        public System.Collections.IEnumerator GetEnumerator()
        {

            for (int i = 0; i < CustomersList.Count; i++)
            {
                yield return CustomersList[i];
            }

            // --- SAME AS ABOVE
            //foreach(Employee emp in this._employees)
            //{
            //    yield return emp;
            //}
        }

        #endregion







        public Customer(string customername, string customerdetails, DateTime issueddatetime, DateTime dt,int ccount)
        {
            CustomerName = customername;
            CustomerDetails = customerdetails;
            issueddatetime = DateTime.Now;
            IssuedDateTime = issueddatetime;
            dt = DateTime.Now;
            ReturnedDateTime = dt;
            CCount = ccount;

            
            
           




        }

        public override string ToString()
        {
            DateTime dt = DateTime.Now;
            return $"{CustomerId,-20} {CustomerName,-20} {CustomerDetails,-20} {IssuedDateTime.ToString("MM/dd/yyyy hh:mm tt"),-20:C} {ReturnedDateTime.ToString("MM/dd/yyyy hh:mm tt"),-20} {BorrowBookId,-10} {CCount,-10} ";

        }





        public void CustomerMenu()
        {

            int menuC = -1;
            while (menuC != 0)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("MENU for Customer");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1.Add a book");
                Console.WriteLine("2.Remove a book");
                Console.WriteLine("3. Display  Books List");
                Console.WriteLine("4. Search for Book");
                Console.WriteLine("5. Borrow Book from Librarian");
                Console.WriteLine("6. Return Book to Librarian");
                Console.WriteLine("0  EXIT");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Enter your choice: ");
                string menuInput = Console.ReadLine();
                int.TryParse(menuInput, out menuC);

                switch (menuC)
                {
                    case 0:
                        Console.WriteLine("--- Thank you");
                        break;
                    case 1:
                        List<Book> BooksList = new List<Book>();
                        Librarian lib = new Librarian();
                        lib.AddBook(BooksList);
                        break;
                    case 2:
                        Librarian libr = new Librarian();
                        libr.RemoveBook();
                        break;
                    case 3:
                        Book book = new Book();
                        Librarian librarian = new Librarian();
                        librarian.DisplayBooksList();
                        break;
                    case 4:
                        Librarian librarian1 = new Librarian();
                        librarian1.SearchBook();
                        break;
                    case 5:
                        Librarian librarian2 = new Librarian();
                        librarian2.BorrowBook();
                        break;
                    case 6:
                        Librarian librarian3 = new Librarian();
                        librarian3.ReturnBook();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }

        }

    }
}
