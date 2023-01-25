using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
	public partial class FormTaskTargilim : Form
	{
		public FormTaskTargilim()
		{
			InitializeComponent();
		}

		public Task Write10LinesToFile()
		{
			return Task.Run(() =>
		   {
			   string fileName = textBox1.Text + ".txt";
			   if (File.Exists(fileName))
			   {
				   using (StreamWriter sw = File.AppendText(fileName))
				   {
					   for (int i = 0; i < 10; i++)
					   {
						   sw.WriteLine("line");
						   Thread.Sleep(1000);
					   }
				   }
			   }
			   else
			   {
				   //File.Create(fileName);
				   using (StreamWriter sw = new StreamWriter(fileName))
				   {
					   for (int i = 0; i < 10; i++)
					   {
						   sw.WriteLine("line");
						   Thread.Sleep(1000);
					   }
				   }
			   }
		   });
		}
		private async void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Please enter file name");
			}
			else
			{
				Task t = Write10LinesToFile();
			}
		}
		
		public Task<string> From1To10(string num)
		{
			
				return Task.Run(() =>
				{
					Thread.Sleep(1000);
					return num;
				});
			
			
		}
		private async void button2_Click(object sender, EventArgs e)
		{
			for (int i = 1; i <= 10; i++)
			{
				label2.Text = await From1To10(i.ToString());
			}
		}

		private Task<string> BringTextFromYnet()
		{
			return Task.Run(() =>
			{
				using (WebClient client = new WebClient())
				{
					return client.DownloadString("https://www.ynet.co.il/");
				}
			});
		}
		private async void button3_Click(object sender, EventArgs e)
		{
			string text= await BringTextFromYnet();
			richTextBox1.Text = text;
			textBox2.Text = text.Length.ToString();
		}

		private Task<string> BringFirstNewFromYnetEvery2Minutes()
		{
			return Task.Run(() =>
			{
				Thread.Sleep(120000);
				using (WebClient client = new WebClient())
				{
				    string xml = client.DownloadString("http://www.ynet.co.il/Integration/StoryRss2.xml");
					XDocument doc = XDocument.Parse(xml);
					var item = doc.Descendants("item").ToList();
					var description = item[0].Element("description").Value;
					return description.ToString();
				}
			});
		}
		private async void button4_Click(object sender, EventArgs e)
		{
			/*for(int i = 0; i < 5;i++)
			{*/
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			while (stopWatch.Elapsed < TimeSpan.FromMinutes(60))
			{
				string text = await BringFirstNewFromYnetEvery2Minutes();
				richTextBox2.Text = text;
			}
			stopWatch.Stop();
			richTextBox2.Text = "";
			//Application.Exit();
			//}
		}
	}
}
