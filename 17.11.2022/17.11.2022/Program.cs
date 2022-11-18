using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Runner r = new Runner();
            /*r.Use();
            */
            //Book b1 = new Book("book1"); 
            //Book b2 = new Book("book2");
            /*
            Book b1 = Book.Create("book1"); //we made the constructor private, and created create function that have
            Book b2 = Book.Create("book2"); //limit of creating only 5 books.
            Book b3 = Book.Create("book3");
            Book b4 = Book.Create("book4");
            Book b5 = Book.Create("book5");
            Book b6 = Book.Create("book6");

            b1.Print();
            b2.Print();
            b3.Print();
            b4.Print(); 
            b5.Print();
            if (b6 != null)
            {
                b6.Print();
            }
            */
            r.Use2(); //homeWork
            Console.ReadLine();
        }
    }
}
