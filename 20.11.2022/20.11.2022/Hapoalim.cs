using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._2022
{
    internal class Hapoalim : Bank
    {
        public int _workersInSnif;

        public Hapoalim(string name, int branch, int code, string street, string city, string phone, int workersInSnif) : base(name, branch, code, street, city, phone)
        {
            _workersInSnif = workersInSnif;
        }
        public int WorkersInSnif
        {
            get { return _workersInSnif; }
            set { _workersInSnif = value; }
        }
    }
}