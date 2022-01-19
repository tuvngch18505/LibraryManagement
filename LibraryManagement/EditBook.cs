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
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
            
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

        private void Grbox_Enter(object sender, EventArgs e)
        {
            cboStatus.DataSource = Item.listStatus;
            cboAvailability.DataSource = Item.listAvailability;
            LoadInfo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string category = txtCategory.Text;
            string author = txtAuthor.Text;
            string publisher = txtPublisher.Text;
            int year = int.Parse(txtYear.Text);
            string status = cboStatus.Text;
            string availability = cboAvailability.Text;

            Item.NewBook = new Books(title, category, author, publisher, year, status, availability);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
