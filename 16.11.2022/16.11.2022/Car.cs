using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2022
{
    internal class Car
    {
        private int _id;
        public string _companyName;
        public int _km;
        private int changeName=0;
        public Car(int id)
        {
            _id = id;
        }
        public int Km
        {
            get { return _km; }
            set
            {
                if (value > 0)
                {
                    _km = value;
                }
            }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                if (changeName < 3)
                {
                    _companyName = value;
                    changeName++;
                }
            }
        }
        public int Id
        {
            get { return _id; }
            set
            {
                //_id = value;
            }
        }
    }
}
