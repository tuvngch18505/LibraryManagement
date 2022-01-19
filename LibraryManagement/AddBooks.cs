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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
            cboStatus.DataSource = Item.listStatus;
            cboAvailability.DataSource = Item.listAvailability;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text == "")
            {
                MessageBox.Show("Please Enter Complete information", "Notifications");
            }
            else
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
