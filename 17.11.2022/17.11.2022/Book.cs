using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._2022
{
    internal class Book
    {
        private static int count=0;
        private int _id;
        public string _name;

        public static Book Create(string name)
        {
            if (count < 5)
            {
                Book ret = new Book(name);
                return ret;
            }
            else
            {
                return null;
            }
            
        }
        private Book(string name)
        {
            _name = name;
            _id = GenerateNewId();
        }

        public int Id { get { return _id; } private set { _id = value; } }

        public string Name { get { return _name; } set { _name = value; } }

        private static int GenerateNewId()
        {
            count++;
            return count;
        }

        public void Print()
        {
            Console.WriteLine("id: " + this._id.ToString() + " Name: " + this.Name);
        }
    }
}
