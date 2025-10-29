using System;
using System.Collections.Generic;

namespace zad1
{
    internal class Program
    {
        abstract class Figura
        {
            public abstract double Pole();
            public abstract double Obwod();
        }

        class Kolo : Figura
        {
            public double Promien { get; set; }

            public Kolo(double promien)
            {
                Promien = promien;
            }

            public override double Pole()
            {
                return Math.PI * Math.Pow(Promien, 2);
            }

            public override double Obwod()
            {
                return 2 * Math.PI * Promien;
            }
        }
        
        class Prostokat : Figura
        {
            public double Dlugosc { get; set; }
            public double Szerokosc { get; set; }

            public Prostokat(double dlugosc, double szerokosc)
            {
                Dlugosc = dlugosc;
                Szerokosc = szerokosc;
            }

            public override double Pole()
            {
                return Dlugosc * Szerokosc;
            }

            public override double Obwod()
            {
                return 2 * (Dlugosc + Szerokosc);
            }
        }

        class Trojkat : Figura
        {
            public double BokA { get; set; }
            public double BokB { get; set; }
            public double BokC { get; set; }
            public double Wysokosc { get; set; }

            public Trojkat(double bokA, double wysokosc, double bokB, double bokC)
            {
                BokA = bokA;
                BokB = bokB;
                BokC = bokC;
                Wysokosc = wysokosc;
            }

            public override double Pole()
            {
                return (BokA * Wysokosc) / 2;
            }

            public override double Obwod()
            {
                return BokA + BokB + BokC;
            }
        }

        static void Main(string[] args)
        {
            List<Figura> figury = new List<Figura>
            {
                new Kolo(3),
                new Prostokat(8, 4),
                new Trojkat(2, 3, 4, 5)
            };

            foreach (var figura in figury)
            {
                Console.WriteLine($"Typ figury: {figura.GetType().Name}");
                Console.WriteLine($"Pole: {figura.Pole():F2}");
                Console.WriteLine($"Obwód: {figura.Obwod():F2}");
                Console.WriteLine();
            }
        }
    }
}
