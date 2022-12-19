using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._12._2022WinFormDB
{
    public partial class frmHost : Form
    {
        public frmHost()
        {
            InitializeComponent();
            //activate the connection
            connection = new SqlConnection(connectionString);
            //show all guests in DB in list
            showAllCategories("");
            showAllGuestsSelectionsFromAllCategories();
        }
        //connection settings to DB
        public string connectionString = "Data Source=localhost\\sqlexpress; Initial Catalog=event_guests; Integrated Security=SSPI;Persist Security Info=False";
        //object that contain the connection settings
        SqlConnection connection;

        //function- connect to DB if success return true else false
        public bool connect()
        {
            try
            {
                connection.Open();
                //MessageBox.Show("The connection successed.");
                return true;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void enterCategory(string name)
        {
            if (!connect()) return;
            string sqlQuery = "if not exists(select * from Categories where name=@category_name) begin insert into Categories values(@category_name) end";
            //create command- use the query and the object that connect to DB
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            //add variable of guest name
            command.Parameters.AddWithValue("@category_name", name);
            //execute command
            try
            {
                int number = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());//=ex.Message
            }
            //close connection to DB
            connection.Close();
        }
        //function- return all guests and show them in grid data view
        private void showAllCategories(string name) //example to danger of sql injection
        {
            //clear list from previous names
            listCategory.Items.Clear();
            if (!connect()) return;
            string sqlQuery = "select name from Categories where name like '%" + name + "%'";
            //create command- use the query and the object that connect to DB
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            //execute command
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) //check if reader return rows- if return we can use while loop
            {
                //read all rows
                while (reader.Read())
                {
                    //read from every row the first column
                    listCategory.Items.Add(reader["name"].ToString());//reader[0]=reader["name"]
                }
            }
            //close connection to DB
            connection.Close();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            string name = txtCategory.Text;
            string name2;
            //enter name in textbox to DB
            
            if (name == "")
            {
                name2 = Microsoft.VisualBasic.Interaction.InputBox("Please enter category name.");

                if (name2 != "")
                {
                    enterCategory(name2); ;
                }
            }
            else
            {
                enterCategory(txtCategory.Text);
            }
            //clear textbox- automitacly showAllGuests will activate
            txtCategory.Text = "";
            showAllCategories("");
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            //when text change the list of guests will change - like search bar
            showAllCategories(txtCategory.Text);
        }

        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //copy and show selected name in list in textbox
            txtCategory.Text = listCategory.Text;
            showAllCategories("");
        }

        //function- show chooses of all guests from all category
        private void showAllGuestsSelectionsFromAllCategories()
        {
            string sqlQuery = "select distinct name as 'Dish Name', count(*) as 'Sum' from Dishes group by name";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
            //create table in memory
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dataSumDishes.DataSource = tbl;
        }
    }
}
