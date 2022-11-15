using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._2022
{
    internal class Pen
    {
        public string color;
        public double len;
        public void Print()
        {
            string str;
            str = "Pen color is: " + color + " pen length is: " + len.ToString();
            Console.WriteLine(str);
        }

        public Pen(string color)
        {
            this.color = color;
        }

        public void SetRandonSize()
        {
            Random t = new Random();
            this.len = t.Next(10,26);
        }
    }
}
