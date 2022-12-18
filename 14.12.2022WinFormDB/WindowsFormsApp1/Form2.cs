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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 parent;
        public Form2(Form1 Parent, string id)
        {
            InitializeComponent();
            parent = Parent;
            label1.Text = id;
        }
        
        private string sendDetails2(string id, string oldPassword, string newPassword)
        {
            if (!parent.connect())
                return "The connection failed";
            string sqlQuery = "declare  @employee_code int, @answer varchar(100) select @employee_code = (select code from Employees where ID = @ID) if @employee_code is null begin select @answer = 'id is invalid, please try again.' end else begin if exists(select password from Passwords where employee_code = @employee_code and password = @old_password and is_active = 1) begin if exists(select password from Passwords where employee_code = @employee_code and password= @new_password) begin select @answer = 'this password was already used, please write another.' end else begin update Passwords set is_active = 0 where employee_code = @employee_code insert into Passwords values(@employee_code, @new_password, GETDATE()+180 ,1) select @answer = 'password changes successfully, the eaxpire date is 180 days from today.' end end else begin select @answer = 'old password is not correct.' end end select @answer";
            //object that send the query to DB by connection
            SqlCommand command = new SqlCommand(sqlQuery, parent.connection);
            //add parameters to command
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@old_password", oldPassword);
            command.Parameters.AddWithValue("@new_password", newPassword);
            //execute query
            string answer = command.ExecuteScalar().ToString();
            //close connection
            parent.connection.Close();
            return answer;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "" || txtNewPassword.Text == "" ||txtConfirmNewPassword.Text=="")
            {
                MessageBox.Show("Please write all fields!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }else if (txtNewPassword.Text!=txtConfirmNewPassword.Text)
            {
                MessageBox.Show("The confirmed password not match.");
                return;
            }
            MessageBox.Show(sendDetails2(label1.Text, txtOldPassword.Text, txtNewPassword.Text));
        }
    }
}
