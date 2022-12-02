namespace _30._11._2022WinFormsApp_TheInterface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            Application.Run(new Form3());

            /* Dispose--------------------------
             * 
            Data data = new Data(12);
            data.Alloc();
            data.arr[3] = 98;
            data.arr[2] = 48;
            //data.Free();

            using (kuku a = new kuku())
            {

            }

            using (Data d = new Data(55))
            {
                d.Alloc();
                d.arr[3] = 98;
                d.arr[2] = 48;
            }

            using (System.IO.StreamWriter s = new System.IO.StreamWriter(""))
            {
                s.WriteLine("sdfsdfsdfsdf");
            }*/
        }
    }
}