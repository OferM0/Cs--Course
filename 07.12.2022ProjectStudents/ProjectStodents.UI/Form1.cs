using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectStodents.Entities;
using System.Windows.Forms;

namespace ProjectStodents.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainManager.Instance.Init();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            MainManager.Instance.Students.ResetHash();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTB.Text) || string.IsNullOrEmpty(nameTB.Text) || string.IsNullOrEmpty(ageTB.Text) || string.IsNullOrEmpty(addressTB.Text))
            {
                MessageBox.Show("There is empty, please fill all");
            }
            else
            {
                Entities.MainManager.Instance.Students.AddNewStudent(int.Parse(idTB.Text), nameTB.Text, int.Parse(ageTB.Text), addressTB.Text);
                MainManager.Instance.Students.ResetHash();
            }
        }

        private void get_Click(object sender, EventArgs e)
        {
            ProjectStudents.Model.Student s=MainManager.Instance.Students.GetStudent(int.Parse(idTB.Text));
            if(s!=null)
            {
                nameTB.Text = s.Name;
                ageTB.Text = s.Age.ToString();
                addressTB.Text = s.Address;
            }
            else
            {
                MessageBox.Show("There is not student with this id");
            }
        }
    }
}
