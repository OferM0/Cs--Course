using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._2022
{
    internal class PenBooster
    {
        private Pen[] PenArray;
        public PenBooster(Pen[] PenArr)
        {
            this.PenArray = PenArr;
        }

        public void PrintBlue()
        {
            for (int i = 0; i < this.PenArray.Length; i++)
            {
                if (this.PenArray[i].color == "blue")
                {
                    string str;
                    str = "Pen color is: " + this.PenArray[i].color + " pen length is: " + this.PenArray[i].len.ToString();
                    Console.WriteLine(str);
                }
            }
        }

        public void PrintRed()
        {
            for (int i = 0; i < this.PenArray.Length; i++)
            {
                if (this.PenArray[i].color == "red")
                {
                    string str;
                    str = "Pen color is: " + this.PenArray[i].color + " pen length is: " + this.PenArray[i].len.ToString();
                    Console.WriteLine(str);
                }
            }
        }

        public void PrintBlack()
        {
            for (int i = 0; i < this.PenArray.Length; i++)
            {
                if (this.PenArray[i].color == "black")
                {
                    string str;
                    str = "Pen color is: " + this.PenArray[i].color + " pen length is: " + this.PenArray[i].len.ToString();
                    Console.WriteLine(str);
                }
            }
        }
    }
}
