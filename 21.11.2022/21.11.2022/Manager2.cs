using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _21._11._2022
{
    internal class Manager2
    {
        private Hashtable _Hashtable = new Hashtable();
        private Manager2()
        {

        }
        private static Manager2 _INSTANCE = new Manager2();
        public static Manager2 INSTANCE
        {
            get
            {
                return _INSTANCE;
            }
        }

        public void LoadTable()
        {
            int id;
            Random random = new Random(DateTime.Now.Millisecond);

            for(int i = 1; i <= 1000; i++)
            {
                id = random.Next(100, 1000);
                if (id%2==0)
                {
                    Falafel f = new Falafel(id);
                    f.Balls = random.Next(1, 6);

                    if (_Hashtable[id] is Falafel)
                    {
                    }
                    else
                    {
                        _Hashtable.Add(id, f);
                    }
                }
                else
                {
                    IceCream c = new IceCream(id);
                    c.Balls = random.Next(1, 6);

                    if (_Hashtable[id] is IceCream)
                    {
                    }
                    else
                    {
                        _Hashtable.Add(id, c);
                    }
                }
            }


            int num;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("\nPlease enter number in range of 100 - 9999 to check if exist in the table");
                num = int.Parse(Console.ReadLine());

                //in a way of interface
                if (_Hashtable[num]!=null)
                {
                    Iitem item = (Iitem)_Hashtable[num];
                    item.print();
                }

                /*
                if (_Hashtable[num] is Falafel)
                {
                    Console.WriteLine("Falafel number {0} has {1} balls", num, ((Falafel)_Hashtable[num]).Balls);
                }
                else if(_Hashtable[num] is IceCream)
                {
                    Console.WriteLine("IceCream number {0} has {1} balls", num, ((IceCream)_Hashtable[num]).Balls);
                }
                else
                {
                    Console.WriteLine("There is not icecream or falafel with this id: {0}", num);
                }*/
            }
        }
    }
}
