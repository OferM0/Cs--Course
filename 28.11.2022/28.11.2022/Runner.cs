using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._11._2022
{
    internal class Runner
    {
            public void Read10Strings()
            {
                string[] s = new string[10];
                string str;
                int sum = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    Console.WriteLine("Please enter string");
                    str = Console.ReadLine();
                    sum = sum + str.Length;
                    if (sum > 100)
                    {
                        throw new ArgumentException("Sum of string arrays length over 100");
                    }
                    s[i] = str;
                }
            }
    }
}
