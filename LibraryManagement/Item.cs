using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Item
    {
        public static Books NewBook = null;
        public const string NEW = "New";
        public const string GOOD = "Good";
        public const string OLD = "Old";
        public const string BORROW = "Borrow";
        public const string NOTBORROW = "Not Borrow";
        public static List<string> listStatus = new List<string>() { "New", "Good", "Old" };
        public static List<string> listAvailability = new List<string>() { "Borrow", "Not Borrow" };

        public const bool BOOROW = true;

        

    }
}
