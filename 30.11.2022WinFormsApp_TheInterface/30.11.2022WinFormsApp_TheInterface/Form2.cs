using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30._11._2022WinFormsApp_TheInterface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public IItem[] itemArray=new IItem[5];
        private static int index = 0;

        private void cola_Click(object sender, EventArgs e)
        {
            IItem colaItem = new Cola();
            if (index < 5)
            {
                itemArray[index] = colaItem;
                index++;
            }
            else
            {
                MessageBox.Show("The item array can contain only 5 items.");
            }
        }

        private void kinly_Click(object sender, EventArgs e)
        {
            IItem kinlyItem = new Kinly();
            if (index < 5)
            {
                itemArray[index] = kinlyItem;
                index++;
            }
            else
            {
                MessageBox.Show("The item array can contain only 5 items.");
            }
        }

        private void print_Click(object sender, EventArgs e)
        {

            string s = "";
            for (int i = 0; i < index; i++)
            {
                if (i == index-1)
                {
                    s = s + i.ToString() + ": " + itemArray[i].GetPrice().ToString();
                }
                else
                {
                    s = s + i.ToString() + ": " + itemArray[i].GetPrice().ToString() + ", ";
                }
            }
            index = 0;
            MessageBox.Show(s);
        }
    }
}
