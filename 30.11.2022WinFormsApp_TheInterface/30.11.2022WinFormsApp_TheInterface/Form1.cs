namespace _30._11._2022WinFormsApp_TheInterface
{
    public partial class Form1 : Form
    {
        public static int num = 0;
        public Days d;

        public Form1()
        {
            InitializeComponent();
        }
        public enum Days
        {
            /*zero,*/
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }

        private void AddToFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(day.Text) || string.IsNullOrEmpty(age.Text))
            {
                MessageBox.Show("Please make sure all text inputs is not empty!");
            }
            else { 
            File.AppendAllText(fileName.Text, name.Text + "," + day.Text + "," + age.Text+"\n");
            num = 0;
            }
        }

        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            try { 
            string line = File.ReadLines(fileName.Text).Skip(num).Take(1).First();
            string[] values= line.Split(',');
            name.Text =values[0];
            day.Text = values[1];
            age.Text=values[2];
            num++;

            d = (Days)Enum.Parse(typeof(Days), day.Text);

            }
            catch (Exception ex) 
            {
                MessageBox.Show("End of file!");
            }
        }
    }
}