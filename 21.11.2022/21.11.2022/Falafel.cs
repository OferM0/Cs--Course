using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._11._2022
{
    interface Iitem
    {
        void print();
    }
    internal class Falafel:Iitem
    {
        private readonly int _id;
        public int _balls;

        public Falafel(int id)
        {
            _id = id;
        }

        public int Id
        {
            get { return _id; }
            //set { _id = value; }
        }

        public int Balls
        {
            get { return _balls; }
            set { _balls = value; }
        }

        public void print()
        {
            Console.WriteLine("This Falafel has {0} balls", Balls);
        }
    }
}
