using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30._11._2022WinFormsApp_TheInterface
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public IShape[] shapeArray = new IShape[100];
        private static int index = 0;
        public int GetBigger(IShape a, IShape b)
        {
            if (a.Vertices() > b.Vertices())
            {
                return a.Vertices();
            }
            else if (a.Vertices() < b.Vertices())
            {
                return b.Vertices();
            }
            else
            {
                return 0;
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (index < 100)
            {
                if (rectangle.Checked)
                {
                    IShape rectangleShape = new Rectangle();
                    shapeArray[index] = rectangleShape;
                    index++;
                }
                if (circle.Checked)
                {
                    IShape circleShape = new Circle();
                    shapeArray[index] = circleShape;
                    index++;
                }
                if (elipse.Checked)
                {
                    IShape elipseShape = new Elipse();
                    shapeArray[index] = elipseShape;
                    index++;
                }
                if (triangle.Checked)
                {
                    IShape triangleShape = new Triangle();
                    shapeArray[index] = triangleShape;
                    index++;
                }
                if (moon.Checked)
                {
                    IShape moonShape = new Moon();
                    shapeArray[index] = moonShape;
                    index++;
                }
            }
            else
            {
                MessageBox.Show("The shapes array can contain only 100 shapes.");
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            int sum=0;
            for (int i = 0; i < index; i++)
            {
                sum = sum + shapeArray[i].Vertices();
            }
            label1.Text = "The sum of vertices of ths shapes is: " + sum.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            index = 0;
        }
    }
    public interface IShape
    {
        string Color();
        int Thick();
        int Vertices();
        void Roll();
    }
    public class Rectangle : IShape
    {
        public int length;
        public int width;
        public string color;
        public int thick;

        public int Thick()
        {
            return thick;
        }
        public string Color()
        {
            return color;
        }
        public int Vertices()
        {
            return 4;
        }
        public void Roll()
        {
            Console.WriteLine("Rectangle is rolling");
        }
    }
    public class Circle : IShape
    {
        public int raduis;
        public string color;
        public int thick;

        public int Thick()
        {
            return thick;
        }
        public string Color()
        {
            return color;
        }
        public void Roll()
        {
            Console.WriteLine("Circle is rolling");
        }
        public int Vertices()
        {
            return 0;
        }
    }
    public class Elipse : IShape
    {
        public int radius;
        public int raduis2;
        public string color;
        public int thick;

        public int Thick()
        {
            return thick;
        }
        public string Color()
        {
            return color;
        }
        public void Roll()
        {
            Console.WriteLine("Elipse is rolling");
        }
        public int Vertices()
        {
            return 0;
        }
    }
    public class Triangle : IShape
    {
        public int width;
        public int height;
        public string color;
        public int thick;

        public int Thick()
        {
            return thick;
        }
        public string Color()
        {
            return color;
        }
        public int Vertices()
        {
            return 3;
        }
        public void Roll()
        {
            Console.WriteLine("Triangle is rolling");
        }
    }
    public class Moon : IShape
    {
        public int dictance;
        public string color;
        public int thick;

        public int Thick()
        {
            return thick;
        }
        public string Color()
        {
            return color;
        }
        public int Vertices()
        {
            return 2;
        }
        public void Roll()
        {
            Console.WriteLine("Moon is rolling");
        }
    }
}
