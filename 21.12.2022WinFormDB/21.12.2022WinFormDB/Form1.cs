using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._12._2022WinFormDB
{
    public partial class Form1 : Form
    {
        private static List<Employees> employees;

        public Form1()
        {
            InitializeComponent();
            ResetAllControls(this);
        }

        //reset all controls in form include radio buttons
        //if there are controls in control for example: radiobuttons in panel then the form cant see them... to solve that we made reqursion
        private void ResetAllControls(Control control)
        {
            if (control == null) return;
            foreach(Control ctr in control.Controls)
            {
                if (ctr is TextBox) ctr.Text = "";
                if (ctr is RadioButton) ((RadioButton)ctr).Checked = false;
                if(ctr is Panel) ResetAllControls(ctr);
                if (ctr is DateTimePicker) ((DateTimePicker)ctr).Value =DateTime.Now.AddYears(-18);
            }
        }
        public string status
        {
            get
            {
                foreach(Control ctr in pStatus.Controls)
                {
                    if (ctr is RadioButton)
                        if (((RadioButton)ctr).Checked) return ctr.Text;
                }
                return " ";
            }
            set
            {
                foreach( Control ctr in pStatus.Controls)
                {
                    if (ctr is RadioButton && ctr.Text == value)
                        ((RadioButton)ctr).Checked = true;

                }
            }
        }
        public string gender
        {
            get
            {
                foreach (Control ctr in pGender.Controls)
                {
                    if (ctr is RadioButton)
                        if (((RadioButton)ctr).Checked) return ctr.Text;
                }
                return " ";
            }
            set
            {
                foreach (Control ctr in pGender.Controls)
                {
                    if (ctr is RadioButton && ctr.Text == value)
                        ((RadioButton)ctr).Checked = true;

                }
            }
        }
        //function- check if all fields filled- return true if not- false
        private bool CheckAllTextFields()
        {
            if (txtCity.Text == ""||txtFirstName.Text==""||txtHomePhone.Text==""||txtId.Text==""||txtLastName.Text==""||txtNumber.Text==""||txtPhoneNumber.Text==""||txtStreet.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //function check validation of radio buttons
        private bool CheckAllRadioButtons()
        {
            if ((rdBtnFemale.Checked==false && rdBtnMale.Checked==false) || (rdBtnDivorced.Checked==false && rdBtnMarried.Checked == false && rdBtnSingle.Checked == false && rdBtnWidower.Checked == false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //function check validation of id
        private bool CheckId(string Id)
        {
            long result = 0;
            //check if we can cast text to number(if there are only numberical chars)
            if (!long.TryParse(Id, out result))return false;
          
            int sum = 0;
            //run on all string
            for (int i = 0; i < Id.Length-1; i++)
            { //calc each digit and multiply in 1 or 2
                int num= int.Parse(Id[i].ToString()) * ((i % 2) + 1);
                //add this result to general sum include reduce decimal number
                sum += num % 10 + num / 10;
            }
            return (sum + int.Parse(Id[Id.Length-1].ToString()))%10==0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetAllControls(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckAllTextFields()) MessageBox.Show("Please fill all fields.");
            if (!CheckAllRadioButtons()) MessageBox.Show("Pleas check radio buttons.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchByCode_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        //when leave textbox
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (!CheckId(txtId.Text))
            {
                lblIdMsg.Text = "Id invalid!";
                lblIdMsg.BackColor = Color.Red;
                txtId.Focus();
            }
            else
            {
                lblIdMsg.Text = "";
                txtId.ReadOnly = true;
            }
        }
    }
}
