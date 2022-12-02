using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._11._2022WinFormsApp_TheInterface
{
    internal class Kinly:IItem
    {/*
        private int price;
        public Kinly()
        {
            price = GetPrice();
        }*/
        public int GetPrice()
        {
            return 11;
        }/*
        public int Price
        {
            get
            {
                return price;
            }
        }*/
    }
}
