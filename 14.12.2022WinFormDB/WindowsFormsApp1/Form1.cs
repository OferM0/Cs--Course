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
    public partial class Form1 : Form
    {
        //connection settings to DB
        string connectionString = "Data Source=localhost\\sqlexpress; Initial Catalog=time_clock; Integrated Security=SSPI;Persist Security Info=False";
        //object that contain the connection settings
        public SqlConnection connection; 
        public Form1()
        {
            InitializeComponent();
            //activate the connection
            connection = new SqlConnection(connectionString);
            //connect();
        }

        //function- check validation of id
        private bool checkId(string ID)
        {
            return true;
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

        //function- send user's details to DB and recive answer
        private string sendDetails(string id, string password)
        {
            if(!connect())
                return "The connection failed";
            string sqlQuery = "declare @employee_code int, @answer varchar(100) select @employee_code = (select code from Employees where ID = @ID) if @employee_code is null begin select @answer = 'id or password invalid, please try again.' end else begin if not exists(select code from Passwords where employee_code = @employee_code and password = @Password and is_active = 1) begin select @answer = 'id or password invalid, please try again.' end else begin if not exists(select code from Passwords where employee_code = @employee_code and password = @Password and is_active = 1 and expire_date > GETDATE()) begin select @answer = 'Your password date expired, please change it.' end else begin if not exists(select * from Times where employee_code = @employee_code and exit_time is null) begin Insert into Times values(@employee_code, GETDATE(), null) select @answer = 'Entry time: ' + convert(varchar(20), GETDATE(), 103) + ' ' + convert(varchar(20), GETDATE(), 108) end else begin update Times set exit_time = GETDATE() where employee_code = @employee_code and exit_time is null select @answer = 'Exit time: ' + convert(varchar(20), GETDATE(), 103) + ' ' + convert(varchar(20), GETDATE(), 108) end end end end select @answer";
            //object that send the query to DB by connection
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            //add parameters to command
            command.Parameters.AddWithValue("@ID", id);
            /* --old way--
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = id;*/
            command.Parameters.AddWithValue("@Password", password);
            //execute query
            string answer = command.ExecuteScalar().ToString();
            //close connection
            connection.Close();
            return answer;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e) //e= keyPress value
        {
            if (e.KeyChar == (char)Keys.Enter) //check if user clicked enter
            {
                //check if user wrote id and password
                if(txtId.Text==""||txtPassword.Text==string.Empty) //""=string.empty
                {
                    MessageBox.Show("Please write id and password!", "id or password empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                    return;
                }
                MessageBox.Show(sendDetails(txtId.Text, txtPassword.Text));
            }
            /*
            if (e.KeyChar == (char)13)
            {
                MessageBox.Show("Enter Key Pressed");
            }
            
            if (e.KeyChar == (char)Keys.Return)
            {
                MessageBox.Show("Enter Key Pressed");
            }*/
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string id2;

            if (id == "")
            {
                id2 = Microsoft.VisualBasic.Interaction.InputBox("Please enter your id.", "Changing Password");

                if (id2 != "")
                {
                    Form2 myForm = new Form2(this, id2);
                    myForm.Show();
                }
            }
            else
            {
                Form2 myForm = new Form2(this, id);
                myForm.Show();
            }
        }
    }
}
