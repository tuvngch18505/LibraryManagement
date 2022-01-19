using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class BorrowTicket
    {
        private Books book;
        public Books Book
        {
            get { return book; }
            set { book = value; }
        }
        private int bookid;
        public int BookId
        {
            get { return bookid; }
        }
        private DateTime dateborrowed;
        private DateTime datedue;
        private DateTime datereturned;
        
        public DateTime DateBorrowed
        {
            get { return dateborrowed; }
            set { dateborrowed = value; }
        }
        public DateTime DateDue
        {
            get { return datedue; }
            set { datedue = value; }
        }
        public DateTime DateReturned
        {
            get { return datereturned; }
            set { dateborrowed = value; }
        }
        private int latereturnfine;
        public int LateReturnFine
        {
            get { return latereturnfine; }
            set { latereturnfine = value; }
        }
        public static int count = 1;

        public BorrowTicket()
        {

        }
        public BorrowTicket(DateTime dateborrowed, DateTime dateduee, DateTime datereturn, int returnfine)
        {
            this.Book = null;
            this.bookid = count * 1001;
            count++;
            this.DateBorrowed = dateborrowed;
            this.DateDue = dateduee;
            this.DateReturned = datereturn;
            this.LateReturnFine = returnfine;
        }
    }
}
