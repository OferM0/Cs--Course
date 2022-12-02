using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _28._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {/*1
            int num1, num2;
            Console.WriteLine("Please enter 2 numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            try
            {
                int result = num1 / num2;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine('0');
            }*/

            /*2
            int num1;
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Please enter number");
                num1 = int.Parse(Console.ReadLine());
                try
                {
                    int result = 777 / num1;
                    Console.WriteLine(result);
                    i = 1;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine('0');
                    i = 0;
                }
            }*/

            /*3
            string fileName;
            Console.WriteLine("Please enter file name");
            fileName = Console.ReadLine();
            try
            {
                StreamReader sw = new StreamReader(fileName);
                while(sw.ReadLine() is string s)
                {
                    Console.WriteLine(s);
                }
                sw.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Exception: file not found");
            }
            */


            Runner run = new Runner();
            try
            {
                Console.WriteLine("Please notice to fill the string array in a way that the general length will not cross 100 words.");
                run.Read10Strings();
            }catch
            {
                Console.WriteLine("try agian. Please notice to fill the string array in a way that the general length will not cross 100 words.");
                run.Read10Strings();
            }
            Console.ReadLine();
        }
    }
}
