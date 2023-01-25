using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormTaskExample : Form
	{
		int counter = 0;
		public FormTaskExample()
		{
			InitializeComponent();
		}

		void func1()
		{
			for (int j = 0; j < 2; j++)
			{
				for (int i = 0; i < int.MaxValue; i++)
				{

				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = "Start";
			Task t = Task.Run(func1);
			int f = 90;
			
			Task.Run(() =>
			{
				f++;
				for (int i = 0; i < 10; i++)
				{
					//אלמנטים ויזואליים שיורשים מקונטרול לא יכולים להתעדכן מתוך פריד שהוא לא המיין פריד(ui)
					//label1.Text = $"{i}";//לא יעבוד			
		    		counter++;
					Thread.Sleep(1000);
				}
			});
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			string ret = await GoToInternet();
			label1.Text=ret;
		}

		public Task<string> GoToInternet()
		{
			return Task.Run(() =>
			{
				Thread.Sleep(5000);
				return "Result From Internet";
			});
		}
	}
}
