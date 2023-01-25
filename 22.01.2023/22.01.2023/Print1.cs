using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22._01._2023
{
    public class Print1
    {
        private string _str;
        public Print1(string str)
        {
            _str = str;
        }


        public void Run()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Number " + i + ": " + _str);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    public class Count
    {
        public Count(string label, int delay, int loops, bool infinite)
        {
            Label = label;
            Delay = delay;
            Loops = loops;
            Infinite = infinite;
            thread = new Thread(PrintLableAndNumbers);
            thread.Start();
        }
        public string Label { get; set; }
        public int Delay { get; set; }
        public int Loops { get; set; }
        public bool Infinite { get; set; }

        public void PrintLableAndNumbers()
        {
            int stop=0;
            if (Infinite == false)
            {
                for (int i = 1; i <= Loops; i++)
                {
                    if(i%10 ==0)
                    {
                        Console.WriteLine("If you wish to stop the program pleas enter 0!");
                        stop = int.Parse(Console.ReadLine());
                        if(stop== 0) thread.Suspend(); //break;
                    }
                    Console.WriteLine(Label + " " + i);
                    Thread.Sleep(Delay);
                }
            }
            else
            {
                while(Infinite)
                {
                    Console.WriteLine(Label);
                    Thread.Sleep(Delay);
                }
            }
        }

        Thread thread;
    }

    public class CreateFile
    {
        private string _fileName1;

        public string FileName
        {
            get { return _fileName1 + ".txt"; }
            set { _fileName1 = value + ".txt"; }
        }

        public CreateFile(string fileName)
        {
            _fileName1 = fileName + ".txt";
        }

        public void CheckAndCreateFile()
        {
            if (!File.Exists(_fileName1))
            {
                File.Create(_fileName1);
                Console.WriteLine($"{_fileName1} created");
            }
            else
            {
                Console.WriteLine($"{_fileName1} already exists!");
            }
        }

        public void AddNewLine(string text)
        {
            if (File.Exists(_fileName1))
            {
                using (StreamWriter sw = File.AppendText(_fileName1))
                {
                    sw.WriteLine(text);
                }
                /*StreamWriter sw = new StreamWriter(_fileName1);
                sw.WriteLine(text);*/
            }
            else
            {
                Console.WriteLine($"File '{_fileName1}' does not exist.");
            }
        }
    }

    public class WriteToFiles
    {
        public WriteToFiles(string fileName)
        {
            FileName = fileName;
            thread = new Thread(WriteRandomNumbersToFiles);
            thread.Start();
        }
        public string FileName { get; set; }

        /*WriteToFiles w1 = new WriteToFiles("file1");
        WriteToFiles w2 = new WriteToFiles("file2");
        WriteToFiles w3 = new WriteToFiles("file3");
        WriteToFiles w4 = new WriteToFiles("file4");*/

        public void WriteRandomNumbersToFiles()
        {
            for (int i = 1; i <= 10000; i++)
            {
                CreateFile c = new CreateFile(FileName);
                c.CheckAndCreateFile();
                c.AddNewLine(i.ToString());
                Thread.Sleep(1000);
            }
        }

        Thread thread;
    }
}