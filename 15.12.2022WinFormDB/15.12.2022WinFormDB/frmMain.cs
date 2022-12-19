using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _15._12._2022WinFormDB
{
    public partial class frmMain : Form
    {
        //connection settings to DB
         public string connectionString = "Data Source=localhost\\sqlexpress; Initial Catalog=event_guests; Integrated Security=SSPI;Persist Security Info=False";
        //object that contain the connection settings
        public SqlConnection connection;
        public frmMain()
        {
            InitializeComponent();
            //activate the connection
            connection = new SqlConnection(connectionString);
            //show all guests in DB in list
            showAllGuests("");
        }

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
        private void ok_Click(object sender, EventArgs e)
        {            
            string name=txtName.Text;
            string name2;
            //enter name in textbox to DB
            //clear textbox- automitacly showAllGuests will activate
            //txtName.Text = "";
            if (name == "")
            {
                name2 = Microsoft.VisualBasic.Interaction.InputBox("Please enter name.");

                if (name2 != "")
                {            
                    enterGuest(name2);
                    CreateFormsByCategories(name2);
                }
            }
            else
            {
                enterGuest(txtName.Text);
                CreateFormsByCategories(name);
            }
        }

        private void enterGuest(string name)
        {
             if (!connect()) return;
                string sqlQuery = "if not exists(select * from Guests where name=@guest_name) begin insert into Guests values(@guest_name) end";
                //create command- use the query and the object that connect to DB
                SqlCommand command= new SqlCommand(sqlQuery, connection);
                //add variable of guest name
                command.Parameters.AddWithValue("@guest_name", name);
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
        private void showAllGuests(string name) //example to danger of sql injection
        {
            //clear list from previous names
            listOfGuests.Items.Clear();
            if (!connect()) return;
            string sqlQuery = "select name from Guests where name like '%" + name + "%'";
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
                    listOfGuests.Items.Add(reader["name"].ToString());//reader[0]=reader["name"]
                }
            }
            //close connection to DB
            connection.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //when text change the list of guests will change - like search bar
            showAllGuests(txtName.Text);
        }

        private void listOfGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            //copy and show selected name in list in textbox
            txtName.Text = listOfGuests.Text;
            showAllGuests("");
        }

        //function- create category forms by DB- category table
        private void CreateFormsByCategories(string guestName)
        {
            int index = 0;
            string sqlQuery = "select name from categories";
            if(!connect()) return;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            //forms list
            List<frmCategory> categoriesList = new List<frmCategory>();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    //create new frmCategory to every category name in DB and add to categoriesList
                    categoriesList.Add(new frmCategory(this, guestName, reader[0].ToString(),index++));//take the index value then up in 1
                }
                categoriesList.First().Brothers=categoriesList;
                categoriesList.First().Show();
            }
            connection.Close();
        }
    }
}