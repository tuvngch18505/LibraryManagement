using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class DetailBook : Form
    {
        public DetailBook()
        {
            InitializeComponent();
            LoadInfo();
        }
        void LoadInfo()
        {
            txtTitle.Text = Item.NewBook.Title;
            txtCategory.Text = Item.NewBook.Category;
            txtAuthor.Text = Item.NewBook.Author;
            txtPublisher.Text = Item.NewBook.Publisher;
            txtYear.Text = Item.NewBook.YearofPublication.ToString();
            cboStatus.Text = Item.NewBook.Status;
            cboAvailability.Text = Item.NewBook.Availability;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
