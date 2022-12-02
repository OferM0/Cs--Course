using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._2022
{
    internal class Leumi : Bank
    {
        public string _giftForNewCustpres;
        public Leumi(string name, int branch, int code, string street, string city, string phone, string giftForNewCustpres) : base(name, branch, code, street, city, phone)
        {
            _giftForNewCustpres = giftForNewCustpres;
        }

        public string GiftForNewCustpres
        {
            get { return _giftForNewCustpres; }
            set { _giftForNewCustpres = value; }
        }
    }
}
