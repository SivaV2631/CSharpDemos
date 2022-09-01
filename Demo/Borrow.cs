using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Demo
{
    class Borrow : IEnumerable
    {

        List<Borrow> borrowList = new List<Borrow>();

        private int _UserId;
        public int UserId
        {
            get
            {
                return _UserId;
            }
        }



        public string UserName;
        public string UserAddress;
        public int _BorrowBookId;
        public int BorrowBookId;

        public DateTime BorrowDate;
        public int BorrowCount;



        #region System.Collections.IEnumerable members

        public System.Collections.IEnumerator GetEnumerator()
        {

            for (int i = 0; i < borrowList.Count; i++)
            {
                yield return borrowList[i];
            }

            // --- SAME AS ABOVE
            //foreach(Employee emp in this._employees)
            //{
            //    yield return emp;
            //}
        }

        #endregion

        public Borrow(string username, string useraddress, DateTime borrowdate, int borrowbookid, int borrowcount)
        {
            UserName = username;
            UserAddress = useraddress;

            borrowdate = DateTime.Now;
            BorrowDate = borrowdate;
            BorrowCount = borrowcount;

        }

        public Borrow()
        {
        }

        public override string ToString()
        {
            DateTime dt = DateTime.Now;
            return $"{UserId,-20} {UserName,-20} {UserAddress,-20}  {BorrowBookId,-10} {BorrowDate.ToString("MM/dd/yyyy hh:mm tt"),-20}  {BorrowCount,-10} ";

        }



    }

}

