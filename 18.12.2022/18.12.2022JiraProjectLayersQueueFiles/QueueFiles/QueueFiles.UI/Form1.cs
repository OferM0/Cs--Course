using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueueFiles.Entities;

namespace QueueFiles.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainManager.Instance.Init();
        }

        private void push_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsert.Text))
            {
                MessageBox.Show("Pleae insert value to push");
            }
            else
            {
                QueueFiles.Model.Item t =new Model.Item();
                t.value= txtInsert.Text;
               Entities.MainManager.Instance.myQueue.Push(t);
                txtInsert.Text = "";
            }
        }

        private void pop_Click(object sender, EventArgs e)
        {
            QueueFiles.Model.Item t = MainManager.Instance.myQueue.Pop();
            if (t != null)
            {
                txtShow.Text = t.value;
            }
            else
            {
                MessageBox.Show("The queue is empty");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            MainManager.Instance.myQueue.ClearQueue();
            txtShow.Text = "";
            txtInsert.Text = "";
        }

        private void random_Click(object sender, EventArgs e)
        {
            txtShow.Text = MainManager.Instance.randomValue.GetRandomBetween(2, 99).ToString();
        }
    }
}
