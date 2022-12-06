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
    public partial class Form3 : Form
    {
        Hashtable tbl = new Hashtable();
        public Form3()
        {
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\\sqlexpress";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select ProductId,ProductName,UnitPrice,UnitsInStock from Products";

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader 
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int firstColumn = reader.GetInt32(0); //productId from Products
                            string secondColumn = reader.GetString(1); //productName from Products 
                            SqlMoney thirdColumn = reader.GetSqlMoney(2); //unitPrice from Products
                            int forthColumn = (int)reader.GetSqlInt16(3); //unitsInStock from Products 
                            Products p = new Products(firstColumn, secondColumn, thirdColumn, forthColumn);
                            tbl.Add(firstColumn, p);
                        }
                    }
                }
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            if (tbl[id] is Products)
            {
                SqlMoney pPrice = ((Products)tbl[id]).UnitPrice;
                int pStock = ((Products)tbl[id]).UnitsInStock;

                price.Text = "Price: " + pPrice.ToString();
                stock.Text = "Stock: " + pStock.ToString();
            }
            else
            {
                MessageBox.Show("This id does not exist");
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=localhost\\sqlexpress";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select count(*) from Products where UnitPrice>" + textBox2.Text;

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int cnt = (int)reader.GetInt32(0);
                            count.Text = "Count:" + cnt.ToString();
                        }
                    }
                }
            }
        }
        public class Products
        {
            public int productId;
            public string productName;
            public SqlMoney unitPrice;
            public int unitsInStock;

            public Products(int productid, string productname, SqlMoney unitprice, int unitsinstock)
            {
                productId = productid;
                productName = productname;
                unitPrice = unitprice;
                unitsInStock = unitsinstock;
            }

            public int ProductId
            {
                get { return productId; }
                set { productId = value; }
            }

            public string ProductName
            {
                get { return productName; }
                set { productName = value; }
            }

            public SqlMoney UnitPrice
            {
                get { return unitPrice; }
                set { unitPrice = value; }
            }

            public int UnitsInStock
            {
                get { return unitsInStock; }
                set { unitsInStock = value; }
            }

        }
    }
}
