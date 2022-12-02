using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._11._2022WinFormsApp_TheInterface
{
    internal class Class1
    {
        /*Enumeration--------------------------------
         * 
        int age;

        string days = "kuku";

        public enum WorkDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        public WorkDays work;
        public static void Run()
        {
            int id;
            WorkDays b, a;

            a = WorkDays.Sunday;
            b = WorkDays.Friday;
            WorkDays c = a;
            c = WorkDays.Tuesday;

            string SaveToFile;
            // convert Enum to String
            SaveToFile = b.ToString();
            a++;

            // convert String to Enum
            WorkDays r;
            r = (WorkDays)Enum.Parse(typeof(WorkDays), "kuku");
            a = r;

        }*/

        /*Interface--------------------------------
         * 
        public interface IMove
        {
            int Go(int km);
        }
        public class Car3 : Bycle, IMove
        {
            public int Go(int km)
            {
                return km * 100;
            }
            public void OpenWindo()
            {

            }
        }
        public class Bycle : IMove
        {
            public int Go(int km)
            {
                return km * 2;
            }

            public void MakeDingDing()
            {

            }
        }

        public class MyClass : IMove
        {
            public int Go(int km)
            {
                return km * 2;
            }
        }

        public class Interfaces
        {
            public static void Run()
            {
                IMove mo = new MyClass();
                mo.Go(45);

                Car3 car3 = new Car3();
                Bycle bycle = new Bycle();

                car3.OpenWindo();
                mo = car3;
                mo.Go(34);
                mo = bycle;

                DoWork(car3);
                DoWork(mo);
                DoWork(bycle);
            }

            public static void DoWork(IMove m)
            {
                m.Go(100);
                // Immposible to call other methods
                //m.OpenWindow();
            }
        }*/

        /* Dispose-----------------------------------------
         * 
        class kuku : IDisposable
        {
            public void Dispose()
            {

            }
        }
        class Data : IDisposable
        {
            public int Id { get; set; }
            public Data(int id)
            {
                Id = id;
            }
            public int[] arr;

            public void Alloc()
            {
                arr = new int[10];
            }

            public void Free()
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    // free forr each cell
                    arr[i] = 0;
                }
            }
            public void Dispose()
            {
                //
                Free();
                Console.WriteLine("Release the Id " + Id.ToString());
            }
        }*/
    }
}
