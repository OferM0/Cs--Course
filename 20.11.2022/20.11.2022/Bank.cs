using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._2022
{
    internal class Bank
    {
        public string _name;
        public int _branch;
        public readonly int _code; //= private int _code
        public string _street;
        public string _city;
        public string _phone;

        public Bank(string name, int branch, int code, string street, string city, string phone)
        {
            _name = name;
            _branch = branch;
            _code = code;
            _street = street;
            _city = city;
            _phone = phone;
        }

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }

        public int Code
        {
            get { return _code; }
            //set { _code = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}, branch: {1}, Code: {2}, Street: {3}, City: {4}, Phone: {5}", Name, Branch.ToString(), Code.ToString(), Street, City, Phone);
        }
    }
}