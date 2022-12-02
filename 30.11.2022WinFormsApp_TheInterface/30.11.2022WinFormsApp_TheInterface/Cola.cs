using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._11._2022WinFormsApp_TheInterface
{
    public interface IItem
    {
        int GetPrice();
    }

    internal class Cola:IItem
    {/*
        private int price;
        public Cola()
        {
            price=GetPrice();
        }*/
        public int GetPrice()
        {
            return 10;
        }
        /*
        public int Price
        {
            get
            {
                return price;
            }
        } */  
    }
}
