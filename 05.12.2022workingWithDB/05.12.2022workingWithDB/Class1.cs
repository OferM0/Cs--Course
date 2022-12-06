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
    internal class Class1
    {
        const string connectionString = "Server=tcp:haimgilboavote.database.windows.net,1433;Initial Catalog=vote;Persist Security Info=False;User ID=haim;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private void button1_Click(object sender, EventArgs e)
        {
            // Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "select 123,+ 23 as 'calc', code,email,99 from email";

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int colIdx = reader.GetOrdinal("email");
                            string email = reader.GetString(colIdx);
                            string code = reader.GetString(reader.GetOrdinal("code"));
                            int num = reader.GetInt32(2);
                        }
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "update tbl set name='kuku'";

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    int rowsEffectes = command.ExecuteNonQuery();
                }
            }
        }

        public static void Sql()
        {
            string queryString = "SELECT * FROM dbo.email";

            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    // Call Read before accessing data.
                    while (reader.Read())
                    {
                        string f = reader.GetString(reader.GetOrdinal("email"));
                    }

                    // Call Close when done reading.
                }
            }
        }
    }
}
