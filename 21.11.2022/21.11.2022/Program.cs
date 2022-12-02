using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SingelTone.INSTANCE.Name = "Miriam";
            SingelTone.INSTANCE.Age = 23;
            SingelTone.INSTANCE.SetValues(33, "Miriam");

            Manager.INSTANCE.LoadFile("snifim.txt");
            Manager.INSTANCE.GetSnif(13,95).Print();
            Manager.INSTANCE.GetSnif(12, 169).Print();
            Manager.INSTANCE.GetSnif(17, 653).Print();
            */
            Manager2.INSTANCE.LoadTable();
            Console.ReadLine();
        }
    }
}
