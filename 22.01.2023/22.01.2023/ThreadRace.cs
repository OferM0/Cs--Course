using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22._01._2023
{
    public class ThreadRace
    {
        public Race[] race;
        public ThreadRace()
        {
            race = new Race[10];

        }
        public void init()
        {
            for (int i = 0; i < race.Length; i++)
            {
                race[i] = new Race($"Car {i}");
            }
        }
    }
    public class Race
    {
        private static int km = 0;
        private string name;
        private bool stop = false;
        Thread thread;

        public int Km
        {
            get { return km; }
            set { km = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Stop
        {
            get { return stop; }
            set { stop = value; }
        }

        public Race(string name) 
        { 
            Name = name; 
            thread = new Thread(MainLoop);
            thread.Start();
        }

        public void MainLoop()
        {
            //bool stop = false;
            while (Stop == false)
            {
                Drive();
            }                
            thread.Suspend();
        }

        public void Drive()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int randNum = rnd.Next(0,101);
            Console.WriteLine($"{Name} drive more {randNum} km");
            Km = Km + randNum;
            if(Km>100)
            {
                Stop = true;            
            }
            Thread.Sleep(1000);
        }
    }
}
