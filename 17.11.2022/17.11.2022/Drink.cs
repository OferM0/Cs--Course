using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._2022
{
    internal class Drink:Item
    {
        public string _liquidColor;
        public Drink(int id, string liquidColor) : base(id)
        {
            _liquidColor = liquidColor;
        }

        public Drink(int id, string name, string liquidColor) : base(id, name)
        {
            _liquidColor = liquidColor;
        }

        public string LiquidColor
        {
            get { return _liquidColor; }
            set { _liquidColor = value; }
        }

    }
}
