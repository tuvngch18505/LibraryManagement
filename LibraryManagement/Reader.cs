using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Reader
    {
        private int readerid;
        public int ReaderId
        {
            get { return readerid; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = name; }
        }

        private int phone;
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private int cardnumber;
        public int CardNumber
        {
            get { return cardnumber; }
            set { cardnumber = value; }
        }

        static int count = 1;
        public Reader()
        {

        }

        public Reader(string name, string address, int phone, int card)
        {
            this.readerid = count;
            count++;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.CardNumber = card;
        }


    }
}
