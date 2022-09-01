using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CP2
{

    class Customer : IEnumerable
    {
        public List<Customer> CustomersList = new List<Customer>();
        private static int CustomerIdCounter;


        static Customer()
        {
            Customer.CustomerIdCounter = 0;

          

        }
        public Customer()
        {
            this._CustomerId = ++Customer.CustomerIdCounter;


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
       
        public int BorrowBookId;
        public int BorrowCount;





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







        public Customer(string customername, string customerdetails, DateTime issueddatetime, DateTime dt, int borrowcount)
        {
            CustomerName = customername;
            CustomerDetails = customerdetails;
            issueddatetime = DateTime.Now;
            IssuedDateTime = issueddatetime;
            dt = DateTime.Now;
            ReturnedDateTime = dt;
            BorrowCount = borrowcount;








        }

        public override string ToString()
        {
            DateTime dt = DateTime.Now;
            return $"{CustomerId,-20} {CustomerName,-20} {CustomerDetails,-20} {IssuedDateTime.ToString("MM/dd/yyyy hh:mm tt"),-20:C} {ReturnedDateTime.ToString("MM/dd/yyyy hh:mm tt"),-20} {BorrowBookId,-10} {BorrowCount,-10} ";

        }


    }
}
