using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._11._2022WinFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string path = rnd.Next(1, 4).ToString() + ".jpg" ;
            pictureBox1.Image = Image.FromFile(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
