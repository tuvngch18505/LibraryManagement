using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Books
    {
        private int id;
        public int Id
        {
            get { return id; }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string category;
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private int yearofpublication;
        public int YearofPublication
        {
            get { return yearofpublication; }
            set { yearofpublication = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string availability;
        public string Availability
        {
            get { return availability; }
            set { availability = value; }
        }
        private static int count = 1;

        public Books()
        {

        }
        public Books(string title, string category, string author, string publisher, int yearofpublication, string status, string availability)
        {
            this.id = count * 101;
            count++;
            this.Title = title;
            this.Category = category;
            this.Author = author;
            this.Publisher = publisher;
            this.YearofPublication = yearofpublication;
            this.Status = status;
            this.Availability = availability;

        }
    }
}
