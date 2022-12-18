using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._12._2022WinFormDB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {

        }

        private void enterGuest(string name)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter your name.");
            }
            else
            {
                if (!connect()) return;
                string sqlQuery = "if not exists(select * from Guests where name=@guest_name) begin insert into Guests values(@guest_name) end";
                SqlCommand command= new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@guest_name", name);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void showAllGuests(string name)
        {
            if (!connect()) return;
            string sqlQuery = "select name from Guests where name like '%" +name+"%'";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}