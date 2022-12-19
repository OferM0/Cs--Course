using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace _15._12._2022WinFormDB
{
    public partial class frmCategory : Form
    {
        private static List<frmCategory> brothers;
        private frmMain parent;
        private int index;

        public frmCategory(frmMain Parent, string name, string category, int index2)
        {
            InitializeComponent();
            parent = Parent;
            index = index2;
            lblGuest.Text = name;
            lblCategory.Text = category;
            showAllGuestsSelections();
            showCurrentGuestSelections();
        }

        public List<frmCategory> Brothers
        { set { brothers = value; } }

        //function- add dish by guest and category
        private void AddDish(string dishName)
        {
            string sqlQuery = "declare @guest_code int, @category_code int if exists(select code from Guests where name = @guest_name) begin select @guest_code = (select code from Guests where name = @guest_name) end else begin insert into Guests values(@guest_name) select @guest_code = @@IDENTITY end if exists(select code from Categories where name = @category_name) begin select @category_code = (select code from Categories where name = @category_name) insert into Dishes values(@guest_code, @category_code, @dish_name) end select* from Dishes";
            if (!parent.connect()) return;
            SqlCommand command = new SqlCommand(sqlQuery, parent.connection);
            command.Parameters.AddWithValue("@guest_name", lblGuest.Text);
            command.Parameters.AddWithValue("@category_name", lblCategory.Text);
            command.Parameters.AddWithValue("@dish_name", dishName);
            command.ExecuteNonQuery();
            parent.connection.Close();
        }

        //function- show chooses of all guests in the specific category
        private void showAllGuestsSelections()
        {
            string sqlQuery = "select Guests.name as 'Guest Name', Dishes.name as 'Dish Name' from Guests inner join Dishes on Guests.code = Dishes.guest_code inner join Categories on Categories.code = Dishes.category_code where Categories.name = '" + lblCategory.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, parent.connectionString);
            //create table in memory
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dataAll.DataSource = tbl;
        }

        //function- show chooses of specific guest in specific category
        private void showCurrentGuestSelections()
        {
            string sqlQuery = "select Guests.name as 'Guest Name', Dishes.name as 'Dish Name' from Guests inner join Dishes on Guests.code = Dishes.guest_code inner join Categories on Categories.code = Dishes.category_code where Categories.name = '"+lblCategory.Text+"' and Guests.name = '"+lblGuest.Text+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, parent.connectionString);
            //create table in memory
            DataTable tbl = new DataTable();
            //fill data that we get to dynamic table in memory
            adapter.Fill(tbl);
            dataGuest.DataSource = tbl;
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            Visible = false;
            if (index > 0)
            {
                brothers[index - 1].Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Visible = false;
            if (index < brothers.Count - 1)
            {
                brothers[index + 1].Show();
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (txtDish.Text != "")
            {
                AddDish(txtDish.Text);
                txtDish.Visible = false;
                confirm.Visible = false;
                showAllGuestsSelections();
                showCurrentGuestSelections();
            }
            else
            {
                MessageBox.Show("Please enter dish name");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            txtDish.Visible = true;
            confirm.Visible = true;
        }

        private void dataAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDish.Visible = true;
            confirm.Visible = true;
            txtDish.Text = dataAll[1,e.RowIndex].Value.ToString();
        }

        private void dataGuest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDish.Visible = true;
            confirm.Visible = true;
            txtDish.Text = dataAll[1, e.RowIndex].Value.ToString();
        }
    }
}