using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05._12._2022workingWithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\\sqlexpress";

            //Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select count(*) from Orders";
                //string queryString = "select ProductName, UnitPrice from Products";

                //Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    /*//Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string secondColumn = reader.GetString(0); //ProductName from Products 
                            SqlMoney firstColumn = reader.GetSqlMoney(1); //UnitPrice from Products 

                        }
                    }*/
                    try
                    {
                        textBox1.Text = command.ExecuteScalar().ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\\sqlexpress";

            //Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select count(*) from Customers";

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    try
                    {
                        MessageBox.Show(command.ExecuteScalar().ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }
    }
}
