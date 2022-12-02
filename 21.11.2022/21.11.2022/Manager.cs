using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _21._11._2022
{
    internal class Manager
    {
        public Bank[] b;
        public int _lines;

        private Manager()
        {

        }
        private static Manager _INSTANCE = new Manager();

        public static Manager INSTANCE
        {
            get
            {
                return _INSTANCE;
            }
        }

        public void LoadFile(string fileName)
        {
            int lines = 0;
            string[] info;
            StreamReader sr = new StreamReader(fileName);
            StreamReader sr2 = new StreamReader(fileName);

            while (sr.ReadLine() is string)
            {
                lines++;
            }

            _lines = lines;
            b = new Bank[_lines];

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
        public Bank GetSnif(int bankCode, int snifNum)
        {
            for (int i = 0; i < _lines; i++)
            {
                if (i > 0)
                {
                    if (b[i].Code == bankCode && b[i].Branch == snifNum)
                    {
                        return b[i];
                    }
                }
            }

            return null;
        }
    }
}