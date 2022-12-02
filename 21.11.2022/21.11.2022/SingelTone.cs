using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._11._2022
{
    internal class SingelTone
    {
        private SingelTone()
        {

        }
        private static SingelTone _INSTANCE = new SingelTone();
        public static SingelTone INSTANCE
        {
            get
            {
                return _INSTANCE;
            }
        }
        public int GetNum()
        {
            return 1;
        }

        public void SetValues(int age, string name)
        {
            Name = name;
            Age = age;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
