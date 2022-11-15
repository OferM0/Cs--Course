using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._2022
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            /*variables types..
            int a;
            short b;
            uint c;
            Int16 d;
            Int32 e;
            Int64 f;
            char g;
            string h;
            

            
            Car subaro1 = new Car(); 

            subaro1.SetNum(123);
            subaro1.name = "Legacy";
            string s=subaro1.PrintDetails();
            Console.WriteLine(s);
            s=Console.ReadLine();
            Console.WriteLine("Shalom " + s);
            Console.ReadLine();*/

            /*from string to other types use .parse
            int a;
            float b;
            bool c;
            string str="12";

            a=int.Parse(str);
            b=float.Parse("1.1");
            c = bool.Parse("true");
            
            
            //1
            string str;
            str = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(str);
            }
            //Console.ReadLine();

            //2
            int num;
            string str2;

            Console.WriteLine("Please insert number:");
            str2 = Console.ReadLine();
            num = int.Parse(str2);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(str);
            }
            
            //3
            string str3;
            string str4="";
            str3 = Console.ReadLine();
            for (int i = 0; i < num; i++)
            {
                str4 = str4 + str3;
            }
            Console.WriteLine(str4);
            Console.ReadLine();
            
            //4
            Pen p1= new Pen("black");      
            p1.len = 1;
            p1.Print();

            
            Pen p2 = new Pen("blue");
            p2.len = 0.5;
            p2.Print();

            Pen p3 = new Pen("white");
            p3.len = 0.75;
            p3.Print();
            
            
            //5
            Random r = new Random();
            int num;

            Console.WriteLine("Please insert number:");
            string s = Console.ReadLine(); 
            num=int.Parse(s);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(r.Next(100));
            }

            //6,7,8
            Random t = new Random();
            int cnt=0;

            for (int i = 0; i < 1000; i++)
            {
                num = t.Next(99, 999);
                Console.WriteLine(num);
                if(num>500)
                {
                    cnt++;
                }
            }
            Console.WriteLine("Cnt of numbers upper 500:"+ cnt);
            Console.WriteLine("Cnt of numbers under 500:" + (10-cnt));
            

            //9
            Pen p4 = new Pen("black");
            p4.SetRandonSize();
            p4.Print();
*/
            //10
            int number;
            Pen[] PenArr= new Pen[1000];
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                number=rnd.Next(1,4);
                if(number==1)
                {
                    PenArr[i] = new Pen("red");
                }else if (number == 2)
                {
                    PenArr[i] = new Pen("black");
                }
                else
                {
                    PenArr[i] = new Pen("blue");
                }
                PenArr[i].SetRandonSize();
                PenArr[i].Print();
            }

            //11
            PenBooster pb1 = new PenBooster(PenArr);
            pb1.PrintBlack();
            pb1.PrintBlue();
            pb1.PrintRed();

            Console.ReadLine();
        }
    }
}
