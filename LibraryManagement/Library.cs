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
    public partial class LibraryManagement : Form
    {
        DataTable dt;
        int index = -1;
        public LibraryManagement()
        {
            InitializeComponent();
            //Step 1: Define the class Student, create/load a list of students

            //Thành phần giao diện: DataGridView (dgvBooks)
            //Thành phần quản lý dữ liệu: DataTable (dt)
            //Thành phần dữ liệu: List<Books> (aList)
            //C1 : aList + dgvBooks
            //C2*: aList + dt + dgvBooks (Sử dụng cách này trên lớp)

            //Step 2: Create DataTable used to manage the data, connect DataTable to DataGridView
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("Title");
            dt.Columns.Add("Book Category");
            dt.Columns.Add("Author");
            dt.Columns.Add("Publisher");
            dt.Columns.Add("Year of publication");
            dt.Columns.Add("Status (New, Good, Old");
            dt.Columns.Add("Availability");


            dt.Rows.Clear();

            foreach (var item in ListBooks.Instance.Books)
            {
                dt.Rows.Add(item.Id, item.Title, item.Category, item.Author, item.Publisher, item.YearofPublication, item.Status, item.Availability);
            }
            dgvBooks.DataSource = dt;
            //Step 3: Change some properties of DataGridView (Giao diện)
            //3.1.Columns' size
            dgvBooks.Columns[0].Width = 50;
            dgvBooks.Columns[1].Width = 100;
            dgvBooks.Columns[2].Width = 70;
            dgvBooks.Columns[3].Width = 70;
            dgvBooks.Columns[4].Width = 70;
            dgvBooks.Columns[5].Width = 70;
            dgvBooks.Columns[6].Width = 95;
            dgvBooks.Columns[7].Width = 90;
            //dgvBooks.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //3.2. Change the color of a dgv's column
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.Bisque;
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;

            dgvBooks.Columns[0].DefaultCellStyle.BackColor = Color.Beige;
            dgvBooks.Columns[0].DefaultCellStyle.ForeColor = Color.Red;

            //3.3. Select the whole row instead of a cell
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ///////////////////////////////////
            lbCount.Text = dt.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item.NewBook = null;
            AddBooks add = new AddBooks();
            add.FormClosed += Add_FormClosed;
            add.ShowDialog();

        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListBooks.Instance.Books.Add(Item.NewBook);
            LoadBooks();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListBooks.Instance.Books.Count)
            {
                MessageBox.Show("Please select a record!!!!");
                return;
            }

            EditBook edit = new EditBook();

            edit.FormClosed += Edit_FormClosed;

            edit.ShowDialog();
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            ListBooks.Instance.Books[index].Title = Item.NewBook.Title;
            ListBooks.Instance.Books[index].Category = Item.NewBook.Category;
            ListBooks.Instance.Books[index].Author = Item.NewBook.Author;
            ListBooks.Instance.Books[index].Publisher = Item.NewBook.Publisher;
            ListBooks.Instance.Books[index].YearofPublication = Item.NewBook.YearofPublication;
            ListBooks.Instance.Books[index].Status = Item.NewBook.Status;
            ListBooks.Instance.Books[index].Availability = Item.NewBook.Availability;

            LoadBooks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListBooks.Instance.Books.Count)
            {
                MessageBox.Show("Please select a record!!!!");
                return;
            }
            var answer = MessageBox.Show(this, "Are you sure to delete this row?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ListBooks.Instance.Books[index].Availability == Item.BORROW )
            {
                MessageBox.Show("Reader Already borrrow Books!! Do not Delete", "Notification");
            }
            else
            {
                ListBooks.Instance.Books.RemoveAt(index);
                LoadBooks();
            }
            
        }

        private void LoadBooks()
        {

            dt.Rows.Clear();
            foreach (var item in ListBooks.Instance.Books)
            {
                dt.Rows.Add(item.Id, item.Title, item.Category, item.Author, item.Publisher, item.YearofPublication, item.Status, item.Availability);
            }
            dgvBooks.DataSource = dt;

        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= ListBooks.Instance.Books.Count)
                return;
            Item.NewBook = new Books();
            Item.NewBook.Title = ListBooks.Instance.Books[index].Title;
            Item.NewBook.Category = ListBooks.Instance.Books[index].Category;
            Item.NewBook.Author = ListBooks.Instance.Books[index].Author;
            Item.NewBook.Publisher = ListBooks.Instance.Books[index].Publisher;
            Item.NewBook.YearofPublication = ListBooks.Instance.Books[index].YearofPublication;
            Item.NewBook.Status = ListBooks.Instance.Books[index].Status;
            Item.NewBook.Availability = ListBooks.Instance.Books[index].Availability;
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "[Title] LIKE '%" + txtSearch.Text + "%'"; //like SQL statement
            lbCount.Text = dt.DefaultView.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListBooks.Instance.Books.Count)
            {
                MessageBox.Show("Please select a record!!!!");
                return;
            }
            DetailBook detail = new DetailBook();
            detail.ShowDialog();
        }
    }
}
