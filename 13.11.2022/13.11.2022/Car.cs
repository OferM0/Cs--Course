using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._2022
{
    internal class Car
    {
        public int num;
        public string name;
        private int id;

        public void SetNum(int aNum)
        {
            num = aNum;
        }

        public string PrintDetails()
        {
            string str;
            str = "Car num is: " + num.ToString() + " Car name is: " + name;
            return str;
        }
    }
}
