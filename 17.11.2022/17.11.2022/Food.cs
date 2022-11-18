using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._2022
{
    internal class Food : Item
    {
        private int _weight;

        public Food(int id, int weight):base(id)
        {
            _weight = weight;
        }

        public Food(int id, string name, int weight) : base(id, name)
        {
            _weight = weight;
        }
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
