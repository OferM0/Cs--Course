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
using System.Collections;
using System.Windows.Forms;

namespace _05._12._2022workingWithDB
{
    public partial class Form2 : Form
    {
        Hashtable tbl = new Hashtable();

        public Form2()
        {
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\\sqlexpress";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select EmployeeID ,FirstName+' '+LastName as FullName from Employees";

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int firstColumn = reader.GetInt32(0); //EmployeeID from Employees
                            string secondColumn = reader.GetString(1); //FullName from Employees 
                            tbl.Add(firstColumn, secondColumn);
                        }
                    }
                }
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            if (tbl[id] is string)
            {
                string name = (string)tbl[id];
                string message= "Employee id: "+id.ToString()+", Employee name: "+name;
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("This id does not exist");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
