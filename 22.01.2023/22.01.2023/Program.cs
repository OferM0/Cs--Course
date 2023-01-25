using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22._01._2023
{
    public class Program
    {    
        static void Main(string[] args)
        {
            /*
            Print1 p1 = new Print1("hi");
            Print1 p2 = new Print1("shalom");

            p1.Run();
            p2.Run();
            */

            /*
            Count threadA = new Count("A", 1000, 100, false);
            Count threadB = new Count("B", 500, 100, false);
            Count threadC = new Count("C", 250, 100, false);
            */

            /*
            WriteToFiles w1 = new WriteToFiles("file1");
            WriteToFiles w2 = new WriteToFiles("file2");
            WriteToFiles w3 = new WriteToFiles("file3");
            WriteToFiles w4 = new WriteToFiles("file4");
            */

            /*
            Count threadA = new Count("A", 1000, 100, true);
            Count threadB = new Count("B", 500, 100, false);
            Count threadC = new Count("C", 250, 100, false);
            */

            ThreadRace threadRace = new ThreadRace();
            threadRace.init();
            Console.ReadLine();
        }
    }
}
