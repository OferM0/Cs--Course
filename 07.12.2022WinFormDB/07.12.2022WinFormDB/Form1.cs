using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _07._12._2022WinFormDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DelegateClass.T2Numbers_delegate func;

        private void plus_Click(object sender, EventArgs e)
        {
            func = DelegateClass.Instance.CalcPlus;
            int result= DelegateClass.Instance.Calc(int.Parse(num1.Text), int.Parse(num2.Text), func);
            MessageBox.Show(result.ToString());
        }

        private void minus_Click(object sender, EventArgs e)
        {
            func = DelegateClass.Instance.CalcMinus;
            int result = DelegateClass.Instance.Calc(int.Parse(num1.Text), int.Parse(num2.Text), func);
            MessageBox.Show(result.ToString());
        }

        private void mult_Click(object sender, EventArgs e)
        {
            func = DelegateClass.Instance.CalcMultiply;
            int result = DelegateClass.Instance.Calc(int.Parse(num1.Text), int.Parse(num2.Text), func);
            MessageBox.Show(result.ToString());
        }

        private void divide_Click(object sender, EventArgs e)
        {
            func = DelegateClass.Instance.CalcDivide;
            MessageBox.Show(func(int.Parse(num1.Text), int.Parse(num2.Text)).ToString());
        }
    }
}
