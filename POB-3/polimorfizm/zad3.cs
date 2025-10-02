using System;

namespace zad2
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>  = new List<int>();

        }
    }
}
