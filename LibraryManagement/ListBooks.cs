using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class ListBooks
    {
        private static ListBooks instance;
        private List<Books> books;

        public List<Books> Books { get => books; set => books = value; }

        public static ListBooks Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ListBooks();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private ListBooks()
        {
            books = new List<Books>();
            books.Add(new Books("Dragon Ball Super", "Action", "Tobijama", "Toey", 2021, Item.NEW, Item.NOTBORROW));
            books.Add(new Books("One Punch Man", "Action", "One", "Shueisha", 2009, Item.GOOD, Item.NOTBORROW));
            books.Add(new Books("Dac Nhan Tam", "self-help", "Carnegie", "Simon, Schuster", 2015, Item.GOOD, Item.NOTBORROW));
            books.Add(new Books("7 Habits of Highly Efective People", "Self-help", "Covey", "Press", 2014, Item.GOOD, Item.NOTBORROW));
            books.Add(new Books("Teach children to enrich 1", "Self-help", "Kiyosaki", "NXB Tre", 2017, Item.NEW, Item.NOTBORROW));
            books.Add(new Books("Teach children to enrich 2", "Self-help", "Kiyosaki", "NXB Tre", 2017, Item.OLD, Item.NOTBORROW));
            books.Add(new Books("Teach children to enrich 3", "Self-help", "Kiyosaki", "NXB Tre", 2018, Item.NEW, Item.NOTBORROW));
            books.Add(new Books("Teach children to enrich 4", "Self-help", "Kiyosaki", "NXB Tre", 2018, Item.GOOD, Item.NOTBORROW));
            books.Add(new Books("Teach children to enrich 5", "Self-help", "Kiyosaki", "NXB Tre", 2018, Item.NEW, Item.NOTBORROW));
            books.Add(new Books("Teach children to enrich 6", "Self-help", "Kiyosaki", "NXB Tre", 2019, Item.GOOD, Item.NOTBORROW));
        }
    }
}
