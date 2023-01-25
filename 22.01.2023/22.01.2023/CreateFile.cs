/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._01._2023
{
    public class CreateFile
    {
        private string _fileName;
        private static int _fileNum = 1;

        public string FileName
        {
            get { return _fileName + _fileNum+ ".txt"; }
            set { _fileName = value; }
        }

        public CreateFile(string fileName)
        {
            _fileName = fileName + (_fileNum).ToString() + ".txt";
        }

        public void CheckAndCreateFile()
        {
            if (!File.Exists(_fileName))
            {
                File.Create(_fileName);
                Console.WriteLine($"{_fileName} created");
            }
            else
            {
                Console.WriteLine($"{_fileName} already exists!");
            }
        }

        public void AddNewLine(string text)
        {
            string fileNameWithoutExtension;

            if (File.Exists(_fileName))
            {
                if (CheckFileSize(_fileName) == true)
                {
                    fileNameWithoutExtension = Path.GetFileNameWithoutExtension(_fileName);
                    _fileNum++;
                    _fileName = fileNameWithoutExtension + (_fileNum).ToString() + ".txt";
                }
                else
                {
                    File.Create(_fileName).Dispose();
                    Console.WriteLine($"{_fileName} created because of size limit");
                }
                StreamWriter sw = new StreamWriter(_fileName);
                sw.WriteLine(text);
            }
            else
            {
                Console.WriteLine($"File '{_fileName}' does not exist.");
            }
        }

        public bool CheckFileSize(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);

            if (fileInfo.Length > 50*1024) //50 kb= 50 bytes * 1024 bytes
            {
                return true;
            }

            return false;
        }    
    }
}*/

/*
 
 private string fileName;
        private string path;
        private string baseName;
        private string newFileName;
        private int fileNumber = 1;

        public FileClass1(string fileName)
        {
            this.fileName = fileName;
            this.path = Path.GetDirectoryName(fileName);
            this.baseName = Path.GetFileNameWithoutExtension(fileName);
        }

        public void CreateFile()
        {
            if (!File.Exists(fileName))
            {
                using (FileStream fs = File.Create(fileName))
                {
                    Console.WriteLine("File created successfully.");
                }
            }
            else
            {
                Console.WriteLine("File already exists.");
            }
        }

        public void WriteToFile(string text)
        {
            FileInfo file = new FileInfo(fileName);

            if (file.Length >= 1000)
            {
                newFileName = path + "\\" + baseName + fileNumber + ".txt";
                fileNumber++;
                if (!File.Exists(newFileName))
                {
                    using (FileStream fs = File.Create(newFileName))
                    {
                        Console.WriteLine("New file created successfully.");
                    }
                }
                else
                {
                    while (File.Exists(newFileName))
                    {
                        fileNumber++;
                        newFileName = path + "\\" + baseName + fileNumber + ".txt";
                    }
                    using (FileStream fs = File.Create(newFileName))
                    {
                        Console.WriteLine("New file created successfully.");
                    }
                }
                fileName = newFileName;
            }

            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(text);
            }
        }
*/