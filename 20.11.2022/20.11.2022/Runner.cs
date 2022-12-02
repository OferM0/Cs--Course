using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._11._2022
{
    internal class Runner
    {
        public void Use() //Targil 3
        {
            StreamWriter s = new StreamWriter("file1.txt");
            string str;

            s.WriteLine("*****");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter string.");
                str = Console.ReadLine();
                s.WriteLine(str);
            }
            s.Close();

            StreamReader s2 = new StreamReader("file1.txt");
            int j = 1;
            while (s2.ReadLine() is string str2)
            {
                Console.WriteLine("LINE#{0}: {1}", j, str2);
                j++;
            }
            s2.Close();
        }

        public void Use2() //Targil 4
        {
            StreamWriter s = new StreamWriter("file2.txt");
            Random r = new Random();
            Random r2 = new Random();
            int lines = r.Next(50, 101);
            int stars;
            for (int i = 0; i < lines; i++)
            {
                s.WriteLine(' ');

                stars = r2.Next(3, 10);
                for (int j = 0; j < stars; j++)
                {
                    s.Write('*');
                }
            }
            s.Close();

            StreamReader s2 = new StreamReader("file2.txt");
            while (s2.ReadLine() is string str2)
            {
                Console.WriteLine(str2);
            }
            s2.Close();
        }

        public void Use3() //Targil 5,6
        {
            int lines = 0;
            string[] info;
            StreamReader sr = new StreamReader("snifim.txt");
            StreamReader sr2 = new StreamReader("snifim.txt");

            while (sr.ReadLine() is string)
            {
                lines++;
            }

            Bank[] b = new Bank[lines];

            string str;
            for (int i = 0; i < lines; i++)
            {
                str = sr2.ReadLine();
                info = str.Split(',');
                if (i > 0)
                {
                    b[i] = new Bank(info[1], int.Parse(info[2]), int.Parse(info[0]), info[4], info[5], info[8]);
                }
                //code- info[0]
                //name- info[1]
                //branch code- info[2]
                //street- info[4]
                //city- info[5]
                //phone- info[8]
            }

            for (int i = 0; i < lines; i++)
            {
                if (i > 0)
                {
                    if (b[i].City.Contains("תל אביב") || b[i].City.Equals("ירושלים"))
                    {
                        b[i].Print();
                    }
                }
            }

            for (int i = 0; i < lines; i++)
            {
                if (i > 0)
                {
                    if (b[i].Name.Contains("הפועלים") && b[i].Phone.Contains('8'))
                    {
                        b[i].Print();
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < lines; i++)
            {
                if (i > 0)
                {
                    if (b[i].Name.Contains("מזרחי"))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

            sr.Close();
            sr2.Close();
        }

        public void Use4()
        {
            int lines = 0;
            string[] info;
            StreamReader sr = new StreamReader("snifim.txt");
            StreamReader sr2 = new StreamReader("snifim.txt");

            while (sr.ReadLine() is string)
            {
                lines++;
            }

            Bank[] b = new Bank[lines];

            string str;
            for (int i = 0; i < lines; i++)
            {
                str = sr2.ReadLine();
                info = str.Split(',');
                if (i > 0)
                {
                    if (info[1].Contains("הפועלים"))
                    {
                        b[i] = new Hapoalim(info[1], int.Parse(info[2]), int.Parse(info[0]), info[4], info[5], info[8], 1);
                    }
                    else if (info[1].Contains("מזרחי"))
                    {
                        b[i] = new Mizrahi(info[1], int.Parse(info[2]), int.Parse(info[0]), info[4], info[5], info[8], 1);
                    }
                    else if (info[1].Contains("לאומי"))
                    {
                        b[i] = new Leumi(info[1], int.Parse(info[2]), int.Parse(info[0]), info[4], info[5], info[8], "clock");
                    }
                    else if (info[1].Contains("דיסקונט"))
                    {
                        b[i] = new Discont(info[1], int.Parse(info[2]), int.Parse(info[0]), info[4], info[5], info[8], true);
                    }
                    else
                    {
                        b[i] = new Bank(info[1], int.Parse(info[2]), int.Parse(info[0]), info[4], info[5], info[8]);
                    }
                }
            }
        }
        public void Use5()
        {
            int lines = 0;
            string[] info;
            StreamReader sr = new StreamReader("snifim.txt");
            StreamReader sr2 = new StreamReader("snifim.txt");

            while (sr.ReadLine() is string)
            {
                lines++;
            }

            Bank[] b = new Bank[lines];

            string str;
            int cnt1 = 0, cnt2 = 0;
            for (int i = 0; i < lines; i++)
            {
                str = sr2.ReadLine();
                info = str.Split(',');
                if (i > 0)
                {
                    if (info[1].Contains("הפועלים"))
                    {
                        cnt1++;
                        b[i] = new Hapoalim(info[1], int.Parse(info[2]), int.Parse(info[0]), info[4], info[5], info[8], 1);
                    }
                    else if (info[1].Contains("דיסקונט"))
                    {
                        cnt2++;
                        b[i] = new Discont(info[1], int.Parse(info[2]), int.Parse(info[0]), info[4], info[5], info[8], true);
                    }
                    else
                    {
                        b[i] = new Bank(info[1], int.Parse(info[2]), int.Parse(info[0]), info[4], info[5], info[8]);
                    }
                }
            }
            BankHapoalim h = new BankHapoalim(cnt1);
            BankDiscont c = new BankDiscont(cnt2);
            h.Import(b);
            c.Import(b);
        }
    }
}

