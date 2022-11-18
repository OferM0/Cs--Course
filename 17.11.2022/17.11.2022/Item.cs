using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._2022
{
    internal class Item
    {
        private int _id;
        public string _name;
        public int _price;
        public Item(int id)
        {
            _id = id;
        }

        public Item(int id, string name)
        {
            _id = id;
            _name = name;
        }


        public int Id { get { return _id; } }
        public int Price { get { return _price; } set { _price = value; } }
        public string Name { get { return _name; } set { _name = value; } }
    }
}