
using System;
using System.Collections.Generic;

namespace zad
{
    internal class Program
    {
        interface IGeometry
        {
            double Pole();
        }

        public abstract class Figura : IGeometry
        {
            public abstract double Pole();
            public abstract string Opis();

            public override string ToString()
            {
                return Opis();
            }
        }

        public class Kolo : Figura
        {
            public int Radius { get; set; }
            public Kolo(int radius)
            {
                Radius = radius;
                
            }
            public override double Pole()
            {
                double pole = Math.Pow(Radius, 2) * 3.14;
                return pole;
            }
            public override string Opis()
            {
                return $"Pole koła {pole}, radius {Radius}";
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
