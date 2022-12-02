using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._11._2022
{
    internal class Mizrahi : Bank
    {
        public int _clubMembersCount;
        public Mizrahi(string name, int branch, int code, string street, string city, string phone, int clubMembersCount) : base(name, branch, code, street, city, phone)
        {
            _clubMembersCount = clubMembersCount;
        }

        public int ClubMembersCount
        {
            get { return _clubMembersCount; }
            set { _clubMembersCount = value; }
        }
    }
}
