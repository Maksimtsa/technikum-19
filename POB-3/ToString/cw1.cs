using System;
using System.Collections.Generic;

namespace zad
{
    internal class Program
    {
        interface IWyszukiwalne
        {
            bool Pasuje(string fraza);
        }

        public abstract class Publikacja : IWyszukiwalne
        {
            public string Tytul { get; set; }
            public int RokWydania { get; set; }

            public abstract string Opis();

            public override string ToString()
            {
                return Opis();
            }

            public abstract bool Pasuje(string fraza);
        }

        public class Ksiazka : Publikacja
        {
            public string Autor { get; set; }
            public int LiczbaStron { get; set; }

            public Ksiazka(string autor, int liczbaStron, string tytul, int rokWydania)
            {
                Autor = autor;
                LiczbaStron = liczbaStron;
                Tytul = tytul;
                RokWydania = rokWydania;
            }

            public override string Opis()
            {
                return $"Książka — Autor: {Autor}, Strony: {LiczbaStron}, Tytuł: {Tytul}, Rok: {RokWydania}";
            }

            public override bool Pasuje(string fraza)
            {
                fraza = fraza.ToLower();
                return Tytul.ToLower().Contains(fraza) || Autor.ToLower().Contains(fraza);
            }
        }

        public class Czasopismo : Publikacja
        {
            public int Numer { get; set; }
            public string MiesiecznikTygodnik { get; set; }

            public Czasopismo(int numer, string rodzaj, string tytul, int rokWydania)
            {
                Numer = numer;
                MiesiecznikTygodnik = rodzaj;
                Tytul = tytul;
                RokWydania = rokWydania;
            }

            public override string Opis()
            {
                return $"Czasopismo — Nr: {Numer}, Typ: {MiesiecznikTygodnik}, Tytuł: {Tytul}, Rok: {RokWydania}";
            }

            public override bool Pasuje(string fraza)
            {
                fraza = fraza.ToLower();
                return Tytul.ToLower().Contains(fraza) || MiesiecznikTygodnik.ToLower().Contains(fraza);
            }
        }

        public class Komiks : Publikacja
        {
            public string AutorRysunku { get; set; }

            public Komiks(string autorRysunku, string tytul, int rokWydania)
            {
                AutorRysunku = autorRysunku;
                Tytul = tytul;
                RokWydania = rokWydania;
            }

            public override string Opis()
            {
                return $"Komiks — Autor: {AutorRysunku}, Tytuł: {Tytul}, Rok: {RokWydania}";
            }

            public override bool Pasuje(string fraza)
            {
                fraza.ToLower();
                return Tytul.ToLower().Contains(fraza) || AutorRysunku.ToLower().Contains(fraza);
            }
        }

        static void Main(string[] args)
        {
            List<Publikacja> publikacje = new List<Publikacja>()
            {
                new Ksiazka("Adam Mickiewicz", 380, "Pan Tadeusz", 1894),
                new Ksiazka("Adam Mickiewicz", 500, "Quo Vadis", 1886),
                new Czasopismo(12, "Miesięcznik", "Book", 2013),
                new Czasopismo(4, "Tygodnik", "Book", 2025),
                new Komiks("Szymon Idzik", "Spider-Man", 1969),
                new Komiks("Szymon Zydel", "Batman: Year One", 1967)
            };

            Console.WriteLine("Podaj frazę do wyszukania: ");
            string fraza = Console.ReadLine();

            Console.WriteLine("Wyniki wyszukiwania:");

            foreach (var p in publikacje)
            {
                if (p.Pasuje(fraza))
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
