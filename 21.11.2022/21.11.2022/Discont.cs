using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._11._2022
{
    internal class Discont : Bank
    {

        public bool _isTeacher;

        public Discont(string name, int branch, int code, string street, string city, string phone, bool isTeacher) : base(name, branch, code, street, city, phone)
        {
            _isTeacher = isTeacher;
        }

        public bool IsTeacher
        {
            get { return _isTeacher; }
            set { _isTeacher = value; }
        }
    }
}
