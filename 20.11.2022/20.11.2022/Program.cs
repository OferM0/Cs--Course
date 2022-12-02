using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Runner runner = new Runner();

            //runner.Use();
            //runner.Use2();
            //runner.Use3();
            //runner.Use4();
            runner.Use5();


            Console.ReadLine();
        }
    }
}
