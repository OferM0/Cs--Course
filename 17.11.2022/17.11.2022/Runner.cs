using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using RandomNum;

namespace _17._11._2022
{
    internal class Runner
    {
        /*
        public void Use()
        {
            Helper h1 = new Helper();
            YarinsClass y1 = new YarinsClass();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(h1.RetRand().ToString() + h1.RetString());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(y1.randomNumGenerator().ToString() + y1.punchLine());
            }
        }
        */
        public void Use2() //homeWork
        {
            Item[] list = new Item[2]; //list of 2 items
            Item[] list2 = new Item[10]; //list of 10 items
            Item[] list3 = new Item[100]; //list of 100 items

            Drink d1 = new Drink(1, "red"); 
            Food f1 = new Food(2, 30);
            list[0] = d1;                    //assign values to 2 places array
            list[1] = f1;
            list[0].Name = "strawberry";
            list[0].Price = 8;
            list[1].Price = 20;
            list[1].Name = "cheese";
            //Console.WriteLine("d1: {0} {1} {2} f1: {3} {4} {5}", list[0].Id, list[0].Name, list[0].Price, list[1].Id, list[1].Name, list[1].Price);

            string id, name, weight, liquidColor, price;
            for (int i = 0; i < 10; i++) //assign values and choose class- first 5 are drink items, last 5 are food items
            {
                if (i < 5)
                {
                    Console.WriteLine("Please enter id of drink item");
                    id = Console.ReadLine();
                    Console.WriteLine("Please enter name of drink item");
                    name = Console.ReadLine();
                    list2[i] = new Drink(int.Parse(id), name, "liquidDrink");
                }
                else
                {
                    Console.WriteLine("Please enter id of Food item");
                    id = Console.ReadLine();
                    Console.WriteLine("Please enter name of Food item");
                    name = Console.ReadLine();
                    list2[i] = new Food(int.Parse(id), name, 10);
                }
            }

            for (int i = 0; i < 10; i++) //print id and name 
            {
                if (i < 5)
                {
                    Console.WriteLine("drink item: {0} {1} ", list2[i].Id, list2[i].Name);
                }
                else
                {
                    Console.WriteLine("food item: {0} {1} ", list2[i].Id, list2[i].Name);
                }
            }

            Random rnd = new Random();
            int randomNum;
            for (int i = 0; i < 100; i++) //assign value to items and choose class by random
            {
                randomNum= rnd.Next(1, 3);
                Console.WriteLine("Item number: " + i);
                if (randomNum == 1)
                {
                    Console.WriteLine("Please enter id of drink item");
                    id = Console.ReadLine();
                    Console.WriteLine("Please enter name of drink item");
                    name = Console.ReadLine();
                    Console.WriteLine("Please enter color of drink item");
                    liquidColor = Console.ReadLine();
                    list3[i] = new Drink(int.Parse(id), name, liquidColor);
                    Console.WriteLine("Please enter price of Food item");
                    price = Console.ReadLine();
                    list3[i].Price = int.Parse(price);
                }
                else
                {
                    Console.WriteLine("Please enter id of Food item");
                    id = Console.ReadLine();
                    Console.WriteLine("Please enter name of Food item");
                    name = Console.ReadLine();
                    Console.WriteLine("Please enter weight of Food item");
                    weight = Console.ReadLine();
                    list3[i] = new Food(int.Parse(id), name, int.Parse(weight));
                    Console.WriteLine("Please enter price of Food item");
                    price = Console.ReadLine();
                    list3[i].Price=int.Parse(price);
                }
            }

            for (int i = 0; i < 100; i++) //print only id
            {
                Console.WriteLine("item number: {0} with id: {1}", i, list3[i].Id);
            }

            for (int i = 0; i < 100; i++) //print all details using is and casting
            {
                if (list3[i] is Drink)
                {
                    Drink drink = (Drink)list3[i];
                    Console.WriteLine("Iten number: {0} is a drink item with details: id- {1} name- {2} price- {3} liquidColor- {4}", i, drink.Id, drink.Name, drink.Price, drink.LiquidColor);
                }
                else if (list3[i] is Food)
                {
                    Food food = (Food)list3[i];
                    Console.WriteLine("Iten number: {0} is a food item with details: id- {1} name- {2} price- {3} weight- {4}", i, food.Id, food.Name, food.Price, food.Weight);
                }
            }
        }
    }
}

