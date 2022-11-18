using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2022
{
    internal class Class
    {
        static void Main(string[] args)
        {
            /*
            Car c1 = new Car(1234);
            Car c2 = new Car(4242);
            Car c3 = new Car(8989);

            c1.CompanyName = "Mazda";
            c2.CompanyName = "Tesla";
            c3.CompanyName = "Nissan";

            c1.Km = 10000;
            c2.Km = 10000;
            c3.Km = 10000;

            Console.WriteLine(c1.Id.ToString() + " " + c1.Km.ToString() + " " + c1.CompanyName);

            c1.Km -= 20000;
            Console.WriteLine(c1.Id.ToString() + " " + c1.Km.ToString() + " " + c1.CompanyName);

            c1.Km = -9999;
            c1.CompanyName = "Mitzubishi";
            Console.WriteLine(c1.Id.ToString() + " " + c1.Km.ToString() + " " + c1.CompanyName);

            c1.CompanyName = "BMW";
            Console.WriteLine(c1.Id.ToString() + " " + c1.Km.ToString() + " " + c1.CompanyName);

            c1.CompanyName = "Mazda";
            Console.WriteLine(c1.Id.ToString() + " " + c1.Km.ToString() + " " + c1.CompanyName);

            Console.ReadLine();
            */
            /*
2. כתבו מחלקה של מכונית עם שדה קמ, שם פירמה , ומספר רכב.

3. לכולם ממשו בעזרת properties

4. צרו כמה מופעים מתוך main ושחקו עם הערכים.

5.בעזרת property וודאו שלא ניתן לשנות מחוץ למחלקה את שדה id

6.בעזרת property  וודאו שלא ניתן להוסיף מספר קמ שלילי 

7.בעזרת property וודאו שניתן לדרוך לא יותר מ 3 פעמים את שם הרכב.

             */

            Student s1 = new Student("207719261");
            Student s2 = new Student("377965513");
            s1.Name = "Ofer Mordehai";
            //s2.Name = "Yair Israel Mordehai";
            s1.Phone = "0528016257";
            //s2.Phone = "0531895164";
            s1.Adress = "Yigal Alon 5, Kiryat Motzkin, Israel";
            //s2.Adress = "Yigal Alon 5, Kiryat Motzkin, Israel";

            s1.Save();
            s2.Load("377965513");

            Console.WriteLine(Student.count);
            Console.ReadLine();
        }
    }
}
