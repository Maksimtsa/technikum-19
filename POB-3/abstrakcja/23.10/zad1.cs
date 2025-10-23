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
                double area = Math.PI * Promien;
                return area;
            }
            public override double Obwod()
            {
                double obwod = 2 * Math.PI * Promien;
                return obwod;
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
                double area = Dlugosc * Szerokosc;
                return area;
            }
            public override double Obwod()
            {
                double obwod = (Dlugosc + Szerokosc) * 2;
                return obwod;
            }
        }
        class Trojkat : Figura
        {
            public double BokA { get; set; }
            public double BokB { get; set; }
            public double BokC { get; set; }
            public double Wyssokosc { get; set; }

            public Trojkat(double bokA, double wysokosc, double bokB, double bokC)
            {
                BokA = bokA;
                BokB = bokB;
                BokC = bokC;
                Wyssokosc = wysokosc;
            }

            public override double Pole()
            {
                double area = (BokA * Wyssokosc)/2;
                return area;
            }
            public override double Obwod()
            {
                double obwod = BokA + BokB + BokC;
                return obwod;
            }
        }

        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>
            {
                new Kolo(3),
                new Prostokat(8, 4),
                new Trojkat(2, 3, 4, 5)

            };
            foreach(var items in Figura)
            {

            }
        }
    }
}
