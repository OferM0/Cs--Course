using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _16._11._2022
{
    internal class Student
    {
        public static int count;
        public string _name;
        private string _id;
        public string _phone;
        public string _adress;

        public Student(string id)
        {
            _id = id;
            count++;
        }
        public string Id 
        {
            get { return _id; }
            private set { _id = value; } //can't chage id from outside.
        }
        public string Phone 
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public string Name
        {
            get { return _name; }
            set 
            {
                if (value.Length <= 15)
                {
                    _name = value;
                }
                else
                {
                    _name = value.Substring(0, 14);
                }
            }
        }

        public void Save()
        {
            string fileName;
            string[] text = new string[4];
            text[0] = this.Id;
            text[1] = this.Name;
            text[2] = this.Phone;
            text[3] = this.Adress;
            fileName = this.Id + ".txt";
            File.WriteAllLines(fileName, text);
        }

        public void Load(string fileName)
        {
            string[] text;
            string fileName1 = fileName + ".txt";
            if (File.Exists(fileName1))
            {
                text = File.ReadAllLines(fileName1);
                if (this.Id == text[0])
                {
                    this.Name = text[1];
                    this.Phone = text[2];
                    this.Adress = text[3];
                }
                else
                {
                    Console.WriteLine("file" + fileName + "not match to student id" + this.Id);
                }
            }
            else
            {
                Console.WriteLine("file" + fileName + "is not exist");
            }
           
        }
    }
}
